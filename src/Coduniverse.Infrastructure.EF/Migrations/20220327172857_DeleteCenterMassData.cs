using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Coduniverse.Infrastructure.EF.Migrations
{
    public partial class DeleteCenterMassData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "spaceObjects",
                keyColumn: "Id",
                keyValue: new Guid("091b4caf-f9ea-4fbb-8a32-e3a80cfc3e14"),
                columns: new[] { "Age", "CreatedAt", "Diameter", "Mass", "UpdatedAt" },
                values: new object[] { 1997204788, new DateTimeOffset(new DateTime(2022, 3, 27, 17, 28, 56, 805, DateTimeKind.Unspecified).AddTicks(8103), new TimeSpan(0, 0, 0, 0, 0)), 322416442, 1264728611, new DateTimeOffset(new DateTime(2022, 3, 27, 17, 28, 56, 805, DateTimeKind.Unspecified).AddTicks(8103), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "spaceObjects",
                keyColumn: "Id",
                keyValue: new Guid("340aa24a-9ee2-4514-875f-41cf64126a85"),
                columns: new[] { "Age", "CreatedAt", "Diameter", "Mass", "UpdatedAt" },
                values: new object[] { 672867947, new DateTimeOffset(new DateTime(2022, 3, 27, 17, 28, 56, 805, DateTimeKind.Unspecified).AddTicks(8103), new TimeSpan(0, 0, 0, 0, 0)), 276562688, 2001246243, new DateTimeOffset(new DateTime(2022, 3, 27, 17, 28, 56, 805, DateTimeKind.Unspecified).AddTicks(8103), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "spaceObjects",
                keyColumn: "Id",
                keyValue: new Guid("60269d83-0267-4896-a067-377b8a4afb3d"),
                columns: new[] { "Age", "CreatedAt", "Diameter", "Mass", "UpdatedAt" },
                values: new object[] { 1755580539, new DateTimeOffset(new DateTime(2022, 3, 27, 17, 28, 56, 805, DateTimeKind.Unspecified).AddTicks(8103), new TimeSpan(0, 0, 0, 0, 0)), 633461747, 151670042, new DateTimeOffset(new DateTime(2022, 3, 27, 17, 28, 56, 805, DateTimeKind.Unspecified).AddTicks(8103), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "spaceObjects",
                keyColumn: "Id",
                keyValue: new Guid("970ba570-e757-48b0-84cc-52235a35a10c"),
                columns: new[] { "Age", "CenterMassId", "CreatedAt", "Diameter", "Mass", "UpdatedAt" },
                values: new object[] { 631876520, null, new DateTimeOffset(new DateTime(2022, 3, 27, 17, 28, 56, 805, DateTimeKind.Unspecified).AddTicks(8103), new TimeSpan(0, 0, 0, 0, 0)), 260023524, 1475774285, new DateTimeOffset(new DateTime(2022, 3, 27, 17, 28, 56, 805, DateTimeKind.Unspecified).AddTicks(8103), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "spaceObjects",
                keyColumn: "Id",
                keyValue: new Guid("b184eaea-de80-47e1-a0af-ce08d93a7524"),
                columns: new[] { "Age", "CreatedAt", "Diameter", "Mass", "UpdatedAt" },
                values: new object[] { 1189530483, new DateTimeOffset(new DateTime(2022, 3, 27, 17, 28, 56, 805, DateTimeKind.Unspecified).AddTicks(8103), new TimeSpan(0, 0, 0, 0, 0)), 187555213, 1093825986, new DateTimeOffset(new DateTime(2022, 3, 27, 17, 28, 56, 805, DateTimeKind.Unspecified).AddTicks(8103), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "spaceObjects",
                keyColumn: "Id",
                keyValue: new Guid("cff1a755-d896-4e57-8aa1-82df408639ee"),
                columns: new[] { "Age", "CreatedAt", "Diameter", "Mass", "UpdatedAt" },
                values: new object[] { 208621775, new DateTimeOffset(new DateTime(2022, 3, 27, 17, 28, 56, 805, DateTimeKind.Unspecified).AddTicks(8103), new TimeSpan(0, 0, 0, 0, 0)), 373069939, 729735711, new DateTimeOffset(new DateTime(2022, 3, 27, 17, 28, 56, 805, DateTimeKind.Unspecified).AddTicks(8103), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "starSystems",
                keyColumn: "Id",
                keyValue: new Guid("e8e87f06-eb9e-40e5-a9ca-2740da47bf61"),
                columns: new[] { "Age", "CreatedAt", "UpdatedAt" },
                values: new object[] { 429849038, new DateTimeOffset(new DateTime(2022, 3, 27, 17, 28, 56, 805, DateTimeKind.Unspecified).AddTicks(8103), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 3, 27, 17, 28, 56, 805, DateTimeKind.Unspecified).AddTicks(8103), new TimeSpan(0, 0, 0, 0, 0)) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "spaceObjects",
                keyColumn: "Id",
                keyValue: new Guid("091b4caf-f9ea-4fbb-8a32-e3a80cfc3e14"),
                columns: new[] { "Age", "CreatedAt", "Diameter", "Mass", "UpdatedAt" },
                values: new object[] { 590415543, new DateTimeOffset(new DateTime(2022, 3, 26, 18, 4, 19, 974, DateTimeKind.Unspecified).AddTicks(1017), new TimeSpan(0, 0, 0, 0, 0)), 811034605, 1246364460, new DateTimeOffset(new DateTime(2022, 3, 26, 18, 4, 19, 974, DateTimeKind.Unspecified).AddTicks(1017), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "spaceObjects",
                keyColumn: "Id",
                keyValue: new Guid("340aa24a-9ee2-4514-875f-41cf64126a85"),
                columns: new[] { "Age", "CreatedAt", "Diameter", "Mass", "UpdatedAt" },
                values: new object[] { 906249929, new DateTimeOffset(new DateTime(2022, 3, 26, 18, 4, 19, 974, DateTimeKind.Unspecified).AddTicks(1017), new TimeSpan(0, 0, 0, 0, 0)), 536376163, 1706120180, new DateTimeOffset(new DateTime(2022, 3, 26, 18, 4, 19, 974, DateTimeKind.Unspecified).AddTicks(1017), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "spaceObjects",
                keyColumn: "Id",
                keyValue: new Guid("60269d83-0267-4896-a067-377b8a4afb3d"),
                columns: new[] { "Age", "CreatedAt", "Diameter", "Mass", "UpdatedAt" },
                values: new object[] { 2096957908, new DateTimeOffset(new DateTime(2022, 3, 26, 18, 4, 19, 974, DateTimeKind.Unspecified).AddTicks(1017), new TimeSpan(0, 0, 0, 0, 0)), 1728868749, 174301235, new DateTimeOffset(new DateTime(2022, 3, 26, 18, 4, 19, 974, DateTimeKind.Unspecified).AddTicks(1017), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "spaceObjects",
                keyColumn: "Id",
                keyValue: new Guid("970ba570-e757-48b0-84cc-52235a35a10c"),
                columns: new[] { "Age", "CenterMassId", "CreatedAt", "Diameter", "Mass", "UpdatedAt" },
                values: new object[] { 598795485, new Guid("e8e87f06-eb9e-40e5-a9ca-2740da47bf61"), new DateTimeOffset(new DateTime(2022, 3, 26, 18, 4, 19, 974, DateTimeKind.Unspecified).AddTicks(1017), new TimeSpan(0, 0, 0, 0, 0)), 114357099, 1500974622, new DateTimeOffset(new DateTime(2022, 3, 26, 18, 4, 19, 974, DateTimeKind.Unspecified).AddTicks(1017), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "spaceObjects",
                keyColumn: "Id",
                keyValue: new Guid("b184eaea-de80-47e1-a0af-ce08d93a7524"),
                columns: new[] { "Age", "CreatedAt", "Diameter", "Mass", "UpdatedAt" },
                values: new object[] { 2006052427, new DateTimeOffset(new DateTime(2022, 3, 26, 18, 4, 19, 974, DateTimeKind.Unspecified).AddTicks(1017), new TimeSpan(0, 0, 0, 0, 0)), 1176081435, 780525606, new DateTimeOffset(new DateTime(2022, 3, 26, 18, 4, 19, 974, DateTimeKind.Unspecified).AddTicks(1017), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "spaceObjects",
                keyColumn: "Id",
                keyValue: new Guid("cff1a755-d896-4e57-8aa1-82df408639ee"),
                columns: new[] { "Age", "CreatedAt", "Diameter", "Mass", "UpdatedAt" },
                values: new object[] { 258543654, new DateTimeOffset(new DateTime(2022, 3, 26, 18, 4, 19, 974, DateTimeKind.Unspecified).AddTicks(1017), new TimeSpan(0, 0, 0, 0, 0)), 1955440506, 261063921, new DateTimeOffset(new DateTime(2022, 3, 26, 18, 4, 19, 974, DateTimeKind.Unspecified).AddTicks(1017), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "starSystems",
                keyColumn: "Id",
                keyValue: new Guid("e8e87f06-eb9e-40e5-a9ca-2740da47bf61"),
                columns: new[] { "Age", "CreatedAt", "UpdatedAt" },
                values: new object[] { 1713657751, new DateTimeOffset(new DateTime(2022, 3, 26, 18, 4, 19, 974, DateTimeKind.Unspecified).AddTicks(1017), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 3, 26, 18, 4, 19, 974, DateTimeKind.Unspecified).AddTicks(1017), new TimeSpan(0, 0, 0, 0, 0)) });
        }
    }
}
