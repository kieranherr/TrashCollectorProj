using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Migrations
{
    public partial class Migration3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cfe8178c-4d11-44f7-849d-cdf3fc11e907");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "fab573e2-3d2c-4730-9116-7322eb524d66", "c63267ee-4fed-4311-830a-4f44349abfb1", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f3b9fbce-a595-45f2-9d7a-462892de320d", "029f1724-274f-422f-8446-ed73c5c804d4", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f9bc2fa1-33f2-4428-800f-dc4577f6f652", "c5c22b7d-a136-49ca-8043-87daef53b7bf", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f3b9fbce-a595-45f2-9d7a-462892de320d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f9bc2fa1-33f2-4428-800f-dc4577f6f652");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fab573e2-3d2c-4730-9116-7322eb524d66");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "cfe8178c-4d11-44f7-849d-cdf3fc11e907", "a52166c8-4fa6-4d68-87b5-eb7027ab6ae7", "Admin", "ADMIN" });
        }
    }
}
