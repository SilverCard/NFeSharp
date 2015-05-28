﻿using NFeSharp.Danfe.Schemas;
using org.pdfclown.documents.contents.composition;
using org.pdfclown.documents.contents.fonts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace NFeSharp.Danfe
{
    public static class Utils
    {
        /// <summary>
        /// Conta o número de linhas que o texto vai ocupar.
        /// </summary>
        /// <param name="font">Fonte do texto</param>
        /// <param name="fontSize">Tamanho da fonte</param>
        /// <param name="width">Largura máxima do texto</param>
        /// <param name="text">Texto</param>
        /// <returns>Número de linhas</returns>
        internal static int CountTextLines(Font font, double fontSize, double width, String text)
        {
            if (String.IsNullOrWhiteSpace(text))
            {
                return 0;
            }

            if (font == null)
            {
                throw new ArgumentNullException("font");
            }

            if (fontSize <= 0)
            {
                throw new ArgumentOutOfRangeException("fontSize");
            }

            if (width <= 0)
            {
                throw new ArgumentOutOfRangeException("width");
            }

            int lines = 0;
            int index = 0, end;
            TextFitter tf = new TextFitter(text, width, font, fontSize, false, '-');

            while (index < text.Length)
            {
                tf.Fit(index, width, true);
                end = tf.EndIndex;

                // Isso evita um loop infinito, impedindo que o index permaneça o mesmo.
                index = index == end ? end + 1 : end;
                lines++;
            }

            return lines;
        }

        /// <summary>
        /// Calcula a altura que o texto vai ocupar.
        /// </summary>
        /// <param name="font">Fonte do texto</param>
        /// <param name="fontSize">Tamanho da fonte</param>
        /// <param name="width">Largura máxima do texto</param>
        /// <param name="text">Texto</param>
        /// <returns>Altura que o texto vai ocupar.</returns>
        internal static double GetTextHeight(Font font, double fontSize, double width, String text)
        {
            int lines = CountTextLines(font, fontSize, width, text);
            double height = font.GetLineHeight(fontSize) * lines;
            return height;
        }       
    }
}
