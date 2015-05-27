using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace NFeSharp.Servicos.Proxies
{
    [MessageContract(IsWrapped = false)]
    public class nfeConsultaNF2Request
    {      
        [MessageHeader]
        public nfeCabecMsg nfeCabecMsg;
      
        [MessageBodyMember]
        public XmlNode nfeDadosMsg;

        public nfeConsultaNF2Request(String cUf, String vDados, XmlNode nfeDadosMsg, String _namespace)
        {
            this.nfeCabecMsg = new nfeCabecMsg(cUf, vDados, _namespace);
            this.nfeDadosMsg = nfeDadosMsg;
        }
    }

    [MessageContract(IsWrapped = false)]
    public class nfeConsultaNF2Response
    {
        [MessageHeader]
        public nfeCabecMsg nfeCabecMsg;

        [MessageBodyMember]
        public XmlNode nfeConsultaNF2Result;
    }

    /// <summary>
    /// Proxy WCF para o serviço NfeConsultaProtocolo
    /// </summary>
    public class NfeConsulta2Cliente : ClienteBase<INfeConsulta2>, INfeConsulta2, INfeConsultaProtocoloCliente
    {
        public const String Namespace = "http://www.portalfiscal.inf.br/nfe/wsdl/NfeConsulta2";

        public NfeConsulta2Cliente(X509Certificate2 certificado, String url)
            : base(certificado, url )
        {
        }

        public nfeConsultaNF2Response nfeConsultaNF2(nfeConsultaNF2Request request)
        {
            return base.Channel.nfeConsultaNF2(request);
        }

        public Task<nfeConsultaNF2Response> nfeConsultaNF2Async(nfeConsultaNF2Request request)
        {
            return base.Channel.nfeConsultaNF2Async(request);
        }

        public async Task<XmlNode> ConsultarProtocoloAsync(String cUf, String vDados, XmlNode nfeDadosMsg)
        {
            var resposta = await nfeConsultaNF2Async(new nfeConsultaNF2Request(cUf, vDados, nfeDadosMsg, NfeConsulta2Cliente.Namespace));
            return resposta.nfeConsultaNF2Result;
        }
    }


}
