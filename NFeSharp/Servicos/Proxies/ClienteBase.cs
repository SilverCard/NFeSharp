﻿using System;
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
        public ClienteBase(VersaoSoap versao, X509Certificate2 certificado, String url )
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

            if(versao == VersaoSoap.v1_1)
            {
                Endpoint.Binding = FactorySoap11Binding();
            }
            else
            {
                Endpoint.Binding = FactorySoap12Binding();
            }

            Endpoint.EndpointBehaviors.Add(new NFeSharp.Servicos.Proxies.nfeCabecMsgFixerBehavior());
            Endpoint.Address = new EndpointAddress(url);
            ClientCredentials.ClientCertificate.Certificate = certificado;
        }

        private BasicHttpBinding FactorySoap11Binding()
        {
            var binding = new BasicHttpBinding(BasicHttpSecurityMode.Transport);
            binding.Security.Transport.ClientCredentialType = HttpClientCredentialType.Certificate;
            return binding;
        }

        private WSHttpBinding FactorySoap12Binding()
        {
            var binding = new WSHttpBinding(SecurityMode.Transport);
            binding.Security.Transport.ClientCredentialType = HttpClientCredentialType.Certificate;
            return binding;
        }

        public enum VersaoSoap
        {
            v1_1,
            v1_2,
        }
    }
}