using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Coduniverse.Infrastructure.EF.Migrations
{
    public partial class ChangeRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_spaceObjects_starSystems_CenterMassId",
                table: "spaceObjects");

            migrationBuilder.DropIndex(
                name: "IX_spaceObjects_CenterMassId",
                table: "spaceObjects");

            migrationBuilder.DropColumn(
                name: "CenterMassId",
                table: "spaceObjects");

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

            migrationBuilder.CreateIndex(
                name: "IX_starSystems_CenterMassId",
                table: "starSystems",
                column: "CenterMassId");

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

            migrationBuilder.DropIndex(
                name: "IX_starSystems_CenterMassId",
                table: "starSystems");

            migrationBuilder.AddColumn<Guid>(
                name: "CenterMassId",
                table: "spaceObjects",
                type: "uuid",
                nullable: true);

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
                columns: new[] { "Age", "CreatedAt", "Diameter", "Mass", "UpdatedAt" },
                values: new object[] { 631876520, new DateTimeOffset(new DateTime(2022, 3, 27, 17, 28, 56, 805, DateTimeKind.Unspecified).AddTicks(8103), new TimeSpan(0, 0, 0, 0, 0)), 260023524, 1475774285, new DateTimeOffset(new DateTime(2022, 3, 27, 17, 28, 56, 805, DateTimeKind.Unspecified).AddTicks(8103), new TimeSpan(0, 0, 0, 0, 0)) });

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

            migrationBuilder.CreateIndex(
                name: "IX_spaceObjects_CenterMassId",
                table: "spaceObjects",
                column: "CenterMassId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_spaceObjects_starSystems_CenterMassId",
                table: "spaceObjects",
                column: "CenterMassId",
                principalTable: "starSystems",
                principalColumn: "Id");
        }
    }
}
