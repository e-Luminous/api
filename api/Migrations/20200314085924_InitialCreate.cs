using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace api.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Groups",
                columns: table => new
                {
                    GroupId = table.Column<string>(nullable: false),
                    GroupName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Groups", x => x.GroupId);
                });

            migrationBuilder.CreateTable(
                name: "Levels",
                columns: table => new
                {
                    LevelId = table.Column<string>(nullable: false),
                    LevelName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Levels", x => x.LevelId);
                });

            migrationBuilder.CreateTable(
                name: "PaymentMethods",
                columns: table => new
                {
                    MethodId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MethodName = table.Column<string>(nullable: true),
                    EndPoint = table.Column<string>(nullable: true),
                    OTPUrl = table.Column<string>(nullable: true),
                    TransactionUrl = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentMethods", x => x.MethodId);
                });

            migrationBuilder.CreateTable(
                name: "Regions",
                columns: table => new
                {
                    RegionId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RegionName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Regions", x => x.RegionId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LevelGroups",
                columns: table => new
                {
                    LevelId = table.Column<string>(nullable: false),
                    GroupId = table.Column<string>(nullable: false),
                    Price = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LevelGroups", x => new { x.LevelId, x.GroupId });
                    table.ForeignKey(
                        name: "FK_LevelGroups_Groups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Groups",
                        principalColumn: "GroupId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LevelGroups_Levels_LevelId",
                        column: x => x.LevelId,
                        principalTable: "Levels",
                        principalColumn: "LevelId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Transactions",
                columns: table => new
                {
                    TransactionId = table.Column<string>(nullable: false),
                    BillPaid = table.Column<double>(nullable: false),
                    DateOfTransaction = table.Column<DateTime>(nullable: false),
                    TransactionLog = table.Column<string>(nullable: true),
                    MethodId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transactions", x => x.TransactionId);
                    table.ForeignKey(
                        name: "FK_Transactions_PaymentMethods_MethodId",
                        column: x => x.MethodId,
                        principalTable: "PaymentMethods",
                        principalColumn: "MethodId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    CountryId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CountryName = table.Column<string>(nullable: true),
                    RegionId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.CountryId);
                    table.ForeignKey(
                        name: "FK_Countries_Regions_RegionId",
                        column: x => x.RegionId,
                        principalTable: "Regions",
                        principalColumn: "RegionId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Experiments",
                columns: table => new
                {
                    ExperimentId = table.Column<string>(nullable: false),
                    ExperimentName = table.Column<string>(nullable: true),
                    LevelGroupLevelId = table.Column<string>(nullable: true),
                    LevelGroupGroupId = table.Column<string>(nullable: true),
                    RegionId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Experiments", x => x.ExperimentId);
                    table.ForeignKey(
                        name: "FK_Experiments_Regions_RegionId",
                        column: x => x.RegionId,
                        principalTable: "Regions",
                        principalColumn: "RegionId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Experiments_LevelGroups_LevelGroupLevelId_LevelGroupGroupId",
                        columns: x => new { x.LevelGroupLevelId, x.LevelGroupGroupId },
                        principalTable: "LevelGroups",
                        principalColumns: new[] { "LevelId", "GroupId" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Institutions",
                columns: table => new
                {
                    InstitutionId = table.Column<string>(nullable: false),
                    InstitutionName = table.Column<string>(nullable: true),
                    Longitude = table.Column<string>(nullable: true),
                    Latitude = table.Column<string>(nullable: true),
                    UTC = table.Column<string>(nullable: true),
                    Domain = table.Column<string>(nullable: true),
                    CountryId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Institutions", x => x.InstitutionId);
                    table.ForeignKey(
                        name: "FK_Institutions_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "CountryId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "InstLevelGroups",
                columns: table => new
                {
                    InstitutionId = table.Column<string>(nullable: false),
                    LevelId = table.Column<string>(nullable: false),
                    GroupId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InstLevelGroups", x => new { x.InstitutionId, x.LevelId, x.GroupId });
                    table.ForeignKey(
                        name: "FK_InstLevelGroups_Institutions_InstitutionId",
                        column: x => x.InstitutionId,
                        principalTable: "Institutions",
                        principalColumn: "InstitutionId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InstLevelGroups_LevelGroups_LevelId_GroupId",
                        columns: x => new { x.LevelId, x.GroupId },
                        principalTable: "LevelGroups",
                        principalColumns: new[] { "LevelId", "GroupId" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Subscriptions",
                columns: table => new
                {
                    SubscriptionId = table.Column<string>(nullable: false),
                    ValidTill = table.Column<DateTime>(nullable: false),
                    InstitutionId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subscriptions", x => x.SubscriptionId);
                    table.ForeignKey(
                        name: "FK_Subscriptions_Institutions_InstitutionId",
                        column: x => x.InstitutionId,
                        principalTable: "Institutions",
                        principalColumn: "InstitutionId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Subscriptions_Transactions_SubscriptionId",
                        column: x => x.SubscriptionId,
                        principalTable: "Transactions",
                        principalColumn: "TransactionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Instructors",
                columns: table => new
                {
                    InstructorId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    InstructorName = table.Column<string>(nullable: true),
                    EmployeeId = table.Column<string>(nullable: true),
                    Shift = table.Column<string>(nullable: true),
                    Bio = table.Column<string>(nullable: true),
                    ProfilePictureUrl = table.Column<string>(nullable: true),
                    CoverImageUrl = table.Column<string>(nullable: true),
                    InstLevelGroupInstitutionId = table.Column<string>(nullable: true),
                    InstLevelGroupLevelId = table.Column<string>(nullable: true),
                    InstLevelGroupGroupId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instructors", x => x.InstructorId);
                    table.ForeignKey(
                        name: "FK_Instructors_InstLevelGroups_InstLevelGroupInstitutionId_InstLevelGroupLevelId_InstLevelGroupGroupId",
                        columns: x => new { x.InstLevelGroupInstitutionId, x.InstLevelGroupLevelId, x.InstLevelGroupGroupId },
                        principalTable: "InstLevelGroups",
                        principalColumns: new[] { "InstitutionId", "LevelId", "GroupId" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PreAuthLists",
                columns: table => new
                {
                    PreAuthId = table.Column<string>(nullable: false),
                    Mail = table.Column<string>(nullable: true),
                    InstLevelGroupInstitutionId = table.Column<string>(nullable: true),
                    InstLevelGroupLevelId = table.Column<string>(nullable: true),
                    InstLevelGroupGroupId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PreAuthLists", x => x.PreAuthId);
                    table.ForeignKey(
                        name: "FK_PreAuthLists_InstLevelGroups_InstLevelGroupInstitutionId_InstLevelGroupLevelId_InstLevelGroupGroupId",
                        columns: x => new { x.InstLevelGroupInstitutionId, x.InstLevelGroupLevelId, x.InstLevelGroupGroupId },
                        principalTable: "InstLevelGroups",
                        principalColumns: new[] { "InstitutionId", "LevelId", "GroupId" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudentId = table.Column<string>(nullable: false),
                    StudentName = table.Column<string>(nullable: true),
                    InstitutionId = table.Column<string>(nullable: true),
                    Shift = table.Column<string>(nullable: true),
                    ProfilePictureUrl = table.Column<string>(nullable: true),
                    CoverImageUrl = table.Column<string>(nullable: true),
                    ILGInstitutionId = table.Column<string>(nullable: true),
                    ILGLevelId = table.Column<string>(nullable: true),
                    ILGGroupId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentId);
                    table.ForeignKey(
                        name: "FK_Students_InstLevelGroups_ILGInstitutionId_ILGLevelId_ILGGroupId",
                        columns: x => new { x.ILGInstitutionId, x.ILGLevelId, x.ILGGroupId },
                        principalTable: "InstLevelGroups",
                        principalColumns: new[] { "InstitutionId", "LevelId", "GroupId" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Classrooms",
                columns: table => new
                {
                    ClassroomId = table.Column<string>(nullable: false),
                    ClassroomTitle = table.Column<string>(nullable: true),
                    AccessCode = table.Column<string>(nullable: true),
                    IllustrationUrl = table.Column<string>(nullable: true),
                    Theme = table.Column<string>(nullable: true),
                    ILGInstitutionId = table.Column<string>(nullable: true),
                    ILGLevelId = table.Column<string>(nullable: true),
                    ILGGroupId = table.Column<string>(nullable: true),
                    InstructorId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classrooms", x => x.ClassroomId);
                    table.ForeignKey(
                        name: "FK_Classrooms_Instructors_InstructorId",
                        column: x => x.InstructorId,
                        principalTable: "Instructors",
                        principalColumn: "InstructorId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Classrooms_InstLevelGroups_ILGInstitutionId_ILGLevelId_ILGGroupId",
                        columns: x => new { x.ILGInstitutionId, x.ILGLevelId, x.ILGGroupId },
                        principalTable: "InstLevelGroups",
                        principalColumns: new[] { "InstitutionId", "LevelId", "GroupId" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ExpClasses",
                columns: table => new
                {
                    ExperimentId = table.Column<string>(nullable: false),
                    ClassroomId = table.Column<string>(nullable: false),
                    MarksScale = table.Column<double>(nullable: false),
                    IsPrivate = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExpClasses", x => new { x.ExperimentId, x.ClassroomId });
                    table.ForeignKey(
                        name: "FK_ExpClasses_Classrooms_ClassroomId",
                        column: x => x.ClassroomId,
                        principalTable: "Classrooms",
                        principalColumn: "ClassroomId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExpClasses_Experiments_ExperimentId",
                        column: x => x.ExperimentId,
                        principalTable: "Experiments",
                        principalColumn: "ExperimentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StudentEnrollments",
                columns: table => new
                {
                    StudentId = table.Column<string>(nullable: false),
                    ClassroomId = table.Column<string>(nullable: false),
                    ExperimentId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentEnrollments", x => new { x.StudentId, x.ClassroomId });
                    table.ForeignKey(
                        name: "FK_StudentEnrollments_Experiments_ExperimentId",
                        column: x => x.ExperimentId,
                        principalTable: "Experiments",
                        principalColumn: "ExperimentId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StudentEnrollments_Classrooms_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Classrooms",
                        principalColumn: "ClassroomId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentEnrollments_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Submissions",
                columns: table => new
                {
                    SubmissionId = table.Column<string>(nullable: false),
                    ObservationJSON = table.Column<string>(nullable: true),
                    MarksGiven = table.Column<double>(nullable: false),
                    Status = table.Column<string>(nullable: true),
                    ExpClassExperimentId = table.Column<string>(nullable: true),
                    ExpClassClassroomId = table.Column<string>(nullable: true),
                    StudentId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Submissions", x => x.SubmissionId);
                    table.ForeignKey(
                        name: "FK_Submissions_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Submissions_ExpClasses_ExpClassExperimentId_ExpClassClassroomId",
                        columns: x => new { x.ExpClassExperimentId, x.ExpClassClassroomId },
                        principalTable: "ExpClasses",
                        principalColumns: new[] { "ExperimentId", "ClassroomId" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Classrooms_InstructorId",
                table: "Classrooms",
                column: "InstructorId");

            migrationBuilder.CreateIndex(
                name: "IX_Classrooms_ILGInstitutionId_ILGLevelId_ILGGroupId",
                table: "Classrooms",
                columns: new[] { "ILGInstitutionId", "ILGLevelId", "ILGGroupId" });

            migrationBuilder.CreateIndex(
                name: "IX_Countries_RegionId",
                table: "Countries",
                column: "RegionId");

            migrationBuilder.CreateIndex(
                name: "IX_ExpClasses_ClassroomId",
                table: "ExpClasses",
                column: "ClassroomId");

            migrationBuilder.CreateIndex(
                name: "IX_Experiments_RegionId",
                table: "Experiments",
                column: "RegionId");

            migrationBuilder.CreateIndex(
                name: "IX_Experiments_LevelGroupLevelId_LevelGroupGroupId",
                table: "Experiments",
                columns: new[] { "LevelGroupLevelId", "LevelGroupGroupId" });

            migrationBuilder.CreateIndex(
                name: "IX_Institutions_CountryId",
                table: "Institutions",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_InstLevelGroups_LevelId_GroupId",
                table: "InstLevelGroups",
                columns: new[] { "LevelId", "GroupId" });

            migrationBuilder.CreateIndex(
                name: "IX_Instructors_InstLevelGroupInstitutionId_InstLevelGroupLevelId_InstLevelGroupGroupId",
                table: "Instructors",
                columns: new[] { "InstLevelGroupInstitutionId", "InstLevelGroupLevelId", "InstLevelGroupGroupId" });

            migrationBuilder.CreateIndex(
                name: "IX_LevelGroups_GroupId",
                table: "LevelGroups",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_PreAuthLists_InstLevelGroupInstitutionId_InstLevelGroupLevelId_InstLevelGroupGroupId",
                table: "PreAuthLists",
                columns: new[] { "InstLevelGroupInstitutionId", "InstLevelGroupLevelId", "InstLevelGroupGroupId" });

            migrationBuilder.CreateIndex(
                name: "IX_StudentEnrollments_ExperimentId",
                table: "StudentEnrollments",
                column: "ExperimentId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_ILGInstitutionId_ILGLevelId_ILGGroupId",
                table: "Students",
                columns: new[] { "ILGInstitutionId", "ILGLevelId", "ILGGroupId" });

            migrationBuilder.CreateIndex(
                name: "IX_Submissions_StudentId",
                table: "Submissions",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Submissions_ExpClassExperimentId_ExpClassClassroomId",
                table: "Submissions",
                columns: new[] { "ExpClassExperimentId", "ExpClassClassroomId" });

            migrationBuilder.CreateIndex(
                name: "IX_Subscriptions_InstitutionId",
                table: "Subscriptions",
                column: "InstitutionId");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_MethodId",
                table: "Transactions",
                column: "MethodId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "PreAuthLists");

            migrationBuilder.DropTable(
                name: "StudentEnrollments");

            migrationBuilder.DropTable(
                name: "Submissions");

            migrationBuilder.DropTable(
                name: "Subscriptions");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "ExpClasses");

            migrationBuilder.DropTable(
                name: "Transactions");

            migrationBuilder.DropTable(
                name: "Classrooms");

            migrationBuilder.DropTable(
                name: "Experiments");

            migrationBuilder.DropTable(
                name: "PaymentMethods");

            migrationBuilder.DropTable(
                name: "Instructors");

            migrationBuilder.DropTable(
                name: "InstLevelGroups");

            migrationBuilder.DropTable(
                name: "Institutions");

            migrationBuilder.DropTable(
                name: "LevelGroups");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "Groups");

            migrationBuilder.DropTable(
                name: "Levels");

            migrationBuilder.DropTable(
                name: "Regions");
        }
    }
}
