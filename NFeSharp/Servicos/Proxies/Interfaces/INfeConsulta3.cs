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


    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe/wsdl/NfeConsulta3")]
    public interface INfeConsulta3
    {

        // CODEGEN: Generating message contract since the operation nfeConsultaNF is neither RPC nor document wrapped.
        [System.ServiceModel.OperationContractAttribute(Action = "http://www.portalfiscal.inf.br/nfe/wsdl/NfeConsulta3/nfeConsultaNF", ReplyAction = "*")]
        //[System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.XmlSerializerFormat(SupportFaults=true)]
        nfeConsultaNFResponse nfeConsultaNF(nfeConsultaNFRequest request);

        [System.ServiceModel.OperationContractAttribute(Action = "http://www.portalfiscal.inf.br/nfe/wsdl/NfeConsulta3/nfeConsultaNF", ReplyAction = "*")]
        System.Threading.Tasks.Task<nfeConsultaNFResponse> nfeConsultaNFAsync(nfeConsultaNFRequest request);
    }

}
