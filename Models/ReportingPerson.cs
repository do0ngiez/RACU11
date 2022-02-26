using System.ComponentModel.DataAnnotations;

namespace RACU11.Models;

public class ReportingPerson
{
    public int Id { get; set; }

    [Display(Name = "Family Name")]
    public string FamilyName { get; set; }
    [Display(Name = "First Name")]
    public string FirstName { get; set; }
    [Display(Name = "Middle Name")]
    public string MiddleName { get; set; }
    [Display(Name = "Qualifier")]
    public string Qualifier { get; set; }
    [Display(Name = "Nickname")]
    public string Nickname { get; set; }
    [Display(Name = "Nationality")]
    public string Nationality { get; set; }
    [Display(Name = "Sex")]
    public string Sex { get; set; }
    [Display(Name = "Civil Status")]
    public string CivilStatus { get; set; }
    [Display(Name = "Date of Birth")]
    public DateTime DOB { get; set; } //Date of Birth
    [Display(Name = "Age")]
    public int Age { get; set; }
    [Display(Name = "Place of Birth")]
    public string POB { get; set; } //Place of Birth
    [Display(Name = "Home Phone")]
    public string HomePhone { get; set; }
    [Display(Name = "Mobile Phone")]
    public string MobilePhone { get; set; }
    [Display(Name = "Current Address (House Number/Street)")]
    public string CurrentAddress { get; set; } //House number, Street (CURRENT)
    [Display(Name = "Village/Sitio")]
    public string CurrentVillage { get; set; }
    [Display(Name = "Barangay")]
    public string CurrentBarangay { get; set; }
    [Display(Name = "Town/City")]
    public string CurrentCity { get; set; }
    [Display(Name = "Province")]
    public string CurrentProvince { get; set; }
    [Display(Name = "Other Address (House Number/Street)")]
    public string OtherAddress { get; set; } //House number, Street (OTHER)
    [Display(Name = "Village/Sitio")]
    public string OtherVillage { get; set; }
    [Display(Name = "Barangay")]
    public string OtherBarangay { get; set; }
    [Display(Name = "Town/City")]
    public string OtherCity { get; set; }
    [Display(Name = "Province")]
    public string OtherProvince { get; set; }
    [Display(Name = "Highest Educational Attainment")]
    public string HighestEducational { get; set; }
    [Display(Name = "Occupation")]
    public string Occupation { get; set; }
    [Display(Name = "ID Card Presented")]
    public string IDCard { get; set; }
    [Display(Name = "Email Address")]
    public string EmailAddress { get; set; }
}