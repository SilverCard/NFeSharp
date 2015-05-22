using NFeSharp.Esquemas.TiposBasicos;
using NFeSharp.Utils;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services.Protocols;

namespace NFeSharp.Servicos
{
    /// <summary>
    /// Essa classe fornece acesso ao serviços dos autorizadores
    /// </summary>
    public class ClienteNFe
    {
        public X509Certificate Certificado { get; private set; }
        public Autorizadores Autorizadores { get; private set; }
        public TAmb TipoAmbiente { get; private set; }

        public ClienteNFe(X509Certificate certificado, Autorizadores autorizadores, TAmb tipoAmbiente)
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

        public NFeSharp.Esquemas.v1_00.retDistDFeInt nfeDistDFeInteresse(NFeSharp.Esquemas.v1_00.distDFeInt param)
        {   
            String url = this.PegarUrlServico(IdentificadorServicos.NFeDistribuicaoDFe, (UnidadesFederativas)param.cUFAutor, VersaoServico.v1_00, false);
            var ws = new NFeDistribuicaoDFe(url, Certificado);
            var msg = XmlUtils.SerializeToXml<NFeSharp.Esquemas.v1_00.distDFeInt>(param);
            var response = ws.nfeDistDFeInteresse(msg);
            return XmlUtils.Deserialize<NFeSharp.Esquemas.v1_00.retDistDFeInt>(response);
        }

        public NFeSharp.Esquemas.v3_10.retConsSitNFe NfeConsulta2(String chaveAcesso)
        {
            int cUF = NFeUtils.PegarCodigoUFChaveAcesso(chaveAcesso);
            String url = this.PegarUrlServico(IdentificadorServicos.NfeConsultaProtocolo, (UnidadesFederativas)cUF, VersaoServico.v3_10, false);
            NFeSharp.Esquemas.v3_10.consSitNFe param = new NFeSharp.Esquemas.v3_10.consSitNFe();
            param.chNFe = chaveAcesso;
            param.tpAmb = this.TipoAmbiente;
            var ws = new NfeConsulta2(url, Certificado);
            ws.Cabecalho.cUF = cUF;
            ws.Cabecalho.versaoDados = "3.10";
            var msg = XmlUtils.SerializeToXml<NFeSharp.Esquemas.v3_10.consSitNFe>(param);
            var response = ws.nfeConsultaNF2(msg);
            return XmlUtils.Deserialize<NFeSharp.Esquemas.v3_10.retConsSitNFe>(response);
        }

        /// <summary>
        /// Pega a url do serviço para determinada UF.
        /// </summary>
        /// <param name="servico">Identificado do serviço</param>
        /// <param name="uf">UF</param>
        /// <param name="versaoServico">Versão do serviço</param>
        /// <param name="contigencia">True para contigência, false caso contrário</param>
        /// <returns>Url do serviço</returns>
        [DebuggerStepThrough]
        public String PegarUrlServico(IdentificadorServicos servico, UnidadesFederativas uf, VersaoServico versaoServico, Boolean contigencia)
        {
            Autorizador autorizador = Autorizadores.ColecaoAutorizadores.FirstOrDefault(x => x.Utilizadores.Contains(uf) && x.Contigencia == contigencia && x.Servicos.Any(y => y.Nome == servico));

            if (autorizador == null)
            {
                throw new Exception(String.Format("Nenhum autorizador encontrado para o serviço \"{0}\" {1} na UF \"{2}\".", servico, versaoServico, uf ));
            }

            var ws = autorizador.Servicos.FirstOrDefault(x => x.Nome == servico && x.Versao == versaoServico);

            if (ws == null)
            {
                throw new Exception(String.Format("Nenhum serviço foi encontrado para o autorizador \"{0}.\"", autorizador.ID));

            }

            return ws.Url;
        }
    }
}
