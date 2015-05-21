using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFeSharp.Utils
{
    public static class NFeUtils
    {
        /// <summary>
        /// Converte os dos primeiros digitos de uma chave de acesso para inteiro, que formam o código da UF
        /// </summary>
        /// <param name="chaveAcesso">Chave de Acesso</param>
        /// <returns>Código da UF</returns>
        public static int PegarCodigoUFChaveAcesso(String chaveAcesso)
        {
            if (String.IsNullOrWhiteSpace(chaveAcesso) || chaveAcesso.Length != 44)
            {
                throw new Exception("Chave de acesso inválida.");
            }

            return int.Parse(chaveAcesso.Substring(0, 2));
        }
    }
}
