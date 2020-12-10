using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AccessJob.Data.Migrations
{
    public partial class ApplicationForm : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Apply",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    ContactAddress = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    PositionApplyingFor = table.Column<string>(nullable: true),
                    CanYouWorkInTheUK = table.Column<string>(nullable: true),
                    MobileNumber = table.Column<string>(nullable: true),
                    PostalCode = table.Column<int>(nullable: false),
                    YearsOfExperience = table.Column<int>(nullable: false),
                    PIN = table.Column<int>(nullable: false),
                    PINExpiryDate = table.Column<DateTime>(nullable: false),
                    NIN = table.Column<int>(nullable: false),
                    DateOfBirth = table.Column<DateTime>(nullable: false),
                    NextOfKinNames = table.Column<string>(nullable: true),
                    NextOfKinRelationship = table.Column<string>(nullable: true),
                    NextOfKinAddress = table.Column<string>(nullable: true),
                    NextOfKinPhoneNumber = table.Column<string>(nullable: true),
                    FirstEmploymentCompanyName = table.Column<string>(nullable: true),
                    FirstEmploymentCompanyAddress = table.Column<string>(nullable: true),
                    FirstEmploymentPosition = table.Column<string>(nullable: true),
                    FirstEmploymentResponsibilities = table.Column<string>(nullable: true),
                    FirstEmploymentReasonForLeaving = table.Column<string>(nullable: true),
                    FirstEmploymentDateFrom = table.Column<DateTime>(nullable: false),
                    FirstEmploymentDateTo = table.Column<DateTime>(nullable: false),
                    SecondEmploymentCompanyName = table.Column<string>(nullable: true),
                    SecondEmploymentCompanyAddress = table.Column<string>(nullable: true),
                    SecondEmploymentPosition = table.Column<string>(nullable: true),
                    SecondEmploymentResponsibilities = table.Column<string>(nullable: true),
                    SecondEmploymentReasonForLeaving = table.Column<string>(nullable: true),
                    SecondEmploymentDateFrom = table.Column<DateTime>(nullable: false),
                    SecondEmploymentDateTo = table.Column<DateTime>(nullable: false),
                    ThirdEmploymentCompanyName = table.Column<string>(nullable: true),
                    ThirdEmploymentCompanyAddress = table.Column<string>(nullable: true),
                    ThirdEmploymentPosition = table.Column<string>(nullable: true),
                    ThirdEmploymentResponsibilities = table.Column<string>(nullable: true),
                    ThirdEmploymentReasonForLeaving = table.Column<string>(nullable: true),
                    ThirdEmploymentDateFrom = table.Column<DateTime>(nullable: false),
                    ThirdEmploymentDateTo = table.Column<DateTime>(nullable: false),
                    FirstQualification = table.Column<string>(nullable: true),
                    FirstAwardingInstitution = table.Column<string>(nullable: true),
                    FirstDateAwarded = table.Column<DateTime>(nullable: false),
                    SecondQualification = table.Column<string>(nullable: true),
                    SecondAwardingInstitution = table.Column<string>(nullable: true),
                    SecondDateAwarded = table.Column<DateTime>(nullable: false),
                    ThirdQualification = table.Column<string>(nullable: true),
                    ThirdAwardingInstitution = table.Column<string>(nullable: true),
                    ThirdDateAwarded = table.Column<DateTime>(nullable: false),
                    ImmunizationName = table.Column<string>(nullable: true),
                    DateAdministered = table.Column<DateTime>(nullable: false),
                    Convicted = table.Column<string>(nullable: true),
                    TypeOfCrime = table.Column<string>(nullable: true),
                    Disabled = table.Column<string>(nullable: true),
                    TypeOfDisability = table.Column<string>(nullable: true),
                    RegisteredWithOtherAgents = table.Column<string>(nullable: true),
                    NameOfAgent = table.Column<string>(nullable: true),
                    FirstRefereeNames = table.Column<string>(nullable: true),
                    SecondRefereeNames = table.Column<string>(nullable: true),
                    HowDidYouKnowAboutUs = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Apply", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Apply");
        }
    }
}
