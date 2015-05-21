//Tipos do esquema resNFe_v1.00.xsd
using NFeSharp.Esquemas.TiposBasicos;
using System;
using System.Xml.Serialization;

namespace NFeSharp.Esquemas.v1_00 
{
    
    /// <summary>
    /// Schema da estrutura XML gerada pelo Ambiente Nacional com o conjunto de informações resumidas de uma NF-e
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = Namespaces.NFe)]
    [XmlRootAttribute(Namespace = Namespaces.NFe, IsNullable = false)]
    public class resNFe
    {
        /// <summary>
        /// Chave de acesso da NF-e
        /// </summary>
        public string chNFe { get; set; }

        /// <summary>
        /// CNPJ ou CPF do Emitente
        /// </summary>
        [XmlElement("CNPJ", typeof(string))]
        [XmlElement("CPF", typeof(string))]
        [XmlChoiceIdentifierAttribute("TipoDocumento")]
        public string CnpjCpf { get; set; }

        
        [XmlIgnore]
        public TipoDocumento TipoDocumento { get; set; }

        /// <summary>
        /// Razão Social ou Nome do emitente
        /// </summary>
        public string xNome { get; set; }

        /// <summary>
        /// Inscrição Estadual do Emitente
        /// </summary>
        public string IE { get; set; }

        /// <summary>
        /// Data e Hora de emissão do Documento Fiscal (AAAA-MM-DDThh:mm:ssTZD) ex.: 2012-09-01T13:00:00-03:00
        /// </summary>
        public DateTime dhEmi { get; set; }

        
        /// <summary>
        /// Tipo do Documento Fiscal (0 - entrada; 1 - saída)
        /// </summary>
        public resNFeTpNF tpNF { get; set; }

        /// <summary>
        /// Valor Total da NF-e
        /// </summary>
        public string vNF { get; set; }

        /// <summary>
        /// Digest Value da NF-e processada. Utilizado para conferir a integridade da NF-e original
        /// </summary>
        [XmlElement(DataType = "base64Binary")]
        public byte[] digVal { get; set; }

        
        /// <summary>
        /// Data e hora de autorização da NF-e, no formato AAAA-MM-DDTHH:MM:SSTZD
        /// </summary>
        public DateTime dhRecbto { get; set; }

        
        /// <summary>
        /// Número do Protocolo de Status da NF-e. 1 posição (1 – Secretaria de Fazenda Estadual 2 – Receita Federal); 2 - códiga da UF - 2 posições ano; 10 seqüencial no ano<
        /// </summary>
        public string nProt { get; set; }

        /// <summary>
        ///  Situação da NF-e
        /// </summary>
        public resNFeCSitNFe cSitNFe { get; set; }

        /// <summary>
        /// Tipo Versão do leiate resNFe
        /// </summary>
        [XmlAttribute]
        public TVerResNFe versao { get; set; }
    }
        
    
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = Namespaces.NFe)]
    public enum resNFeTpNF
    {        
        [XmlEnumAttribute("0")]
        Entrada = 0,
                
        [XmlEnumAttribute("1")]
        Saida = 1,
    } 
    
}