using Microsoft.AspNetCore.Mvc;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Rotativa.AspNetCore;

namespace courseSearch.Controllers
{
    public class DownloadPDF : Controller
    {
        public IActionResult Download(IFormCollection form)
        {
            string selectedValue1 = form["subject1"].ToString();
           

            string data = "Your subjects are" + " "  + selectedValue1;

            // Get your data and put it into a string
            

            // Create a PDF document
            Document document = new Document();
            MemoryStream stream = new MemoryStream();
            PdfWriter writer = PdfWriter.GetInstance(document, stream);
            document.Open();

            // Add your data to the PDF document
            Paragraph paragraph = new Paragraph(data);
            document.Add(paragraph);

            // Close the document
            document.Close();

            // Convert the PDF document to a byte array
            byte[] pdfBytes = stream.ToArray();

            // Return the PDF as a downloadable file
            return File(pdfBytes, "application/pdf", "YourFileName.pdf");
        }
    }
}
