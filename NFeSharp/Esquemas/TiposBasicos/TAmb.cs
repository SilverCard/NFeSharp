using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFeSharp.Esquemas.TiposBasicos
{
    /// <remarks/>
    
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TAmb
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,
    }
}
