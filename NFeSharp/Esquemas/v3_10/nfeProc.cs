using NFeSharp.Esquemas.TiposBasicos;
using System;
using System.Xml.Serialization;

namespace NFeSharp.Esquemas.v3_10
{

    [Serializable]
    [XmlType(Namespace = Namespaces.NFe)]
    [XmlRoot("nfeProc", Namespace = Namespaces.NFe, IsNullable = false)]
    public partial class nfeProc
    {


        public TNFe NFe{get;set;}


        public TProtNFe protNFe{get;set;}


        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string versao{get;set;}
    }



    [Serializable]


    [XmlType(Namespace = Namespaces.NFe)]
    public partial class TNFe
    {


        public TNFeInfNFe infNFe{get;set;}


        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
        public SignatureType Signature{get;set;}
    }



    [Serializable]


    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFe
    {


        public TNFeInfNFeIde ide{get;set;}


        public TNFeInfNFeEmit emit{get;set;}


        public TNFeInfNFeAvulsa avulsa{get;set;}


        public TNFeInfNFeDest dest{get;set;}


        public TLocal retirada{get;set;}


        public TLocal entrega{get;set;}


        [System.Xml.Serialization.XmlElementAttribute("autXML")]
        public TNFeInfNFeAutXML[] autXML{get;set;}


        [System.Xml.Serialization.XmlElementAttribute("det")]
        public TNFeInfNFeDet[] det{get;set;}


        public TNFeInfNFeTotal total{get;set;}


        public TNFeInfNFeTransp transp{get;set;}


        public TNFeInfNFeCobr cobr{get;set;}


        [System.Xml.Serialization.XmlElementAttribute("pag")]
        public TNFeInfNFePag[] pag{get;set;}


        public TNFeInfNFeInfAdic infAdic{get;set;}


        public TNFeInfNFeExporta exporta{get;set;}


        public TNFeInfNFeCompra compra{get;set;}


        public TNFeInfNFeCana cana{get;set;}


        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string versao{get;set;}


        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string Id{get;set;}
    }



    [Serializable]


    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeIde
    {


        public TCodUfIBGE cUF{get;set;}


        public string cNF{get;set;}


        public string natOp{get;set;}


        public TNFeInfNFeIdeIndPag indPag{get;set;}


        public TMod mod{get;set;}


        public string serie{get;set;}


        public string nNF{get;set;}


        public string dhEmi{get;set;}


        public string dhSaiEnt{get;set;}


        public TNFeInfNFeIdeTpNF tpNF{get;set;}


        public TNFeInfNFeIdeIdDest idDest{get;set;}


        public string cMunFG{get;set;}


        public TNFeInfNFeIdeTpImp tpImp{get;set;}


        public TNFeInfNFeIdeTpEmis tpEmis{get;set;}


        public string cDV{get;set;}


        public TAmb tpAmb{get;set;}


        public TFinNFe finNFe{get;set;}


        public TNFeInfNFeIdeIndFinal indFinal{get;set;}


        public TNFeInfNFeIdeIndPres indPres{get;set;}


        public TProcEmi procEmi{get;set;}


        public string verProc{get;set;}


        public string dhCont{get;set;}


        public string xJust{get;set;}


        [System.Xml.Serialization.XmlElementAttribute("NFref")]
        public TNFeInfNFeIdeNFref[] NFref{get;set;}
    }



    [Serializable]
    [XmlType(Namespace = Namespaces.NFe)]
    public enum TCodUfIBGE
    {


        [System.Xml.Serialization.XmlEnumAttribute("11")]
        Item11,


        [System.Xml.Serialization.XmlEnumAttribute("12")]
        Item12,


        [System.Xml.Serialization.XmlEnumAttribute("13")]
        Item13,


        [System.Xml.Serialization.XmlEnumAttribute("14")]
        Item14,


        [System.Xml.Serialization.XmlEnumAttribute("15")]
        Item15,


        [System.Xml.Serialization.XmlEnumAttribute("16")]
        Item16,


        [System.Xml.Serialization.XmlEnumAttribute("17")]
        Item17,


        [System.Xml.Serialization.XmlEnumAttribute("21")]
        Item21,


        [System.Xml.Serialization.XmlEnumAttribute("22")]
        Item22,


        [System.Xml.Serialization.XmlEnumAttribute("23")]
        Item23,


        [System.Xml.Serialization.XmlEnumAttribute("24")]
        Item24,


        [System.Xml.Serialization.XmlEnumAttribute("25")]
        Item25,


        [System.Xml.Serialization.XmlEnumAttribute("26")]
        Item26,


        [System.Xml.Serialization.XmlEnumAttribute("27")]
        Item27,


        [System.Xml.Serialization.XmlEnumAttribute("28")]
        Item28,


        [System.Xml.Serialization.XmlEnumAttribute("29")]
        Item29,


        [System.Xml.Serialization.XmlEnumAttribute("31")]
        Item31,


        [System.Xml.Serialization.XmlEnumAttribute("32")]
        Item32,


        [System.Xml.Serialization.XmlEnumAttribute("33")]
        Item33,


        [System.Xml.Serialization.XmlEnumAttribute("35")]
        Item35,


        [System.Xml.Serialization.XmlEnumAttribute("41")]
        Item41,


        [System.Xml.Serialization.XmlEnumAttribute("42")]
        Item42,


        [System.Xml.Serialization.XmlEnumAttribute("43")]
        Item43,


        [System.Xml.Serialization.XmlEnumAttribute("50")]
        Item50,


        [System.Xml.Serialization.XmlEnumAttribute("51")]
        Item51,


        [System.Xml.Serialization.XmlEnumAttribute("52")]
        Item52,


        [System.Xml.Serialization.XmlEnumAttribute("53")]
        Item53,
    }



    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeIdeIndPag
    {


        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,


        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,


        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,
    }



    [Serializable]
    [XmlType(Namespace = Namespaces.NFe)]
    public enum TMod
    {


        [System.Xml.Serialization.XmlEnumAttribute("55")]
        Item55,


        [System.Xml.Serialization.XmlEnumAttribute("65")]
        Item65,
    }



    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeIdeTpNF
    {


        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,


        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,
    }



    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeIdeIdDest
    {


        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,


        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,


        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,
    }



    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeIdeTpImp
    {


        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,


        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,


        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,


        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,


        [System.Xml.Serialization.XmlEnumAttribute("4")]
        Item4,


        [System.Xml.Serialization.XmlEnumAttribute("5")]
        Item5,
    }



    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeIdeTpEmis
    {


        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,


        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,


        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,


        [System.Xml.Serialization.XmlEnumAttribute("4")]
        Item4,


        [System.Xml.Serialization.XmlEnumAttribute("5")]
        Item5,


        [System.Xml.Serialization.XmlEnumAttribute("6")]
        Item6,


        [System.Xml.Serialization.XmlEnumAttribute("7")]
        Item7,


        [System.Xml.Serialization.XmlEnumAttribute("9")]
        Item9,
    }




    [Serializable]
    [XmlType(Namespace = Namespaces.NFe)]
    public enum TFinNFe
    {


        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,


        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,


        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,


        [System.Xml.Serialization.XmlEnumAttribute("4")]
        Item4,
    }



    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeIdeIndFinal
    {


        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,


        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,
    }



    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeIdeIndPres
    {


        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,


        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,


        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,


        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,


        [System.Xml.Serialization.XmlEnumAttribute("4")]
        Item4,


        [System.Xml.Serialization.XmlEnumAttribute("9")]
        Item9,
    }



    [Serializable]
    [XmlType(Namespace = Namespaces.NFe)]
    public enum TProcEmi
    {


        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,


        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,


        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,


        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,
    }



    [Serializable]


    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeIdeNFref
    {


        [System.Xml.Serialization.XmlElementAttribute("refCTe", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("refECF", typeof(TNFeInfNFeIdeNFrefRefECF))]
        [System.Xml.Serialization.XmlElementAttribute("refNF", typeof(TNFeInfNFeIdeNFrefRefNF))]
        [System.Xml.Serialization.XmlElementAttribute("refNFP", typeof(TNFeInfNFeIdeNFrefRefNFP))]
        [System.Xml.Serialization.XmlElementAttribute("refNFe", typeof(string))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public object Item{get;set;}


        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType9 ItemElementName{get;set;}
    }



    [Serializable]


    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeIdeNFrefRefECF
    {


        public TNFeInfNFeIdeNFrefRefECFMod mod{get;set;}


        public string nECF{get;set;}


        public string nCOO{get;set;}
    }



    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeIdeNFrefRefECFMod
    {


        [System.Xml.Serialization.XmlEnumAttribute("2B")]
        Item2B,


        [System.Xml.Serialization.XmlEnumAttribute("2C")]
        Item2C,


        [System.Xml.Serialization.XmlEnumAttribute("2D")]
        Item2D,
    }




    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public class TProtNFeInfProt
    {


        public TAmb tpAmb{get;set;}


        public string verAplic{get;set;}


        public string chNFe{get;set;}


        public string dhRecbto{get;set;}


        public string nProt{get;set;}


        [System.Xml.Serialization.XmlElementAttribute(DataType = "base64Binary")]
        public byte[] digVal{get;set;}


        public string cStat{get;set;}


        public string xMotivo{get;set;}


        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string Id{get;set;}
    }



    [Serializable]


    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    [System.Xml.Serialization.XmlRootAttribute("Signature", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
    public partial class SignatureType
    {


        public SignedInfoType SignedInfo{get;set;}


        public SignatureValueType SignatureValue{get;set;}


        public KeyInfoType KeyInfo{get;set;}


        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string Id{get;set;}
    }



    [Serializable]


    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public partial class SignedInfoType
    {


        public SignedInfoTypeCanonicalizationMethod CanonicalizationMethod{get;set;}


        public SignedInfoTypeSignatureMethod SignatureMethod{get;set;}


        public ReferenceType Reference{get;set;}


        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string Id{get;set;}
    }








    [Serializable]


    [XmlType(Namespace = Namespaces.NFe)]
    public partial class TVeiculo
    {


        public string placa{get;set;}


        public TUf UF{get;set;}


        public string RNTC{get;set;}
    }



    [Serializable]
    [XmlType(Namespace = Namespaces.NFe)]
    public enum TUf
    {


        AC,


        AL,


        AM,


        AP,


        BA,


        CE,


        DF,


        ES,


        GO,


        MA,


        MG,


        MS,


        MT,


        PA,


        PB,


        PE,


        PI,


        PR,


        RJ,


        RN,


        RO,


        RR,


        RS,


        SC,


        SE,


        SP,


        TO,


        EX,
    }



    [Serializable]


    [XmlType(Namespace = Namespaces.NFe)]
    public partial class TIpi
    {


        public string clEnq{get;set;}


        public string CNPJProd{get;set;}


        public string cSelo{get;set;}


        public string qSelo{get;set;}


        public string cEnq{get;set;}


        [System.Xml.Serialization.XmlElementAttribute("IPINT", typeof(TIpiIPINT))]
        [System.Xml.Serialization.XmlElementAttribute("IPITrib", typeof(TIpiIPITrib))]
        public object Item{get;set;}
    }



    [Serializable]


    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TIpiIPINT
    {


        public TIpiIPINTCST CST{get;set;}
    }



    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TIpiIPINTCST
    {


        [System.Xml.Serialization.XmlEnumAttribute("01")]
        Item01,


        [System.Xml.Serialization.XmlEnumAttribute("02")]
        Item02,


        [System.Xml.Serialization.XmlEnumAttribute("03")]
        Item03,


        [System.Xml.Serialization.XmlEnumAttribute("04")]
        Item04,


        [System.Xml.Serialization.XmlEnumAttribute("05")]
        Item05,


        [System.Xml.Serialization.XmlEnumAttribute("51")]
        Item51,


        [System.Xml.Serialization.XmlEnumAttribute("52")]
        Item52,


        [System.Xml.Serialization.XmlEnumAttribute("53")]
        Item53,


        [System.Xml.Serialization.XmlEnumAttribute("54")]
        Item54,


        [System.Xml.Serialization.XmlEnumAttribute("55")]
        Item55,
    }



    [Serializable]


    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TIpiIPITrib
    {


        public TIpiIPITribCST CST{get;set;}


        [System.Xml.Serialization.XmlElementAttribute("pIPI", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("qUnid", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("vBC", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("vUnid", typeof(string))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public string[] Items{get;set;}


        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemsChoiceType[] ItemsElementName{get;set;}


        public string vIPI{get;set;}
    }



    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TIpiIPITribCST
    {


        [System.Xml.Serialization.XmlEnumAttribute("00")]
        Item00,


        [System.Xml.Serialization.XmlEnumAttribute("49")]
        Item49,


        [System.Xml.Serialization.XmlEnumAttribute("50")]
        Item50,


        [System.Xml.Serialization.XmlEnumAttribute("99")]
        Item99,
    }



    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe", IncludeInSchema = false)]
    public enum ItemsChoiceType
    {


        pIPI,


        qUnid,


        vBC,


        vUnid,
    }



    [Serializable]


    [XmlType(Namespace = Namespaces.NFe)]
    public partial class TLocal
    {


        [System.Xml.Serialization.XmlElementAttribute("CNPJ", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("CPF", typeof(string))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public string Item{get;set;}


        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType4 ItemElementName{get;set;}


        public string xLgr{get;set;}


        public string nro{get;set;}


        public string xCpl{get;set;}


        public string xBairro{get;set;}


        public string cMun{get;set;}


        public string xMun{get;set;}


        public TUf UF{get;set;}
    }



    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe", IncludeInSchema = false)]
    public enum ItemChoiceType4
    {


        CNPJ,


        CPF,
    }



    [Serializable]


    [XmlType(Namespace = Namespaces.NFe)]
    public partial class TEndereco
    {


        public string xLgr{get;set;}


        public string nro{get;set;}


        public string xCpl{get;set;}


        public string xBairro{get;set;}


        public string cMun{get;set;}


        public string xMun{get;set;}


        public TUf UF{get;set;}


        public string CEP{get;set;}


        public Tpais cPais{get;set;}


        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool cPaisSpecified{get;set;}


        public string xPais{get;set;}


        public string fone{get;set;}
    }



    [Serializable]
    [XmlType(Namespace = Namespaces.NFe)]
    public enum Tpais
    {


        [System.Xml.Serialization.XmlEnumAttribute("132")]
        Item132,


        [System.Xml.Serialization.XmlEnumAttribute("175")]
        Item175,


        [System.Xml.Serialization.XmlEnumAttribute("230")]
        Item230,


        [System.Xml.Serialization.XmlEnumAttribute("310")]
        Item310,


        [System.Xml.Serialization.XmlEnumAttribute("370")]
        Item370,


        [System.Xml.Serialization.XmlEnumAttribute("400")]
        Item400,


        [System.Xml.Serialization.XmlEnumAttribute("418")]
        Item418,


        [System.Xml.Serialization.XmlEnumAttribute("434")]
        Item434,


        [System.Xml.Serialization.XmlEnumAttribute("477")]
        Item477,


        [System.Xml.Serialization.XmlEnumAttribute("531")]
        Item531,


        [System.Xml.Serialization.XmlEnumAttribute("590")]
        Item590,


        [System.Xml.Serialization.XmlEnumAttribute("639")]
        Item639,


        [System.Xml.Serialization.XmlEnumAttribute("647")]
        Item647,


        [System.Xml.Serialization.XmlEnumAttribute("655")]
        Item655,


        [System.Xml.Serialization.XmlEnumAttribute("698")]
        Item698,


        [System.Xml.Serialization.XmlEnumAttribute("728")]
        Item728,


        [System.Xml.Serialization.XmlEnumAttribute("736")]
        Item736,


        [System.Xml.Serialization.XmlEnumAttribute("779")]
        Item779,


        [System.Xml.Serialization.XmlEnumAttribute("809")]
        Item809,


        [System.Xml.Serialization.XmlEnumAttribute("817")]
        Item817,


        [System.Xml.Serialization.XmlEnumAttribute("833")]
        Item833,


        [System.Xml.Serialization.XmlEnumAttribute("850")]
        Item850,


        [System.Xml.Serialization.XmlEnumAttribute("876")]
        Item876,


        [System.Xml.Serialization.XmlEnumAttribute("884")]
        Item884,


        [System.Xml.Serialization.XmlEnumAttribute("906")]
        Item906,


        [System.Xml.Serialization.XmlEnumAttribute("930")]
        Item930,


        [System.Xml.Serialization.XmlEnumAttribute("973")]
        Item973,


        [System.Xml.Serialization.XmlEnumAttribute("981")]
        Item981,


        [System.Xml.Serialization.XmlEnumAttribute("0132")]
        Item0132,


        [System.Xml.Serialization.XmlEnumAttribute("0175")]
        Item0175,


        [System.Xml.Serialization.XmlEnumAttribute("0230")]
        Item0230,


        [System.Xml.Serialization.XmlEnumAttribute("0310")]
        Item0310,


        [System.Xml.Serialization.XmlEnumAttribute("0370")]
        Item0370,


        [System.Xml.Serialization.XmlEnumAttribute("0400")]
        Item0400,


        [System.Xml.Serialization.XmlEnumAttribute("0418")]
        Item0418,


        [System.Xml.Serialization.XmlEnumAttribute("0434")]
        Item0434,


        [System.Xml.Serialization.XmlEnumAttribute("0477")]
        Item0477,


        [System.Xml.Serialization.XmlEnumAttribute("0531")]
        Item0531,


        [System.Xml.Serialization.XmlEnumAttribute("0590")]
        Item0590,


        [System.Xml.Serialization.XmlEnumAttribute("0639")]
        Item0639,


        [System.Xml.Serialization.XmlEnumAttribute("0647")]
        Item0647,


        [System.Xml.Serialization.XmlEnumAttribute("0655")]
        Item0655,


        [System.Xml.Serialization.XmlEnumAttribute("0698")]
        Item0698,


        [System.Xml.Serialization.XmlEnumAttribute("0728")]
        Item0728,


        [System.Xml.Serialization.XmlEnumAttribute("0736")]
        Item0736,


        [System.Xml.Serialization.XmlEnumAttribute("0779")]
        Item0779,


        [System.Xml.Serialization.XmlEnumAttribute("0809")]
        Item0809,


        [System.Xml.Serialization.XmlEnumAttribute("0817")]
        Item0817,


        [System.Xml.Serialization.XmlEnumAttribute("0833")]
        Item0833,


        [System.Xml.Serialization.XmlEnumAttribute("0850")]
        Item0850,


        [System.Xml.Serialization.XmlEnumAttribute("0876")]
        Item0876,


        [System.Xml.Serialization.XmlEnumAttribute("0884")]
        Item0884,


        [System.Xml.Serialization.XmlEnumAttribute("0906")]
        Item0906,


        [System.Xml.Serialization.XmlEnumAttribute("0930")]
        Item0930,


        [System.Xml.Serialization.XmlEnumAttribute("0973")]
        Item0973,


        [System.Xml.Serialization.XmlEnumAttribute("0981")]
        Item0981,


        [System.Xml.Serialization.XmlEnumAttribute("1015")]
        Item1015,


        [System.Xml.Serialization.XmlEnumAttribute("1058")]
        Item1058,


        [System.Xml.Serialization.XmlEnumAttribute("1082")]
        Item1082,


        [System.Xml.Serialization.XmlEnumAttribute("1112")]
        Item1112,


        [System.Xml.Serialization.XmlEnumAttribute("1155")]
        Item1155,


        [System.Xml.Serialization.XmlEnumAttribute("1198")]
        Item1198,


        [System.Xml.Serialization.XmlEnumAttribute("1279")]
        Item1279,


        [System.Xml.Serialization.XmlEnumAttribute("1376")]
        Item1376,


        [System.Xml.Serialization.XmlEnumAttribute("1414")]
        Item1414,


        [System.Xml.Serialization.XmlEnumAttribute("1457")]
        Item1457,


        [System.Xml.Serialization.XmlEnumAttribute("1490")]
        Item1490,


        [System.Xml.Serialization.XmlEnumAttribute("1504")]
        Item1504,


        [System.Xml.Serialization.XmlEnumAttribute("1508")]
        Item1508,


        [System.Xml.Serialization.XmlEnumAttribute("1511")]
        Item1511,


        [System.Xml.Serialization.XmlEnumAttribute("1538")]
        Item1538,


        [System.Xml.Serialization.XmlEnumAttribute("1546")]
        Item1546,


        [System.Xml.Serialization.XmlEnumAttribute("1589")]
        Item1589,


        [System.Xml.Serialization.XmlEnumAttribute("1600")]
        Item1600,


        [System.Xml.Serialization.XmlEnumAttribute("1619")]
        Item1619,


        [System.Xml.Serialization.XmlEnumAttribute("1635")]
        Item1635,


        [System.Xml.Serialization.XmlEnumAttribute("1651")]
        Item1651,


        [System.Xml.Serialization.XmlEnumAttribute("1694")]
        Item1694,


        [System.Xml.Serialization.XmlEnumAttribute("1732")]
        Item1732,


        [System.Xml.Serialization.XmlEnumAttribute("1775")]
        Item1775,


        [System.Xml.Serialization.XmlEnumAttribute("1830")]
        Item1830,


        [System.Xml.Serialization.XmlEnumAttribute("1872")]
        Item1872,


        [System.Xml.Serialization.XmlEnumAttribute("1902")]
        Item1902,


        [System.Xml.Serialization.XmlEnumAttribute("1937")]
        Item1937,


        [System.Xml.Serialization.XmlEnumAttribute("1953")]
        Item1953,


        [System.Xml.Serialization.XmlEnumAttribute("1961")]
        Item1961,


        [System.Xml.Serialization.XmlEnumAttribute("1988")]
        Item1988,


        [System.Xml.Serialization.XmlEnumAttribute("1996")]
        Item1996,


        [System.Xml.Serialization.XmlEnumAttribute("2291")]
        Item2291,


        [System.Xml.Serialization.XmlEnumAttribute("2321")]
        Item2321,


        [System.Xml.Serialization.XmlEnumAttribute("2356")]
        Item2356,


        [System.Xml.Serialization.XmlEnumAttribute("2399")]
        Item2399,


        [System.Xml.Serialization.XmlEnumAttribute("2402")]
        Item2402,


        [System.Xml.Serialization.XmlEnumAttribute("2437")]
        Item2437,


        [System.Xml.Serialization.XmlEnumAttribute("2445")]
        Item2445,


        [System.Xml.Serialization.XmlEnumAttribute("2453")]
        Item2453,


        [System.Xml.Serialization.XmlEnumAttribute("2461")]
        Item2461,


        [System.Xml.Serialization.XmlEnumAttribute("2470")]
        Item2470,


        [System.Xml.Serialization.XmlEnumAttribute("2496")]
        Item2496,


        [System.Xml.Serialization.XmlEnumAttribute("2518")]
        Item2518,


        [System.Xml.Serialization.XmlEnumAttribute("2534")]
        Item2534,


        [System.Xml.Serialization.XmlEnumAttribute("2550")]
        Item2550,


        [System.Xml.Serialization.XmlEnumAttribute("2593")]
        Item2593,


        [System.Xml.Serialization.XmlEnumAttribute("2674")]
        Item2674,


        [System.Xml.Serialization.XmlEnumAttribute("2712")]
        Item2712,


        [System.Xml.Serialization.XmlEnumAttribute("2755")]
        Item2755,


        [System.Xml.Serialization.XmlEnumAttribute("2810")]
        Item2810,


        [System.Xml.Serialization.XmlEnumAttribute("2852")]
        Item2852,


        [System.Xml.Serialization.XmlEnumAttribute("2895")]
        Item2895,


        [System.Xml.Serialization.XmlEnumAttribute("2917")]
        Item2917,


        [System.Xml.Serialization.XmlEnumAttribute("2933")]
        Item2933,


        [System.Xml.Serialization.XmlEnumAttribute("2976")]
        Item2976,


        [System.Xml.Serialization.XmlEnumAttribute("3018")]
        Item3018,


        [System.Xml.Serialization.XmlEnumAttribute("3050")]
        Item3050,


        [System.Xml.Serialization.XmlEnumAttribute("3093")]
        Item3093,


        [System.Xml.Serialization.XmlEnumAttribute("3131")]
        Item3131,


        [System.Xml.Serialization.XmlEnumAttribute("3174")]
        Item3174,


        [System.Xml.Serialization.XmlEnumAttribute("3255")]
        Item3255,


        [System.Xml.Serialization.XmlEnumAttribute("3298")]
        Item3298,


        [System.Xml.Serialization.XmlEnumAttribute("3310")]
        Item3310,


        [System.Xml.Serialization.XmlEnumAttribute("3344")]
        Item3344,


        [System.Xml.Serialization.XmlEnumAttribute("3379")]
        Item3379,


        [System.Xml.Serialization.XmlEnumAttribute("3417")]
        Item3417,


        [System.Xml.Serialization.XmlEnumAttribute("3450")]
        Item3450,


        [System.Xml.Serialization.XmlEnumAttribute("3514")]
        Item3514,


        [System.Xml.Serialization.XmlEnumAttribute("3557")]
        Item3557,


        [System.Xml.Serialization.XmlEnumAttribute("3573")]
        Item3573,


        [System.Xml.Serialization.XmlEnumAttribute("3595")]
        Item3595,


        [System.Xml.Serialization.XmlEnumAttribute("3611")]
        Item3611,


        [System.Xml.Serialization.XmlEnumAttribute("3654")]
        Item3654,


        [System.Xml.Serialization.XmlEnumAttribute("3697")]
        Item3697,


        [System.Xml.Serialization.XmlEnumAttribute("3727")]
        Item3727,


        [System.Xml.Serialization.XmlEnumAttribute("3751")]
        Item3751,


        [System.Xml.Serialization.XmlEnumAttribute("3794")]
        Item3794,


        [System.Xml.Serialization.XmlEnumAttribute("3832")]
        Item3832,


        [System.Xml.Serialization.XmlEnumAttribute("3867")]
        Item3867,


        [System.Xml.Serialization.XmlEnumAttribute("3913")]
        Item3913,


        [System.Xml.Serialization.XmlEnumAttribute("3964")]
        Item3964,


        [System.Xml.Serialization.XmlEnumAttribute("3999")]
        Item3999,


        [System.Xml.Serialization.XmlEnumAttribute("4030")]
        Item4030,


        [System.Xml.Serialization.XmlEnumAttribute("4111")]
        Item4111,


        [System.Xml.Serialization.XmlEnumAttribute("4200")]
        Item4200,


        [System.Xml.Serialization.XmlEnumAttribute("4235")]
        Item4235,


        [System.Xml.Serialization.XmlEnumAttribute("4260")]
        Item4260,


        [System.Xml.Serialization.XmlEnumAttribute("4278")]
        Item4278,


        [System.Xml.Serialization.XmlEnumAttribute("4316")]
        Item4316,


        [System.Xml.Serialization.XmlEnumAttribute("4340")]
        Item4340,


        [System.Xml.Serialization.XmlEnumAttribute("4383")]
        Item4383,


        [System.Xml.Serialization.XmlEnumAttribute("4405")]
        Item4405,


        [System.Xml.Serialization.XmlEnumAttribute("4421")]
        Item4421,


        [System.Xml.Serialization.XmlEnumAttribute("4456")]
        Item4456,


        [System.Xml.Serialization.XmlEnumAttribute("4472")]
        Item4472,


        [System.Xml.Serialization.XmlEnumAttribute("4499")]
        Item4499,


        [System.Xml.Serialization.XmlEnumAttribute("4502")]
        Item4502,


        [System.Xml.Serialization.XmlEnumAttribute("4525")]
        Item4525,


        [System.Xml.Serialization.XmlEnumAttribute("4553")]
        Item4553,


        [System.Xml.Serialization.XmlEnumAttribute("4588")]
        Item4588,


        [System.Xml.Serialization.XmlEnumAttribute("4618")]
        Item4618,


        [System.Xml.Serialization.XmlEnumAttribute("4642")]
        Item4642,


        [System.Xml.Serialization.XmlEnumAttribute("4677")]
        Item4677,


        [System.Xml.Serialization.XmlEnumAttribute("4723")]
        Item4723,


        [System.Xml.Serialization.XmlEnumAttribute("4740")]
        Item4740,


        [System.Xml.Serialization.XmlEnumAttribute("4766")]
        Item4766,


        [System.Xml.Serialization.XmlEnumAttribute("4774")]
        Item4774,


        [System.Xml.Serialization.XmlEnumAttribute("4855")]
        Item4855,


        [System.Xml.Serialization.XmlEnumAttribute("4880")]
        Item4880,


        [System.Xml.Serialization.XmlEnumAttribute("4885")]
        Item4885,


        [System.Xml.Serialization.XmlEnumAttribute("4901")]
        Item4901,


        [System.Xml.Serialization.XmlEnumAttribute("4936")]
        Item4936,


        [System.Xml.Serialization.XmlEnumAttribute("4944")]
        Item4944,


        [System.Xml.Serialization.XmlEnumAttribute("4952")]
        Item4952,


        [System.Xml.Serialization.XmlEnumAttribute("4979")]
        Item4979,


        [System.Xml.Serialization.XmlEnumAttribute("4985")]
        Item4985,


        [System.Xml.Serialization.XmlEnumAttribute("4995")]
        Item4995,


        [System.Xml.Serialization.XmlEnumAttribute("5010")]
        Item5010,


        [System.Xml.Serialization.XmlEnumAttribute("5053")]
        Item5053,


        [System.Xml.Serialization.XmlEnumAttribute("5070")]
        Item5070,


        [System.Xml.Serialization.XmlEnumAttribute("5088")]
        Item5088,


        [System.Xml.Serialization.XmlEnumAttribute("5118")]
        Item5118,


        [System.Xml.Serialization.XmlEnumAttribute("5177")]
        Item5177,


        [System.Xml.Serialization.XmlEnumAttribute("5215")]
        Item5215,


        [System.Xml.Serialization.XmlEnumAttribute("5258")]
        Item5258,


        [System.Xml.Serialization.XmlEnumAttribute("5282")]
        Item5282,


        [System.Xml.Serialization.XmlEnumAttribute("5312")]
        Item5312,


        [System.Xml.Serialization.XmlEnumAttribute("5355")]
        Item5355,


        [System.Xml.Serialization.XmlEnumAttribute("5380")]
        Item5380,


        [System.Xml.Serialization.XmlEnumAttribute("5428")]
        Item5428,


        [System.Xml.Serialization.XmlEnumAttribute("5452")]
        Item5452,


        [System.Xml.Serialization.XmlEnumAttribute("5487")]
        Item5487,


        [System.Xml.Serialization.XmlEnumAttribute("5517")]
        Item5517,


        [System.Xml.Serialization.XmlEnumAttribute("5568")]
        Item5568,


        [System.Xml.Serialization.XmlEnumAttribute("5665")]
        Item5665,


        [System.Xml.Serialization.XmlEnumAttribute("5738")]
        Item5738,


        [System.Xml.Serialization.XmlEnumAttribute("5754")]
        Item5754,


        [System.Xml.Serialization.XmlEnumAttribute("5762")]
        Item5762,


        [System.Xml.Serialization.XmlEnumAttribute("5780")]
        Item5780,


        [System.Xml.Serialization.XmlEnumAttribute("5800")]
        Item5800,


        [System.Xml.Serialization.XmlEnumAttribute("5860")]
        Item5860,


        [System.Xml.Serialization.XmlEnumAttribute("5894")]
        Item5894,


        [System.Xml.Serialization.XmlEnumAttribute("5932")]
        Item5932,


        [System.Xml.Serialization.XmlEnumAttribute("5991")]
        Item5991,


        [System.Xml.Serialization.XmlEnumAttribute("6033")]
        Item6033,


        [System.Xml.Serialization.XmlEnumAttribute("6076")]
        Item6076,


        [System.Xml.Serialization.XmlEnumAttribute("6114")]
        Item6114,


        [System.Xml.Serialization.XmlEnumAttribute("6238")]
        Item6238,


        [System.Xml.Serialization.XmlEnumAttribute("6254")]
        Item6254,


        [System.Xml.Serialization.XmlEnumAttribute("6289")]
        Item6289,


        [System.Xml.Serialization.XmlEnumAttribute("6408")]
        Item6408,


        [System.Xml.Serialization.XmlEnumAttribute("6475")]
        Item6475,


        [System.Xml.Serialization.XmlEnumAttribute("6602")]
        Item6602,


        [System.Xml.Serialization.XmlEnumAttribute("6653")]
        Item6653,


        [System.Xml.Serialization.XmlEnumAttribute("6700")]
        Item6700,


        [System.Xml.Serialization.XmlEnumAttribute("6750")]
        Item6750,


        [System.Xml.Serialization.XmlEnumAttribute("6769")]
        Item6769,


        [System.Xml.Serialization.XmlEnumAttribute("6777")]
        Item6777,


        [System.Xml.Serialization.XmlEnumAttribute("6781")]
        Item6781,


        [System.Xml.Serialization.XmlEnumAttribute("6858")]
        Item6858,


        [System.Xml.Serialization.XmlEnumAttribute("6874")]
        Item6874,


        [System.Xml.Serialization.XmlEnumAttribute("6904")]
        Item6904,


        [System.Xml.Serialization.XmlEnumAttribute("6912")]
        Item6912,


        [System.Xml.Serialization.XmlEnumAttribute("6955")]
        Item6955,


        [System.Xml.Serialization.XmlEnumAttribute("6971")]
        Item6971,


        [System.Xml.Serialization.XmlEnumAttribute("7005")]
        Item7005,


        [System.Xml.Serialization.XmlEnumAttribute("7056")]
        Item7056,


        [System.Xml.Serialization.XmlEnumAttribute("7102")]
        Item7102,


        [System.Xml.Serialization.XmlEnumAttribute("7153")]
        Item7153,


        [System.Xml.Serialization.XmlEnumAttribute("7200")]
        Item7200,


        [System.Xml.Serialization.XmlEnumAttribute("7285")]
        Item7285,


        [System.Xml.Serialization.XmlEnumAttribute("7315")]
        Item7315,


        [System.Xml.Serialization.XmlEnumAttribute("7358")]
        Item7358,


        [System.Xml.Serialization.XmlEnumAttribute("7370")]
        Item7370,


        [System.Xml.Serialization.XmlEnumAttribute("7412")]
        Item7412,


        [System.Xml.Serialization.XmlEnumAttribute("7447")]
        Item7447,


        [System.Xml.Serialization.XmlEnumAttribute("7480")]
        Item7480,


        [System.Xml.Serialization.XmlEnumAttribute("7501")]
        Item7501,


        [System.Xml.Serialization.XmlEnumAttribute("7544")]
        Item7544,


        [System.Xml.Serialization.XmlEnumAttribute("7560")]
        Item7560,


        [System.Xml.Serialization.XmlEnumAttribute("7595")]
        Item7595,


        [System.Xml.Serialization.XmlEnumAttribute("7600")]
        Item7600,


        [System.Xml.Serialization.XmlEnumAttribute("7641")]
        Item7641,


        [System.Xml.Serialization.XmlEnumAttribute("7676")]
        Item7676,


        [System.Xml.Serialization.XmlEnumAttribute("7706")]
        Item7706,


        [System.Xml.Serialization.XmlEnumAttribute("7722")]
        Item7722,


        [System.Xml.Serialization.XmlEnumAttribute("7765")]
        Item7765,


        [System.Xml.Serialization.XmlEnumAttribute("7803")]
        Item7803,


        [System.Xml.Serialization.XmlEnumAttribute("7820")]
        Item7820,


        [System.Xml.Serialization.XmlEnumAttribute("7838")]
        Item7838,


        [System.Xml.Serialization.XmlEnumAttribute("7889")]
        Item7889,


        [System.Xml.Serialization.XmlEnumAttribute("7919")]
        Item7919,


        [System.Xml.Serialization.XmlEnumAttribute("7951")]
        Item7951,


        [System.Xml.Serialization.XmlEnumAttribute("8001")]
        Item8001,


        [System.Xml.Serialization.XmlEnumAttribute("8052")]
        Item8052,


        [System.Xml.Serialization.XmlEnumAttribute("8109")]
        Item8109,


        [System.Xml.Serialization.XmlEnumAttribute("8150")]
        Item8150,


        [System.Xml.Serialization.XmlEnumAttribute("8206")]
        Item8206,


        [System.Xml.Serialization.XmlEnumAttribute("8230")]
        Item8230,


        [System.Xml.Serialization.XmlEnumAttribute("8249")]
        Item8249,


        [System.Xml.Serialization.XmlEnumAttribute("8273")]
        Item8273,


        [System.Xml.Serialization.XmlEnumAttribute("8281")]
        Item8281,


        [System.Xml.Serialization.XmlEnumAttribute("8311")]
        Item8311,


        [System.Xml.Serialization.XmlEnumAttribute("8338")]
        Item8338,


        [System.Xml.Serialization.XmlEnumAttribute("8451")]
        Item8451,


        [System.Xml.Serialization.XmlEnumAttribute("8478")]
        Item8478,


        [System.Xml.Serialization.XmlEnumAttribute("8486")]
        Item8486,


        [System.Xml.Serialization.XmlEnumAttribute("8508")]
        Item8508,


        [System.Xml.Serialization.XmlEnumAttribute("8583")]
        Item8583,


        [System.Xml.Serialization.XmlEnumAttribute("8630")]
        Item8630,


        [System.Xml.Serialization.XmlEnumAttribute("8664")]
        Item8664,


        [System.Xml.Serialization.XmlEnumAttribute("8702")]
        Item8702,


        [System.Xml.Serialization.XmlEnumAttribute("8737")]
        Item8737,


        [System.Xml.Serialization.XmlEnumAttribute("8885")]
        Item8885,


        [System.Xml.Serialization.XmlEnumAttribute("8907")]
        Item8907,


        [System.Xml.Serialization.XmlEnumAttribute("8958")]
        Item8958,


        [System.Xml.Serialization.XmlEnumAttribute("9903")]
        Item9903,


        [System.Xml.Serialization.XmlEnumAttribute("9946")]
        Item9946,


        [System.Xml.Serialization.XmlEnumAttribute("9950")]
        Item9950,


        [System.Xml.Serialization.XmlEnumAttribute("9970")]
        Item9970,
    }



    [Serializable]


    [XmlType(Namespace = Namespaces.NFe)]
    public partial class TEnderEmi
    {


        public string xLgr{get;set;}


        public string nro{get;set;}


        public string xCpl{get;set;}


        public string xBairro{get;set;}


        public string cMun{get;set;}


        public string xMun{get;set;}


        public TUfEmi UF{get;set;}


        public string CEP{get;set;}


        public TEnderEmiCPais cPais{get;set;}


        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool cPaisSpecified{get;set;}


        public TEnderEmiXPais xPais{get;set;}


        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool xPaisSpecified{get;set;}


        public string fone{get;set;}
    }



    [Serializable]
    [XmlType(Namespace = Namespaces.NFe)]
    public enum TUfEmi
    {


        AC,


        AL,


        AM,


        AP,


        BA,


        CE,


        DF,


        ES,


        GO,


        MA,


        MG,


        MS,


        MT,


        PA,


        PB,


        PE,


        PI,


        PR,


        RJ,


        RN,


        RO,


        RR,


        RS,


        SC,


        SE,


        SP,


        TO,
    }



    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TEnderEmiCPais
    {


        [System.Xml.Serialization.XmlEnumAttribute("1058")]
        Item1058,
    }



    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TEnderEmiXPais
    {


        Brasil,


        BRASIL,
    }



    [Serializable]


    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeIdeNFrefRefNF
    {


        public TCodUfIBGE cUF{get;set;}


        public string AAMM{get;set;}


        public string CNPJ{get;set;}


        public TNFeInfNFeIdeNFrefRefNFMod mod{get;set;}


        public string serie{get;set;}


        public string nNF{get;set;}
    }



    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeIdeNFrefRefNFMod
    {


        [System.Xml.Serialization.XmlEnumAttribute("01")]
        Item01,
    }



    [Serializable]


    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeIdeNFrefRefNFP
    {


        public TCodUfIBGE cUF{get;set;}


        public string AAMM{get;set;}


        [System.Xml.Serialization.XmlElementAttribute("CNPJ", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("CPF", typeof(string))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public string Item{get;set;}


        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType ItemElementName{get;set;}


        public string IE{get;set;}


        public TNFeInfNFeIdeNFrefRefNFPMod mod{get;set;}


        public string serie{get;set;}


        public string nNF{get;set;}
    }







    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeIdeNFrefRefNFPMod
    {


        [System.Xml.Serialization.XmlEnumAttribute("01")]
        Item01,


        [System.Xml.Serialization.XmlEnumAttribute("04")]
        Item04,
    }



    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe", IncludeInSchema = false)]
    public enum ItemChoiceType9
    {


        refCTe,


        refECF,


        refNF,


        refNFP,


        refNFe,
    }



    [Serializable]


    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeEmit
    {


        [System.Xml.Serialization.XmlElementAttribute("CNPJ", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("CPF", typeof(string))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public string Item{get;set;}


        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType2 ItemElementName{get;set;}


        public string xNome{get;set;}


        public string xFant{get;set;}


        public TEnderEmi enderEmit{get;set;}


        public string IE{get;set;}


        public string IEST{get;set;}


        public string IM{get;set;}


        public string CNAE{get;set;}


        public TNFeInfNFeEmitCRT CRT{get;set;}
    }



    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe", IncludeInSchema = false)]
    public enum ItemChoiceType2
    {


        CNPJ,


        CPF,
    }



    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeEmitCRT
    {


        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,


        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,


        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,
    }



    [Serializable]


    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeAvulsa
    {


        public string CNPJ{get;set;}


        public string xOrgao{get;set;}


        public string matr{get;set;}


        public string xAgente{get;set;}


        public string fone{get;set;}


        public TUfEmi UF{get;set;}


        public string nDAR{get;set;}


        public string dEmi{get;set;}


        public string vDAR{get;set;}


        public string repEmi{get;set;}


        public string dPag{get;set;}
    }



    [Serializable]


    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDest
    {


        [System.Xml.Serialization.XmlElementAttribute("CNPJ", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("CPF", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("idEstrangeiro", typeof(string))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public string Item{get;set;}


        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType3 ItemElementName{get;set;}


        public string xNome{get;set;}


        public TEndereco enderDest{get;set;}


        public TNFeInfNFeDestIndIEDest indIEDest{get;set;}


        public string IE{get;set;}


        public string ISUF{get;set;}


        public string IM{get;set;}


        public string email{get;set;}
    }



    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe", IncludeInSchema = false)]
    public enum ItemChoiceType3
    {


        CNPJ,


        CPF,


        idEstrangeiro,
    }



    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDestIndIEDest
    {


        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,


        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,


        [System.Xml.Serialization.XmlEnumAttribute("9")]
        Item9,
    }



    [Serializable]


    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeAutXML
    {


        [System.Xml.Serialization.XmlElementAttribute("CNPJ", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("CPF", typeof(string))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public string Item{get;set;}


        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType5 ItemElementName{get;set;}
    }



    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe", IncludeInSchema = false)]
    public enum ItemChoiceType5
    {


        CNPJ,


        CPF,
    }



    [Serializable]


    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDet
    {


        public TNFeInfNFeDetProd prod{get;set;}


        public TNFeInfNFeDetImposto imposto{get;set;}


        public TNFeInfNFeDetImpostoDevol impostoDevol{get;set;}


        public string infAdProd{get;set;}


        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string nItem{get;set;}
    }



    [Serializable]


    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetProd
    {


        public string cProd{get;set;}


        public string cEAN{get;set;}


        public string xProd{get;set;}


        public string NCM{get;set;}


        [System.Xml.Serialization.XmlElementAttribute("NVE")]
        public string[] NVE{get;set;}


        public string EXTIPI{get;set;}


        public TCfop CFOP{get;set;}


        public string uCom{get;set;}


        public string qCom{get;set;}


        public string vUnCom{get;set;}


        public string vProd{get;set;}


        public string cEANTrib{get;set;}


        public string uTrib{get;set;}


        public string qTrib{get;set;}


        public string vUnTrib{get;set;}


        public string vFrete{get;set;}


        public string vSeg{get;set;}


        public string vDesc{get;set;}


        public string vOutro{get;set;}


        public TNFeInfNFeDetProdIndTot indTot{get;set;}


        [System.Xml.Serialization.XmlElementAttribute("DI")]
        public TNFeInfNFeDetProdDI[] DI{get;set;}


        [System.Xml.Serialization.XmlElementAttribute("detExport")]
        public TNFeInfNFeDetProdDetExport[] detExport{get;set;}


        public string xPed{get;set;}


        public string nItemPed{get;set;}


        public string nFCI{get;set;}


        [System.Xml.Serialization.XmlElementAttribute("arma", typeof(TNFeInfNFeDetProdArma))]
        [System.Xml.Serialization.XmlElementAttribute("comb", typeof(TNFeInfNFeDetProdComb))]
        [System.Xml.Serialization.XmlElementAttribute("med", typeof(TNFeInfNFeDetProdMed))]
        [System.Xml.Serialization.XmlElementAttribute("nRECOPI", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("veicProd", typeof(TNFeInfNFeDetProdVeicProd))]
        public object[] Items{get;set;}
    }



    [Serializable]
    [XmlType(Namespace = Namespaces.NFe)]
    public enum TCfop
    {


        [System.Xml.Serialization.XmlEnumAttribute("1101")]
        Item1101,


        [System.Xml.Serialization.XmlEnumAttribute("1102")]
        Item1102,


        [System.Xml.Serialization.XmlEnumAttribute("1111")]
        Item1111,


        [System.Xml.Serialization.XmlEnumAttribute("1113")]
        Item1113,


        [System.Xml.Serialization.XmlEnumAttribute("1116")]
        Item1116,


        [System.Xml.Serialization.XmlEnumAttribute("1117")]
        Item1117,


        [System.Xml.Serialization.XmlEnumAttribute("1118")]
        Item1118,


        [System.Xml.Serialization.XmlEnumAttribute("1120")]
        Item1120,


        [System.Xml.Serialization.XmlEnumAttribute("1121")]
        Item1121,


        [System.Xml.Serialization.XmlEnumAttribute("1122")]
        Item1122,


        [System.Xml.Serialization.XmlEnumAttribute("1124")]
        Item1124,


        [System.Xml.Serialization.XmlEnumAttribute("1125")]
        Item1125,


        [System.Xml.Serialization.XmlEnumAttribute("1126")]
        Item1126,


        [System.Xml.Serialization.XmlEnumAttribute("1128")]
        Item1128,


        [System.Xml.Serialization.XmlEnumAttribute("1151")]
        Item1151,


        [System.Xml.Serialization.XmlEnumAttribute("1152")]
        Item1152,


        [System.Xml.Serialization.XmlEnumAttribute("1153")]
        Item1153,


        [System.Xml.Serialization.XmlEnumAttribute("1154")]
        Item1154,


        [System.Xml.Serialization.XmlEnumAttribute("1201")]
        Item1201,


        [System.Xml.Serialization.XmlEnumAttribute("1202")]
        Item1202,


        [System.Xml.Serialization.XmlEnumAttribute("1203")]
        Item1203,


        [System.Xml.Serialization.XmlEnumAttribute("1204")]
        Item1204,


        [System.Xml.Serialization.XmlEnumAttribute("1205")]
        Item1205,


        [System.Xml.Serialization.XmlEnumAttribute("1206")]
        Item1206,


        [System.Xml.Serialization.XmlEnumAttribute("1207")]
        Item1207,


        [System.Xml.Serialization.XmlEnumAttribute("1208")]
        Item1208,


        [System.Xml.Serialization.XmlEnumAttribute("1209")]
        Item1209,


        [System.Xml.Serialization.XmlEnumAttribute("1251")]
        Item1251,


        [System.Xml.Serialization.XmlEnumAttribute("1252")]
        Item1252,


        [System.Xml.Serialization.XmlEnumAttribute("1253")]
        Item1253,


        [System.Xml.Serialization.XmlEnumAttribute("1254")]
        Item1254,


        [System.Xml.Serialization.XmlEnumAttribute("1255")]
        Item1255,


        [System.Xml.Serialization.XmlEnumAttribute("1256")]
        Item1256,


        [System.Xml.Serialization.XmlEnumAttribute("1257")]
        Item1257,


        [System.Xml.Serialization.XmlEnumAttribute("1301")]
        Item1301,


        [System.Xml.Serialization.XmlEnumAttribute("1302")]
        Item1302,


        [System.Xml.Serialization.XmlEnumAttribute("1303")]
        Item1303,


        [System.Xml.Serialization.XmlEnumAttribute("1304")]
        Item1304,


        [System.Xml.Serialization.XmlEnumAttribute("1305")]
        Item1305,


        [System.Xml.Serialization.XmlEnumAttribute("1306")]
        Item1306,


        [System.Xml.Serialization.XmlEnumAttribute("1351")]
        Item1351,


        [System.Xml.Serialization.XmlEnumAttribute("1352")]
        Item1352,


        [System.Xml.Serialization.XmlEnumAttribute("1353")]
        Item1353,


        [System.Xml.Serialization.XmlEnumAttribute("1354")]
        Item1354,


        [System.Xml.Serialization.XmlEnumAttribute("1355")]
        Item1355,


        [System.Xml.Serialization.XmlEnumAttribute("1356")]
        Item1356,


        [System.Xml.Serialization.XmlEnumAttribute("1360")]
        Item1360,


        [System.Xml.Serialization.XmlEnumAttribute("1401")]
        Item1401,


        [System.Xml.Serialization.XmlEnumAttribute("1403")]
        Item1403,


        [System.Xml.Serialization.XmlEnumAttribute("1406")]
        Item1406,


        [System.Xml.Serialization.XmlEnumAttribute("1407")]
        Item1407,


        [System.Xml.Serialization.XmlEnumAttribute("1408")]
        Item1408,


        [System.Xml.Serialization.XmlEnumAttribute("1409")]
        Item1409,


        [System.Xml.Serialization.XmlEnumAttribute("1410")]
        Item1410,


        [System.Xml.Serialization.XmlEnumAttribute("1411")]
        Item1411,


        [System.Xml.Serialization.XmlEnumAttribute("1414")]
        Item1414,


        [System.Xml.Serialization.XmlEnumAttribute("1415")]
        Item1415,


        [System.Xml.Serialization.XmlEnumAttribute("1451")]
        Item1451,


        [System.Xml.Serialization.XmlEnumAttribute("1452")]
        Item1452,


        [System.Xml.Serialization.XmlEnumAttribute("1501")]
        Item1501,


        [System.Xml.Serialization.XmlEnumAttribute("1503")]
        Item1503,


        [System.Xml.Serialization.XmlEnumAttribute("1504")]
        Item1504,


        [System.Xml.Serialization.XmlEnumAttribute("1505")]
        Item1505,


        [System.Xml.Serialization.XmlEnumAttribute("1506")]
        Item1506,


        [System.Xml.Serialization.XmlEnumAttribute("1551")]
        Item1551,


        [System.Xml.Serialization.XmlEnumAttribute("1552")]
        Item1552,


        [System.Xml.Serialization.XmlEnumAttribute("1553")]
        Item1553,


        [System.Xml.Serialization.XmlEnumAttribute("1554")]
        Item1554,


        [System.Xml.Serialization.XmlEnumAttribute("1555")]
        Item1555,


        [System.Xml.Serialization.XmlEnumAttribute("1556")]
        Item1556,


        [System.Xml.Serialization.XmlEnumAttribute("1557")]
        Item1557,


        [System.Xml.Serialization.XmlEnumAttribute("1601")]
        Item1601,


        [System.Xml.Serialization.XmlEnumAttribute("1602")]
        Item1602,


        [System.Xml.Serialization.XmlEnumAttribute("1603")]
        Item1603,


        [System.Xml.Serialization.XmlEnumAttribute("1604")]
        Item1604,


        [System.Xml.Serialization.XmlEnumAttribute("1605")]
        Item1605,


        [System.Xml.Serialization.XmlEnumAttribute("1651")]
        Item1651,


        [System.Xml.Serialization.XmlEnumAttribute("1652")]
        Item1652,


        [System.Xml.Serialization.XmlEnumAttribute("1653")]
        Item1653,


        [System.Xml.Serialization.XmlEnumAttribute("1658")]
        Item1658,


        [System.Xml.Serialization.XmlEnumAttribute("1659")]
        Item1659,


        [System.Xml.Serialization.XmlEnumAttribute("1660")]
        Item1660,


        [System.Xml.Serialization.XmlEnumAttribute("1661")]
        Item1661,


        [System.Xml.Serialization.XmlEnumAttribute("1662")]
        Item1662,


        [System.Xml.Serialization.XmlEnumAttribute("1663")]
        Item1663,


        [System.Xml.Serialization.XmlEnumAttribute("1664")]
        Item1664,


        [System.Xml.Serialization.XmlEnumAttribute("1901")]
        Item1901,


        [System.Xml.Serialization.XmlEnumAttribute("1902")]
        Item1902,


        [System.Xml.Serialization.XmlEnumAttribute("1903")]
        Item1903,


        [System.Xml.Serialization.XmlEnumAttribute("1904")]
        Item1904,


        [System.Xml.Serialization.XmlEnumAttribute("1905")]
        Item1905,


        [System.Xml.Serialization.XmlEnumAttribute("1906")]
        Item1906,


        [System.Xml.Serialization.XmlEnumAttribute("1907")]
        Item1907,


        [System.Xml.Serialization.XmlEnumAttribute("1908")]
        Item1908,


        [System.Xml.Serialization.XmlEnumAttribute("1909")]
        Item1909,


        [System.Xml.Serialization.XmlEnumAttribute("1910")]
        Item1910,


        [System.Xml.Serialization.XmlEnumAttribute("1911")]
        Item1911,


        [System.Xml.Serialization.XmlEnumAttribute("1912")]
        Item1912,


        [System.Xml.Serialization.XmlEnumAttribute("1913")]
        Item1913,


        [System.Xml.Serialization.XmlEnumAttribute("1914")]
        Item1914,


        [System.Xml.Serialization.XmlEnumAttribute("1915")]
        Item1915,


        [System.Xml.Serialization.XmlEnumAttribute("1916")]
        Item1916,


        [System.Xml.Serialization.XmlEnumAttribute("1917")]
        Item1917,


        [System.Xml.Serialization.XmlEnumAttribute("1918")]
        Item1918,


        [System.Xml.Serialization.XmlEnumAttribute("1919")]
        Item1919,


        [System.Xml.Serialization.XmlEnumAttribute("1920")]
        Item1920,


        [System.Xml.Serialization.XmlEnumAttribute("1921")]
        Item1921,


        [System.Xml.Serialization.XmlEnumAttribute("1922")]
        Item1922,


        [System.Xml.Serialization.XmlEnumAttribute("1923")]
        Item1923,


        [System.Xml.Serialization.XmlEnumAttribute("1924")]
        Item1924,


        [System.Xml.Serialization.XmlEnumAttribute("1925")]
        Item1925,


        [System.Xml.Serialization.XmlEnumAttribute("1926")]
        Item1926,


        [System.Xml.Serialization.XmlEnumAttribute("1931")]
        Item1931,


        [System.Xml.Serialization.XmlEnumAttribute("1932")]
        Item1932,


        [System.Xml.Serialization.XmlEnumAttribute("1933")]
        Item1933,


        [System.Xml.Serialization.XmlEnumAttribute("1934")]
        Item1934,


        [System.Xml.Serialization.XmlEnumAttribute("1949")]
        Item1949,


        [System.Xml.Serialization.XmlEnumAttribute("2101")]
        Item2101,


        [System.Xml.Serialization.XmlEnumAttribute("2102")]
        Item2102,


        [System.Xml.Serialization.XmlEnumAttribute("2111")]
        Item2111,


        [System.Xml.Serialization.XmlEnumAttribute("2113")]
        Item2113,


        [System.Xml.Serialization.XmlEnumAttribute("2116")]
        Item2116,


        [System.Xml.Serialization.XmlEnumAttribute("2117")]
        Item2117,


        [System.Xml.Serialization.XmlEnumAttribute("2118")]
        Item2118,


        [System.Xml.Serialization.XmlEnumAttribute("2120")]
        Item2120,


        [System.Xml.Serialization.XmlEnumAttribute("2121")]
        Item2121,


        [System.Xml.Serialization.XmlEnumAttribute("2122")]
        Item2122,


        [System.Xml.Serialization.XmlEnumAttribute("2124")]
        Item2124,


        [System.Xml.Serialization.XmlEnumAttribute("2125")]
        Item2125,


        [System.Xml.Serialization.XmlEnumAttribute("2126")]
        Item2126,


        [System.Xml.Serialization.XmlEnumAttribute("2128")]
        Item2128,


        [System.Xml.Serialization.XmlEnumAttribute("2151")]
        Item2151,


        [System.Xml.Serialization.XmlEnumAttribute("2152")]
        Item2152,


        [System.Xml.Serialization.XmlEnumAttribute("2153")]
        Item2153,


        [System.Xml.Serialization.XmlEnumAttribute("2154")]
        Item2154,


        [System.Xml.Serialization.XmlEnumAttribute("2201")]
        Item2201,


        [System.Xml.Serialization.XmlEnumAttribute("2202")]
        Item2202,


        [System.Xml.Serialization.XmlEnumAttribute("2203")]
        Item2203,


        [System.Xml.Serialization.XmlEnumAttribute("2204")]
        Item2204,


        [System.Xml.Serialization.XmlEnumAttribute("2205")]
        Item2205,


        [System.Xml.Serialization.XmlEnumAttribute("2206")]
        Item2206,


        [System.Xml.Serialization.XmlEnumAttribute("2207")]
        Item2207,


        [System.Xml.Serialization.XmlEnumAttribute("2208")]
        Item2208,


        [System.Xml.Serialization.XmlEnumAttribute("2209")]
        Item2209,


        [System.Xml.Serialization.XmlEnumAttribute("2251")]
        Item2251,


        [System.Xml.Serialization.XmlEnumAttribute("2252")]
        Item2252,


        [System.Xml.Serialization.XmlEnumAttribute("2253")]
        Item2253,


        [System.Xml.Serialization.XmlEnumAttribute("2254")]
        Item2254,


        [System.Xml.Serialization.XmlEnumAttribute("2255")]
        Item2255,


        [System.Xml.Serialization.XmlEnumAttribute("2256")]
        Item2256,


        [System.Xml.Serialization.XmlEnumAttribute("2257")]
        Item2257,


        [System.Xml.Serialization.XmlEnumAttribute("2301")]
        Item2301,


        [System.Xml.Serialization.XmlEnumAttribute("2302")]
        Item2302,


        [System.Xml.Serialization.XmlEnumAttribute("2303")]
        Item2303,


        [System.Xml.Serialization.XmlEnumAttribute("2304")]
        Item2304,


        [System.Xml.Serialization.XmlEnumAttribute("2305")]
        Item2305,


        [System.Xml.Serialization.XmlEnumAttribute("2306")]
        Item2306,


        [System.Xml.Serialization.XmlEnumAttribute("2351")]
        Item2351,


        [System.Xml.Serialization.XmlEnumAttribute("2352")]
        Item2352,


        [System.Xml.Serialization.XmlEnumAttribute("2353")]
        Item2353,


        [System.Xml.Serialization.XmlEnumAttribute("2354")]
        Item2354,


        [System.Xml.Serialization.XmlEnumAttribute("2355")]
        Item2355,


        [System.Xml.Serialization.XmlEnumAttribute("2356")]
        Item2356,


        [System.Xml.Serialization.XmlEnumAttribute("2401")]
        Item2401,


        [System.Xml.Serialization.XmlEnumAttribute("2403")]
        Item2403,


        [System.Xml.Serialization.XmlEnumAttribute("2406")]
        Item2406,


        [System.Xml.Serialization.XmlEnumAttribute("2407")]
        Item2407,


        [System.Xml.Serialization.XmlEnumAttribute("2408")]
        Item2408,


        [System.Xml.Serialization.XmlEnumAttribute("2409")]
        Item2409,


        [System.Xml.Serialization.XmlEnumAttribute("2410")]
        Item2410,


        [System.Xml.Serialization.XmlEnumAttribute("2411")]
        Item2411,


        [System.Xml.Serialization.XmlEnumAttribute("2414")]
        Item2414,


        [System.Xml.Serialization.XmlEnumAttribute("2415")]
        Item2415,


        [System.Xml.Serialization.XmlEnumAttribute("2501")]
        Item2501,


        [System.Xml.Serialization.XmlEnumAttribute("2503")]
        Item2503,


        [System.Xml.Serialization.XmlEnumAttribute("2504")]
        Item2504,


        [System.Xml.Serialization.XmlEnumAttribute("2505")]
        Item2505,


        [System.Xml.Serialization.XmlEnumAttribute("2506")]
        Item2506,


        [System.Xml.Serialization.XmlEnumAttribute("2551")]
        Item2551,


        [System.Xml.Serialization.XmlEnumAttribute("2552")]
        Item2552,


        [System.Xml.Serialization.XmlEnumAttribute("2553")]
        Item2553,


        [System.Xml.Serialization.XmlEnumAttribute("2554")]
        Item2554,


        [System.Xml.Serialization.XmlEnumAttribute("2555")]
        Item2555,


        [System.Xml.Serialization.XmlEnumAttribute("2556")]
        Item2556,


        [System.Xml.Serialization.XmlEnumAttribute("2557")]
        Item2557,


        [System.Xml.Serialization.XmlEnumAttribute("2603")]
        Item2603,


        [System.Xml.Serialization.XmlEnumAttribute("2651")]
        Item2651,


        [System.Xml.Serialization.XmlEnumAttribute("2652")]
        Item2652,


        [System.Xml.Serialization.XmlEnumAttribute("2653")]
        Item2653,


        [System.Xml.Serialization.XmlEnumAttribute("2658")]
        Item2658,


        [System.Xml.Serialization.XmlEnumAttribute("2659")]
        Item2659,


        [System.Xml.Serialization.XmlEnumAttribute("2660")]
        Item2660,


        [System.Xml.Serialization.XmlEnumAttribute("2661")]
        Item2661,


        [System.Xml.Serialization.XmlEnumAttribute("2662")]
        Item2662,


        [System.Xml.Serialization.XmlEnumAttribute("2663")]
        Item2663,


        [System.Xml.Serialization.XmlEnumAttribute("2664")]
        Item2664,


        [System.Xml.Serialization.XmlEnumAttribute("2901")]
        Item2901,


        [System.Xml.Serialization.XmlEnumAttribute("2902")]
        Item2902,


        [System.Xml.Serialization.XmlEnumAttribute("2903")]
        Item2903,


        [System.Xml.Serialization.XmlEnumAttribute("2904")]
        Item2904,


        [System.Xml.Serialization.XmlEnumAttribute("2905")]
        Item2905,


        [System.Xml.Serialization.XmlEnumAttribute("2906")]
        Item2906,


        [System.Xml.Serialization.XmlEnumAttribute("2907")]
        Item2907,


        [System.Xml.Serialization.XmlEnumAttribute("2908")]
        Item2908,


        [System.Xml.Serialization.XmlEnumAttribute("2909")]
        Item2909,


        [System.Xml.Serialization.XmlEnumAttribute("2910")]
        Item2910,


        [System.Xml.Serialization.XmlEnumAttribute("2911")]
        Item2911,


        [System.Xml.Serialization.XmlEnumAttribute("2912")]
        Item2912,


        [System.Xml.Serialization.XmlEnumAttribute("2913")]
        Item2913,


        [System.Xml.Serialization.XmlEnumAttribute("2914")]
        Item2914,


        [System.Xml.Serialization.XmlEnumAttribute("2915")]
        Item2915,


        [System.Xml.Serialization.XmlEnumAttribute("2916")]
        Item2916,


        [System.Xml.Serialization.XmlEnumAttribute("2917")]
        Item2917,


        [System.Xml.Serialization.XmlEnumAttribute("2918")]
        Item2918,


        [System.Xml.Serialization.XmlEnumAttribute("2919")]
        Item2919,


        [System.Xml.Serialization.XmlEnumAttribute("2920")]
        Item2920,


        [System.Xml.Serialization.XmlEnumAttribute("2921")]
        Item2921,


        [System.Xml.Serialization.XmlEnumAttribute("2922")]
        Item2922,


        [System.Xml.Serialization.XmlEnumAttribute("2923")]
        Item2923,


        [System.Xml.Serialization.XmlEnumAttribute("2924")]
        Item2924,


        [System.Xml.Serialization.XmlEnumAttribute("2925")]
        Item2925,


        [System.Xml.Serialization.XmlEnumAttribute("2931")]
        Item2931,


        [System.Xml.Serialization.XmlEnumAttribute("2932")]
        Item2932,


        [System.Xml.Serialization.XmlEnumAttribute("2933")]
        Item2933,


        [System.Xml.Serialization.XmlEnumAttribute("2934")]
        Item2934,


        [System.Xml.Serialization.XmlEnumAttribute("2949")]
        Item2949,


        [System.Xml.Serialization.XmlEnumAttribute("3101")]
        Item3101,


        [System.Xml.Serialization.XmlEnumAttribute("3102")]
        Item3102,


        [System.Xml.Serialization.XmlEnumAttribute("3126")]
        Item3126,


        [System.Xml.Serialization.XmlEnumAttribute("3127")]
        Item3127,


        [System.Xml.Serialization.XmlEnumAttribute("3128")]
        Item3128,


        [System.Xml.Serialization.XmlEnumAttribute("3201")]
        Item3201,


        [System.Xml.Serialization.XmlEnumAttribute("3202")]
        Item3202,


        [System.Xml.Serialization.XmlEnumAttribute("3205")]
        Item3205,


        [System.Xml.Serialization.XmlEnumAttribute("3206")]
        Item3206,


        [System.Xml.Serialization.XmlEnumAttribute("3207")]
        Item3207,


        [System.Xml.Serialization.XmlEnumAttribute("3211")]
        Item3211,


        [System.Xml.Serialization.XmlEnumAttribute("3251")]
        Item3251,


        [System.Xml.Serialization.XmlEnumAttribute("3301")]
        Item3301,


        [System.Xml.Serialization.XmlEnumAttribute("3351")]
        Item3351,


        [System.Xml.Serialization.XmlEnumAttribute("3352")]
        Item3352,


        [System.Xml.Serialization.XmlEnumAttribute("3353")]
        Item3353,


        [System.Xml.Serialization.XmlEnumAttribute("3354")]
        Item3354,


        [System.Xml.Serialization.XmlEnumAttribute("3355")]
        Item3355,


        [System.Xml.Serialization.XmlEnumAttribute("3356")]
        Item3356,


        [System.Xml.Serialization.XmlEnumAttribute("3503")]
        Item3503,


        [System.Xml.Serialization.XmlEnumAttribute("3551")]
        Item3551,


        [System.Xml.Serialization.XmlEnumAttribute("3553")]
        Item3553,


        [System.Xml.Serialization.XmlEnumAttribute("3556")]
        Item3556,


        [System.Xml.Serialization.XmlEnumAttribute("3651")]
        Item3651,


        [System.Xml.Serialization.XmlEnumAttribute("3652")]
        Item3652,


        [System.Xml.Serialization.XmlEnumAttribute("3653")]
        Item3653,


        [System.Xml.Serialization.XmlEnumAttribute("3930")]
        Item3930,


        [System.Xml.Serialization.XmlEnumAttribute("3949")]
        Item3949,


        [System.Xml.Serialization.XmlEnumAttribute("5101")]
        Item5101,


        [System.Xml.Serialization.XmlEnumAttribute("5102")]
        Item5102,


        [System.Xml.Serialization.XmlEnumAttribute("5103")]
        Item5103,


        [System.Xml.Serialization.XmlEnumAttribute("5104")]
        Item5104,


        [System.Xml.Serialization.XmlEnumAttribute("5105")]
        Item5105,


        [System.Xml.Serialization.XmlEnumAttribute("5106")]
        Item5106,


        [System.Xml.Serialization.XmlEnumAttribute("5109")]
        Item5109,


        [System.Xml.Serialization.XmlEnumAttribute("5110")]
        Item5110,


        [System.Xml.Serialization.XmlEnumAttribute("5111")]
        Item5111,


        [System.Xml.Serialization.XmlEnumAttribute("5112")]
        Item5112,


        [System.Xml.Serialization.XmlEnumAttribute("5113")]
        Item5113,


        [System.Xml.Serialization.XmlEnumAttribute("5114")]
        Item5114,


        [System.Xml.Serialization.XmlEnumAttribute("5115")]
        Item5115,


        [System.Xml.Serialization.XmlEnumAttribute("5116")]
        Item5116,


        [System.Xml.Serialization.XmlEnumAttribute("5117")]
        Item5117,


        [System.Xml.Serialization.XmlEnumAttribute("5118")]
        Item5118,


        [System.Xml.Serialization.XmlEnumAttribute("5119")]
        Item5119,


        [System.Xml.Serialization.XmlEnumAttribute("5120")]
        Item5120,


        [System.Xml.Serialization.XmlEnumAttribute("5122")]
        Item5122,


        [System.Xml.Serialization.XmlEnumAttribute("5123")]
        Item5123,


        [System.Xml.Serialization.XmlEnumAttribute("5124")]
        Item5124,


        [System.Xml.Serialization.XmlEnumAttribute("5125")]
        Item5125,


        [System.Xml.Serialization.XmlEnumAttribute("5151")]
        Item5151,


        [System.Xml.Serialization.XmlEnumAttribute("5152")]
        Item5152,


        [System.Xml.Serialization.XmlEnumAttribute("5153")]
        Item5153,


        [System.Xml.Serialization.XmlEnumAttribute("5155")]
        Item5155,


        [System.Xml.Serialization.XmlEnumAttribute("5156")]
        Item5156,


        [System.Xml.Serialization.XmlEnumAttribute("5201")]
        Item5201,


        [System.Xml.Serialization.XmlEnumAttribute("5202")]
        Item5202,


        [System.Xml.Serialization.XmlEnumAttribute("5205")]
        Item5205,


        [System.Xml.Serialization.XmlEnumAttribute("5206")]
        Item5206,


        [System.Xml.Serialization.XmlEnumAttribute("5207")]
        Item5207,


        [System.Xml.Serialization.XmlEnumAttribute("5208")]
        Item5208,


        [System.Xml.Serialization.XmlEnumAttribute("5209")]
        Item5209,


        [System.Xml.Serialization.XmlEnumAttribute("5210")]
        Item5210,


        [System.Xml.Serialization.XmlEnumAttribute("5251")]
        Item5251,


        [System.Xml.Serialization.XmlEnumAttribute("5252")]
        Item5252,


        [System.Xml.Serialization.XmlEnumAttribute("5253")]
        Item5253,


        [System.Xml.Serialization.XmlEnumAttribute("5254")]
        Item5254,


        [System.Xml.Serialization.XmlEnumAttribute("5255")]
        Item5255,


        [System.Xml.Serialization.XmlEnumAttribute("5256")]
        Item5256,


        [System.Xml.Serialization.XmlEnumAttribute("5257")]
        Item5257,


        [System.Xml.Serialization.XmlEnumAttribute("5258")]
        Item5258,


        [System.Xml.Serialization.XmlEnumAttribute("5401")]
        Item5401,


        [System.Xml.Serialization.XmlEnumAttribute("5402")]
        Item5402,


        [System.Xml.Serialization.XmlEnumAttribute("5403")]
        Item5403,


        [System.Xml.Serialization.XmlEnumAttribute("5405")]
        Item5405,


        [System.Xml.Serialization.XmlEnumAttribute("5408")]
        Item5408,


        [System.Xml.Serialization.XmlEnumAttribute("5409")]
        Item5409,


        [System.Xml.Serialization.XmlEnumAttribute("5410")]
        Item5410,


        [System.Xml.Serialization.XmlEnumAttribute("5411")]
        Item5411,


        [System.Xml.Serialization.XmlEnumAttribute("5412")]
        Item5412,


        [System.Xml.Serialization.XmlEnumAttribute("5413")]
        Item5413,


        [System.Xml.Serialization.XmlEnumAttribute("5414")]
        Item5414,


        [System.Xml.Serialization.XmlEnumAttribute("5415")]
        Item5415,


        [System.Xml.Serialization.XmlEnumAttribute("5451")]
        Item5451,


        [System.Xml.Serialization.XmlEnumAttribute("5501")]
        Item5501,


        [System.Xml.Serialization.XmlEnumAttribute("5502")]
        Item5502,


        [System.Xml.Serialization.XmlEnumAttribute("5503")]
        Item5503,


        [System.Xml.Serialization.XmlEnumAttribute("5504")]
        Item5504,


        [System.Xml.Serialization.XmlEnumAttribute("5505")]
        Item5505,


        [System.Xml.Serialization.XmlEnumAttribute("5551")]
        Item5551,


        [System.Xml.Serialization.XmlEnumAttribute("5552")]
        Item5552,


        [System.Xml.Serialization.XmlEnumAttribute("5553")]
        Item5553,


        [System.Xml.Serialization.XmlEnumAttribute("5554")]
        Item5554,


        [System.Xml.Serialization.XmlEnumAttribute("5555")]
        Item5555,


        [System.Xml.Serialization.XmlEnumAttribute("5556")]
        Item5556,


        [System.Xml.Serialization.XmlEnumAttribute("5557")]
        Item5557,


        [System.Xml.Serialization.XmlEnumAttribute("5601")]
        Item5601,


        [System.Xml.Serialization.XmlEnumAttribute("5602")]
        Item5602,


        [System.Xml.Serialization.XmlEnumAttribute("5603")]
        Item5603,


        [System.Xml.Serialization.XmlEnumAttribute("5605")]
        Item5605,


        [System.Xml.Serialization.XmlEnumAttribute("5606")]
        Item5606,


        [System.Xml.Serialization.XmlEnumAttribute("5651")]
        Item5651,


        [System.Xml.Serialization.XmlEnumAttribute("5652")]
        Item5652,


        [System.Xml.Serialization.XmlEnumAttribute("5653")]
        Item5653,


        [System.Xml.Serialization.XmlEnumAttribute("5654")]
        Item5654,


        [System.Xml.Serialization.XmlEnumAttribute("5655")]
        Item5655,


        [System.Xml.Serialization.XmlEnumAttribute("5656")]
        Item5656,


        [System.Xml.Serialization.XmlEnumAttribute("5657")]
        Item5657,


        [System.Xml.Serialization.XmlEnumAttribute("5658")]
        Item5658,


        [System.Xml.Serialization.XmlEnumAttribute("5659")]
        Item5659,


        [System.Xml.Serialization.XmlEnumAttribute("5660")]
        Item5660,


        [System.Xml.Serialization.XmlEnumAttribute("5661")]
        Item5661,


        [System.Xml.Serialization.XmlEnumAttribute("5662")]
        Item5662,


        [System.Xml.Serialization.XmlEnumAttribute("5663")]
        Item5663,


        [System.Xml.Serialization.XmlEnumAttribute("5664")]
        Item5664,


        [System.Xml.Serialization.XmlEnumAttribute("5665")]
        Item5665,


        [System.Xml.Serialization.XmlEnumAttribute("5666")]
        Item5666,


        [System.Xml.Serialization.XmlEnumAttribute("5667")]
        Item5667,


        [System.Xml.Serialization.XmlEnumAttribute("5901")]
        Item5901,


        [System.Xml.Serialization.XmlEnumAttribute("5902")]
        Item5902,


        [System.Xml.Serialization.XmlEnumAttribute("5903")]
        Item5903,


        [System.Xml.Serialization.XmlEnumAttribute("5904")]
        Item5904,


        [System.Xml.Serialization.XmlEnumAttribute("5905")]
        Item5905,


        [System.Xml.Serialization.XmlEnumAttribute("5906")]
        Item5906,


        [System.Xml.Serialization.XmlEnumAttribute("5907")]
        Item5907,


        [System.Xml.Serialization.XmlEnumAttribute("5908")]
        Item5908,


        [System.Xml.Serialization.XmlEnumAttribute("5909")]
        Item5909,


        [System.Xml.Serialization.XmlEnumAttribute("5910")]
        Item5910,


        [System.Xml.Serialization.XmlEnumAttribute("5911")]
        Item5911,


        [System.Xml.Serialization.XmlEnumAttribute("5912")]
        Item5912,


        [System.Xml.Serialization.XmlEnumAttribute("5913")]
        Item5913,


        [System.Xml.Serialization.XmlEnumAttribute("5914")]
        Item5914,


        [System.Xml.Serialization.XmlEnumAttribute("5915")]
        Item5915,


        [System.Xml.Serialization.XmlEnumAttribute("5916")]
        Item5916,


        [System.Xml.Serialization.XmlEnumAttribute("5917")]
        Item5917,


        [System.Xml.Serialization.XmlEnumAttribute("5918")]
        Item5918,


        [System.Xml.Serialization.XmlEnumAttribute("5919")]
        Item5919,


        [System.Xml.Serialization.XmlEnumAttribute("5920")]
        Item5920,


        [System.Xml.Serialization.XmlEnumAttribute("5921")]
        Item5921,


        [System.Xml.Serialization.XmlEnumAttribute("5922")]
        Item5922,


        [System.Xml.Serialization.XmlEnumAttribute("5923")]
        Item5923,


        [System.Xml.Serialization.XmlEnumAttribute("5924")]
        Item5924,


        [System.Xml.Serialization.XmlEnumAttribute("5925")]
        Item5925,


        [System.Xml.Serialization.XmlEnumAttribute("5926")]
        Item5926,


        [System.Xml.Serialization.XmlEnumAttribute("5927")]
        Item5927,


        [System.Xml.Serialization.XmlEnumAttribute("5928")]
        Item5928,


        [System.Xml.Serialization.XmlEnumAttribute("5929")]
        Item5929,


        [System.Xml.Serialization.XmlEnumAttribute("5931")]
        Item5931,


        [System.Xml.Serialization.XmlEnumAttribute("5932")]
        Item5932,


        [System.Xml.Serialization.XmlEnumAttribute("5933")]
        Item5933,


        [System.Xml.Serialization.XmlEnumAttribute("5934")]
        Item5934,


        [System.Xml.Serialization.XmlEnumAttribute("5949")]
        Item5949,


        [System.Xml.Serialization.XmlEnumAttribute("6101")]
        Item6101,


        [System.Xml.Serialization.XmlEnumAttribute("6102")]
        Item6102,


        [System.Xml.Serialization.XmlEnumAttribute("6103")]
        Item6103,


        [System.Xml.Serialization.XmlEnumAttribute("6104")]
        Item6104,


        [System.Xml.Serialization.XmlEnumAttribute("6105")]
        Item6105,


        [System.Xml.Serialization.XmlEnumAttribute("6106")]
        Item6106,


        [System.Xml.Serialization.XmlEnumAttribute("6107")]
        Item6107,


        [System.Xml.Serialization.XmlEnumAttribute("6108")]
        Item6108,


        [System.Xml.Serialization.XmlEnumAttribute("6109")]
        Item6109,


        [System.Xml.Serialization.XmlEnumAttribute("6110")]
        Item6110,


        [System.Xml.Serialization.XmlEnumAttribute("6111")]
        Item6111,


        [System.Xml.Serialization.XmlEnumAttribute("6112")]
        Item6112,


        [System.Xml.Serialization.XmlEnumAttribute("6113")]
        Item6113,


        [System.Xml.Serialization.XmlEnumAttribute("6114")]
        Item6114,


        [System.Xml.Serialization.XmlEnumAttribute("6115")]
        Item6115,


        [System.Xml.Serialization.XmlEnumAttribute("6116")]
        Item6116,


        [System.Xml.Serialization.XmlEnumAttribute("6117")]
        Item6117,


        [System.Xml.Serialization.XmlEnumAttribute("6118")]
        Item6118,


        [System.Xml.Serialization.XmlEnumAttribute("6119")]
        Item6119,


        [System.Xml.Serialization.XmlEnumAttribute("6120")]
        Item6120,


        [System.Xml.Serialization.XmlEnumAttribute("6122")]
        Item6122,


        [System.Xml.Serialization.XmlEnumAttribute("6123")]
        Item6123,


        [System.Xml.Serialization.XmlEnumAttribute("6124")]
        Item6124,


        [System.Xml.Serialization.XmlEnumAttribute("6125")]
        Item6125,


        [System.Xml.Serialization.XmlEnumAttribute("6151")]
        Item6151,


        [System.Xml.Serialization.XmlEnumAttribute("6152")]
        Item6152,


        [System.Xml.Serialization.XmlEnumAttribute("6153")]
        Item6153,


        [System.Xml.Serialization.XmlEnumAttribute("6155")]
        Item6155,


        [System.Xml.Serialization.XmlEnumAttribute("6156")]
        Item6156,


        [System.Xml.Serialization.XmlEnumAttribute("6201")]
        Item6201,


        [System.Xml.Serialization.XmlEnumAttribute("6202")]
        Item6202,


        [System.Xml.Serialization.XmlEnumAttribute("6205")]
        Item6205,


        [System.Xml.Serialization.XmlEnumAttribute("6206")]
        Item6206,


        [System.Xml.Serialization.XmlEnumAttribute("6207")]
        Item6207,


        [System.Xml.Serialization.XmlEnumAttribute("6208")]
        Item6208,


        [System.Xml.Serialization.XmlEnumAttribute("6209")]
        Item6209,


        [System.Xml.Serialization.XmlEnumAttribute("6210")]
        Item6210,


        [System.Xml.Serialization.XmlEnumAttribute("6251")]
        Item6251,


        [System.Xml.Serialization.XmlEnumAttribute("6252")]
        Item6252,


        [System.Xml.Serialization.XmlEnumAttribute("6253")]
        Item6253,


        [System.Xml.Serialization.XmlEnumAttribute("6254")]
        Item6254,


        [System.Xml.Serialization.XmlEnumAttribute("6255")]
        Item6255,


        [System.Xml.Serialization.XmlEnumAttribute("6256")]
        Item6256,


        [System.Xml.Serialization.XmlEnumAttribute("6257")]
        Item6257,


        [System.Xml.Serialization.XmlEnumAttribute("6258")]
        Item6258,


        [System.Xml.Serialization.XmlEnumAttribute("6401")]
        Item6401,


        [System.Xml.Serialization.XmlEnumAttribute("6402")]
        Item6402,


        [System.Xml.Serialization.XmlEnumAttribute("6403")]
        Item6403,


        [System.Xml.Serialization.XmlEnumAttribute("6404")]
        Item6404,


        [System.Xml.Serialization.XmlEnumAttribute("6408")]
        Item6408,


        [System.Xml.Serialization.XmlEnumAttribute("6409")]
        Item6409,


        [System.Xml.Serialization.XmlEnumAttribute("6410")]
        Item6410,


        [System.Xml.Serialization.XmlEnumAttribute("6411")]
        Item6411,


        [System.Xml.Serialization.XmlEnumAttribute("6412")]
        Item6412,


        [System.Xml.Serialization.XmlEnumAttribute("6413")]
        Item6413,


        [System.Xml.Serialization.XmlEnumAttribute("6414")]
        Item6414,


        [System.Xml.Serialization.XmlEnumAttribute("6415")]
        Item6415,


        [System.Xml.Serialization.XmlEnumAttribute("6501")]
        Item6501,


        [System.Xml.Serialization.XmlEnumAttribute("6502")]
        Item6502,


        [System.Xml.Serialization.XmlEnumAttribute("6503")]
        Item6503,


        [System.Xml.Serialization.XmlEnumAttribute("6504")]
        Item6504,


        [System.Xml.Serialization.XmlEnumAttribute("6505")]
        Item6505,


        [System.Xml.Serialization.XmlEnumAttribute("6551")]
        Item6551,


        [System.Xml.Serialization.XmlEnumAttribute("6552")]
        Item6552,


        [System.Xml.Serialization.XmlEnumAttribute("6553")]
        Item6553,


        [System.Xml.Serialization.XmlEnumAttribute("6554")]
        Item6554,


        [System.Xml.Serialization.XmlEnumAttribute("6555")]
        Item6555,


        [System.Xml.Serialization.XmlEnumAttribute("6556")]
        Item6556,


        [System.Xml.Serialization.XmlEnumAttribute("6557")]
        Item6557,


        [System.Xml.Serialization.XmlEnumAttribute("6603")]
        Item6603,


        [System.Xml.Serialization.XmlEnumAttribute("6651")]
        Item6651,


        [System.Xml.Serialization.XmlEnumAttribute("6652")]
        Item6652,


        [System.Xml.Serialization.XmlEnumAttribute("6653")]
        Item6653,


        [System.Xml.Serialization.XmlEnumAttribute("6654")]
        Item6654,


        [System.Xml.Serialization.XmlEnumAttribute("6655")]
        Item6655,


        [System.Xml.Serialization.XmlEnumAttribute("6656")]
        Item6656,


        [System.Xml.Serialization.XmlEnumAttribute("6657")]
        Item6657,


        [System.Xml.Serialization.XmlEnumAttribute("6658")]
        Item6658,


        [System.Xml.Serialization.XmlEnumAttribute("6659")]
        Item6659,


        [System.Xml.Serialization.XmlEnumAttribute("6660")]
        Item6660,


        [System.Xml.Serialization.XmlEnumAttribute("6661")]
        Item6661,


        [System.Xml.Serialization.XmlEnumAttribute("6662")]
        Item6662,


        [System.Xml.Serialization.XmlEnumAttribute("6663")]
        Item6663,


        [System.Xml.Serialization.XmlEnumAttribute("6664")]
        Item6664,


        [System.Xml.Serialization.XmlEnumAttribute("6665")]
        Item6665,


        [System.Xml.Serialization.XmlEnumAttribute("6666")]
        Item6666,


        [System.Xml.Serialization.XmlEnumAttribute("6667")]
        Item6667,


        [System.Xml.Serialization.XmlEnumAttribute("6901")]
        Item6901,


        [System.Xml.Serialization.XmlEnumAttribute("6902")]
        Item6902,


        [System.Xml.Serialization.XmlEnumAttribute("6903")]
        Item6903,


        [System.Xml.Serialization.XmlEnumAttribute("6904")]
        Item6904,


        [System.Xml.Serialization.XmlEnumAttribute("6905")]
        Item6905,


        [System.Xml.Serialization.XmlEnumAttribute("6906")]
        Item6906,


        [System.Xml.Serialization.XmlEnumAttribute("6907")]
        Item6907,


        [System.Xml.Serialization.XmlEnumAttribute("6908")]
        Item6908,


        [System.Xml.Serialization.XmlEnumAttribute("6909")]
        Item6909,


        [System.Xml.Serialization.XmlEnumAttribute("6910")]
        Item6910,


        [System.Xml.Serialization.XmlEnumAttribute("6911")]
        Item6911,


        [System.Xml.Serialization.XmlEnumAttribute("6912")]
        Item6912,


        [System.Xml.Serialization.XmlEnumAttribute("6913")]
        Item6913,


        [System.Xml.Serialization.XmlEnumAttribute("6914")]
        Item6914,


        [System.Xml.Serialization.XmlEnumAttribute("6915")]
        Item6915,


        [System.Xml.Serialization.XmlEnumAttribute("6916")]
        Item6916,


        [System.Xml.Serialization.XmlEnumAttribute("6917")]
        Item6917,


        [System.Xml.Serialization.XmlEnumAttribute("6918")]
        Item6918,


        [System.Xml.Serialization.XmlEnumAttribute("6919")]
        Item6919,


        [System.Xml.Serialization.XmlEnumAttribute("6920")]
        Item6920,


        [System.Xml.Serialization.XmlEnumAttribute("6921")]
        Item6921,


        [System.Xml.Serialization.XmlEnumAttribute("6922")]
        Item6922,


        [System.Xml.Serialization.XmlEnumAttribute("6923")]
        Item6923,


        [System.Xml.Serialization.XmlEnumAttribute("6924")]
        Item6924,


        [System.Xml.Serialization.XmlEnumAttribute("6925")]
        Item6925,


        [System.Xml.Serialization.XmlEnumAttribute("6929")]
        Item6929,


        [System.Xml.Serialization.XmlEnumAttribute("6931")]
        Item6931,


        [System.Xml.Serialization.XmlEnumAttribute("6932")]
        Item6932,


        [System.Xml.Serialization.XmlEnumAttribute("6933")]
        Item6933,


        [System.Xml.Serialization.XmlEnumAttribute("6934")]
        Item6934,


        [System.Xml.Serialization.XmlEnumAttribute("6949")]
        Item6949,


        [System.Xml.Serialization.XmlEnumAttribute("7101")]
        Item7101,


        [System.Xml.Serialization.XmlEnumAttribute("7102")]
        Item7102,


        [System.Xml.Serialization.XmlEnumAttribute("7105")]
        Item7105,


        [System.Xml.Serialization.XmlEnumAttribute("7106")]
        Item7106,


        [System.Xml.Serialization.XmlEnumAttribute("7127")]
        Item7127,


        [System.Xml.Serialization.XmlEnumAttribute("7201")]
        Item7201,


        [System.Xml.Serialization.XmlEnumAttribute("7202")]
        Item7202,


        [System.Xml.Serialization.XmlEnumAttribute("7205")]
        Item7205,


        [System.Xml.Serialization.XmlEnumAttribute("7206")]
        Item7206,


        [System.Xml.Serialization.XmlEnumAttribute("7207")]
        Item7207,


        [System.Xml.Serialization.XmlEnumAttribute("7210")]
        Item7210,


        [System.Xml.Serialization.XmlEnumAttribute("7211")]
        Item7211,


        [System.Xml.Serialization.XmlEnumAttribute("7251")]
        Item7251,


        [System.Xml.Serialization.XmlEnumAttribute("7501")]
        Item7501,


        [System.Xml.Serialization.XmlEnumAttribute("7551")]
        Item7551,


        [System.Xml.Serialization.XmlEnumAttribute("7553")]
        Item7553,


        [System.Xml.Serialization.XmlEnumAttribute("7556")]
        Item7556,


        [System.Xml.Serialization.XmlEnumAttribute("7651")]
        Item7651,


        [System.Xml.Serialization.XmlEnumAttribute("7654")]
        Item7654,


        [System.Xml.Serialization.XmlEnumAttribute("7667")]
        Item7667,


        [System.Xml.Serialization.XmlEnumAttribute("7930")]
        Item7930,


        [System.Xml.Serialization.XmlEnumAttribute("7949")]
        Item7949,
    }



    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetProdIndTot
    {


        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,


        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,
    }



    [Serializable]


    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetProdDI
    {


        public string nDI{get;set;}


        public string dDI{get;set;}


        public string xLocDesemb{get;set;}


        public TUfEmi UFDesemb{get;set;}


        public string dDesemb{get;set;}


        public TNFeInfNFeDetProdDITpViaTransp tpViaTransp{get;set;}


        public string vAFRMM{get;set;}


        public TNFeInfNFeDetProdDITpIntermedio tpIntermedio{get;set;}


        public string CNPJ{get;set;}


        public TUfEmi UFTerceiro{get;set;}


        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool UFTerceiroSpecified{get;set;}


        public string cExportador{get;set;}


        [System.Xml.Serialization.XmlElementAttribute("adi")]
        public TNFeInfNFeDetProdDIAdi[] adi{get;set;}
    }



    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetProdDITpViaTransp
    {


        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,


        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,


        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,


        [System.Xml.Serialization.XmlEnumAttribute("4")]
        Item4,


        [System.Xml.Serialization.XmlEnumAttribute("5")]
        Item5,


        [System.Xml.Serialization.XmlEnumAttribute("6")]
        Item6,


        [System.Xml.Serialization.XmlEnumAttribute("7")]
        Item7,


        [System.Xml.Serialization.XmlEnumAttribute("8")]
        Item8,


        [System.Xml.Serialization.XmlEnumAttribute("9")]
        Item9,


        [System.Xml.Serialization.XmlEnumAttribute("10")]
        Item10,


        [System.Xml.Serialization.XmlEnumAttribute("11")]
        Item11,


        [System.Xml.Serialization.XmlEnumAttribute("12")]
        Item12,
    }



    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetProdDITpIntermedio
    {


        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,


        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,


        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,
    }



    [Serializable]


    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetProdDIAdi
    {


        public string nAdicao{get;set;}


        public string nSeqAdic{get;set;}


        public string cFabricante{get;set;}


        public string vDescDI{get;set;}


        public string nDraw{get;set;}
    }



    [Serializable]


    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetProdDetExport
    {


        public string nDraw{get;set;}


        public TNFeInfNFeDetProdDetExportExportInd exportInd{get;set;}
    }



    [Serializable]


    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetProdDetExportExportInd
    {


        public string nRE{get;set;}


        public string chNFe{get;set;}


        public string qExport{get;set;}
    }



    [Serializable]


    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetProdArma
    {


        public TNFeInfNFeDetProdArmaTpArma tpArma{get;set;}


        public string nSerie{get;set;}


        public string nCano{get;set;}


        public string descr{get;set;}
    }



    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetProdArmaTpArma
    {


        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,


        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,
    }



    [Serializable]


    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetProdComb
    {


        public TcProdANP cProdANP{get;set;}


        public string pMixGN{get;set;}


        public string CODIF{get;set;}


        public string qTemp{get;set;}


        public TUf UFCons{get;set;}


        public TNFeInfNFeDetProdCombCIDE CIDE{get;set;}
    }



    [Serializable]
    [XmlType(Namespace = Namespaces.NFe)]
    public enum TcProdANP
    {


        [System.Xml.Serialization.XmlEnumAttribute("110203073")]
        Item110203073,


        [System.Xml.Serialization.XmlEnumAttribute("110204001")]
        Item110204001,


        [System.Xml.Serialization.XmlEnumAttribute("110204002")]
        Item110204002,


        [System.Xml.Serialization.XmlEnumAttribute("140101027")]
        Item140101027,


        [System.Xml.Serialization.XmlEnumAttribute("140101026")]
        Item140101026,


        [System.Xml.Serialization.XmlEnumAttribute("740101005")]
        Item740101005,


        [System.Xml.Serialization.XmlEnumAttribute("740101004")]
        Item740101004,


        [System.Xml.Serialization.XmlEnumAttribute("740101001")]
        Item740101001,


        [System.Xml.Serialization.XmlEnumAttribute("740101006")]
        Item740101006,


        [System.Xml.Serialization.XmlEnumAttribute("740101002")]
        Item740101002,


        [System.Xml.Serialization.XmlEnumAttribute("110203083")]
        Item110203083,


        [System.Xml.Serialization.XmlEnumAttribute("910101001")]
        Item910101001,


        [System.Xml.Serialization.XmlEnumAttribute("110103001")]
        Item110103001,


        [System.Xml.Serialization.XmlEnumAttribute("330101001")]
        Item330101001,


        [System.Xml.Serialization.XmlEnumAttribute("110203091")]
        Item110203091,


        [System.Xml.Serialization.XmlEnumAttribute("120204001")]
        Item120204001,


        [System.Xml.Serialization.XmlEnumAttribute("110106001")]
        Item110106001,


        [System.Xml.Serialization.XmlEnumAttribute("120206001")]
        Item120206001,


        [System.Xml.Serialization.XmlEnumAttribute("110101001")]
        Item110101001,


        [System.Xml.Serialization.XmlEnumAttribute("110101042")]
        Item110101042,


        [System.Xml.Serialization.XmlEnumAttribute("810201001")]
        Item810201001,


        [System.Xml.Serialization.XmlEnumAttribute("110204003")]
        Item110204003,


        [System.Xml.Serialization.XmlEnumAttribute("330201005")]
        Item330201005,


        [System.Xml.Serialization.XmlEnumAttribute("330201006")]
        Item330201006,


        [System.Xml.Serialization.XmlEnumAttribute("330201004")]
        Item330201004,


        [System.Xml.Serialization.XmlEnumAttribute("110105001")]
        Item110105001,


        [System.Xml.Serialization.XmlEnumAttribute("110203072")]
        Item110203072,


        [System.Xml.Serialization.XmlEnumAttribute("110203001")]
        Item110203001,


        [System.Xml.Serialization.XmlEnumAttribute("110201001")]
        Item110201001,


        [System.Xml.Serialization.XmlEnumAttribute("110101002")]
        Item110101002,


        [System.Xml.Serialization.XmlEnumAttribute("110203002")]
        Item110203002,


        [System.Xml.Serialization.XmlEnumAttribute("120205010")]
        Item120205010,


        [System.Xml.Serialization.XmlEnumAttribute("110203003")]
        Item110203003,


        [System.Xml.Serialization.XmlEnumAttribute("110204004")]
        Item110204004,


        [System.Xml.Serialization.XmlEnumAttribute("110204005")]
        Item110204005,


        [System.Xml.Serialization.XmlEnumAttribute("110204006")]
        Item110204006,


        [System.Xml.Serialization.XmlEnumAttribute("110204007")]
        Item110204007,


        [System.Xml.Serialization.XmlEnumAttribute("110204008")]
        Item110204008,


        [System.Xml.Serialization.XmlEnumAttribute("110204009")]
        Item110204009,


        [System.Xml.Serialization.XmlEnumAttribute("110204010")]
        Item110204010,


        [System.Xml.Serialization.XmlEnumAttribute("110204011")]
        Item110204011,


        [System.Xml.Serialization.XmlEnumAttribute("110105027")]
        Item110105027,


        [System.Xml.Serialization.XmlEnumAttribute("110103003")]
        Item110103003,


        [System.Xml.Serialization.XmlEnumAttribute("110103002")]
        Item110103002,


        [System.Xml.Serialization.XmlEnumAttribute("110105002")]
        Item110105002,


        [System.Xml.Serialization.XmlEnumAttribute("110205001")]
        Item110205001,


        [System.Xml.Serialization.XmlEnumAttribute("120203002")]
        Item120203002,


        [System.Xml.Serialization.XmlEnumAttribute("120205001")]
        Item120205001,


        [System.Xml.Serialization.XmlEnumAttribute("110203004")]
        Item110203004,


        [System.Xml.Serialization.XmlEnumAttribute("120203001")]
        Item120203001,


        [System.Xml.Serialization.XmlEnumAttribute("530102001")]
        Item530102001,


        [System.Xml.Serialization.XmlEnumAttribute("530101002")]
        Item530101002,


        [System.Xml.Serialization.XmlEnumAttribute("110108001")]
        Item110108001,


        [System.Xml.Serialization.XmlEnumAttribute("110105017")]
        Item110105017,


        [System.Xml.Serialization.XmlEnumAttribute("110206019")]
        Item110206019,


        [System.Xml.Serialization.XmlEnumAttribute("110205023")]
        Item110205023,


        [System.Xml.Serialization.XmlEnumAttribute("110203092")]
        Item110203092,


        [System.Xml.Serialization.XmlEnumAttribute("110201002")]
        Item110201002,


        [System.Xml.Serialization.XmlEnumAttribute("120202001")]
        Item120202001,


        [System.Xml.Serialization.XmlEnumAttribute("110101003")]
        Item110101003,


        [System.Xml.Serialization.XmlEnumAttribute("110101004")]
        Item110101004,


        [System.Xml.Serialization.XmlEnumAttribute("110103004")]
        Item110103004,


        [System.Xml.Serialization.XmlEnumAttribute("110103005")]
        Item110103005,


        [System.Xml.Serialization.XmlEnumAttribute("110101005")]
        Item110101005,


        [System.Xml.Serialization.XmlEnumAttribute("110204012")]
        Item110204012,


        [System.Xml.Serialization.XmlEnumAttribute("110204013")]
        Item110204013,


        [System.Xml.Serialization.XmlEnumAttribute("110204014")]
        Item110204014,


        [System.Xml.Serialization.XmlEnumAttribute("110102001")]
        Item110102001,


        [System.Xml.Serialization.XmlEnumAttribute("120207003")]
        Item120207003,


        [System.Xml.Serialization.XmlEnumAttribute("110201003")]
        Item110201003,


        [System.Xml.Serialization.XmlEnumAttribute("110201004")]
        Item110201004,


        [System.Xml.Serialization.XmlEnumAttribute("110201005")]
        Item110201005,


        [System.Xml.Serialization.XmlEnumAttribute("110201006")]
        Item110201006,


        [System.Xml.Serialization.XmlEnumAttribute("110206001")]
        Item110206001,


        [System.Xml.Serialization.XmlEnumAttribute("110205002")]
        Item110205002,


        [System.Xml.Serialization.XmlEnumAttribute("110203005")]
        Item110203005,


        [System.Xml.Serialization.XmlEnumAttribute("110205003")]
        Item110205003,


        [System.Xml.Serialization.XmlEnumAttribute("330201001")]
        Item330201001,


        [System.Xml.Serialization.XmlEnumAttribute("110206002")]
        Item110206002,


        [System.Xml.Serialization.XmlEnumAttribute("110101006")]
        Item110101006,


        [System.Xml.Serialization.XmlEnumAttribute("110101007")]
        Item110101007,


        [System.Xml.Serialization.XmlEnumAttribute("110101038")]
        Item110101038,


        [System.Xml.Serialization.XmlEnumAttribute("120205002")]
        Item120205002,


        [System.Xml.Serialization.XmlEnumAttribute("820101001")]
        Item820101001,


        [System.Xml.Serialization.XmlEnumAttribute("820101010")]
        Item820101010,


        [System.Xml.Serialization.XmlEnumAttribute("820101999")]
        Item820101999,


        [System.Xml.Serialization.XmlEnumAttribute("110206003")]
        Item110206003,


        [System.Xml.Serialization.XmlEnumAttribute("110201007")]
        Item110201007,


        [System.Xml.Serialization.XmlEnumAttribute("120201001")]
        Item120201001,


        [System.Xml.Serialization.XmlEnumAttribute("110201008")]
        Item110201008,


        [System.Xml.Serialization.XmlEnumAttribute("110103017")]
        Item110103017,


        [System.Xml.Serialization.XmlEnumAttribute("110205004")]
        Item110205004,


        [System.Xml.Serialization.XmlEnumAttribute("110203077")]
        Item110203077,


        [System.Xml.Serialization.XmlEnumAttribute("110101008")]
        Item110101008,


        [System.Xml.Serialization.XmlEnumAttribute("110203006")]
        Item110203006,


        [System.Xml.Serialization.XmlEnumAttribute("110203007")]
        Item110203007,


        [System.Xml.Serialization.XmlEnumAttribute("110201009")]
        Item110201009,


        [System.Xml.Serialization.XmlEnumAttribute("110203008")]
        Item110203008,


        [System.Xml.Serialization.XmlEnumAttribute("110203009")]
        Item110203009,


        [System.Xml.Serialization.XmlEnumAttribute("110203010")]
        Item110203010,


        [System.Xml.Serialization.XmlEnumAttribute("120203004")]
        Item120203004,


        [System.Xml.Serialization.XmlEnumAttribute("110206004")]
        Item110206004,


        [System.Xml.Serialization.XmlEnumAttribute("610101009")]
        Item610101009,


        [System.Xml.Serialization.XmlEnumAttribute("120205003")]
        Item120205003,


        [System.Xml.Serialization.XmlEnumAttribute("110205005")]
        Item110205005,


        [System.Xml.Serialization.XmlEnumAttribute("110203092")]
        Item1102030921,


        [System.Xml.Serialization.XmlEnumAttribute("110204015")]
        Item110204015,


        [System.Xml.Serialization.XmlEnumAttribute("210202003")]
        Item210202003,


        [System.Xml.Serialization.XmlEnumAttribute("210202001")]
        Item210202001,


        [System.Xml.Serialization.XmlEnumAttribute("210202002")]
        Item210202002,


        [System.Xml.Serialization.XmlEnumAttribute("110105018")]
        Item110105018,


        [System.Xml.Serialization.XmlEnumAttribute("110203011")]
        Item110203011,


        [System.Xml.Serialization.XmlEnumAttribute("110203012")]
        Item110203012,


        [System.Xml.Serialization.XmlEnumAttribute("110101009")]
        Item110101009,


        [System.Xml.Serialization.XmlEnumAttribute("110104001")]
        Item110104001,


        [System.Xml.Serialization.XmlEnumAttribute("110104006")]
        Item110104006,


        [System.Xml.Serialization.XmlEnumAttribute("110106010")]
        Item110106010,


        [System.Xml.Serialization.XmlEnumAttribute("110202007")]
        Item110202007,


        [System.Xml.Serialization.XmlEnumAttribute("110106002")]
        Item110106002,


        [System.Xml.Serialization.XmlEnumAttribute("110111002")]
        Item110111002,


        [System.Xml.Serialization.XmlEnumAttribute("110103006")]
        Item110103006,


        [System.Xml.Serialization.XmlEnumAttribute("110105003")]
        Item110105003,


        [System.Xml.Serialization.XmlEnumAttribute("110201010")]
        Item110201010,


        [System.Xml.Serialization.XmlEnumAttribute("110201011")]
        Item110201011,


        [System.Xml.Serialization.XmlEnumAttribute("110201012")]
        Item110201012,


        [System.Xml.Serialization.XmlEnumAttribute("110101010")]
        Item110101010,


        [System.Xml.Serialization.XmlEnumAttribute("110101011")]
        Item110101011,


        [System.Xml.Serialization.XmlEnumAttribute("110108002")]
        Item110108002,


        [System.Xml.Serialization.XmlEnumAttribute("110107001")]
        Item110107001,


        [System.Xml.Serialization.XmlEnumAttribute("120202002")]
        Item120202002,


        [System.Xml.Serialization.XmlEnumAttribute("110106003")]
        Item110106003,


        [System.Xml.Serialization.XmlEnumAttribute("110108003")]
        Item110108003,


        [System.Xml.Serialization.XmlEnumAttribute("110203085")]
        Item110203085,


        [System.Xml.Serialization.XmlEnumAttribute("110201013")]
        Item110201013,


        [System.Xml.Serialization.XmlEnumAttribute("110207001")]
        Item110207001,


        [System.Xml.Serialization.XmlEnumAttribute("110105023")]
        Item110105023,


        [System.Xml.Serialization.XmlEnumAttribute("110101012")]
        Item110101012,


        [System.Xml.Serialization.XmlEnumAttribute("110201014")]
        Item110201014,


        [System.Xml.Serialization.XmlEnumAttribute("620501002")]
        Item620501002,


        [System.Xml.Serialization.XmlEnumAttribute("620501001")]
        Item620501001,


        [System.Xml.Serialization.XmlEnumAttribute("610101005")]
        Item610101005,


        [System.Xml.Serialization.XmlEnumAttribute("610101006")]
        Item610101006,


        [System.Xml.Serialization.XmlEnumAttribute("530101001")]
        Item530101001,


        [System.Xml.Serialization.XmlEnumAttribute("530101020")]
        Item530101020,


        [System.Xml.Serialization.XmlEnumAttribute("530101018")]
        Item530101018,


        [System.Xml.Serialization.XmlEnumAttribute("110205006")]
        Item110205006,


        [System.Xml.Serialization.XmlEnumAttribute("110201015")]
        Item110201015,


        [System.Xml.Serialization.XmlEnumAttribute("110203013")]
        Item110203013,


        [System.Xml.Serialization.XmlEnumAttribute("110202001")]
        Item110202001,


        [System.Xml.Serialization.XmlEnumAttribute("120104001")]
        Item120104001,


        [System.Xml.Serialization.XmlEnumAttribute("120102001")]
        Item120102001,


        [System.Xml.Serialization.XmlEnumAttribute("110205024")]
        Item110205024,


        [System.Xml.Serialization.XmlEnumAttribute("120205009")]
        Item120205009,


        [System.Xml.Serialization.XmlEnumAttribute("540101002")]
        Item540101002,


        [System.Xml.Serialization.XmlEnumAttribute("540101001")]
        Item540101001,


        [System.Xml.Serialization.XmlEnumAttribute("110107002")]
        Item110107002,


        [System.Xml.Serialization.XmlEnumAttribute("620601003")]
        Item620601003,


        [System.Xml.Serialization.XmlEnumAttribute("110201016")]
        Item110201016,


        [System.Xml.Serialization.XmlEnumAttribute("110101013")]
        Item110101013,


        [System.Xml.Serialization.XmlEnumAttribute("120207001")]
        Item120207001,


        [System.Xml.Serialization.XmlEnumAttribute("110206020")]
        Item110206020,


        [System.Xml.Serialization.XmlEnumAttribute("110104008")]
        Item110104008,


        [System.Xml.Serialization.XmlEnumAttribute("110201017")]
        Item110201017,


        [System.Xml.Serialization.XmlEnumAttribute("110108004")]
        Item110108004,


        [System.Xml.Serialization.XmlEnumAttribute("110201018")]
        Item110201018,


        [System.Xml.Serialization.XmlEnumAttribute("330201007")]
        Item330201007,


        [System.Xml.Serialization.XmlEnumAttribute("110205007")]
        Item110205007,


        [System.Xml.Serialization.XmlEnumAttribute("110203086")]
        Item110203086,


        [System.Xml.Serialization.XmlEnumAttribute("110205008")]
        Item110205008,


        [System.Xml.Serialization.XmlEnumAttribute("340101002")]
        Item340101002,


        [System.Xml.Serialization.XmlEnumAttribute("130202002")]
        Item130202002,


        [System.Xml.Serialization.XmlEnumAttribute("430101002")]
        Item430101002,


        [System.Xml.Serialization.XmlEnumAttribute("130202003")]
        Item130202003,


        [System.Xml.Serialization.XmlEnumAttribute("560101002")]
        Item560101002,


        [System.Xml.Serialization.XmlEnumAttribute("130202004")]
        Item130202004,


        [System.Xml.Serialization.XmlEnumAttribute("820101026")]
        Item820101026,


        [System.Xml.Serialization.XmlEnumAttribute("820101032")]
        Item820101032,


        [System.Xml.Serialization.XmlEnumAttribute("820101027")]
        Item820101027,


        [System.Xml.Serialization.XmlEnumAttribute("820101004")]
        Item820101004,


        [System.Xml.Serialization.XmlEnumAttribute("820101005")]
        Item820101005,


        [System.Xml.Serialization.XmlEnumAttribute("820101022")]
        Item820101022,


        [System.Xml.Serialization.XmlEnumAttribute("820101007")]
        Item820101007,


        [System.Xml.Serialization.XmlEnumAttribute("820101002")]
        Item820101002,


        [System.Xml.Serialization.XmlEnumAttribute("820101009")]
        Item820101009,


        [System.Xml.Serialization.XmlEnumAttribute("820101008")]
        Item820101008,


        [System.Xml.Serialization.XmlEnumAttribute("820101014")]
        Item820101014,


        [System.Xml.Serialization.XmlEnumAttribute("820101006")]
        Item820101006,


        [System.Xml.Serialization.XmlEnumAttribute("820101016")]
        Item820101016,


        [System.Xml.Serialization.XmlEnumAttribute("820101015")]
        Item820101015,


        [System.Xml.Serialization.XmlEnumAttribute("820101014")]
        Item8201010141,


        [System.Xml.Serialization.XmlEnumAttribute("820101006")]
        Item8201010061,


        [System.Xml.Serialization.XmlEnumAttribute("820101031")]
        Item820101031,


        [System.Xml.Serialization.XmlEnumAttribute("820101030")]
        Item820101030,


        [System.Xml.Serialization.XmlEnumAttribute("820101016")]
        Item8201010161,


        [System.Xml.Serialization.XmlEnumAttribute("820101015")]
        Item8201010151,


        [System.Xml.Serialization.XmlEnumAttribute("820101025")]
        Item820101025,


        [System.Xml.Serialization.XmlEnumAttribute("820101007")]
        Item8201010071,


        [System.Xml.Serialization.XmlEnumAttribute("820101002")]
        Item8201010021,


        [System.Xml.Serialization.XmlEnumAttribute("820101026")]
        Item8201010261,


        [System.Xml.Serialization.XmlEnumAttribute("820101009")]
        Item8201010091,


        [System.Xml.Serialization.XmlEnumAttribute("820101008")]
        Item8201010081,


        [System.Xml.Serialization.XmlEnumAttribute("820101027")]
        Item8201010271,


        [System.Xml.Serialization.XmlEnumAttribute("820101007")]
        Item8201010072,


        [System.Xml.Serialization.XmlEnumAttribute("820101002")]
        Item8201010022,


        [System.Xml.Serialization.XmlEnumAttribute("820101028")]
        Item820101028,


        [System.Xml.Serialization.XmlEnumAttribute("820101029")]
        Item820101029,


        [System.Xml.Serialization.XmlEnumAttribute("820101009")]
        Item8201010092,


        [System.Xml.Serialization.XmlEnumAttribute("820101008")]
        Item8201010082,


        [System.Xml.Serialization.XmlEnumAttribute("820101011")]
        Item820101011,


        [System.Xml.Serialization.XmlEnumAttribute("820101003")]
        Item820101003,


        [System.Xml.Serialization.XmlEnumAttribute("820101013")]
        Item820101013,


        [System.Xml.Serialization.XmlEnumAttribute("820101012")]
        Item820101012,


        [System.Xml.Serialization.XmlEnumAttribute("820101017")]
        Item820101017,


        [System.Xml.Serialization.XmlEnumAttribute("820101018")]
        Item820101018,


        [System.Xml.Serialization.XmlEnumAttribute("820101019")]
        Item820101019,


        [System.Xml.Serialization.XmlEnumAttribute("820101020")]
        Item820101020,


        [System.Xml.Serialization.XmlEnumAttribute("820101021")]
        Item820101021,


        [System.Xml.Serialization.XmlEnumAttribute("330101003")]
        Item330101003,


        [System.Xml.Serialization.XmlEnumAttribute("130202006")]
        Item130202006,


        [System.Xml.Serialization.XmlEnumAttribute("110203014")]
        Item110203014,


        [System.Xml.Serialization.XmlEnumAttribute("420201001")]
        Item420201001,


        [System.Xml.Serialization.XmlEnumAttribute("420201003")]
        Item420201003,


        [System.Xml.Serialization.XmlEnumAttribute("120204010")]
        Item120204010,


        [System.Xml.Serialization.XmlEnumAttribute("110103007")]
        Item110103007,


        [System.Xml.Serialization.XmlEnumAttribute("110204017")]
        Item110204017,


        [System.Xml.Serialization.XmlEnumAttribute("110204051")]
        Item110204051,


        [System.Xml.Serialization.XmlEnumAttribute("110204018")]
        Item110204018,


        [System.Xml.Serialization.XmlEnumAttribute("110205022")]
        Item110205022,


        [System.Xml.Serialization.XmlEnumAttribute("110203069")]
        Item110203069,


        [System.Xml.Serialization.XmlEnumAttribute("110203015")]
        Item110203015,


        [System.Xml.Serialization.XmlEnumAttribute("110206005")]
        Item110206005,


        [System.Xml.Serialization.XmlEnumAttribute("110203016")]
        Item110203016,


        [System.Xml.Serialization.XmlEnumAttribute("110203017")]
        Item110203017,


        [System.Xml.Serialization.XmlEnumAttribute("110203018")]
        Item110203018,


        [System.Xml.Serialization.XmlEnumAttribute("110203088")]
        Item110203088,


        [System.Xml.Serialization.XmlEnumAttribute("110203019")]
        Item110203019,


        [System.Xml.Serialization.XmlEnumAttribute("530101003")]
        Item530101003,


        [System.Xml.Serialization.XmlEnumAttribute("530101019")]
        Item530101019,


        [System.Xml.Serialization.XmlEnumAttribute("110101014")]
        Item110101014,


        [System.Xml.Serialization.XmlEnumAttribute("620101002")]
        Item620101002,


        [System.Xml.Serialization.XmlEnumAttribute("720101001")]
        Item720101001,


        [System.Xml.Serialization.XmlEnumAttribute("720101002")]
        Item720101002,


        [System.Xml.Serialization.XmlEnumAttribute("120205004")]
        Item120205004,


        [System.Xml.Serialization.XmlEnumAttribute("110203079")]
        Item110203079,


        [System.Xml.Serialization.XmlEnumAttribute("110203020")]
        Item110203020,


        [System.Xml.Serialization.XmlEnumAttribute("110201019")]
        Item110201019,


        [System.Xml.Serialization.XmlEnumAttribute("110203021")]
        Item110203021,


        [System.Xml.Serialization.XmlEnumAttribute("110108005")]
        Item110108005,


        [System.Xml.Serialization.XmlEnumAttribute("110101015")]
        Item110101015,


        [System.Xml.Serialization.XmlEnumAttribute("110104002")]
        Item110104002,


        [System.Xml.Serialization.XmlEnumAttribute("110101016")]
        Item110101016,


        [System.Xml.Serialization.XmlEnumAttribute("620101007")]
        Item620101007,


        [System.Xml.Serialization.XmlEnumAttribute("140102001")]
        Item140102001,


        [System.Xml.Serialization.XmlEnumAttribute("110105004")]
        Item110105004,


        [System.Xml.Serialization.XmlEnumAttribute("110107003")]
        Item110107003,


        [System.Xml.Serialization.XmlEnumAttribute("110203095")]
        Item110203095,


        [System.Xml.Serialization.XmlEnumAttribute("210301001")]
        Item210301001,


        [System.Xml.Serialization.XmlEnumAttribute("810102001")]
        Item810102001,


        [System.Xml.Serialization.XmlEnumAttribute("810102004")]
        Item810102004,


        [System.Xml.Serialization.XmlEnumAttribute("810102002")]
        Item810102002,


        [System.Xml.Serialization.XmlEnumAttribute("130201002")]
        Item130201002,


        [System.Xml.Serialization.XmlEnumAttribute("810102003")]
        Item810102003,


        [System.Xml.Serialization.XmlEnumAttribute("810101002")]
        Item810101002,


        [System.Xml.Serialization.XmlEnumAttribute("810101001")]
        Item810101001,


        [System.Xml.Serialization.XmlEnumAttribute("810101003")]
        Item810101003,


        [System.Xml.Serialization.XmlEnumAttribute("210301002")]
        Item210301002,


        [System.Xml.Serialization.XmlEnumAttribute("330201010")]
        Item330201010,


        [System.Xml.Serialization.XmlEnumAttribute("110204016")]
        Item110204016,


        [System.Xml.Serialization.XmlEnumAttribute("110105005")]
        Item110105005,


        [System.Xml.Serialization.XmlEnumAttribute("110105006")]
        Item110105006,


        [System.Xml.Serialization.XmlEnumAttribute("110105007")]
        Item110105007,


        [System.Xml.Serialization.XmlEnumAttribute("110104003")]
        Item110104003,


        [System.Xml.Serialization.XmlEnumAttribute("110206006")]
        Item110206006,


        [System.Xml.Serialization.XmlEnumAttribute("110206007")]
        Item110206007,


        [System.Xml.Serialization.XmlEnumAttribute("110203022")]
        Item110203022,


        [System.Xml.Serialization.XmlEnumAttribute("110204019")]
        Item110204019,


        [System.Xml.Serialization.XmlEnumAttribute("110206008")]
        Item110206008,


        [System.Xml.Serialization.XmlEnumAttribute("110206009")]
        Item110206009,


        [System.Xml.Serialization.XmlEnumAttribute("110101043")]
        Item110101043,


        [System.Xml.Serialization.XmlEnumAttribute("110201020")]
        Item110201020,


        [System.Xml.Serialization.XmlEnumAttribute("110203023")]
        Item110203023,


        [System.Xml.Serialization.XmlEnumAttribute("110101017")]
        Item110101017,


        [System.Xml.Serialization.XmlEnumAttribute("110101018")]
        Item110101018,


        [System.Xml.Serialization.XmlEnumAttribute("210302004")]
        Item210302004,


        [System.Xml.Serialization.XmlEnumAttribute("210101001")]
        Item210101001,


        [System.Xml.Serialization.XmlEnumAttribute("210302003")]
        Item210302003,


        [System.Xml.Serialization.XmlEnumAttribute("210302002")]
        Item210302002,


        [System.Xml.Serialization.XmlEnumAttribute("210204001")]
        Item210204001,


        [System.Xml.Serialization.XmlEnumAttribute("220101003")]
        Item220101003,


        [System.Xml.Serialization.XmlEnumAttribute("220101004")]
        Item220101004,


        [System.Xml.Serialization.XmlEnumAttribute("220101002")]
        Item220101002,


        [System.Xml.Serialization.XmlEnumAttribute("220101001")]
        Item220101001,


        [System.Xml.Serialization.XmlEnumAttribute("220101005")]
        Item220101005,


        [System.Xml.Serialization.XmlEnumAttribute("220101006")]
        Item220101006,


        [System.Xml.Serialization.XmlEnumAttribute("130202001")]
        Item130202001,


        [System.Xml.Serialization.XmlEnumAttribute("130202005")]
        Item130202005,


        [System.Xml.Serialization.XmlEnumAttribute("520101001")]
        Item520101001,


        [System.Xml.Serialization.XmlEnumAttribute("320101001")]
        Item320101001,


        [System.Xml.Serialization.XmlEnumAttribute("320101003")]
        Item320101003,


        [System.Xml.Serialization.XmlEnumAttribute("320101002")]
        Item320101002,


        [System.Xml.Serialization.XmlEnumAttribute("320103001")]
        Item320103001,


        [System.Xml.Serialization.XmlEnumAttribute("320102002")]
        Item320102002,


        [System.Xml.Serialization.XmlEnumAttribute("320102001")]
        Item320102001,


        [System.Xml.Serialization.XmlEnumAttribute("320102004")]
        Item320102004,


        [System.Xml.Serialization.XmlEnumAttribute("320102003")]
        Item320102003,


        [System.Xml.Serialization.XmlEnumAttribute("320201001")]
        Item320201001,


        [System.Xml.Serialization.XmlEnumAttribute("320201002")]
        Item320201002,


        [System.Xml.Serialization.XmlEnumAttribute("220102001")]
        Item220102001,


        [System.Xml.Serialization.XmlEnumAttribute("320301002")]
        Item320301002,


        [System.Xml.Serialization.XmlEnumAttribute("110204020")]
        Item110204020,


        [System.Xml.Serialization.XmlEnumAttribute("110203024")]
        Item110203024,


        [System.Xml.Serialization.XmlEnumAttribute("120205012")]
        Item120205012,


        [System.Xml.Serialization.XmlEnumAttribute("110207002")]
        Item110207002,


        [System.Xml.Serialization.XmlEnumAttribute("110203087")]
        Item110203087,


        [System.Xml.Serialization.XmlEnumAttribute("730101002")]
        Item730101002,


        [System.Xml.Serialization.XmlEnumAttribute("210203001")]
        Item210203001,


        [System.Xml.Serialization.XmlEnumAttribute("210203002")]
        Item210203002,


        [System.Xml.Serialization.XmlEnumAttribute("110104005")]
        Item110104005,


        [System.Xml.Serialization.XmlEnumAttribute("140101023")]
        Item140101023,


        [System.Xml.Serialization.XmlEnumAttribute("140101024")]
        Item140101024,


        [System.Xml.Serialization.XmlEnumAttribute("140101025")]
        Item140101025,


        [System.Xml.Serialization.XmlEnumAttribute("650101001")]
        Item650101001,


        [System.Xml.Serialization.XmlEnumAttribute("110207003")]
        Item110207003,


        [System.Xml.Serialization.XmlEnumAttribute("110201021")]
        Item110201021,


        [System.Xml.Serialization.XmlEnumAttribute("110103013")]
        Item110103013,


        [System.Xml.Serialization.XmlEnumAttribute("110201022")]
        Item110201022,


        [System.Xml.Serialization.XmlEnumAttribute("110203025")]
        Item110203025,


        [System.Xml.Serialization.XmlEnumAttribute("110203026")]
        Item110203026,


        [System.Xml.Serialization.XmlEnumAttribute("110206011")]
        Item110206011,


        [System.Xml.Serialization.XmlEnumAttribute("110206010")]
        Item110206010,


        [System.Xml.Serialization.XmlEnumAttribute("110203027")]
        Item110203027,


        [System.Xml.Serialization.XmlEnumAttribute("110203028")]
        Item110203028,


        [System.Xml.Serialization.XmlEnumAttribute("110203028")]
        Item1102030281,


        [System.Xml.Serialization.XmlEnumAttribute("330101008")]
        Item330101008,


        [System.Xml.Serialization.XmlEnumAttribute("330101002")]
        Item330101002,


        [System.Xml.Serialization.XmlEnumAttribute("330101009")]
        Item330101009,


        [System.Xml.Serialization.XmlEnumAttribute("620101001")]
        Item620101001,


        [System.Xml.Serialization.XmlEnumAttribute("610201001")]
        Item610201001,


        [System.Xml.Serialization.XmlEnumAttribute("610201002")]
        Item610201002,


        [System.Xml.Serialization.XmlEnumAttribute("610201003")]
        Item610201003,


        [System.Xml.Serialization.XmlEnumAttribute("710101001")]
        Item710101001,


        [System.Xml.Serialization.XmlEnumAttribute("110203074")]
        Item110203074,


        [System.Xml.Serialization.XmlEnumAttribute("110201023")]
        Item110201023,


        [System.Xml.Serialization.XmlEnumAttribute("110103008")]
        Item110103008,


        [System.Xml.Serialization.XmlEnumAttribute("110203029")]
        Item110203029,


        [System.Xml.Serialization.XmlEnumAttribute("120205005")]
        Item120205005,


        [System.Xml.Serialization.XmlEnumAttribute("110204021")]
        Item110204021,


        [System.Xml.Serialization.XmlEnumAttribute("110204022")]
        Item110204022,


        [System.Xml.Serialization.XmlEnumAttribute("110204023")]
        Item110204023,


        [System.Xml.Serialization.XmlEnumAttribute("620101004")]
        Item620101004,


        [System.Xml.Serialization.XmlEnumAttribute("620101005")]
        Item620101005,


        [System.Xml.Serialization.XmlEnumAttribute("330101010")]
        Item330101010,


        [System.Xml.Serialization.XmlEnumAttribute("110202002")]
        Item110202002,


        [System.Xml.Serialization.XmlEnumAttribute("110202003")]
        Item110202003,


        [System.Xml.Serialization.XmlEnumAttribute("110207004")]
        Item110207004,


        [System.Xml.Serialization.XmlEnumAttribute("110101046")]
        Item110101046,


        [System.Xml.Serialization.XmlEnumAttribute("110204024")]
        Item110204024,


        [System.Xml.Serialization.XmlEnumAttribute("110113001")]
        Item110113001,


        [System.Xml.Serialization.XmlEnumAttribute("110105015")]
        Item110105015,


        [System.Xml.Serialization.XmlEnumAttribute("110101019")]
        Item110101019,


        [System.Xml.Serialization.XmlEnumAttribute("110103015")]
        Item110103015,


        [System.Xml.Serialization.XmlEnumAttribute("110205025")]
        Item110205025,


        [System.Xml.Serialization.XmlEnumAttribute("110204025")]
        Item110204025,


        [System.Xml.Serialization.XmlEnumAttribute("110204026")]
        Item110204026,


        [System.Xml.Serialization.XmlEnumAttribute("110204027")]
        Item110204027,


        [System.Xml.Serialization.XmlEnumAttribute("120204009")]
        Item120204009,


        [System.Xml.Serialization.XmlEnumAttribute("110205026")]
        Item110205026,


        [System.Xml.Serialization.XmlEnumAttribute("110204028")]
        Item110204028,


        [System.Xml.Serialization.XmlEnumAttribute("110204029")]
        Item110204029,


        [System.Xml.Serialization.XmlEnumAttribute("110203080")]
        Item110203080,


        [System.Xml.Serialization.XmlEnumAttribute("120207004")]
        Item120207004,


        [System.Xml.Serialization.XmlEnumAttribute("110203030")]
        Item110203030,


        [System.Xml.Serialization.XmlEnumAttribute("110105025")]
        Item110105025,


        [System.Xml.Serialization.XmlEnumAttribute("110203031")]
        Item110203031,


        [System.Xml.Serialization.XmlEnumAttribute("110203084")]
        Item110203084,


        [System.Xml.Serialization.XmlEnumAttribute("110203032")]
        Item110203032,


        [System.Xml.Serialization.XmlEnumAttribute("110204030")]
        Item110204030,


        [System.Xml.Serialization.XmlEnumAttribute("110205009")]
        Item110205009,


        [System.Xml.Serialization.XmlEnumAttribute("110104004")]
        Item110104004,


        [System.Xml.Serialization.XmlEnumAttribute("110201024")]
        Item110201024,


        [System.Xml.Serialization.XmlEnumAttribute("110201025")]
        Item110201025,


        [System.Xml.Serialization.XmlEnumAttribute("110201026")]
        Item110201026,


        [System.Xml.Serialization.XmlEnumAttribute("110201027")]
        Item110201027,


        [System.Xml.Serialization.XmlEnumAttribute("110201028")]
        Item110201028,


        [System.Xml.Serialization.XmlEnumAttribute("110201029")]
        Item110201029,


        [System.Xml.Serialization.XmlEnumAttribute("110201030")]
        Item110201030,


        [System.Xml.Serialization.XmlEnumAttribute("110207005")]
        Item110207005,


        [System.Xml.Serialization.XmlEnumAttribute("110204031")]
        Item110204031,


        [System.Xml.Serialization.XmlEnumAttribute("110207006")]
        Item110207006,


        [System.Xml.Serialization.XmlEnumAttribute("110201031")]
        Item110201031,


        [System.Xml.Serialization.XmlEnumAttribute("110201032")]
        Item110201032,


        [System.Xml.Serialization.XmlEnumAttribute("110201033")]
        Item110201033,


        [System.Xml.Serialization.XmlEnumAttribute("120204002")]
        Item120204002,


        [System.Xml.Serialization.XmlEnumAttribute("110101020")]
        Item110101020,


        [System.Xml.Serialization.XmlEnumAttribute("220102002")]
        Item220102002,


        [System.Xml.Serialization.XmlEnumAttribute("110105008")]
        Item110105008,


        [System.Xml.Serialization.XmlEnumAttribute("110203033")]
        Item110203033,


        [System.Xml.Serialization.XmlEnumAttribute("110105009")]
        Item110105009,


        [System.Xml.Serialization.XmlEnumAttribute("110201034")]
        Item110201034,


        [System.Xml.Serialization.XmlEnumAttribute("110203034")]
        Item110203034,


        [System.Xml.Serialization.XmlEnumAttribute("110203035")]
        Item110203035,


        [System.Xml.Serialization.XmlEnumAttribute("640201001")]
        Item640201001,


        [System.Xml.Serialization.XmlEnumAttribute("120205011")]
        Item120205011,


        [System.Xml.Serialization.XmlEnumAttribute("110101021")]
        Item110101021,


        [System.Xml.Serialization.XmlEnumAttribute("120103001")]
        Item120103001,


        [System.Xml.Serialization.XmlEnumAttribute("110203036")]
        Item110203036,


        [System.Xml.Serialization.XmlEnumAttribute("120204003")]
        Item120204003,


        [System.Xml.Serialization.XmlEnumAttribute("110201035")]
        Item110201035,


        [System.Xml.Serialization.XmlEnumAttribute("110204032")]
        Item110204032,


        [System.Xml.Serialization.XmlEnumAttribute("110101022")]
        Item110101022,


        [System.Xml.Serialization.XmlEnumAttribute("110201036")]
        Item110201036,


        [System.Xml.Serialization.XmlEnumAttribute("110101023")]
        Item110101023,


        [System.Xml.Serialization.XmlEnumAttribute("110101024")]
        Item110101024,


        [System.Xml.Serialization.XmlEnumAttribute("110101025")]
        Item110101025,


        [System.Xml.Serialization.XmlEnumAttribute("110101039")]
        Item110101039,


        [System.Xml.Serialization.XmlEnumAttribute("110204033")]
        Item110204033,


        [System.Xml.Serialization.XmlEnumAttribute("120207002")]
        Item120207002,


        [System.Xml.Serialization.XmlEnumAttribute("110202004")]
        Item110202004,


        [System.Xml.Serialization.XmlEnumAttribute("110202005")]
        Item110202005,


        [System.Xml.Serialization.XmlEnumAttribute("110203037")]
        Item110203037,


        [System.Xml.Serialization.XmlEnumAttribute("110203037")]
        Item1102030371,


        [System.Xml.Serialization.XmlEnumAttribute("110201037")]
        Item110201037,


        [System.Xml.Serialization.XmlEnumAttribute("110203078")]
        Item110203078,


        [System.Xml.Serialization.XmlEnumAttribute("120203005")]
        Item120203005,


        [System.Xml.Serialization.XmlEnumAttribute("120204010")]
        Item1202040101,


        [System.Xml.Serialization.XmlEnumAttribute("110201038")]
        Item110201038,


        [System.Xml.Serialization.XmlEnumAttribute("110201039")]
        Item110201039,


        [System.Xml.Serialization.XmlEnumAttribute("120101001")]
        Item120101001,


        [System.Xml.Serialization.XmlEnumAttribute("110201040")]
        Item110201040,


        [System.Xml.Serialization.XmlEnumAttribute("110201041")]
        Item110201041,


        [System.Xml.Serialization.XmlEnumAttribute("740101007")]
        Item740101007,


        [System.Xml.Serialization.XmlEnumAttribute("420201003")]
        Item4202010031,


        [System.Xml.Serialization.XmlEnumAttribute("640101001")]
        Item640101001,


        [System.Xml.Serialization.XmlEnumAttribute("110205027")]
        Item110205027,


        [System.Xml.Serialization.XmlEnumAttribute("110103009")]
        Item110103009,


        [System.Xml.Serialization.XmlEnumAttribute("110103010")]
        Item110103010,


        [System.Xml.Serialization.XmlEnumAttribute("110205010")]
        Item110205010,


        [System.Xml.Serialization.XmlEnumAttribute("820101018")]
        Item8201010181,


        [System.Xml.Serialization.XmlEnumAttribute("820101017")]
        Item8201010171,


        [System.Xml.Serialization.XmlEnumAttribute("820101006")]
        Item8201010062,


        [System.Xml.Serialization.XmlEnumAttribute("820101014")]
        Item8201010142,


        [System.Xml.Serialization.XmlEnumAttribute("820101006")]
        Item8201010063,


        [System.Xml.Serialization.XmlEnumAttribute("820101016")]
        Item8201010162,


        [System.Xml.Serialization.XmlEnumAttribute("820101015")]
        Item8201010152,


        [System.Xml.Serialization.XmlEnumAttribute("820101006")]
        Item8201010064,


        [System.Xml.Serialization.XmlEnumAttribute("820101005")]
        Item8201010051,


        [System.Xml.Serialization.XmlEnumAttribute("820101004")]
        Item8201010041,


        [System.Xml.Serialization.XmlEnumAttribute("820101003")]
        Item8201010031,


        [System.Xml.Serialization.XmlEnumAttribute("820101011")]
        Item8201010111,


        [System.Xml.Serialization.XmlEnumAttribute("820101003")]
        Item8201010032,


        [System.Xml.Serialization.XmlEnumAttribute("820101013")]
        Item8201010131,


        [System.Xml.Serialization.XmlEnumAttribute("820101012")]
        Item8201010121,


        [System.Xml.Serialization.XmlEnumAttribute("820101002")]
        Item8201010023,


        [System.Xml.Serialization.XmlEnumAttribute("820101007")]
        Item8201010073,


        [System.Xml.Serialization.XmlEnumAttribute("820101002")]
        Item8201010024,


        [System.Xml.Serialization.XmlEnumAttribute("820101009")]
        Item8201010093,


        [System.Xml.Serialization.XmlEnumAttribute("820101008")]
        Item8201010083,


        [System.Xml.Serialization.XmlEnumAttribute("110301001")]
        Item110301001,


        [System.Xml.Serialization.XmlEnumAttribute("110208001")]
        Item110208001,


        [System.Xml.Serialization.XmlEnumAttribute("110203038")]
        Item110203038,


        [System.Xml.Serialization.XmlEnumAttribute("110203089")]
        Item110203089,


        [System.Xml.Serialization.XmlEnumAttribute("110201042")]
        Item110201042,


        [System.Xml.Serialization.XmlEnumAttribute("110101026")]
        Item110101026,


        [System.Xml.Serialization.XmlEnumAttribute("620502001")]
        Item620502001,


        [System.Xml.Serialization.XmlEnumAttribute("110203039")]
        Item110203039,


        [System.Xml.Serialization.XmlEnumAttribute("110202008")]
        Item110202008,


        [System.Xml.Serialization.XmlEnumAttribute("110204034")]
        Item110204034,


        [System.Xml.Serialization.XmlEnumAttribute("110110001")]
        Item110110001,


        [System.Xml.Serialization.XmlEnumAttribute("310102001")]
        Item310102001,


        [System.Xml.Serialization.XmlEnumAttribute("310103001")]
        Item310103001,


        [System.Xml.Serialization.XmlEnumAttribute("310101001")]
        Item310101001,


        [System.Xml.Serialization.XmlEnumAttribute("110101027")]
        Item110101027,


        [System.Xml.Serialization.XmlEnumAttribute("110205011")]
        Item110205011,


        [System.Xml.Serialization.XmlEnumAttribute("110201062")]
        Item110201062,


        [System.Xml.Serialization.XmlEnumAttribute("110203040")]
        Item110203040,


        [System.Xml.Serialization.XmlEnumAttribute("610101002")]
        Item610101002,


        [System.Xml.Serialization.XmlEnumAttribute("610401002")]
        Item610401002,


        [System.Xml.Serialization.XmlEnumAttribute("610101003")]
        Item610101003,


        [System.Xml.Serialization.XmlEnumAttribute("610401003")]
        Item610401003,


        [System.Xml.Serialization.XmlEnumAttribute("610101004")]
        Item610101004,


        [System.Xml.Serialization.XmlEnumAttribute("610401004")]
        Item610401004,


        [System.Xml.Serialization.XmlEnumAttribute("110203041")]
        Item110203041,


        [System.Xml.Serialization.XmlEnumAttribute("110203042")]
        Item110203042,


        [System.Xml.Serialization.XmlEnumAttribute("110203043")]
        Item110203043,


        [System.Xml.Serialization.XmlEnumAttribute("110203094")]
        Item110203094,


        [System.Xml.Serialization.XmlEnumAttribute("110203044")]
        Item110203044,


        [System.Xml.Serialization.XmlEnumAttribute("110203044")]
        Item1102030441,


        [System.Xml.Serialization.XmlEnumAttribute("430101001")]
        Item430101001,


        [System.Xml.Serialization.XmlEnumAttribute("110206021")]
        Item110206021,


        [System.Xml.Serialization.XmlEnumAttribute("120204004")]
        Item120204004,


        [System.Xml.Serialization.XmlEnumAttribute("110207007")]
        Item110207007,


        [System.Xml.Serialization.XmlEnumAttribute("110203045")]
        Item110203045,


        [System.Xml.Serialization.XmlEnumAttribute("110201043")]
        Item110201043,


        [System.Xml.Serialization.XmlEnumAttribute("110203046")]
        Item110203046,


        [System.Xml.Serialization.XmlEnumAttribute("110203047")]
        Item110203047,


        [System.Xml.Serialization.XmlEnumAttribute("110203048")]
        Item110203048,


        [System.Xml.Serialization.XmlEnumAttribute("110203081")]
        Item110203081,


        [System.Xml.Serialization.XmlEnumAttribute("430101004")]
        Item430101004,


        [System.Xml.Serialization.XmlEnumAttribute("510101003")]
        Item510101003,


        [System.Xml.Serialization.XmlEnumAttribute("510101001")]
        Item510101001,


        [System.Xml.Serialization.XmlEnumAttribute("510101002")]
        Item510101002,


        [System.Xml.Serialization.XmlEnumAttribute("510102003")]
        Item510102003,


        [System.Xml.Serialization.XmlEnumAttribute("510102001")]
        Item510102001,


        [System.Xml.Serialization.XmlEnumAttribute("510102002")]
        Item510102002,


        [System.Xml.Serialization.XmlEnumAttribute("510201001")]
        Item510201001,


        [System.Xml.Serialization.XmlEnumAttribute("510201002")]
        Item510201002,


        [System.Xml.Serialization.XmlEnumAttribute("510201003")]
        Item510201003,


        [System.Xml.Serialization.XmlEnumAttribute("510301003")]
        Item510301003,


        [System.Xml.Serialization.XmlEnumAttribute("140101015")]
        Item140101015,


        [System.Xml.Serialization.XmlEnumAttribute("140101009")]
        Item140101009,


        [System.Xml.Serialization.XmlEnumAttribute("140101016")]
        Item140101016,


        [System.Xml.Serialization.XmlEnumAttribute("140101017")]
        Item140101017,


        [System.Xml.Serialization.XmlEnumAttribute("140101005")]
        Item140101005,


        [System.Xml.Serialization.XmlEnumAttribute("140101014")]
        Item140101014,


        [System.Xml.Serialization.XmlEnumAttribute("140101018")]
        Item140101018,


        [System.Xml.Serialization.XmlEnumAttribute("140101006")]
        Item140101006,


        [System.Xml.Serialization.XmlEnumAttribute("140101028")]
        Item140101028,


        [System.Xml.Serialization.XmlEnumAttribute("140101021")]
        Item140101021,


        [System.Xml.Serialization.XmlEnumAttribute("140101010")]
        Item140101010,


        [System.Xml.Serialization.XmlEnumAttribute("140101012")]
        Item140101012,


        [System.Xml.Serialization.XmlEnumAttribute("140101013")]
        Item140101013,


        [System.Xml.Serialization.XmlEnumAttribute("140101001")]
        Item140101001,


        [System.Xml.Serialization.XmlEnumAttribute("140101011")]
        Item140101011,


        [System.Xml.Serialization.XmlEnumAttribute("140101003")]
        Item140101003,


        [System.Xml.Serialization.XmlEnumAttribute("140101002")]
        Item140101002,


        [System.Xml.Serialization.XmlEnumAttribute("140101008")]
        Item140101008,


        [System.Xml.Serialization.XmlEnumAttribute("140101007")]
        Item140101007,


        [System.Xml.Serialization.XmlEnumAttribute("140101019")]
        Item140101019,


        [System.Xml.Serialization.XmlEnumAttribute("140101004")]
        Item140101004,


        [System.Xml.Serialization.XmlEnumAttribute("560101001")]
        Item560101001,


        [System.Xml.Serialization.XmlEnumAttribute("420105001")]
        Item420105001,


        [System.Xml.Serialization.XmlEnumAttribute("420101005")]
        Item420101005,


        [System.Xml.Serialization.XmlEnumAttribute("420101004")]
        Item420101004,


        [System.Xml.Serialization.XmlEnumAttribute("420101003")]
        Item420101003,


        [System.Xml.Serialization.XmlEnumAttribute("420102006")]
        Item420102006,


        [System.Xml.Serialization.XmlEnumAttribute("420102005")]
        Item420102005,


        [System.Xml.Serialization.XmlEnumAttribute("420102004")]
        Item420102004,


        [System.Xml.Serialization.XmlEnumAttribute("420102003")]
        Item420102003,


        [System.Xml.Serialization.XmlEnumAttribute("420104001")]
        Item420104001,


        [System.Xml.Serialization.XmlEnumAttribute("820101033")]
        Item820101033,


        [System.Xml.Serialization.XmlEnumAttribute("820101034")]
        Item820101034,


        [System.Xml.Serialization.XmlEnumAttribute("820101011")]
        Item8201010112,


        [System.Xml.Serialization.XmlEnumAttribute("820101003")]
        Item8201010033,


        [System.Xml.Serialization.XmlEnumAttribute("820101028")]
        Item8201010281,


        [System.Xml.Serialization.XmlEnumAttribute("820101029")]
        Item8201010291,


        [System.Xml.Serialization.XmlEnumAttribute("820101013")]
        Item8201010132,


        [System.Xml.Serialization.XmlEnumAttribute("820101012")]
        Item8201010122,


        [System.Xml.Serialization.XmlEnumAttribute("420301003")]
        Item420301003,


        [System.Xml.Serialization.XmlEnumAttribute("420101005")]
        Item4201010051,


        [System.Xml.Serialization.XmlEnumAttribute("420101002")]
        Item420101002,


        [System.Xml.Serialization.XmlEnumAttribute("420101001")]
        Item420101001,


        [System.Xml.Serialization.XmlEnumAttribute("420101003")]
        Item4201010031,


        [System.Xml.Serialization.XmlEnumAttribute("420101004")]
        Item4201010041,


        [System.Xml.Serialization.XmlEnumAttribute("420101003")]
        Item4201010032,


        [System.Xml.Serialization.XmlEnumAttribute("420201001")]
        Item4202010011,


        [System.Xml.Serialization.XmlEnumAttribute("420201002")]
        Item420201002,


        [System.Xml.Serialization.XmlEnumAttribute("420102005")]
        Item4201020051,


        [System.Xml.Serialization.XmlEnumAttribute("420102004")]
        Item4201020041,


        [System.Xml.Serialization.XmlEnumAttribute("420102002")]
        Item420102002,


        [System.Xml.Serialization.XmlEnumAttribute("420102001")]
        Item420102001,


        [System.Xml.Serialization.XmlEnumAttribute("420102003")]
        Item4201020031,


        [System.Xml.Serialization.XmlEnumAttribute("420102003")]
        Item4201020032,


        [System.Xml.Serialization.XmlEnumAttribute("420202001")]
        Item420202001,


        [System.Xml.Serialization.XmlEnumAttribute("420301001")]
        Item420301001,


        [System.Xml.Serialization.XmlEnumAttribute("420102006")]
        Item4201020061,


        [System.Xml.Serialization.XmlEnumAttribute("420103002")]
        Item420103002,


        [System.Xml.Serialization.XmlEnumAttribute("420103001")]
        Item420103001,


        [System.Xml.Serialization.XmlEnumAttribute("420103003")]
        Item420103003,


        [System.Xml.Serialization.XmlEnumAttribute("610601001")]
        Item610601001,


        [System.Xml.Serialization.XmlEnumAttribute("610701001")]
        Item610701001,


        [System.Xml.Serialization.XmlEnumAttribute("510301002")]
        Item510301002,


        [System.Xml.Serialization.XmlEnumAttribute("620601001")]
        Item620601001,


        [System.Xml.Serialization.XmlEnumAttribute("660101001")]
        Item660101001,


        [System.Xml.Serialization.XmlEnumAttribute("620401001")]
        Item620401001,


        [System.Xml.Serialization.XmlEnumAttribute("620301001")]
        Item620301001,


        [System.Xml.Serialization.XmlEnumAttribute("620201001")]
        Item620201001,


        [System.Xml.Serialization.XmlEnumAttribute("630101001")]
        Item630101001,


        [System.Xml.Serialization.XmlEnumAttribute("110202006")]
        Item110202006,


        [System.Xml.Serialization.XmlEnumAttribute("110203093")]
        Item110203093,


        [System.Xml.Serialization.XmlEnumAttribute("110204035")]
        Item110204035,


        [System.Xml.Serialization.XmlEnumAttribute("110203049")]
        Item110203049,


        [System.Xml.Serialization.XmlEnumAttribute("110201044")]
        Item110201044,


        [System.Xml.Serialization.XmlEnumAttribute("110201045")]
        Item110201045,


        [System.Xml.Serialization.XmlEnumAttribute("110206012")]
        Item110206012,


        [System.Xml.Serialization.XmlEnumAttribute("120203003")]
        Item120203003,


        [System.Xml.Serialization.XmlEnumAttribute("320301001")]
        Item320301001,


        [System.Xml.Serialization.XmlEnumAttribute("320103002")]
        Item320103002,


        [System.Xml.Serialization.XmlEnumAttribute("650101002")]
        Item650101002,


        [System.Xml.Serialization.XmlEnumAttribute("310102002")]
        Item310102002,


        [System.Xml.Serialization.XmlEnumAttribute("640401001")]
        Item640401001,


        [System.Xml.Serialization.XmlEnumAttribute("140101029")]
        Item140101029,


        [System.Xml.Serialization.XmlEnumAttribute("740101003")]
        Item740101003,


        [System.Xml.Serialization.XmlEnumAttribute("810201002")]
        Item810201002,


        [System.Xml.Serialization.XmlEnumAttribute("530103001")]
        Item530103001,


        [System.Xml.Serialization.XmlEnumAttribute("340101003")]
        Item340101003,


        [System.Xml.Serialization.XmlEnumAttribute("430101003")]
        Item430101003,


        [System.Xml.Serialization.XmlEnumAttribute("560101003")]
        Item560101003,


        [System.Xml.Serialization.XmlEnumAttribute("210302001")]
        Item210302001,


        [System.Xml.Serialization.XmlEnumAttribute("210204002")]
        Item210204002,


        [System.Xml.Serialization.XmlEnumAttribute("130201001")]
        Item130201001,


        [System.Xml.Serialization.XmlEnumAttribute("530104001")]
        Item530104001,


        [System.Xml.Serialization.XmlEnumAttribute("140101022")]
        Item140101022,


        [System.Xml.Serialization.XmlEnumAttribute("140101999")]
        Item140101999,


        [System.Xml.Serialization.XmlEnumAttribute("610201004")]
        Item610201004,


        [System.Xml.Serialization.XmlEnumAttribute("510301001")]
        Item510301001,


        [System.Xml.Serialization.XmlEnumAttribute("420301002")]
        Item420301002,


        [System.Xml.Serialization.XmlEnumAttribute("620601004")]
        Item620601004,


        [System.Xml.Serialization.XmlEnumAttribute("620505001")]
        Item620505001,


        [System.Xml.Serialization.XmlEnumAttribute("610501001")]
        Item610501001,


        [System.Xml.Serialization.XmlEnumAttribute("620101008")]
        Item620101008,


        [System.Xml.Serialization.XmlEnumAttribute("610101010")]
        Item610101010,


        [System.Xml.Serialization.XmlEnumAttribute("110208002")]
        Item110208002,


        [System.Xml.Serialization.XmlEnumAttribute("110110002")]
        Item110110002,


        [System.Xml.Serialization.XmlEnumAttribute("130202008")]
        Item130202008,


        [System.Xml.Serialization.XmlEnumAttribute("410103001")]
        Item410103001,


        [System.Xml.Serialization.XmlEnumAttribute("610301002")]
        Item610301002,


        [System.Xml.Serialization.XmlEnumAttribute("610302001")]
        Item610302001,


        [System.Xml.Serialization.XmlEnumAttribute("330101007")]
        Item330101007,


        [System.Xml.Serialization.XmlEnumAttribute("330201009")]
        Item330201009,


        [System.Xml.Serialization.XmlEnumAttribute("730101001")]
        Item730101001,


        [System.Xml.Serialization.XmlEnumAttribute("110203050")]
        Item110203050,


        [System.Xml.Serialization.XmlEnumAttribute("110101028")]
        Item110101028,


        [System.Xml.Serialization.XmlEnumAttribute("110101049")]
        Item110101049,


        [System.Xml.Serialization.XmlEnumAttribute("110101029")]
        Item110101029,


        [System.Xml.Serialization.XmlEnumAttribute("110101030")]
        Item110101030,


        [System.Xml.Serialization.XmlEnumAttribute("110104007")]
        Item110104007,


        [System.Xml.Serialization.XmlEnumAttribute("110111001")]
        Item110111001,


        [System.Xml.Serialization.XmlEnumAttribute("120205006")]
        Item120205006,


        [System.Xml.Serialization.XmlEnumAttribute("110203051")]
        Item110203051,


        [System.Xml.Serialization.XmlEnumAttribute("110101050")]
        Item110101050,


        [System.Xml.Serialization.XmlEnumAttribute("110105028")]
        Item110105028,


        [System.Xml.Serialization.XmlEnumAttribute("110105016")]
        Item110105016,


        [System.Xml.Serialization.XmlEnumAttribute("110201046")]
        Item110201046,


        [System.Xml.Serialization.XmlEnumAttribute("110106007")]
        Item110106007,


        [System.Xml.Serialization.XmlEnumAttribute("110101031")]
        Item110101031,


        [System.Xml.Serialization.XmlEnumAttribute("110203082")]
        Item110203082,


        [System.Xml.Serialization.XmlEnumAttribute("610301001")]
        Item610301001,


        [System.Xml.Serialization.XmlEnumAttribute("110101032")]
        Item110101032,


        [System.Xml.Serialization.XmlEnumAttribute("110101047")]
        Item110101047,


        [System.Xml.Serialization.XmlEnumAttribute("110105021")]
        Item110105021,


        [System.Xml.Serialization.XmlEnumAttribute("110105010")]
        Item110105010,


        [System.Xml.Serialization.XmlEnumAttribute("620101003")]
        Item620101003,


        [System.Xml.Serialization.XmlEnumAttribute("210201001")]
        Item210201001,


        [System.Xml.Serialization.XmlEnumAttribute("210201002")]
        Item210201002,


        [System.Xml.Serialization.XmlEnumAttribute("210201003")]
        Item210201003,


        [System.Xml.Serialization.XmlEnumAttribute("110105020")]
        Item110105020,


        [System.Xml.Serialization.XmlEnumAttribute("110105022")]
        Item110105022,


        [System.Xml.Serialization.XmlEnumAttribute("110205012")]
        Item110205012,


        [System.Xml.Serialization.XmlEnumAttribute("620601002")]
        Item620601002,


        [System.Xml.Serialization.XmlEnumAttribute("120206003")]
        Item120206003,


        [System.Xml.Serialization.XmlEnumAttribute("110204036")]
        Item110204036,


        [System.Xml.Serialization.XmlEnumAttribute("110204037")]
        Item110204037,


        [System.Xml.Serialization.XmlEnumAttribute("110204038")]
        Item110204038,


        [System.Xml.Serialization.XmlEnumAttribute("410101001")]
        Item410101001,


        [System.Xml.Serialization.XmlEnumAttribute("410101002")]
        Item410101002,


        [System.Xml.Serialization.XmlEnumAttribute("410102001")]
        Item410102001,


        [System.Xml.Serialization.XmlEnumAttribute("410102002")]
        Item410102002,


        [System.Xml.Serialization.XmlEnumAttribute("110103014")]
        Item110103014,


        [System.Xml.Serialization.XmlEnumAttribute("110203052")]
        Item110203052,


        [System.Xml.Serialization.XmlEnumAttribute("330101005")]
        Item330101005,


        [System.Xml.Serialization.XmlEnumAttribute("330101006")]
        Item330101006,


        [System.Xml.Serialization.XmlEnumAttribute("110205029")]
        Item110205029,


        [System.Xml.Serialization.XmlEnumAttribute("110203053")]
        Item110203053,


        [System.Xml.Serialization.XmlEnumAttribute("120204008")]
        Item120204008,


        [System.Xml.Serialization.XmlEnumAttribute("110203054")]
        Item110203054,


        [System.Xml.Serialization.XmlEnumAttribute("110204039")]
        Item110204039,


        [System.Xml.Serialization.XmlEnumAttribute("110201047")]
        Item110201047,


        [System.Xml.Serialization.XmlEnumAttribute("110201048")]
        Item110201048,


        [System.Xml.Serialization.XmlEnumAttribute("110103011")]
        Item110103011,


        [System.Xml.Serialization.XmlEnumAttribute("340101001")]
        Item340101001,


        [System.Xml.Serialization.XmlEnumAttribute("550101001")]
        Item550101001,


        [System.Xml.Serialization.XmlEnumAttribute("550101005")]
        Item550101005,


        [System.Xml.Serialization.XmlEnumAttribute("550101002")]
        Item550101002,


        [System.Xml.Serialization.XmlEnumAttribute("550101003")]
        Item550101003,


        [System.Xml.Serialization.XmlEnumAttribute("550101004")]
        Item550101004,


        [System.Xml.Serialization.XmlEnumAttribute("130202007")]
        Item130202007,


        [System.Xml.Serialization.XmlEnumAttribute("110105011")]
        Item110105011,


        [System.Xml.Serialization.XmlEnumAttribute("110201049")]
        Item110201049,


        [System.Xml.Serialization.XmlEnumAttribute("110101048")]
        Item110101048,


        [System.Xml.Serialization.XmlEnumAttribute("110101033")]
        Item110101033,


        [System.Xml.Serialization.XmlEnumAttribute("110101040")]
        Item110101040,


        [System.Xml.Serialization.XmlEnumAttribute("110101045")]
        Item110101045,


        [System.Xml.Serialization.XmlEnumAttribute("110101041")]
        Item110101041,


        [System.Xml.Serialization.XmlEnumAttribute("110204040")]
        Item110204040,


        [System.Xml.Serialization.XmlEnumAttribute("110105019")]
        Item110105019,


        [System.Xml.Serialization.XmlEnumAttribute("110204041")]
        Item110204041,


        [System.Xml.Serialization.XmlEnumAttribute("110105024")]
        Item110105024,


        [System.Xml.Serialization.XmlEnumAttribute("110203070")]
        Item110203070,


        [System.Xml.Serialization.XmlEnumAttribute("110203055")]
        Item110203055,


        [System.Xml.Serialization.XmlEnumAttribute("110204042")]
        Item110204042,


        [System.Xml.Serialization.XmlEnumAttribute("110203075")]
        Item110203075,


        [System.Xml.Serialization.XmlEnumAttribute("110201050")]
        Item110201050,


        [System.Xml.Serialization.XmlEnumAttribute("110201051")]
        Item110201051,


        [System.Xml.Serialization.XmlEnumAttribute("110201052")]
        Item110201052,


        [System.Xml.Serialization.XmlEnumAttribute("110201053")]
        Item110201053,


        [System.Xml.Serialization.XmlEnumAttribute("120201002")]
        Item120201002,


        [System.Xml.Serialization.XmlEnumAttribute("110105029")]
        Item110105029,


        [System.Xml.Serialization.XmlEnumAttribute("110203056")]
        Item110203056,


        [System.Xml.Serialization.XmlEnumAttribute("110204043")]
        Item110204043,


        [System.Xml.Serialization.XmlEnumAttribute("110203090")]
        Item110203090,


        [System.Xml.Serialization.XmlEnumAttribute("140101020")]
        Item140101020,


        [System.Xml.Serialization.XmlEnumAttribute("110103018")]
        Item110103018,


        [System.Xml.Serialization.XmlEnumAttribute("110106004")]
        Item110106004,


        [System.Xml.Serialization.XmlEnumAttribute("110106005")]
        Item110106005,


        [System.Xml.Serialization.XmlEnumAttribute("110106006")]
        Item110106006,


        [System.Xml.Serialization.XmlEnumAttribute("110205028")]
        Item110205028,


        [System.Xml.Serialization.XmlEnumAttribute("110105012")]
        Item110105012,


        [System.Xml.Serialization.XmlEnumAttribute("120204005")]
        Item120204005,


        [System.Xml.Serialization.XmlEnumAttribute("110205013")]
        Item110205013,


        [System.Xml.Serialization.XmlEnumAttribute("110201054")]
        Item110201054,


        [System.Xml.Serialization.XmlEnumAttribute("110101044")]
        Item110101044,


        [System.Xml.Serialization.XmlEnumAttribute("110204044")]
        Item110204044,


        [System.Xml.Serialization.XmlEnumAttribute("110203057")]
        Item110203057,


        [System.Xml.Serialization.XmlEnumAttribute("110203058")]
        Item110203058,


        [System.Xml.Serialization.XmlEnumAttribute("120206002")]
        Item120206002,


        [System.Xml.Serialization.XmlEnumAttribute("120206004")]
        Item120206004,


        [System.Xml.Serialization.XmlEnumAttribute("330201008")]
        Item330201008,


        [System.Xml.Serialization.XmlEnumAttribute("330101004")]
        Item330101004,


        [System.Xml.Serialization.XmlEnumAttribute("110204045")]
        Item110204045,


        [System.Xml.Serialization.XmlEnumAttribute("110204046")]
        Item110204046,


        [System.Xml.Serialization.XmlEnumAttribute("110201063")]
        Item110201063,


        [System.Xml.Serialization.XmlEnumAttribute("110206013")]
        Item110206013,


        [System.Xml.Serialization.XmlEnumAttribute("110203059")]
        Item110203059,


        [System.Xml.Serialization.XmlEnumAttribute("110203060")]
        Item110203060,


        [System.Xml.Serialization.XmlEnumAttribute("610101001")]
        Item610101001,


        [System.Xml.Serialization.XmlEnumAttribute("610401001")]
        Item610401001,


        [System.Xml.Serialization.XmlEnumAttribute("110206015")]
        Item110206015,


        [System.Xml.Serialization.XmlEnumAttribute("110206014")]
        Item110206014,


        [System.Xml.Serialization.XmlEnumAttribute("110204052")]
        Item110204052,


        [System.Xml.Serialization.XmlEnumAttribute("110205015")]
        Item110205015,


        [System.Xml.Serialization.XmlEnumAttribute("110205014")]
        Item110205014,


        [System.Xml.Serialization.XmlEnumAttribute("110204047")]
        Item110204047,


        [System.Xml.Serialization.XmlEnumAttribute("110205016")]
        Item110205016,


        [System.Xml.Serialization.XmlEnumAttribute("110203061")]
        Item110203061,


        [System.Xml.Serialization.XmlEnumAttribute("110205017")]
        Item110205017,


        [System.Xml.Serialization.XmlEnumAttribute("110106009")]
        Item110106009,


        [System.Xml.Serialization.XmlEnumAttribute("110203062")]
        Item110203062,


        [System.Xml.Serialization.XmlEnumAttribute("110206016")]
        Item110206016,


        [System.Xml.Serialization.XmlEnumAttribute("120205007")]
        Item120205007,


        [System.Xml.Serialization.XmlEnumAttribute("120201003")]
        Item120201003,


        [System.Xml.Serialization.XmlEnumAttribute("620101006")]
        Item620101006,


        [System.Xml.Serialization.XmlEnumAttribute("120205008")]
        Item120205008,


        [System.Xml.Serialization.XmlEnumAttribute("120204006")]
        Item120204006,


        [System.Xml.Serialization.XmlEnumAttribute("110201055")]
        Item110201055,


        [System.Xml.Serialization.XmlEnumAttribute("110201056")]
        Item110201056,


        [System.Xml.Serialization.XmlEnumAttribute("110201057")]
        Item110201057,


        [System.Xml.Serialization.XmlEnumAttribute("110103016")]
        Item110103016,


        [System.Xml.Serialization.XmlEnumAttribute("110205018")]
        Item110205018,


        [System.Xml.Serialization.XmlEnumAttribute("110107005")]
        Item110107005,


        [System.Xml.Serialization.XmlEnumAttribute("330201002")]
        Item330201002,


        [System.Xml.Serialization.XmlEnumAttribute("620504001")]
        Item620504001,


        [System.Xml.Serialization.XmlEnumAttribute("620503001")]
        Item620503001,


        [System.Xml.Serialization.XmlEnumAttribute("110101034")]
        Item110101034,


        [System.Xml.Serialization.XmlEnumAttribute("110107004")]
        Item110107004,


        [System.Xml.Serialization.XmlEnumAttribute("610101007")]
        Item610101007,


        [System.Xml.Serialization.XmlEnumAttribute("610101008")]
        Item610101008,


        [System.Xml.Serialization.XmlEnumAttribute("110105014")]
        Item110105014,


        [System.Xml.Serialization.XmlEnumAttribute("110205019")]
        Item110205019,


        [System.Xml.Serialization.XmlEnumAttribute("110103012")]
        Item110103012,


        [System.Xml.Serialization.XmlEnumAttribute("110203063")]
        Item110203063,


        [System.Xml.Serialization.XmlEnumAttribute("120204007")]
        Item120204007,


        [System.Xml.Serialization.XmlEnumAttribute("110204048")]
        Item110204048,


        [System.Xml.Serialization.XmlEnumAttribute("110105013")]
        Item110105013,


        [System.Xml.Serialization.XmlEnumAttribute("110204049")]
        Item110204049,


        [System.Xml.Serialization.XmlEnumAttribute("110206017")]
        Item110206017,


        [System.Xml.Serialization.XmlEnumAttribute("110109001")]
        Item110109001,


        [System.Xml.Serialization.XmlEnumAttribute("110107006")]
        Item110107006,


        [System.Xml.Serialization.XmlEnumAttribute("110201059")]
        Item110201059,


        [System.Xml.Serialization.XmlEnumAttribute("110201058")]
        Item110201058,


        [System.Xml.Serialization.XmlEnumAttribute("640301001")]
        Item640301001,


        [System.Xml.Serialization.XmlEnumAttribute("110101035")]
        Item110101035,


        [System.Xml.Serialization.XmlEnumAttribute("110101036")]
        Item110101036,


        [System.Xml.Serialization.XmlEnumAttribute("110101037")]
        Item110101037,


        [System.Xml.Serialization.XmlEnumAttribute("110205020")]
        Item110205020,


        [System.Xml.Serialization.XmlEnumAttribute("120207005")]
        Item120207005,


        [System.Xml.Serialization.XmlEnumAttribute("110206018")]
        Item110206018,


        [System.Xml.Serialization.XmlEnumAttribute("110108006")]
        Item110108006,


        [System.Xml.Serialization.XmlEnumAttribute("110203076")]
        Item110203076,


        [System.Xml.Serialization.XmlEnumAttribute("110205021")]
        Item110205021,


        [System.Xml.Serialization.XmlEnumAttribute("330201003")]
        Item330201003,


        [System.Xml.Serialization.XmlEnumAttribute("130101001")]
        Item130101001,


        [System.Xml.Serialization.XmlEnumAttribute("110201060")]
        Item110201060,


        [System.Xml.Serialization.XmlEnumAttribute("110203071")]
        Item110203071,


        [System.Xml.Serialization.XmlEnumAttribute("110203065")]
        Item110203065,


        [System.Xml.Serialization.XmlEnumAttribute("110203064")]
        Item110203064,


        [System.Xml.Serialization.XmlEnumAttribute("110204050")]
        Item110204050,


        [System.Xml.Serialization.XmlEnumAttribute("110203066")]
        Item110203066,


        [System.Xml.Serialization.XmlEnumAttribute("110203067")]
        Item110203067,


        [System.Xml.Serialization.XmlEnumAttribute("110201061")]
        Item110201061,


        [System.Xml.Serialization.XmlEnumAttribute("110203068")]
        Item110203068,


        [System.Xml.Serialization.XmlEnumAttribute("110105026")]
        Item110105026,


        [System.Xml.Serialization.XmlEnumAttribute("110106008")]
        Item110106008,
    }



    [Serializable]


    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetProdCombCIDE
    {


        public string qBCProd{get;set;}


        public string vAliqProd{get;set;}


        public string vCIDE{get;set;}
    }



    [Serializable]


    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetProdMed
    {


        public string nLote{get;set;}


        public string qLote{get;set;}


        public string dFab{get;set;}


        public string dVal{get;set;}


        public string vPMC{get;set;}
    }



    [Serializable]


    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetProdVeicProd
    {


        public TNFeInfNFeDetProdVeicProdTpOp tpOp{get;set;}


        public string chassi{get;set;}


        public string cCor{get;set;}


        public string xCor{get;set;}


        public string pot{get;set;}


        public string cilin{get;set;}


        public string pesoL{get;set;}


        public string pesoB{get;set;}


        public string nSerie{get;set;}


        public string tpComb{get;set;}


        public string nMotor{get;set;}


        public string CMT{get;set;}


        public string dist{get;set;}


        public string anoMod{get;set;}


        public string anoFab{get;set;}


        public string tpPint{get;set;}


        public string tpVeic{get;set;}


        public string espVeic{get;set;}


        public TNFeInfNFeDetProdVeicProdVIN VIN{get;set;}


        public TNFeInfNFeDetProdVeicProdCondVeic condVeic{get;set;}


        public string cMod{get;set;}


        public string cCorDENATRAN{get;set;}


        public string lota{get;set;}


        public TNFeInfNFeDetProdVeicProdTpRest tpRest{get;set;}
    }



    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetProdVeicProdTpOp
    {


        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,


        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,


        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,


        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,
    }



    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetProdVeicProdVIN
    {


        R,


        N,
    }



    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetProdVeicProdCondVeic
    {


        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,


        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,


        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,
    }



    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetProdVeicProdTpRest
    {


        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,


        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,


        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,


        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,


        [System.Xml.Serialization.XmlEnumAttribute("4")]
        Item4,


        [System.Xml.Serialization.XmlEnumAttribute("9")]
        Item9,
    }



    [Serializable]


    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImposto
    {


        public string vTotTrib{get;set;}


        [System.Xml.Serialization.XmlElementAttribute("ICMS", typeof(TNFeInfNFeDetImpostoICMS))]
        [System.Xml.Serialization.XmlElementAttribute("II", typeof(TNFeInfNFeDetImpostoII))]
        [System.Xml.Serialization.XmlElementAttribute("IPI", typeof(TIpi))]
        [System.Xml.Serialization.XmlElementAttribute("ISSQN", typeof(TNFeInfNFeDetImpostoISSQN))]
        public object[] Items{get;set;}


        public TNFeInfNFeDetImpostoPIS PIS{get;set;}


        public TNFeInfNFeDetImpostoPISST PISST{get;set;}


        public TNFeInfNFeDetImpostoCOFINS COFINS{get;set;}


        public TNFeInfNFeDetImpostoCOFINSST COFINSST{get;set;}
    }



    [Serializable]


    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoICMS
    {


        [System.Xml.Serialization.XmlElementAttribute("ICMS00", typeof(TNFeInfNFeDetImpostoICMSICMS00))]
        [System.Xml.Serialization.XmlElementAttribute("ICMS10", typeof(TNFeInfNFeDetImpostoICMSICMS10))]
        [System.Xml.Serialization.XmlElementAttribute("ICMS20", typeof(TNFeInfNFeDetImpostoICMSICMS20))]
        [System.Xml.Serialization.XmlElementAttribute("ICMS30", typeof(TNFeInfNFeDetImpostoICMSICMS30))]
        [System.Xml.Serialization.XmlElementAttribute("ICMS40", typeof(TNFeInfNFeDetImpostoICMSICMS40))]
        [System.Xml.Serialization.XmlElementAttribute("ICMS51", typeof(TNFeInfNFeDetImpostoICMSICMS51))]
        [System.Xml.Serialization.XmlElementAttribute("ICMS60", typeof(TNFeInfNFeDetImpostoICMSICMS60))]
        [System.Xml.Serialization.XmlElementAttribute("ICMS70", typeof(TNFeInfNFeDetImpostoICMSICMS70))]
        [System.Xml.Serialization.XmlElementAttribute("ICMS90", typeof(TNFeInfNFeDetImpostoICMSICMS90))]
        [System.Xml.Serialization.XmlElementAttribute("ICMSPart", typeof(TNFeInfNFeDetImpostoICMSICMSPart))]
        [System.Xml.Serialization.XmlElementAttribute("ICMSSN101", typeof(TNFeInfNFeDetImpostoICMSICMSSN101))]
        [System.Xml.Serialization.XmlElementAttribute("ICMSSN102", typeof(TNFeInfNFeDetImpostoICMSICMSSN102))]
        [System.Xml.Serialization.XmlElementAttribute("ICMSSN201", typeof(TNFeInfNFeDetImpostoICMSICMSSN201))]
        [System.Xml.Serialization.XmlElementAttribute("ICMSSN202", typeof(TNFeInfNFeDetImpostoICMSICMSSN202))]
        [System.Xml.Serialization.XmlElementAttribute("ICMSSN500", typeof(TNFeInfNFeDetImpostoICMSICMSSN500))]
        [System.Xml.Serialization.XmlElementAttribute("ICMSSN900", typeof(TNFeInfNFeDetImpostoICMSICMSSN900))]
        [System.Xml.Serialization.XmlElementAttribute("ICMSST", typeof(TNFeInfNFeDetImpostoICMSICMSST))]
        public object Item{get;set;}
    }



    [Serializable]


    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoICMSICMS00
    {


        public Torig orig{get;set;}


        public TNFeInfNFeDetImpostoICMSICMS00CST CST{get;set;}


        public TNFeInfNFeDetImpostoICMSICMS00ModBC modBC{get;set;}


        public string vBC{get;set;}


        public string pICMS{get;set;}


        public string vICMS{get;set;}
    }



    [Serializable]
    [XmlType(Namespace = Namespaces.NFe)]
    public enum Torig
    {


        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,


        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,


        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,


        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,


        [System.Xml.Serialization.XmlEnumAttribute("4")]
        Item4,


        [System.Xml.Serialization.XmlEnumAttribute("5")]
        Item5,


        [System.Xml.Serialization.XmlEnumAttribute("6")]
        Item6,


        [System.Xml.Serialization.XmlEnumAttribute("7")]
        Item7,


        [System.Xml.Serialization.XmlEnumAttribute("8")]
        Item8,
    }



    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMS00CST
    {


        [System.Xml.Serialization.XmlEnumAttribute("00")]
        Item00,
    }



    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMS00ModBC
    {


        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,


        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,


        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,


        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,
    }



    [Serializable]


    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoICMSICMS10
    {


        public Torig orig{get;set;}


        public TNFeInfNFeDetImpostoICMSICMS10CST CST{get;set;}


        public TNFeInfNFeDetImpostoICMSICMS10ModBC modBC{get;set;}


        public string vBC{get;set;}


        public string pICMS{get;set;}


        public string vICMS{get;set;}


        public TNFeInfNFeDetImpostoICMSICMS10ModBCST modBCST{get;set;}


        public string pMVAST{get;set;}


        public string pRedBCST{get;set;}


        public string vBCST{get;set;}


        public string pICMSST{get;set;}


        public string vICMSST{get;set;}
    }



    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMS10CST
    {


        [System.Xml.Serialization.XmlEnumAttribute("10")]
        Item10,
    }



    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMS10ModBC
    {


        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,


        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,


        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,


        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,
    }



    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMS10ModBCST
    {


        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,


        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,


        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,


        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,


        [System.Xml.Serialization.XmlEnumAttribute("4")]
        Item4,


        [System.Xml.Serialization.XmlEnumAttribute("5")]
        Item5,
    }



    [Serializable]


    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoICMSICMS20
    {


        public Torig orig{get;set;}


        public TNFeInfNFeDetImpostoICMSICMS20CST CST{get;set;}


        public TNFeInfNFeDetImpostoICMSICMS20ModBC modBC{get;set;}


        public string pRedBC{get;set;}


        public string vBC{get;set;}


        public string pICMS{get;set;}


        public string vICMS{get;set;}


        public string vICMSDeson{get;set;}


        public TNFeInfNFeDetImpostoICMSICMS20MotDesICMS motDesICMS{get;set;}
    }



    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMS20CST
    {


        [System.Xml.Serialization.XmlEnumAttribute("20")]
        Item20,
    }



    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMS20ModBC
    {


        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,


        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,


        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,


        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,
    }



    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMS20MotDesICMS
    {


        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,


        [System.Xml.Serialization.XmlEnumAttribute("9")]
        Item9,


        [System.Xml.Serialization.XmlEnumAttribute("12")]
        Item12,
    }



    [Serializable]


    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoICMSICMS30
    {


        public Torig orig{get;set;}


        public TNFeInfNFeDetImpostoICMSICMS30CST CST{get;set;}


        public TNFeInfNFeDetImpostoICMSICMS30ModBCST modBCST{get;set;}


        public string pMVAST{get;set;}


        public string pRedBCST{get;set;}


        public string vBCST{get;set;}


        public string pICMSST{get;set;}


        public string vICMSST{get;set;}


        public string vICMSDeson{get;set;}


        public TNFeInfNFeDetImpostoICMSICMS30MotDesICMS motDesICMS{get;set;}
    }



    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMS30CST
    {


        [System.Xml.Serialization.XmlEnumAttribute("30")]
        Item30,
    }



    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMS30ModBCST
    {


        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,


        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,


        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,


        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,


        [System.Xml.Serialization.XmlEnumAttribute("4")]
        Item4,


        [System.Xml.Serialization.XmlEnumAttribute("5")]
        Item5,
    }



    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMS30MotDesICMS
    {


        [System.Xml.Serialization.XmlEnumAttribute("6")]
        Item6,


        [System.Xml.Serialization.XmlEnumAttribute("7")]
        Item7,


        [System.Xml.Serialization.XmlEnumAttribute("9")]
        Item9,
    }



    [Serializable]


    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoICMSICMS40
    {


        public Torig orig{get;set;}


        public TNFeInfNFeDetImpostoICMSICMS40CST CST{get;set;}


        public string vICMSDeson{get;set;}


        public TNFeInfNFeDetImpostoICMSICMS40MotDesICMS motDesICMS{get;set;}
    }



    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMS40CST
    {


        [System.Xml.Serialization.XmlEnumAttribute("40")]
        Item40,


        [System.Xml.Serialization.XmlEnumAttribute("41")]
        Item41,


        [System.Xml.Serialization.XmlEnumAttribute("50")]
        Item50,
    }



    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMS40MotDesICMS
    {


        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,


        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,


        [System.Xml.Serialization.XmlEnumAttribute("4")]
        Item4,


        [System.Xml.Serialization.XmlEnumAttribute("5")]
        Item5,


        [System.Xml.Serialization.XmlEnumAttribute("6")]
        Item6,


        [System.Xml.Serialization.XmlEnumAttribute("7")]
        Item7,


        [System.Xml.Serialization.XmlEnumAttribute("8")]
        Item8,


        [System.Xml.Serialization.XmlEnumAttribute("9")]
        Item9,


        [System.Xml.Serialization.XmlEnumAttribute("10")]
        Item10,


        [System.Xml.Serialization.XmlEnumAttribute("11")]
        Item11,
    }



    [Serializable]


    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoICMSICMS51
    {


        public Torig orig{get;set;}


        public TNFeInfNFeDetImpostoICMSICMS51CST CST{get;set;}


        public TNFeInfNFeDetImpostoICMSICMS51ModBC modBC{get;set;}


        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool modBCSpecified{get;set;}


        public string pRedBC{get;set;}


        public string vBC{get;set;}


        public string pICMS{get;set;}


        public string vICMSOp{get;set;}


        public string pDif{get;set;}


        public string vICMSDif{get;set;}


        public string vICMS{get;set;}
    }



    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMS51CST
    {


        [System.Xml.Serialization.XmlEnumAttribute("51")]
        Item51,
    }



    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMS51ModBC
    {


        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,


        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,


        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,


        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,
    }



    [Serializable]


    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoICMSICMS60
    {


        public Torig orig{get;set;}


        public TNFeInfNFeDetImpostoICMSICMS60CST CST{get;set;}


        public string vBCSTRet{get;set;}


        public string vICMSSTRet{get;set;}
    }



    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMS60CST
    {


        [System.Xml.Serialization.XmlEnumAttribute("60")]
        Item60,
    }



    [Serializable]


    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoICMSICMS70
    {


        public Torig orig{get;set;}


        public TNFeInfNFeDetImpostoICMSICMS70CST CST{get;set;}


        public TNFeInfNFeDetImpostoICMSICMS70ModBC modBC{get;set;}


        public string pRedBC{get;set;}


        public string vBC{get;set;}


        public string pICMS{get;set;}


        public string vICMS{get;set;}


        public TNFeInfNFeDetImpostoICMSICMS70ModBCST modBCST{get;set;}


        public string pMVAST{get;set;}


        public string pRedBCST{get;set;}


        public string vBCST{get;set;}


        public string pICMSST{get;set;}


        public string vICMSST{get;set;}


        public string vICMSDeson{get;set;}


        public TNFeInfNFeDetImpostoICMSICMS70MotDesICMS motDesICMS{get;set;}
    }



    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMS70CST
    {


        [System.Xml.Serialization.XmlEnumAttribute("70")]
        Item70,
    }



    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMS70ModBC
    {


        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,


        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,


        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,


        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,
    }



    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMS70ModBCST
    {


        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,


        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,


        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,


        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,


        [System.Xml.Serialization.XmlEnumAttribute("4")]
        Item4,


        [System.Xml.Serialization.XmlEnumAttribute("5")]
        Item5,
    }



    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMS70MotDesICMS
    {


        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,


        [System.Xml.Serialization.XmlEnumAttribute("9")]
        Item9,


        [System.Xml.Serialization.XmlEnumAttribute("12")]
        Item12,
    }



    [Serializable]


    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoICMSICMS90
    {


        public Torig orig{get;set;}


        public TNFeInfNFeDetImpostoICMSICMS90CST CST{get;set;}


        public TNFeInfNFeDetImpostoICMSICMS90ModBC modBC{get;set;}


        public string vBC{get;set;}


        public string pRedBC{get;set;}


        public string pICMS{get;set;}


        public string vICMS{get;set;}


        public TNFeInfNFeDetImpostoICMSICMS90ModBCST modBCST{get;set;}


        public string pMVAST{get;set;}


        public string pRedBCST{get;set;}


        public string vBCST{get;set;}


        public string pICMSST{get;set;}


        public string vICMSST{get;set;}


        public string vICMSDeson{get;set;}


        public TNFeInfNFeDetImpostoICMSICMS90MotDesICMS motDesICMS{get;set;}
    }



    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMS90CST
    {


        [System.Xml.Serialization.XmlEnumAttribute("90")]
        Item90,
    }



    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMS90ModBC
    {


        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,


        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,


        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,


        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,
    }



    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMS90ModBCST
    {


        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,


        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,


        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,


        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,


        [System.Xml.Serialization.XmlEnumAttribute("4")]
        Item4,


        [System.Xml.Serialization.XmlEnumAttribute("5")]
        Item5,
    }



    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMS90MotDesICMS
    {


        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,


        [System.Xml.Serialization.XmlEnumAttribute("9")]
        Item9,


        [System.Xml.Serialization.XmlEnumAttribute("12")]
        Item12,
    }



    [Serializable]


    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoICMSICMSPart
    {


        public Torig orig{get;set;}


        public TNFeInfNFeDetImpostoICMSICMSPartCST CST{get;set;}


        public TNFeInfNFeDetImpostoICMSICMSPartModBC modBC{get;set;}


        public string vBC{get;set;}


        public string pRedBC{get;set;}


        public string pICMS{get;set;}


        public string vICMS{get;set;}


        public TNFeInfNFeDetImpostoICMSICMSPartModBCST modBCST{get;set;}


        public string pMVAST{get;set;}


        public string pRedBCST{get;set;}


        public string vBCST{get;set;}


        public string pICMSST{get;set;}


        public string vICMSST{get;set;}


        public string pBCOp{get;set;}


        public TUf UFST{get;set;}
    }



    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMSPartCST
    {


        [System.Xml.Serialization.XmlEnumAttribute("10")]
        Item10,


        [System.Xml.Serialization.XmlEnumAttribute("90")]
        Item90,
    }



    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMSPartModBC
    {


        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,


        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,


        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,


        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,
    }



    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMSPartModBCST
    {


        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,


        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,


        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,


        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,


        [System.Xml.Serialization.XmlEnumAttribute("4")]
        Item4,


        [System.Xml.Serialization.XmlEnumAttribute("5")]
        Item5,
    }



    [Serializable]


    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoICMSICMSSN101
    {


        public Torig orig{get;set;}


        public TNFeInfNFeDetImpostoICMSICMSSN101CSOSN CSOSN{get;set;}


        public string pCredSN{get;set;}


        public string vCredICMSSN{get;set;}
    }



    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMSSN101CSOSN
    {


        [System.Xml.Serialization.XmlEnumAttribute("101")]
        Item101,
    }



    [Serializable]


    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoICMSICMSSN102
    {


        public Torig orig{get;set;}


        public TNFeInfNFeDetImpostoICMSICMSSN102CSOSN CSOSN{get;set;}
    }



    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMSSN102CSOSN
    {


        [System.Xml.Serialization.XmlEnumAttribute("102")]
        Item102,


        [System.Xml.Serialization.XmlEnumAttribute("103")]
        Item103,


        [System.Xml.Serialization.XmlEnumAttribute("300")]
        Item300,


        [System.Xml.Serialization.XmlEnumAttribute("400")]
        Item400,
    }



    [Serializable]


    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoICMSICMSSN201
    {


        public Torig orig{get;set;}


        public TNFeInfNFeDetImpostoICMSICMSSN201CSOSN CSOSN{get;set;}


        public TNFeInfNFeDetImpostoICMSICMSSN201ModBCST modBCST{get;set;}


        public string pMVAST{get;set;}


        public string pRedBCST{get;set;}


        public string vBCST{get;set;}


        public string pICMSST{get;set;}


        public string vICMSST{get;set;}


        public string pCredSN{get;set;}


        public string vCredICMSSN{get;set;}
    }



    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMSSN201CSOSN
    {


        [System.Xml.Serialization.XmlEnumAttribute("201")]
        Item201,
    }



    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMSSN201ModBCST
    {


        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,


        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,


        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,


        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,


        [System.Xml.Serialization.XmlEnumAttribute("4")]
        Item4,


        [System.Xml.Serialization.XmlEnumAttribute("5")]
        Item5,
    }



    [Serializable]


    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoICMSICMSSN202
    {


        public Torig orig{get;set;}


        public TNFeInfNFeDetImpostoICMSICMSSN202CSOSN CSOSN{get;set;}


        public TNFeInfNFeDetImpostoICMSICMSSN202ModBCST modBCST{get;set;}


        public string pMVAST{get;set;}


        public string pRedBCST{get;set;}


        public string vBCST{get;set;}


        public string pICMSST{get;set;}


        public string vICMSST{get;set;}
    }



    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMSSN202CSOSN
    {


        [System.Xml.Serialization.XmlEnumAttribute("202")]
        Item202,


        [System.Xml.Serialization.XmlEnumAttribute("203")]
        Item203,
    }



    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMSSN202ModBCST
    {


        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,


        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,


        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,


        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,


        [System.Xml.Serialization.XmlEnumAttribute("4")]
        Item4,


        [System.Xml.Serialization.XmlEnumAttribute("5")]
        Item5,
    }



    [Serializable]


    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoICMSICMSSN500
    {


        public Torig orig{get;set;}


        public TNFeInfNFeDetImpostoICMSICMSSN500CSOSN CSOSN{get;set;}


        public string vBCSTRet{get;set;}


        public string vICMSSTRet{get;set;}
    }



    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMSSN500CSOSN
    {


        [System.Xml.Serialization.XmlEnumAttribute("500")]
        Item500,
    }



    [Serializable]


    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoICMSICMSSN900
    {


        public Torig orig{get;set;}


        public TNFeInfNFeDetImpostoICMSICMSSN900CSOSN CSOSN{get;set;}


        public TNFeInfNFeDetImpostoICMSICMSSN900ModBC modBC{get;set;}


        public string vBC{get;set;}


        public string pRedBC{get;set;}


        public string pICMS{get;set;}


        public string vICMS{get;set;}


        public TNFeInfNFeDetImpostoICMSICMSSN900ModBCST modBCST{get;set;}


        public string pMVAST{get;set;}


        public string pRedBCST{get;set;}


        public string vBCST{get;set;}


        public string pICMSST{get;set;}


        public string vICMSST{get;set;}


        public string pCredSN{get;set;}


        public string vCredICMSSN{get;set;}
    }



    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMSSN900CSOSN
    {


        [System.Xml.Serialization.XmlEnumAttribute("900")]
        Item900,
    }



    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMSSN900ModBC
    {


        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,


        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,


        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,


        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,
    }



    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMSSN900ModBCST
    {


        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,


        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,


        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,


        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,


        [System.Xml.Serialization.XmlEnumAttribute("4")]
        Item4,


        [System.Xml.Serialization.XmlEnumAttribute("5")]
        Item5,
    }



    [Serializable]


    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoICMSICMSST
    {


        public Torig orig{get;set;}


        public TNFeInfNFeDetImpostoICMSICMSSTCST CST{get;set;}


        public string vBCSTRet{get;set;}


        public string vICMSSTRet{get;set;}


        public string vBCSTDest{get;set;}


        public string vICMSSTDest{get;set;}
    }



    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMSSTCST
    {


        [System.Xml.Serialization.XmlEnumAttribute("41")]
        Item41,
    }



    [Serializable]


    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoII
    {


        public string vBC{get;set;}


        public string vDespAdu{get;set;}


        public string vII{get;set;}


        public string vIOF{get;set;}
    }



    [Serializable]


    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoISSQN
    {


        public string vBC{get;set;}


        public string vAliq{get;set;}


        public string vISSQN{get;set;}


        public string cMunFG{get;set;}


        public TCListServ cListServ{get;set;}


        public string vDeducao{get;set;}


        public string vOutro{get;set;}


        public string vDescIncond{get;set;}


        public string vDescCond{get;set;}


        public string vISSRet{get;set;}


        public TNFeInfNFeDetImpostoISSQNIndISS indISS{get;set;}


        public string cServico{get;set;}


        public string cMun{get;set;}


        public Tpais cPais{get;set;}


        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool cPaisSpecified{get;set;}


        public string nProcesso{get;set;}


        public TNFeInfNFeDetImpostoISSQNIndIncentivo indIncentivo{get;set;}
    }



    [Serializable]
    [XmlType(Namespace = Namespaces.NFe)]
    public enum TCListServ
    {


        [System.Xml.Serialization.XmlEnumAttribute("01.01")]
        Item0101,


        [System.Xml.Serialization.XmlEnumAttribute("01.02")]
        Item0102,


        [System.Xml.Serialization.XmlEnumAttribute("01.03")]
        Item0103,


        [System.Xml.Serialization.XmlEnumAttribute("01.04")]
        Item0104,


        [System.Xml.Serialization.XmlEnumAttribute("01.05")]
        Item0105,


        [System.Xml.Serialization.XmlEnumAttribute("01.06")]
        Item0106,


        [System.Xml.Serialization.XmlEnumAttribute("01.07")]
        Item0107,


        [System.Xml.Serialization.XmlEnumAttribute("01.08")]
        Item0108,


        [System.Xml.Serialization.XmlEnumAttribute("02.01")]
        Item0201,


        [System.Xml.Serialization.XmlEnumAttribute("03.02")]
        Item0302,


        [System.Xml.Serialization.XmlEnumAttribute("03.03")]
        Item0303,


        [System.Xml.Serialization.XmlEnumAttribute("03.04")]
        Item0304,


        [System.Xml.Serialization.XmlEnumAttribute("03.05")]
        Item0305,


        [System.Xml.Serialization.XmlEnumAttribute("04.01")]
        Item0401,


        [System.Xml.Serialization.XmlEnumAttribute("04.02")]
        Item0402,


        [System.Xml.Serialization.XmlEnumAttribute("04.03")]
        Item0403,


        [System.Xml.Serialization.XmlEnumAttribute("04.04")]
        Item0404,


        [System.Xml.Serialization.XmlEnumAttribute("04.05")]
        Item0405,


        [System.Xml.Serialization.XmlEnumAttribute("04.06")]
        Item0406,


        [System.Xml.Serialization.XmlEnumAttribute("04.07")]
        Item0407,


        [System.Xml.Serialization.XmlEnumAttribute("04.08")]
        Item0408,


        [System.Xml.Serialization.XmlEnumAttribute("04.09")]
        Item0409,


        [System.Xml.Serialization.XmlEnumAttribute("04.10")]
        Item0410,


        [System.Xml.Serialization.XmlEnumAttribute("04.11")]
        Item0411,


        [System.Xml.Serialization.XmlEnumAttribute("04.12")]
        Item0412,


        [System.Xml.Serialization.XmlEnumAttribute("04.13")]
        Item0413,


        [System.Xml.Serialization.XmlEnumAttribute("04.14")]
        Item0414,


        [System.Xml.Serialization.XmlEnumAttribute("04.15")]
        Item0415,


        [System.Xml.Serialization.XmlEnumAttribute("04.16")]
        Item0416,


        [System.Xml.Serialization.XmlEnumAttribute("04.17")]
        Item0417,


        [System.Xml.Serialization.XmlEnumAttribute("04.18")]
        Item0418,


        [System.Xml.Serialization.XmlEnumAttribute("04.19")]
        Item0419,


        [System.Xml.Serialization.XmlEnumAttribute("04.20")]
        Item0420,


        [System.Xml.Serialization.XmlEnumAttribute("04.21")]
        Item0421,


        [System.Xml.Serialization.XmlEnumAttribute("04.22")]
        Item0422,


        [System.Xml.Serialization.XmlEnumAttribute("04.23")]
        Item0423,


        [System.Xml.Serialization.XmlEnumAttribute("05.01")]
        Item0501,


        [System.Xml.Serialization.XmlEnumAttribute("05.02")]
        Item0502,


        [System.Xml.Serialization.XmlEnumAttribute("05.03")]
        Item0503,


        [System.Xml.Serialization.XmlEnumAttribute("05.04")]
        Item0504,


        [System.Xml.Serialization.XmlEnumAttribute("05.05")]
        Item0505,


        [System.Xml.Serialization.XmlEnumAttribute("05.06")]
        Item0506,


        [System.Xml.Serialization.XmlEnumAttribute("05.07")]
        Item0507,


        [System.Xml.Serialization.XmlEnumAttribute("05.08")]
        Item0508,


        [System.Xml.Serialization.XmlEnumAttribute("05.09")]
        Item0509,


        [System.Xml.Serialization.XmlEnumAttribute("06.01")]
        Item0601,


        [System.Xml.Serialization.XmlEnumAttribute("06.02")]
        Item0602,


        [System.Xml.Serialization.XmlEnumAttribute("06.03")]
        Item0603,


        [System.Xml.Serialization.XmlEnumAttribute("06.04")]
        Item0604,


        [System.Xml.Serialization.XmlEnumAttribute("06.05")]
        Item0605,


        [System.Xml.Serialization.XmlEnumAttribute("07.01")]
        Item0701,


        [System.Xml.Serialization.XmlEnumAttribute("07.02")]
        Item0702,


        [System.Xml.Serialization.XmlEnumAttribute("07.03")]
        Item0703,


        [System.Xml.Serialization.XmlEnumAttribute("07.04")]
        Item0704,


        [System.Xml.Serialization.XmlEnumAttribute("07.05")]
        Item0705,


        [System.Xml.Serialization.XmlEnumAttribute("07.06")]
        Item0706,


        [System.Xml.Serialization.XmlEnumAttribute("07.07")]
        Item0707,


        [System.Xml.Serialization.XmlEnumAttribute("07.08")]
        Item0708,


        [System.Xml.Serialization.XmlEnumAttribute("07.09")]
        Item0709,


        [System.Xml.Serialization.XmlEnumAttribute("07.10")]
        Item0710,


        [System.Xml.Serialization.XmlEnumAttribute("07.11")]
        Item0711,


        [System.Xml.Serialization.XmlEnumAttribute("07.12")]
        Item0712,


        [System.Xml.Serialization.XmlEnumAttribute("07.13")]
        Item0713,


        [System.Xml.Serialization.XmlEnumAttribute("07.16")]
        Item0716,


        [System.Xml.Serialization.XmlEnumAttribute("07.17")]
        Item0717,


        [System.Xml.Serialization.XmlEnumAttribute("07.18")]
        Item0718,


        [System.Xml.Serialization.XmlEnumAttribute("07.19")]
        Item0719,


        [System.Xml.Serialization.XmlEnumAttribute("07.20")]
        Item0720,


        [System.Xml.Serialization.XmlEnumAttribute("07.21")]
        Item0721,


        [System.Xml.Serialization.XmlEnumAttribute("07.22")]
        Item0722,


        [System.Xml.Serialization.XmlEnumAttribute("08.01")]
        Item0801,


        [System.Xml.Serialization.XmlEnumAttribute("08.02")]
        Item0802,


        [System.Xml.Serialization.XmlEnumAttribute("09.01")]
        Item0901,


        [System.Xml.Serialization.XmlEnumAttribute("09.02")]
        Item0902,


        [System.Xml.Serialization.XmlEnumAttribute("09.03")]
        Item0903,


        [System.Xml.Serialization.XmlEnumAttribute("10.01")]
        Item1001,


        [System.Xml.Serialization.XmlEnumAttribute("10.02")]
        Item1002,


        [System.Xml.Serialization.XmlEnumAttribute("10.03")]
        Item1003,


        [System.Xml.Serialization.XmlEnumAttribute("10.04")]
        Item1004,


        [System.Xml.Serialization.XmlEnumAttribute("10.05")]
        Item1005,


        [System.Xml.Serialization.XmlEnumAttribute("10.06")]
        Item1006,


        [System.Xml.Serialization.XmlEnumAttribute("10.07")]
        Item1007,


        [System.Xml.Serialization.XmlEnumAttribute("10.08")]
        Item1008,


        [System.Xml.Serialization.XmlEnumAttribute("10.09")]
        Item1009,


        [System.Xml.Serialization.XmlEnumAttribute("10.10")]
        Item1010,


        [System.Xml.Serialization.XmlEnumAttribute("11.01")]
        Item1101,


        [System.Xml.Serialization.XmlEnumAttribute("11.02")]
        Item1102,


        [System.Xml.Serialization.XmlEnumAttribute("11.03")]
        Item1103,


        [System.Xml.Serialization.XmlEnumAttribute("11.04")]
        Item1104,


        [System.Xml.Serialization.XmlEnumAttribute("12.01")]
        Item1201,


        [System.Xml.Serialization.XmlEnumAttribute("12.02")]
        Item1202,


        [System.Xml.Serialization.XmlEnumAttribute("12.03")]
        Item1203,


        [System.Xml.Serialization.XmlEnumAttribute("12.04")]
        Item1204,


        [System.Xml.Serialization.XmlEnumAttribute("12.05")]
        Item1205,


        [System.Xml.Serialization.XmlEnumAttribute("12.06")]
        Item1206,


        [System.Xml.Serialization.XmlEnumAttribute("12.07")]
        Item1207,


        [System.Xml.Serialization.XmlEnumAttribute("12.08")]
        Item1208,


        [System.Xml.Serialization.XmlEnumAttribute("12.09")]
        Item1209,


        [System.Xml.Serialization.XmlEnumAttribute("12.10")]
        Item1210,


        [System.Xml.Serialization.XmlEnumAttribute("12.11")]
        Item1211,


        [System.Xml.Serialization.XmlEnumAttribute("12.12")]
        Item1212,


        [System.Xml.Serialization.XmlEnumAttribute("12.13")]
        Item1213,


        [System.Xml.Serialization.XmlEnumAttribute("12.14")]
        Item1214,


        [System.Xml.Serialization.XmlEnumAttribute("12.15")]
        Item1215,


        [System.Xml.Serialization.XmlEnumAttribute("12.16")]
        Item1216,


        [System.Xml.Serialization.XmlEnumAttribute("12.17")]
        Item1217,


        [System.Xml.Serialization.XmlEnumAttribute("13.02")]
        Item1302,


        [System.Xml.Serialization.XmlEnumAttribute("13.03")]
        Item1303,


        [System.Xml.Serialization.XmlEnumAttribute("13.04")]
        Item1304,


        [System.Xml.Serialization.XmlEnumAttribute("13.05")]
        Item1305,


        [System.Xml.Serialization.XmlEnumAttribute("14.01")]
        Item1401,


        [System.Xml.Serialization.XmlEnumAttribute("14.02")]
        Item1402,


        [System.Xml.Serialization.XmlEnumAttribute("14.03")]
        Item1403,


        [System.Xml.Serialization.XmlEnumAttribute("14.04")]
        Item1404,


        [System.Xml.Serialization.XmlEnumAttribute("14.05")]
        Item1405,


        [System.Xml.Serialization.XmlEnumAttribute("14.06")]
        Item1406,


        [System.Xml.Serialization.XmlEnumAttribute("14.07")]
        Item1407,


        [System.Xml.Serialization.XmlEnumAttribute("14.08")]
        Item1408,


        [System.Xml.Serialization.XmlEnumAttribute("14.09")]
        Item1409,


        [System.Xml.Serialization.XmlEnumAttribute("14.10")]
        Item1410,


        [System.Xml.Serialization.XmlEnumAttribute("14.11")]
        Item1411,


        [System.Xml.Serialization.XmlEnumAttribute("14.12")]
        Item1412,


        [System.Xml.Serialization.XmlEnumAttribute("14.13")]
        Item1413,


        [System.Xml.Serialization.XmlEnumAttribute("15.01")]
        Item1501,


        [System.Xml.Serialization.XmlEnumAttribute("15.02")]
        Item1502,


        [System.Xml.Serialization.XmlEnumAttribute("15.03")]
        Item1503,


        [System.Xml.Serialization.XmlEnumAttribute("15.04")]
        Item1504,


        [System.Xml.Serialization.XmlEnumAttribute("15.05")]
        Item1505,


        [System.Xml.Serialization.XmlEnumAttribute("15.06")]
        Item1506,


        [System.Xml.Serialization.XmlEnumAttribute("15.07")]
        Item1507,


        [System.Xml.Serialization.XmlEnumAttribute("15.08")]
        Item1508,


        [System.Xml.Serialization.XmlEnumAttribute("15.09")]
        Item1509,


        [System.Xml.Serialization.XmlEnumAttribute("15.10")]
        Item1510,


        [System.Xml.Serialization.XmlEnumAttribute("15.11")]
        Item1511,


        [System.Xml.Serialization.XmlEnumAttribute("15.12")]
        Item1512,


        [System.Xml.Serialization.XmlEnumAttribute("15.13")]
        Item1513,


        [System.Xml.Serialization.XmlEnumAttribute("15.14")]
        Item1514,


        [System.Xml.Serialization.XmlEnumAttribute("15.15")]
        Item1515,


        [System.Xml.Serialization.XmlEnumAttribute("15.16")]
        Item1516,


        [System.Xml.Serialization.XmlEnumAttribute("15.17")]
        Item1517,


        [System.Xml.Serialization.XmlEnumAttribute("15.18")]
        Item1518,


        [System.Xml.Serialization.XmlEnumAttribute("16.01")]
        Item1601,


        [System.Xml.Serialization.XmlEnumAttribute("17.01")]
        Item1701,


        [System.Xml.Serialization.XmlEnumAttribute("17.02")]
        Item1702,


        [System.Xml.Serialization.XmlEnumAttribute("17.03")]
        Item1703,


        [System.Xml.Serialization.XmlEnumAttribute("17.04")]
        Item1704,


        [System.Xml.Serialization.XmlEnumAttribute("17.05")]
        Item1705,


        [System.Xml.Serialization.XmlEnumAttribute("17.06")]
        Item1706,


        [System.Xml.Serialization.XmlEnumAttribute("17.08")]
        Item1708,


        [System.Xml.Serialization.XmlEnumAttribute("17.09")]
        Item1709,


        [System.Xml.Serialization.XmlEnumAttribute("17.10")]
        Item1710,


        [System.Xml.Serialization.XmlEnumAttribute("17.11")]
        Item1711,


        [System.Xml.Serialization.XmlEnumAttribute("17.12")]
        Item1712,


        [System.Xml.Serialization.XmlEnumAttribute("17.13")]
        Item1713,


        [System.Xml.Serialization.XmlEnumAttribute("17.14")]
        Item1714,


        [System.Xml.Serialization.XmlEnumAttribute("17.15")]
        Item1715,


        [System.Xml.Serialization.XmlEnumAttribute("17.16")]
        Item1716,


        [System.Xml.Serialization.XmlEnumAttribute("17.17")]
        Item1717,


        [System.Xml.Serialization.XmlEnumAttribute("17.18")]
        Item1718,


        [System.Xml.Serialization.XmlEnumAttribute("17.19")]
        Item1719,


        [System.Xml.Serialization.XmlEnumAttribute("17.20")]
        Item1720,


        [System.Xml.Serialization.XmlEnumAttribute("17.21")]
        Item1721,


        [System.Xml.Serialization.XmlEnumAttribute("17.22")]
        Item1722,


        [System.Xml.Serialization.XmlEnumAttribute("17.23")]
        Item1723,


        [System.Xml.Serialization.XmlEnumAttribute("17.24")]
        Item1724,


        [System.Xml.Serialization.XmlEnumAttribute("18.01")]
        Item1801,


        [System.Xml.Serialization.XmlEnumAttribute("19.01")]
        Item1901,


        [System.Xml.Serialization.XmlEnumAttribute("20.01")]
        Item2001,


        [System.Xml.Serialization.XmlEnumAttribute("20.02")]
        Item2002,


        [System.Xml.Serialization.XmlEnumAttribute("20.03")]
        Item2003,


        [System.Xml.Serialization.XmlEnumAttribute("21.01")]
        Item2101,


        [System.Xml.Serialization.XmlEnumAttribute("22.01")]
        Item2201,


        [System.Xml.Serialization.XmlEnumAttribute("23.01")]
        Item2301,


        [System.Xml.Serialization.XmlEnumAttribute("24.01")]
        Item2401,


        [System.Xml.Serialization.XmlEnumAttribute("25.01")]
        Item2501,


        [System.Xml.Serialization.XmlEnumAttribute("25.02")]
        Item2502,


        [System.Xml.Serialization.XmlEnumAttribute("25.03")]
        Item2503,


        [System.Xml.Serialization.XmlEnumAttribute("25.04")]
        Item2504,


        [System.Xml.Serialization.XmlEnumAttribute("26.01")]
        Item2601,


        [System.Xml.Serialization.XmlEnumAttribute("27.01")]
        Item2701,


        [System.Xml.Serialization.XmlEnumAttribute("28.01")]
        Item2801,


        [System.Xml.Serialization.XmlEnumAttribute("29.01")]
        Item2901,


        [System.Xml.Serialization.XmlEnumAttribute("30.01")]
        Item3001,


        [System.Xml.Serialization.XmlEnumAttribute("31.01")]
        Item3101,


        [System.Xml.Serialization.XmlEnumAttribute("32.01")]
        Item3201,


        [System.Xml.Serialization.XmlEnumAttribute("33.01")]
        Item3301,


        [System.Xml.Serialization.XmlEnumAttribute("34.01")]
        Item3401,


        [System.Xml.Serialization.XmlEnumAttribute("35.01")]
        Item3501,


        [System.Xml.Serialization.XmlEnumAttribute("36.01")]
        Item3601,


        [System.Xml.Serialization.XmlEnumAttribute("37.01")]
        Item3701,


        [System.Xml.Serialization.XmlEnumAttribute("38.01")]
        Item3801,


        [System.Xml.Serialization.XmlEnumAttribute("39.01")]
        Item3901,


        [System.Xml.Serialization.XmlEnumAttribute("40.01")]
        Item4001,
    }



    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoISSQNIndISS
    {


        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,


        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,


        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,


        [System.Xml.Serialization.XmlEnumAttribute("4")]
        Item4,


        [System.Xml.Serialization.XmlEnumAttribute("5")]
        Item5,


        [System.Xml.Serialization.XmlEnumAttribute("6")]
        Item6,


        [System.Xml.Serialization.XmlEnumAttribute("7")]
        Item7,
    }



    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoISSQNIndIncentivo
    {


        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,


        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,
    }



    [Serializable]


    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoPIS
    {


        [System.Xml.Serialization.XmlElementAttribute("PISAliq", typeof(TNFeInfNFeDetImpostoPISPISAliq))]
        [System.Xml.Serialization.XmlElementAttribute("PISNT", typeof(TNFeInfNFeDetImpostoPISPISNT))]
        [System.Xml.Serialization.XmlElementAttribute("PISOutr", typeof(TNFeInfNFeDetImpostoPISPISOutr))]
        [System.Xml.Serialization.XmlElementAttribute("PISQtde", typeof(TNFeInfNFeDetImpostoPISPISQtde))]
        public object Item{get;set;}
    }



    [Serializable]


    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoPISPISAliq
    {


        public TNFeInfNFeDetImpostoPISPISAliqCST CST{get;set;}


        public string vBC{get;set;}


        public string pPIS{get;set;}


        public string vPIS{get;set;}
    }



    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoPISPISAliqCST
    {


        [System.Xml.Serialization.XmlEnumAttribute("01")]
        Item01,


        [System.Xml.Serialization.XmlEnumAttribute("02")]
        Item02,
    }



    [Serializable]


    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoPISPISNT
    {


        public TNFeInfNFeDetImpostoPISPISNTCST CST{get;set;}
    }



    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoPISPISNTCST
    {


        [System.Xml.Serialization.XmlEnumAttribute("04")]
        Item04,


        [System.Xml.Serialization.XmlEnumAttribute("05")]
        Item05,


        [System.Xml.Serialization.XmlEnumAttribute("06")]
        Item06,


        [System.Xml.Serialization.XmlEnumAttribute("07")]
        Item07,


        [System.Xml.Serialization.XmlEnumAttribute("08")]
        Item08,


        [System.Xml.Serialization.XmlEnumAttribute("09")]
        Item09,
    }



    [Serializable]


    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoPISPISOutr
    {


        public TNFeInfNFeDetImpostoPISPISOutrCST CST{get;set;}


        [System.Xml.Serialization.XmlElementAttribute("pPIS", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("qBCProd", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("vAliqProd", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("vBC", typeof(string))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public string[] Items{get;set;}


        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemsChoiceType1[] ItemsElementName{get;set;}


        public string vPIS{get;set;}
    }



    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoPISPISOutrCST
    {


        [System.Xml.Serialization.XmlEnumAttribute("49")]
        Item49,


        [System.Xml.Serialization.XmlEnumAttribute("50")]
        Item50,


        [System.Xml.Serialization.XmlEnumAttribute("51")]
        Item51,


        [System.Xml.Serialization.XmlEnumAttribute("52")]
        Item52,


        [System.Xml.Serialization.XmlEnumAttribute("53")]
        Item53,


        [System.Xml.Serialization.XmlEnumAttribute("54")]
        Item54,


        [System.Xml.Serialization.XmlEnumAttribute("55")]
        Item55,


        [System.Xml.Serialization.XmlEnumAttribute("56")]
        Item56,


        [System.Xml.Serialization.XmlEnumAttribute("60")]
        Item60,


        [System.Xml.Serialization.XmlEnumAttribute("61")]
        Item61,


        [System.Xml.Serialization.XmlEnumAttribute("62")]
        Item62,


        [System.Xml.Serialization.XmlEnumAttribute("63")]
        Item63,


        [System.Xml.Serialization.XmlEnumAttribute("64")]
        Item64,


        [System.Xml.Serialization.XmlEnumAttribute("65")]
        Item65,


        [System.Xml.Serialization.XmlEnumAttribute("66")]
        Item66,


        [System.Xml.Serialization.XmlEnumAttribute("67")]
        Item67,


        [System.Xml.Serialization.XmlEnumAttribute("70")]
        Item70,


        [System.Xml.Serialization.XmlEnumAttribute("71")]
        Item71,


        [System.Xml.Serialization.XmlEnumAttribute("72")]
        Item72,


        [System.Xml.Serialization.XmlEnumAttribute("73")]
        Item73,


        [System.Xml.Serialization.XmlEnumAttribute("74")]
        Item74,


        [System.Xml.Serialization.XmlEnumAttribute("75")]
        Item75,


        [System.Xml.Serialization.XmlEnumAttribute("98")]
        Item98,


        [System.Xml.Serialization.XmlEnumAttribute("99")]
        Item99,
    }



    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe", IncludeInSchema = false)]
    public enum ItemsChoiceType1
    {


        pPIS,


        qBCProd,


        vAliqProd,


        vBC,
    }



    [Serializable]


    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoPISPISQtde
    {


        public TNFeInfNFeDetImpostoPISPISQtdeCST CST{get;set;}


        public string qBCProd{get;set;}


        public string vAliqProd{get;set;}


        public string vPIS{get;set;}
    }



    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoPISPISQtdeCST
    {


        [System.Xml.Serialization.XmlEnumAttribute("03")]
        Item03,
    }



    [Serializable]


    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoPISST
    {


        [System.Xml.Serialization.XmlElementAttribute("pPIS", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("qBCProd", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("vAliqProd", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("vBC", typeof(string))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public string[] Items{get;set;}


        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemsChoiceType2[] ItemsElementName{get;set;}


        public string vPIS{get;set;}
    }



    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe", IncludeInSchema = false)]
    public enum ItemsChoiceType2
    {


        pPIS,


        qBCProd,


        vAliqProd,


        vBC,
    }



    [Serializable]


    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoCOFINS
    {


        [System.Xml.Serialization.XmlElementAttribute("COFINSAliq", typeof(TNFeInfNFeDetImpostoCOFINSCOFINSAliq))]
        [System.Xml.Serialization.XmlElementAttribute("COFINSNT", typeof(TNFeInfNFeDetImpostoCOFINSCOFINSNT))]
        [System.Xml.Serialization.XmlElementAttribute("COFINSOutr", typeof(TNFeInfNFeDetImpostoCOFINSCOFINSOutr))]
        [System.Xml.Serialization.XmlElementAttribute("COFINSQtde", typeof(TNFeInfNFeDetImpostoCOFINSCOFINSQtde))]
        public object Item{get;set;}
    }



    [Serializable]


    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoCOFINSCOFINSAliq
    {


        public TNFeInfNFeDetImpostoCOFINSCOFINSAliqCST CST{get;set;}


        public string vBC{get;set;}


        public string pCOFINS{get;set;}


        public string vCOFINS{get;set;}
    }



    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoCOFINSCOFINSAliqCST
    {


        [System.Xml.Serialization.XmlEnumAttribute("01")]
        Item01,


        [System.Xml.Serialization.XmlEnumAttribute("02")]
        Item02,
    }



    [Serializable]


    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoCOFINSCOFINSNT
    {


        public TNFeInfNFeDetImpostoCOFINSCOFINSNTCST CST{get;set;}
    }



    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoCOFINSCOFINSNTCST
    {


        [System.Xml.Serialization.XmlEnumAttribute("04")]
        Item04,


        [System.Xml.Serialization.XmlEnumAttribute("05")]
        Item05,


        [System.Xml.Serialization.XmlEnumAttribute("06")]
        Item06,


        [System.Xml.Serialization.XmlEnumAttribute("07")]
        Item07,


        [System.Xml.Serialization.XmlEnumAttribute("08")]
        Item08,


        [System.Xml.Serialization.XmlEnumAttribute("09")]
        Item09,
    }



    [Serializable]


    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoCOFINSCOFINSOutr
    {


        public TNFeInfNFeDetImpostoCOFINSCOFINSOutrCST CST{get;set;}


        [System.Xml.Serialization.XmlElementAttribute("pCOFINS", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("qBCProd", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("vAliqProd", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("vBC", typeof(string))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public string[] Items{get;set;}


        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemsChoiceType3[] ItemsElementName{get;set;}


        public string vCOFINS{get;set;}
    }



    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoCOFINSCOFINSOutrCST
    {


        [System.Xml.Serialization.XmlEnumAttribute("49")]
        Item49,


        [System.Xml.Serialization.XmlEnumAttribute("50")]
        Item50,


        [System.Xml.Serialization.XmlEnumAttribute("51")]
        Item51,


        [System.Xml.Serialization.XmlEnumAttribute("52")]
        Item52,


        [System.Xml.Serialization.XmlEnumAttribute("53")]
        Item53,


        [System.Xml.Serialization.XmlEnumAttribute("54")]
        Item54,


        [System.Xml.Serialization.XmlEnumAttribute("55")]
        Item55,


        [System.Xml.Serialization.XmlEnumAttribute("56")]
        Item56,


        [System.Xml.Serialization.XmlEnumAttribute("60")]
        Item60,


        [System.Xml.Serialization.XmlEnumAttribute("61")]
        Item61,


        [System.Xml.Serialization.XmlEnumAttribute("62")]
        Item62,


        [System.Xml.Serialization.XmlEnumAttribute("63")]
        Item63,


        [System.Xml.Serialization.XmlEnumAttribute("64")]
        Item64,


        [System.Xml.Serialization.XmlEnumAttribute("65")]
        Item65,


        [System.Xml.Serialization.XmlEnumAttribute("66")]
        Item66,


        [System.Xml.Serialization.XmlEnumAttribute("67")]
        Item67,


        [System.Xml.Serialization.XmlEnumAttribute("70")]
        Item70,


        [System.Xml.Serialization.XmlEnumAttribute("71")]
        Item71,


        [System.Xml.Serialization.XmlEnumAttribute("72")]
        Item72,


        [System.Xml.Serialization.XmlEnumAttribute("73")]
        Item73,


        [System.Xml.Serialization.XmlEnumAttribute("74")]
        Item74,


        [System.Xml.Serialization.XmlEnumAttribute("75")]
        Item75,


        [System.Xml.Serialization.XmlEnumAttribute("98")]
        Item98,


        [System.Xml.Serialization.XmlEnumAttribute("99")]
        Item99,
    }



    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe", IncludeInSchema = false)]
    public enum ItemsChoiceType3
    {


        pCOFINS,


        qBCProd,


        vAliqProd,


        vBC,
    }



    [Serializable]


    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoCOFINSCOFINSQtde
    {


        public TNFeInfNFeDetImpostoCOFINSCOFINSQtdeCST CST{get;set;}


        public string qBCProd{get;set;}


        public string vAliqProd{get;set;}


        public string vCOFINS{get;set;}
    }



    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoCOFINSCOFINSQtdeCST
    {


        [System.Xml.Serialization.XmlEnumAttribute("03")]
        Item03,
    }



    [Serializable]


    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoCOFINSST
    {


        [System.Xml.Serialization.XmlElementAttribute("pCOFINS", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("qBCProd", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("vAliqProd", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("vBC", typeof(string))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public string[] Items{get;set;}


        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemsChoiceType4[] ItemsElementName{get;set;}


        public string vCOFINS{get;set;}
    }



    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe", IncludeInSchema = false)]
    public enum ItemsChoiceType4
    {


        pCOFINS,


        qBCProd,


        vAliqProd,


        vBC,
    }



    [Serializable]


    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoDevol
    {


        public string pDevol{get;set;}


        public TNFeInfNFeDetImpostoDevolIPI IPI{get;set;}
    }



    [Serializable]


    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoDevolIPI
    {


        public string vIPIDevol{get;set;}
    }



    [Serializable]


    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeTotal
    {


        public TNFeInfNFeTotalICMSTot ICMSTot{get;set;}


        public TNFeInfNFeTotalISSQNtot ISSQNtot{get;set;}


        public TNFeInfNFeTotalRetTrib retTrib{get;set;}
    }



    [Serializable]


    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeTotalICMSTot
    {


        public string vBC{get;set;}


        public string vICMS{get;set;}


        public string vICMSDeson{get;set;}


        public string vBCST{get;set;}


        public string vST{get;set;}


        public string vProd{get;set;}


        public string vFrete{get;set;}


        public string vSeg{get;set;}


        public string vDesc{get;set;}


        public string vII{get;set;}


        public string vIPI{get;set;}


        public string vPIS{get;set;}


        public string vCOFINS{get;set;}


        public string vOutro{get;set;}


        public string vNF{get;set;}


        public string vTotTrib{get;set;}
    }



    [Serializable]


    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeTotalISSQNtot
    {


        public string vServ{get;set;}


        public string vBC{get;set;}


        public string vISS{get;set;}


        public string vPIS{get;set;}


        public string vCOFINS{get;set;}


        public string dCompet{get;set;}


        public string vDeducao{get;set;}


        public string vOutro{get;set;}


        public string vDescIncond{get;set;}


        public string vDescCond{get;set;}


        public string vISSRet{get;set;}


        public TNFeInfNFeTotalISSQNtotCRegTrib cRegTrib{get;set;}


        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool cRegTribSpecified{get;set;}
    }



    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeTotalISSQNtotCRegTrib
    {


        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,


        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,


        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,


        [System.Xml.Serialization.XmlEnumAttribute("4")]
        Item4,


        [System.Xml.Serialization.XmlEnumAttribute("5")]
        Item5,


        [System.Xml.Serialization.XmlEnumAttribute("6")]
        Item6,
    }



    [Serializable]


    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeTotalRetTrib
    {


        public string vRetPIS{get;set;}


        public string vRetCOFINS{get;set;}


        public string vRetCSLL{get;set;}


        public string vBCIRRF{get;set;}


        public string vIRRF{get;set;}


        public string vBCRetPrev{get;set;}


        public string vRetPrev{get;set;}
    }



    [Serializable]


    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeTransp
    {


        public TNFeInfNFeTranspModFrete modFrete{get;set;}


        public TNFeInfNFeTranspTransporta transporta{get;set;}


        public TNFeInfNFeTranspRetTransp retTransp{get;set;}


        [System.Xml.Serialization.XmlElementAttribute("balsa", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("reboque", typeof(TVeiculo))]
        [System.Xml.Serialization.XmlElementAttribute("vagao", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("veicTransp", typeof(TVeiculo))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public object[] Items{get;set;}


        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemsChoiceType5[] ItemsElementName{get;set;}


        [System.Xml.Serialization.XmlElementAttribute("vol")]
        public TNFeInfNFeTranspVol[] vol{get;set;}
    }



    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeTranspModFrete
    {


        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,


        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,


        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,


        [System.Xml.Serialization.XmlEnumAttribute("9")]
        Item9,
    }



    [Serializable]


    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeTranspTransporta
    {


        [System.Xml.Serialization.XmlElementAttribute("CNPJ", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("CPF", typeof(string))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public string Item{get;set;}


        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType6 ItemElementName{get;set;}


        public string xNome{get;set;}


        public string IE{get;set;}


        public string xEnder{get;set;}


        public string xMun{get;set;}


        public TUf UF{get;set;}


        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool UFSpecified{get;set;}
    }



    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe", IncludeInSchema = false)]
    public enum ItemChoiceType6
    {


        CNPJ,


        CPF,
    }



    [Serializable]


    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeTranspRetTransp
    {


        public string vServ{get;set;}


        public string vBCRet{get;set;}


        public string pICMSRet{get;set;}


        public string vICMSRet{get;set;}


        public TCfopTransp CFOP{get;set;}


        public string cMunFG{get;set;}
    }



    [Serializable]
    [XmlType(Namespace = Namespaces.NFe)]
    public enum TCfopTransp
    {


        [System.Xml.Serialization.XmlEnumAttribute("5351")]
        Item5351,


        [System.Xml.Serialization.XmlEnumAttribute("5352")]
        Item5352,


        [System.Xml.Serialization.XmlEnumAttribute("5353")]
        Item5353,


        [System.Xml.Serialization.XmlEnumAttribute("5354")]
        Item5354,


        [System.Xml.Serialization.XmlEnumAttribute("5355")]
        Item5355,


        [System.Xml.Serialization.XmlEnumAttribute("5356")]
        Item5356,


        [System.Xml.Serialization.XmlEnumAttribute("5357")]
        Item5357,


        [System.Xml.Serialization.XmlEnumAttribute("5359")]
        Item5359,


        [System.Xml.Serialization.XmlEnumAttribute("5360")]
        Item5360,


        [System.Xml.Serialization.XmlEnumAttribute("5931")]
        Item5931,


        [System.Xml.Serialization.XmlEnumAttribute("5932")]
        Item5932,


        [System.Xml.Serialization.XmlEnumAttribute("6351")]
        Item6351,


        [System.Xml.Serialization.XmlEnumAttribute("6352")]
        Item6352,


        [System.Xml.Serialization.XmlEnumAttribute("6353")]
        Item6353,


        [System.Xml.Serialization.XmlEnumAttribute("6354")]
        Item6354,


        [System.Xml.Serialization.XmlEnumAttribute("6355")]
        Item6355,


        [System.Xml.Serialization.XmlEnumAttribute("6356")]
        Item6356,


        [System.Xml.Serialization.XmlEnumAttribute("6357")]
        Item6357,


        [System.Xml.Serialization.XmlEnumAttribute("6359")]
        Item6359,


        [System.Xml.Serialization.XmlEnumAttribute("6360")]
        Item6360,


        [System.Xml.Serialization.XmlEnumAttribute("6931")]
        Item6931,


        [System.Xml.Serialization.XmlEnumAttribute("6932")]
        Item6932,


        [System.Xml.Serialization.XmlEnumAttribute("7358")]
        Item7358,
    }



    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe", IncludeInSchema = false)]
    public enum ItemsChoiceType5
    {


        balsa,


        reboque,


        vagao,


        veicTransp,
    }



    [Serializable]


    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeTranspVol
    {


        public string qVol{get;set;}


        public string esp{get;set;}


        public string marca{get;set;}


        public string nVol{get;set;}


        public string pesoL{get;set;}


        public string pesoB{get;set;}


        [System.Xml.Serialization.XmlElementAttribute("lacres")]
        public TNFeInfNFeTranspVolLacres[] lacres{get;set;}
    }



    [Serializable]


    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeTranspVolLacres
    {


        public string nLacre{get;set;}
    }



    [Serializable]


    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeCobr
    {


        public TNFeInfNFeCobrFat fat{get;set;}


        [System.Xml.Serialization.XmlElementAttribute("dup")]
        public TNFeInfNFeCobrDup[] dup{get;set;}
    }



    [Serializable]


    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeCobrFat
    {


        public string nFat{get;set;}


        public string vOrig{get;set;}


        public string vDesc{get;set;}


        public string vLiq{get;set;}
    }



    [Serializable]


    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeCobrDup
    {


        public string nDup{get;set;}


        public string dVenc{get;set;}


        public string vDup{get;set;}
    }



    [Serializable]


    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFePag
    {


        public TNFeInfNFePagTPag tPag{get;set;}


        public string vPag{get;set;}


        public TNFeInfNFePagCard card{get;set;}
    }



    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFePagTPag
    {


        [System.Xml.Serialization.XmlEnumAttribute("01")]
        Item01,


        [System.Xml.Serialization.XmlEnumAttribute("02")]
        Item02,


        [System.Xml.Serialization.XmlEnumAttribute("03")]
        Item03,


        [System.Xml.Serialization.XmlEnumAttribute("04")]
        Item04,


        [System.Xml.Serialization.XmlEnumAttribute("05")]
        Item05,


        [System.Xml.Serialization.XmlEnumAttribute("10")]
        Item10,


        [System.Xml.Serialization.XmlEnumAttribute("11")]
        Item11,


        [System.Xml.Serialization.XmlEnumAttribute("12")]
        Item12,


        [System.Xml.Serialization.XmlEnumAttribute("13")]
        Item13,


        [System.Xml.Serialization.XmlEnumAttribute("99")]
        Item99,
    }



    [Serializable]


    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFePagCard
    {


        public string CNPJ{get;set;}


        public TNFeInfNFePagCardTBand tBand{get;set;}


        public string cAut{get;set;}
    }



    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFePagCardTBand
    {


        [System.Xml.Serialization.XmlEnumAttribute("01")]
        Item01,


        [System.Xml.Serialization.XmlEnumAttribute("02")]
        Item02,


        [System.Xml.Serialization.XmlEnumAttribute("03")]
        Item03,


        [System.Xml.Serialization.XmlEnumAttribute("04")]
        Item04,


        [System.Xml.Serialization.XmlEnumAttribute("99")]
        Item99,
    }



    [Serializable]


    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeInfAdic
    {


        public string infAdFisco{get;set;}


        public string infCpl{get;set;}


        [System.Xml.Serialization.XmlElementAttribute("obsCont")]
        public TNFeInfNFeInfAdicObsCont[] obsCont{get;set;}


        [System.Xml.Serialization.XmlElementAttribute("obsFisco")]
        public TNFeInfNFeInfAdicObsFisco[] obsFisco{get;set;}


        [System.Xml.Serialization.XmlElementAttribute("procRef")]
        public TNFeInfNFeInfAdicProcRef[] procRef{get;set;}
    }



    [Serializable]


    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeInfAdicObsCont
    {


        public string xTexto{get;set;}


        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string xCampo{get;set;}
    }



    [Serializable]


    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeInfAdicObsFisco
    {


        public string xTexto{get;set;}


        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string xCampo{get;set;}
    }



    [Serializable]


    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeInfAdicProcRef
    {


        public string nProc{get;set;}


        public TNFeInfNFeInfAdicProcRefIndProc indProc{get;set;}
    }



    [Serializable]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeInfAdicProcRefIndProc
    {


        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,


        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,


        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,


        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,


        [System.Xml.Serialization.XmlEnumAttribute("9")]
        Item9,
    }



    [Serializable]


    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeExporta
    {


        public TUfEmi UFSaidaPais{get;set;}


        public string xLocExporta{get;set;}


        public string xLocDespacho{get;set;}
    }



    [Serializable]


    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeCompra
    {


        public string xNEmp{get;set;}


        public string xPed{get;set;}


        public string xCont{get;set;}
    }



    [Serializable]


    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeCana
    {


        public string safra{get;set;}


        public string @ref{get;set;}


        [System.Xml.Serialization.XmlElementAttribute("forDia")]
        public TNFeInfNFeCanaForDia[] forDia{get;set;}


        public string qTotMes{get;set;}


        public string qTotAnt{get;set;}


        public string qTotGer{get;set;}


        [System.Xml.Serialization.XmlElementAttribute("deduc")]
        public TNFeInfNFeCanaDeduc[] deduc{get;set;}


        public string vFor{get;set;}


        public string vTotDed{get;set;}


        public string vLiqFor{get;set;}
    }



    [Serializable]


    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeCanaForDia
    {


        public string qtde{get;set;}


        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string dia{get;set;}
    }



    [Serializable]


    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeCanaDeduc
    {


        public string xDed{get;set;}


        public string vDed{get;set;}
    }

}