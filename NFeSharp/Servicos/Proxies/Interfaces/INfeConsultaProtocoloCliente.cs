using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace NFeSharp.Servicos.Proxies
{
    public interface INfeConsultaProtocoloCliente : System.ServiceModel.ICommunicationObject
    {
        Task<XmlNode> ConsultarProtocoloAsync(String cUf, String vDados, XmlNode nfeDadosMsg);
    }
}
