using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace NFeSharp.Servicos.Proxies
{
    [MessageContract(IsWrapped = true, WrapperName = "nfeDistDFeInteresse", WrapperNamespace = NFeDistribuicaoDFeCliente.Namespace)]
    public partial class nfeDistDFeInteresseRequest
    {
        [MessageBodyMember]
        public XmlNode nfeDadosMsg;
    }

    [MessageContract(IsWrapped = true, WrapperName = "nfeDistDFeInteresseResponse", WrapperNamespace = NFeDistribuicaoDFeCliente.Namespace)]
    public partial class nfeDistDFeInteresseResponse
    {
         [MessageBodyMember]
         public XmlNode nfeDistDFeInteresseResult;        
    }

    public class NFeDistribuicaoDFeCliente : ClienteBase<INFeDistribuicaoDFe>, INFeDistribuicaoDFe
    {
        public const String Namespace = "http://www.portalfiscal.inf.br/nfe/wsdl/NFeDistribuicaoDFe";

        public NFeDistribuicaoDFeCliente(X509Certificate2 certificado, String url)
            :  base(certificado, url )
        {          
        }

        public nfeDistDFeInteresseResponse nfeDistDFeInteresse(nfeDistDFeInteresseRequest request)
        {
            return base.Channel.nfeDistDFeInteresse(request);
        }

        public Task<nfeDistDFeInteresseResponse> nfeDistDFeInteresseAsync(nfeDistDFeInteresseRequest request)
        {
            return base.Channel.nfeDistDFeInteresseAsync(request);
        }
    }
}
