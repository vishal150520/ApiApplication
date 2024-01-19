using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiApplication.Migrations
{
    public partial class AddRole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleID", "CreatedBy", "CreatedDate", "IdentityRoleID", "IsActive", "IsDeleted", "ModifiedBy", "ModifiedDate", "RoleName" },
                values: new object[] { 1, null, new DateTime(2024, 1, 19, 7, 12, 19, 980, DateTimeKind.Utc).AddTicks(3832), "", true, false, null, new DateTime(2024, 1, 19, 7, 12, 19, 980, DateTimeKind.Utc).AddTicks(3836), "Admin" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleID", "CreatedBy", "CreatedDate", "IdentityRoleID", "IsActive", "IsDeleted", "ModifiedBy", "ModifiedDate", "RoleName" },
                values: new object[] { 2, null, new DateTime(2024, 1, 19, 7, 12, 19, 980, DateTimeKind.Utc).AddTicks(3838), "", true, false, null, new DateTime(2024, 1, 19, 7, 12, 19, 980, DateTimeKind.Utc).AddTicks(3839), "Company" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleID", "CreatedBy", "CreatedDate", "IdentityRoleID", "IsActive", "IsDeleted", "ModifiedBy", "ModifiedDate", "RoleName" },
                values: new object[] { 3, null, new DateTime(2024, 1, 19, 7, 12, 19, 980, DateTimeKind.Utc).AddTicks(3840), "", true, false, null, new DateTime(2024, 1, 19, 7, 12, 19, 980, DateTimeKind.Utc).AddTicks(3841), "Candidate" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 3);
        }
    }
}
