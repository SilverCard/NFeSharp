using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services.Protocols;

namespace NFeSharp.Servicos
{
    public abstract class ServicoBase : SoapHttpClientProtocol
    {
        public ServicoBase(String url, X509Certificate certificado)
        {
            if(String.IsNullOrWhiteSpace(url))
            {
                throw new ArgumentNullException("url");
            }

            if(certificado == null)
            {
                throw new ArgumentNullException("certificado");
            }

            this.Url = url;
            this.ClientCertificates.Add(certificado);
        }
    }
}
