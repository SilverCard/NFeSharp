using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFeSharp
{
    public class Certificados
    {
        private List<Certificado> _ColecaoCertificados;
        private Object _LockObject = new Object();

        public Certificados()
        {
            _ColecaoCertificados = new List<Certificado>();
        }

        public Certificados(IEnumerable<Certificado> certificados) : this()
        {
            _ColecaoCertificados.AddRange(certificados);
        }

        public void AdicionarCertificado(Certificado certificado)
        {
            lock (_LockObject)
            {
                _ColecaoCertificados.Add(certificado);
            }
        }

        public void AdicionarCertificados(IEnumerable<Certificado> certificados)
        {
            lock (_LockObject)
            {
                _ColecaoCertificados.AddRange(certificados);
            }
        }

        public void LimparCertificados()
        {
            lock (_LockObject)
            {
                _ColecaoCertificados.Clear();
            }
        }

        public Certificado PegarCertificado(String nDocumento)
        {
            lock (_LockObject)
            {
                String nDocumento2 = Certificado.CortarNumeroDocumento(nDocumento);
                return _ColecaoCertificados.FirstOrDefault(x => x.CnpjBaseCpf == nDocumento2);
            }
        }

    }
}
