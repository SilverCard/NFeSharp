using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace NFeSharp.Utils
{
    public static class XmlUtils
    {
        /// <summary>
        /// Dicionário para a associação do Type
        /// </summary>
        private static readonly Dictionary<Tuple<String, String>, Type> TypeDicionary = new Dictionary<Tuple<String, String>, Type>() {
            { Tuple.Create<String,String>("resEvento", "1.00"), typeof(NFeSharp.Esquemas.v1_00.resEvento) },
            { Tuple.Create<String,String>("resNFe", "1.00"), typeof(NFeSharp.Esquemas.v1_00.resNFe) },
            { Tuple.Create<String,String>("procEventoNFe", "1.00"), typeof(NFeSharp.Esquemas.v1_00.TProcEvento) },
            { Tuple.Create<String,String>("procNFe", "3.00"), typeof(NFeSharp.Esquemas.v3_10.nfeProc) }
        };

        /// <summary>
        /// Regex utilizado para a identificação do Type do esquema
        /// </summary>
        private const String SchemaRegex = @"(?<Tipo>[^_]{1,})_v(?<Versao>\d+\.\d{2})\.xsd";

        public static XmlNode SerializeToXml<T>(T obj)
        {
            var doc = new XmlDocument();
            var nav = doc.CreateNavigator();

            XmlSerializerNamespaces ns = new XmlSerializerNamespaces(); 
            XmlTypeAttribute xmlType = (XmlTypeAttribute)Attribute.GetCustomAttribute(typeof(T), typeof(XmlTypeAttribute));

            if(xmlType != null)
            {
                ns.Add("", xmlType.Namespace);
            }

            using (var writer = nav.AppendChild())
            {
                var ser = new XmlSerializer(typeof(T));
                ser.Serialize(writer, obj, ns);
            }

            return doc;
        }

        public static T Deserialize<T>(XmlNode node)
        {
            var ser = new XmlSerializer(typeof(T));
            T result;
            using (XmlNodeReader reader = new XmlNodeReader(node))
            {
                result = (T)ser.Deserialize(reader);
            }
            return result;
        }

        public static Type PegarTipoConteudoDocZip(NFeSharp.Esquemas.v1_00.DocZip docZip)
        {
            Match match = Regex.Match(docZip.schema, SchemaRegex);
            String type = match.Groups["Tipo"].ToString();
            String versao = match.Groups["Versao"].ToString();

            var key = Tuple.Create<String, String>(type, versao);

            if (TypeDicionary.ContainsKey(key))
            {
                return TypeDicionary[key];
            }

            return null;
        }

        public static Object LerConteudoDocZip(NFeSharp.Esquemas.v1_00.DocZip docZip)
        {
            XmlDocument doc = new XmlDocument();
            Type type = PegarTipoConteudoDocZip(docZip);
            Object result;

            if (type == null)
            {
                return null;
            }

            using (GZipStream stream = new GZipStream(new MemoryStream(docZip.Conteudo), CompressionMode.Decompress))
            {
                var ser = new XmlSerializer(type);
                using (XmlReader reader = XmlReader.Create(stream))
                {
                    result = ser.Deserialize(reader);
                }
            }

            return result;
        }
    }
}
