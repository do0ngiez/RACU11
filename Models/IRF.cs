using System.ComponentModel.DataAnnotations;

namespace RACU11.Models;

public class IRF
{

    //
    public int Id { get; set; }
    [Display(Name = "Blotter Entry Number")]
    public string BlotterEntryNumber { get; set; }
    [Display(Name = "Type of Incident")]
    public string TypeOfIncident { get; set; }
    [Display(Name = "Reporting Time and Date of Report")]
    public DateTime ReportingTimeAndDateOfReport { get; set; } //Time&Date of Report
    [Display(Name = "Reporting Time and Date of Incident")]
    public DateTime ReportingTimeAndDateOfIncident { get; set; } //Time&Date of Incident
    
    // 
    [Display(Name = "Is there a suspect?")]
    public bool IsThereSuspect { get; set; } //checkbox
    [Display(Name = "Is there more than one suspect?")]
    public bool IsThereMoreThanOneSuspect { get; set; } //checkbox
    
    //
    public ReportingPerson ReportingPerson { get; set; }
    public Suspect Suspect { get; set; }
}