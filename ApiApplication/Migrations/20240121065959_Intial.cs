using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiApplication.Migrations
{
    public partial class Intial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Lastname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsVerified = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserID);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    RoleID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UsersUserID = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.RoleID);
                    table.ForeignKey(
                        name: "FK_Roles_Users_UsersUserID",
                        column: x => x.UsersUserID,
                        principalTable: "Users",
                        principalColumn: "UserID");
                });

            migrationBuilder.CreateTable(
                name: "Userroles",
                columns: table => new
                {
                    UserRoleID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    RoleID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Userroles", x => x.UserRoleID);
                    table.ForeignKey(
                        name: "FK_Userroles_Roles_RoleID",
                        column: x => x.RoleID,
                        principalTable: "Roles",
                        principalColumn: "RoleID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleID", "CreatedBy", "CreatedDate", "IsActive", "IsDeleted", "ModifiedBy", "ModifiedDate", "RoleName", "UsersUserID" },
                values: new object[] { 1, null, new DateTime(2024, 1, 21, 6, 59, 59, 415, DateTimeKind.Utc).AddTicks(3433), true, false, null, new DateTime(2024, 1, 21, 6, 59, 59, 415, DateTimeKind.Utc).AddTicks(3436), "Admin", null });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleID", "CreatedBy", "CreatedDate", "IsActive", "IsDeleted", "ModifiedBy", "ModifiedDate", "RoleName", "UsersUserID" },
                values: new object[] { 2, null, new DateTime(2024, 1, 21, 6, 59, 59, 415, DateTimeKind.Utc).AddTicks(3437), true, false, null, new DateTime(2024, 1, 21, 6, 59, 59, 415, DateTimeKind.Utc).AddTicks(3437), "Company", null });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleID", "CreatedBy", "CreatedDate", "IsActive", "IsDeleted", "ModifiedBy", "ModifiedDate", "RoleName", "UsersUserID" },
                values: new object[] { 3, null, new DateTime(2024, 1, 21, 6, 59, 59, 415, DateTimeKind.Utc).AddTicks(3438), true, false, null, new DateTime(2024, 1, 21, 6, 59, 59, 415, DateTimeKind.Utc).AddTicks(3438), "Candidate", null });

            migrationBuilder.CreateIndex(
                name: "IX_Roles_UsersUserID",
                table: "Roles",
                column: "UsersUserID");

            migrationBuilder.CreateIndex(
                name: "IX_Userroles_RoleID",
                table: "Userroles",
                column: "RoleID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Userroles");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
