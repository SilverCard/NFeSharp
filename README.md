###NFeSharp

[![Build Status](https://travis-ci.org/SilverCard/NFeSharp.svg?branch=master)](https://travis-ci.org/SilverCard/NFeSharp)

NFeSharp é uma API escrita em C# que implementa um cliente para o consumo dos serviços web dos autorizadores de NFe. Alpha.

#### Exemplo de uso
```csharp
using System;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
using System.Linq;
using NFeSharp.Esquemas.TiposBasicos;
using NFeSharp.Servicos;

namespace NFeSharpSandBox
{
    class Program
    {
        static void Main(string[] args)
        {
            var certificado = new X509Certificate2("Certificado.pfx", "SenhaCertificado");
            ClienteNFe cliente = new ClienteNFe(certificado, Autorizadores.LerDeArquivo("Autorizadores.xml"), TAmb.Producao);
            var resposta = cliente.NfeConsultaProtocoloAsync("43012345678901234567890123456789012345678909").Result;

            Console.WriteLine(resposta.xMotivo);
            Console.ReadLine();    
        }
    }
}

```
