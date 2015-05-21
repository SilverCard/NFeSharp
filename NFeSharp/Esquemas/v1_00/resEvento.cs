//Tipos do esquema resEvento_v1.00.xsd
using NFeSharp.Esquemas.TiposBasicos;
using System;
using System.Xml.Serialization;
    

namespace NFeSharp.Esquemas.v1_00
{    
    /// <summary>
    /// Schema da estrutura XML gerada pelo Ambiente Nacional com o conjunto de informações resumidas de um evento de NF-e
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = Namespaces.NFe)]
    [XmlRootAttribute(Namespace = Namespaces.NFe, IsNullable = false)]
    public partial class resEvento
    {

        /// <summary>
        /// Código do órgão de recepção do Evento. Utilizar a Tabela do IBGE extendida, utilizar 91 para identificar o Ambiente Nacional
        /// </summary>
        public TCOrgaoIBGE cOrgao { get; set; }

        /// <summary>
        /// CNPJ ou CPF do Emitente
        /// </summary>
        [XmlElement("CNPJ", typeof(string))]
        [XmlElement("CPF", typeof(string))]
        [XmlChoiceIdentifierAttribute("TipoDocumento")]
        public string CnpjCpf { get; set; }

        
        [XmlIgnoreAttribute()]
        public TipoDocumento TipoDocumento;

        /// <summary>
        /// Chave de acesso da NF-e
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
        /// Seqüencial do evento para o mesmo tipo de evento.  Para maioria dos eventos será 1, nos casos em que possa existir mais de um evento, como é o caso da carta de correção, o autor do evento deve numerar de forma seqüencial
        /// </summary>
        public string nSeqEvento { get; set; }

        
        /// <summary>
        /// Descrição do Evento
        /// </summary>
        public string xEvento { get; set; }

        /// <summary>
        /// Data e hora de autorização do evento no formato AAAA-MM-DDTHH:MM:SSTZD
        /// </summary>
        public DateTime dhRecbto { get; set; }

        
        /// <summary>
        /// Número do Protocolo do evento. 1 posição (1 – Secretaria de Fazenda Estadual 2 – Receita Federal); 2 - códiga da UF - 2 posições ano; 10 seqüencial no ano
        /// </summary>
        public string nProt { get; set; }

        /// <summary>
        /// Tipo Versão do leiate resNFe
        /// </summary>
        [XmlAttribute]
        public TVerResEvento versao { get; set; }
    } 
    
    
    [Serializable]
    [XmlType(Namespace = Namespaces.NFe)]
    public enum TVerResEvento
    {        
        [XmlEnumAttribute("1.00")]
        v1_00,
    }
    
}