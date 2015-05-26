using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;

namespace NFeSharp.Servicos
{
    public abstract class ClienteBase<TChannel> : ClientBase<TChannel> where TChannel : class
    {
        private const int _MaxReceivedMessageSize = 1024 * 1024;

        public ClienteBase(X509Certificate2 certificado, String url )
            : base(new ServiceEndpoint(ContractDescription.GetContract(typeof(TChannel))))
        {
            if(certificado == null)
            {
                throw new ArgumentNullException("certificado");
            }
            if (String.IsNullOrWhiteSpace(url))
            {
                throw new ArgumentNullException("url");
            }

            Endpoint.Binding = FactorySoap12Binding();
            Endpoint.EndpointBehaviors.Add(new NFeSharp.Servicos.Proxies.nfeCabecMsgFixerBehavior());
            Endpoint.Address = new EndpointAddress(url);
            ClientCredentials.ClientCertificate.Certificate = certificado;
        }

        private CustomBinding FactorySoap12Binding()
        {
            var binding = new CustomBinding();
          
            var httpsb = new HttpsTransportBindingElement();
            httpsb.RequireClientCertificate = true;
            httpsb.MaxReceivedMessageSize = _MaxReceivedMessageSize;

            var tmb = new TextMessageEncodingBindingElement(MessageVersion.Soap12, Encoding.UTF8);            

            // o HttpTransportBindingElement precisa aparecer por último.
            binding.Elements.Add(tmb);
            binding.Elements.Add(httpsb);
            return binding;
        }
    }
}
