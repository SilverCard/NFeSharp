using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Dispatcher;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace NFeSharp.Servicos.Proxies
{
    internal class nfeCabecMsgFixer : IClientMessageInspector
    {

        public static String SelectNodeTextByName(XmlDocument d, String name)
        {
            var node = d.DocumentElement.SelectSingleNode(String.Format("//*[local-name()='{0}']", name));
            return node == null ? String.Empty : node.InnerText;
        }

        private int BuscarIndice(Message request)
        {
            for (int i = 0; i < request.Headers.Count; i++)
            {
                if (request.Headers[i].Name == "nfeCabecMsg")
                {
                    return i;
                }
            }

            return -1;
        }

        public object BeforeSendRequest(ref Message request, IClientChannel channel)
        {
            int idx = BuscarIndice(request);

            if (idx >= 0)
            {
                nfeCabecMsg newHeader;
                using (XmlDictionaryReader reader = request.Headers.GetReaderAtHeader(idx))
                {
                    newHeader = new nfeCabecMsg(reader.NamespaceURI);
                    XmlDocument xmlDocument = new XmlDocument();
                    xmlDocument.Load(reader);
                    newHeader.cUF = SelectNodeTextByName(xmlDocument, "cUF");
                    newHeader.versaoDados = SelectNodeTextByName(xmlDocument, "versaoDados");
                }

                request.Headers.RemoveAt(idx);
                request.Headers.Add(newHeader);
            }

            return null;
        }

        public void AfterReceiveReply(ref Message reply, object correlationState) { }
    }

}
