namespace RACU11.Models;

public class IRFReceipt
{
    public int Id { get; set; }
    public int BlotterEntryNumber { get; set; }
    public string ReportingPersonName { get; set; }
    public string ReportingPersonAddress { get; set; }
    public string TypeOfIncident { get; set; }
    public DateTime TimeDateOfIncident { get; set; }
    public string PlaceOfIncident { get; set; }
    public string Officer { get; set; }
}