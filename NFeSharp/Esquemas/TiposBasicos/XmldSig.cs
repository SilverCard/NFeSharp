// Tipos para o arquivo xmldsig-core-schema_v1.01.xsd
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NFeSharp.Esquemas.TiposBasicos
{
    [Serializable]
    [XmlType(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    [XmlRootAttribute("Signature", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
    public class SignatureType
    {
        public SignedInfoType SignedInfo { get; set; }
        public SignatureValueType SignatureValue { get; set; }
        public KeyInfoType KeyInfo { get; set; }
        [XmlAttributeAttribute(DataType = "ID")]
        public string Id { get; set; }
    }



    [Serializable]
    [XmlType(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public class SignedInfoType
    {
        public SignedInfoTypeCanonicalizationMethod CanonicalizationMethod { get; set; }
        public SignedInfoTypeSignatureMethod SignatureMethod { get; set; }
        public ReferenceType Reference { get; set; }
        [XmlAttributeAttribute(DataType = "ID")]
        public string Id { get; set; }
    }



    [Serializable]
    public class SignedInfoTypeCanonicalizationMethod
    {

        [XmlAttributeAttribute(DataType = "anyURI")]
        public string Algorithm { get; set; }

        public SignedInfoTypeCanonicalizationMethod()
        {
            this.Algorithm = "http://www.w3.org/TR/2001/REC-xml-c14n-20010315";
        }
    }





    [Serializable]
    [XmlType(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public class ReferenceType
    {
        [XmlArrayItemAttribute("Transform", IsNullable = false)]
        public TransformType[] Transforms { get; set; }


        public ReferenceTypeDigestMethod DigestMethod { get; set; }

        [XmlElement(DataType = "base64Binary")]
        public byte[] DigestValue { get; set; }


        [XmlAttributeAttribute(DataType = "ID")]
        public string Id { get; set; }


        [XmlAttributeAttribute(DataType = "anyURI")]
        public string URI { get; set; }


        [XmlAttributeAttribute(DataType = "anyURI")]
        public string Type { get; set; }
    }



    [Serializable]
    [XmlType(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public class TransformType
    {


        [XmlElement("XPath")]
        public string[] XPath { get; set; }


        [XmlAttributeAttribute()]
        public TTransformURI Algorithm { get; set; }
    }



    [Serializable]
    [XmlType(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public enum TTransformURI
    {

        [XmlEnumAttribute("http://www.w3.org/2000/09/xmldsig#enveloped-signature")]
        httpwwww3org200009xmldsigenvelopedsignature,

        [XmlEnumAttribute("http://www.w3.org/TR/2001/REC-xml-c14n-20010315")]
        httpwwww3orgTR2001RECxmlc14n20010315,
    }



    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public class ReferenceTypeDigestMethod
    {


        [XmlAttributeAttribute(DataType = "anyURI")]
        public string Algorithm { get; set; }

        public ReferenceTypeDigestMethod()
        {
            this.Algorithm = "http://www.w3.org/2000/09/xmldsig#sha1";
        }
    }



    [Serializable]
    [XmlType(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public class SignatureValueType
    {


        [XmlAttributeAttribute(DataType = "ID")]
        public string Id { get; set; }


        [XmlTextAttribute(DataType = "base64Binary")]
        public byte[] Value { get; set; }
    }



    [Serializable]
    [XmlType(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public class KeyInfoType
    {
        public X509DataType X509Data { get; set; }

        [XmlAttributeAttribute(DataType = "ID")]
        public string Id { get; set; }
    }



    [Serializable]
    [XmlType(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public class X509DataType
    {
        [XmlElement(DataType = "base64Binary")]
        public byte[] X509Certificate { get; set; }
    }

    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public class SignedInfoTypeSignatureMethod
    {


        [XmlAttributeAttribute(DataType = "anyURI")]
        public string Algorithm;

        public SignedInfoTypeSignatureMethod()
        {
            this.Algorithm = "http://www.w3.org/2000/09/xmldsig#rsa-sha1";
        }
    }
}
