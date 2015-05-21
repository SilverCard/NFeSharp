//Tipos do esquema procEventoNFe_v1.00.xsd
using System.Xml.Serialization;
using NFeSharp.Esquemas.TiposBasicos;
using System;

namespace NFeSharp.Esquemas.v1_00
{    
   
    [Serializable]
    [XmlType(Namespace = Namespaces.NFe)]
    [XmlRoot("procEventoNFe", Namespace = Namespaces.NFe, IsNullable = false)]
    public class TProcEvento
    {
        
        public TEvento evento { get; set; }        
        public TRetEvento retEvento { get; set; }
        
        [XmlAttribute]
        public string versao { get; set; }
    }


    [Serializable]
    [XmlType(Namespace = Namespaces.NFe)]
    public class TEvento
    {

        public infEvento infEvento { get; set; }

        
        [XmlElement(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
        public SignatureType Signature { get; set; }

        
        [XmlAttribute]
        public string versao { get; set; }
    }

    
   
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = Namespaces.NFe)]
    public class infEvento
    {

        /// <summary>
        /// Código do órgão de recepção do Evento. Utilizar a Tabela do IBGE extendida, utilizar 90 para identificar o Ambiente Nacional
        /// </summary>
        public TCOrgaoIBGE cOrgao { get; set; }

        /// <summary>
        /// Identificação do Ambiente
        /// </summary>
        public TAmb tpAmb { get; set; }

        /// <summary>
        /// Identificação do  autor do evento
        /// </summary>
        [XmlElementAttribute("CNPJ", typeof(string))]
        [XmlElementAttribute("CPF", typeof(string))]
        [XmlChoiceIdentifierAttribute("TipoDocumento")]
        public string Documento { get; set; }

        
        [XmlIgnore]
        public TipoDocumento TipoDocumento { get; set; }

        /// <summary>
        /// Chave de Acesso da NF-e vinculada ao evento
        /// </summary>
        public string chNFe { get; set; }

        /// <summary>
        /// Data e Hora do Evento, formato UTC (AAAA-MM-DDThh:mm:ssTZD, onde TZD = +hh:mm ou -hh:mm)
        /// </summary>
        public DateTime dhEvento { get; set; }

        /// <summary>
        /// Tipo do Evento
        /// </summary>
        public string tpEvento { get; set; }

        /// <summary>
        /// Seqüencial do evento para o mesmo tipo de evento.  Para maioria dos eventos será 1, nos casos em que possa existir mais de um evento, como é o caso da carta de correção, o autor do evento deve numerar de forma seqüencial.
        /// </summary>
        public string nSeqEvento{ get; set; }

        
        /// <summary>
        /// Versão do Tipo do Evento
        /// </summary>
        public string verEvento{ get; set; }

        /// <summary>
        /// informações específicas do evento
        /// </summary>
        public detEvento detEvento { get; set; }

        /// <summary>
        /// Identificador da TAG a ser assinada, a regra de formação do Id é: “ID” + tpEvento +  chave da NF-e + nSeqEvento
        /// </summary>
        [XmlAttribute(DataType = "ID")]
        public string Id { get; set; }
    }
        
   
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = Namespaces.NFe)]
    public class detEvento
    {        
        [XmlAnyElement]
        public System.Xml.XmlElement[] Any { get; set; }
        
        [XmlAnyAttribute]
        public System.Xml.XmlAttribute[] AnyAttr { get; set; }
    }

    
    /// <summary>
    /// Tipo retorno do Evento
    /// </summary>
    [Serializable]
    [XmlType(Namespace = Namespaces.NFe)]
    public class TRetEvento
    {
        public TRetEventoInfEvento infEvento { get; set; }
        
        [XmlElement(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
        public SignatureType Signature { get; set; }

        
        [XmlAttribute]
        public string versao { get; set; }
    }    
   
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = Namespaces.NFe)]
    public class TRetEventoInfEvento
    {

        public TAmb tpAmb { get; set; }
        public string verAplic { get; set; }
        public TCOrgaoIBGE cOrgao { get; set; }
        public string cStat { get; set; }
        public string xMotivo { get; set; }
        public string chNFe { get; set; }
        public string tpEvento { get; set; }
        public string xEvento { get; set; }
        public string nSeqEvento { get; set; }
        public TCOrgaoIBGE cOrgaoAutor { get; set; }
        
        [XmlIgnore]
        public bool cOrgaoAutorSpecified { get; set; }

        
        [XmlElement("CNPJDest", typeof(string))]
        [XmlElement("CPFDest", typeof(string))]
        [XmlChoiceIdentifier("TipoDocumentoDestinatario")]
        public string DocumentoDestinatari { get; set; }

        
        [XmlIgnore]
        public TipoDocumentoDestinatario TipoDocumentoDestinatario { get; set; }


        public string emailDest { get; set; }
        public string dhRegEvento { get; set; }
        public string nProt { get; set; }
        
        [XmlAttribute(DataType = "ID")]
        public string Id { get; set; }
    }

    
   
    [Serializable]
    [XmlType(Namespace = Namespaces.NFe, IncludeInSchema = false)]
    public enum TipoDocumentoDestinatario
    {        
        CNPJDest,        
        CPFDest,
    }    
    
}