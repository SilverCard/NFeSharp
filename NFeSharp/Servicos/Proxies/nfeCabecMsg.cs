using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;

namespace NFeSharp.Servicos.Proxies
{
    public class nfeCabecMsg : MessageHeader
    {
        private String _Namespace;
        public string cUF { get; set; }
        public string versaoDados { get; set; }

        public nfeCabecMsg() { }

        public nfeCabecMsg(string _cUF, string _versaoDados, string _namspace)
        {
            this.cUF = _cUF;
            this.versaoDados = _versaoDados;
            this._Namespace = _namspace;
        }

        protected override void OnWriteHeaderContents(System.Xml.XmlDictionaryWriter writer, MessageVersion messageVersion)
        {
            writer.WriteElementString("cUF", cUF);
            writer.WriteElementString("versaoDados", versaoDados);
        }

        public override string Name
        {
            get { return "nfeCabecMsg"; }
        }

        public override string Namespace
        {
            get { return _Namespace; }
        }
    }
}
