using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace NFeSharp.Servicos.Proxies
{
    [MessageContract(IsWrapped = false)]
    public class nfeConsultaNFRequest
    {
        [MessageHeader(Namespace = "http://www.portalfiscal.inf.br/nfe/wsdl/NfeConsulta3")]
        public nfeCabecMsg nfeCabecMsg;

        [MessageBodyMember]
        public XmlNode nfeDadosMsg;

        public nfeConsultaNFRequest(String cUf, String vDados, XmlNode nfeDadosMsg, String _namespace)
        {
            this.nfeCabecMsg = new nfeCabecMsg(cUf, vDados, _namespace);
            this.nfeDadosMsg = nfeDadosMsg;
        }
    }


    [MessageContract(IsWrapped = false)]
    public class nfeConsultaNFResponse
    {

        [MessageHeader(Namespace = "http://www.portalfiscal.inf.br/nfe/wsdl/NfeConsulta3")]
        public nfeCabecMsg nfeCabecMsg;

        [MessageBodyMember]
        public System.Xml.XmlNode nfeConsultaNFResult;

    }

    public class NfeConsulta3Client : ClienteBase<INfeConsulta3>, INfeConsulta3, INfeConsultaProtocoloCliente
    {
        public const String Namespace = "http://www.portalfiscal.inf.br/nfe/wsdl/NfeConsulta2";

        public NfeConsulta3Client(X509Certificate2 certificado, String url)
            :  base( VersaoSoap.v1_2 , certificado, url )
        {          
        }

        public nfeConsultaNFResponse nfeConsultaNF(nfeConsultaNFRequest request)
        {       
            return base.Channel.nfeConsultaNF(request);
        }

        public Task<nfeConsultaNFResponse> nfeConsultaNFAsync(nfeConsultaNFRequest request)
        {
            return base.Channel.nfeConsultaNFAsync(request);
        }

        public async Task<XmlNode> ConsultarProtocoloAsync(String cUf, String vDados, XmlNode nfeDadosMsg)
        {
            var resposta = await nfeConsultaNFAsync(new nfeConsultaNFRequest(cUf, vDados, nfeDadosMsg, NfeConsulta3Client.Namespace));
            return resposta.nfeConsultaNFResult;
        }       


    }
}
