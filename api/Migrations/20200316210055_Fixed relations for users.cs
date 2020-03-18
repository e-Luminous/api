using Microsoft.EntityFrameworkCore.Migrations;

namespace api.Migrations
{
    public partial class Fixedrelationsforusers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UsersId",
                table: "Students",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UsersId",
                table: "Instructors",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UsersId",
                table: "Institutions",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    RoleId = table.Column<string>(nullable: false),
                    RoleName = table.Column<string>(nullable: true),
                    NormalizedName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.RoleId);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(nullable: true),
                    Mobile = table.Column<string>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: false),
                    MobileConfirmed = table.Column<bool>(nullable: false),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnabled = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserRole",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRole", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserRole_Role_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Role",
                        principalColumn: "RoleId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserRole_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Students_UsersId",
                table: "Students",
                column: "UsersId");

            migrationBuilder.CreateIndex(
                name: "IX_Instructors_UsersId",
                table: "Instructors",
                column: "UsersId");

            migrationBuilder.CreateIndex(
                name: "IX_Institutions_UsersId",
                table: "Institutions",
                column: "UsersId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRole_RoleId",
                table: "UserRole",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRole_UserId",
                table: "UserRole",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Institutions_User_UsersId",
                table: "Institutions",
                column: "UsersId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Instructors_User_UsersId",
                table: "Instructors",
                column: "UsersId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_User_UsersId",
                table: "Students",
                column: "UsersId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Institutions_User_UsersId",
                table: "Institutions");

            migrationBuilder.DropForeignKey(
                name: "FK_Instructors_User_UsersId",
                table: "Instructors");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_User_UsersId",
                table: "Students");

            migrationBuilder.DropTable(
                name: "UserRole");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropIndex(
                name: "IX_Students_UsersId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Instructors_UsersId",
                table: "Instructors");

            migrationBuilder.DropIndex(
                name: "IX_Institutions_UsersId",
                table: "Institutions");

            migrationBuilder.DropColumn(
                name: "UsersId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "UsersId",
                table: "Instructors");

            migrationBuilder.DropColumn(
                name: "UsersId",
                table: "Institutions");
        }
    }
}
