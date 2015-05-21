using NFeSharp.Esquemas.TiposBasicos;
using System.Xml.Serialization;


namespace NFeSharp.Esquemas.v3_10
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    [System.Xml.Serialization.XmlRootAttribute("consSitNFe", Namespace = "http://www.portalfiscal.inf.br/nfe", IsNullable = false)]
    public partial class consSitNFe
    {

        /// <remarks/>
        public TAmb tpAmb;

        /// <remarks/>
        public TConsSitNFeXServ xServ;

        /// <remarks/>
        public string chNFe;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public TVerConsSitNFe versao;

        public consSitNFe()
        {
            xServ = TConsSitNFeXServ.CONSULTAR;
            versao = TVerConsSitNFe.v3_10;
        }
    }



    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TConsSitNFeXServ
    {
        CONSULTAR,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TVerConsSitNFe
    {

        /// <remarks/>
        [XmlEnum("3.10")]
        v3_10,
    }

}