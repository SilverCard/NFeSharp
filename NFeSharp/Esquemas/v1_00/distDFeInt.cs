//Tipos do esquema distDFeInt_v1.00.xsd
using NFeSharp.Esquemas.TiposBasicos;
using System;
using System.Xml.Serialization; 

namespace NFeSharp.Esquemas.v1_00
{    
    
    /// <summary>
    /// Schema de pedido de distribuição de DF-e de interesse
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="http://www.portalfiscal.inf.br/nfe")]
    [XmlRootAttribute(Namespace="http://www.portalfiscal.inf.br/nfe", IsNullable=false)]
    public partial class distDFeInt
    {
        /// <summary>
        /// Identificação do Ambiente
        /// </summary>
        public TAmb tpAmb { get; set; }

        /// <summary>
        /// Código da UF do Autor
        /// </summary>
        public UnidadesFederativas cUFAutor { get; set; }            
        
        /// <summary>
        /// CPF ou CNPJ do interessado no DF-e
        /// </summary>
        [XmlElement("CNPJ", typeof(string))]
        [XmlElement("CPF", typeof(string))]
        [XmlChoiceIdentifierAttribute("TipoDocumento")]
        public string CnpjCpf { get; set; }        
        
        [XmlIgnoreAttribute()]
        public TipoDocumento TipoDocumento { get; set; }    
        
        
        [XmlElement("consNSU", typeof(consNSU))]
        [XmlElement("distNSU", typeof(distNSU))]
        public object Item1 { get; set; }            
        
        [XmlAttributeAttribute()]
        public TVerDistDFe versao { get; set; }    
    }
    
    /// <summary>
    /// Grupo para consultar um DF-e a partir de um NSU específico
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType=true, Namespace="http://www.portalfiscal.inf.br/nfe")]
    public partial class consNSU {
        
        /// <summary>
        /// úmero Sequencial Único. Geralmente esta consulta será utilizada quando identificado pelo interessado um NSU faltante. O Web Service retornará o documento ou informará que o NSU não existe no Ambiente Nacional. Assim, esta consulta fechará a lacuna do NSU identificado como faltante.
        /// </summary>
        [XmlElement(DataType="token")]
        public string NSU { get; set; }   
    }
    
    
    /// <summary>
    /// Grupo para distribuir DF-e de interesse
    /// </summary>
    [Serializable]   
    [XmlType(AnonymousType=true, Namespace="http://www.portalfiscal.inf.br/nfe")]
    public partial class distNSU {
        
        /// <summary>
        /// Último NSU recebido pelo ator. Caso seja informado com zero, ou com um NSU muito antigo, a consulta retornará unicamente as informações resumidas e documentos fiscais eletrônicos que tenham sido recepcionados pelo Ambiente Nacional nos últimos 3 meses.
        /// </summary>
        [XmlElement(DataType="token")]
        public string ultNSU { get; set; }   
    }    
    
    
    [Serializable]
    [XmlType(Namespace="http://www.portalfiscal.inf.br/nfe")]
    public enum TVerDistDFe {        
        
        [XmlEnumAttribute("1.00")]
        v1_00,
    }
}
