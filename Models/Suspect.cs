namespace RACU11.Models;

public class Suspect
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
    public string HomePhone { get; set; }
    public string MobilePhone { get; set; }
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
    public string RelationToVictim { get; set; }
    public string EmailAddress { get; set; }
    public string AfpPersonnelRank { get; set; }
    public string UnitAssignment { get; set; }
    public string GroupAffiliation { get; set; }
    public string WasWithPreviousCase { get; set; }
    public string StatusOfPreviousCase { get; set; }
    public string Height { get; set; }
    public string Weight { get; set; }
    public string ColorOfEyes { get; set; }
    public string DescriptionOfEyes { get; set; }
    public string ColorOfHair { get; set; }
    public string DescriptionOfHair { get; set; }
    public bool UnderInfluenceOfDrugs { get; set; }
    public bool UnderInfluenceOfLiquors { get; set; }
    public string UnderInfluenceOfOthers { get; set; }
}