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
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [MessageContractAttribute(IsWrapped = false)]
    public class nfeConsultaNFRequest
    {

        [MessageHeader(Namespace = "http://www.portalfiscal.inf.br/nfe/wsdl/NfeConsulta3")]
        public nfeCabecMsg nfeCabecMsg;

        [System.ServiceModel.MessageBodyMemberAttribute]
        public System.Xml.XmlNode nfeDadosMsg;

        public nfeConsultaNFRequest()
        {
        }

        public nfeConsultaNFRequest(nfeCabecMsg nfeCabecMsg, System.Xml.XmlNode nfeDadosMsg)
        {
            this.nfeCabecMsg = nfeCabecMsg;
            this.nfeDadosMsg = nfeDadosMsg;
        }

        public nfeConsultaNFRequest(String cUf, String vDados, XmlNode nfeDadosMsg)
            : this(new nfeCabecMsg(cUf, vDados, NfeConsulta3Client.Namespace), nfeDadosMsg)
        {
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [MessageContractAttribute(IsWrapped = false)]
    public partial class nfeConsultaNFResponse
    {

        [MessageHeader(Namespace="http://www.portalfiscal.inf.br/nfe/wsdl/NfeConsulta3")]
        public nfeCabecMsg nfeCabecMsg;

        [MessageBodyMember]
        public System.Xml.XmlNode nfeConsultaNFResult;

        public nfeConsultaNFResponse()
        {
        }

        public nfeConsultaNFResponse(nfeCabecMsg nfeCabecMsg, System.Xml.XmlNode nfeConsultaNFResult)
        {
            this.nfeCabecMsg = nfeCabecMsg;
            this.nfeConsultaNFResult = nfeConsultaNFResult;
        }
    }

    public class NfeConsulta3Client : ClientBase<INfeConsulta3>, INfeConsulta3, INfeConsultaProtocoloCliente
    {
        public const String Namespace = "http://www.portalfiscal.inf.br/nfe/wsdl/NfeConsulta2";

        public NfeConsulta3Client(X509Certificate2 certificado, String url)
            : base(new WSHttpBinding( SecurityMode.Transport ) , new EndpointAddress(url))
        {
            this.ClientCredentials.ClientCertificate.Certificate = certificado;
            var binding = this.Endpoint.Binding as WSHttpBinding;
            binding.Security.Transport.ClientCredentialType = HttpClientCredentialType.Certificate;


        }


        public nfeConsultaNFResponse nfeConsultaNF(nfeConsultaNFRequest request)
        {
         

            return base.Channel.nfeConsultaNF(request);
        }

        public Task<nfeConsultaNFResponse> nfeConsultaNFAsync(nfeConsultaNFRequest request)
        {
            return base.Channel.nfeConsultaNFAsync(request);
        }

        public async Task<XmlNode> ConsultarProtocolo(String cUf, String vDados, XmlNode nfeDadosMsg)
        {
            var resposta = await nfeConsultaNFAsync(new nfeConsultaNFRequest(cUf, vDados, nfeDadosMsg));
            return resposta.nfeConsultaNFResult;
        }       


    }
}
