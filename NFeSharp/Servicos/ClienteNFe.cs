using NFeSharp.Esquemas.TiposBasicos;
using NFeSharp.Servicos.Proxies;
using NFeSharp.Utils;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services.Protocols;
using System.Xml;

namespace NFeSharp.Servicos
{
    /// <summary>
    /// Essa classe fornece acesso ao serviços dos autorizadores
    /// </summary>
    public class ClienteNFe
    {
        public X509Certificate2 Certificado { get; private set; }
        public Autorizadores Autorizadores { get; private set; }
        public TAmb TipoAmbiente { get; private set; }

        public ClienteNFe(X509Certificate2 certificado, Autorizadores autorizadores, TAmb tipoAmbiente)
        {
            if (certificado == null)
            {
                throw new ArgumentNullException("certificado");
            }

            if(autorizadores == null)
            {
                throw new ArgumentNullException("autorizadores");
            }

            Certificado = certificado;
            Autorizadores = autorizadores;
            TipoAmbiente = tipoAmbiente;
        }

        public async Task<NFeSharp.Esquemas.v1_00.retDistDFeInt> NFeDistribuicaoDFeAsync(NFeSharp.Esquemas.v1_00.distDFeInt param)
        {
            if(param == null)
            {
                throw new ArgumentNullException("param");
            }

            String url = this.PegarUrlServico(IdentificadorServicos.NFeDistribuicaoDFe, (UnidadesFederativas)param.cUFAutor, VersaoServico.v1_00, false);
            var msg = XmlUtils.SerializeToXml<NFeSharp.Esquemas.v1_00.distDFeInt>(param);
            var request = new nfeDistDFeInteresseRequest()
            {
                nfeDadosMsg = msg
            };
            var cliente = new NFeDistribuicaoDFeCliente(Certificado, url);
            var response = await cliente.nfeDistDFeInteresseAsync(request);
            cliente.Close();

            if (response == null)
            {
                throw new NFeSharpException("A resposta do serviço foi entendida.");
            }

            return DeserializeSeguro<NFeSharp.Esquemas.v1_00.retDistDFeInt>(response.nfeDistDFeInteresseResult);
        } 
       
        private T DeserializeSeguro<T>(XmlNode xml)
        {
            try
            {
                return XmlUtils.Deserialize<T>(xml);
            }
            catch(Exception e)
            {
                throw new NFeSharpException("Não foi possível deserializar a resposta do serviço.", e);
            }
        }

        public async Task<NFeSharp.Esquemas.v3_10.retConsSitNFe> NfeConsultaProtocoloAsync(String chaveAcesso)
        {
            if(!NFeUtils.IsChaveAcessoValida(chaveAcesso))
            {
                throw new  ArgumentException("chaveAcesso", "A Chave de Acesso é inválida");
            }

            int cUF = NFeUtils.PegarCodigoUFChaveAcesso(chaveAcesso);
            String url = this.PegarUrlServico(IdentificadorServicos.NfeConsultaProtocolo, (UnidadesFederativas)cUF, VersaoServico.v3_10, false);
            INfeConsultaProtocoloCliente cliente;

            // Correção para SEFAZ do PR.
            if(cUF == 41)
            {
                cliente = new Proxies.NfeConsulta3Cliente(this.Certificado, url);
            }
            else
            {
                cliente = new Proxies.NfeConsulta2Cliente(this.Certificado, url);
            }


            NFeSharp.Esquemas.v3_10.consSitNFe param = new NFeSharp.Esquemas.v3_10.consSitNFe()
            {
                chNFe = chaveAcesso,
                tpAmb = this.TipoAmbiente
            };

            var msg = XmlUtils.SerializeToXml<NFeSharp.Esquemas.v3_10.consSitNFe>(param);
            var respostaXml =  await cliente.ConsultarProtocoloAsync(cUF.ToString(), "3.10", msg);
            cliente.Close();

            if (respostaXml == null)
            {
                throw new NFeSharpException("A resposta do serviço não foi entendida.");
            }

            return DeserializeSeguro<NFeSharp.Esquemas.v3_10.retConsSitNFe>(respostaXml);
        }

        /// <summary>
        /// Pega a url do serviço para determinada UF.
        /// </summary>
        /// <param name="idServico">Identificado do serviço</param>
        /// <param name="uf">UF</param>
        /// <param name="versaoServico">Versão do serviço</param>
        /// <param name="contigencia">True para contigência, false caso contrário</param>
        /// <returns>Url do serviço</returns>
        [DebuggerStepThrough]
        public String PegarUrlServico(IdentificadorServicos idServico, UnidadesFederativas uf, VersaoServico versaoServico, Boolean contigencia)
        {
            Autorizador autorizador = Autorizadores.ColecaoAutorizadores.FirstOrDefault(x => x.Utilizadores.Contains(uf) && x.Contigencia == contigencia && x.Servicos.Any(y => y.Nome == idServico));

            if (autorizador == null)
            {
                throw new NFeSharpException(String.Format("Nenhum autorizador encontrado para o serviço \"{0}\" {1} na UF \"{2}\".", idServico, versaoServico, uf));
            }

            var servico = autorizador.Servicos.FirstOrDefault(x => x.Nome == idServico && x.Versao == versaoServico);

            if (servico == null)
            {
                throw new NFeSharpException(String.Format("Nenhum serviço foi encontrado para o autorizador \"{0}.\"", autorizador.ID));
            }

            return servico.Url;
        }
    }
}
