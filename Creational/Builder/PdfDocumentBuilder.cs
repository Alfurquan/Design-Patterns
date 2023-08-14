using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Builder
{
    public class PdfDocumentBuilder : IPresentationBuilder
    {
        private PdfDocument document = new PdfDocument();
        public void AddSlide(Slide slide)
        {
            
            document.AddPage(slide.GetText());
        }

        public PdfDocument GetPdfDocument()
        {
            return document;
        }
    }
}
