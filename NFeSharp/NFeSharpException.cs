using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFeSharp
{
    public class NFeSharpException : Exception
    {
        public NFeSharpException()
            : base("Algo de errado aconteceu.") { }


        public NFeSharpException(String mensagem)
            : base(mensagem) { }

        public NFeSharpException(String mensagem, Exception innerException)
            : base(mensagem, innerException) { }
    }
}
