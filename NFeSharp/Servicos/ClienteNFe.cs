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
    public class ClienteNFe
    {
        public Certificados Certificados { get; private set; }
        public Autorizadores Autorizadores { get; private set; }
        public TAmb TipoAmbiente { get; private set; }

        public ClienteNFe(Certificados certificados, Autorizadores autorizadores, TAmb tipoAmbiente)
        {
            Certificados = certificados;
            Autorizadores = autorizadores;
            TipoAmbiente = tipoAmbiente;
        }

        public NFeSharp.Esquemas.v1_00.retDistDFeInt nfeDistDFeInteresse(NFeSharp.Esquemas.v1_00.distDFeInt param)
        {            
            var ws = new NFeDistribuicaoDFe();
            AdicionarCertificadoServico(ws, param.CnpjCpf);
            ws.Url = this.PegarUrlServico(IdentificadorServicos.NFeDistribuicaoDFe, (UnidadesFederativas)param.cUFAutor, VersaoServico.v1_00, false);
            var msg = XmlUtils.SerializeToXml<NFeSharp.Esquemas.v1_00.distDFeInt>(param);
            var response = ws.nfeDistDFeInteresse(msg);
            return XmlUtils.Deserialize<NFeSharp.Esquemas.v1_00.retDistDFeInt>(response);
        }

        private void AdicionarCertificadoServico(SoapHttpClientProtocol servico, String nDocumento)
        {
            Certificado certificado = Certificados.PegarCertificado(nDocumento);

            if(certificado == null)
            {
                throw new Exception(String.Format("Nenhuma certificado encontrado para {0}.", nDocumento));
            }

            servico.ClientCertificates.Add(certificado.CertificadoInterno);
        }

        public NFeSharp.Esquemas.v3_10.TRetConsSitNFe NfeConsulta2(String chaveAcesso)
        {
            NFeSharp.Esquemas.v3_10.TConsSitNFe param = new NFeSharp.Esquemas.v3_10.TConsSitNFe();
            param.chNFe = chaveAcesso;
            param.tpAmb = this.TipoAmbiente;
            var ws = new NfeConsulta2();
            ws.ClientCertificates.Add(Certificados.PegarPrimeiroCertificado().CertificadoInterno);
            ws.Cabecalho.cUF = NFeUtils.PegarCodigoUFChaveAcesso(param.chNFe);
            ws.Cabecalho.versaoDados = "3.10";
            ws.Url = this.PegarUrlServico(IdentificadorServicos.NfeConsultaProtocolo, (UnidadesFederativas)ws.Cabecalho.cUF, VersaoServico.v3_10, false);
            var msg = XmlUtils.SerializeToXml<NFeSharp.Esquemas.v3_10.TConsSitNFe>(param);
            var response = ws.nfeConsultaNF2(msg);
            return XmlUtils.Deserialize<NFeSharp.Esquemas.v3_10.TRetConsSitNFe>(response);
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
                throw new Exception("Nenhum autorizador encontrado.");
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
