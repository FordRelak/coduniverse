using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Coduniverse.Infrastructure.EF.Migrations
{
    public partial class initDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "starSystems",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Age = table.Column<int>(type: "integer", nullable: false),
                    CenterMassId = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_starSystems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "spaceObjects",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Age = table.Column<int>(type: "integer", nullable: false),
                    Type = table.Column<int>(type: "integer", nullable: false),
                    StarSystemId = table.Column<Guid>(type: "uuid", nullable: false),
                    CenterMassId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedAt = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_spaceObjects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_spaceObjects_starSystems_CenterMassId",
                        column: x => x.CenterMassId,
                        principalTable: "starSystems",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_spaceObjects_starSystems_StarSystemId",
                        column: x => x.StarSystemId,
                        principalTable: "starSystems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "starSystems",
                columns: new[] { "Id", "Age", "CenterMassId", "CreatedAt", "UpdatedAt", "Name" },
                values: new object[] { new Guid("e8e87f06-eb9e-40e5-a9ca-2740da47bf61"), 2075069542, new Guid("970ba570-e757-48b0-84cc-52235a35a10c"), new DateTimeOffset(new DateTime(2022, 3, 20, 12, 41, 54, 383, DateTimeKind.Unspecified).AddTicks(5565), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 3, 20, 12, 41, 54, 383, DateTimeKind.Unspecified).AddTicks(5565), new TimeSpan(0, 0, 0, 0, 0)), "Solar system" });

            migrationBuilder.InsertData(
                table: "spaceObjects",
                columns: new[] { "Id", "Age", "CenterMassId", "CreatedAt", "UpdatedAt", "Name", "StarSystemId", "Type" },
                values: new object[,]
                {
                    { new Guid("091b4caf-f9ea-4fbb-8a32-e3a80cfc3e14"), 305927391, null, new DateTimeOffset(new DateTime(2022, 3, 20, 12, 41, 54, 383, DateTimeKind.Unspecified).AddTicks(5565), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 3, 20, 12, 41, 54, 383, DateTimeKind.Unspecified).AddTicks(5565), new TimeSpan(0, 0, 0, 0, 0)), "Mars", new Guid("e8e87f06-eb9e-40e5-a9ca-2740da47bf61"), 2 },
                    { new Guid("340aa24a-9ee2-4514-875f-41cf64126a85"), 723246094, null, new DateTimeOffset(new DateTime(2022, 3, 20, 12, 41, 54, 383, DateTimeKind.Unspecified).AddTicks(5565), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 3, 20, 12, 41, 54, 383, DateTimeKind.Unspecified).AddTicks(5565), new TimeSpan(0, 0, 0, 0, 0)), "Mercury", new Guid("e8e87f06-eb9e-40e5-a9ca-2740da47bf61"), 2 },
                    { new Guid("60269d83-0267-4896-a067-377b8a4afb3d"), 817793029, null, new DateTimeOffset(new DateTime(2022, 3, 20, 12, 41, 54, 383, DateTimeKind.Unspecified).AddTicks(5565), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 3, 20, 12, 41, 54, 383, DateTimeKind.Unspecified).AddTicks(5565), new TimeSpan(0, 0, 0, 0, 0)), "Jupiter", new Guid("e8e87f06-eb9e-40e5-a9ca-2740da47bf61"), 2 },
                    { new Guid("970ba570-e757-48b0-84cc-52235a35a10c"), 1968575717, new Guid("e8e87f06-eb9e-40e5-a9ca-2740da47bf61"), new DateTimeOffset(new DateTime(2022, 3, 20, 12, 41, 54, 383, DateTimeKind.Unspecified).AddTicks(5565), new TimeSpan(0, 0, 0, 0, 0)),  new DateTimeOffset(new DateTime(2022, 3, 20, 12, 41, 54, 383, DateTimeKind.Unspecified).AddTicks(5565), new TimeSpan(0, 0, 0, 0, 0)), "Solar", new Guid("e8e87f06-eb9e-40e5-a9ca-2740da47bf61"), 0 },
                    { new Guid("b184eaea-de80-47e1-a0af-ce08d93a7524"), 1606528554, null, new DateTimeOffset(new DateTime(2022, 3, 20, 12, 41, 54, 383, DateTimeKind.Unspecified).AddTicks(5565), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 3, 20, 12, 41, 54, 383, DateTimeKind.Unspecified).AddTicks(5565), new TimeSpan(0, 0, 0, 0, 0)), "Earth", new Guid("e8e87f06-eb9e-40e5-a9ca-2740da47bf61"), 2 },
                    { new Guid("cff1a755-d896-4e57-8aa1-82df408639ee"), 2021917336, null, new DateTimeOffset(new DateTime(2022, 3, 20, 12, 41, 54, 383, DateTimeKind.Unspecified).AddTicks(5565), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 3, 20, 12, 41, 54, 383, DateTimeKind.Unspecified).AddTicks(5565), new TimeSpan(0, 0, 0, 0, 0)), "Venus", new Guid("e8e87f06-eb9e-40e5-a9ca-2740da47bf61"), 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_spaceObjects_CenterMassId",
                table: "spaceObjects",
                column: "CenterMassId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_spaceObjects_StarSystemId",
                table: "spaceObjects",
                column: "StarSystemId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "spaceObjects");

            migrationBuilder.DropTable(
                name: "starSystems");
        }
    }
}
