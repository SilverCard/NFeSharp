using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml;
using System.Xml.Serialization;

namespace NFeSharp.Servicos
{

    [WebServiceBinding(Name = "NfeConsulta2Soap", Namespace = "http://www.portalfiscal.inf.br/nfe/wsdl/NfeConsulta2")]
    public class NfeConsulta2 : ServicoBase
    {
        public nfeCabecMsg Cabecalho { get; set; }

        public NfeConsulta2(String url, X509Certificate certificado) : base(url, certificado)
        {
            this.SoapVersion = SoapProtocolVersion.Soap12;
            Cabecalho = new nfeCabecMsg();
        } 


        [SoapHeader("Cabecalho", Direction = System.Web.Services.Protocols.SoapHeaderDirection.InOut)]
        [SoapDocumentMethod("http://www.portalfiscal.inf.br/nfe/wsdl/NfeConsulta2/nfeConsultaNF2", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Bare)]
        [return: XmlElement(Namespace = "http://www.portalfiscal.inf.br/nfe/wsdl/NfeConsulta2")]
        public System.Xml.XmlNode nfeConsultaNF2([System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe/wsdl/NfeConsulta2")] System.Xml.XmlNode nfeDadosMsg)
        {
            
            object[] results = this.Invoke("nfeConsultaNF2", new object[] { nfeDadosMsg});
            return ((System.Xml.XmlNode)(results[0]));
        }

        [Serializable]
        [XmlType(Namespace = "http://www.portalfiscal.inf.br/nfe/wsdl/NfeConsulta2")]
        [XmlRoot(Namespace = "http://www.portalfiscal.inf.br/nfe/wsdl/NfeConsulta2", IsNullable = false)]
        public class nfeCabecMsg : System.Web.Services.Protocols.SoapHeader
        {

            /// <remarks/>
            public int cUF { get; set; }

            /// <remarks/>
            public string versaoDados { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlAnyAttributeAttribute()]
            public System.Xml.XmlAttribute[] AnyAttr { get; set; }

        }

    }
}
