using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace NFeSharp.Servicos.Proxies
{
    [ServiceContract(Namespace = "http://www.portalfiscal.inf.br/nfe/wsdl/NFeDistribuicaoDFe")]
    [XmlSerializerFormat]
    public interface INFeDistribuicaoDFe
    {
        [OperationContract(Action = "http://www.portalfiscal.inf.br/nfe/wsdl/NFeDistribuicaoDFe/nfeDistDFeInteresse", ReplyAction = "*")]
        nfeDistDFeInteresseResponse nfeDistDFeInteresse(nfeDistDFeInteresseRequest request);

        [OperationContract(Action = "http://www.portalfiscal.inf.br/nfe/wsdl/NFeDistribuicaoDFe/nfeDistDFeInteresse", ReplyAction = "*")]
        Task<nfeDistDFeInteresseResponse> nfeDistDFeInteresseAsync(nfeDistDFeInteresseRequest request);
    }
}
