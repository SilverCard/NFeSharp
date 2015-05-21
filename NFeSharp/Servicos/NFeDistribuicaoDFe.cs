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
    [WebServiceBinding(Name = "NFeDistribuicaoDFeSoap", Namespace = "http://www.portalfiscal.inf.br/nfe/wsdl/NFeDistribuicaoDFe")]
    public class NFeDistribuicaoDFe : SoapHttpClientProtocol
    { 
        [SoapDocumentMethod("http://www.portalfiscal.inf.br/nfe/wsdl/NFeDistribuicaoDFe/nfeDistDFeInteresse", RequestNamespace = "http://www.portalfiscal.inf.br/nfe/wsdl/NFeDistribuicaoDFe", ResponseNamespace = "http://www.portalfiscal.inf.br/nfe/wsdl/NFeDistribuicaoDFe", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Xml.XmlNode nfeDistDFeInteresse(System.Xml.XmlNode nfeDadosMsg)
        {
            object[] results = this.Invoke("nfeDistDFeInteresse", new object[] {
                    nfeDadosMsg});
            return ((System.Xml.XmlNode)(results[0]));
        }
    }
}
