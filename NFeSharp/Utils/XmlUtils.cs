using NFeSharp.Esquemas;
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
    /// <summary>
    /// Classe com com utilizades relacionados a Xml
    /// </summary>
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

        /// <summary>
        /// Serializa um objeto para Xml
        /// </summary>
        /// <typeparam name="T">Tipo do objeto</typeparam>
        /// <param name="obj">Objeto</param>
        /// <returns>Xml serializado</returns>
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

        /// <summary>
        /// Deserializa um xml para objeto
        /// </summary>
        /// <typeparam name="T">Tipo do objeto</typeparam>
        /// <param name="node">Xml</param>
        /// <returns>Objeto deserializado</returns>
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

        /// <summary>
        /// Pega o tipo do DocZip
        /// </summary>
        /// <param name="docZip">DocZip</param>
        /// <returns>Tipo</returns>
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

        /// <summary>
        /// Decodifica e descompacta o centúdo do DocZip
        /// </summary>
        /// <param name="docZip">DocZip</param>
        /// <returns>Conteúdo desserializado</returns>
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

        public static XmlDocument CriarXml(String stringXml)
        {
            if (String.IsNullOrWhiteSpace(stringXml))
            {
                throw new ArgumentNullException("stringXml");
            }
            XmlDocument xml = new XmlDocument()
            {
                PreserveWhitespace = true
            };


            try
            {
                xml.LoadXml(stringXml);
            }
            catch (Exception e)
            {
                throw new NFeSharpException("Não foi possuir interpretar a string Xml.", e);
            }

            return xml;
        }

        /// <summary>
        /// Monta um Xml de processamento da NFe apartir dos elementos NFe e protNFe
        /// </summary>
        /// <param name="nfe">Xml NFe</param>
        /// <param name="protNFe">Xml protNFe</param>
        /// <param name="versao">Versão do documento</param>
        /// <returns>Xml de processamento da Nfe</returns>
        public static XmlDocument MontarNFeProcessamento(XmlNode nfe, XmlNode protNFe, String versao)
        {
            if (nfe == null) throw new ArgumentNullException("nfe");
            if (protNFe == null) throw new ArgumentNullException("protNFe");

            if (nfe.Name != "NFe") throw new ArgumentException("O parametro nfe não é um elemento NFe.");
            if (protNFe.Name != "protNFe") throw new ArgumentException("O parametro protNFe não é um elemento protNFe.");

            XmlDocument xml = new XmlDocument();
            var nfeProcElement = xml.CreateElement("nfeProc", Namespaces.NFe);
            var versaoAtributo = xml.CreateAttribute("versao");
            versaoAtributo.Value = versao;
            xml.AppendChild(nfeProcElement);
            var newNFe = xml.ImportNode(nfe, true);
            var newProtNFe = xml.ImportNode(protNFe, true);
            nfeProcElement.Attributes.Append(versaoAtributo);
            nfeProcElement.AppendChild(newNFe);
            nfeProcElement.AppendChild(newProtNFe);

            return xml;
        }

        /// <summary>
        /// Monta um Xml de processamento da NFe apartir do arquivo enviado e recebido ao Sefaz.
        /// </summary>
        /// <param name="xmlEnvio">Xml enviado ao Sefaz</param>
        /// <param name="xmlRetorno">Xml recebido do Sefaz</param>
        /// <returns>Xml de processamento da Nfe</returns>
        public static XmlDocument MontarNFeProcessamento(XmlNode xmlEnvio, XmlNode xmlRetorno)
        {
            if (xmlEnvio == null) throw new ArgumentNullException("xmlEnvio");
            if (xmlRetorno == null) throw new ArgumentNullException("xmlRetorno");

            if (xmlEnvio.Name != "enviNFe") throw new ArgumentException("O parametro xmlEnvio não é um elemento enviNFe.");


            NameTable nt = new NameTable();
            XmlNamespaceManager nsmgr = new XmlNamespaceManager(nt);
            nsmgr.AddNamespace("nfe", Namespaces.NFe);

            var nfeElement = xmlEnvio.SelectSingleNode("//nfe:NFe", nsmgr);
            if (nfeElement == null)
            {
                throw new ArgumentException("Elemento NFe não encontrado no Xml de envio.");
            }

            var protNfe = xmlRetorno.SelectSingleNode("//nfe:protNFe", nsmgr);
            if (protNfe == null)
            {
                throw new ArgumentException("Elemento protNfe não encontrado no Xml de retorno.");
            }

            var versao = xmlEnvio.Attributes["versao"];
            if (versao == null) throw new ArgumentNullException("O elemento enviNFe não possui o atributo versão.");

            return MontarNFeProcessamento(nfeElement, protNfe, versao.Value);
        }

        /// <summary>
        /// Monta um Xml de processamento da NFe apartir do arquivo enviado e recebido ao Sefaz.
        /// </summary>
        /// <param name="xmlEnvio">Xml enviado ao Sefaz</param>
        /// <param name="xmlRetorno">Xml recebido do Sefaz</param>
        /// <returns>Xml de processamento da Nfe</returns>
        public static XmlDocument MontarNFeProcessamento(String xmlEnvio, String xmlRetorno)
        {
            if (String.IsNullOrWhiteSpace(xmlEnvio)) throw new ArgumentNullException("xmlEnvio");
            if (String.IsNullOrWhiteSpace(xmlRetorno)) throw new ArgumentNullException("xmlRetorno");

            XmlDocument xmlEnvio2 = CriarXml(xmlEnvio);
            XmlDocument xmlRetorno2 = CriarXml(xmlRetorno);

            return MontarNFeProcessamento((XmlNode)xmlEnvio2.DocumentElement, (XmlNode)xmlRetorno2.DocumentElement);
        }
    }
}
