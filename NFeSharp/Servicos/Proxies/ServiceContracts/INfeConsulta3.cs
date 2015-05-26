using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using System.ServiceModel.Dispatcher;
using System.Text;
using System.Threading.Tasks;

namespace NFeSharp.Servicos.Proxies
{

    [ServiceContractAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe/wsdl/NfeConsulta3")]
    public interface INfeConsulta3
    {     
        [OperationContract(Action = "http://www.portalfiscal.inf.br/nfe/wsdl/NfeConsulta3/nfeConsultaNF", ReplyAction = "*")]
        [XmlSerializerFormat(SupportFaults=true)]
        nfeConsultaNFResponse nfeConsultaNF(nfeConsultaNFRequest request);

        [OperationContract(Action = "http://www.portalfiscal.inf.br/nfe/wsdl/NfeConsulta3/nfeConsultaNF", ReplyAction = "*")]
        Task<nfeConsultaNFResponse> nfeConsultaNFAsync(nfeConsultaNFRequest request);
    }

}
