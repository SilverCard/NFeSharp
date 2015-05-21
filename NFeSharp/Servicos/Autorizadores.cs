using NFeSharp.Servicos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace NFeSharp.Servicos
{
    [Serializable]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public class Autorizadores
    {
        [XmlElement("Autorizador", Form = XmlSchemaForm.Unqualified)]
        public Autorizador[] ColecaoAutorizadores { get; set; }

        public static Autorizadores LerDeArquivo(String caminho)
        {
            Autorizadores autorizadores = null;
            XmlSerializer serializer = new XmlSerializer(typeof(Autorizadores));

            using (StreamReader reader = new StreamReader(caminho))
            {
                autorizadores = (Autorizadores)serializer.Deserialize(reader);
            }

            return autorizadores;
        }
    }


    [Serializable]
    [XmlType(AnonymousType = true)]
    public class Autorizador
    {

        [XmlArray(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [XmlArrayItem("Servico", typeof(Servico), Form = XmlSchemaForm.Unqualified)]
        public Servico[] Servicos;

        [XmlArray(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [XmlArrayItem("Utilizadores", typeof(Utilizadores), Form = XmlSchemaForm.Unqualified, ElementName = "UF")]
        public UnidadesFederativas[] Utilizadores;

        [XmlAttribute]
        public string ID;

        [XmlAttribute]
        public string Nome;

        [XmlAttribute]
        public Boolean Contigencia;

        public override string ToString()
        {
            return String.Format("{0}:{1}", ID, Nome);
        }

    }

    /// <summary>
    /// Enumeração contendo as Unidades Federativas do Brasil, associadas ao seu respectivo código do IBGE.
    /// </summary>
    public enum Utilizadores : int
    {
        // Região Norte      
        RO = 11,
        AC = 12,
        AM = 13,
        RR = 14,
        PA = 15,
        AP = 16,
        TO = 17,

        // Região Nordeste
        MA = 21,
        PI = 22,
        CE = 23,
        RN = 24,
        PB = 25,
        PE = 26,
        AL = 27,
        SE = 28,
        BA = 29,

        // Região Sudeste
        MG = 31,
        ES = 32,
        RJ = 33,
        SP = 35,

        // Região Sul
        PR = 41,
        SC = 42,
        RS = 43,

        // Região Centro-Oeste
        MS = 50,
        MT = 51,
        GO = 52,
        DF = 53,

    }

    [Serializable]
    [XmlType(AnonymousType = true)]
    public class Servico
    {
        [XmlAttribute]
        public IdentificadorServicos Nome;

        [XmlAttribute]
        public VersaoServico Versao;

        [XmlText]
        public string Url;

        public override string ToString()
        {
            return Nome.ToString();
        }
    }
}