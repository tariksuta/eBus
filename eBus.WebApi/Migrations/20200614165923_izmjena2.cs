using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eBus.WebApi.Migrations
{
    public partial class izmjena2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Angazuje",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DatumAngazovanja", "DatumIsteka" },
                values: new object[] { new DateTime(2020, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "KorisniciUloge",
                keyColumn: "ID",
                keyValue: 1,
                column: "DatumIzmjene",
                value: new DateTime(2020, 6, 14, 18, 59, 22, 347, DateTimeKind.Local).AddTicks(4833));

            migrationBuilder.UpdateData(
                table: "KorisniciUloge",
                keyColumn: "ID",
                keyValue: 2,
                column: "DatumIzmjene",
                value: new DateTime(2020, 6, 14, 18, 59, 22, 351, DateTimeKind.Local).AddTicks(7704));

            migrationBuilder.UpdateData(
                table: "Notifikacije",
                keyColumn: "ID",
                keyValue: 1,
                column: "DatumSlanja",
                value: new DateTime(2020, 6, 14, 18, 59, 22, 358, DateTimeKind.Local).AddTicks(9174));

            migrationBuilder.UpdateData(
                table: "Novosti",
                keyColumn: "ID",
                keyValue: 1,
                column: "DatumObjave",
                value: new DateTime(2020, 6, 14, 18, 59, 22, 358, DateTimeKind.Local).AddTicks(2782));

            migrationBuilder.UpdateData(
                table: "Putnik",
                keyColumn: "ID",
                keyValue: 1,
                column: "DatumRegistracije",
                value: new DateTime(2020, 6, 14, 18, 59, 22, 353, DateTimeKind.Local).AddTicks(940));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Angazuje",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DatumAngazovanja", "DatumIsteka" },
                values: new object[] { new DateTime(2020, 6, 13, 14, 45, 47, 255, DateTimeKind.Local).AddTicks(5281), new DateTime(2020, 6, 20, 14, 45, 47, 255, DateTimeKind.Local).AddTicks(6661) });

            migrationBuilder.UpdateData(
                table: "KorisniciUloge",
                keyColumn: "ID",
                keyValue: 1,
                column: "DatumIzmjene",
                value: new DateTime(2020, 6, 13, 14, 45, 47, 181, DateTimeKind.Local).AddTicks(9226));

            migrationBuilder.UpdateData(
                table: "KorisniciUloge",
                keyColumn: "ID",
                keyValue: 2,
                column: "DatumIzmjene",
                value: new DateTime(2020, 6, 13, 14, 45, 47, 244, DateTimeKind.Local).AddTicks(2701));

            migrationBuilder.UpdateData(
                table: "Notifikacije",
                keyColumn: "ID",
                keyValue: 1,
                column: "DatumSlanja",
                value: new DateTime(2020, 6, 13, 14, 45, 47, 258, DateTimeKind.Local).AddTicks(7357));

            migrationBuilder.UpdateData(
                table: "Novosti",
                keyColumn: "ID",
                keyValue: 1,
                column: "DatumObjave",
                value: new DateTime(2020, 6, 13, 14, 45, 47, 257, DateTimeKind.Local).AddTicks(6671));

            migrationBuilder.UpdateData(
                table: "Putnik",
                keyColumn: "ID",
                keyValue: 1,
                column: "DatumRegistracije",
                value: new DateTime(2020, 6, 13, 14, 45, 47, 247, DateTimeKind.Local).AddTicks(6043));
        }
    }
}
