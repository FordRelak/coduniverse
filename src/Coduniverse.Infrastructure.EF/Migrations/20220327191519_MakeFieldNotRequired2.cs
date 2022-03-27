using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Coduniverse.Infrastructure.EF.Migrations
{
    public partial class MakeFieldNotRequired2 : Migration
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
                values: new object[] { 1710493554, new DateTimeOffset(new DateTime(2022, 3, 27, 19, 15, 19, 540, DateTimeKind.Unspecified).AddTicks(9754), new TimeSpan(0, 0, 0, 0, 0)), 1024754046, 208773005, new DateTimeOffset(new DateTime(2022, 3, 27, 19, 15, 19, 540, DateTimeKind.Unspecified).AddTicks(9754), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "spaceObjects",
                keyColumn: "Id",
                keyValue: new Guid("340aa24a-9ee2-4514-875f-41cf64126a85"),
                columns: new[] { "Age", "CreatedAt", "Diameter", "Mass", "UpdatedAt" },
                values: new object[] { 1277368370, new DateTimeOffset(new DateTime(2022, 3, 27, 19, 15, 19, 540, DateTimeKind.Unspecified).AddTicks(9754), new TimeSpan(0, 0, 0, 0, 0)), 1530947044, 1785573545, new DateTimeOffset(new DateTime(2022, 3, 27, 19, 15, 19, 540, DateTimeKind.Unspecified).AddTicks(9754), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "spaceObjects",
                keyColumn: "Id",
                keyValue: new Guid("60269d83-0267-4896-a067-377b8a4afb3d"),
                columns: new[] { "Age", "CreatedAt", "Diameter", "Mass", "UpdatedAt" },
                values: new object[] { 1123005472, new DateTimeOffset(new DateTime(2022, 3, 27, 19, 15, 19, 540, DateTimeKind.Unspecified).AddTicks(9754), new TimeSpan(0, 0, 0, 0, 0)), 920801779, 647037652, new DateTimeOffset(new DateTime(2022, 3, 27, 19, 15, 19, 540, DateTimeKind.Unspecified).AddTicks(9754), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "spaceObjects",
                keyColumn: "Id",
                keyValue: new Guid("970ba570-e757-48b0-84cc-52235a35a10c"),
                columns: new[] { "Age", "CreatedAt", "Diameter", "Mass", "UpdatedAt" },
                values: new object[] { 1031866699, new DateTimeOffset(new DateTime(2022, 3, 27, 19, 15, 19, 540, DateTimeKind.Unspecified).AddTicks(9754), new TimeSpan(0, 0, 0, 0, 0)), 541936413, 900717936, new DateTimeOffset(new DateTime(2022, 3, 27, 19, 15, 19, 540, DateTimeKind.Unspecified).AddTicks(9754), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "spaceObjects",
                keyColumn: "Id",
                keyValue: new Guid("b184eaea-de80-47e1-a0af-ce08d93a7524"),
                columns: new[] { "Age", "CreatedAt", "Diameter", "Mass", "UpdatedAt" },
                values: new object[] { 414591564, new DateTimeOffset(new DateTime(2022, 3, 27, 19, 15, 19, 540, DateTimeKind.Unspecified).AddTicks(9754), new TimeSpan(0, 0, 0, 0, 0)), 290729494, 88819581, new DateTimeOffset(new DateTime(2022, 3, 27, 19, 15, 19, 540, DateTimeKind.Unspecified).AddTicks(9754), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "spaceObjects",
                keyColumn: "Id",
                keyValue: new Guid("cff1a755-d896-4e57-8aa1-82df408639ee"),
                columns: new[] { "Age", "CreatedAt", "Diameter", "Mass", "UpdatedAt" },
                values: new object[] { 1978978260, new DateTimeOffset(new DateTime(2022, 3, 27, 19, 15, 19, 540, DateTimeKind.Unspecified).AddTicks(9754), new TimeSpan(0, 0, 0, 0, 0)), 1291242034, 733284783, new DateTimeOffset(new DateTime(2022, 3, 27, 19, 15, 19, 540, DateTimeKind.Unspecified).AddTicks(9754), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "starSystems",
                keyColumn: "Id",
                keyValue: new Guid("e8e87f06-eb9e-40e5-a9ca-2740da47bf61"),
                columns: new[] { "Age", "CreatedAt", "UpdatedAt" },
                values: new object[] { 426414991, new DateTimeOffset(new DateTime(2022, 3, 27, 19, 15, 19, 540, DateTimeKind.Unspecified).AddTicks(9754), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 3, 27, 19, 15, 19, 540, DateTimeKind.Unspecified).AddTicks(9754), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.AddForeignKey(
                name: "FK_starSystems_spaceObjects_CenterMassId",
                table: "starSystems",
                column: "CenterMassId",
                principalTable: "spaceObjects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
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
    }
}
