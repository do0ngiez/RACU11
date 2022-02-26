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

    public FileContentResult FilloutForm()
    {
        // Retrieve template
        string path = "Contents/IRF.docx";

        byte[] templateBytes = System.IO.File.ReadAllBytes(path);
        using MemoryStream templateStream = new MemoryStream();
        templateStream.Write(templateBytes, 0, templateBytes.Length);

        using WordprocessingDocument doc = WordprocessingDocument.Open(templateStream, true);

        // Find the first table in the document.
        Table table = doc.MainDocumentPart.Document.Body.Elements<Table>().First();

        // Find the second row in the table.
        // this is blotter entry number row
        TableRow row = table.Elements<TableRow>().ElementAt(1);

        // blotter entry number
        TableCell cell = row.Elements<TableCell>().ElementAt(0);

        // 2nd paragraph is where you can insert information
        Paragraph p = cell.Elements<Paragraph>().ElementAt(1);
        Run r = new Run();
        p.InsertAt(r, 0);

        // tablerow -> tablecell -> paragraph -> run -> text

        // Create the first text in the run.
        Text t = new Text("Hello World! Stream SMiLEY x_x");
        r.InsertAt(t, 0);

        // find type of incident row
        TableRow typeofIncidentRow = table.Elements<TableRow>().ElementAt(2);

        // find type of incident tc
        TableCell typeofIncidentCell = typeofIncidentRow.Elements<TableCell>().ElementAt(0);

        // find paragraph
        Paragraph typeofIncidentPar = typeofIncidentCell.Elements<Paragraph>().ElementAt(1);
        Run typeofIncidentRun = new Run();
        typeofIncidentPar.InsertAt(typeofIncidentRun, 0);

        // create run and add text
        Text typeofIncidentText = new Text("Stream SMiLEY x_x");
        typeofIncidentRun.InsertAt(typeofIncidentText, 0);



        /////////////////////////

        doc.Close();
        templateStream.Seek(0, SeekOrigin.Begin);
        using MemoryStream memoryStream = new MemoryStream();
        templateStream.CopyTo(memoryStream);

        return new FileContentResult(memoryStream.ToArray(), "application/vnd.openxmlformats-officedocument.wordprocessingml.document");
    }
}
