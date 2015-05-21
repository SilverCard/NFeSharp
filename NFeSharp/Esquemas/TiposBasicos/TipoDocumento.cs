using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NFeSharp.Esquemas.TiposBasicos
{
    [Serializable]
    [XmlType(Namespace = Namespaces.NFe, IncludeInSchema = false)]
    public enum TipoDocumento
    {

        CNPJ,
        CPF,
    }
}
