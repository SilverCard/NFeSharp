using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace NFeSharp.Servicos.Proxies
{
    [ServiceContract(Namespace = "http://www.portalfiscal.inf.br/nfe/wsdl/NfeConsulta2")]
    public interface INfeConsulta2
    {
        [OperationContract(Action = "http://www.portalfiscal.inf.br/nfe/wsdl/NfeConsulta2/nfeConsultaNF2", ReplyAction = "*")]
        [XmlSerializerFormat(SupportFaults = true)]
        nfeConsultaNF2Response nfeConsultaNF2(nfeConsultaNF2Request request);

        [OperationContract(Action = "http://www.portalfiscal.inf.br/nfe/wsdl/NfeConsulta2/nfeConsultaNF2", ReplyAction = "*")]
        Task<nfeConsultaNF2Response> nfeConsultaNF2Async(nfeConsultaNF2Request request);
    }
}
