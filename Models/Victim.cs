namespace RACU11.Models;

public class Victim
{
    public int Id { get; set; }
    public bool IfReportingPersonIsVictim { get; set; }
    public bool IfTwoOrMoreVictims { get; set; }
    public string FamilyName { get; set; }
    public string FirstName { get; set; }
    public string MiddleName { get; set; }
    public string Qualifier { get; set; }
    public string Nickname { get; set; }
    public string CurrentAddress { get; set; }
    public string CurrentVillage { get; set; }
    public string CurrentBarangay { get; set; }
    public string CurrentCity { get; set; }
    public string CurrentProvince { get; set; }
    public string OtherAddress { get; set; }
    public string OtherVillage { get; set; }
    public string OtherBarangay { get; set; }
    public string OtherCity { get; set; }
    public string OtherProvince { get; set; }
    public string HighestEducation { get; set; }
    public string Occupation { get; set; }
    public string WorkAddress { get; set; }
    public string EmailAddress { get; set; }


}