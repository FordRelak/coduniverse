using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Coduniverse.Infrastructure.EF.Migrations
{
    public partial class MakeFieldNotRequired : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_starSystems_spaceObjects_CenterMassId",
                table: "starSystems");

            migrationBuilder.UpdateData(
                table: "spaceObjects",
                keyColumn: "Id",
                keyValue: new Guid("091b4caf-f9ea-4fbb-8a32-e3a80cfc3e14"),
                columns: new[] { "Age", "CreatedAt", "Diameter", "Mass", "UpdatedAt" },
                values: new object[] { 1213000259, new DateTimeOffset(new DateTime(2022, 3, 27, 19, 8, 23, 192, DateTimeKind.Unspecified).AddTicks(7541), new TimeSpan(0, 0, 0, 0, 0)), 1987989335, 1426833673, new DateTimeOffset(new DateTime(2022, 3, 27, 19, 8, 23, 192, DateTimeKind.Unspecified).AddTicks(7541), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "spaceObjects",
                keyColumn: "Id",
                keyValue: new Guid("340aa24a-9ee2-4514-875f-41cf64126a85"),
                columns: new[] { "Age", "CreatedAt", "Diameter", "Mass", "UpdatedAt" },
                values: new object[] { 780060360, new DateTimeOffset(new DateTime(2022, 3, 27, 19, 8, 23, 192, DateTimeKind.Unspecified).AddTicks(7541), new TimeSpan(0, 0, 0, 0, 0)), 737366613, 982480371, new DateTimeOffset(new DateTime(2022, 3, 27, 19, 8, 23, 192, DateTimeKind.Unspecified).AddTicks(7541), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "spaceObjects",
                keyColumn: "Id",
                keyValue: new Guid("60269d83-0267-4896-a067-377b8a4afb3d"),
                columns: new[] { "Age", "CreatedAt", "Diameter", "Mass", "UpdatedAt" },
                values: new object[] { 312695790, new DateTimeOffset(new DateTime(2022, 3, 27, 19, 8, 23, 192, DateTimeKind.Unspecified).AddTicks(7541), new TimeSpan(0, 0, 0, 0, 0)), 965469162, 1205821667, new DateTimeOffset(new DateTime(2022, 3, 27, 19, 8, 23, 192, DateTimeKind.Unspecified).AddTicks(7541), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "spaceObjects",
                keyColumn: "Id",
                keyValue: new Guid("970ba570-e757-48b0-84cc-52235a35a10c"),
                columns: new[] { "Age", "CreatedAt", "Diameter", "Mass", "UpdatedAt" },
                values: new object[] { 120079022, new DateTimeOffset(new DateTime(2022, 3, 27, 19, 8, 23, 192, DateTimeKind.Unspecified).AddTicks(7541), new TimeSpan(0, 0, 0, 0, 0)), 743058886, 748981882, new DateTimeOffset(new DateTime(2022, 3, 27, 19, 8, 23, 192, DateTimeKind.Unspecified).AddTicks(7541), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "spaceObjects",
                keyColumn: "Id",
                keyValue: new Guid("b184eaea-de80-47e1-a0af-ce08d93a7524"),
                columns: new[] { "Age", "CreatedAt", "Diameter", "Mass", "UpdatedAt" },
                values: new object[] { 1738318932, new DateTimeOffset(new DateTime(2022, 3, 27, 19, 8, 23, 192, DateTimeKind.Unspecified).AddTicks(7541), new TimeSpan(0, 0, 0, 0, 0)), 1219304020, 1051858076, new DateTimeOffset(new DateTime(2022, 3, 27, 19, 8, 23, 192, DateTimeKind.Unspecified).AddTicks(7541), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "spaceObjects",
                keyColumn: "Id",
                keyValue: new Guid("cff1a755-d896-4e57-8aa1-82df408639ee"),
                columns: new[] { "Age", "CreatedAt", "Diameter", "Mass", "UpdatedAt" },
                values: new object[] { 1287438364, new DateTimeOffset(new DateTime(2022, 3, 27, 19, 8, 23, 192, DateTimeKind.Unspecified).AddTicks(7541), new TimeSpan(0, 0, 0, 0, 0)), 369615397, 719317324, new DateTimeOffset(new DateTime(2022, 3, 27, 19, 8, 23, 192, DateTimeKind.Unspecified).AddTicks(7541), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "starSystems",
                keyColumn: "Id",
                keyValue: new Guid("e8e87f06-eb9e-40e5-a9ca-2740da47bf61"),
                columns: new[] { "Age", "CreatedAt", "UpdatedAt" },
                values: new object[] { 797823801, new DateTimeOffset(new DateTime(2022, 3, 27, 19, 8, 23, 192, DateTimeKind.Unspecified).AddTicks(7541), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 3, 27, 19, 8, 23, 192, DateTimeKind.Unspecified).AddTicks(7541), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.AddForeignKey(
                name: "FK_starSystems_spaceObjects_CenterMassId",
                table: "starSystems",
                column: "CenterMassId",
                principalTable: "spaceObjects",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_starSystems_spaceObjects_CenterMassId",
                table: "starSystems");

            migrationBuilder.UpdateData(
                table: "spaceObjects",
                keyColumn: "Id",
                keyValue: new Guid("091b4caf-f9ea-4fbb-8a32-e3a80cfc3e14"),
                columns: new[] { "Age", "CreatedAt", "Diameter", "Mass", "UpdatedAt" },
                values: new object[] { 20425567, new DateTimeOffset(new DateTime(2022, 3, 27, 17, 37, 9, 812, DateTimeKind.Unspecified).AddTicks(9817), new TimeSpan(0, 0, 0, 0, 0)), 1609408531, 1225736035, new DateTimeOffset(new DateTime(2022, 3, 27, 17, 37, 9, 812, DateTimeKind.Unspecified).AddTicks(9817), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "spaceObjects",
                keyColumn: "Id",
                keyValue: new Guid("340aa24a-9ee2-4514-875f-41cf64126a85"),
                columns: new[] { "Age", "CreatedAt", "Diameter", "Mass", "UpdatedAt" },
                values: new object[] { 1179832462, new DateTimeOffset(new DateTime(2022, 3, 27, 17, 37, 9, 812, DateTimeKind.Unspecified).AddTicks(9817), new TimeSpan(0, 0, 0, 0, 0)), 1972878382, 667828408, new DateTimeOffset(new DateTime(2022, 3, 27, 17, 37, 9, 812, DateTimeKind.Unspecified).AddTicks(9817), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "spaceObjects",
                keyColumn: "Id",
                keyValue: new Guid("60269d83-0267-4896-a067-377b8a4afb3d"),
                columns: new[] { "Age", "CreatedAt", "Diameter", "Mass", "UpdatedAt" },
                values: new object[] { 1865898124, new DateTimeOffset(new DateTime(2022, 3, 27, 17, 37, 9, 812, DateTimeKind.Unspecified).AddTicks(9817), new TimeSpan(0, 0, 0, 0, 0)), 1886774005, 1810759129, new DateTimeOffset(new DateTime(2022, 3, 27, 17, 37, 9, 812, DateTimeKind.Unspecified).AddTicks(9817), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "spaceObjects",
                keyColumn: "Id",
                keyValue: new Guid("970ba570-e757-48b0-84cc-52235a35a10c"),
                columns: new[] { "Age", "CreatedAt", "Diameter", "Mass", "UpdatedAt" },
                values: new object[] { 1237780259, new DateTimeOffset(new DateTime(2022, 3, 27, 17, 37, 9, 812, DateTimeKind.Unspecified).AddTicks(9817), new TimeSpan(0, 0, 0, 0, 0)), 1548148094, 1755329019, new DateTimeOffset(new DateTime(2022, 3, 27, 17, 37, 9, 812, DateTimeKind.Unspecified).AddTicks(9817), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "spaceObjects",
                keyColumn: "Id",
                keyValue: new Guid("b184eaea-de80-47e1-a0af-ce08d93a7524"),
                columns: new[] { "Age", "CreatedAt", "Diameter", "Mass", "UpdatedAt" },
                values: new object[] { 1023838361, new DateTimeOffset(new DateTime(2022, 3, 27, 17, 37, 9, 812, DateTimeKind.Unspecified).AddTicks(9817), new TimeSpan(0, 0, 0, 0, 0)), 1762209225, 1032414568, new DateTimeOffset(new DateTime(2022, 3, 27, 17, 37, 9, 812, DateTimeKind.Unspecified).AddTicks(9817), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "spaceObjects",
                keyColumn: "Id",
                keyValue: new Guid("cff1a755-d896-4e57-8aa1-82df408639ee"),
                columns: new[] { "Age", "CreatedAt", "Diameter", "Mass", "UpdatedAt" },
                values: new object[] { 1868994362, new DateTimeOffset(new DateTime(2022, 3, 27, 17, 37, 9, 812, DateTimeKind.Unspecified).AddTicks(9817), new TimeSpan(0, 0, 0, 0, 0)), 1609211990, 1092959870, new DateTimeOffset(new DateTime(2022, 3, 27, 17, 37, 9, 812, DateTimeKind.Unspecified).AddTicks(9817), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "starSystems",
                keyColumn: "Id",
                keyValue: new Guid("e8e87f06-eb9e-40e5-a9ca-2740da47bf61"),
                columns: new[] { "Age", "CreatedAt", "UpdatedAt" },
                values: new object[] { 1113472669, new DateTimeOffset(new DateTime(2022, 3, 27, 17, 37, 9, 812, DateTimeKind.Unspecified).AddTicks(9817), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 3, 27, 17, 37, 9, 812, DateTimeKind.Unspecified).AddTicks(9817), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.AddForeignKey(
                name: "FK_starSystems_spaceObjects_CenterMassId",
                table: "starSystems",
                column: "CenterMassId",
                principalTable: "spaceObjects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
