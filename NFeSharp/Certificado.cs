using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace NFeSharp
{
    public class Certificado
    {
        public String CnpjBaseCpf { get; set; }
        internal X509Certificate CertificadoInterno { get; private set; }

        public Certificado(String nDocumento, X509Certificate certificado)
        {
            Iniciar(nDocumento, certificado);
        }

        public Certificado(String nDocumento, String caminhoCertificado, String senha)
        {
            X509Certificate certificado = new X509Certificate(caminhoCertificado, senha);
            Iniciar(nDocumento, certificado);
        }

        internal static String CortarNumeroDocumento(String nDocumento)
        {
            if (String.IsNullOrEmpty(nDocumento))
            {
                throw new ArgumentNullException("nDocumento");
            }
            else if (nDocumento.Length == 14)
            {
                return nDocumento.Substring(0, 8);
            }
            else if (nDocumento.Length == 11 || nDocumento.Length == 8)
            {
                return nDocumento;
            }

            throw new Exception("nDocumento inválido, ele deve possuir 8, 11 ou 14 caracteres.");
        }

        private void Iniciar(String nDocumento, X509Certificate certificado)
        {
            CnpjBaseCpf = CortarNumeroDocumento(nDocumento);
            CertificadoInterno = certificado;
        }
    }
}
