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
        public NfeConsulta2Client.nfeCabecMsg nfeCabecMsg;

      
        [MessageBodyMember]
        public XmlNode nfeDadosMsg;

        public nfeConsultaNF2Request()
        {
        }

        public nfeConsultaNF2Request(NfeConsulta2Client.nfeCabecMsg nfeCabecMsg, XmlNode nfeDadosMsg)
        {
            this.nfeCabecMsg = nfeCabecMsg;
            this.nfeDadosMsg = nfeDadosMsg;
        }

        public nfeConsultaNF2Request(String cUf, String vDados, XmlNode nfeDadosMsg)
            : this(new NfeConsulta2Client.nfeCabecMsg(cUf, vDados), nfeDadosMsg)
        {
        }
    }

    [MessageContract(IsWrapped = false)]
    public class nfeConsultaNF2Response
    {

        [MessageHeader]
        public NfeConsulta2Client.nfeCabecMsg nfeCabecMsg;

        [MessageBodyMember]
        public XmlNode nfeConsultaNF2Result;

        public nfeConsultaNF2Response()
        {
        }

        public nfeConsultaNF2Response(NfeConsulta2Client.nfeCabecMsg nfeCabecMsg, XmlNode nfeConsultaNF2Result)
        {
            this.nfeCabecMsg = nfeCabecMsg;
            this.nfeConsultaNF2Result = nfeConsultaNF2Result;
        }
    }

    public class NfeConsulta2Client : ClientBase<INfeConsulta2>, INfeConsulta2, INfeConsultaProtocoloCliente
    {
        public NfeConsulta2Client(X509Certificate2 certificado, String url)
            : base(new BasicHttpBinding( BasicHttpSecurityMode.Transport) , new EndpointAddress(url))
        {
            this.ClientCredentials.ClientCertificate.Certificate = certificado;
            var binding = this.Endpoint.Binding as BasicHttpBinding;
            binding.Security.Transport.ClientCredentialType = HttpClientCredentialType.Certificate;
        }


        public nfeConsultaNF2Response nfeConsultaNF2(nfeConsultaNF2Request request)
        {
            return base.Channel.nfeConsultaNF2(request);
        }

        public Task<nfeConsultaNF2Response> nfeConsultaNF2Async(nfeConsultaNF2Request request)
        {
            return base.Channel.nfeConsultaNF2Async(request);
        }

        public async Task<XmlNode> ConsultarProtocolo(String cUf, String vDados, XmlNode nfeDadosMsg)
        {
            var resposta = await nfeConsultaNF2Async(new nfeConsultaNF2Request(cUf, vDados, nfeDadosMsg));
            return resposta.nfeConsultaNF2Result;
        }

        [Serializable]
        public class nfeCabecMsg
        {

            [XmlElement(Order = 0)]
            public string cUF { get; set; }

            [XmlElement(Order = 1)]
            public string versaoDados { get; set; }

            public nfeCabecMsg(String cUf, String vDados)
            {
                cUF = cUf;
                versaoDados = vDados;
            }

            public nfeCabecMsg()
            {
            }
        }
    }
}
