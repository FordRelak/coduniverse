using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Coduniverse.Infrastructure.EF.Migrations
{
    public partial class addAutoGen : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "UpdatedDateTime",
                table: "spaceObjects",
                type: "timestamp with time zone",
                nullable: false,
                defaultValueSql: "now()",
                oldClrType: typeof(DateTimeOffset),
                oldType: "timestamp with time zone");

            migrationBuilder.UpdateData(
                table: "spaceObjects",
                keyColumn: "Id",
                keyValue: new Guid("091b4caf-f9ea-4fbb-8a32-e3a80cfc3e14"),
                columns: new[] { "Age", "CreatedAt", "UpdatedDateTime" },
                values: new object[] { 1604174136, new DateTimeOffset(new DateTime(2022, 3, 20, 14, 15, 38, 972, DateTimeKind.Unspecified).AddTicks(6015), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 3, 20, 14, 15, 38, 972, DateTimeKind.Unspecified).AddTicks(6015), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "spaceObjects",
                keyColumn: "Id",
                keyValue: new Guid("340aa24a-9ee2-4514-875f-41cf64126a85"),
                columns: new[] { "Age", "CreatedAt", "UpdatedDateTime" },
                values: new object[] { 690913231, new DateTimeOffset(new DateTime(2022, 3, 20, 14, 15, 38, 972, DateTimeKind.Unspecified).AddTicks(6015), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 3, 20, 14, 15, 38, 972, DateTimeKind.Unspecified).AddTicks(6015), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "spaceObjects",
                keyColumn: "Id",
                keyValue: new Guid("60269d83-0267-4896-a067-377b8a4afb3d"),
                columns: new[] { "Age", "CreatedAt", "UpdatedDateTime" },
                values: new object[] { 1204563700, new DateTimeOffset(new DateTime(2022, 3, 20, 14, 15, 38, 972, DateTimeKind.Unspecified).AddTicks(6015), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 3, 20, 14, 15, 38, 972, DateTimeKind.Unspecified).AddTicks(6015), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "spaceObjects",
                keyColumn: "Id",
                keyValue: new Guid("970ba570-e757-48b0-84cc-52235a35a10c"),
                columns: new[] { "Age", "CreatedAt", "UpdatedDateTime" },
                values: new object[] { 156333024, new DateTimeOffset(new DateTime(2022, 3, 20, 14, 15, 38, 972, DateTimeKind.Unspecified).AddTicks(6015), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 3, 20, 14, 15, 38, 972, DateTimeKind.Unspecified).AddTicks(6015), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "spaceObjects",
                keyColumn: "Id",
                keyValue: new Guid("b184eaea-de80-47e1-a0af-ce08d93a7524"),
                columns: new[] { "Age", "CreatedAt", "UpdatedDateTime" },
                values: new object[] { 1703450276, new DateTimeOffset(new DateTime(2022, 3, 20, 14, 15, 38, 972, DateTimeKind.Unspecified).AddTicks(6015), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 3, 20, 14, 15, 38, 972, DateTimeKind.Unspecified).AddTicks(6015), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "spaceObjects",
                keyColumn: "Id",
                keyValue: new Guid("cff1a755-d896-4e57-8aa1-82df408639ee"),
                columns: new[] { "Age", "CreatedAt", "UpdatedDateTime" },
                values: new object[] { 1343978660, new DateTimeOffset(new DateTime(2022, 3, 20, 14, 15, 38, 972, DateTimeKind.Unspecified).AddTicks(6015), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 3, 20, 14, 15, 38, 972, DateTimeKind.Unspecified).AddTicks(6015), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "starSystems",
                keyColumn: "Id",
                keyValue: new Guid("e8e87f06-eb9e-40e5-a9ca-2740da47bf61"),
                columns: new[] { "Age", "CreatedAt" },
                values: new object[] { 2036408055, new DateTimeOffset(new DateTime(2022, 3, 20, 14, 15, 38, 972, DateTimeKind.Unspecified).AddTicks(6015), new TimeSpan(0, 0, 0, 0, 0)) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "UpdatedDateTime",
                table: "spaceObjects",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldType: "timestamp with time zone",
                oldDefaultValueSql: "now()");

            migrationBuilder.UpdateData(
                table: "spaceObjects",
                keyColumn: "Id",
                keyValue: new Guid("091b4caf-f9ea-4fbb-8a32-e3a80cfc3e14"),
                columns: new[] { "Age", "CreatedAt", "UpdatedDateTime" },
                values: new object[] { 1734789560, new DateTimeOffset(new DateTime(2022, 3, 20, 14, 13, 24, 378, DateTimeKind.Unspecified).AddTicks(6940), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 3, 20, 14, 13, 24, 378, DateTimeKind.Unspecified).AddTicks(6940), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "spaceObjects",
                keyColumn: "Id",
                keyValue: new Guid("340aa24a-9ee2-4514-875f-41cf64126a85"),
                columns: new[] { "Age", "CreatedAt", "UpdatedDateTime" },
                values: new object[] { 335610706, new DateTimeOffset(new DateTime(2022, 3, 20, 14, 13, 24, 378, DateTimeKind.Unspecified).AddTicks(6940), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 3, 20, 14, 13, 24, 378, DateTimeKind.Unspecified).AddTicks(6940), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "spaceObjects",
                keyColumn: "Id",
                keyValue: new Guid("60269d83-0267-4896-a067-377b8a4afb3d"),
                columns: new[] { "Age", "CreatedAt", "UpdatedDateTime" },
                values: new object[] { 1932341752, new DateTimeOffset(new DateTime(2022, 3, 20, 14, 13, 24, 378, DateTimeKind.Unspecified).AddTicks(6940), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 3, 20, 14, 13, 24, 378, DateTimeKind.Unspecified).AddTicks(6940), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "spaceObjects",
                keyColumn: "Id",
                keyValue: new Guid("970ba570-e757-48b0-84cc-52235a35a10c"),
                columns: new[] { "Age", "CreatedAt", "UpdatedDateTime" },
                values: new object[] { 1354260757, new DateTimeOffset(new DateTime(2022, 3, 20, 14, 13, 24, 378, DateTimeKind.Unspecified).AddTicks(6940), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 3, 20, 14, 13, 24, 378, DateTimeKind.Unspecified).AddTicks(6940), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "spaceObjects",
                keyColumn: "Id",
                keyValue: new Guid("b184eaea-de80-47e1-a0af-ce08d93a7524"),
                columns: new[] { "Age", "CreatedAt", "UpdatedDateTime" },
                values: new object[] { 1446297225, new DateTimeOffset(new DateTime(2022, 3, 20, 14, 13, 24, 378, DateTimeKind.Unspecified).AddTicks(6940), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 3, 20, 14, 13, 24, 378, DateTimeKind.Unspecified).AddTicks(6940), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "spaceObjects",
                keyColumn: "Id",
                keyValue: new Guid("cff1a755-d896-4e57-8aa1-82df408639ee"),
                columns: new[] { "Age", "CreatedAt", "UpdatedDateTime" },
                values: new object[] { 97520950, new DateTimeOffset(new DateTime(2022, 3, 20, 14, 13, 24, 378, DateTimeKind.Unspecified).AddTicks(6940), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 3, 20, 14, 13, 24, 378, DateTimeKind.Unspecified).AddTicks(6940), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "starSystems",
                keyColumn: "Id",
                keyValue: new Guid("e8e87f06-eb9e-40e5-a9ca-2740da47bf61"),
                columns: new[] { "Age", "CreatedAt" },
                values: new object[] { 341353665, new DateTimeOffset(new DateTime(2022, 3, 20, 14, 13, 24, 378, DateTimeKind.Unspecified).AddTicks(6940), new TimeSpan(0, 0, 0, 0, 0)) });
        }
    }
}
