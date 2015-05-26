using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            if (!IsChaveAcessoValida(chaveAcesso))
            {
                throw new ArgumentException("Chave de acesso inválida.");
            }

            return int.Parse(chaveAcesso.Substring(0, 2));
        }

        /// <summary>
        /// Valida a Chave de Acesso de um documento fiscal.
        /// </summary>
        /// <param name="chaveAcesso">Chave de Acesso</param>
        /// <returns>verdadeiro caso a Chave de Acesso seja valida, false caso contrário.</returns>
        public static Boolean IsChaveAcessoValida(String chaveAcesso)
        {
            if (String.IsNullOrWhiteSpace(chaveAcesso) || chaveAcesso.Length != 44)
            {
                return false;
            }
            if (!Regex.IsMatch(chaveAcesso, @"^\d{44}$"))
            {
                return false;
            }

            int[] digitos = chaveAcesso.Select(x => int.Parse(x.ToString())).ToArray();
            int soma = 0, dv, m;

            for (int i = digitos.Length - 2; i >= 0; )
            {
                for (int p = 2; p <= 9 && i >= 0; p++, i--)
                {
                    soma += digitos[i] * p;
                }
            }

            m = (soma % 11);
            dv = m <= 1 ? 0 : dv = 11 - m;

            return dv == digitos.Last();
        }
    }
}
