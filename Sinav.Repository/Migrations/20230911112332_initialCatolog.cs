using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sinav.Repository.Migrations
{
    public partial class initialCatolog : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kullanicis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kullanicis", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sanatcis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sanatcis", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Albums",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AlbumAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CikisTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Fiyat = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    IndirimOrani = table.Column<double>(type: "float", nullable: false),
                    SatisDurum = table.Column<bool>(type: "bit", nullable: false),
                    SanatciId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Albums", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Albums_Sanatcis_SanatciId",
                        column: x => x.SanatciId,
                        principalTable: "Sanatcis",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Kullanicis",
                columns: new[] { "Id", "CreateDate", "DeletedDate", "FirstName", "LastName", "Password", "Status", "UpdateDate", "UserName" },
                values: new object[] { 1, new DateTime(2023, 9, 11, 14, 23, 32, 440, DateTimeKind.Local).AddTicks(8417), null, "Sefa", "Attila", "sssSSS..", 0, null, "admin" });

            migrationBuilder.InsertData(
                table: "Sanatcis",
                columns: new[] { "Id", "CreateDate", "DeletedDate", "FirstName", "LastName", "Status", "UpdateDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 9, 11, 14, 23, 32, 440, DateTimeKind.Local).AddTicks(8508), null, "Ali", "Gündüz", 0, null },
                    { 2, new DateTime(2023, 9, 11, 14, 23, 32, 440, DateTimeKind.Local).AddTicks(8513), null, "Mehmet", "Uzun", 0, null },
                    { 3, new DateTime(2023, 9, 11, 14, 23, 32, 440, DateTimeKind.Local).AddTicks(8515), null, "Veli", "Kısa", 0, null },
                    { 4, new DateTime(2023, 9, 11, 14, 23, 32, 440, DateTimeKind.Local).AddTicks(8516), null, "Adnan", "Ziya", 0, null },
                    { 5, new DateTime(2023, 9, 11, 14, 23, 32, 440, DateTimeKind.Local).AddTicks(8517), null, "Fatih", "Aslan", 0, null },
                    { 6, new DateTime(2023, 9, 11, 14, 23, 32, 440, DateTimeKind.Local).AddTicks(8518), null, "Furkan", "Kartal", 0, null }
                });

            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "Id", "AlbumAdi", "CikisTarihi", "CreateDate", "DeletedDate", "Fiyat", "IndirimOrani", "SanatciId", "SatisDurum", "Status", "UpdateDate" },
                values: new object[,]
                {
                    { 1, "Deneme1", new DateTime(2025, 9, 11, 14, 23, 32, 440, DateTimeKind.Local).AddTicks(6331), new DateTime(2023, 9, 11, 14, 23, 32, 440, DateTimeKind.Local).AddTicks(6318), null, 150m, 15.0, 1, true, 0, null },
                    { 2, "Deneme2", new DateTime(2024, 9, 11, 14, 23, 32, 440, DateTimeKind.Local).AddTicks(6343), new DateTime(2023, 9, 11, 14, 23, 32, 440, DateTimeKind.Local).AddTicks(6342), null, 150m, 15.0, 2, true, 0, null },
                    { 3, "Deneme3", new DateTime(2033, 9, 11, 14, 23, 32, 440, DateTimeKind.Local).AddTicks(6346), new DateTime(2023, 9, 11, 14, 23, 32, 440, DateTimeKind.Local).AddTicks(6345), null, 150m, 15.0, 3, true, 0, null },
                    { 4, "Deneme4", new DateTime(2030, 9, 11, 14, 23, 32, 440, DateTimeKind.Local).AddTicks(6348), new DateTime(2023, 9, 11, 14, 23, 32, 440, DateTimeKind.Local).AddTicks(6347), null, 150m, 15.0, 4, true, 0, null },
                    { 5, "Deneme5", new DateTime(2035, 9, 11, 14, 23, 32, 440, DateTimeKind.Local).AddTicks(6351), new DateTime(2023, 9, 11, 14, 23, 32, 440, DateTimeKind.Local).AddTicks(6350), null, 150m, 15.0, 5, true, 0, null },
                    { 6, "Deneme6", new DateTime(2031, 9, 11, 14, 23, 32, 440, DateTimeKind.Local).AddTicks(6353), new DateTime(2023, 9, 11, 14, 23, 32, 440, DateTimeKind.Local).AddTicks(6352), null, 150m, 15.0, 6, true, 0, null },
                    { 7, "Deneme7", new DateTime(2026, 9, 11, 14, 23, 32, 440, DateTimeKind.Local).AddTicks(6355), new DateTime(2023, 9, 11, 14, 23, 32, 440, DateTimeKind.Local).AddTicks(6354), null, 150m, 15.0, 1, true, 0, null },
                    { 8, "Deneme8", new DateTime(2027, 9, 11, 14, 23, 32, 440, DateTimeKind.Local).AddTicks(6357), new DateTime(2023, 9, 11, 14, 23, 32, 440, DateTimeKind.Local).AddTicks(6357), null, 150m, 15.0, 2, true, 0, null },
                    { 9, "Deneme9", new DateTime(2028, 9, 11, 14, 23, 32, 440, DateTimeKind.Local).AddTicks(6360), new DateTime(2023, 9, 11, 14, 23, 32, 440, DateTimeKind.Local).AddTicks(6359), null, 150m, 15.0, 1, true, 0, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Albums_SanatciId",
                table: "Albums",
                column: "SanatciId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Albums");

            migrationBuilder.DropTable(
                name: "Kullanicis");

            migrationBuilder.DropTable(
                name: "Sanatcis");
        }
    }
}
