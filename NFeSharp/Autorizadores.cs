using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace NFeSharp
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
        [XmlArrayItem("Servicos", typeof(Servico), Form = XmlSchemaForm.Unqualified)]
        public Servico[] Servicos;

        [XmlArray(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [XmlArrayItem("Utilizadores", typeof(UnidadesFederativas), Form = XmlSchemaForm.Unqualified, ElementName = "UF")]
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

        [Serializable]
        [XmlType(AnonymousType = true)]
        public class Servico
        {
            [XmlAttribute]
            public IdentificadorWebService Nome;

            [XmlAttribute]
            public VersaoWebService Versao;

            [XmlText]
            public string Url;

            public override string ToString()
            {
                return Nome.ToString();
            }
        }
    }
}