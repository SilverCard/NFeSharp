using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NFeSharp.Servicos
{
    public enum VersaoServico
    {
        [XmlEnum("1.00")]
        v1_00,
        [XmlEnum("1.01")]
        v1_01,
        [XmlEnum("2.00")]
        v2_00,
        [XmlEnum("3.10")]
        v3_10,
    }
}
