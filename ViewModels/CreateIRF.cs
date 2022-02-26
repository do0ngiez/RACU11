using System.ComponentModel.DataAnnotations;

namespace RACU11.ViewModels;

public class CreateIRF
{
    [Display(Name = "Blotter Entry Number")]
    public string IRF_BlotterEntryNumber { get; set; }
    [Display(Name = "Type of Incident")]
    public string IRF_TypeOfIncident { get; set; }
    [Display(Name = "Reporting Time and Date of Report")]
    public DateTime IRF_ReportingTimeAndDateOfReport { get; set; } //Time&Date of Report
    [Display(Name = "Reporting Time and Date of Incident")]
    public DateTime IRF_ReportingTimeAndDateOfIncident { get; set; } //Time&Date of Incident
    
    [Display(Name = "Is there a suspect?")]
    public bool IRF_IsThereSuspect { get; set; } //checkbox
    [Display(Name = "Is there more than one suspect?")]
    public bool IRF_IsThereMoreThanOneSuspect { get; set; } //checkbox
    



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


    public string Suspect_FamilyName { get; set; }
    public string Suspect_FirstName { get; set; }
    public string Suspect_MiddleName { get; set; }
    public string Suspect_Qualifier { get; set; }
    public string Suspect_Nickname { get; set; }
    public string Suspect_Nationality { get; set; }
    public string Suspect_Sex { get; set; }
    public string Suspect_CivilStatus { get; set; }
    public DateTime Suspect_DOB { get; set; } //Date of Birth
    public int Suspect_Age { get; set; }
    public string Suspect_HomePhone { get; set; }
    public string Suspect_MobilePhone { get; set; }
    public string Suspect_CurrentAddress { get; set; }
    public string Suspect_CurrentVillage { get; set; }
    public string Suspect_CurrentBarangay { get; set; }
    public string Suspect_CurrentCity { get; set; }
    public string Suspect_CurrentProvince { get; set; }
    public string Suspect_OtherAddress { get; set; }
    public string Suspect_OtherVillage { get; set; }
    public string Suspect_OtherBarangay { get; set; }
    public string Suspect_OtherCity { get; set; }
    public string Suspect_OtherProvince { get; set; }
    public string Suspect_HighestEducation { get; set; }
    public string Suspect_Occupation { get; set; }
    public string Suspect_WorkAddress { get; set; }
    public string Suspect_RelationToVictim { get; set; }
    public string Suspect_EmailAddress { get; set; }
    public string Suspect_AfpPersonnelRank { get; set; }
    public string Suspect_UnitAssignment { get; set; }
    public string Suspect_GroupAffiliation { get; set; }
    public string Suspect_WasWithPreviousCase { get; set; }
    public string Suspect_StatusOfPreviousCase { get; set; }
    public string Suspect_Height { get; set; }
    public string Suspect_Weight { get; set; }
    public string Suspect_ColorOfEyes { get; set; }
    public string Suspect_DescriptionOfEyes { get; set; }
    public string Suspect_ColorOfHair { get; set; }
    public string Suspect_DescriptionOfHair { get; set; }
    public bool Suspect_UnderInfluenceOfDrugs { get; set; }
    public bool Suspect_UnderInfluenceOfLiquors { get; set; }
    public string Suspect_UnderInfluenceOfOthers { get; set; }



    public string Children_GuardianName { get; set; }
    public string Children_GuardianAddress { get; set; }
    public string Children_HomePhone { get; set; }
    public string Children_MobilePhone { get; set; }
    public string Children_DiversionMechanism { get; set; }
    public string Children_OtherFeatures { get; set; }



    public bool Victim_IfReportingPersonIsVictim { get; set; }
    public bool Victim_IfTwoOrMoreVictims { get; set; }
    public string Victim_FamilyName { get; set; }
    public string Victim_FirstName { get; set; }
    public string Victim_MiddleName { get; set; }
    public string Victim_Qualifier { get; set; }
    public string Victim_Nickname { get; set; }
    public string Victim_CurrentAddress { get; set; }
    public string Victim_CurrentVillage { get; set; }
    public string Victim_CurrentBarangay { get; set; }
    public string Victim_CurrentCity { get; set; }
    public string Victim_CurrentProvince { get; set; }
    public string Victim_OtherAddress { get; set; }
    public string Victim_OtherVillage { get; set; }
    public string Victim_OtherBarangay { get; set; }
    public string Victim_OtherCity { get; set; }
    public string Victim_OtherProvince { get; set; }
    public string Victim_HighestEducation { get; set; }
    public string Victim_Occupation { get; set; }
    public string Victim_WorkAddress { get; set; }
    public string Victim_EmailAddress { get; set; }
}