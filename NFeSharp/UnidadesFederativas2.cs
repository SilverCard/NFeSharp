using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NFeSharp
{
    /// <summary>
    /// Enumeração contendo as Unidades Federativas do Brasil, associadas ao seu respectivo código do IBGE.
    /// </summary>
    public enum UnidadesFederativas2 : int
    {
        // Região Norte      
        RO = 11,
        AC = 12,
        AM = 13,
        RR = 14,
        PA = 15,
        AP = 16,
        TO = 17,

        // Região Nordeste
        MA = 21,
        PI = 22,
        CE = 23,
        RN = 24,
        PB = 25,
        PE = 26,
        AL = 27,
        SE = 28,
        BA = 29,

        // Região Sudeste
        MG = 31,
        ES = 32,
        RJ = 33,
        SP = 35,

        // Região Sul
        PR = 41,
        SC = 42,
        RS = 43,

        // Região Centro-Oeste
        MS = 50,
        MT = 51,
        GO = 52,
        DF = 53,

    }
}
