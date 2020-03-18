﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using api.Models;

namespace api.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

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
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("api.Models.Classroom", b =>
                {
                    b.Property<string>("ClassroomId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AccessCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClassroomTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ILGGroupId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ILGInstitutionId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ILGLevelId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("IllustrationUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InstructorId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Theme")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ClassroomId");

                    b.HasIndex("InstructorId");

                    b.HasIndex("ILGInstitutionId", "ILGLevelId", "ILGGroupId");

                    b.ToTable("Classrooms");
                });

            modelBuilder.Entity("api.Models.Country", b =>
                {
                    b.Property<int>("CountryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CountryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("RegionId")
                        .HasColumnType("int");

                    b.HasKey("CountryId");

                    b.HasIndex("RegionId");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("api.Models.ExpClass", b =>
                {
                    b.Property<string>("ExperimentId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ClassroomId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("IsPrivate")
                        .HasColumnType("bit");

                    b.Property<double>("MarksScale")
                        .HasColumnType("float");

                    b.HasKey("ExperimentId", "ClassroomId");

                    b.HasIndex("ClassroomId");

                    b.ToTable("ExpClasses");
                });

            modelBuilder.Entity("api.Models.Experiment", b =>
                {
                    b.Property<string>("ExperimentId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ExperimentName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LevelGroupGroupId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LevelGroupLevelId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("RegionId")
                        .HasColumnType("int");

                    b.HasKey("ExperimentId");

                    b.HasIndex("RegionId");

                    b.HasIndex("LevelGroupLevelId", "LevelGroupGroupId");

                    b.ToTable("Experiments");
                });

            modelBuilder.Entity("api.Models.Group", b =>
                {
                    b.Property<string>("GroupId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("GroupName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GroupId");

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("api.Models.InstLevelGroup", b =>
                {
                    b.Property<string>("InstitutionId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LevelId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("GroupId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("InstitutionId", "LevelId", "GroupId");

                    b.HasIndex("LevelId", "GroupId");

                    b.ToTable("InstLevelGroups");
                });

            modelBuilder.Entity("api.Models.Institution", b =>
                {
                    b.Property<string>("InstitutionId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("Domain")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InstitutionName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Latitude")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Longitude")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UTC")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UsersId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("InstitutionId");

                    b.HasIndex("CountryId");

                    b.HasIndex("UsersId");

                    b.ToTable("Institutions");
                });

            modelBuilder.Entity("api.Models.Instructor", b =>
                {
                    b.Property<string>("InstructorId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Bio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CoverImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmployeeId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InstLevelGroupGroupId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("InstLevelGroupInstitutionId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("InstLevelGroupLevelId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("InstructorName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProfilePictureUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Shift")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UsersId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("InstructorId");

                    b.HasIndex("UsersId");

                    b.HasIndex("InstLevelGroupInstitutionId", "InstLevelGroupLevelId", "InstLevelGroupGroupId");

                    b.ToTable("Instructors");
                });

            modelBuilder.Entity("api.Models.Level", b =>
                {
                    b.Property<string>("LevelId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LevelName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LevelId");

                    b.ToTable("Levels");
                });

            modelBuilder.Entity("api.Models.LevelGroup", b =>
                {
                    b.Property<string>("LevelId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("GroupId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("LevelId", "GroupId");

                    b.HasIndex("GroupId");

                    b.ToTable("LevelGroups");
                });

            modelBuilder.Entity("api.Models.PaymentMethod", b =>
                {
                    b.Property<int>("MethodId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EndPoint")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MethodName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OTPUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TransactionUrl")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MethodId");

                    b.ToTable("PaymentMethods");
                });

            modelBuilder.Entity("api.Models.PreAuthList", b =>
                {
                    b.Property<string>("PreAuthId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("InstLevelGroupGroupId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("InstLevelGroupInstitutionId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("InstLevelGroupLevelId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Mail")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PreAuthId");

                    b.HasIndex("InstLevelGroupInstitutionId", "InstLevelGroupLevelId", "InstLevelGroupGroupId");

                    b.ToTable("PreAuthLists");
                });

            modelBuilder.Entity("api.Models.Region", b =>
                {
                    b.Property<int>("RegionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("RegionName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RegionId");

                    b.ToTable("Regions");
                });

            modelBuilder.Entity("api.Models.Student", b =>
                {
                    b.Property<string>("StudentId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CoverImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ILGGroupId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ILGInstitutionId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ILGLevelId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("InstitutionId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProfilePictureUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Shift")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StudentName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UsersId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("StudentId");

                    b.HasIndex("UsersId");

                    b.HasIndex("ILGInstitutionId", "ILGLevelId", "ILGGroupId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("api.Models.StudentEnrollment", b =>
                {
                    b.Property<string>("StudentId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ClassroomId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ExperimentId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("StudentId", "ClassroomId");

                    b.HasIndex("ExperimentId");

                    b.ToTable("StudentEnrollments");
                });

            modelBuilder.Entity("api.Models.Submission", b =>
                {
                    b.Property<string>("SubmissionId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ExpClassClassroomId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ExpClassExperimentId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<double>("MarksGiven")
                        .HasColumnType("float");

                    b.Property<string>("ObservationJSON")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StudentId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("SubmissionId");

                    b.HasIndex("StudentId");

                    b.HasIndex("ExpClassExperimentId", "ExpClassClassroomId");

                    b.ToTable("Submissions");
                });

            modelBuilder.Entity("api.Models.Subscription", b =>
                {
                    b.Property<string>("SubscriptionId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("InstitutionId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("ValidTill")
                        .HasColumnType("datetime2");

                    b.HasKey("SubscriptionId");

                    b.HasIndex("InstitutionId");

                    b.ToTable("Subscriptions");
                });

            modelBuilder.Entity("api.Models.Transaction", b =>
                {
                    b.Property<string>("TransactionId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<double>("BillPaid")
                        .HasColumnType("float");

                    b.Property<DateTime>("DateOfTransaction")
                        .HasColumnType("datetime2");

                    b.Property<int?>("MethodId")
                        .HasColumnType("int");

                    b.Property<string>("TransactionLog")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TransactionId");

                    b.HasIndex("MethodId");

                    b.ToTable("Transactions");
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

            modelBuilder.Entity("api.Models.Classroom", b =>
                {
                    b.HasOne("api.Models.Instructor", "Instructor")
                        .WithMany("Classes")
                        .HasForeignKey("InstructorId");

                    b.HasOne("api.Models.InstLevelGroup", "ILG")
                        .WithMany()
                        .HasForeignKey("ILGInstitutionId", "ILGLevelId", "ILGGroupId");
                });

            modelBuilder.Entity("api.Models.Country", b =>
                {
                    b.HasOne("api.Models.Region", "Region")
                        .WithMany("Countries")
                        .HasForeignKey("RegionId");
                });

            modelBuilder.Entity("api.Models.ExpClass", b =>
                {
                    b.HasOne("api.Models.Classroom", "Classroom")
                        .WithMany("ExpClass")
                        .HasForeignKey("ClassroomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("api.Models.Experiment", "Experiment")
                        .WithMany("ExpClass")
                        .HasForeignKey("ExperimentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("api.Models.Experiment", b =>
                {
                    b.HasOne("api.Models.Region", "Region")
                        .WithMany("Exps")
                        .HasForeignKey("RegionId");

                    b.HasOne("api.Models.LevelGroup", "LevelGroup")
                        .WithMany("Exps")
                        .HasForeignKey("LevelGroupLevelId", "LevelGroupGroupId");
                });

            modelBuilder.Entity("api.Models.InstLevelGroup", b =>
                {
                    b.HasOne("api.Models.Institution", "Institution")
                        .WithMany("InstLevelGroup")
                        .HasForeignKey("InstitutionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("api.Models.LevelGroup", "LevelGroup")
                        .WithMany("InstLevelGroups")
                        .HasForeignKey("LevelId", "GroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("api.Models.Institution", b =>
                {
                    b.HasOne("api.Models.Country", "Country")
                        .WithMany("Institutions")
                        .HasForeignKey("CountryId");

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "Users")
                        .WithMany()
                        .HasForeignKey("UsersId");
                });

            modelBuilder.Entity("api.Models.Instructor", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "Users")
                        .WithMany()
                        .HasForeignKey("UsersId");

                    b.HasOne("api.Models.InstLevelGroup", "InstLevelGroup")
                        .WithMany("Instructors")
                        .HasForeignKey("InstLevelGroupInstitutionId", "InstLevelGroupLevelId", "InstLevelGroupGroupId");
                });

            modelBuilder.Entity("api.Models.LevelGroup", b =>
                {
                    b.HasOne("api.Models.Group", "Group")
                        .WithMany("LevelGroups")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("api.Models.Level", "Level")
                        .WithMany("LevelGroups")
                        .HasForeignKey("LevelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("api.Models.PreAuthList", b =>
                {
                    b.HasOne("api.Models.InstLevelGroup", "InstLevelGroup")
                        .WithMany("PreAuthList")
                        .HasForeignKey("InstLevelGroupInstitutionId", "InstLevelGroupLevelId", "InstLevelGroupGroupId");
                });

            modelBuilder.Entity("api.Models.Student", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "Users")
                        .WithMany()
                        .HasForeignKey("UsersId");

                    b.HasOne("api.Models.InstLevelGroup", "ILG")
                        .WithMany("Students")
                        .HasForeignKey("ILGInstitutionId", "ILGLevelId", "ILGGroupId");
                });

            modelBuilder.Entity("api.Models.StudentEnrollment", b =>
                {
                    b.HasOne("api.Models.Experiment", null)
                        .WithMany("StudentEnr")
                        .HasForeignKey("ExperimentId");

                    b.HasOne("api.Models.Classroom", "Classroom")
                        .WithMany("StudentEnr")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("api.Models.Student", "Student")
                        .WithMany("StudentEnr")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("api.Models.Submission", b =>
                {
                    b.HasOne("api.Models.Student", "Student")
                        .WithMany("Subs")
                        .HasForeignKey("StudentId");

                    b.HasOne("api.Models.ExpClass", "ExpClass")
                        .WithMany("Subs")
                        .HasForeignKey("ExpClassExperimentId", "ExpClassClassroomId");
                });

            modelBuilder.Entity("api.Models.Subscription", b =>
                {
                    b.HasOne("api.Models.Institution", "Institution")
                        .WithMany("Subscribed")
                        .HasForeignKey("InstitutionId");

                    b.HasOne("api.Models.Transaction", "Transaction")
                        .WithOne("Subscription")
                        .HasForeignKey("api.Models.Subscription", "SubscriptionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("api.Models.Transaction", b =>
                {
                    b.HasOne("api.Models.PaymentMethod", "Method")
                        .WithMany("Transcs")
                        .HasForeignKey("MethodId");
                });
#pragma warning restore 612, 618
        }
    }
}
