﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace RACU11.Migrations
{
    [DbContext(typeof(RACU11Context))]
    partial class RACU11ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.1");

            modelBuilder.Entity("RACU11.Models.Children", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("DiversionMechanism")
                        .HasColumnType("TEXT");

                    b.Property<string>("GuardianAddress")
                        .HasColumnType("TEXT");

                    b.Property<string>("GuardianName")
                        .HasColumnType("TEXT");

                    b.Property<string>("HomePhone")
                        .HasColumnType("TEXT");

                    b.Property<string>("MobilePhone")
                        .HasColumnType("TEXT");

                    b.Property<string>("OtherFeatures")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Children");
                });

            modelBuilder.Entity("RACU11.Models.IRF", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("BlotterEntryNumber")
                        .HasColumnType("TEXT");

                    b.Property<int?>("ChildrenId")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsThereMoreThanOneSuspect")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsThereSuspect")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ReportingPersonId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("ReportingTimeAndDateOfIncident")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("ReportingTimeAndDateOfReport")
                        .HasColumnType("TEXT");

                    b.Property<int?>("SuspectId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("TypeOfIncident")
                        .HasColumnType("TEXT");

                    b.Property<int?>("VictimId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ChildrenId");

                    b.HasIndex("ReportingPersonId");

                    b.HasIndex("SuspectId");

                    b.HasIndex("VictimId");

                    b.ToTable("IRF");
                });

            modelBuilder.Entity("RACU11.Models.ReportingPerson", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Age")
                        .HasColumnType("INTEGER");

                    b.Property<string>("CivilStatus")
                        .HasColumnType("TEXT");

                    b.Property<string>("CurrentAddress")
                        .HasColumnType("TEXT");

                    b.Property<string>("CurrentBarangay")
                        .HasColumnType("TEXT");

                    b.Property<string>("CurrentCity")
                        .HasColumnType("TEXT");

                    b.Property<string>("CurrentProvince")
                        .HasColumnType("TEXT");

                    b.Property<string>("CurrentVillage")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DOB")
                        .HasColumnType("TEXT");

                    b.Property<string>("EmailAddress")
                        .HasColumnType("TEXT");

                    b.Property<string>("FamilyName")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT");

                    b.Property<string>("HighestEducational")
                        .HasColumnType("TEXT");

                    b.Property<string>("HomePhone")
                        .HasColumnType("TEXT");

                    b.Property<string>("IDCard")
                        .HasColumnType("TEXT");

                    b.Property<string>("MiddleName")
                        .HasColumnType("TEXT");

                    b.Property<string>("MobilePhone")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nationality")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nickname")
                        .HasColumnType("TEXT");

                    b.Property<string>("Occupation")
                        .HasColumnType("TEXT");

                    b.Property<string>("OtherAddress")
                        .HasColumnType("TEXT");

                    b.Property<string>("OtherBarangay")
                        .HasColumnType("TEXT");

                    b.Property<string>("OtherCity")
                        .HasColumnType("TEXT");

                    b.Property<string>("OtherProvince")
                        .HasColumnType("TEXT");

                    b.Property<string>("OtherVillage")
                        .HasColumnType("TEXT");

                    b.Property<string>("POB")
                        .HasColumnType("TEXT");

                    b.Property<string>("Qualifier")
                        .HasColumnType("TEXT");

                    b.Property<string>("Sex")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("ReportingPeople");
                });

            modelBuilder.Entity("RACU11.Models.Suspect", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("AfpPersonnelRank")
                        .HasColumnType("TEXT");

                    b.Property<int>("Age")
                        .HasColumnType("INTEGER");

                    b.Property<string>("CivilStatus")
                        .HasColumnType("TEXT");

                    b.Property<string>("ColorOfEyes")
                        .HasColumnType("TEXT");

                    b.Property<string>("ColorOfHair")
                        .HasColumnType("TEXT");

                    b.Property<string>("CurrentAddress")
                        .HasColumnType("TEXT");

                    b.Property<string>("CurrentBarangay")
                        .HasColumnType("TEXT");

                    b.Property<string>("CurrentCity")
                        .HasColumnType("TEXT");

                    b.Property<string>("CurrentProvince")
                        .HasColumnType("TEXT");

                    b.Property<string>("CurrentVillage")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DOB")
                        .HasColumnType("TEXT");

                    b.Property<string>("DescriptionOfEyes")
                        .HasColumnType("TEXT");

                    b.Property<string>("DescriptionOfHair")
                        .HasColumnType("TEXT");

                    b.Property<string>("EmailAddress")
                        .HasColumnType("TEXT");

                    b.Property<string>("FamilyName")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT");

                    b.Property<string>("GroupAffiliation")
                        .HasColumnType("TEXT");

                    b.Property<string>("Height")
                        .HasColumnType("TEXT");

                    b.Property<string>("HighestEducation")
                        .HasColumnType("TEXT");

                    b.Property<string>("HomePhone")
                        .HasColumnType("TEXT");

                    b.Property<string>("MiddleName")
                        .HasColumnType("TEXT");

                    b.Property<string>("MobilePhone")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nationality")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nickname")
                        .HasColumnType("TEXT");

                    b.Property<string>("Occupation")
                        .HasColumnType("TEXT");

                    b.Property<string>("OtherAddress")
                        .HasColumnType("TEXT");

                    b.Property<string>("OtherBarangay")
                        .HasColumnType("TEXT");

                    b.Property<string>("OtherCity")
                        .HasColumnType("TEXT");

                    b.Property<string>("OtherProvince")
                        .HasColumnType("TEXT");

                    b.Property<string>("OtherVillage")
                        .HasColumnType("TEXT");

                    b.Property<string>("Qualifier")
                        .HasColumnType("TEXT");

                    b.Property<string>("RelationToVictim")
                        .HasColumnType("TEXT");

                    b.Property<string>("Sex")
                        .HasColumnType("TEXT");

                    b.Property<string>("StatusOfPreviousCase")
                        .HasColumnType("TEXT");

                    b.Property<bool>("UnderInfluenceOfDrugs")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("UnderInfluenceOfLiquors")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UnderInfluenceOfOthers")
                        .HasColumnType("TEXT");

                    b.Property<string>("UnitAssignment")
                        .HasColumnType("TEXT");

                    b.Property<string>("WasWithPreviousCase")
                        .HasColumnType("TEXT");

                    b.Property<string>("Weight")
                        .HasColumnType("TEXT");

                    b.Property<string>("WorkAddress")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Suspect");
                });

            modelBuilder.Entity("RACU11.Models.Victim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CurrentAddress")
                        .HasColumnType("TEXT");

                    b.Property<string>("CurrentBarangay")
                        .HasColumnType("TEXT");

                    b.Property<string>("CurrentCity")
                        .HasColumnType("TEXT");

                    b.Property<string>("CurrentProvince")
                        .HasColumnType("TEXT");

                    b.Property<string>("CurrentVillage")
                        .HasColumnType("TEXT");

                    b.Property<string>("EmailAddress")
                        .HasColumnType("TEXT");

                    b.Property<string>("FamilyName")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT");

                    b.Property<string>("HighestEducation")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IfReportingPersonIsVictim")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IfTwoOrMoreVictims")
                        .HasColumnType("INTEGER");

                    b.Property<string>("MiddleName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nickname")
                        .HasColumnType("TEXT");

                    b.Property<string>("Occupation")
                        .HasColumnType("TEXT");

                    b.Property<string>("OtherAddress")
                        .HasColumnType("TEXT");

                    b.Property<string>("OtherBarangay")
                        .HasColumnType("TEXT");

                    b.Property<string>("OtherCity")
                        .HasColumnType("TEXT");

                    b.Property<string>("OtherProvince")
                        .HasColumnType("TEXT");

                    b.Property<string>("OtherVillage")
                        .HasColumnType("TEXT");

                    b.Property<string>("Qualifier")
                        .HasColumnType("TEXT");

                    b.Property<string>("WorkAddress")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Victim");
                });

            modelBuilder.Entity("RACU11.Models.IRF", b =>
                {
                    b.HasOne("RACU11.Models.Children", "Children")
                        .WithMany()
                        .HasForeignKey("ChildrenId");

                    b.HasOne("RACU11.Models.ReportingPerson", "ReportingPerson")
                        .WithMany()
                        .HasForeignKey("ReportingPersonId");

                    b.HasOne("RACU11.Models.Suspect", "Suspect")
                        .WithMany()
                        .HasForeignKey("SuspectId");

                    b.HasOne("RACU11.Models.Victim", "Victim")
                        .WithMany()
                        .HasForeignKey("VictimId");

                    b.Navigation("Children");

                    b.Navigation("ReportingPerson");

                    b.Navigation("Suspect");

                    b.Navigation("Victim");
                });
#pragma warning restore 612, 618
        }
    }
}
