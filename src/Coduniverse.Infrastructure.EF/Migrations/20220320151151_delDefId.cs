using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Coduniverse.Infrastructure.EF.Migrations
{
    public partial class delDefId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "spaceObjects",
                keyColumn: "Id",
                keyValue: new Guid("091b4caf-f9ea-4fbb-8a32-e3a80cfc3e14"),
                columns: new[] { "Age", "CreatedAt", "UpdatedDateTime" },
                values: new object[] { 1931782167, new DateTimeOffset(new DateTime(2022, 3, 20, 15, 11, 51, 675, DateTimeKind.Unspecified).AddTicks(6131), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 3, 20, 15, 11, 51, 675, DateTimeKind.Unspecified).AddTicks(6131), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "spaceObjects",
                keyColumn: "Id",
                keyValue: new Guid("340aa24a-9ee2-4514-875f-41cf64126a85"),
                columns: new[] { "Age", "CreatedAt", "UpdatedDateTime" },
                values: new object[] { 1837126803, new DateTimeOffset(new DateTime(2022, 3, 20, 15, 11, 51, 675, DateTimeKind.Unspecified).AddTicks(6131), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 3, 20, 15, 11, 51, 675, DateTimeKind.Unspecified).AddTicks(6131), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "spaceObjects",
                keyColumn: "Id",
                keyValue: new Guid("60269d83-0267-4896-a067-377b8a4afb3d"),
                columns: new[] { "Age", "CreatedAt", "UpdatedDateTime" },
                values: new object[] { 777142772, new DateTimeOffset(new DateTime(2022, 3, 20, 15, 11, 51, 675, DateTimeKind.Unspecified).AddTicks(6131), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 3, 20, 15, 11, 51, 675, DateTimeKind.Unspecified).AddTicks(6131), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "spaceObjects",
                keyColumn: "Id",
                keyValue: new Guid("970ba570-e757-48b0-84cc-52235a35a10c"),
                columns: new[] { "Age", "CreatedAt", "UpdatedDateTime" },
                values: new object[] { 124276493, new DateTimeOffset(new DateTime(2022, 3, 20, 15, 11, 51, 675, DateTimeKind.Unspecified).AddTicks(6131), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 3, 20, 15, 11, 51, 675, DateTimeKind.Unspecified).AddTicks(6131), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "spaceObjects",
                keyColumn: "Id",
                keyValue: new Guid("b184eaea-de80-47e1-a0af-ce08d93a7524"),
                columns: new[] { "Age", "CreatedAt", "UpdatedDateTime" },
                values: new object[] { 1753915049, new DateTimeOffset(new DateTime(2022, 3, 20, 15, 11, 51, 675, DateTimeKind.Unspecified).AddTicks(6131), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 3, 20, 15, 11, 51, 675, DateTimeKind.Unspecified).AddTicks(6131), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "spaceObjects",
                keyColumn: "Id",
                keyValue: new Guid("cff1a755-d896-4e57-8aa1-82df408639ee"),
                columns: new[] { "Age", "CreatedAt", "UpdatedDateTime" },
                values: new object[] { 9301330, new DateTimeOffset(new DateTime(2022, 3, 20, 15, 11, 51, 675, DateTimeKind.Unspecified).AddTicks(6131), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 3, 20, 15, 11, 51, 675, DateTimeKind.Unspecified).AddTicks(6131), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "starSystems",
                keyColumn: "Id",
                keyValue: new Guid("e8e87f06-eb9e-40e5-a9ca-2740da47bf61"),
                columns: new[] { "Age", "CreatedAt", "UpdatedDateTime" },
                values: new object[] { 1589194038, new DateTimeOffset(new DateTime(2022, 3, 20, 15, 11, 51, 675, DateTimeKind.Unspecified).AddTicks(6131), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 3, 20, 15, 11, 51, 675, DateTimeKind.Unspecified).AddTicks(6131), new TimeSpan(0, 0, 0, 0, 0)) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "spaceObjects",
                keyColumn: "Id",
                keyValue: new Guid("091b4caf-f9ea-4fbb-8a32-e3a80cfc3e14"),
                columns: new[] { "Age", "CreatedAt", "UpdatedDateTime" },
                values: new object[] { 497383398, new DateTimeOffset(new DateTime(2022, 3, 20, 14, 22, 52, 325, DateTimeKind.Unspecified).AddTicks(3842), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 3, 20, 14, 22, 52, 325, DateTimeKind.Unspecified).AddTicks(3842), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "spaceObjects",
                keyColumn: "Id",
                keyValue: new Guid("340aa24a-9ee2-4514-875f-41cf64126a85"),
                columns: new[] { "Age", "CreatedAt", "UpdatedDateTime" },
                values: new object[] { 324012083, new DateTimeOffset(new DateTime(2022, 3, 20, 14, 22, 52, 325, DateTimeKind.Unspecified).AddTicks(3842), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 3, 20, 14, 22, 52, 325, DateTimeKind.Unspecified).AddTicks(3842), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "spaceObjects",
                keyColumn: "Id",
                keyValue: new Guid("60269d83-0267-4896-a067-377b8a4afb3d"),
                columns: new[] { "Age", "CreatedAt", "UpdatedDateTime" },
                values: new object[] { 185731196, new DateTimeOffset(new DateTime(2022, 3, 20, 14, 22, 52, 325, DateTimeKind.Unspecified).AddTicks(3842), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 3, 20, 14, 22, 52, 325, DateTimeKind.Unspecified).AddTicks(3842), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "spaceObjects",
                keyColumn: "Id",
                keyValue: new Guid("970ba570-e757-48b0-84cc-52235a35a10c"),
                columns: new[] { "Age", "CreatedAt", "UpdatedDateTime" },
                values: new object[] { 1683421990, new DateTimeOffset(new DateTime(2022, 3, 20, 14, 22, 52, 325, DateTimeKind.Unspecified).AddTicks(3842), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 3, 20, 14, 22, 52, 325, DateTimeKind.Unspecified).AddTicks(3842), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "spaceObjects",
                keyColumn: "Id",
                keyValue: new Guid("b184eaea-de80-47e1-a0af-ce08d93a7524"),
                columns: new[] { "Age", "CreatedAt", "UpdatedDateTime" },
                values: new object[] { 1643178240, new DateTimeOffset(new DateTime(2022, 3, 20, 14, 22, 52, 325, DateTimeKind.Unspecified).AddTicks(3842), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 3, 20, 14, 22, 52, 325, DateTimeKind.Unspecified).AddTicks(3842), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "spaceObjects",
                keyColumn: "Id",
                keyValue: new Guid("cff1a755-d896-4e57-8aa1-82df408639ee"),
                columns: new[] { "Age", "CreatedAt", "UpdatedDateTime" },
                values: new object[] { 207001604, new DateTimeOffset(new DateTime(2022, 3, 20, 14, 22, 52, 325, DateTimeKind.Unspecified).AddTicks(3842), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 3, 20, 14, 22, 52, 325, DateTimeKind.Unspecified).AddTicks(3842), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "starSystems",
                keyColumn: "Id",
                keyValue: new Guid("e8e87f06-eb9e-40e5-a9ca-2740da47bf61"),
                columns: new[] { "Age", "CreatedAt", "UpdatedDateTime" },
                values: new object[] { 2023484089, new DateTimeOffset(new DateTime(2022, 3, 20, 14, 22, 52, 325, DateTimeKind.Unspecified).AddTicks(3842), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 3, 20, 14, 22, 52, 325, DateTimeKind.Unspecified).AddTicks(3842), new TimeSpan(0, 0, 0, 0, 0)) });
        }
    }
}
