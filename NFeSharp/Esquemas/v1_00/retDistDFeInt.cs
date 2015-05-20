////Tipos do esquema retDistDFeInt_v1.00.xsd
using NFeSharp.Esquemas.TiposBasicos;
using System;
using System.Xml.Serialization;


namespace NFeSharp.Esquemas.v1_00
{
    /// <summary>
    /// Schema do resultado do pedido de distribuição de DF-e de interesse
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    [XmlRootAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe", IsNullable = false)]
    public class retDistDFeInt
    {

        /// <summary>
        /// Identificação do Ambiente
        /// </summary>
        public TAmb tpAmb { get; set; }

        /// <summary>
        /// Versão do Web Service NFeDistribuicaoDFe
        /// </summary>
        public string verAplic { get; set; }

        /// <summary>
        /// Código do status de processamento da requisição
        /// </summary>
        public string cStat { get; set; }

        /// <summary>
        /// Descrição literal do status do processamento da requisição
        /// </summary>
        public string xMotivo { get; set; }

        /// <summary>
        /// Data e Hora de processamento da requisição no formato AAAA-MM-DDTHH:MM:SS
        /// </summary>
        public DateTime dhResp { get; set; }

        /// <summary>
        /// Último NSU pesquisado no Ambiente Nacional. Se for o caso, o solicitante pode continuar a consulta a partir deste NSU para obter novos resultados.
        /// </summary>
        [XmlElement(DataType = "token")]
        public string ultNSU { get; set; }

        /// <summary>
        /// Maior NSU existente no Ambiente Nacional para o CNPJ/CPF informado
        /// </summary>
        [XmlElement(DataType = "token")]
        public string maxNSU { get; set; }

        /// <summary>
        /// Conjunto de informações resumidas e documentos fiscais eletrônicos de interesse da pessoa ou empresa.
        /// </summary>
        public loteDistDFeInt loteDistDFeInt { get; set; }


        [XmlAttribute]
        public TVerDistDFe versao { get; set; }
    }
    
    
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum resNFeCSitNFe
    {        
        [XmlEnumAttribute("1")]
        Autorizado,
        
        [XmlEnumAttribute("2")]
        Denegado,
    }
    
    
    [Serializable]
    [XmlType(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TVerResNFe
    {

        
        [XmlEnumAttribute("1.00")]
        v1_00,
    }        
    
    
    [Serializable]   
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public class loteDistDFeInt
    {
        
        [XmlElement("docZip")]
        public DocZip[] docZip;
    }

    
    /// <summary>
    /// Informação resumida ou documento fiscal eletrônico de interesse da pessoa ou empresa. O conteúdo desta tag estará compactado no padrão gZip. O tipo do campo é base64Binary.
    /// </summary>
    [Serializable]   
    [XmlType(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class DocZip
    {

        /// <summary>
        /// NSU do documento fiscal
        /// </summary>
        [XmlAttributeAttribute(DataType = "token")]
        public string NSU { get; set; }

        /// <summary>
        /// Identificação do Schema XML que será utilizado para validar o XML existente no conteúdo da tag docZip. Vai identificar o tipo do documento e sua versão. Exemplos: resNFe_v1.00.xsd, procNFe_v3.10.xsd, resEvento_1.00.xsd, procEventoNFe_v1.00.xsd
        /// </summary>
        [XmlAttribute]
        public string schema { get; set; }

        
        [XmlText(DataType = "base64Binary")]
        public byte[] Conteudo { get; set; }
    }

    
    

    
}