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
    public partial class nfeConsultaNFRequest
    {

        [MessageHeader(Namespace = "http://www.portalfiscal.inf.br/nfe/wsdl/NfeConsulta3")]
        public NfeConsulta3Client.nfeCabecMsg nfeCabecMsg;

        [System.ServiceModel.MessageBodyMemberAttribute]
        public System.Xml.XmlNode nfeDadosMsg;

        public nfeConsultaNFRequest()
        {
        }

        public nfeConsultaNFRequest(NfeConsulta3Client.nfeCabecMsg nfeCabecMsg, System.Xml.XmlNode nfeDadosMsg)
        {
            this.nfeCabecMsg = nfeCabecMsg;
            this.nfeDadosMsg = nfeDadosMsg;
        }

        public nfeConsultaNFRequest(String cUf, String vDados, XmlNode nfeDadosMsg)
            : this(new NfeConsulta3Client.nfeCabecMsg(cUf, vDados), nfeDadosMsg)
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
        public NfeConsulta3Client.nfeCabecMsg nfeCabecMsg;

        [MessageBodyMember]
        public System.Xml.XmlNode nfeConsultaNFResult;

        public nfeConsultaNFResponse()
        {
        }

        public nfeConsultaNFResponse(NfeConsulta3Client.nfeCabecMsg nfeCabecMsg, System.Xml.XmlNode nfeConsultaNFResult)
        {
            this.nfeCabecMsg = nfeCabecMsg;
            this.nfeConsultaNFResult = nfeConsultaNFResult;
        }
    }

    public class NfeConsulta3Client : ClientBase<INfeConsulta3>, INfeConsulta3, INfeConsultaProtocoloCliente
    {
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
        

        /// <remarks/>

       // [Serializable]
       // [XmlType(Namespace="http://www.portalfiscal.inf.br/nfe/wsdl/NfeConsulta3", AnonymousType = true)]
        public class nfeCabecMsg : MessageHeader
        {


            public nfeCabecMsg()
            {

            }

            /// <remarks/>
          //  [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
            public string cUF { get; set; }


            public nfeCabecMsg(String cUf, String vDados)
            {
                cUF = cUf;
                versaoDados = vDados;
            }

            /// <remarks/>
           // [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
            public string versaoDados { get; set; }
            


            protected override void OnWriteHeaderContents(XmlDictionaryWriter writer, MessageVersion messageVersion)
            {
                Console.WriteLine("lol");
                writer.WriteElementString("versaoDadoss", versaoDados);
            }

            protected override void OnWriteStartHeader(XmlDictionaryWriter writer, MessageVersion messageVersion)
            {
                writer.WriteElementString("versaoDadoss", versaoDados);
            }

            public override string Name
            {
                get { return "nfeCabecMsg"; }
            }

            public override string Namespace
            {
                get { return "http://www.portalfiscal.inf.br/nfe/wsdl/NfeConsulta3"; }
            }
        }
    }
}
