using Arebis.Pdf.Common;
using Arebis.Pdf.Writing;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arebis.Pdf
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a TextOptions object:
            var to = new PdfTextOptions(PdfPredefinedFont.Helvetica, 12.0, PdfColor.Blue);

            // Write the document:
            using (var stream = new FileStream(@"MyNewPDF.pdf", FileMode.Create, FileAccess.Write))
            using (var writer = new PdfDocumentWriter(stream))
            {
                // Write a page:
                using (var page = writer.NewPage(PdfPageFormat.A4Portrait))
                {
                    /// Read text file
                    string text = File.ReadAllText(@"c:\temp\file.txt", Encoding.UTF8);

                    // Draw text on the page (with given TextOptions):
                    page.DrawText(40, 800, text, to);
                }
            }
        }
    }
}
