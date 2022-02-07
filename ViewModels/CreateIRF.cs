using System.ComponentModel.DataAnnotations;

namespace RACU11.ViewModels;

public class CreateIRF
{

    //ITEM "A"
    [Display(Name = "Blotter Entry Number")]
    public string IRF_BlotterEntryNumber { get; set; }
    [Display(Name = "Type of Incident")]
    public string IRF_TypeOfIncident { get; set; }
    [Display(Name = "Reporting Time and Date of Report")]
    public DateTime IRF_ReportingTimeAndDateOfReport { get; set; } //Time&Date of Report
    [Display(Name = "Reporting Time and Date of Incident")]
    public DateTime IRF_ReportingTimeAndDateOfIncident { get; set; } //Time&Date of Incident
    
    // ITEM "B"
    [Display(Name = "Is there a suspect?")]
    public bool IRF_IsThereSuspect { get; set; } //checkbox
    [Display(Name = "Is there more than one suspect?")]
    public bool IRF_IsThereMoreThanOneSuspect { get; set; } //checkbox
    
    //ITEM "C"

    public string ReportingPerson_FamilyName { get; set; }
    public string ReportingPerson_FirstName { get; set; }
    public string ReportingPerson_MiddleName { get; set; }
    public string ReportingPerson_Qualifier { get; set; }
    public string ReportingPerson_Nickname { get; set; }
    public string ReportingPerson_Nationality { get; set; }
    public string ReportingPerson_Sex { get; set; }
    public string ReportingPerson_CivilStatus { get; set; }
    public DateTime ReportingPerson_DOB { get; set; } //Date of Birth
    public int ReportingPerson_Age { get; set; }
    public string ReportingPerson_POB { get; set; } //Place of Birth
    public string ReportingPerson_HomePhone { get; set; }
    public string ReportingPerson_MobilePhone { get; set; }
    public string ReportingPerson_CurrentAddress { get; set; } //House number, Street (CURRENT)
    public string ReportingPerson_CurrentVillage { get; set; }
    public string ReportingPerson_CurrentBarangay { get; set; }
    public string ReportingPerson_CurrentCity { get; set; }
    public string ReportingPerson_CurrentProvince { get; set; }
    public string ReportingPerson_OtherAddress { get; set; } //House number, Street (OTHER)
    public string ReportingPerson_OtherVillage { get; set; }
    public string ReportingPerson_OtherBarangay { get; set; }
    public string ReportingPerson_OtherCity { get; set; }
    public string ReportingPerson_OtherProvince { get; set; }
    public string ReportingPerson_HighestEducational { get; set; }
    public string ReportingPerson_Occupation { get; set; }
    public string ReportingPerson_IDCard { get; set; }
    public string ReportingPerson_EmailAddress { get; set; }
}