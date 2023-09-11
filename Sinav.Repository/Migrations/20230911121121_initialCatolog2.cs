using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sinav.Repository.Migrations
{
    public partial class initialCatolog2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CikisTarihi", "CreateDate" },
                values: new object[] { new DateTime(2025, 9, 11, 15, 11, 20, 888, DateTimeKind.Local).AddTicks(8523), new DateTime(2023, 9, 11, 15, 11, 20, 888, DateTimeKind.Local).AddTicks(8509) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CikisTarihi", "CreateDate" },
                values: new object[] { new DateTime(2024, 9, 11, 15, 11, 20, 888, DateTimeKind.Local).AddTicks(8538), new DateTime(2023, 9, 11, 15, 11, 20, 888, DateTimeKind.Local).AddTicks(8537) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CikisTarihi", "CreateDate" },
                values: new object[] { new DateTime(2033, 9, 11, 15, 11, 20, 888, DateTimeKind.Local).AddTicks(8541), new DateTime(2023, 9, 11, 15, 11, 20, 888, DateTimeKind.Local).AddTicks(8540) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CikisTarihi", "CreateDate" },
                values: new object[] { new DateTime(2030, 9, 11, 15, 11, 20, 888, DateTimeKind.Local).AddTicks(8543), new DateTime(2023, 9, 11, 15, 11, 20, 888, DateTimeKind.Local).AddTicks(8543) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CikisTarihi", "CreateDate" },
                values: new object[] { new DateTime(2035, 9, 11, 15, 11, 20, 888, DateTimeKind.Local).AddTicks(8546), new DateTime(2023, 9, 11, 15, 11, 20, 888, DateTimeKind.Local).AddTicks(8545) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CikisTarihi", "CreateDate" },
                values: new object[] { new DateTime(2031, 9, 11, 15, 11, 20, 888, DateTimeKind.Local).AddTicks(8548), new DateTime(2023, 9, 11, 15, 11, 20, 888, DateTimeKind.Local).AddTicks(8547) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CikisTarihi", "CreateDate" },
                values: new object[] { new DateTime(2026, 9, 11, 15, 11, 20, 888, DateTimeKind.Local).AddTicks(8550), new DateTime(2023, 9, 11, 15, 11, 20, 888, DateTimeKind.Local).AddTicks(8549) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CikisTarihi", "CreateDate" },
                values: new object[] { new DateTime(2027, 9, 11, 15, 11, 20, 888, DateTimeKind.Local).AddTicks(8552), new DateTime(2023, 9, 11, 15, 11, 20, 888, DateTimeKind.Local).AddTicks(8552) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CikisTarihi", "CreateDate" },
                values: new object[] { new DateTime(2028, 9, 11, 15, 11, 20, 888, DateTimeKind.Local).AddTicks(8554), new DateTime(2023, 9, 11, 15, 11, 20, 888, DateTimeKind.Local).AddTicks(8554) });

            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "Password" },
                values: new object[] { new DateTime(2023, 9, 11, 15, 11, 20, 889, DateTimeKind.Local).AddTicks(1072), "C8B7388EE2A0BC141591C0DF7644134EC65504D1E15F3A18719302BF66332E03" });

            migrationBuilder.UpdateData(
                table: "Sanatcis",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 9, 11, 15, 11, 20, 889, DateTimeKind.Local).AddTicks(2894));

            migrationBuilder.UpdateData(
                table: "Sanatcis",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 9, 11, 15, 11, 20, 889, DateTimeKind.Local).AddTicks(2900));

            migrationBuilder.UpdateData(
                table: "Sanatcis",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2023, 9, 11, 15, 11, 20, 889, DateTimeKind.Local).AddTicks(2901));

            migrationBuilder.UpdateData(
                table: "Sanatcis",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2023, 9, 11, 15, 11, 20, 889, DateTimeKind.Local).AddTicks(2902));

            migrationBuilder.UpdateData(
                table: "Sanatcis",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2023, 9, 11, 15, 11, 20, 889, DateTimeKind.Local).AddTicks(2903));

            migrationBuilder.UpdateData(
                table: "Sanatcis",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2023, 9, 11, 15, 11, 20, 889, DateTimeKind.Local).AddTicks(2905));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CikisTarihi", "CreateDate" },
                values: new object[] { new DateTime(2025, 9, 11, 14, 23, 32, 440, DateTimeKind.Local).AddTicks(6331), new DateTime(2023, 9, 11, 14, 23, 32, 440, DateTimeKind.Local).AddTicks(6318) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CikisTarihi", "CreateDate" },
                values: new object[] { new DateTime(2024, 9, 11, 14, 23, 32, 440, DateTimeKind.Local).AddTicks(6343), new DateTime(2023, 9, 11, 14, 23, 32, 440, DateTimeKind.Local).AddTicks(6342) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CikisTarihi", "CreateDate" },
                values: new object[] { new DateTime(2033, 9, 11, 14, 23, 32, 440, DateTimeKind.Local).AddTicks(6346), new DateTime(2023, 9, 11, 14, 23, 32, 440, DateTimeKind.Local).AddTicks(6345) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CikisTarihi", "CreateDate" },
                values: new object[] { new DateTime(2030, 9, 11, 14, 23, 32, 440, DateTimeKind.Local).AddTicks(6348), new DateTime(2023, 9, 11, 14, 23, 32, 440, DateTimeKind.Local).AddTicks(6347) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CikisTarihi", "CreateDate" },
                values: new object[] { new DateTime(2035, 9, 11, 14, 23, 32, 440, DateTimeKind.Local).AddTicks(6351), new DateTime(2023, 9, 11, 14, 23, 32, 440, DateTimeKind.Local).AddTicks(6350) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CikisTarihi", "CreateDate" },
                values: new object[] { new DateTime(2031, 9, 11, 14, 23, 32, 440, DateTimeKind.Local).AddTicks(6353), new DateTime(2023, 9, 11, 14, 23, 32, 440, DateTimeKind.Local).AddTicks(6352) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CikisTarihi", "CreateDate" },
                values: new object[] { new DateTime(2026, 9, 11, 14, 23, 32, 440, DateTimeKind.Local).AddTicks(6355), new DateTime(2023, 9, 11, 14, 23, 32, 440, DateTimeKind.Local).AddTicks(6354) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CikisTarihi", "CreateDate" },
                values: new object[] { new DateTime(2027, 9, 11, 14, 23, 32, 440, DateTimeKind.Local).AddTicks(6357), new DateTime(2023, 9, 11, 14, 23, 32, 440, DateTimeKind.Local).AddTicks(6357) });

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CikisTarihi", "CreateDate" },
                values: new object[] { new DateTime(2028, 9, 11, 14, 23, 32, 440, DateTimeKind.Local).AddTicks(6360), new DateTime(2023, 9, 11, 14, 23, 32, 440, DateTimeKind.Local).AddTicks(6359) });

            migrationBuilder.UpdateData(
                table: "Kullanicis",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "Password" },
                values: new object[] { new DateTime(2023, 9, 11, 14, 23, 32, 440, DateTimeKind.Local).AddTicks(8417), "sssSSS.." });

            migrationBuilder.UpdateData(
                table: "Sanatcis",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 9, 11, 14, 23, 32, 440, DateTimeKind.Local).AddTicks(8508));

            migrationBuilder.UpdateData(
                table: "Sanatcis",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 9, 11, 14, 23, 32, 440, DateTimeKind.Local).AddTicks(8513));

            migrationBuilder.UpdateData(
                table: "Sanatcis",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2023, 9, 11, 14, 23, 32, 440, DateTimeKind.Local).AddTicks(8515));

            migrationBuilder.UpdateData(
                table: "Sanatcis",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2023, 9, 11, 14, 23, 32, 440, DateTimeKind.Local).AddTicks(8516));

            migrationBuilder.UpdateData(
                table: "Sanatcis",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2023, 9, 11, 14, 23, 32, 440, DateTimeKind.Local).AddTicks(8517));

            migrationBuilder.UpdateData(
                table: "Sanatcis",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2023, 9, 11, 14, 23, 32, 440, DateTimeKind.Local).AddTicks(8518));
        }
    }
}
