using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Coduniverse.Infrastructure.EF.Migrations
{
    public partial class MakeFieldNullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<Guid>(
                name: "CenterMassId",
                table: "starSystems",
                type: "uuid",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldDefaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "spaceObjects",
                keyColumn: "Id",
                keyValue: new Guid("091b4caf-f9ea-4fbb-8a32-e3a80cfc3e14"),
                columns: new[] { "Age", "CreatedAt", "Diameter", "Mass", "UpdatedAt" },
                values: new object[] { 1069863656, new DateTimeOffset(new DateTime(2022, 3, 27, 19, 33, 53, 958, DateTimeKind.Unspecified).AddTicks(3005), new TimeSpan(0, 0, 0, 0, 0)), 1168253704, 882427276, new DateTimeOffset(new DateTime(2022, 3, 27, 19, 33, 53, 958, DateTimeKind.Unspecified).AddTicks(3005), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "spaceObjects",
                keyColumn: "Id",
                keyValue: new Guid("340aa24a-9ee2-4514-875f-41cf64126a85"),
                columns: new[] { "Age", "CreatedAt", "Diameter", "Mass", "UpdatedAt" },
                values: new object[] { 1822579592, new DateTimeOffset(new DateTime(2022, 3, 27, 19, 33, 53, 958, DateTimeKind.Unspecified).AddTicks(3005), new TimeSpan(0, 0, 0, 0, 0)), 597384204, 1630710593, new DateTimeOffset(new DateTime(2022, 3, 27, 19, 33, 53, 958, DateTimeKind.Unspecified).AddTicks(3005), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "spaceObjects",
                keyColumn: "Id",
                keyValue: new Guid("60269d83-0267-4896-a067-377b8a4afb3d"),
                columns: new[] { "Age", "CreatedAt", "Diameter", "Mass", "UpdatedAt" },
                values: new object[] { 1249692303, new DateTimeOffset(new DateTime(2022, 3, 27, 19, 33, 53, 958, DateTimeKind.Unspecified).AddTicks(3005), new TimeSpan(0, 0, 0, 0, 0)), 924356266, 1089360360, new DateTimeOffset(new DateTime(2022, 3, 27, 19, 33, 53, 958, DateTimeKind.Unspecified).AddTicks(3005), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "spaceObjects",
                keyColumn: "Id",
                keyValue: new Guid("970ba570-e757-48b0-84cc-52235a35a10c"),
                columns: new[] { "Age", "CreatedAt", "Diameter", "Mass", "UpdatedAt" },
                values: new object[] { 878003394, new DateTimeOffset(new DateTime(2022, 3, 27, 19, 33, 53, 958, DateTimeKind.Unspecified).AddTicks(3005), new TimeSpan(0, 0, 0, 0, 0)), 2133188207, 1459312810, new DateTimeOffset(new DateTime(2022, 3, 27, 19, 33, 53, 958, DateTimeKind.Unspecified).AddTicks(3005), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "spaceObjects",
                keyColumn: "Id",
                keyValue: new Guid("b184eaea-de80-47e1-a0af-ce08d93a7524"),
                columns: new[] { "Age", "CreatedAt", "Diameter", "Mass", "UpdatedAt" },
                values: new object[] { 2137212187, new DateTimeOffset(new DateTime(2022, 3, 27, 19, 33, 53, 958, DateTimeKind.Unspecified).AddTicks(3005), new TimeSpan(0, 0, 0, 0, 0)), 249094810, 333584233, new DateTimeOffset(new DateTime(2022, 3, 27, 19, 33, 53, 958, DateTimeKind.Unspecified).AddTicks(3005), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "spaceObjects",
                keyColumn: "Id",
                keyValue: new Guid("cff1a755-d896-4e57-8aa1-82df408639ee"),
                columns: new[] { "Age", "CreatedAt", "Diameter", "Mass", "UpdatedAt" },
                values: new object[] { 1413864703, new DateTimeOffset(new DateTime(2022, 3, 27, 19, 33, 53, 958, DateTimeKind.Unspecified).AddTicks(3005), new TimeSpan(0, 0, 0, 0, 0)), 1132467835, 1132243811, new DateTimeOffset(new DateTime(2022, 3, 27, 19, 33, 53, 958, DateTimeKind.Unspecified).AddTicks(3005), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "starSystems",
                keyColumn: "Id",
                keyValue: new Guid("e8e87f06-eb9e-40e5-a9ca-2740da47bf61"),
                columns: new[] { "Age", "CreatedAt", "UpdatedAt" },
                values: new object[] { 928212946, new DateTimeOffset(new DateTime(2022, 3, 27, 19, 33, 53, 958, DateTimeKind.Unspecified).AddTicks(3005), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 3, 27, 19, 33, 53, 958, DateTimeKind.Unspecified).AddTicks(3005), new TimeSpan(0, 0, 0, 0, 0)) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<Guid>(
                name: "CenterMassId",
                table: "starSystems",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "spaceObjects",
                keyColumn: "Id",
                keyValue: new Guid("091b4caf-f9ea-4fbb-8a32-e3a80cfc3e14"),
                columns: new[] { "Age", "CreatedAt", "Diameter", "Mass", "UpdatedAt" },
                values: new object[] { 724717979, new DateTimeOffset(new DateTime(2022, 3, 27, 19, 27, 40, 186, DateTimeKind.Unspecified).AddTicks(8593), new TimeSpan(0, 0, 0, 0, 0)), 656334731, 1851536124, new DateTimeOffset(new DateTime(2022, 3, 27, 19, 27, 40, 186, DateTimeKind.Unspecified).AddTicks(8593), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "spaceObjects",
                keyColumn: "Id",
                keyValue: new Guid("340aa24a-9ee2-4514-875f-41cf64126a85"),
                columns: new[] { "Age", "CreatedAt", "Diameter", "Mass", "UpdatedAt" },
                values: new object[] { 512346118, new DateTimeOffset(new DateTime(2022, 3, 27, 19, 27, 40, 186, DateTimeKind.Unspecified).AddTicks(8593), new TimeSpan(0, 0, 0, 0, 0)), 1585050451, 1205068500, new DateTimeOffset(new DateTime(2022, 3, 27, 19, 27, 40, 186, DateTimeKind.Unspecified).AddTicks(8593), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "spaceObjects",
                keyColumn: "Id",
                keyValue: new Guid("60269d83-0267-4896-a067-377b8a4afb3d"),
                columns: new[] { "Age", "CreatedAt", "Diameter", "Mass", "UpdatedAt" },
                values: new object[] { 757157171, new DateTimeOffset(new DateTime(2022, 3, 27, 19, 27, 40, 186, DateTimeKind.Unspecified).AddTicks(8593), new TimeSpan(0, 0, 0, 0, 0)), 1883452645, 1279144543, new DateTimeOffset(new DateTime(2022, 3, 27, 19, 27, 40, 186, DateTimeKind.Unspecified).AddTicks(8593), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "spaceObjects",
                keyColumn: "Id",
                keyValue: new Guid("970ba570-e757-48b0-84cc-52235a35a10c"),
                columns: new[] { "Age", "CreatedAt", "Diameter", "Mass", "UpdatedAt" },
                values: new object[] { 1085047650, new DateTimeOffset(new DateTime(2022, 3, 27, 19, 27, 40, 186, DateTimeKind.Unspecified).AddTicks(8593), new TimeSpan(0, 0, 0, 0, 0)), 42940079, 1910999895, new DateTimeOffset(new DateTime(2022, 3, 27, 19, 27, 40, 186, DateTimeKind.Unspecified).AddTicks(8593), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "spaceObjects",
                keyColumn: "Id",
                keyValue: new Guid("b184eaea-de80-47e1-a0af-ce08d93a7524"),
                columns: new[] { "Age", "CreatedAt", "Diameter", "Mass", "UpdatedAt" },
                values: new object[] { 1057394016, new DateTimeOffset(new DateTime(2022, 3, 27, 19, 27, 40, 186, DateTimeKind.Unspecified).AddTicks(8593), new TimeSpan(0, 0, 0, 0, 0)), 344737210, 1846392695, new DateTimeOffset(new DateTime(2022, 3, 27, 19, 27, 40, 186, DateTimeKind.Unspecified).AddTicks(8593), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "spaceObjects",
                keyColumn: "Id",
                keyValue: new Guid("cff1a755-d896-4e57-8aa1-82df408639ee"),
                columns: new[] { "Age", "CreatedAt", "Diameter", "Mass", "UpdatedAt" },
                values: new object[] { 91000536, new DateTimeOffset(new DateTime(2022, 3, 27, 19, 27, 40, 186, DateTimeKind.Unspecified).AddTicks(8593), new TimeSpan(0, 0, 0, 0, 0)), 374536000, 210035105, new DateTimeOffset(new DateTime(2022, 3, 27, 19, 27, 40, 186, DateTimeKind.Unspecified).AddTicks(8593), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "starSystems",
                keyColumn: "Id",
                keyValue: new Guid("e8e87f06-eb9e-40e5-a9ca-2740da47bf61"),
                columns: new[] { "Age", "CreatedAt", "UpdatedAt" },
                values: new object[] { 2084023244, new DateTimeOffset(new DateTime(2022, 3, 27, 19, 27, 40, 186, DateTimeKind.Unspecified).AddTicks(8593), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 3, 27, 19, 27, 40, 186, DateTimeKind.Unspecified).AddTicks(8593), new TimeSpan(0, 0, 0, 0, 0)) });
        }
    }
}
