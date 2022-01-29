namespace RACU11.Models;

public class ReportingPerson
{
    public int Id { get; set; }
    public string FamilyName { get; set; }
    public string FirstName { get; set; }
    public string MiddleName { get; set; }
    public string Qualifier { get; set; }
    public string Nickname { get; set; }
    public string Nationality { get; set; }
    public string Sex { get; set; }
    public string CivilStatus { get; set; }
    public DateTime DOB { get; set; } //Date of Birth
    public int Age { get; set; }
    public string POB { get; set; } //Place of Birth
    public string HomePhone { get; set; }
    public string MobilePhone { get; set; }
    public string CurrentAddress { get; set; } //House number, Street (CURRENT)
    public string CurrentVillage { get; set; }
    public string CurrentBarangay { get; set; }
    public string CurrentCity { get; set; }
    public string CurrentProvince { get; set; }
    public string OtherAddress { get; set; } //House number, Street (OTHER)
    public string OtherVillage { get; set; }
    public string OtherBarangay { get; set; }
    public string OtherCity { get; set; }
    public string OtherProvince { get; set; }
    public string HighestEducational { get; set; }
    public string Occupation { get; set; }
    public string IDCard { get; set; }
    public string EmailAddress { get; set; }
}