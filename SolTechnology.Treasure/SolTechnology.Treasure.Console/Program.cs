using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using iText.IO.Source;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas.Parser;
using iText.Svg.Processors.Impl;

namespace SolTechnology.Treasure.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Gimme a file xD");

            var filePath = System.Console.ReadLine();


            StringBuilder processed = new StringBuilder();


            var fileInfo = new FileInfo(filePath);

            var reader = new PdfReader(fileInfo);
            var pdfDocument = new PdfDocument(reader);



            for (var pageNum = 1; pageNum <= pdfDocument.GetNumberOfPages(); pageNum++)
            {
                // Get the page content and tokenize it.
                var page = pdfDocument.GetPage(pageNum);
                string text = PdfTextExtractor.GetTextFromPage(page);
                processed.Append(text);
            }

            reader.Close();

            var content = processed.ToString();

            if (content.Contains("ZUS", StringComparison.InvariantCultureIgnoreCase))
            {
                File.Copy(filePath, $"C:\\Users\\Adi\\Downloads\\adrian_strugala_{DateTime.Now:MMyyyy}_podatki_zus.pdf");
            }


            System.Console.WriteLine(processed);
            System.Console.ReadLine();
        }
    }
}
