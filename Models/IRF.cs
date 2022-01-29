namespace RACU11.Models;

public class IRF
{

    //ITEM "A"
    public int Id { get; set; }
    public string BlotterEntryNumber { get; set; }
    public string TypeOfIncident { get; set; }
    public DateTime ReportingTimeAndDateOfReport { get; set; } //Time&Date of Report
    public DateTime ReportingTimeAndDateOfIncident { get; set; } //Time&Date of Incident
    
    // ITEM "B"
    public bool IsThereSuspect { get; set; } //checkbox
    public bool IsThereMoreThanOneSuspect { get; set; } //checkbox
    
    //ITEM "C"

    public ReportingPerson ReportingPerson { get; set; }
    public Suspect Suspect { get; set; }
}