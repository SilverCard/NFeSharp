using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace NFeSharp.Utils
{
    public class XmlUtils
    {
        public static XmlNode SerializeToXml<T>(T obj)
        {
            var doc = new XmlDocument();
            var nav = doc.CreateNavigator();
            using (var writer = nav.AppendChild())
            {
                var ser = new XmlSerializer(typeof(T));
                ser.Serialize(writer, obj);
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
    }
}
