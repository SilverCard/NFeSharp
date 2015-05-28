﻿using NFeSharp.Danfe.Model;
using org.pdfclown.documents;
using org.pdfclown.documents.contents.colorSpaces;
using org.pdfclown.documents.contents.composition;
using org.pdfclown.documents.contents.fonts;
using org.pdfclown.documents.contents.xObjects;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFeSharp.Danfe
{
    /// <summary>
    /// DANFE
    /// </summary>
    public sealed class DanfeDocumento : IDisposable
    {
        /// <summary>
        /// File do PDF Clown.
        /// </summary>
        private org.pdfclown.files.File _File;

        /// <summary>
        /// Document do PDF Clown.
        /// </summary>
        internal Document Document;

        /// <summary>
        /// Tamanho do DANFE.
        /// </summary>
        public static readonly Size A4Tamanho = new Size(210, 297);
       
        /// <summary>
        /// Modelo de dados para preenchimento.
        /// </summary>
        public DanfeViewModel Model { get; private set; }

        /// <summary>
        /// Margem do documento.
        /// </summary>
        public float Margem { get; private set; }

        /// <summary>
        /// Fonte do DANFE.
        /// </summary>
        public StandardType1Font Font { get; private set; }
        
        /// <summary>
        /// Fonte em negrito do DANFE.
        /// </summary>
        public StandardType1Font FontBold { get; private set; }

        public readonly float CampoAltura = Unit.Mm2Pu(6.75F);
        public readonly float CabecalhoBlocoAltura = Unit.Mm2Pu(3);

        /// <summary>
        /// Retângulo do interior
        /// </summary>
        public RectangleF InnerRect { get; private set; }

        /// <summary>
        /// Paginas do DANFE.
        /// </summary>
        public List<DanfePagina> Paginas { get; private set; }

        /// <summary>
        /// Tamanho da borda dos campos.
        /// </summary>
        public const float LineWidth = 0.25F;

        /// <summary>
        /// Tamanho do documento.
        /// </summary>
        public SizeF Size { get; private set; }

        /// <summary>
        /// Indica se o DANFE foi gerado.
        /// </summary>
        public Boolean FoiGerado { get; private set; }

        public DanfeDocumento(DanfeViewModel model)
            : this(model, Unit.Mm2Pu(5))
        {            
        }


        public DanfeDocumento(DanfeViewModel model, float margem)
        {
            Margem = margem;
            _File = new org.pdfclown.files.File();
            Document = _File.Document;
            Model = model;
            Size = new SizeF(Unit.Mm2Pu(A4Tamanho.Width), Unit.Mm2Pu(A4Tamanho.Height));

            Font = new StandardType1Font(Document, StandardType1Font.FamilyEnum.Times, false, false);
            FontBold = new StandardType1Font(Document, StandardType1Font.FamilyEnum.Times, true, false);

            InnerRect = new RectangleF(0, 0, Unit.Mm2Pu(A4Tamanho.Width), Unit.Mm2Pu(A4Tamanho.Height)).GetPaddedRectangleMm(5);
            Paginas = new List<DanfePagina>();

            AdicionarMetadata();

            FoiGerado = false;
        }

        private void AdicionarMetadata()
        {
            var info = Document.Information;
            info.CreationDate = DateTime.Now;
            info.Creator = String.Format("{0} {1} - {2}", "DanfeSharp", System.Reflection.Assembly.GetExecutingAssembly().GetName().Version, "http://danfesharp.codeplex.com");
            info.Title = "DANFE (Documento auxiliar da NFe)";
        }

        private void RenderizarDocumento()
        {
            int n = 1;

            foreach (var pagina in Paginas)
            {
                pagina.Renderizar(n, Paginas.Count);
                n++;
            }
        }

        internal DanfePagina CriarPaginar()
        {
            DanfePagina page = new DanfePagina(this);
            Document.Pages.Add(page._Page);
            Paginas.Add(page);
            return page;
        }

        /// <summary>
        /// Salva o DANFE em arquivo.
        /// </summary>
        /// <param name="path">Caminho do arquivo.</param>
        public void Salvar(String path)
        {
            VerificarGerado();

            _File.Save(path, org.pdfclown.files.SerializationModeEnum.Standard);
        }

        /// <summary>
        /// Salva o DANFE em um stream.
        /// </summary>
        /// <param name="stream">Stream.</param>
        public void Salvar(System.IO.Stream stream)
        {
            VerificarGerado();

            var pdfclowStream = new org.pdfclown.bytes.Stream(stream);
            _File.Save(pdfclowStream, org.pdfclown.files.SerializationModeEnum.Standard);
        }

        [DebuggerStepThrough]
        private void VerificarGerado()
        {
            if (!FoiGerado)
                throw new InvalidOperationException("O DANFE precisa ser gerado antes de ser salvo.");
        }


        /// <summary>
        /// Gera o DANFE.
        /// </summary>
        public void Gerar()
        {
            if (FoiGerado) return; 
            
            if(Model.PossuiLogo && !System.IO.File.Exists(Model.LogoPath))
            {
                throw new System.IO.FileNotFoundException("O arquivo do logo não foi encontrado.", Model.LogoPath);
            }

            DanfePagina page = CriarPaginar();
            float y = InnerRect.Top, y2 = InnerRect.Bottom;

            var canhoto = new BlocoCanhoto(this);                       
            var dadosNfe = new BlocoDadosNFe(this);
            var desti = new BlocoDestinatario(this);
            var faturas = new BlocoFaturas(this);
            var calcImposto = new BlocoCalculoImposto(this);
            var transportador = new BlocoTransportador(this);
            var dadosAdicionais = new BlocoDadosAdicionais(this);
            var issqn = new BlocoIssqn(this);

            page.AdicionarBlocoSuperior(canhoto);
            page.AdicionarBlocoSuperior(dadosNfe);
            page.AdicionarBlocoSuperior(desti);

            if (Model.Duplicatas.Count > 0)
            {
                page.AdicionarBlocoSuperior(faturas);
            }

            page.AdicionarBlocoSuperior(calcImposto);
            page.AdicionarBlocoSuperior(transportador);

            if (Model.MostrarCalculoIssqn)
            {
                page.AdicionarBlocoInferior(issqn);
            }

            page.AdicionarBlocoInferior(dadosAdicionais);

            BlocoProdutos produtos = new BlocoProdutos(this, page.GetAlturaCorpo(InnerRect), 0);
            produtos.ToXObject();
            int produtoIndex = produtos.ProdutoIndexEnd;
            page.AdicionarBlocoSuperior(produtos);                                

            while (produtoIndex < Model.Produtos.Count)
            {

                page = CriarPaginar(); 
                page.AdicionarBlocoSuperior(dadosNfe);
                produtos = new BlocoProdutos(this, page.GetAlturaCorpo(InnerRect), produtoIndex);
                produtos.ToXObject();
                produtoIndex = produtos.ProdutoIndexEnd;

                page.AdicionarBlocoSuperior(produtos);

            }

            RenderizarDocumento();

            FoiGerado = true;
        }

        /// <summary>
        /// Libera os recursos.
        /// </summary>
        public void Dispose()
        {
            if(_File != null)
            {
                _File.Dispose();
            }
        }
    }
}