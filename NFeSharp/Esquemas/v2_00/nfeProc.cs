using NFeSharp.Esquemas.TiposBasicos;
using System;
using System.Xml.Serialization;

namespace NFeSharp.Esquemas.v2_00
{
   
    [Serializable]
    [XmlType(Namespace = Namespaces.NFe)]
    [XmlRoot("nfeProc", Namespace = Namespaces.NFe, IsNullable = false)]
    public class nfeProc
    {

        public TNFe NFe { get; set; }
        public TProtNFe protNFe { get; set; }
        [XmlAttribute()]
        public string versao { get; set; }
    }

   
    [Serializable]
    [XmlType(Namespace = Namespaces.NFe)]
    public class TNFe
    {
        public TNFeInfNFe infNFe { get; set; }
        [XmlElement(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
        public NFeSharp.Esquemas.TiposBasicos.SignatureType Signature { get; set; }
    }
   
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = Namespaces.NFe)]
    public class TNFeInfNFe
    {

        public TNFeInfNFeIde ide { get; set; }
        public TNFeInfNFeEmit emit { get; set; }
        public TNFeInfNFeAvulsa avulsa { get; set; }
        public TNFeInfNFeDest dest { get; set; }
        public TLocal retirada { get; set; }
        public TLocal entrega { get; set; }


        [XmlElement("det")]
        public TNFeInfNFeDet[] det { get; set; }
        public TNFeInfNFeTotal total { get; set; }


        public TNFeInfNFeTransp transp { get; set; }
        public TNFeInfNFeCobr cobr { get; set; }
        public TNFeInfNFeInfAdic infAdic { get; set; }
        public TNFeInfNFeExporta exporta { get; set; }
        public TNFeInfNFeCompra compra { get; set; }
        public TNFeInfNFeCana cana { get; set; }

        [XmlAttribute()]
        public string versao { get; set; }


        [XmlAttribute(DataType = "ID")]
        public string Id { get; set; }
    }


   
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = Namespaces.NFe)]
    public class TNFeInfNFeIde
    {

        public UnidadesFederativas cUF { get; set; }
        public string cNF { get; set; }
        public string natOp { get; set; }

        public TNFeInfNFeIdeIndPag indPag { get; set; }

        public TMod mod { get; set; }
        public string serie { get; set; }
        public string nNF { get; set; }
        public string dEmi { get; set; }
        public string dSaiEnt { get; set; }

        public string hSaiEnt { get; set; }
        public TNFeInfNFeIdeTpNF tpNF { get; set; }
        public string cMunFG { get; set; }


        [XmlElement("NFref")]
        public TNFeInfNFeIdeNFref[] NFref { get; set; }


        public TNFeInfNFeIdeTpImp tpImp { get; set; }
        public TNFeInfNFeIdeTpEmis tpEmis { get; set; }


        public string cDV { get; set; }
        public TAmb tpAmb { get; set; }
        public TFinNFe finNFe { get; set; }
        public TProcEmi procEmi { get; set; }
        public string verProc { get; set; }
        public string dhCont { get; set; }
        public string xJust { get; set; }
    }   
   
   
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = Namespaces.NFe)]
    public enum TNFeInfNFeIdeIndPag
    {


        [XmlEnum("0")]
        Item0,


        [XmlEnum("1")]
        Item1,


        [XmlEnum("2")]
        Item2,
    }


   
    [Serializable]
    [XmlType(Namespace = Namespaces.NFe)]
    public enum TMod
    {


        [XmlEnum("55")]
        Item55,
    }


   
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = Namespaces.NFe)]
    public enum TNFeInfNFeIdeTpNF
    {


        [XmlEnum("0")]
        Item0,


        [XmlEnum("1")]
        Item1,
    }


   
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = Namespaces.NFe)]
    public class TNFeInfNFeIdeNFref
    {


        [XmlElement("refCTe", typeof(string))]
        [XmlElement("refECF", typeof(TNFeInfNFeIdeNFrefRefECF))]
        [XmlElement("refNF", typeof(TNFeInfNFeIdeNFrefRefNF))]
        [XmlElement("refNFP", typeof(TNFeInfNFeIdeNFrefRefNFP))]
        [XmlElement("refNFe", typeof(string))]
        [XmlChoiceIdentifier("ItemElementName")]
        public object Item { get; set; }


        [XmlIgnore()]
        public ItemChoiceType1 ItemElementName { get; set; }
    }


   
    [Serializable]


    [XmlType(AnonymousType = true, Namespace = Namespaces.NFe)]
    public class TNFeInfNFeIdeNFrefRefECF
    {

        public TNFeInfNFeIdeNFrefRefECFMod mod { get; set; }
        public string nECF { get; set; }
        public string nCOO { get; set; }
    }


   
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = Namespaces.NFe)]
    public enum TNFeInfNFeIdeNFrefRefECFMod
    {


        [XmlEnum("2B")]
        Item2B,


        [XmlEnum("2C")]
        Item2C,


        [XmlEnum("2D")]
        Item2D,
    }


   
    [Serializable]
    [XmlType(Namespace = Namespaces.NFe)]
    public class TProtNFe
    {
        public TProtNFeInfProt infProt { get; set; }


        [XmlElement(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
        public NFeSharp.Esquemas.TiposBasicos.SignatureType Signature { get; set; }


        [XmlAttribute()]
        public string versao { get; set; }
    }


   
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = Namespaces.NFe)]
    public class TProtNFeInfProt
    {

        public TAmb tpAmb { get; set; }


        public string verAplic { get; set; }


        public string chNFe { get; set; }


        public System.DateTime dhRecbto { get; set; }


        public string nProt { get; set; }


        [XmlElement(DataType = "base64Binary")]
        public byte[] digVal { get; set; }


        public string cStat { get; set; }


        public string xMotivo { get; set; }


        [XmlAttribute(DataType = "ID")]
        public string Id { get; set; }
    }


   
    [Serializable]
    [XmlType(Namespace = Namespaces.NFe)]
    public enum TAmb
    {


        [XmlEnum("1")]
        Item1,


        [XmlEnum("2")]
        Item2,
    }


   
   


   
    [Serializable]


    [XmlType(Namespace = Namespaces.NFe)]
    public class TVeiculo
    {


        public string placa { get; set; }


        public TUf UF { get; set; }


        public string RNTC { get; set; }
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
    public class TLocal
    {


        [XmlElement("CNPJ", typeof(string))]
        [XmlElement("CPF", typeof(string))]
        [XmlChoiceIdentifier("ItemElementName")]
        public string Item { get; set; }


        [XmlIgnore()]
        public TipoDocumento ItemElementName { get; set; }


        public string xLgr { get; set; }


        public string nro { get; set; }


        public string xCpl { get; set; }


        public string xBairro { get; set; }


        public string cMun { get; set; }


        public string xMun { get; set; }


        public TUf UF { get; set; }
    }

       


   
    [Serializable]
    [XmlType(Namespace = Namespaces.NFe)]
    public class TEndereco
    {


        public string xLgr { get; set; }


        public string nro { get; set; }


        public string xCpl { get; set; }


        public string xBairro { get; set; }


        public string cMun { get; set; }


        public string xMun { get; set; }


        public TUf UF { get; set; }


        public string CEP { get; set; }


        public Tpais cPais { get; set; }


        [XmlIgnore()]
        public bool cPaisSpecified { get; set; }


        public string xPais { get; set; }


        public string fone { get; set; }
    }


   
    [Serializable]
    [XmlType(Namespace = Namespaces.NFe)]
    public enum Tpais
    {


        [XmlEnum("132")]
        Item132,


        [XmlEnum("175")]
        Item175,


        [XmlEnum("230")]
        Item230,


        [XmlEnum("310")]
        Item310,


        [XmlEnum("370")]
        Item370,


        [XmlEnum("400")]
        Item400,


        [XmlEnum("418")]
        Item418,


        [XmlEnum("434")]
        Item434,


        [XmlEnum("477")]
        Item477,


        [XmlEnum("531")]
        Item531,


        [XmlEnum("590")]
        Item590,


        [XmlEnum("639")]
        Item639,


        [XmlEnum("647")]
        Item647,


        [XmlEnum("655")]
        Item655,


        [XmlEnum("698")]
        Item698,


        [XmlEnum("728")]
        Item728,


        [XmlEnum("736")]
        Item736,


        [XmlEnum("779")]
        Item779,


        [XmlEnum("809")]
        Item809,


        [XmlEnum("817")]
        Item817,


        [XmlEnum("833")]
        Item833,


        [XmlEnum("850")]
        Item850,


        [XmlEnum("876")]
        Item876,


        [XmlEnum("884")]
        Item884,


        [XmlEnum("906")]
        Item906,


        [XmlEnum("930")]
        Item930,


        [XmlEnum("973")]
        Item973,


        [XmlEnum("981")]
        Item981,


        [XmlEnum("0132")]
        Item0132,


        [XmlEnum("0175")]
        Item0175,


        [XmlEnum("0230")]
        Item0230,


        [XmlEnum("0310")]
        Item0310,


        [XmlEnum("0370")]
        Item0370,


        [XmlEnum("0400")]
        Item0400,


        [XmlEnum("0418")]
        Item0418,


        [XmlEnum("0434")]
        Item0434,


        [XmlEnum("0477")]
        Item0477,


        [XmlEnum("0531")]
        Item0531,


        [XmlEnum("0590")]
        Item0590,


        [XmlEnum("0639")]
        Item0639,


        [XmlEnum("0647")]
        Item0647,


        [XmlEnum("0655")]
        Item0655,


        [XmlEnum("0698")]
        Item0698,


        [XmlEnum("0728")]
        Item0728,


        [XmlEnum("0736")]
        Item0736,


        [XmlEnum("0779")]
        Item0779,


        [XmlEnum("0809")]
        Item0809,


        [XmlEnum("0817")]
        Item0817,


        [XmlEnum("0833")]
        Item0833,


        [XmlEnum("0850")]
        Item0850,


        [XmlEnum("0876")]
        Item0876,


        [XmlEnum("0884")]
        Item0884,


        [XmlEnum("0906")]
        Item0906,


        [XmlEnum("0930")]
        Item0930,


        [XmlEnum("0973")]
        Item0973,


        [XmlEnum("0981")]
        Item0981,


        [XmlEnum("1015")]
        Item1015,


        [XmlEnum("1058")]
        Item1058,


        [XmlEnum("1082")]
        Item1082,


        [XmlEnum("1112")]
        Item1112,


        [XmlEnum("1155")]
        Item1155,


        [XmlEnum("1198")]
        Item1198,


        [XmlEnum("1279")]
        Item1279,


        [XmlEnum("1376")]
        Item1376,


        [XmlEnum("1414")]
        Item1414,


        [XmlEnum("1457")]
        Item1457,


        [XmlEnum("1490")]
        Item1490,


        [XmlEnum("1504")]
        Item1504,


        [XmlEnum("1508")]
        Item1508,


        [XmlEnum("1511")]
        Item1511,


        [XmlEnum("1538")]
        Item1538,


        [XmlEnum("1546")]
        Item1546,


        [XmlEnum("1589")]
        Item1589,


        [XmlEnum("1600")]
        Item1600,


        [XmlEnum("1619")]
        Item1619,


        [XmlEnum("1635")]
        Item1635,


        [XmlEnum("1651")]
        Item1651,


        [XmlEnum("1694")]
        Item1694,


        [XmlEnum("1732")]
        Item1732,


        [XmlEnum("1775")]
        Item1775,


        [XmlEnum("1830")]
        Item1830,


        [XmlEnum("1872")]
        Item1872,


        [XmlEnum("1902")]
        Item1902,


        [XmlEnum("1937")]
        Item1937,


        [XmlEnum("1953")]
        Item1953,


        [XmlEnum("1961")]
        Item1961,


        [XmlEnum("1988")]
        Item1988,


        [XmlEnum("1996")]
        Item1996,


        [XmlEnum("2291")]
        Item2291,


        [XmlEnum("2321")]
        Item2321,


        [XmlEnum("2356")]
        Item2356,


        [XmlEnum("2399")]
        Item2399,


        [XmlEnum("2402")]
        Item2402,


        [XmlEnum("2437")]
        Item2437,


        [XmlEnum("2445")]
        Item2445,


        [XmlEnum("2453")]
        Item2453,


        [XmlEnum("2461")]
        Item2461,


        [XmlEnum("2470")]
        Item2470,


        [XmlEnum("2496")]
        Item2496,


        [XmlEnum("2518")]
        Item2518,


        [XmlEnum("2534")]
        Item2534,


        [XmlEnum("2550")]
        Item2550,


        [XmlEnum("2593")]
        Item2593,


        [XmlEnum("2674")]
        Item2674,


        [XmlEnum("2712")]
        Item2712,


        [XmlEnum("2755")]
        Item2755,


        [XmlEnum("2810")]
        Item2810,


        [XmlEnum("2852")]
        Item2852,


        [XmlEnum("2895")]
        Item2895,


        [XmlEnum("2917")]
        Item2917,


        [XmlEnum("2933")]
        Item2933,


        [XmlEnum("2976")]
        Item2976,


        [XmlEnum("3018")]
        Item3018,


        [XmlEnum("3050")]
        Item3050,


        [XmlEnum("3093")]
        Item3093,


        [XmlEnum("3131")]
        Item3131,


        [XmlEnum("3174")]
        Item3174,


        [XmlEnum("3255")]
        Item3255,


        [XmlEnum("3298")]
        Item3298,


        [XmlEnum("3310")]
        Item3310,


        [XmlEnum("3344")]
        Item3344,


        [XmlEnum("3379")]
        Item3379,


        [XmlEnum("3417")]
        Item3417,


        [XmlEnum("3450")]
        Item3450,


        [XmlEnum("3514")]
        Item3514,


        [XmlEnum("3557")]
        Item3557,


        [XmlEnum("3573")]
        Item3573,


        [XmlEnum("3595")]
        Item3595,


        [XmlEnum("3611")]
        Item3611,


        [XmlEnum("3654")]
        Item3654,


        [XmlEnum("3697")]
        Item3697,


        [XmlEnum("3727")]
        Item3727,


        [XmlEnum("3751")]
        Item3751,


        [XmlEnum("3794")]
        Item3794,


        [XmlEnum("3832")]
        Item3832,


        [XmlEnum("3867")]
        Item3867,


        [XmlEnum("3913")]
        Item3913,


        [XmlEnum("3964")]
        Item3964,


        [XmlEnum("3999")]
        Item3999,


        [XmlEnum("4030")]
        Item4030,


        [XmlEnum("4111")]
        Item4111,


        [XmlEnum("4200")]
        Item4200,


        [XmlEnum("4235")]
        Item4235,


        [XmlEnum("4260")]
        Item4260,


        [XmlEnum("4278")]
        Item4278,


        [XmlEnum("4316")]
        Item4316,


        [XmlEnum("4340")]
        Item4340,


        [XmlEnum("4383")]
        Item4383,


        [XmlEnum("4405")]
        Item4405,


        [XmlEnum("4421")]
        Item4421,


        [XmlEnum("4456")]
        Item4456,


        [XmlEnum("4472")]
        Item4472,


        [XmlEnum("4499")]
        Item4499,


        [XmlEnum("4502")]
        Item4502,


        [XmlEnum("4525")]
        Item4525,


        [XmlEnum("4553")]
        Item4553,


        [XmlEnum("4588")]
        Item4588,


        [XmlEnum("4618")]
        Item4618,


        [XmlEnum("4642")]
        Item4642,


        [XmlEnum("4677")]
        Item4677,


        [XmlEnum("4723")]
        Item4723,


        [XmlEnum("4740")]
        Item4740,


        [XmlEnum("4766")]
        Item4766,


        [XmlEnum("4774")]
        Item4774,


        [XmlEnum("4855")]
        Item4855,


        [XmlEnum("4880")]
        Item4880,


        [XmlEnum("4885")]
        Item4885,


        [XmlEnum("4901")]
        Item4901,


        [XmlEnum("4936")]
        Item4936,


        [XmlEnum("4944")]
        Item4944,


        [XmlEnum("4952")]
        Item4952,


        [XmlEnum("4979")]
        Item4979,


        [XmlEnum("4985")]
        Item4985,


        [XmlEnum("4995")]
        Item4995,


        [XmlEnum("5010")]
        Item5010,


        [XmlEnum("5053")]
        Item5053,


        [XmlEnum("5070")]
        Item5070,


        [XmlEnum("5088")]
        Item5088,


        [XmlEnum("5118")]
        Item5118,


        [XmlEnum("5177")]
        Item5177,


        [XmlEnum("5215")]
        Item5215,


        [XmlEnum("5258")]
        Item5258,


        [XmlEnum("5282")]
        Item5282,


        [XmlEnum("5312")]
        Item5312,


        [XmlEnum("5355")]
        Item5355,


        [XmlEnum("5380")]
        Item5380,


        [XmlEnum("5428")]
        Item5428,


        [XmlEnum("5452")]
        Item5452,


        [XmlEnum("5487")]
        Item5487,


        [XmlEnum("5517")]
        Item5517,


        [XmlEnum("5568")]
        Item5568,


        [XmlEnum("5665")]
        Item5665,


        [XmlEnum("5738")]
        Item5738,


        [XmlEnum("5754")]
        Item5754,


        [XmlEnum("5762")]
        Item5762,


        [XmlEnum("5780")]
        Item5780,


        [XmlEnum("5800")]
        Item5800,


        [XmlEnum("5860")]
        Item5860,


        [XmlEnum("5894")]
        Item5894,


        [XmlEnum("5932")]
        Item5932,


        [XmlEnum("5991")]
        Item5991,


        [XmlEnum("6033")]
        Item6033,


        [XmlEnum("6076")]
        Item6076,


        [XmlEnum("6114")]
        Item6114,


        [XmlEnum("6238")]
        Item6238,


        [XmlEnum("6254")]
        Item6254,


        [XmlEnum("6289")]
        Item6289,


        [XmlEnum("6408")]
        Item6408,


        [XmlEnum("6475")]
        Item6475,


        [XmlEnum("6602")]
        Item6602,


        [XmlEnum("6653")]
        Item6653,


        [XmlEnum("6700")]
        Item6700,


        [XmlEnum("6750")]
        Item6750,


        [XmlEnum("6769")]
        Item6769,


        [XmlEnum("6777")]
        Item6777,


        [XmlEnum("6781")]
        Item6781,


        [XmlEnum("6858")]
        Item6858,


        [XmlEnum("6874")]
        Item6874,


        [XmlEnum("6904")]
        Item6904,


        [XmlEnum("6912")]
        Item6912,


        [XmlEnum("6955")]
        Item6955,


        [XmlEnum("6971")]
        Item6971,


        [XmlEnum("7005")]
        Item7005,


        [XmlEnum("7056")]
        Item7056,


        [XmlEnum("7102")]
        Item7102,


        [XmlEnum("7153")]
        Item7153,


        [XmlEnum("7200")]
        Item7200,


        [XmlEnum("7285")]
        Item7285,


        [XmlEnum("7315")]
        Item7315,


        [XmlEnum("7358")]
        Item7358,


        [XmlEnum("7370")]
        Item7370,


        [XmlEnum("7412")]
        Item7412,


        [XmlEnum("7447")]
        Item7447,


        [XmlEnum("7480")]
        Item7480,


        [XmlEnum("7501")]
        Item7501,


        [XmlEnum("7544")]
        Item7544,


        [XmlEnum("7560")]
        Item7560,


        [XmlEnum("7595")]
        Item7595,


        [XmlEnum("7600")]
        Item7600,


        [XmlEnum("7641")]
        Item7641,


        [XmlEnum("7676")]
        Item7676,


        [XmlEnum("7706")]
        Item7706,


        [XmlEnum("7722")]
        Item7722,


        [XmlEnum("7765")]
        Item7765,


        [XmlEnum("7803")]
        Item7803,


        [XmlEnum("7820")]
        Item7820,


        [XmlEnum("7838")]
        Item7838,


        [XmlEnum("7889")]
        Item7889,


        [XmlEnum("7919")]
        Item7919,


        [XmlEnum("7951")]
        Item7951,


        [XmlEnum("8001")]
        Item8001,


        [XmlEnum("8052")]
        Item8052,


        [XmlEnum("8109")]
        Item8109,


        [XmlEnum("8150")]
        Item8150,


        [XmlEnum("8206")]
        Item8206,


        [XmlEnum("8230")]
        Item8230,


        [XmlEnum("8249")]
        Item8249,


        [XmlEnum("8273")]
        Item8273,


        [XmlEnum("8281")]
        Item8281,


        [XmlEnum("8311")]
        Item8311,


        [XmlEnum("8338")]
        Item8338,


        [XmlEnum("8451")]
        Item8451,


        [XmlEnum("8478")]
        Item8478,


        [XmlEnum("8486")]
        Item8486,


        [XmlEnum("8508")]
        Item8508,


        [XmlEnum("8583")]
        Item8583,


        [XmlEnum("8630")]
        Item8630,


        [XmlEnum("8664")]
        Item8664,


        [XmlEnum("8702")]
        Item8702,


        [XmlEnum("8737")]
        Item8737,


        [XmlEnum("8885")]
        Item8885,


        [XmlEnum("8907")]
        Item8907,


        [XmlEnum("8958")]
        Item8958,


        [XmlEnum("9903")]
        Item9903,


        [XmlEnum("9946")]
        Item9946,


        [XmlEnum("9950")]
        Item9950,


        [XmlEnum("9970")]
        Item9970,
    }


   
    [Serializable]


    [XmlType(Namespace = Namespaces.NFe)]
    public class TEnderEmi
    {


        public string xLgr { get; set; }


        public string nro { get; set; }


        public string xCpl { get; set; }


        public string xBairro { get; set; }


        public string cMun { get; set; }


        public string xMun { get; set; }


        public TUfEmi UF { get; set; }


        public string CEP { get; set; }


        public TEnderEmiCPais cPais { get; set; }


        [XmlIgnore()]
        public bool cPaisSpecified { get; set; }


        public TEnderEmiXPais xPais { get; set; }


        [XmlIgnore()]
        public bool xPaisSpecified { get; set; }


        public string fone { get; set; }
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
    [XmlType(AnonymousType = true, Namespace = Namespaces.NFe)]
    public enum TEnderEmiCPais
    {


        [XmlEnum("1058")]
        Item1058,
    }


   
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = Namespaces.NFe)]
    public enum TEnderEmiXPais
    {


        Brasil,


        BRASIL,
    }


   
    [Serializable]


    [XmlType(AnonymousType = true, Namespace = Namespaces.NFe)]
    public class TNFeInfNFeIdeNFrefRefNF
    {


        public UnidadesFederativas cUF { get; set; }


        public string AAMM { get; set; }


        public string CNPJ { get; set; }


        public TNFeInfNFeIdeNFrefRefNFMod mod { get; set; }


        public string serie { get; set; }


        public string nNF { get; set; }
    }


   
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = Namespaces.NFe)]
    public enum TNFeInfNFeIdeNFrefRefNFMod
    {


        [XmlEnum("01")]
        Item01,
    }


   
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = Namespaces.NFe)]
    public class TNFeInfNFeIdeNFrefRefNFP
    {


        public UnidadesFederativas cUF { get; set; }


        public string AAMM { get; set; }


        [XmlElement("CNPJ", typeof(string))]
        [XmlElement("CPF", typeof(string))]
        [XmlChoiceIdentifier("ItemElementName")]
        public string Item { get; set; }


        [XmlIgnore()]
        public TipoDocumento ItemElementName { get; set; }


        public string IE { get; set; }


        public TNFeInfNFeIdeNFrefRefNFPMod mod { get; set; }


        public string serie { get; set; }


        public string nNF { get; set; }
    }   



   
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = Namespaces.NFe)]
    public enum TNFeInfNFeIdeNFrefRefNFPMod
    {


        [XmlEnum("01")]
        Item01,


        [XmlEnum("04")]
        Item04,
    }


   
    [Serializable]
    [XmlType(Namespace = Namespaces.NFe, IncludeInSchema = false)]
    public enum ItemChoiceType1
    {


        refCTe,


        refECF,


        refNF,


        refNFP,


        refNFe,
    }


   
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = Namespaces.NFe)]
    public enum TNFeInfNFeIdeTpImp
    {


        [XmlEnum("1")]
        Item1,


        [XmlEnum("2")]
        Item2,
    }


   
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = Namespaces.NFe)]
    public enum TNFeInfNFeIdeTpEmis
    {


        [XmlEnum("1")]
        Item1,


        [XmlEnum("2")]
        Item2,


        [XmlEnum("3")]
        Item3,


        [XmlEnum("4")]
        Item4,


        [XmlEnum("5")]
        Item5,


        [XmlEnum("6")]
        Item6,


        [XmlEnum("7")]
        Item7,
    }


   
    [Serializable]
    [XmlType(Namespace = Namespaces.NFe)]
    public enum TFinNFe
    {


        [XmlEnum("1")]
        Item1,


        [XmlEnum("2")]
        Item2,


        [XmlEnum("3")]
        Item3,
    }


   
    [Serializable]
    [XmlType(Namespace = Namespaces.NFe)]
    public enum TProcEmi
    {


        [XmlEnum("0")]
        Item0,


        [XmlEnum("1")]
        Item1,


        [XmlEnum("2")]
        Item2,


        [XmlEnum("3")]
        Item3,
    }


   
    [Serializable]


    [XmlType(AnonymousType = true, Namespace = Namespaces.NFe)]
    public class TNFeInfNFeEmit
    {


        [XmlElement("CNPJ", typeof(string))]
        [XmlElement("CPF", typeof(string))]
        [XmlChoiceIdentifier("ItemElementName")]
        public string Item { get; set; }


        [XmlIgnore()]
        public TipoDocumento ItemElementName { get; set; }


        public string xNome { get; set; }


        public string xFant { get; set; }


        public TEnderEmi enderEmit { get; set; }


        public string IE { get; set; }


        public string IEST { get; set; }


        public string IM { get; set; }


        public string CNAE { get; set; }


        public TNFeInfNFeEmitCRT CRT { get; set; }
    }


   


   
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = Namespaces.NFe)]
    public enum TNFeInfNFeEmitCRT
    {


        [XmlEnum("1")]
        Item1,


        [XmlEnum("2")]
        Item2,


        [XmlEnum("3")]
        Item3,
    }


   
    [Serializable]


    [XmlType(AnonymousType = true, Namespace = Namespaces.NFe)]
    public class TNFeInfNFeAvulsa
    {


        public string CNPJ { get; set; }


        public string xOrgao { get; set; }


        public string matr { get; set; }


        public string xAgente { get; set; }


        public string fone { get; set; }


        public TUfEmi UF { get; set; }


        public string nDAR { get; set; }


        public string dEmi { get; set; }


        public string vDAR { get; set; }


        public string repEmi { get; set; }


        public string dPag { get; set; }
    }


   
    [Serializable]


    [XmlType(AnonymousType = true, Namespace = Namespaces.NFe)]
    public class TNFeInfNFeDest
    {


        [XmlElement("CNPJ", typeof(string))]
        [XmlElement("CPF", typeof(string))]
        [XmlChoiceIdentifier("ItemElementName")]
        public string Item { get; set; }


        [XmlIgnore()]
        public TipoDocumento ItemElementName { get; set; }


        public string xNome { get; set; }


        public TEndereco enderDest { get; set; }


        public string IE { get; set; }


        public string ISUF { get; set; }


        public string email { get; set; }
    }


   


   
    [Serializable]


    [XmlType(AnonymousType = true, Namespace = Namespaces.NFe)]
    public class TNFeInfNFeDet
    {


        public TNFeInfNFeDetProd prod { get; set; }


        public TNFeInfNFeDetImposto imposto { get; set; }


        public string infAdProd { get; set; }


        [XmlAttribute()]
        public string nItem { get; set; }
    }


   
    [Serializable]


    [XmlType(AnonymousType = true, Namespace = Namespaces.NFe)]
    public class TNFeInfNFeDetProd
    {


        public string cProd { get; set; }


        public string cEAN { get; set; }


        public string xProd { get; set; }


        public string NCM { get; set; }


        public string EXTIPI { get; set; }


        public TCfop CFOP { get; set; }


        public string uCom { get; set; }


        public string qCom { get; set; }


        public string vUnCom { get; set; }


        public string vProd { get; set; }


        public string cEANTrib { get; set; }


        public string uTrib { get; set; }


        public string qTrib { get; set; }


        public string vUnTrib { get; set; }


        public string vFrete { get; set; }


        public string vSeg { get; set; }


        public string vDesc { get; set; }


        public string vOutro { get; set; }


        public TNFeInfNFeDetProdIndTot indTot { get; set; }


        [XmlElement("DI")]
        public TNFeInfNFeDetProdDI[] DI { get; set; }


        public string xPed { get; set; }


        public string nItemPed { get; set; }


        public string nFCI { get; set; }


        [XmlElement("arma", typeof(TNFeInfNFeDetProdArma))]
        [XmlElement("comb", typeof(TNFeInfNFeDetProdComb))]
        [XmlElement("med", typeof(TNFeInfNFeDetProdMed))]
        [XmlElement("veicProd", typeof(TNFeInfNFeDetProdVeicProd))]
        public object[] Items { get; set; }
    }


   
    [Serializable]
    [XmlType(Namespace = Namespaces.NFe)]
    public enum TCfop
    {


        [XmlEnum("1101")]
        Item1101,


        [XmlEnum("1102")]
        Item1102,


        [XmlEnum("1111")]
        Item1111,


        [XmlEnum("1113")]
        Item1113,


        [XmlEnum("1116")]
        Item1116,


        [XmlEnum("1117")]
        Item1117,


        [XmlEnum("1118")]
        Item1118,


        [XmlEnum("1120")]
        Item1120,


        [XmlEnum("1121")]
        Item1121,


        [XmlEnum("1122")]
        Item1122,


        [XmlEnum("1124")]
        Item1124,


        [XmlEnum("1125")]
        Item1125,


        [XmlEnum("1126")]
        Item1126,


        [XmlEnum("1128")]
        Item1128,


        [XmlEnum("1151")]
        Item1151,


        [XmlEnum("1152")]
        Item1152,


        [XmlEnum("1153")]
        Item1153,


        [XmlEnum("1154")]
        Item1154,


        [XmlEnum("1201")]
        Item1201,


        [XmlEnum("1202")]
        Item1202,


        [XmlEnum("1203")]
        Item1203,


        [XmlEnum("1204")]
        Item1204,


        [XmlEnum("1205")]
        Item1205,


        [XmlEnum("1206")]
        Item1206,


        [XmlEnum("1207")]
        Item1207,


        [XmlEnum("1208")]
        Item1208,


        [XmlEnum("1209")]
        Item1209,


        [XmlEnum("1251")]
        Item1251,


        [XmlEnum("1252")]
        Item1252,


        [XmlEnum("1253")]
        Item1253,


        [XmlEnum("1254")]
        Item1254,


        [XmlEnum("1255")]
        Item1255,


        [XmlEnum("1256")]
        Item1256,


        [XmlEnum("1257")]
        Item1257,


        [XmlEnum("1301")]
        Item1301,


        [XmlEnum("1302")]
        Item1302,


        [XmlEnum("1303")]
        Item1303,


        [XmlEnum("1304")]
        Item1304,


        [XmlEnum("1305")]
        Item1305,


        [XmlEnum("1306")]
        Item1306,


        [XmlEnum("1351")]
        Item1351,


        [XmlEnum("1352")]
        Item1352,


        [XmlEnum("1353")]
        Item1353,


        [XmlEnum("1354")]
        Item1354,


        [XmlEnum("1355")]
        Item1355,


        [XmlEnum("1356")]
        Item1356,


        [XmlEnum("1360")]
        Item1360,


        [XmlEnum("1401")]
        Item1401,


        [XmlEnum("1403")]
        Item1403,


        [XmlEnum("1406")]
        Item1406,


        [XmlEnum("1407")]
        Item1407,


        [XmlEnum("1408")]
        Item1408,


        [XmlEnum("1409")]
        Item1409,


        [XmlEnum("1410")]
        Item1410,


        [XmlEnum("1411")]
        Item1411,


        [XmlEnum("1414")]
        Item1414,


        [XmlEnum("1415")]
        Item1415,


        [XmlEnum("1451")]
        Item1451,


        [XmlEnum("1452")]
        Item1452,


        [XmlEnum("1501")]
        Item1501,


        [XmlEnum("1503")]
        Item1503,


        [XmlEnum("1504")]
        Item1504,


        [XmlEnum("1505")]
        Item1505,


        [XmlEnum("1506")]
        Item1506,


        [XmlEnum("1551")]
        Item1551,


        [XmlEnum("1552")]
        Item1552,


        [XmlEnum("1553")]
        Item1553,


        [XmlEnum("1554")]
        Item1554,


        [XmlEnum("1555")]
        Item1555,


        [XmlEnum("1556")]
        Item1556,


        [XmlEnum("1557")]
        Item1557,


        [XmlEnum("1601")]
        Item1601,


        [XmlEnum("1602")]
        Item1602,


        [XmlEnum("1603")]
        Item1603,


        [XmlEnum("1604")]
        Item1604,


        [XmlEnum("1605")]
        Item1605,


        [XmlEnum("1651")]
        Item1651,


        [XmlEnum("1652")]
        Item1652,


        [XmlEnum("1653")]
        Item1653,


        [XmlEnum("1658")]
        Item1658,


        [XmlEnum("1659")]
        Item1659,


        [XmlEnum("1660")]
        Item1660,


        [XmlEnum("1661")]
        Item1661,


        [XmlEnum("1662")]
        Item1662,


        [XmlEnum("1663")]
        Item1663,


        [XmlEnum("1664")]
        Item1664,


        [XmlEnum("1901")]
        Item1901,


        [XmlEnum("1902")]
        Item1902,


        [XmlEnum("1903")]
        Item1903,


        [XmlEnum("1904")]
        Item1904,


        [XmlEnum("1905")]
        Item1905,


        [XmlEnum("1906")]
        Item1906,


        [XmlEnum("1907")]
        Item1907,


        [XmlEnum("1908")]
        Item1908,


        [XmlEnum("1909")]
        Item1909,


        [XmlEnum("1910")]
        Item1910,


        [XmlEnum("1911")]
        Item1911,


        [XmlEnum("1912")]
        Item1912,


        [XmlEnum("1913")]
        Item1913,


        [XmlEnum("1914")]
        Item1914,


        [XmlEnum("1915")]
        Item1915,


        [XmlEnum("1916")]
        Item1916,


        [XmlEnum("1917")]
        Item1917,


        [XmlEnum("1918")]
        Item1918,


        [XmlEnum("1919")]
        Item1919,


        [XmlEnum("1920")]
        Item1920,


        [XmlEnum("1921")]
        Item1921,


        [XmlEnum("1922")]
        Item1922,


        [XmlEnum("1923")]
        Item1923,


        [XmlEnum("1924")]
        Item1924,


        [XmlEnum("1925")]
        Item1925,


        [XmlEnum("1926")]
        Item1926,


        [XmlEnum("1931")]
        Item1931,


        [XmlEnum("1932")]
        Item1932,


        [XmlEnum("1933")]
        Item1933,


        [XmlEnum("1934")]
        Item1934,


        [XmlEnum("1949")]
        Item1949,


        [XmlEnum("2101")]
        Item2101,


        [XmlEnum("2102")]
        Item2102,


        [XmlEnum("2111")]
        Item2111,


        [XmlEnum("2113")]
        Item2113,


        [XmlEnum("2116")]
        Item2116,


        [XmlEnum("2117")]
        Item2117,


        [XmlEnum("2118")]
        Item2118,


        [XmlEnum("2120")]
        Item2120,


        [XmlEnum("2121")]
        Item2121,


        [XmlEnum("2122")]
        Item2122,


        [XmlEnum("2124")]
        Item2124,


        [XmlEnum("2125")]
        Item2125,


        [XmlEnum("2126")]
        Item2126,


        [XmlEnum("2128")]
        Item2128,


        [XmlEnum("2151")]
        Item2151,


        [XmlEnum("2152")]
        Item2152,


        [XmlEnum("2153")]
        Item2153,


        [XmlEnum("2154")]
        Item2154,


        [XmlEnum("2201")]
        Item2201,


        [XmlEnum("2202")]
        Item2202,


        [XmlEnum("2203")]
        Item2203,


        [XmlEnum("2204")]
        Item2204,


        [XmlEnum("2205")]
        Item2205,


        [XmlEnum("2206")]
        Item2206,


        [XmlEnum("2207")]
        Item2207,


        [XmlEnum("2208")]
        Item2208,


        [XmlEnum("2209")]
        Item2209,


        [XmlEnum("2251")]
        Item2251,


        [XmlEnum("2252")]
        Item2252,


        [XmlEnum("2253")]
        Item2253,


        [XmlEnum("2254")]
        Item2254,


        [XmlEnum("2255")]
        Item2255,


        [XmlEnum("2256")]
        Item2256,


        [XmlEnum("2257")]
        Item2257,


        [XmlEnum("2301")]
        Item2301,


        [XmlEnum("2302")]
        Item2302,


        [XmlEnum("2303")]
        Item2303,


        [XmlEnum("2304")]
        Item2304,


        [XmlEnum("2305")]
        Item2305,


        [XmlEnum("2306")]
        Item2306,


        [XmlEnum("2351")]
        Item2351,


        [XmlEnum("2352")]
        Item2352,


        [XmlEnum("2353")]
        Item2353,


        [XmlEnum("2354")]
        Item2354,


        [XmlEnum("2355")]
        Item2355,


        [XmlEnum("2356")]
        Item2356,


        [XmlEnum("2401")]
        Item2401,


        [XmlEnum("2403")]
        Item2403,


        [XmlEnum("2406")]
        Item2406,


        [XmlEnum("2407")]
        Item2407,


        [XmlEnum("2408")]
        Item2408,


        [XmlEnum("2409")]
        Item2409,


        [XmlEnum("2410")]
        Item2410,


        [XmlEnum("2411")]
        Item2411,


        [XmlEnum("2414")]
        Item2414,


        [XmlEnum("2415")]
        Item2415,


        [XmlEnum("2501")]
        Item2501,


        [XmlEnum("2503")]
        Item2503,


        [XmlEnum("2504")]
        Item2504,


        [XmlEnum("2505")]
        Item2505,


        [XmlEnum("2506")]
        Item2506,


        [XmlEnum("2551")]
        Item2551,


        [XmlEnum("2552")]
        Item2552,


        [XmlEnum("2553")]
        Item2553,


        [XmlEnum("2554")]
        Item2554,


        [XmlEnum("2555")]
        Item2555,


        [XmlEnum("2556")]
        Item2556,


        [XmlEnum("2557")]
        Item2557,


        [XmlEnum("2603")]
        Item2603,


        [XmlEnum("2651")]
        Item2651,


        [XmlEnum("2652")]
        Item2652,


        [XmlEnum("2653")]
        Item2653,


        [XmlEnum("2658")]
        Item2658,


        [XmlEnum("2659")]
        Item2659,


        [XmlEnum("2660")]
        Item2660,


        [XmlEnum("2661")]
        Item2661,


        [XmlEnum("2662")]
        Item2662,


        [XmlEnum("2663")]
        Item2663,


        [XmlEnum("2664")]
        Item2664,


        [XmlEnum("2901")]
        Item2901,


        [XmlEnum("2902")]
        Item2902,


        [XmlEnum("2903")]
        Item2903,


        [XmlEnum("2904")]
        Item2904,


        [XmlEnum("2905")]
        Item2905,


        [XmlEnum("2906")]
        Item2906,


        [XmlEnum("2907")]
        Item2907,


        [XmlEnum("2908")]
        Item2908,


        [XmlEnum("2909")]
        Item2909,


        [XmlEnum("2910")]
        Item2910,


        [XmlEnum("2911")]
        Item2911,


        [XmlEnum("2912")]
        Item2912,


        [XmlEnum("2913")]
        Item2913,


        [XmlEnum("2914")]
        Item2914,


        [XmlEnum("2915")]
        Item2915,


        [XmlEnum("2916")]
        Item2916,


        [XmlEnum("2917")]
        Item2917,


        [XmlEnum("2918")]
        Item2918,


        [XmlEnum("2919")]
        Item2919,


        [XmlEnum("2920")]
        Item2920,


        [XmlEnum("2921")]
        Item2921,


        [XmlEnum("2922")]
        Item2922,


        [XmlEnum("2923")]
        Item2923,


        [XmlEnum("2924")]
        Item2924,


        [XmlEnum("2925")]
        Item2925,


        [XmlEnum("2931")]
        Item2931,


        [XmlEnum("2932")]
        Item2932,


        [XmlEnum("2933")]
        Item2933,


        [XmlEnum("2934")]
        Item2934,


        [XmlEnum("2949")]
        Item2949,


        [XmlEnum("3101")]
        Item3101,


        [XmlEnum("3102")]
        Item3102,


        [XmlEnum("3126")]
        Item3126,


        [XmlEnum("3127")]
        Item3127,


        [XmlEnum("3128")]
        Item3128,


        [XmlEnum("3201")]
        Item3201,


        [XmlEnum("3202")]
        Item3202,


        [XmlEnum("3205")]
        Item3205,


        [XmlEnum("3206")]
        Item3206,


        [XmlEnum("3207")]
        Item3207,


        [XmlEnum("3211")]
        Item3211,


        [XmlEnum("3251")]
        Item3251,


        [XmlEnum("3301")]
        Item3301,


        [XmlEnum("3351")]
        Item3351,


        [XmlEnum("3352")]
        Item3352,


        [XmlEnum("3353")]
        Item3353,


        [XmlEnum("3354")]
        Item3354,


        [XmlEnum("3355")]
        Item3355,


        [XmlEnum("3356")]
        Item3356,


        [XmlEnum("3503")]
        Item3503,


        [XmlEnum("3551")]
        Item3551,


        [XmlEnum("3553")]
        Item3553,


        [XmlEnum("3556")]
        Item3556,


        [XmlEnum("3651")]
        Item3651,


        [XmlEnum("3652")]
        Item3652,


        [XmlEnum("3653")]
        Item3653,


        [XmlEnum("3930")]
        Item3930,


        [XmlEnum("3949")]
        Item3949,


        [XmlEnum("5101")]
        Item5101,


        [XmlEnum("5102")]
        Item5102,


        [XmlEnum("5103")]
        Item5103,


        [XmlEnum("5104")]
        Item5104,


        [XmlEnum("5105")]
        Item5105,


        [XmlEnum("5106")]
        Item5106,


        [XmlEnum("5109")]
        Item5109,


        [XmlEnum("5110")]
        Item5110,


        [XmlEnum("5111")]
        Item5111,


        [XmlEnum("5112")]
        Item5112,


        [XmlEnum("5113")]
        Item5113,


        [XmlEnum("5114")]
        Item5114,


        [XmlEnum("5115")]
        Item5115,


        [XmlEnum("5116")]
        Item5116,


        [XmlEnum("5117")]
        Item5117,


        [XmlEnum("5118")]
        Item5118,


        [XmlEnum("5119")]
        Item5119,


        [XmlEnum("5120")]
        Item5120,


        [XmlEnum("5122")]
        Item5122,


        [XmlEnum("5123")]
        Item5123,


        [XmlEnum("5124")]
        Item5124,


        [XmlEnum("5125")]
        Item5125,


        [XmlEnum("5151")]
        Item5151,


        [XmlEnum("5152")]
        Item5152,


        [XmlEnum("5153")]
        Item5153,


        [XmlEnum("5155")]
        Item5155,


        [XmlEnum("5156")]
        Item5156,


        [XmlEnum("5201")]
        Item5201,


        [XmlEnum("5202")]
        Item5202,


        [XmlEnum("5205")]
        Item5205,


        [XmlEnum("5206")]
        Item5206,


        [XmlEnum("5207")]
        Item5207,


        [XmlEnum("5208")]
        Item5208,


        [XmlEnum("5209")]
        Item5209,


        [XmlEnum("5210")]
        Item5210,


        [XmlEnum("5251")]
        Item5251,


        [XmlEnum("5252")]
        Item5252,


        [XmlEnum("5253")]
        Item5253,


        [XmlEnum("5254")]
        Item5254,


        [XmlEnum("5255")]
        Item5255,


        [XmlEnum("5256")]
        Item5256,


        [XmlEnum("5257")]
        Item5257,


        [XmlEnum("5258")]
        Item5258,


        [XmlEnum("5401")]
        Item5401,


        [XmlEnum("5402")]
        Item5402,


        [XmlEnum("5403")]
        Item5403,


        [XmlEnum("5405")]
        Item5405,


        [XmlEnum("5408")]
        Item5408,


        [XmlEnum("5409")]
        Item5409,


        [XmlEnum("5410")]
        Item5410,


        [XmlEnum("5411")]
        Item5411,


        [XmlEnum("5412")]
        Item5412,


        [XmlEnum("5413")]
        Item5413,


        [XmlEnum("5414")]
        Item5414,


        [XmlEnum("5415")]
        Item5415,


        [XmlEnum("5451")]
        Item5451,


        [XmlEnum("5501")]
        Item5501,


        [XmlEnum("5502")]
        Item5502,


        [XmlEnum("5503")]
        Item5503,


        [XmlEnum("5504")]
        Item5504,


        [XmlEnum("5505")]
        Item5505,


        [XmlEnum("5551")]
        Item5551,


        [XmlEnum("5552")]
        Item5552,


        [XmlEnum("5553")]
        Item5553,


        [XmlEnum("5554")]
        Item5554,


        [XmlEnum("5555")]
        Item5555,


        [XmlEnum("5556")]
        Item5556,


        [XmlEnum("5557")]
        Item5557,


        [XmlEnum("5601")]
        Item5601,


        [XmlEnum("5602")]
        Item5602,


        [XmlEnum("5603")]
        Item5603,


        [XmlEnum("5605")]
        Item5605,


        [XmlEnum("5606")]
        Item5606,


        [XmlEnum("5651")]
        Item5651,


        [XmlEnum("5652")]
        Item5652,


        [XmlEnum("5653")]
        Item5653,


        [XmlEnum("5654")]
        Item5654,


        [XmlEnum("5655")]
        Item5655,


        [XmlEnum("5656")]
        Item5656,


        [XmlEnum("5657")]
        Item5657,


        [XmlEnum("5658")]
        Item5658,


        [XmlEnum("5659")]
        Item5659,


        [XmlEnum("5660")]
        Item5660,


        [XmlEnum("5661")]
        Item5661,


        [XmlEnum("5662")]
        Item5662,


        [XmlEnum("5663")]
        Item5663,


        [XmlEnum("5664")]
        Item5664,


        [XmlEnum("5665")]
        Item5665,


        [XmlEnum("5666")]
        Item5666,


        [XmlEnum("5667")]
        Item5667,


        [XmlEnum("5901")]
        Item5901,


        [XmlEnum("5902")]
        Item5902,


        [XmlEnum("5903")]
        Item5903,


        [XmlEnum("5904")]
        Item5904,


        [XmlEnum("5905")]
        Item5905,


        [XmlEnum("5906")]
        Item5906,


        [XmlEnum("5907")]
        Item5907,


        [XmlEnum("5908")]
        Item5908,


        [XmlEnum("5909")]
        Item5909,


        [XmlEnum("5910")]
        Item5910,


        [XmlEnum("5911")]
        Item5911,


        [XmlEnum("5912")]
        Item5912,


        [XmlEnum("5913")]
        Item5913,


        [XmlEnum("5914")]
        Item5914,


        [XmlEnum("5915")]
        Item5915,


        [XmlEnum("5916")]
        Item5916,


        [XmlEnum("5917")]
        Item5917,


        [XmlEnum("5918")]
        Item5918,


        [XmlEnum("5919")]
        Item5919,


        [XmlEnum("5920")]
        Item5920,


        [XmlEnum("5921")]
        Item5921,


        [XmlEnum("5922")]
        Item5922,


        [XmlEnum("5923")]
        Item5923,


        [XmlEnum("5924")]
        Item5924,


        [XmlEnum("5925")]
        Item5925,


        [XmlEnum("5926")]
        Item5926,


        [XmlEnum("5927")]
        Item5927,


        [XmlEnum("5928")]
        Item5928,


        [XmlEnum("5929")]
        Item5929,


        [XmlEnum("5931")]
        Item5931,


        [XmlEnum("5932")]
        Item5932,


        [XmlEnum("5933")]
        Item5933,


        [XmlEnum("5934")]
        Item5934,


        [XmlEnum("5949")]
        Item5949,


        [XmlEnum("6101")]
        Item6101,


        [XmlEnum("6102")]
        Item6102,


        [XmlEnum("6103")]
        Item6103,


        [XmlEnum("6104")]
        Item6104,


        [XmlEnum("6105")]
        Item6105,


        [XmlEnum("6106")]
        Item6106,


        [XmlEnum("6107")]
        Item6107,


        [XmlEnum("6108")]
        Item6108,


        [XmlEnum("6109")]
        Item6109,


        [XmlEnum("6110")]
        Item6110,


        [XmlEnum("6111")]
        Item6111,


        [XmlEnum("6112")]
        Item6112,


        [XmlEnum("6113")]
        Item6113,


        [XmlEnum("6114")]
        Item6114,


        [XmlEnum("6115")]
        Item6115,


        [XmlEnum("6116")]
        Item6116,


        [XmlEnum("6117")]
        Item6117,


        [XmlEnum("6118")]
        Item6118,


        [XmlEnum("6119")]
        Item6119,


        [XmlEnum("6120")]
        Item6120,


        [XmlEnum("6122")]
        Item6122,


        [XmlEnum("6123")]
        Item6123,


        [XmlEnum("6124")]
        Item6124,


        [XmlEnum("6125")]
        Item6125,


        [XmlEnum("6151")]
        Item6151,


        [XmlEnum("6152")]
        Item6152,


        [XmlEnum("6153")]
        Item6153,


        [XmlEnum("6155")]
        Item6155,


        [XmlEnum("6156")]
        Item6156,


        [XmlEnum("6201")]
        Item6201,


        [XmlEnum("6202")]
        Item6202,


        [XmlEnum("6205")]
        Item6205,


        [XmlEnum("6206")]
        Item6206,


        [XmlEnum("6207")]
        Item6207,


        [XmlEnum("6208")]
        Item6208,


        [XmlEnum("6209")]
        Item6209,


        [XmlEnum("6210")]
        Item6210,


        [XmlEnum("6251")]
        Item6251,


        [XmlEnum("6252")]
        Item6252,


        [XmlEnum("6253")]
        Item6253,


        [XmlEnum("6254")]
        Item6254,


        [XmlEnum("6255")]
        Item6255,


        [XmlEnum("6256")]
        Item6256,


        [XmlEnum("6257")]
        Item6257,


        [XmlEnum("6258")]
        Item6258,


        [XmlEnum("6401")]
        Item6401,


        [XmlEnum("6402")]
        Item6402,


        [XmlEnum("6403")]
        Item6403,


        [XmlEnum("6404")]
        Item6404,


        [XmlEnum("6408")]
        Item6408,


        [XmlEnum("6409")]
        Item6409,


        [XmlEnum("6410")]
        Item6410,


        [XmlEnum("6411")]
        Item6411,


        [XmlEnum("6412")]
        Item6412,


        [XmlEnum("6413")]
        Item6413,


        [XmlEnum("6414")]
        Item6414,


        [XmlEnum("6415")]
        Item6415,


        [XmlEnum("6501")]
        Item6501,


        [XmlEnum("6502")]
        Item6502,


        [XmlEnum("6503")]
        Item6503,


        [XmlEnum("6504")]
        Item6504,


        [XmlEnum("6505")]
        Item6505,


        [XmlEnum("6551")]
        Item6551,


        [XmlEnum("6552")]
        Item6552,


        [XmlEnum("6553")]
        Item6553,


        [XmlEnum("6554")]
        Item6554,


        [XmlEnum("6555")]
        Item6555,


        [XmlEnum("6556")]
        Item6556,


        [XmlEnum("6557")]
        Item6557,


        [XmlEnum("6603")]
        Item6603,


        [XmlEnum("6651")]
        Item6651,


        [XmlEnum("6652")]
        Item6652,


        [XmlEnum("6653")]
        Item6653,


        [XmlEnum("6654")]
        Item6654,


        [XmlEnum("6655")]
        Item6655,


        [XmlEnum("6656")]
        Item6656,


        [XmlEnum("6657")]
        Item6657,


        [XmlEnum("6658")]
        Item6658,


        [XmlEnum("6659")]
        Item6659,


        [XmlEnum("6660")]
        Item6660,


        [XmlEnum("6661")]
        Item6661,


        [XmlEnum("6662")]
        Item6662,


        [XmlEnum("6663")]
        Item6663,


        [XmlEnum("6664")]
        Item6664,


        [XmlEnum("6665")]
        Item6665,


        [XmlEnum("6666")]
        Item6666,


        [XmlEnum("6667")]
        Item6667,


        [XmlEnum("6901")]
        Item6901,


        [XmlEnum("6902")]
        Item6902,


        [XmlEnum("6903")]
        Item6903,


        [XmlEnum("6904")]
        Item6904,


        [XmlEnum("6905")]
        Item6905,


        [XmlEnum("6906")]
        Item6906,


        [XmlEnum("6907")]
        Item6907,


        [XmlEnum("6908")]
        Item6908,


        [XmlEnum("6909")]
        Item6909,


        [XmlEnum("6910")]
        Item6910,


        [XmlEnum("6911")]
        Item6911,


        [XmlEnum("6912")]
        Item6912,


        [XmlEnum("6913")]
        Item6913,


        [XmlEnum("6914")]
        Item6914,


        [XmlEnum("6915")]
        Item6915,


        [XmlEnum("6916")]
        Item6916,


        [XmlEnum("6917")]
        Item6917,


        [XmlEnum("6918")]
        Item6918,


        [XmlEnum("6919")]
        Item6919,


        [XmlEnum("6920")]
        Item6920,


        [XmlEnum("6921")]
        Item6921,


        [XmlEnum("6922")]
        Item6922,


        [XmlEnum("6923")]
        Item6923,


        [XmlEnum("6924")]
        Item6924,


        [XmlEnum("6925")]
        Item6925,


        [XmlEnum("6929")]
        Item6929,


        [XmlEnum("6931")]
        Item6931,


        [XmlEnum("6932")]
        Item6932,


        [XmlEnum("6933")]
        Item6933,


        [XmlEnum("6934")]
        Item6934,


        [XmlEnum("6949")]
        Item6949,


        [XmlEnum("7101")]
        Item7101,


        [XmlEnum("7102")]
        Item7102,


        [XmlEnum("7105")]
        Item7105,


        [XmlEnum("7106")]
        Item7106,


        [XmlEnum("7127")]
        Item7127,


        [XmlEnum("7201")]
        Item7201,


        [XmlEnum("7202")]
        Item7202,


        [XmlEnum("7205")]
        Item7205,


        [XmlEnum("7206")]
        Item7206,


        [XmlEnum("7207")]
        Item7207,


        [XmlEnum("7210")]
        Item7210,


        [XmlEnum("7211")]
        Item7211,


        [XmlEnum("7251")]
        Item7251,


        [XmlEnum("7501")]
        Item7501,


        [XmlEnum("7551")]
        Item7551,


        [XmlEnum("7553")]
        Item7553,


        [XmlEnum("7556")]
        Item7556,


        [XmlEnum("7651")]
        Item7651,


        [XmlEnum("7654")]
        Item7654,


        [XmlEnum("7667")]
        Item7667,


        [XmlEnum("7930")]
        Item7930,


        [XmlEnum("7949")]
        Item7949,
    }


   
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = Namespaces.NFe)]
    public enum TNFeInfNFeDetProdIndTot
    {


        [XmlEnum("0")]
        Item0,


        [XmlEnum("1")]
        Item1,
    }


   
    [Serializable]


    [XmlType(AnonymousType = true, Namespace = Namespaces.NFe)]
    public class TNFeInfNFeDetProdDI
    {


        public string nDI { get; set; }


        public string dDI { get; set; }


        public string xLocDesemb { get; set; }


        public TUfEmi UFDesemb { get; set; }


        public string dDesemb { get; set; }


        public string cExportador { get; set; }


        [XmlElement("adi")]
        public TNFeInfNFeDetProdDIAdi[] adi { get; set; }
    }


   
    [Serializable]


    [XmlType(AnonymousType = true, Namespace = Namespaces.NFe)]
    public class TNFeInfNFeDetProdDIAdi
    {


        public string nAdicao { get; set; }


        public string nSeqAdic { get; set; }


        public string cFabricante { get; set; }


        public string vDescDI { get; set; }
    }


   
    [Serializable]


    [XmlType(AnonymousType = true, Namespace = Namespaces.NFe)]
    public class TNFeInfNFeDetProdArma
    {


        public TNFeInfNFeDetProdArmaTpArma tpArma { get; set; }


        public string nSerie { get; set; }


        public string nCano { get; set; }


        public string descr { get; set; }
    }


   
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = Namespaces.NFe)]
    public enum TNFeInfNFeDetProdArmaTpArma
    {


        [XmlEnum("0")]
        Item0,


        [XmlEnum("1")]
        Item1,
    }


   
    [Serializable]


    [XmlType(AnonymousType = true, Namespace = Namespaces.NFe)]
    public class TNFeInfNFeDetProdComb
    {


        public TcProdANP cProdANP { get; set; }


        public string CODIF { get; set; }


        public string qTemp { get; set; }


        public TUf UFCons { get; set; }


        public TNFeInfNFeDetProdCombCIDE CIDE { get; set; }
    }


   
    [Serializable]
    [XmlType(Namespace = Namespaces.NFe)]
    public enum TcProdANP
    {


        [XmlEnum("110203073")]
        Item110203073,


        [XmlEnum("110204001")]
        Item110204001,


        [XmlEnum("110204002")]
        Item110204002,


        [XmlEnum("140101027")]
        Item140101027,


        [XmlEnum("140101026")]
        Item140101026,


        [XmlEnum("740101005")]
        Item740101005,


        [XmlEnum("740101004")]
        Item740101004,


        [XmlEnum("740101001")]
        Item740101001,


        [XmlEnum("740101006")]
        Item740101006,


        [XmlEnum("740101002")]
        Item740101002,


        [XmlEnum("110203083")]
        Item110203083,


        [XmlEnum("910101001")]
        Item910101001,


        [XmlEnum("110103001")]
        Item110103001,


        [XmlEnum("330101001")]
        Item330101001,


        [XmlEnum("110203091")]
        Item110203091,


        [XmlEnum("120204001")]
        Item120204001,


        [XmlEnum("110106001")]
        Item110106001,


        [XmlEnum("120206001")]
        Item120206001,


        [XmlEnum("110101001")]
        Item110101001,


        [XmlEnum("110101042")]
        Item110101042,


        [XmlEnum("810201001")]
        Item810201001,


        [XmlEnum("110204003")]
        Item110204003,


        [XmlEnum("330201005")]
        Item330201005,


        [XmlEnum("330201006")]
        Item330201006,


        [XmlEnum("330201004")]
        Item330201004,


        [XmlEnum("110105001")]
        Item110105001,


        [XmlEnum("110203072")]
        Item110203072,


        [XmlEnum("110203001")]
        Item110203001,


        [XmlEnum("110201001")]
        Item110201001,


        [XmlEnum("110101002")]
        Item110101002,


        [XmlEnum("110203002")]
        Item110203002,


        [XmlEnum("120205010")]
        Item120205010,


        [XmlEnum("110203003")]
        Item110203003,


        [XmlEnum("110204004")]
        Item110204004,


        [XmlEnum("110204005")]
        Item110204005,


        [XmlEnum("110204006")]
        Item110204006,


        [XmlEnum("110204007")]
        Item110204007,


        [XmlEnum("110204008")]
        Item110204008,


        [XmlEnum("110204009")]
        Item110204009,


        [XmlEnum("110204010")]
        Item110204010,


        [XmlEnum("110204011")]
        Item110204011,


        [XmlEnum("110105027")]
        Item110105027,


        [XmlEnum("110103003")]
        Item110103003,


        [XmlEnum("110103002")]
        Item110103002,


        [XmlEnum("110105002")]
        Item110105002,


        [XmlEnum("110205001")]
        Item110205001,


        [XmlEnum("120203002")]
        Item120203002,


        [XmlEnum("120205001")]
        Item120205001,


        [XmlEnum("110203004")]
        Item110203004,


        [XmlEnum("120203001")]
        Item120203001,


        [XmlEnum("530102001")]
        Item530102001,


        [XmlEnum("530101002")]
        Item530101002,


        [XmlEnum("110108001")]
        Item110108001,


        [XmlEnum("110105017")]
        Item110105017,


        [XmlEnum("110206019")]
        Item110206019,


        [XmlEnum("110205023")]
        Item110205023,


        [XmlEnum("110203092")]
        Item110203092,


        [XmlEnum("110201002")]
        Item110201002,


        [XmlEnum("120202001")]
        Item120202001,


        [XmlEnum("110101003")]
        Item110101003,


        [XmlEnum("110101004")]
        Item110101004,


        [XmlEnum("110103004")]
        Item110103004,


        [XmlEnum("110103005")]
        Item110103005,


        [XmlEnum("110101005")]
        Item110101005,


        [XmlEnum("110204012")]
        Item110204012,


        [XmlEnum("110204013")]
        Item110204013,


        [XmlEnum("110204014")]
        Item110204014,


        [XmlEnum("110102001")]
        Item110102001,


        [XmlEnum("120207003")]
        Item120207003,


        [XmlEnum("110201003")]
        Item110201003,


        [XmlEnum("110201004")]
        Item110201004,


        [XmlEnum("110201005")]
        Item110201005,


        [XmlEnum("110201006")]
        Item110201006,


        [XmlEnum("110206001")]
        Item110206001,


        [XmlEnum("110205002")]
        Item110205002,


        [XmlEnum("110203005")]
        Item110203005,


        [XmlEnum("110205003")]
        Item110205003,


        [XmlEnum("330201001")]
        Item330201001,


        [XmlEnum("110206002")]
        Item110206002,


        [XmlEnum("110101006")]
        Item110101006,


        [XmlEnum("110101007")]
        Item110101007,


        [XmlEnum("110101038")]
        Item110101038,


        [XmlEnum("120205002")]
        Item120205002,


        [XmlEnum("820101001")]
        Item820101001,


        [XmlEnum("820101010")]
        Item820101010,


        [XmlEnum("820101999")]
        Item820101999,


        [XmlEnum("110206003")]
        Item110206003,


        [XmlEnum("110201007")]
        Item110201007,


        [XmlEnum("120201001")]
        Item120201001,


        [XmlEnum("110201008")]
        Item110201008,


        [XmlEnum("110103017")]
        Item110103017,


        [XmlEnum("110205004")]
        Item110205004,


        [XmlEnum("110203077")]
        Item110203077,


        [XmlEnum("110101008")]
        Item110101008,


        [XmlEnum("110203006")]
        Item110203006,


        [XmlEnum("110203007")]
        Item110203007,


        [XmlEnum("110201009")]
        Item110201009,


        [XmlEnum("110203008")]
        Item110203008,


        [XmlEnum("110203009")]
        Item110203009,


        [XmlEnum("110203010")]
        Item110203010,


        [XmlEnum("120203004")]
        Item120203004,


        [XmlEnum("110206004")]
        Item110206004,


        [XmlEnum("610101009")]
        Item610101009,


        [XmlEnum("120205003")]
        Item120205003,


        [XmlEnum("110205005")]
        Item110205005,


        [XmlEnum("110203092")]
        Item1102030921,


        [XmlEnum("110204015")]
        Item110204015,


        [XmlEnum("210202003")]
        Item210202003,


        [XmlEnum("210202001")]
        Item210202001,


        [XmlEnum("210202002")]
        Item210202002,


        [XmlEnum("110105018")]
        Item110105018,


        [XmlEnum("110203011")]
        Item110203011,


        [XmlEnum("110203012")]
        Item110203012,


        [XmlEnum("110101009")]
        Item110101009,


        [XmlEnum("110104001")]
        Item110104001,


        [XmlEnum("110104006")]
        Item110104006,


        [XmlEnum("110106010")]
        Item110106010,


        [XmlEnum("110202007")]
        Item110202007,


        [XmlEnum("110106002")]
        Item110106002,


        [XmlEnum("110111002")]
        Item110111002,


        [XmlEnum("110103006")]
        Item110103006,


        [XmlEnum("110105003")]
        Item110105003,


        [XmlEnum("110201010")]
        Item110201010,


        [XmlEnum("110201011")]
        Item110201011,


        [XmlEnum("110201012")]
        Item110201012,


        [XmlEnum("110101010")]
        Item110101010,


        [XmlEnum("110101011")]
        Item110101011,


        [XmlEnum("110108002")]
        Item110108002,


        [XmlEnum("110107001")]
        Item110107001,


        [XmlEnum("120202002")]
        Item120202002,


        [XmlEnum("110106003")]
        Item110106003,


        [XmlEnum("110108003")]
        Item110108003,


        [XmlEnum("110203085")]
        Item110203085,


        [XmlEnum("110201013")]
        Item110201013,


        [XmlEnum("110207001")]
        Item110207001,


        [XmlEnum("110105023")]
        Item110105023,


        [XmlEnum("110101012")]
        Item110101012,


        [XmlEnum("110201014")]
        Item110201014,


        [XmlEnum("620501002")]
        Item620501002,


        [XmlEnum("620501001")]
        Item620501001,


        [XmlEnum("610101005")]
        Item610101005,


        [XmlEnum("610101006")]
        Item610101006,


        [XmlEnum("530101001")]
        Item530101001,


        [XmlEnum("530101020")]
        Item530101020,


        [XmlEnum("530101018")]
        Item530101018,


        [XmlEnum("110205006")]
        Item110205006,


        [XmlEnum("110201015")]
        Item110201015,


        [XmlEnum("110203013")]
        Item110203013,


        [XmlEnum("110202001")]
        Item110202001,


        [XmlEnum("120104001")]
        Item120104001,


        [XmlEnum("120102001")]
        Item120102001,


        [XmlEnum("110205024")]
        Item110205024,


        [XmlEnum("120205009")]
        Item120205009,


        [XmlEnum("540101002")]
        Item540101002,


        [XmlEnum("540101001")]
        Item540101001,


        [XmlEnum("110107002")]
        Item110107002,


        [XmlEnum("620601003")]
        Item620601003,


        [XmlEnum("110201016")]
        Item110201016,


        [XmlEnum("110101013")]
        Item110101013,


        [XmlEnum("120207001")]
        Item120207001,


        [XmlEnum("110206020")]
        Item110206020,


        [XmlEnum("110104008")]
        Item110104008,


        [XmlEnum("110201017")]
        Item110201017,


        [XmlEnum("110108004")]
        Item110108004,


        [XmlEnum("110201018")]
        Item110201018,


        [XmlEnum("330201007")]
        Item330201007,


        [XmlEnum("110205007")]
        Item110205007,


        [XmlEnum("110203086")]
        Item110203086,


        [XmlEnum("110205008")]
        Item110205008,


        [XmlEnum("340101002")]
        Item340101002,


        [XmlEnum("130202002")]
        Item130202002,


        [XmlEnum("430101002")]
        Item430101002,


        [XmlEnum("130202003")]
        Item130202003,


        [XmlEnum("560101002")]
        Item560101002,


        [XmlEnum("130202004")]
        Item130202004,


        [XmlEnum("820101026")]
        Item820101026,


        [XmlEnum("820101032")]
        Item820101032,


        [XmlEnum("820101027")]
        Item820101027,


        [XmlEnum("820101004")]
        Item820101004,


        [XmlEnum("820101005")]
        Item820101005,


        [XmlEnum("820101022")]
        Item820101022,


        [XmlEnum("820101007")]
        Item820101007,


        [XmlEnum("820101002")]
        Item820101002,


        [XmlEnum("820101009")]
        Item820101009,


        [XmlEnum("820101008")]
        Item820101008,


        [XmlEnum("820101014")]
        Item820101014,


        [XmlEnum("820101006")]
        Item820101006,


        [XmlEnum("820101016")]
        Item820101016,


        [XmlEnum("820101015")]
        Item820101015,


        [XmlEnum("820101014")]
        Item8201010141,


        [XmlEnum("820101006")]
        Item8201010061,


        [XmlEnum("820101031")]
        Item820101031,


        [XmlEnum("820101030")]
        Item820101030,


        [XmlEnum("820101016")]
        Item8201010161,


        [XmlEnum("820101015")]
        Item8201010151,


        [XmlEnum("820101025")]
        Item820101025,


        [XmlEnum("820101007")]
        Item8201010071,


        [XmlEnum("820101002")]
        Item8201010021,


        [XmlEnum("820101026")]
        Item8201010261,


        [XmlEnum("820101009")]
        Item8201010091,


        [XmlEnum("820101008")]
        Item8201010081,


        [XmlEnum("820101027")]
        Item8201010271,


        [XmlEnum("820101007")]
        Item8201010072,


        [XmlEnum("820101002")]
        Item8201010022,


        [XmlEnum("820101028")]
        Item820101028,


        [XmlEnum("820101029")]
        Item820101029,


        [XmlEnum("820101009")]
        Item8201010092,


        [XmlEnum("820101008")]
        Item8201010082,


        [XmlEnum("820101011")]
        Item820101011,


        [XmlEnum("820101003")]
        Item820101003,


        [XmlEnum("820101013")]
        Item820101013,


        [XmlEnum("820101012")]
        Item820101012,


        [XmlEnum("820101017")]
        Item820101017,


        [XmlEnum("820101018")]
        Item820101018,


        [XmlEnum("820101019")]
        Item820101019,


        [XmlEnum("820101020")]
        Item820101020,


        [XmlEnum("820101021")]
        Item820101021,


        [XmlEnum("330101003")]
        Item330101003,


        [XmlEnum("130202006")]
        Item130202006,


        [XmlEnum("110203014")]
        Item110203014,


        [XmlEnum("420201001")]
        Item420201001,


        [XmlEnum("420201003")]
        Item420201003,


        [XmlEnum("120204010")]
        Item120204010,


        [XmlEnum("110103007")]
        Item110103007,


        [XmlEnum("110204017")]
        Item110204017,


        [XmlEnum("110204051")]
        Item110204051,


        [XmlEnum("110204018")]
        Item110204018,


        [XmlEnum("110205022")]
        Item110205022,


        [XmlEnum("110203069")]
        Item110203069,


        [XmlEnum("110203015")]
        Item110203015,


        [XmlEnum("110206005")]
        Item110206005,


        [XmlEnum("110203016")]
        Item110203016,


        [XmlEnum("110203017")]
        Item110203017,


        [XmlEnum("110203018")]
        Item110203018,


        [XmlEnum("110203088")]
        Item110203088,


        [XmlEnum("110203019")]
        Item110203019,


        [XmlEnum("530101003")]
        Item530101003,


        [XmlEnum("530101019")]
        Item530101019,


        [XmlEnum("110101014")]
        Item110101014,


        [XmlEnum("620101002")]
        Item620101002,


        [XmlEnum("720101001")]
        Item720101001,


        [XmlEnum("720101002")]
        Item720101002,


        [XmlEnum("120205004")]
        Item120205004,


        [XmlEnum("110203079")]
        Item110203079,


        [XmlEnum("110203020")]
        Item110203020,


        [XmlEnum("110201019")]
        Item110201019,


        [XmlEnum("110203021")]
        Item110203021,


        [XmlEnum("110108005")]
        Item110108005,


        [XmlEnum("110101015")]
        Item110101015,


        [XmlEnum("110104002")]
        Item110104002,


        [XmlEnum("110101016")]
        Item110101016,


        [XmlEnum("620101007")]
        Item620101007,


        [XmlEnum("140102001")]
        Item140102001,


        [XmlEnum("110105004")]
        Item110105004,


        [XmlEnum("110107003")]
        Item110107003,


        [XmlEnum("110203095")]
        Item110203095,


        [XmlEnum("210301001")]
        Item210301001,


        [XmlEnum("810102001")]
        Item810102001,


        [XmlEnum("810102004")]
        Item810102004,


        [XmlEnum("810102002")]
        Item810102002,


        [XmlEnum("130201002")]
        Item130201002,


        [XmlEnum("810102003")]
        Item810102003,


        [XmlEnum("810101002")]
        Item810101002,


        [XmlEnum("810101001")]
        Item810101001,


        [XmlEnum("810101003")]
        Item810101003,


        [XmlEnum("210301002")]
        Item210301002,


        [XmlEnum("330201010")]
        Item330201010,


        [XmlEnum("110204016")]
        Item110204016,


        [XmlEnum("110105005")]
        Item110105005,


        [XmlEnum("110105006")]
        Item110105006,


        [XmlEnum("110105007")]
        Item110105007,


        [XmlEnum("110104003")]
        Item110104003,


        [XmlEnum("110206006")]
        Item110206006,


        [XmlEnum("110206007")]
        Item110206007,


        [XmlEnum("110203022")]
        Item110203022,


        [XmlEnum("110204019")]
        Item110204019,


        [XmlEnum("110206008")]
        Item110206008,


        [XmlEnum("110206009")]
        Item110206009,


        [XmlEnum("110101043")]
        Item110101043,


        [XmlEnum("110201020")]
        Item110201020,


        [XmlEnum("110203023")]
        Item110203023,


        [XmlEnum("110101017")]
        Item110101017,


        [XmlEnum("110101018")]
        Item110101018,


        [XmlEnum("210302004")]
        Item210302004,


        [XmlEnum("210101001")]
        Item210101001,


        [XmlEnum("210302003")]
        Item210302003,


        [XmlEnum("210302002")]
        Item210302002,


        [XmlEnum("210204001")]
        Item210204001,


        [XmlEnum("220101003")]
        Item220101003,


        [XmlEnum("220101004")]
        Item220101004,


        [XmlEnum("220101002")]
        Item220101002,


        [XmlEnum("220101001")]
        Item220101001,


        [XmlEnum("220101005")]
        Item220101005,


        [XmlEnum("220101006")]
        Item220101006,


        [XmlEnum("130202001")]
        Item130202001,


        [XmlEnum("130202005")]
        Item130202005,


        [XmlEnum("520101001")]
        Item520101001,


        [XmlEnum("320101001")]
        Item320101001,


        [XmlEnum("320101003")]
        Item320101003,


        [XmlEnum("320101002")]
        Item320101002,


        [XmlEnum("320103001")]
        Item320103001,


        [XmlEnum("320102002")]
        Item320102002,


        [XmlEnum("320102001")]
        Item320102001,


        [XmlEnum("320102004")]
        Item320102004,


        [XmlEnum("320102003")]
        Item320102003,


        [XmlEnum("320201001")]
        Item320201001,


        [XmlEnum("320201002")]
        Item320201002,


        [XmlEnum("220102001")]
        Item220102001,


        [XmlEnum("320301002")]
        Item320301002,


        [XmlEnum("110204020")]
        Item110204020,


        [XmlEnum("110203024")]
        Item110203024,


        [XmlEnum("120205012")]
        Item120205012,


        [XmlEnum("110207002")]
        Item110207002,


        [XmlEnum("110203087")]
        Item110203087,


        [XmlEnum("730101002")]
        Item730101002,


        [XmlEnum("210203001")]
        Item210203001,


        [XmlEnum("210203002")]
        Item210203002,


        [XmlEnum("110104005")]
        Item110104005,


        [XmlEnum("140101023")]
        Item140101023,


        [XmlEnum("140101024")]
        Item140101024,


        [XmlEnum("140101025")]
        Item140101025,


        [XmlEnum("650101001")]
        Item650101001,


        [XmlEnum("110207003")]
        Item110207003,


        [XmlEnum("110201021")]
        Item110201021,


        [XmlEnum("110103013")]
        Item110103013,


        [XmlEnum("110201022")]
        Item110201022,


        [XmlEnum("110203025")]
        Item110203025,


        [XmlEnum("110203026")]
        Item110203026,


        [XmlEnum("110206011")]
        Item110206011,


        [XmlEnum("110206010")]
        Item110206010,


        [XmlEnum("110203027")]
        Item110203027,


        [XmlEnum("110203028")]
        Item110203028,


        [XmlEnum("110203028")]
        Item1102030281,


        [XmlEnum("330101008")]
        Item330101008,


        [XmlEnum("330101002")]
        Item330101002,


        [XmlEnum("330101009")]
        Item330101009,


        [XmlEnum("620101001")]
        Item620101001,


        [XmlEnum("610201001")]
        Item610201001,


        [XmlEnum("610201002")]
        Item610201002,


        [XmlEnum("610201003")]
        Item610201003,


        [XmlEnum("710101001")]
        Item710101001,


        [XmlEnum("110203074")]
        Item110203074,


        [XmlEnum("110201023")]
        Item110201023,


        [XmlEnum("110103008")]
        Item110103008,


        [XmlEnum("110203029")]
        Item110203029,


        [XmlEnum("120205005")]
        Item120205005,


        [XmlEnum("110204021")]
        Item110204021,


        [XmlEnum("110204022")]
        Item110204022,


        [XmlEnum("110204023")]
        Item110204023,


        [XmlEnum("620101004")]
        Item620101004,


        [XmlEnum("620101005")]
        Item620101005,


        [XmlEnum("330101010")]
        Item330101010,


        [XmlEnum("110202002")]
        Item110202002,


        [XmlEnum("110202003")]
        Item110202003,


        [XmlEnum("110207004")]
        Item110207004,


        [XmlEnum("110101046")]
        Item110101046,


        [XmlEnum("110204024")]
        Item110204024,


        [XmlEnum("110113001")]
        Item110113001,


        [XmlEnum("110105015")]
        Item110105015,


        [XmlEnum("110101019")]
        Item110101019,


        [XmlEnum("110103015")]
        Item110103015,


        [XmlEnum("110205025")]
        Item110205025,


        [XmlEnum("110204025")]
        Item110204025,


        [XmlEnum("110204026")]
        Item110204026,


        [XmlEnum("110204027")]
        Item110204027,


        [XmlEnum("120204009")]
        Item120204009,


        [XmlEnum("110205026")]
        Item110205026,


        [XmlEnum("110204028")]
        Item110204028,


        [XmlEnum("110204029")]
        Item110204029,


        [XmlEnum("110203080")]
        Item110203080,


        [XmlEnum("120207004")]
        Item120207004,


        [XmlEnum("110203030")]
        Item110203030,


        [XmlEnum("110105025")]
        Item110105025,


        [XmlEnum("110203031")]
        Item110203031,


        [XmlEnum("110203084")]
        Item110203084,


        [XmlEnum("110203032")]
        Item110203032,


        [XmlEnum("110204030")]
        Item110204030,


        [XmlEnum("110205009")]
        Item110205009,


        [XmlEnum("110104004")]
        Item110104004,


        [XmlEnum("110201024")]
        Item110201024,


        [XmlEnum("110201025")]
        Item110201025,


        [XmlEnum("110201026")]
        Item110201026,


        [XmlEnum("110201027")]
        Item110201027,


        [XmlEnum("110201028")]
        Item110201028,


        [XmlEnum("110201029")]
        Item110201029,


        [XmlEnum("110201030")]
        Item110201030,


        [XmlEnum("110207005")]
        Item110207005,


        [XmlEnum("110204031")]
        Item110204031,


        [XmlEnum("110207006")]
        Item110207006,


        [XmlEnum("110201031")]
        Item110201031,


        [XmlEnum("110201032")]
        Item110201032,


        [XmlEnum("110201033")]
        Item110201033,


        [XmlEnum("120204002")]
        Item120204002,


        [XmlEnum("110101020")]
        Item110101020,


        [XmlEnum("220102002")]
        Item220102002,


        [XmlEnum("110105008")]
        Item110105008,


        [XmlEnum("110203033")]
        Item110203033,


        [XmlEnum("110105009")]
        Item110105009,


        [XmlEnum("110201034")]
        Item110201034,


        [XmlEnum("110203034")]
        Item110203034,


        [XmlEnum("110203035")]
        Item110203035,


        [XmlEnum("640201001")]
        Item640201001,


        [XmlEnum("120205011")]
        Item120205011,


        [XmlEnum("110101021")]
        Item110101021,


        [XmlEnum("120103001")]
        Item120103001,


        [XmlEnum("110203036")]
        Item110203036,


        [XmlEnum("120204003")]
        Item120204003,


        [XmlEnum("110201035")]
        Item110201035,


        [XmlEnum("110204032")]
        Item110204032,


        [XmlEnum("110101022")]
        Item110101022,


        [XmlEnum("110201036")]
        Item110201036,


        [XmlEnum("110101023")]
        Item110101023,


        [XmlEnum("110101024")]
        Item110101024,


        [XmlEnum("110101025")]
        Item110101025,


        [XmlEnum("110101039")]
        Item110101039,


        [XmlEnum("110204033")]
        Item110204033,


        [XmlEnum("120207002")]
        Item120207002,


        [XmlEnum("110202004")]
        Item110202004,


        [XmlEnum("110202005")]
        Item110202005,


        [XmlEnum("110203037")]
        Item110203037,


        [XmlEnum("110203037")]
        Item1102030371,


        [XmlEnum("110201037")]
        Item110201037,


        [XmlEnum("110203078")]
        Item110203078,


        [XmlEnum("120203005")]
        Item120203005,


        [XmlEnum("120204010")]
        Item1202040101,


        [XmlEnum("110201038")]
        Item110201038,


        [XmlEnum("110201039")]
        Item110201039,


        [XmlEnum("120101001")]
        Item120101001,


        [XmlEnum("110201040")]
        Item110201040,


        [XmlEnum("110201041")]
        Item110201041,


        [XmlEnum("740101007")]
        Item740101007,


        [XmlEnum("420201003")]
        Item4202010031,


        [XmlEnum("640101001")]
        Item640101001,


        [XmlEnum("110205027")]
        Item110205027,


        [XmlEnum("110103009")]
        Item110103009,


        [XmlEnum("110103010")]
        Item110103010,


        [XmlEnum("110205010")]
        Item110205010,


        [XmlEnum("820101018")]
        Item8201010181,


        [XmlEnum("820101017")]
        Item8201010171,


        [XmlEnum("820101006")]
        Item8201010062,


        [XmlEnum("820101014")]
        Item8201010142,


        [XmlEnum("820101006")]
        Item8201010063,


        [XmlEnum("820101016")]
        Item8201010162,


        [XmlEnum("820101015")]
        Item8201010152,


        [XmlEnum("820101006")]
        Item8201010064,


        [XmlEnum("820101005")]
        Item8201010051,


        [XmlEnum("820101004")]
        Item8201010041,


        [XmlEnum("820101003")]
        Item8201010031,


        [XmlEnum("820101011")]
        Item8201010111,


        [XmlEnum("820101003")]
        Item8201010032,


        [XmlEnum("820101013")]
        Item8201010131,


        [XmlEnum("820101012")]
        Item8201010121,


        [XmlEnum("820101002")]
        Item8201010023,


        [XmlEnum("820101007")]
        Item8201010073,


        [XmlEnum("820101002")]
        Item8201010024,


        [XmlEnum("820101009")]
        Item8201010093,


        [XmlEnum("820101008")]
        Item8201010083,


        [XmlEnum("110301001")]
        Item110301001,


        [XmlEnum("110208001")]
        Item110208001,


        [XmlEnum("110203038")]
        Item110203038,


        [XmlEnum("110203089")]
        Item110203089,


        [XmlEnum("110201042")]
        Item110201042,


        [XmlEnum("110101026")]
        Item110101026,


        [XmlEnum("620502001")]
        Item620502001,


        [XmlEnum("110203039")]
        Item110203039,


        [XmlEnum("110202008")]
        Item110202008,


        [XmlEnum("110204034")]
        Item110204034,


        [XmlEnum("110110001")]
        Item110110001,


        [XmlEnum("310102001")]
        Item310102001,


        [XmlEnum("310103001")]
        Item310103001,


        [XmlEnum("310101001")]
        Item310101001,


        [XmlEnum("110101027")]
        Item110101027,


        [XmlEnum("110205011")]
        Item110205011,


        [XmlEnum("110201062")]
        Item110201062,


        [XmlEnum("110203040")]
        Item110203040,


        [XmlEnum("610101002")]
        Item610101002,


        [XmlEnum("610401002")]
        Item610401002,


        [XmlEnum("610101003")]
        Item610101003,


        [XmlEnum("610401003")]
        Item610401003,


        [XmlEnum("610101004")]
        Item610101004,


        [XmlEnum("610401004")]
        Item610401004,


        [XmlEnum("110203041")]
        Item110203041,


        [XmlEnum("110203042")]
        Item110203042,


        [XmlEnum("110203043")]
        Item110203043,


        [XmlEnum("110203094")]
        Item110203094,


        [XmlEnum("110203044")]
        Item110203044,


        [XmlEnum("110203044")]
        Item1102030441,


        [XmlEnum("430101001")]
        Item430101001,


        [XmlEnum("110206021")]
        Item110206021,


        [XmlEnum("120204004")]
        Item120204004,


        [XmlEnum("110207007")]
        Item110207007,


        [XmlEnum("110203045")]
        Item110203045,


        [XmlEnum("110201043")]
        Item110201043,


        [XmlEnum("110203046")]
        Item110203046,


        [XmlEnum("110203047")]
        Item110203047,


        [XmlEnum("110203048")]
        Item110203048,


        [XmlEnum("110203081")]
        Item110203081,


        [XmlEnum("430101004")]
        Item430101004,


        [XmlEnum("510101003")]
        Item510101003,


        [XmlEnum("510101001")]
        Item510101001,


        [XmlEnum("510101002")]
        Item510101002,


        [XmlEnum("510102003")]
        Item510102003,


        [XmlEnum("510102001")]
        Item510102001,


        [XmlEnum("510102002")]
        Item510102002,


        [XmlEnum("510201001")]
        Item510201001,


        [XmlEnum("510201002")]
        Item510201002,


        [XmlEnum("510201003")]
        Item510201003,


        [XmlEnum("510301003")]
        Item510301003,


        [XmlEnum("140101015")]
        Item140101015,


        [XmlEnum("140101009")]
        Item140101009,


        [XmlEnum("140101016")]
        Item140101016,


        [XmlEnum("140101017")]
        Item140101017,


        [XmlEnum("140101005")]
        Item140101005,


        [XmlEnum("140101014")]
        Item140101014,


        [XmlEnum("140101018")]
        Item140101018,


        [XmlEnum("140101006")]
        Item140101006,


        [XmlEnum("140101028")]
        Item140101028,


        [XmlEnum("140101021")]
        Item140101021,


        [XmlEnum("140101010")]
        Item140101010,


        [XmlEnum("140101012")]
        Item140101012,


        [XmlEnum("140101013")]
        Item140101013,


        [XmlEnum("140101001")]
        Item140101001,


        [XmlEnum("140101011")]
        Item140101011,


        [XmlEnum("140101003")]
        Item140101003,


        [XmlEnum("140101002")]
        Item140101002,


        [XmlEnum("140101008")]
        Item140101008,


        [XmlEnum("140101007")]
        Item140101007,


        [XmlEnum("140101019")]
        Item140101019,


        [XmlEnum("140101004")]
        Item140101004,


        [XmlEnum("560101001")]
        Item560101001,


        [XmlEnum("420105001")]
        Item420105001,


        [XmlEnum("420101005")]
        Item420101005,


        [XmlEnum("420101004")]
        Item420101004,


        [XmlEnum("420101003")]
        Item420101003,


        [XmlEnum("420102006")]
        Item420102006,


        [XmlEnum("420102005")]
        Item420102005,


        [XmlEnum("420102004")]
        Item420102004,


        [XmlEnum("420102003")]
        Item420102003,


        [XmlEnum("420104001")]
        Item420104001,


        [XmlEnum("820101033")]
        Item820101033,


        [XmlEnum("820101034")]
        Item820101034,


        [XmlEnum("820101011")]
        Item8201010112,


        [XmlEnum("820101003")]
        Item8201010033,


        [XmlEnum("820101028")]
        Item8201010281,


        [XmlEnum("820101029")]
        Item8201010291,


        [XmlEnum("820101013")]
        Item8201010132,


        [XmlEnum("820101012")]
        Item8201010122,


        [XmlEnum("420301003")]
        Item420301003,


        [XmlEnum("420101005")]
        Item4201010051,


        [XmlEnum("420101002")]
        Item420101002,


        [XmlEnum("420101001")]
        Item420101001,


        [XmlEnum("420101003")]
        Item4201010031,


        [XmlEnum("420101004")]
        Item4201010041,


        [XmlEnum("420101003")]
        Item4201010032,


        [XmlEnum("420201001")]
        Item4202010011,


        [XmlEnum("420201002")]
        Item420201002,


        [XmlEnum("420102005")]
        Item4201020051,


        [XmlEnum("420102004")]
        Item4201020041,


        [XmlEnum("420102002")]
        Item420102002,


        [XmlEnum("420102001")]
        Item420102001,


        [XmlEnum("420102003")]
        Item4201020031,


        [XmlEnum("420102003")]
        Item4201020032,


        [XmlEnum("420202001")]
        Item420202001,


        [XmlEnum("420301001")]
        Item420301001,


        [XmlEnum("420102006")]
        Item4201020061,


        [XmlEnum("420103002")]
        Item420103002,


        [XmlEnum("420103001")]
        Item420103001,


        [XmlEnum("420103003")]
        Item420103003,


        [XmlEnum("610601001")]
        Item610601001,


        [XmlEnum("610701001")]
        Item610701001,


        [XmlEnum("510301002")]
        Item510301002,


        [XmlEnum("620601001")]
        Item620601001,


        [XmlEnum("660101001")]
        Item660101001,


        [XmlEnum("620401001")]
        Item620401001,


        [XmlEnum("620301001")]
        Item620301001,


        [XmlEnum("620201001")]
        Item620201001,


        [XmlEnum("630101001")]
        Item630101001,


        [XmlEnum("110202006")]
        Item110202006,


        [XmlEnum("110203093")]
        Item110203093,


        [XmlEnum("110204035")]
        Item110204035,


        [XmlEnum("110203049")]
        Item110203049,


        [XmlEnum("110201044")]
        Item110201044,


        [XmlEnum("110201045")]
        Item110201045,


        [XmlEnum("110206012")]
        Item110206012,


        [XmlEnum("120203003")]
        Item120203003,


        [XmlEnum("320301001")]
        Item320301001,


        [XmlEnum("320103002")]
        Item320103002,


        [XmlEnum("650101002")]
        Item650101002,


        [XmlEnum("310102002")]
        Item310102002,


        [XmlEnum("640401001")]
        Item640401001,


        [XmlEnum("140101029")]
        Item140101029,


        [XmlEnum("740101003")]
        Item740101003,


        [XmlEnum("810201002")]
        Item810201002,


        [XmlEnum("530103001")]
        Item530103001,


        [XmlEnum("340101003")]
        Item340101003,


        [XmlEnum("430101003")]
        Item430101003,


        [XmlEnum("560101003")]
        Item560101003,


        [XmlEnum("210302001")]
        Item210302001,


        [XmlEnum("210204002")]
        Item210204002,


        [XmlEnum("130201001")]
        Item130201001,


        [XmlEnum("530104001")]
        Item530104001,


        [XmlEnum("140101022")]
        Item140101022,


        [XmlEnum("140101999")]
        Item140101999,


        [XmlEnum("610201004")]
        Item610201004,


        [XmlEnum("510301001")]
        Item510301001,


        [XmlEnum("420301002")]
        Item420301002,


        [XmlEnum("620601004")]
        Item620601004,


        [XmlEnum("620505001")]
        Item620505001,


        [XmlEnum("610501001")]
        Item610501001,


        [XmlEnum("620101008")]
        Item620101008,


        [XmlEnum("610101010")]
        Item610101010,


        [XmlEnum("110208002")]
        Item110208002,


        [XmlEnum("110110002")]
        Item110110002,


        [XmlEnum("130202008")]
        Item130202008,


        [XmlEnum("410103001")]
        Item410103001,


        [XmlEnum("610301002")]
        Item610301002,


        [XmlEnum("610302001")]
        Item610302001,


        [XmlEnum("330101007")]
        Item330101007,


        [XmlEnum("330201009")]
        Item330201009,


        [XmlEnum("730101001")]
        Item730101001,


        [XmlEnum("110203050")]
        Item110203050,


        [XmlEnum("110101028")]
        Item110101028,


        [XmlEnum("110101049")]
        Item110101049,


        [XmlEnum("110101029")]
        Item110101029,


        [XmlEnum("110101030")]
        Item110101030,


        [XmlEnum("110104007")]
        Item110104007,


        [XmlEnum("110111001")]
        Item110111001,


        [XmlEnum("120205006")]
        Item120205006,


        [XmlEnum("110203051")]
        Item110203051,


        [XmlEnum("110101050")]
        Item110101050,


        [XmlEnum("110105028")]
        Item110105028,


        [XmlEnum("110105016")]
        Item110105016,


        [XmlEnum("110201046")]
        Item110201046,


        [XmlEnum("110106007")]
        Item110106007,


        [XmlEnum("110101031")]
        Item110101031,


        [XmlEnum("110203082")]
        Item110203082,


        [XmlEnum("610301001")]
        Item610301001,


        [XmlEnum("110101032")]
        Item110101032,


        [XmlEnum("110101047")]
        Item110101047,


        [XmlEnum("110105021")]
        Item110105021,


        [XmlEnum("110105010")]
        Item110105010,


        [XmlEnum("620101003")]
        Item620101003,


        [XmlEnum("210201001")]
        Item210201001,


        [XmlEnum("210201002")]
        Item210201002,


        [XmlEnum("210201003")]
        Item210201003,


        [XmlEnum("110105020")]
        Item110105020,


        [XmlEnum("110105022")]
        Item110105022,


        [XmlEnum("110205012")]
        Item110205012,


        [XmlEnum("620601002")]
        Item620601002,


        [XmlEnum("120206003")]
        Item120206003,


        [XmlEnum("110204036")]
        Item110204036,


        [XmlEnum("110204037")]
        Item110204037,


        [XmlEnum("110204038")]
        Item110204038,


        [XmlEnum("410101001")]
        Item410101001,


        [XmlEnum("410101002")]
        Item410101002,


        [XmlEnum("410102001")]
        Item410102001,


        [XmlEnum("410102002")]
        Item410102002,


        [XmlEnum("110103014")]
        Item110103014,


        [XmlEnum("110203052")]
        Item110203052,


        [XmlEnum("330101005")]
        Item330101005,


        [XmlEnum("330101006")]
        Item330101006,


        [XmlEnum("110205029")]
        Item110205029,


        [XmlEnum("110203053")]
        Item110203053,


        [XmlEnum("120204008")]
        Item120204008,


        [XmlEnum("110203054")]
        Item110203054,


        [XmlEnum("110204039")]
        Item110204039,


        [XmlEnum("110201047")]
        Item110201047,


        [XmlEnum("110201048")]
        Item110201048,


        [XmlEnum("110103011")]
        Item110103011,


        [XmlEnum("340101001")]
        Item340101001,


        [XmlEnum("550101001")]
        Item550101001,


        [XmlEnum("550101005")]
        Item550101005,


        [XmlEnum("550101002")]
        Item550101002,


        [XmlEnum("550101003")]
        Item550101003,


        [XmlEnum("550101004")]
        Item550101004,


        [XmlEnum("130202007")]
        Item130202007,


        [XmlEnum("110105011")]
        Item110105011,


        [XmlEnum("110201049")]
        Item110201049,


        [XmlEnum("110101048")]
        Item110101048,


        [XmlEnum("110101033")]
        Item110101033,


        [XmlEnum("110101040")]
        Item110101040,


        [XmlEnum("110101045")]
        Item110101045,


        [XmlEnum("110101041")]
        Item110101041,


        [XmlEnum("110204040")]
        Item110204040,


        [XmlEnum("110105019")]
        Item110105019,


        [XmlEnum("110204041")]
        Item110204041,


        [XmlEnum("110105024")]
        Item110105024,


        [XmlEnum("110203070")]
        Item110203070,


        [XmlEnum("110203055")]
        Item110203055,


        [XmlEnum("110204042")]
        Item110204042,


        [XmlEnum("110203075")]
        Item110203075,


        [XmlEnum("110201050")]
        Item110201050,


        [XmlEnum("110201051")]
        Item110201051,


        [XmlEnum("110201052")]
        Item110201052,


        [XmlEnum("110201053")]
        Item110201053,


        [XmlEnum("120201002")]
        Item120201002,


        [XmlEnum("110105029")]
        Item110105029,


        [XmlEnum("110203056")]
        Item110203056,


        [XmlEnum("110204043")]
        Item110204043,


        [XmlEnum("110203090")]
        Item110203090,


        [XmlEnum("140101020")]
        Item140101020,


        [XmlEnum("110103018")]
        Item110103018,


        [XmlEnum("110106004")]
        Item110106004,


        [XmlEnum("110106005")]
        Item110106005,


        [XmlEnum("110106006")]
        Item110106006,


        [XmlEnum("110205028")]
        Item110205028,


        [XmlEnum("110105012")]
        Item110105012,


        [XmlEnum("120204005")]
        Item120204005,


        [XmlEnum("110205013")]
        Item110205013,


        [XmlEnum("110201054")]
        Item110201054,


        [XmlEnum("110101044")]
        Item110101044,


        [XmlEnum("110204044")]
        Item110204044,


        [XmlEnum("110203057")]
        Item110203057,


        [XmlEnum("110203058")]
        Item110203058,


        [XmlEnum("120206002")]
        Item120206002,


        [XmlEnum("120206004")]
        Item120206004,


        [XmlEnum("330201008")]
        Item330201008,


        [XmlEnum("330101004")]
        Item330101004,


        [XmlEnum("110204045")]
        Item110204045,


        [XmlEnum("110204046")]
        Item110204046,


        [XmlEnum("110201063")]
        Item110201063,


        [XmlEnum("110206013")]
        Item110206013,


        [XmlEnum("110203059")]
        Item110203059,


        [XmlEnum("110203060")]
        Item110203060,


        [XmlEnum("610101001")]
        Item610101001,


        [XmlEnum("610401001")]
        Item610401001,


        [XmlEnum("110206015")]
        Item110206015,


        [XmlEnum("110206014")]
        Item110206014,


        [XmlEnum("110204052")]
        Item110204052,


        [XmlEnum("110205015")]
        Item110205015,


        [XmlEnum("110205014")]
        Item110205014,


        [XmlEnum("110204047")]
        Item110204047,


        [XmlEnum("110205016")]
        Item110205016,


        [XmlEnum("110203061")]
        Item110203061,


        [XmlEnum("110205017")]
        Item110205017,


        [XmlEnum("110106009")]
        Item110106009,


        [XmlEnum("110203062")]
        Item110203062,


        [XmlEnum("110206016")]
        Item110206016,


        [XmlEnum("120205007")]
        Item120205007,


        [XmlEnum("120201003")]
        Item120201003,


        [XmlEnum("620101006")]
        Item620101006,


        [XmlEnum("120205008")]
        Item120205008,


        [XmlEnum("120204006")]
        Item120204006,


        [XmlEnum("110201055")]
        Item110201055,


        [XmlEnum("110201056")]
        Item110201056,


        [XmlEnum("110201057")]
        Item110201057,


        [XmlEnum("110103016")]
        Item110103016,


        [XmlEnum("110205018")]
        Item110205018,


        [XmlEnum("110107005")]
        Item110107005,


        [XmlEnum("330201002")]
        Item330201002,


        [XmlEnum("620504001")]
        Item620504001,


        [XmlEnum("620503001")]
        Item620503001,


        [XmlEnum("110101034")]
        Item110101034,


        [XmlEnum("110107004")]
        Item110107004,


        [XmlEnum("610101007")]
        Item610101007,


        [XmlEnum("610101008")]
        Item610101008,


        [XmlEnum("110105014")]
        Item110105014,


        [XmlEnum("110205019")]
        Item110205019,


        [XmlEnum("110103012")]
        Item110103012,


        [XmlEnum("110203063")]
        Item110203063,


        [XmlEnum("120204007")]
        Item120204007,


        [XmlEnum("110204048")]
        Item110204048,


        [XmlEnum("110105013")]
        Item110105013,


        [XmlEnum("110204049")]
        Item110204049,


        [XmlEnum("110206017")]
        Item110206017,


        [XmlEnum("110109001")]
        Item110109001,


        [XmlEnum("110107006")]
        Item110107006,


        [XmlEnum("110201059")]
        Item110201059,


        [XmlEnum("110201058")]
        Item110201058,


        [XmlEnum("640301001")]
        Item640301001,


        [XmlEnum("110101035")]
        Item110101035,


        [XmlEnum("110101036")]
        Item110101036,


        [XmlEnum("110101037")]
        Item110101037,


        [XmlEnum("110205020")]
        Item110205020,


        [XmlEnum("120207005")]
        Item120207005,


        [XmlEnum("110206018")]
        Item110206018,


        [XmlEnum("110108006")]
        Item110108006,


        [XmlEnum("110203076")]
        Item110203076,


        [XmlEnum("110205021")]
        Item110205021,


        [XmlEnum("330201003")]
        Item330201003,


        [XmlEnum("130101001")]
        Item130101001,


        [XmlEnum("110201060")]
        Item110201060,


        [XmlEnum("110203071")]
        Item110203071,


        [XmlEnum("110203065")]
        Item110203065,


        [XmlEnum("110203064")]
        Item110203064,


        [XmlEnum("110204050")]
        Item110204050,


        [XmlEnum("110203066")]
        Item110203066,


        [XmlEnum("110203067")]
        Item110203067,


        [XmlEnum("110201061")]
        Item110201061,


        [XmlEnum("110203068")]
        Item110203068,


        [XmlEnum("110105026")]
        Item110105026,


        [XmlEnum("110106008")]
        Item110106008,
    }


   
    [Serializable]


    [XmlType(AnonymousType = true, Namespace = Namespaces.NFe)]
    public class TNFeInfNFeDetProdCombCIDE
    {


        public string qBCProd { get; set; }


        public string vAliqProd { get; set; }


        public string vCIDE { get; set; }
    }


   
    [Serializable]


    [XmlType(AnonymousType = true, Namespace = Namespaces.NFe)]
    public class TNFeInfNFeDetProdMed
    {


        public string nLote { get; set; }


        public string qLote { get; set; }


        public string dFab { get; set; }


        public string dVal { get; set; }


        public string vPMC { get; set; }
    }


   
    [Serializable]


    [XmlType(AnonymousType = true, Namespace = Namespaces.NFe)]
    public class TNFeInfNFeDetProdVeicProd
    {


        public TNFeInfNFeDetProdVeicProdTpOp tpOp { get; set; }


        public string chassi { get; set; }


        public string cCor { get; set; }


        public string xCor { get; set; }


        public string pot { get; set; }


        public string cilin { get; set; }


        public string pesoL { get; set; }


        public string pesoB { get; set; }


        public string nSerie { get; set; }


        public string tpComb { get; set; }


        public string nMotor { get; set; }


        public string CMT { get; set; }


        public string dist { get; set; }


        public string anoMod { get; set; }


        public string anoFab { get; set; }


        public string tpPint { get; set; }


        public string tpVeic { get; set; }


        public string espVeic { get; set; }


        public TNFeInfNFeDetProdVeicProdVIN VIN { get; set; }


        public TNFeInfNFeDetProdVeicProdCondVeic condVeic { get; set; }


        public string cMod { get; set; }


        public string cCorDENATRAN { get; set; }


        public string lota { get; set; }


        public TNFeInfNFeDetProdVeicProdTpRest tpRest { get; set; }
    }


   
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = Namespaces.NFe)]
    public enum TNFeInfNFeDetProdVeicProdTpOp
    {


        [XmlEnum("0")]
        Item0,


        [XmlEnum("1")]
        Item1,


        [XmlEnum("2")]
        Item2,


        [XmlEnum("3")]
        Item3,
    }


   
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = Namespaces.NFe)]
    public enum TNFeInfNFeDetProdVeicProdVIN
    {


        R,


        N,
    }


   
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = Namespaces.NFe)]
    public enum TNFeInfNFeDetProdVeicProdCondVeic
    {


        [XmlEnum("1")]
        Item1,


        [XmlEnum("2")]
        Item2,


        [XmlEnum("3")]
        Item3,
    }


   
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = Namespaces.NFe)]
    public enum TNFeInfNFeDetProdVeicProdTpRest
    {


        [XmlEnum("0")]
        Item0,


        [XmlEnum("1")]
        Item1,


        [XmlEnum("2")]
        Item2,


        [XmlEnum("3")]
        Item3,


        [XmlEnum("4")]
        Item4,


        [XmlEnum("9")]
        Item9,
    }


   
    [Serializable]


    [XmlType(AnonymousType = true, Namespace = Namespaces.NFe)]
    public class TNFeInfNFeDetImposto
    {


        public string vTotTrib { get; set; }


        [XmlElement("ICMS", typeof(TNFeInfNFeDetImpostoICMS))]
        [XmlElement("II", typeof(TNFeInfNFeDetImpostoII))]
        [XmlElement("IPI", typeof(TNFeInfNFeDetImpostoIPI))]
        [XmlElement("ISSQN", typeof(TNFeInfNFeDetImpostoISSQN))]
        public object[] Items { get; set; }


        public TNFeInfNFeDetImpostoPIS PIS { get; set; }


        public TNFeInfNFeDetImpostoPISST PISST { get; set; }


        public TNFeInfNFeDetImpostoCOFINS COFINS { get; set; }


        public TNFeInfNFeDetImpostoCOFINSST COFINSST { get; set; }
    }


   
    [Serializable]


    [XmlType(AnonymousType = true, Namespace = Namespaces.NFe)]
    public class TNFeInfNFeDetImpostoICMS
    {


        [XmlElement("ICMS00", typeof(TNFeInfNFeDetImpostoICMSICMS00))]
        [XmlElement("ICMS10", typeof(TNFeInfNFeDetImpostoICMSICMS10))]
        [XmlElement("ICMS20", typeof(TNFeInfNFeDetImpostoICMSICMS20))]
        [XmlElement("ICMS30", typeof(TNFeInfNFeDetImpostoICMSICMS30))]
        [XmlElement("ICMS40", typeof(TNFeInfNFeDetImpostoICMSICMS40))]
        [XmlElement("ICMS51", typeof(TNFeInfNFeDetImpostoICMSICMS51))]
        [XmlElement("ICMS60", typeof(TNFeInfNFeDetImpostoICMSICMS60))]
        [XmlElement("ICMS70", typeof(TNFeInfNFeDetImpostoICMSICMS70))]
        [XmlElement("ICMS90", typeof(TNFeInfNFeDetImpostoICMSICMS90))]
        [XmlElement("ICMSPart", typeof(TNFeInfNFeDetImpostoICMSICMSPart))]
        [XmlElement("ICMSSN101", typeof(TNFeInfNFeDetImpostoICMSICMSSN101))]
        [XmlElement("ICMSSN102", typeof(TNFeInfNFeDetImpostoICMSICMSSN102))]
        [XmlElement("ICMSSN201", typeof(TNFeInfNFeDetImpostoICMSICMSSN201))]
        [XmlElement("ICMSSN202", typeof(TNFeInfNFeDetImpostoICMSICMSSN202))]
        [XmlElement("ICMSSN500", typeof(TNFeInfNFeDetImpostoICMSICMSSN500))]
        [XmlElement("ICMSSN900", typeof(TNFeInfNFeDetImpostoICMSICMSSN900))]
        [XmlElement("ICMSST", typeof(TNFeInfNFeDetImpostoICMSICMSST))]
        public object Item { get; set; }
    }


   
    [Serializable]


    [XmlType(AnonymousType = true, Namespace = Namespaces.NFe)]
    public class TNFeInfNFeDetImpostoICMSICMS00
    {


        public Torig orig { get; set; }


        public TNFeInfNFeDetImpostoICMSICMS00CST CST { get; set; }


        public TNFeInfNFeDetImpostoICMSICMS00ModBC modBC { get; set; }


        public string vBC { get; set; }


        public string pICMS { get; set; }


        public string vICMS { get; set; }
    }


   
    [Serializable]
    [XmlType(Namespace = Namespaces.NFe)]
    public enum Torig
    {


        [XmlEnum("0")]
        Item0,


        [XmlEnum("1")]
        Item1,


        [XmlEnum("2")]
        Item2,


        [XmlEnum("3")]
        Item3,


        [XmlEnum("4")]
        Item4,


        [XmlEnum("5")]
        Item5,


        [XmlEnum("6")]
        Item6,


        [XmlEnum("7")]
        Item7,


        [XmlEnum("8")]
        Item8,
    }


   
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = Namespaces.NFe)]
    public enum TNFeInfNFeDetImpostoICMSICMS00CST
    {


        [XmlEnum("00")]
        Item00,
    }


   
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = Namespaces.NFe)]
    public enum TNFeInfNFeDetImpostoICMSICMS00ModBC
    {


        [XmlEnum("0")]
        Item0,


        [XmlEnum("1")]
        Item1,


        [XmlEnum("2")]
        Item2,


        [XmlEnum("3")]
        Item3,
    }


   
    [Serializable]


    [XmlType(AnonymousType = true, Namespace = Namespaces.NFe)]
    public class TNFeInfNFeDetImpostoICMSICMS10
    {


        public Torig orig { get; set; }


        public TNFeInfNFeDetImpostoICMSICMS10CST CST { get; set; }


        public TNFeInfNFeDetImpostoICMSICMS10ModBC modBC { get; set; }


        public string vBC { get; set; }


        public string pICMS { get; set; }


        public string vICMS { get; set; }


        public TNFeInfNFeDetImpostoICMSICMS10ModBCST modBCST { get; set; }


        public string pMVAST { get; set; }


        public string pRedBCST { get; set; }


        public string vBCST { get; set; }


        public string pICMSST { get; set; }


        public string vICMSST { get; set; }
    }


   
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = Namespaces.NFe)]
    public enum TNFeInfNFeDetImpostoICMSICMS10CST
    {


        [XmlEnum("10")]
        Item10,
    }


   
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = Namespaces.NFe)]
    public enum TNFeInfNFeDetImpostoICMSICMS10ModBC
    {


        [XmlEnum("0")]
        Item0,


        [XmlEnum("1")]
        Item1,


        [XmlEnum("2")]
        Item2,


        [XmlEnum("3")]
        Item3,
    }


   
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = Namespaces.NFe)]
    public enum TNFeInfNFeDetImpostoICMSICMS10ModBCST
    {


        [XmlEnum("0")]
        Item0,


        [XmlEnum("1")]
        Item1,


        [XmlEnum("2")]
        Item2,


        [XmlEnum("3")]
        Item3,


        [XmlEnum("4")]
        Item4,


        [XmlEnum("5")]
        Item5,
    }


   
    [Serializable]


    [XmlType(AnonymousType = true, Namespace = Namespaces.NFe)]
    public class TNFeInfNFeDetImpostoICMSICMS20
    {


        public Torig orig { get; set; }


        public TNFeInfNFeDetImpostoICMSICMS20CST CST { get; set; }


        public TNFeInfNFeDetImpostoICMSICMS20ModBC modBC { get; set; }


        public string pRedBC { get; set; }


        public string vBC { get; set; }


        public string pICMS { get; set; }


        public string vICMS { get; set; }
    }


   
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = Namespaces.NFe)]
    public enum TNFeInfNFeDetImpostoICMSICMS20CST
    {


        [XmlEnum("20")]
        Item20,
    }


   
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = Namespaces.NFe)]
    public enum TNFeInfNFeDetImpostoICMSICMS20ModBC
    {


        [XmlEnum("0")]
        Item0,


        [XmlEnum("1")]
        Item1,


        [XmlEnum("2")]
        Item2,


        [XmlEnum("3")]
        Item3,
    }


   
    [Serializable]


    [XmlType(AnonymousType = true, Namespace = Namespaces.NFe)]
    public class TNFeInfNFeDetImpostoICMSICMS30
    {


        public Torig orig { get; set; }


        public TNFeInfNFeDetImpostoICMSICMS30CST CST { get; set; }


        public TNFeInfNFeDetImpostoICMSICMS30ModBCST modBCST { get; set; }


        public string pMVAST { get; set; }


        public string pRedBCST { get; set; }


        public string vBCST { get; set; }


        public string pICMSST { get; set; }


        public string vICMSST { get; set; }
    }


   
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = Namespaces.NFe)]
    public enum TNFeInfNFeDetImpostoICMSICMS30CST
    {


        [XmlEnum("30")]
        Item30,
    }


   
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = Namespaces.NFe)]
    public enum TNFeInfNFeDetImpostoICMSICMS30ModBCST
    {


        [XmlEnum("0")]
        Item0,


        [XmlEnum("1")]
        Item1,


        [XmlEnum("2")]
        Item2,


        [XmlEnum("3")]
        Item3,


        [XmlEnum("4")]
        Item4,


        [XmlEnum("5")]
        Item5,
    }


   
    [Serializable]


    [XmlType(AnonymousType = true, Namespace = Namespaces.NFe)]
    public class TNFeInfNFeDetImpostoICMSICMS40
    {


        public Torig orig { get; set; }


        public TNFeInfNFeDetImpostoICMSICMS40CST CST { get; set; }


        public string vICMS { get; set; }


        public TNFeInfNFeDetImpostoICMSICMS40MotDesICMS motDesICMS { get; set; }
    }


   
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = Namespaces.NFe)]
    public enum TNFeInfNFeDetImpostoICMSICMS40CST
    {


        [XmlEnum("40")]
        Item40,


        [XmlEnum("41")]
        Item41,


        [XmlEnum("50")]
        Item50,
    }


   
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = Namespaces.NFe)]
    public enum TNFeInfNFeDetImpostoICMSICMS40MotDesICMS
    {


        [XmlEnum("1")]
        Item1,


        [XmlEnum("2")]
        Item2,


        [XmlEnum("3")]
        Item3,


        [XmlEnum("4")]
        Item4,


        [XmlEnum("5")]
        Item5,


        [XmlEnum("6")]
        Item6,


        [XmlEnum("7")]
        Item7,


        [XmlEnum("8")]
        Item8,


        [XmlEnum("9")]
        Item9,
    }


   
    [Serializable]


    [XmlType(AnonymousType = true, Namespace = Namespaces.NFe)]
    public class TNFeInfNFeDetImpostoICMSICMS51
    {


        public Torig orig { get; set; }


        public TNFeInfNFeDetImpostoICMSICMS51CST CST { get; set; }


        public TNFeInfNFeDetImpostoICMSICMS51ModBC modBC { get; set; }


        [XmlIgnore()]
        public bool modBCSpecified { get; set; }


        public string pRedBC { get; set; }


        public string vBC { get; set; }


        public string pICMS { get; set; }


        public string vICMS { get; set; }
    }


   
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = Namespaces.NFe)]
    public enum TNFeInfNFeDetImpostoICMSICMS51CST
    {


        [XmlEnum("51")]
        Item51,
    }


   
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = Namespaces.NFe)]
    public enum TNFeInfNFeDetImpostoICMSICMS51ModBC
    {


        [XmlEnum("0")]
        Item0,


        [XmlEnum("1")]
        Item1,


        [XmlEnum("2")]
        Item2,


        [XmlEnum("3")]
        Item3,
    }


   
    [Serializable]


    [XmlType(AnonymousType = true, Namespace = Namespaces.NFe)]
    public class TNFeInfNFeDetImpostoICMSICMS60
    {


        public Torig orig { get; set; }


        public TNFeInfNFeDetImpostoICMSICMS60CST CST { get; set; }


        public string vBCSTRet { get; set; }


        public string vICMSSTRet { get; set; }
    }


   
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = Namespaces.NFe)]
    public enum TNFeInfNFeDetImpostoICMSICMS60CST
    {


        [XmlEnum("60")]
        Item60,
    }


   
    [Serializable]


    [XmlType(AnonymousType = true, Namespace = Namespaces.NFe)]
    public class TNFeInfNFeDetImpostoICMSICMS70
    {


        public Torig orig { get; set; }


        public TNFeInfNFeDetImpostoICMSICMS70CST CST { get; set; }


        public TNFeInfNFeDetImpostoICMSICMS70ModBC modBC { get; set; }


        public string pRedBC { get; set; }


        public string vBC { get; set; }


        public string pICMS { get; set; }


        public string vICMS { get; set; }


        public TNFeInfNFeDetImpostoICMSICMS70ModBCST modBCST { get; set; }


        public string pMVAST { get; set; }


        public string pRedBCST { get; set; }


        public string vBCST { get; set; }


        public string pICMSST { get; set; }


        public string vICMSST { get; set; }
    }


   
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = Namespaces.NFe)]
    public enum TNFeInfNFeDetImpostoICMSICMS70CST
    {


        [XmlEnum("70")]
        Item70,
    }


   
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = Namespaces.NFe)]
    public enum TNFeInfNFeDetImpostoICMSICMS70ModBC
    {


        [XmlEnum("0")]
        Item0,


        [XmlEnum("1")]
        Item1,


        [XmlEnum("2")]
        Item2,


        [XmlEnum("3")]
        Item3,
    }


   
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = Namespaces.NFe)]
    public enum TNFeInfNFeDetImpostoICMSICMS70ModBCST
    {


        [XmlEnum("0")]
        Item0,


        [XmlEnum("1")]
        Item1,


        [XmlEnum("2")]
        Item2,


        [XmlEnum("3")]
        Item3,


        [XmlEnum("4")]
        Item4,


        [XmlEnum("5")]
        Item5,
    }


   
    [Serializable]


    [XmlType(AnonymousType = true, Namespace = Namespaces.NFe)]
    public class TNFeInfNFeDetImpostoICMSICMS90
    {


        public Torig orig { get; set; }


        public TNFeInfNFeDetImpostoICMSICMS90CST CST { get; set; }


        public TNFeInfNFeDetImpostoICMSICMS90ModBC modBC { get; set; }


        public string vBC { get; set; }


        public string pRedBC { get; set; }


        public string pICMS { get; set; }


        public string vICMS { get; set; }


        public TNFeInfNFeDetImpostoICMSICMS90ModBCST modBCST { get; set; }


        public string pMVAST { get; set; }


        public string pRedBCST { get; set; }


        public string vBCST { get; set; }


        public string pICMSST { get; set; }


        public string vICMSST { get; set; }
    }


   
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = Namespaces.NFe)]
    public enum TNFeInfNFeDetImpostoICMSICMS90CST
    {


        [XmlEnum("90")]
        Item90,
    }


   
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = Namespaces.NFe)]
    public enum TNFeInfNFeDetImpostoICMSICMS90ModBC
    {


        [XmlEnum("0")]
        Item0,


        [XmlEnum("1")]
        Item1,


        [XmlEnum("2")]
        Item2,


        [XmlEnum("3")]
        Item3,
    }


   
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = Namespaces.NFe)]
    public enum TNFeInfNFeDetImpostoICMSICMS90ModBCST
    {


        [XmlEnum("0")]
        Item0,


        [XmlEnum("1")]
        Item1,


        [XmlEnum("2")]
        Item2,


        [XmlEnum("3")]
        Item3,


        [XmlEnum("4")]
        Item4,


        [XmlEnum("5")]
        Item5,
    }


   
    [Serializable]


    [XmlType(AnonymousType = true, Namespace = Namespaces.NFe)]
    public class TNFeInfNFeDetImpostoICMSICMSPart
    {


        public Torig orig { get; set; }


        public TNFeInfNFeDetImpostoICMSICMSPartCST CST { get; set; }


        public TNFeInfNFeDetImpostoICMSICMSPartModBC modBC { get; set; }


        public string vBC { get; set; }


        public string pRedBC { get; set; }


        public string pICMS { get; set; }


        public string vICMS { get; set; }


        public TNFeInfNFeDetImpostoICMSICMSPartModBCST modBCST { get; set; }


        public string pMVAST { get; set; }


        public string pRedBCST { get; set; }


        public string vBCST { get; set; }


        public string pICMSST { get; set; }


        public string vICMSST { get; set; }


        public string pBCOp { get; set; }


        public TUf UFST { get; set; }
    }


   
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = Namespaces.NFe)]
    public enum TNFeInfNFeDetImpostoICMSICMSPartCST
    {


        [XmlEnum("10")]
        Item10,


        [XmlEnum("90")]
        Item90,
    }


   
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = Namespaces.NFe)]
    public enum TNFeInfNFeDetImpostoICMSICMSPartModBC
    {


        [XmlEnum("0")]
        Item0,


        [XmlEnum("1")]
        Item1,


        [XmlEnum("2")]
        Item2,


        [XmlEnum("3")]
        Item3,
    }


   
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = Namespaces.NFe)]
    public enum TNFeInfNFeDetImpostoICMSICMSPartModBCST
    {


        [XmlEnum("0")]
        Item0,


        [XmlEnum("1")]
        Item1,


        [XmlEnum("2")]
        Item2,


        [XmlEnum("3")]
        Item3,


        [XmlEnum("4")]
        Item4,


        [XmlEnum("5")]
        Item5,
    }


   
    [Serializable]


    [XmlType(AnonymousType = true, Namespace = Namespaces.NFe)]
    public class TNFeInfNFeDetImpostoICMSICMSSN101
    {


        public Torig orig { get; set; }


        public TNFeInfNFeDetImpostoICMSICMSSN101CSOSN CSOSN { get; set; }


        public string pCredSN { get; set; }


        public string vCredICMSSN { get; set; }
    }


   
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = Namespaces.NFe)]
    public enum TNFeInfNFeDetImpostoICMSICMSSN101CSOSN
    {


        [XmlEnum("101")]
        Item101,
    }


   
    [Serializable]


    [XmlType(AnonymousType = true, Namespace = Namespaces.NFe)]
    public class TNFeInfNFeDetImpostoICMSICMSSN102
    {


        public Torig orig { get; set; }


        public TNFeInfNFeDetImpostoICMSICMSSN102CSOSN CSOSN { get; set; }
    }


   
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = Namespaces.NFe)]
    public enum TNFeInfNFeDetImpostoICMSICMSSN102CSOSN
    {


        [XmlEnum("102")]
        Item102,


        [XmlEnum("103")]
        Item103,


        [XmlEnum("300")]
        Item300,


        [XmlEnum("400")]
        Item400,
    }


   
    [Serializable]


    [XmlType(AnonymousType = true, Namespace = Namespaces.NFe)]
    public class TNFeInfNFeDetImpostoICMSICMSSN201
    {


        public Torig orig { get; set; }


        public TNFeInfNFeDetImpostoICMSICMSSN201CSOSN CSOSN { get; set; }


        public TNFeInfNFeDetImpostoICMSICMSSN201ModBCST modBCST { get; set; }


        public string pMVAST { get; set; }


        public string pRedBCST { get; set; }


        public string vBCST { get; set; }


        public string pICMSST { get; set; }


        public string vICMSST { get; set; }


        public string pCredSN { get; set; }


        public string vCredICMSSN { get; set; }
    }


   
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = Namespaces.NFe)]
    public enum TNFeInfNFeDetImpostoICMSICMSSN201CSOSN
    {


        [XmlEnum("201")]
        Item201,
    }


   
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = Namespaces.NFe)]
    public enum TNFeInfNFeDetImpostoICMSICMSSN201ModBCST
    {


        [XmlEnum("0")]
        Item0,


        [XmlEnum("1")]
        Item1,


        [XmlEnum("2")]
        Item2,


        [XmlEnum("3")]
        Item3,


        [XmlEnum("4")]
        Item4,


        [XmlEnum("5")]
        Item5,
    }


   
    [Serializable]


    [XmlType(AnonymousType = true, Namespace = Namespaces.NFe)]
    public class TNFeInfNFeDetImpostoICMSICMSSN202
    {


        public Torig orig { get; set; }


        public TNFeInfNFeDetImpostoICMSICMSSN202CSOSN CSOSN { get; set; }


        public TNFeInfNFeDetImpostoICMSICMSSN202ModBCST modBCST { get; set; }


        public string pMVAST { get; set; }


        public string pRedBCST { get; set; }


        public string vBCST { get; set; }


        public string pICMSST { get; set; }


        public string vICMSST { get; set; }
    }


   
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = Namespaces.NFe)]
    public enum TNFeInfNFeDetImpostoICMSICMSSN202CSOSN
    {


        [XmlEnum("202")]
        Item202,


        [XmlEnum("203")]
        Item203,
    }


   
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = Namespaces.NFe)]
    public enum TNFeInfNFeDetImpostoICMSICMSSN202ModBCST
    {


        [XmlEnum("0")]
        Item0,


        [XmlEnum("1")]
        Item1,


        [XmlEnum("2")]
        Item2,


        [XmlEnum("3")]
        Item3,


        [XmlEnum("4")]
        Item4,


        [XmlEnum("5")]
        Item5,
    }


   
    [Serializable]


    [XmlType(AnonymousType = true, Namespace = Namespaces.NFe)]
    public class TNFeInfNFeDetImpostoICMSICMSSN500
    {


        public Torig orig { get; set; }


        public TNFeInfNFeDetImpostoICMSICMSSN500CSOSN CSOSN { get; set; }


        public string vBCSTRet { get; set; }


        public string vICMSSTRet { get; set; }
    }


   
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = Namespaces.NFe)]
    public enum TNFeInfNFeDetImpostoICMSICMSSN500CSOSN
    {


        [XmlEnum("500")]
        Item500,
    }


   
    [Serializable]


    [XmlType(AnonymousType = true, Namespace = Namespaces.NFe)]
    public class TNFeInfNFeDetImpostoICMSICMSSN900
    {


        public Torig orig { get; set; }


        public TNFeInfNFeDetImpostoICMSICMSSN900CSOSN CSOSN { get; set; }


        public TNFeInfNFeDetImpostoICMSICMSSN900ModBC modBC { get; set; }


        public string vBC { get; set; }


        public string pRedBC { get; set; }


        public string pICMS { get; set; }


        public string vICMS { get; set; }


        public TNFeInfNFeDetImpostoICMSICMSSN900ModBCST modBCST { get; set; }


        public string pMVAST { get; set; }


        public string pRedBCST { get; set; }


        public string vBCST { get; set; }


        public string pICMSST { get; set; }


        public string vICMSST { get; set; }


        public string pCredSN { get; set; }


        public string vCredICMSSN { get; set; }
    }


   
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = Namespaces.NFe)]
    public enum TNFeInfNFeDetImpostoICMSICMSSN900CSOSN
    {


        [XmlEnum("900")]
        Item900,
    }


   
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = Namespaces.NFe)]
    public enum TNFeInfNFeDetImpostoICMSICMSSN900ModBC
    {


        [XmlEnum("0")]
        Item0,


        [XmlEnum("1")]
        Item1,


        [XmlEnum("2")]
        Item2,


        [XmlEnum("3")]
        Item3,
    }


   
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = Namespaces.NFe)]
    public enum TNFeInfNFeDetImpostoICMSICMSSN900ModBCST
    {


        [XmlEnum("0")]
        Item0,


        [XmlEnum("1")]
        Item1,


        [XmlEnum("2")]
        Item2,


        [XmlEnum("3")]
        Item3,


        [XmlEnum("4")]
        Item4,


        [XmlEnum("5")]
        Item5,
    }


   
    [Serializable]


    [XmlType(AnonymousType = true, Namespace = Namespaces.NFe)]
    public class TNFeInfNFeDetImpostoICMSICMSST
    {


        public Torig orig { get; set; }


        public TNFeInfNFeDetImpostoICMSICMSSTCST CST { get; set; }


        public string vBCSTRet { get; set; }


        public string vICMSSTRet { get; set; }


        public string vBCSTDest { get; set; }


        public string vICMSSTDest { get; set; }
    }


   
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = Namespaces.NFe)]
    public enum TNFeInfNFeDetImpostoICMSICMSSTCST
    {


        [XmlEnum("41")]
        Item41,
    }


   
    [Serializable]


    [XmlType(AnonymousType = true, Namespace = Namespaces.NFe)]
    public class TNFeInfNFeDetImpostoII
    {


        public string vBC { get; set; }


        public string vDespAdu { get; set; }


        public string vII { get; set; }


        public string vIOF { get; set; }
    }


   
    [Serializable]


    [XmlType(AnonymousType = true, Namespace = Namespaces.NFe)]
    public class TNFeInfNFeDetImpostoIPI
    {


        public string clEnq { get; set; }


        public string CNPJProd { get; set; }


        public string cSelo { get; set; }


        public string qSelo { get; set; }


        public string cEnq { get; set; }


        [XmlElement("IPINT", typeof(TNFeInfNFeDetImpostoIPIIPINT))]
        [XmlElement("IPITrib", typeof(TNFeInfNFeDetImpostoIPIIPITrib))]
        public object Item { get; set; }
    }


   
    [Serializable]


    [XmlType(AnonymousType = true, Namespace = Namespaces.NFe)]
    public class TNFeInfNFeDetImpostoIPIIPINT
    {


        public TNFeInfNFeDetImpostoIPIIPINTCST CST { get; set; }
    }


   
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = Namespaces.NFe)]
    public enum TNFeInfNFeDetImpostoIPIIPINTCST
    {


        [XmlEnum("01")]
        Item01,


        [XmlEnum("02")]
        Item02,


        [XmlEnum("03")]
        Item03,


        [XmlEnum("04")]
        Item04,


        [XmlEnum("05")]
        Item05,


        [XmlEnum("51")]
        Item51,


        [XmlEnum("52")]
        Item52,


        [XmlEnum("53")]
        Item53,


        [XmlEnum("54")]
        Item54,


        [XmlEnum("55")]
        Item55,
    }


   
    [Serializable]


    [XmlType(AnonymousType = true, Namespace = Namespaces.NFe)]
    public class TNFeInfNFeDetImpostoIPIIPITrib
    {


        public TNFeInfNFeDetImpostoIPIIPITribCST CST { get; set; }


        [XmlElement("pIPI", typeof(string))]
        [XmlElement("qUnid", typeof(string))]
        [XmlElement("vBC", typeof(string))]
        [XmlElement("vUnid", typeof(string))]
        [XmlChoiceIdentifier("ItemsElementName")]
        public string[] Items { get; set; }


        [XmlElement("ItemsElementName")]
        [XmlIgnore()]
        public ItemsChoiceType[] ItemsElementName { get; set; }


        public string vIPI { get; set; }
    }


   
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = Namespaces.NFe)]
    public enum TNFeInfNFeDetImpostoIPIIPITribCST
    {


        [XmlEnum("00")]
        Item00,


        [XmlEnum("49")]
        Item49,


        [XmlEnum("50")]
        Item50,


        [XmlEnum("99")]
        Item99,
    }


   
    [Serializable]
    [XmlType(Namespace = Namespaces.NFe, IncludeInSchema = false)]
    public enum ItemsChoiceType
    {


        pIPI,


        qUnid,


        vBC,


        vUnid,
    }


   
    [Serializable]


    [XmlType(AnonymousType = true, Namespace = Namespaces.NFe)]
    public class TNFeInfNFeDetImpostoISSQN
    {


        public string vBC { get; set; }


        public string vAliq { get; set; }


        public string vISSQN { get; set; }


        public string cMunFG { get; set; }


        public TCListServ cListServ { get; set; }


        public TNFeInfNFeDetImpostoISSQNCSitTrib cSitTrib { get; set; }
    }


   
    [Serializable]
    [XmlType(Namespace = Namespaces.NFe)]
    public enum TCListServ
    {


        [XmlEnum("101")]
        Item101,


        [XmlEnum("102")]
        Item102,


        [XmlEnum("103")]
        Item103,


        [XmlEnum("104")]
        Item104,


        [XmlEnum("105")]
        Item105,


        [XmlEnum("106")]
        Item106,


        [XmlEnum("107")]
        Item107,


        [XmlEnum("108")]
        Item108,


        [XmlEnum("201")]
        Item201,


        [XmlEnum("302")]
        Item302,


        [XmlEnum("303")]
        Item303,


        [XmlEnum("304")]
        Item304,


        [XmlEnum("305")]
        Item305,


        [XmlEnum("401")]
        Item401,


        [XmlEnum("402")]
        Item402,


        [XmlEnum("403")]
        Item403,


        [XmlEnum("404")]
        Item404,


        [XmlEnum("405")]
        Item405,


        [XmlEnum("406")]
        Item406,


        [XmlEnum("407")]
        Item407,


        [XmlEnum("408")]
        Item408,


        [XmlEnum("409")]
        Item409,


        [XmlEnum("410")]
        Item410,


        [XmlEnum("411")]
        Item411,


        [XmlEnum("412")]
        Item412,


        [XmlEnum("413")]
        Item413,


        [XmlEnum("414")]
        Item414,


        [XmlEnum("415")]
        Item415,


        [XmlEnum("416")]
        Item416,


        [XmlEnum("417")]
        Item417,


        [XmlEnum("418")]
        Item418,


        [XmlEnum("419")]
        Item419,


        [XmlEnum("420")]
        Item420,


        [XmlEnum("421")]
        Item421,


        [XmlEnum("422")]
        Item422,


        [XmlEnum("423")]
        Item423,


        [XmlEnum("501")]
        Item501,


        [XmlEnum("502")]
        Item502,


        [XmlEnum("503")]
        Item503,


        [XmlEnum("504")]
        Item504,


        [XmlEnum("505")]
        Item505,


        [XmlEnum("506")]
        Item506,


        [XmlEnum("507")]
        Item507,


        [XmlEnum("508")]
        Item508,


        [XmlEnum("509")]
        Item509,


        [XmlEnum("601")]
        Item601,


        [XmlEnum("602")]
        Item602,


        [XmlEnum("603")]
        Item603,


        [XmlEnum("604")]
        Item604,


        [XmlEnum("605")]
        Item605,


        [XmlEnum("701")]
        Item701,


        [XmlEnum("702")]
        Item702,


        [XmlEnum("703")]
        Item703,


        [XmlEnum("704")]
        Item704,


        [XmlEnum("705")]
        Item705,


        [XmlEnum("706")]
        Item706,


        [XmlEnum("707")]
        Item707,


        [XmlEnum("708")]
        Item708,


        [XmlEnum("709")]
        Item709,


        [XmlEnum("710")]
        Item710,


        [XmlEnum("711")]
        Item711,


        [XmlEnum("712")]
        Item712,


        [XmlEnum("713")]
        Item713,


        [XmlEnum("716")]
        Item716,


        [XmlEnum("717")]
        Item717,


        [XmlEnum("718")]
        Item718,


        [XmlEnum("719")]
        Item719,


        [XmlEnum("720")]
        Item720,


        [XmlEnum("721")]
        Item721,


        [XmlEnum("722")]
        Item722,


        [XmlEnum("801")]
        Item801,


        [XmlEnum("802")]
        Item802,


        [XmlEnum("901")]
        Item901,


        [XmlEnum("902")]
        Item902,


        [XmlEnum("903")]
        Item903,


        [XmlEnum("1001")]
        Item1001,


        [XmlEnum("1002")]
        Item1002,


        [XmlEnum("1003")]
        Item1003,


        [XmlEnum("1004")]
        Item1004,


        [XmlEnum("1005")]
        Item1005,


        [XmlEnum("1006")]
        Item1006,


        [XmlEnum("1007")]
        Item1007,


        [XmlEnum("1008")]
        Item1008,


        [XmlEnum("1009")]
        Item1009,


        [XmlEnum("1010")]
        Item1010,


        [XmlEnum("1101")]
        Item1101,


        [XmlEnum("1102")]
        Item1102,


        [XmlEnum("1103")]
        Item1103,


        [XmlEnum("1104")]
        Item1104,


        [XmlEnum("1201")]
        Item1201,


        [XmlEnum("1202")]
        Item1202,


        [XmlEnum("1203")]
        Item1203,


        [XmlEnum("1204")]
        Item1204,


        [XmlEnum("1205")]
        Item1205,


        [XmlEnum("1206")]
        Item1206,


        [XmlEnum("1207")]
        Item1207,


        [XmlEnum("1208")]
        Item1208,


        [XmlEnum("1209")]
        Item1209,


        [XmlEnum("1210")]
        Item1210,


        [XmlEnum("1211")]
        Item1211,


        [XmlEnum("1212")]
        Item1212,


        [XmlEnum("1213")]
        Item1213,


        [XmlEnum("1214")]
        Item1214,


        [XmlEnum("1215")]
        Item1215,


        [XmlEnum("1216")]
        Item1216,


        [XmlEnum("1217")]
        Item1217,


        [XmlEnum("1302")]
        Item1302,


        [XmlEnum("1303")]
        Item1303,


        [XmlEnum("1304")]
        Item1304,


        [XmlEnum("1305")]
        Item1305,


        [XmlEnum("1401")]
        Item1401,


        [XmlEnum("1402")]
        Item1402,


        [XmlEnum("1403")]
        Item1403,


        [XmlEnum("1404")]
        Item1404,


        [XmlEnum("1405")]
        Item1405,


        [XmlEnum("1406")]
        Item1406,


        [XmlEnum("1407")]
        Item1407,


        [XmlEnum("1408")]
        Item1408,


        [XmlEnum("1409")]
        Item1409,


        [XmlEnum("1410")]
        Item1410,


        [XmlEnum("1411")]
        Item1411,


        [XmlEnum("1412")]
        Item1412,


        [XmlEnum("1413")]
        Item1413,


        [XmlEnum("1501")]
        Item1501,


        [XmlEnum("1502")]
        Item1502,


        [XmlEnum("1503")]
        Item1503,


        [XmlEnum("1504")]
        Item1504,


        [XmlEnum("1505")]
        Item1505,


        [XmlEnum("1506")]
        Item1506,


        [XmlEnum("1507")]
        Item1507,


        [XmlEnum("1508")]
        Item1508,


        [XmlEnum("1509")]
        Item1509,


        [XmlEnum("1510")]
        Item1510,


        [XmlEnum("1511")]
        Item1511,


        [XmlEnum("1512")]
        Item1512,


        [XmlEnum("1513")]
        Item1513,


        [XmlEnum("1514")]
        Item1514,


        [XmlEnum("1515")]
        Item1515,


        [XmlEnum("1516")]
        Item1516,


        [XmlEnum("1517")]
        Item1517,


        [XmlEnum("1518")]
        Item1518,


        [XmlEnum("1601")]
        Item1601,


        [XmlEnum("1701")]
        Item1701,


        [XmlEnum("1702")]
        Item1702,


        [XmlEnum("1703")]
        Item1703,


        [XmlEnum("1704")]
        Item1704,


        [XmlEnum("1705")]
        Item1705,


        [XmlEnum("1706")]
        Item1706,


        [XmlEnum("1708")]
        Item1708,


        [XmlEnum("1709")]
        Item1709,


        [XmlEnum("1710")]
        Item1710,


        [XmlEnum("1711")]
        Item1711,


        [XmlEnum("1712")]
        Item1712,


        [XmlEnum("1713")]
        Item1713,


        [XmlEnum("1714")]
        Item1714,


        [XmlEnum("1715")]
        Item1715,


        [XmlEnum("1716")]
        Item1716,


        [XmlEnum("1717")]
        Item1717,


        [XmlEnum("1718")]
        Item1718,


        [XmlEnum("1719")]
        Item1719,


        [XmlEnum("1720")]
        Item1720,


        [XmlEnum("1721")]
        Item1721,


        [XmlEnum("1722")]
        Item1722,


        [XmlEnum("1723")]
        Item1723,


        [XmlEnum("1724")]
        Item1724,


        [XmlEnum("1801")]
        Item1801,


        [XmlEnum("1901")]
        Item1901,


        [XmlEnum("2001")]
        Item2001,


        [XmlEnum("2002")]
        Item2002,


        [XmlEnum("2003")]
        Item2003,


        [XmlEnum("2101")]
        Item2101,


        [XmlEnum("2201")]
        Item2201,


        [XmlEnum("2301")]
        Item2301,


        [XmlEnum("2401")]
        Item2401,


        [XmlEnum("2501")]
        Item2501,


        [XmlEnum("2502")]
        Item2502,


        [XmlEnum("2503")]
        Item2503,


        [XmlEnum("2504")]
        Item2504,


        [XmlEnum("2601")]
        Item2601,


        [XmlEnum("2701")]
        Item2701,


        [XmlEnum("2801")]
        Item2801,


        [XmlEnum("2901")]
        Item2901,


        [XmlEnum("3001")]
        Item3001,


        [XmlEnum("3101")]
        Item3101,


        [XmlEnum("3201")]
        Item3201,


        [XmlEnum("3301")]
        Item3301,


        [XmlEnum("3401")]
        Item3401,


        [XmlEnum("3501")]
        Item3501,


        [XmlEnum("3601")]
        Item3601,


        [XmlEnum("3701")]
        Item3701,


        [XmlEnum("3801")]
        Item3801,


        [XmlEnum("3901")]
        Item3901,


        [XmlEnum("4001")]
        Item4001,
    }


   
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = Namespaces.NFe)]
    public enum TNFeInfNFeDetImpostoISSQNCSitTrib
    {


        N,


        R,


        S,


        I,
    }


   
    [Serializable]


    [XmlType(AnonymousType = true, Namespace = Namespaces.NFe)]
    public class TNFeInfNFeDetImpostoPIS
    {


        [XmlElement("PISAliq", typeof(TNFeInfNFeDetImpostoPISPISAliq))]
        [XmlElement("PISNT", typeof(TNFeInfNFeDetImpostoPISPISNT))]
        [XmlElement("PISOutr", typeof(TNFeInfNFeDetImpostoPISPISOutr))]
        [XmlElement("PISQtde", typeof(TNFeInfNFeDetImpostoPISPISQtde))]
        public object Item { get; set; }
    }


   
    [Serializable]


    [XmlType(AnonymousType = true, Namespace = Namespaces.NFe)]
    public class TNFeInfNFeDetImpostoPISPISAliq
    {


        public TNFeInfNFeDetImpostoPISPISAliqCST CST { get; set; }


        public string vBC { get; set; }


        public string pPIS { get; set; }


        public string vPIS { get; set; }
    }


   
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = Namespaces.NFe)]
    public enum TNFeInfNFeDetImpostoPISPISAliqCST
    {


        [XmlEnum("01")]
        Item01,


        [XmlEnum("02")]
        Item02,
    }


   
    [Serializable]


    [XmlType(AnonymousType = true, Namespace = Namespaces.NFe)]
    public class TNFeInfNFeDetImpostoPISPISNT
    {


        public TNFeInfNFeDetImpostoPISPISNTCST CST { get; set; }
    }


   
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = Namespaces.NFe)]
    public enum TNFeInfNFeDetImpostoPISPISNTCST
    {


        [XmlEnum("04")]
        Item04,


        [XmlEnum("06")]
        Item06,


        [XmlEnum("07")]
        Item07,


        [XmlEnum("08")]
        Item08,


        [XmlEnum("09")]
        Item09,
    }


   
    [Serializable]


    [XmlType(AnonymousType = true, Namespace = Namespaces.NFe)]
    public class TNFeInfNFeDetImpostoPISPISOutr
    {


        public TNFeInfNFeDetImpostoPISPISOutrCST CST { get; set; }


        [XmlElement("pPIS", typeof(string))]
        [XmlElement("qBCProd", typeof(string))]
        [XmlElement("vAliqProd", typeof(string))]
        [XmlElement("vBC", typeof(string))]
        [XmlChoiceIdentifier("ItemsElementName")]
        public string[] Items { get; set; }


        [XmlElement("ItemsElementName")]
        [XmlIgnore()]
        public ItemsChoiceType1[] ItemsElementName { get; set; }


        public string vPIS { get; set; }
    }


   
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = Namespaces.NFe)]
    public enum TNFeInfNFeDetImpostoPISPISOutrCST
    {


        [XmlEnum("49")]
        Item49,


        [XmlEnum("50")]
        Item50,


        [XmlEnum("51")]
        Item51,


        [XmlEnum("52")]
        Item52,


        [XmlEnum("53")]
        Item53,


        [XmlEnum("54")]
        Item54,


        [XmlEnum("55")]
        Item55,


        [XmlEnum("56")]
        Item56,


        [XmlEnum("60")]
        Item60,


        [XmlEnum("61")]
        Item61,


        [XmlEnum("62")]
        Item62,


        [XmlEnum("63")]
        Item63,


        [XmlEnum("64")]
        Item64,


        [XmlEnum("65")]
        Item65,


        [XmlEnum("66")]
        Item66,


        [XmlEnum("67")]
        Item67,


        [XmlEnum("70")]
        Item70,


        [XmlEnum("71")]
        Item71,


        [XmlEnum("72")]
        Item72,


        [XmlEnum("73")]
        Item73,


        [XmlEnum("74")]
        Item74,


        [XmlEnum("75")]
        Item75,


        [XmlEnum("98")]
        Item98,


        [XmlEnum("99")]
        Item99,
    }


   
    [Serializable]
    [XmlType(Namespace = Namespaces.NFe, IncludeInSchema = false)]
    public enum ItemsChoiceType1
    {


        pPIS,


        qBCProd,


        vAliqProd,


        vBC,
    }


   
    [Serializable]


    [XmlType(AnonymousType = true, Namespace = Namespaces.NFe)]
    public class TNFeInfNFeDetImpostoPISPISQtde
    {


        public TNFeInfNFeDetImpostoPISPISQtdeCST CST { get; set; }


        public string qBCProd { get; set; }


        public string vAliqProd { get; set; }


        public string vPIS { get; set; }
    }


   
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = Namespaces.NFe)]
    public enum TNFeInfNFeDetImpostoPISPISQtdeCST
    {


        [XmlEnum("03")]
        Item03,
    }


   
    [Serializable]


    [XmlType(AnonymousType = true, Namespace = Namespaces.NFe)]
    public class TNFeInfNFeDetImpostoPISST
    {


        [XmlElement("pPIS", typeof(string))]
        [XmlElement("qBCProd", typeof(string))]
        [XmlElement("vAliqProd", typeof(string))]
        [XmlElement("vBC", typeof(string))]
        [XmlChoiceIdentifier("ItemsElementName")]
        public string[] Items { get; set; }


        [XmlElement("ItemsElementName")]
        [XmlIgnore()]
        public ItemsChoiceType2[] ItemsElementName { get; set; }


        public string vPIS { get; set; }
    }


   
    [Serializable]
    [XmlType(Namespace = Namespaces.NFe, IncludeInSchema = false)]
    public enum ItemsChoiceType2
    {


        pPIS,


        qBCProd,


        vAliqProd,


        vBC,
    }


   
    [Serializable]


    [XmlType(AnonymousType = true, Namespace = Namespaces.NFe)]
    public class TNFeInfNFeDetImpostoCOFINS
    {


        [XmlElement("COFINSAliq", typeof(TNFeInfNFeDetImpostoCOFINSCOFINSAliq))]
        [XmlElement("COFINSNT", typeof(TNFeInfNFeDetImpostoCOFINSCOFINSNT))]
        [XmlElement("COFINSOutr", typeof(TNFeInfNFeDetImpostoCOFINSCOFINSOutr))]
        [XmlElement("COFINSQtde", typeof(TNFeInfNFeDetImpostoCOFINSCOFINSQtde))]
        public object Item { get; set; }
    }


   
    [Serializable]


    [XmlType(AnonymousType = true, Namespace = Namespaces.NFe)]
    public class TNFeInfNFeDetImpostoCOFINSCOFINSAliq
    {


        public TNFeInfNFeDetImpostoCOFINSCOFINSAliqCST CST { get; set; }


        public string vBC { get; set; }


        public string pCOFINS { get; set; }


        public string vCOFINS { get; set; }
    }


   
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = Namespaces.NFe)]
    public enum TNFeInfNFeDetImpostoCOFINSCOFINSAliqCST
    {


        [XmlEnum("01")]
        Item01,


        [XmlEnum("02")]
        Item02,
    }


   
    [Serializable]


    [XmlType(AnonymousType = true, Namespace = Namespaces.NFe)]
    public class TNFeInfNFeDetImpostoCOFINSCOFINSNT
    {


        public TNFeInfNFeDetImpostoCOFINSCOFINSNTCST CST { get; set; }
    }


   
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = Namespaces.NFe)]
    public enum TNFeInfNFeDetImpostoCOFINSCOFINSNTCST
    {


        [XmlEnum("04")]
        Item04,


        [XmlEnum("06")]
        Item06,


        [XmlEnum("07")]
        Item07,


        [XmlEnum("08")]
        Item08,


        [XmlEnum("09")]
        Item09,
    }


   
    [Serializable]


    [XmlType(AnonymousType = true, Namespace = Namespaces.NFe)]
    public class TNFeInfNFeDetImpostoCOFINSCOFINSOutr
    {


        public TNFeInfNFeDetImpostoCOFINSCOFINSOutrCST CST { get; set; }


        [XmlElement("pCOFINS", typeof(string))]
        [XmlElement("qBCProd", typeof(string))]
        [XmlElement("vAliqProd", typeof(string))]
        [XmlElement("vBC", typeof(string))]
        [XmlChoiceIdentifier("ItemsElementName")]
        public string[] Items { get; set; }


        [XmlElement("ItemsElementName")]
        [XmlIgnore()]
        public ItemsChoiceType3[] ItemsElementName { get; set; }


        public string vCOFINS { get; set; }
    }


   
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = Namespaces.NFe)]
    public enum TNFeInfNFeDetImpostoCOFINSCOFINSOutrCST
    {


        [XmlEnum("49")]
        Item49,


        [XmlEnum("50")]
        Item50,


        [XmlEnum("51")]
        Item51,


        [XmlEnum("52")]
        Item52,


        [XmlEnum("53")]
        Item53,


        [XmlEnum("54")]
        Item54,


        [XmlEnum("55")]
        Item55,


        [XmlEnum("56")]
        Item56,


        [XmlEnum("60")]
        Item60,


        [XmlEnum("61")]
        Item61,


        [XmlEnum("62")]
        Item62,


        [XmlEnum("63")]
        Item63,


        [XmlEnum("64")]
        Item64,


        [XmlEnum("65")]
        Item65,


        [XmlEnum("66")]
        Item66,


        [XmlEnum("67")]
        Item67,


        [XmlEnum("70")]
        Item70,


        [XmlEnum("71")]
        Item71,


        [XmlEnum("72")]
        Item72,


        [XmlEnum("73")]
        Item73,


        [XmlEnum("74")]
        Item74,


        [XmlEnum("75")]
        Item75,


        [XmlEnum("98")]
        Item98,


        [XmlEnum("99")]
        Item99,
    }


   
    [Serializable]
    [XmlType(Namespace = Namespaces.NFe, IncludeInSchema = false)]
    public enum ItemsChoiceType3
    {


        pCOFINS,


        qBCProd,


        vAliqProd,


        vBC,
    }


   
    [Serializable]


    [XmlType(AnonymousType = true, Namespace = Namespaces.NFe)]
    public class TNFeInfNFeDetImpostoCOFINSCOFINSQtde
    {


        public TNFeInfNFeDetImpostoCOFINSCOFINSQtdeCST CST { get; set; }


        public string qBCProd { get; set; }


        public string vAliqProd { get; set; }


        public string vCOFINS { get; set; }
    }


   
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = Namespaces.NFe)]
    public enum TNFeInfNFeDetImpostoCOFINSCOFINSQtdeCST
    {


        [XmlEnum("03")]
        Item03,
    }


   
    [Serializable]


    [XmlType(AnonymousType = true, Namespace = Namespaces.NFe)]
    public class TNFeInfNFeDetImpostoCOFINSST
    {


        [XmlElement("pCOFINS", typeof(string))]
        [XmlElement("qBCProd", typeof(string))]
        [XmlElement("vAliqProd", typeof(string))]
        [XmlElement("vBC", typeof(string))]
        [XmlChoiceIdentifier("ItemsElementName")]
        public string[] Items { get; set; }


        [XmlElement("ItemsElementName")]
        [XmlIgnore()]
        public ItemsChoiceType4[] ItemsElementName { get; set; }


        public string vCOFINS { get; set; }
    }


   
    [Serializable]
    [XmlType(Namespace = Namespaces.NFe, IncludeInSchema = false)]
    public enum ItemsChoiceType4
    {


        pCOFINS,


        qBCProd,


        vAliqProd,


        vBC,
    }


   
    [Serializable]


    [XmlType(AnonymousType = true, Namespace = Namespaces.NFe)]
    public class TNFeInfNFeTotal
    {


        public TNFeInfNFeTotalICMSTot ICMSTot { get; set; }


        public TNFeInfNFeTotalISSQNtot ISSQNtot { get; set; }


        public TNFeInfNFeTotalRetTrib retTrib { get; set; }
    }


   
    [Serializable]


    [XmlType(AnonymousType = true, Namespace = Namespaces.NFe)]
    public class TNFeInfNFeTotalICMSTot
    {


        public string vBC { get; set; }


        public string vICMS { get; set; }


        public string vBCST { get; set; }


        public string vST { get; set; }


        public string vProd { get; set; }


        public string vFrete { get; set; }


        public string vSeg { get; set; }


        public string vDesc { get; set; }


        public string vII { get; set; }


        public string vIPI { get; set; }


        public string vPIS { get; set; }


        public string vCOFINS { get; set; }


        public string vOutro { get; set; }


        public string vNF { get; set; }


        public string vTotTrib { get; set; }
    }


   
    [Serializable]


    [XmlType(AnonymousType = true, Namespace = Namespaces.NFe)]
    public class TNFeInfNFeTotalISSQNtot
    {


        public string vServ { get; set; }


        public string vBC { get; set; }


        public string vISS { get; set; }


        public string vPIS { get; set; }


        public string vCOFINS { get; set; }
    }


   
    [Serializable]


    [XmlType(AnonymousType = true, Namespace = Namespaces.NFe)]
    public class TNFeInfNFeTotalRetTrib
    {


        public string vRetPIS { get; set; }


        public string vRetCOFINS { get; set; }


        public string vRetCSLL { get; set; }


        public string vBCIRRF { get; set; }


        public string vIRRF { get; set; }


        public string vBCRetPrev { get; set; }


        public string vRetPrev { get; set; }
    }


   
    [Serializable]


    [XmlType(AnonymousType = true, Namespace = Namespaces.NFe)]
    public class TNFeInfNFeTransp
    {


        public TNFeInfNFeTranspModFrete modFrete { get; set; }


        public TNFeInfNFeTranspTransporta transporta { get; set; }


        public TNFeInfNFeTranspRetTransp retTransp { get; set; }


        [XmlElement("balsa", typeof(string))]
        [XmlElement("reboque", typeof(TVeiculo))]
        [XmlElement("vagao", typeof(string))]
        [XmlElement("veicTransp", typeof(TVeiculo))]
        [XmlChoiceIdentifier("ItemsElementName")]
        public object[] Items { get; set; }


        [XmlElement("ItemsElementName")]
        [XmlIgnore()]
        public ItemsChoiceType5[] ItemsElementName { get; set; }


        [XmlElement("vol")]
        public TNFeInfNFeTranspVol[] vol { get; set; }
    }


   
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = Namespaces.NFe)]
    public enum TNFeInfNFeTranspModFrete
    {


        [XmlEnum("0")]
        Item0,


        [XmlEnum("1")]
        Item1,


        [XmlEnum("2")]
        Item2,


        [XmlEnum("9")]
        Item9,
    }


   
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = Namespaces.NFe)]
    public class TNFeInfNFeTranspTransporta
    {


        [XmlElement("CNPJ", typeof(string))]
        [XmlElement("CPF", typeof(string))]
        [XmlChoiceIdentifier("ItemElementName")]
        public string Item { get; set; }


        [XmlIgnore()]
        public TipoDocumento ItemElementName { get; set; }


        public string xNome { get; set; }


        public string IE { get; set; }


        public string xEnder { get; set; }


        public string xMun { get; set; }


        public TUf UF { get; set; }


        [XmlIgnore()]
        public bool UFSpecified { get; set; }
    }

    

   
    [Serializable]


    [XmlType(AnonymousType = true, Namespace = Namespaces.NFe)]
    public class TNFeInfNFeTranspRetTransp
    {


        public string vServ { get; set; }


        public string vBCRet { get; set; }


        public string pICMSRet { get; set; }


        public string vICMSRet { get; set; }


        public TCfopTransp CFOP { get; set; }


        public string cMunFG { get; set; }
    }


   
    [Serializable]
    [XmlType(Namespace = Namespaces.NFe)]
    public enum TCfopTransp
    {


        [XmlEnum("5351")]
        Item5351,


        [XmlEnum("5352")]
        Item5352,


        [XmlEnum("5353")]
        Item5353,


        [XmlEnum("5354")]
        Item5354,


        [XmlEnum("5355")]
        Item5355,


        [XmlEnum("5356")]
        Item5356,


        [XmlEnum("5357")]
        Item5357,


        [XmlEnum("5359")]
        Item5359,


        [XmlEnum("5360")]
        Item5360,


        [XmlEnum("5931")]
        Item5931,


        [XmlEnum("5932")]
        Item5932,


        [XmlEnum("6351")]
        Item6351,


        [XmlEnum("6352")]
        Item6352,


        [XmlEnum("6353")]
        Item6353,


        [XmlEnum("6354")]
        Item6354,


        [XmlEnum("6355")]
        Item6355,


        [XmlEnum("6356")]
        Item6356,


        [XmlEnum("6357")]
        Item6357,


        [XmlEnum("6359")]
        Item6359,


        [XmlEnum("6360")]
        Item6360,


        [XmlEnum("6931")]
        Item6931,


        [XmlEnum("6932")]
        Item6932,


        [XmlEnum("7358")]
        Item7358,
    }


   
    [Serializable]
    [XmlType(Namespace = Namespaces.NFe, IncludeInSchema = false)]
    public enum ItemsChoiceType5
    {


        balsa,


        reboque,


        vagao,


        veicTransp,
    }


   
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = Namespaces.NFe)]
    public class TNFeInfNFeTranspVol
    {


        public string qVol { get; set; }


        public string esp { get; set; }


        public string marca { get; set; }


        public string nVol { get; set; }


        public string pesoL { get; set; }


        public string pesoB { get; set; }


        [XmlElement("lacres")]
        public TNFeInfNFeTranspVolLacres[] lacres { get; set; }
    }


   
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = Namespaces.NFe)]
    public class TNFeInfNFeTranspVolLacres
    {
        public string nLacre { get; set; }
    }


   
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = Namespaces.NFe)]
    public class TNFeInfNFeCobr
    {


        public TNFeInfNFeCobrFat fat { get; set; }


        [XmlElement("dup")]
        public TNFeInfNFeCobrDup[] dup { get; set; }
    }


   
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = Namespaces.NFe)]
    public class TNFeInfNFeCobrFat
    {


        public string nFat { get; set; }


        public string vOrig { get; set; }


        public string vDesc { get; set; }


        public string vLiq { get; set; }
    }


   
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = Namespaces.NFe)]
    public class TNFeInfNFeCobrDup
    {


        public string nDup { get; set; }


        public string dVenc { get; set; }


        public string vDup { get; set; }
    }


   
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = Namespaces.NFe)]
    public class TNFeInfNFeInfAdic
    {


        public string infAdFisco { get; set; }


        public string infCpl { get; set; }


        [XmlElement("obsCont")]
        public TNFeInfNFeInfAdicObsCont[] obsCont { get; set; }


        [XmlElement("obsFisco")]
        public TNFeInfNFeInfAdicObsFisco[] obsFisco { get; set; }


        [XmlElement("procRef")]
        public TNFeInfNFeInfAdicProcRef[] procRef { get; set; }
    }


   
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = Namespaces.NFe)]
    public class TNFeInfNFeInfAdicObsCont
    {


        public string xTexto { get; set; }


        [XmlAttribute()]
        public string xCampo { get; set; }
    }


   
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = Namespaces.NFe)]
    public class TNFeInfNFeInfAdicObsFisco
    {

        public string xTexto { get; set; }

        [XmlAttribute()]
        public string xCampo { get; set; }
    }


   
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = Namespaces.NFe)]
    public class TNFeInfNFeInfAdicProcRef
    {
        public string nProc { get; set; }
        public TNFeInfNFeInfAdicProcRefIndProc indProc { get; set; }
    }


   
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = Namespaces.NFe)]
    public enum TNFeInfNFeInfAdicProcRefIndProc
    {


        [XmlEnum("0")]
        Item0,


        [XmlEnum("1")]
        Item1,


        [XmlEnum("2")]
        Item2,


        [XmlEnum("3")]
        Item3,


        [XmlEnum("9")]
        Item9,
    }


   
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = Namespaces.NFe)]
    public class TNFeInfNFeExporta
    {
        public TUf UFEmbarq { get; set; }
        public string xLocEmbarq { get; set; }
    }


    [Serializable]
    [XmlType(AnonymousType = true, Namespace = Namespaces.NFe)]
    public class TNFeInfNFeCompra
    {
        public string xNEmp { get; set; }
        public string xPed { get; set; }
        public string xCont { get; set; }
    }


   
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = Namespaces.NFe)]
    public class TNFeInfNFeCana
    {


        public string safra { get; set; }
        public string @ref { get; set; }


        [XmlElement("forDia")]
        public TNFeInfNFeCanaForDia[] forDia { get; set; }


        public string qTotMes { get; set; }
        public string qTotAnt { get; set; }
        public string qTotGer { get; set; }


        [XmlElement("deduc")]
        public TNFeInfNFeCanaDeduc[] deduc { get; set; }


        public string vFor { get; set; }
        public string vTotDed { get; set; }
        public string vLiqFor { get; set; }
    }


   
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = Namespaces.NFe)]
    public class TNFeInfNFeCanaForDia
    {

        public string qtde { get; set; }
        [XmlAttribute()]
        public string dia { get; set; }
    }


   
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = Namespaces.NFe)]
    public class TNFeInfNFeCanaDeduc
    {
        public string xDed { get; set; }
        public string vDed { get; set; }
    }

}