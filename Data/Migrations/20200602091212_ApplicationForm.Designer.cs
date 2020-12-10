﻿// <auto-generated />
using System;
using AccessJob.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AccessJob.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20200602091212_ApplicationForm")]
    partial class ApplicationForm
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AccessJob.Models.Apply", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CanYouWorkInTheUK")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Convicted")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateAdministered")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Disabled")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstAwardingInstitution")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FirstDateAwarded")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstEmploymentCompanyAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstEmploymentCompanyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FirstEmploymentDateFrom")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FirstEmploymentDateTo")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstEmploymentPosition")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstEmploymentReasonForLeaving")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstEmploymentResponsibilities")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstQualification")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstRefereeNames")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HowDidYouKnowAboutUs")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImmunizationName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MobileNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NIN")
                        .HasColumnType("int");

                    b.Property<string>("NameOfAgent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NextOfKinAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NextOfKinNames")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NextOfKinPhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NextOfKinRelationship")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PIN")
                        .HasColumnType("int");

                    b.Property<DateTime>("PINExpiryDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("PositionApplyingFor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PostalCode")
                        .HasColumnType("int");

                    b.Property<string>("RegisteredWithOtherAgents")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecondAwardingInstitution")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("SecondDateAwarded")
                        .HasColumnType("datetime2");

                    b.Property<string>("SecondEmploymentCompanyAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecondEmploymentCompanyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("SecondEmploymentDateFrom")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("SecondEmploymentDateTo")
                        .HasColumnType("datetime2");

                    b.Property<string>("SecondEmploymentPosition")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecondEmploymentReasonForLeaving")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecondEmploymentResponsibilities")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecondQualification")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecondRefereeNames")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ThirdAwardingInstitution")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ThirdDateAwarded")
                        .HasColumnType("datetime2");

                    b.Property<string>("ThirdEmploymentCompanyAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ThirdEmploymentCompanyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ThirdEmploymentDateFrom")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ThirdEmploymentDateTo")
                        .HasColumnType("datetime2");

                    b.Property<string>("ThirdEmploymentPosition")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ThirdEmploymentReasonForLeaving")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ThirdEmploymentResponsibilities")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ThirdQualification")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TypeOfCrime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TypeOfDisability")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("YearsOfExperience")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Apply");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
