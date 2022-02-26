using System.Diagnostics;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using Microsoft.AspNetCore.Mvc;
using RACU11.Models;

namespace RACU11.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

    public FileContentResult FilloutForm() //ty viet for the code :)
    {
        // Retrieve template
        string path = "Contents/Sample.docx";

        byte[] templateBytes = System.IO.File.ReadAllBytes(path);
        using MemoryStream templateStream = new MemoryStream();
        templateStream.Write(templateBytes, 0, templateBytes.Length);
        // using FileStream fs = System.IO.File.OpenRead(path);
        // fs.CopyTo(memStream);

        // memStream.Flush();
        // memStream.Position = 0;

        using WordprocessingDocument doc = WordprocessingDocument.Open(templateStream, true);

        // Find the first table in the document.
        Table table = doc.MainDocumentPart.Document.Body.Elements<Table>().First();

        // Find the first row in the table.
        // this is maybe family row?
        TableRow row = table.Elements<TableRow>().ElementAt(0);
        // DocumentFormat.OpenXml.Wordprocessing.TableRow row = table.Elements<DocumentFormat.OpenXml.Wordprocessing.TableRow>().ElementAt(5);

        // Family Name?
        TableCell cell = row.Elements<TableCell>().ElementAt(0);

        // 2nd paragraph is where you can insert information
        Run r = new Run();
        Paragraph p = cell.Elements<Paragraph>().ElementAt(0);
        p.InsertAt(r, 0);
        // Create the first text in the run.
        Text t = new Text("Hello World! Stream SMiLEY x_x");
        r.InsertAt(t, 0);

        doc.Save();
        templateStream.Position = 0;
        // using MemoryStream memoryStream = new MemoryStream();
        // templateStream.CopyTo(memoryStream);

        System.IO.File.WriteAllBytes("Contents/temp.docx", templateStream.ToArray());

        byte[] tempBytes = System.IO.File.ReadAllBytes("Contents/temp.docx");

        return new FileContentResult(tempBytes, "application/vnd.openxmlformats-officedocument.wordprocessingml.document");
    }
}
