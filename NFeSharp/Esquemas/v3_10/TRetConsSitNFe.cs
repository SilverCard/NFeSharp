using NFeSharp.Esquemas.TiposBasicos;
using System;
using System.Xml.Serialization;

namespace NFeSharp.Esquemas.v3_10
{
    [Serializable]
    [XmlType(Namespace = Namespaces.NFe)]
    [XmlRoot("retConsSitNFe", Namespace = Namespaces.NFe, IsNullable = false)]
    public class TRetConsSitNFe
    {

        public TAmb tpAmb { get; set; }
        public string verAplic { get; set; }     

        /// <summary>
        /// Código do resultado da solicitação, 100 = NFe autorizada, 101 = NFe Cancelada, 102 = NFe inutilizada, 110 = NFe denegada
        /// </summary>
        public string cStat { get; set; }

        public string xMotivo { get; set; }

        public UnidadesFederativas cUF { get; set; }

        public DateTime dhRecbto { get; set; }

        public string chNFe { get; set; }

        public TProtNFe protNFe { get; set; }

        public TRetCancNFe retCancNFe { get; set; } 
        
        [XmlElement("procEventoNFe")]
        public TProcEvento[] procEventoNFe { get; set; }  
        
        [XmlAttribute]
        public TVerConsSitNFe versao { get; set; }     
    }
    

    [Serializable]
    [XmlType(Namespace = Namespaces.NFe)]
    public class TProtNFe
    {

        public TProtNFeInfProt infProt { get; set; }   

        
        [XmlElementAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
        public NFeSharp.Esquemas.TiposBasicos.SignatureType Signature { get; set; }     

        
        [XmlAttribute]
        public string versao { get; set; }     
    }

    

    [Serializable]
    [XmlType(AnonymousType = true, Namespace = Namespaces.NFe)]
    public class TProtNFeInfProt
    {


        public TAmb tpAmb { get; set; }

        public string verAplic { get; set; }


        public string chNFe { get; set; }

        public DateTime dhRecbto { get; set; }

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
    public class TRetEvento
    {

        
        public TRetEventoInfEvento infEvento{get;set;}

        
        [XmlElementAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
        public NFeSharp.Esquemas.TiposBasicos.SignatureType Signature{get;set;}

        
        [XmlAttribute()]
        public string versao{get;set;}
    }

    
    
    [Serializable]


    [XmlType(AnonymousType = true, Namespace = Namespaces.NFe)]
    public class TRetEventoInfEvento
    {

        
        public TAmb tpAmb{get;set;}

        
        public string verAplic{get;set;}

        
        public TCOrgaoIBGE cOrgao{get;set;}

        
        public string cStat{get;set;}

        
        public string xMotivo{get;set;}

        
        public string chNFe{get;set;}

        
        public string tpEvento{get;set;}

        
        public string xEvento{get;set;}

        
        public string nSeqEvento{get;set;}

        
        [XmlElementAttribute("CNPJDest", typeof(string))]
        [XmlElementAttribute("CPFDest", typeof(string))]
        [XmlChoiceIdentifierAttribute("ItemElementName")]
        public string Item{get;set;}

        
        [XmlIgnoreAttribute()]
        public ItemChoiceType1 ItemElementName{get;set;}

        
        public string emailDest{get;set;}

        
        public string dhRegEvento{get;set;}

        
        public string nProt{get;set;}

        
        [XmlAttribute(DataType = "ID")]
        public string Id{get;set;}
    }

    
    
    
    
    
    [Serializable]
    [XmlType(Namespace = Namespaces.NFe, IncludeInSchema = false)]
    public enum ItemChoiceType1
    {
        
        CNPJDest,                
        CPFDest,
    }


    
    
    [Serializable]


    [XmlType(Namespace = Namespaces.NFe)]
    public partial class TEvento
    {

        
        public TEventoInfEvento infEvento{get;set;}

        
        [XmlElementAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
        public NFeSharp.Esquemas.TiposBasicos.SignatureType Signature{get;set;}

        
        [XmlAttribute()]
        public string versao{get;set;}
    }

    
    
    [Serializable]


    [XmlType(AnonymousType = true, Namespace = Namespaces.NFe)]
    public partial class TEventoInfEvento
    {

        
        public TCOrgaoIBGE cOrgao{get;set;}

        
        public TAmb tpAmb{get;set;}

        
        [XmlElementAttribute("CNPJ", typeof(string))]
        [XmlElementAttribute("CPF", typeof(string))]
        [XmlChoiceIdentifierAttribute("ItemElementName")]
        public string Item{get;set;}

        
        [XmlIgnoreAttribute()]
        public ItemChoiceType ItemElementName{get;set;}

        
        public string chNFe{get;set;}

        
        public DateTime dhEvento{get;set;}

        
        public string tpEvento{get;set;}

        
        public string nSeqEvento{get;set;}

        
        public string verEvento{get;set;}

        
        public TEventoInfEventoDetEvento detEvento{get;set;}

        
        [XmlAttribute(DataType = "ID")]
        public string Id{get;set;}
    }

    
    
    [Serializable]
    [XmlType(Namespace = Namespaces.NFe, IncludeInSchema = false)]
    public enum ItemChoiceType
    {

        
        CNPJ,

        
        CPF,
    }

    
    
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = Namespaces.NFe)]
    public partial class TEventoInfEventoDetEvento
    {

        
        [XmlAnyElementAttribute()]
        public System.Xml.XmlElement[] Any{get;set;}

        
        [XmlAnyAttributeAttribute()]
        public System.Xml.XmlAttribute[] AnyAttr{get;set;}
    }

    
    
    [Serializable]
    [XmlType(Namespace = Namespaces.NFe)]
    public partial class TProcEvento
    {

        
        public TEvento evento{get;set;}

        
        public TRetEvento retEvento{get;set;}

        
        [XmlAttribute()]
        public string versao{get;set;}
    }

    
    
    [Serializable]
    [XmlType(Namespace = Namespaces.NFe)]
    public partial class TRetCancNFe
    {

        
        public TRetCancNFeInfCanc infCanc{get;set;}

        
        [XmlElementAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
        public NFeSharp.Esquemas.TiposBasicos.SignatureType Signature{get;set;}

        
        [XmlAttribute()]
        public string versao{get;set;}
    }

    
    
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = Namespaces.NFe)]
    public partial class TRetCancNFeInfCanc
    {

        
        public TAmb tpAmb{get;set;}

        
        public string verAplic{get;set;}

        
        public string cStat{get;set;}

        
        public string xMotivo{get;set;}

        
        public UnidadesFederativas cUF{get;set;}

        
        public string chNFe{get;set;}

        
        public System.DateTime dhRecbto{get;set;}

        
        [XmlIgnoreAttribute()]
        public bool dhRecbtoSpecified{get;set;}

        
        public string nProt{get;set;}

        
        [XmlAttribute(DataType = "ID")]
        public string Id{get;set;}
    }


    
}