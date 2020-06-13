using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eBus.WebApi.Migrations
{
    public partial class podaci2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Angazuje",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DatumAngazovanja", "DatumIsteka" },
                values: new object[] { new DateTime(2020, 6, 13, 14, 45, 47, 255, DateTimeKind.Local).AddTicks(5281), new DateTime(2020, 6, 20, 14, 45, 47, 255, DateTimeKind.Local).AddTicks(6661) });

            migrationBuilder.InsertData(
                table: "Karta",
                columns: new[] { "ID", "AngazujeID", "BrojKarte", "DatumIzdavanja", "SjedisteID", "VrijemeDolaska", "VrijemePolaska" },
                values: new object[,]
                {
                    { 5, 1, "affdstdoda", new DateTime(2020, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new TimeSpan(0, 10, 0, 0, 0), new TimeSpan(0, 8, 0, 0, 0) },
                    { 6, 1, "yetdsudvda", new DateTime(2020, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new TimeSpan(0, 10, 0, 0, 0), new TimeSpan(0, 8, 0, 0, 0) },
                    { 7, 1, "xetdszdvdp", new DateTime(2020, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, new TimeSpan(0, 10, 0, 0, 0), new TimeSpan(0, 8, 0, 0, 0) },
                    { 8, 1, "xewdszxvlp", new DateTime(2020, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, new TimeSpan(0, 10, 0, 0, 0), new TimeSpan(0, 8, 0, 0, 0) }
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.UpdateData(
                table: "Angazuje",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DatumAngazovanja", "DatumIsteka" },
                values: new object[] { new DateTime(2020, 6, 6, 12, 2, 27, 67, DateTimeKind.Local).AddTicks(9555), new DateTime(2020, 6, 13, 12, 2, 27, 68, DateTimeKind.Local).AddTicks(522) });

            migrationBuilder.UpdateData(
                table: "KorisniciUloge",
                keyColumn: "ID",
                keyValue: 1,
                column: "DatumIzmjene",
                value: new DateTime(2020, 6, 6, 12, 2, 27, 54, DateTimeKind.Local).AddTicks(9498));

            migrationBuilder.UpdateData(
                table: "KorisniciUloge",
                keyColumn: "ID",
                keyValue: 2,
                column: "DatumIzmjene",
                value: new DateTime(2020, 6, 6, 12, 2, 27, 60, DateTimeKind.Local).AddTicks(1651));

            migrationBuilder.UpdateData(
                table: "Notifikacije",
                keyColumn: "ID",
                keyValue: 1,
                column: "DatumSlanja",
                value: new DateTime(2020, 6, 6, 12, 2, 27, 70, DateTimeKind.Local).AddTicks(6305));

            migrationBuilder.UpdateData(
                table: "Novosti",
                keyColumn: "ID",
                keyValue: 1,
                column: "DatumObjave",
                value: new DateTime(2020, 6, 6, 12, 2, 27, 69, DateTimeKind.Local).AddTicks(5865));

            migrationBuilder.UpdateData(
                table: "Putnik",
                keyColumn: "ID",
                keyValue: 1,
                column: "DatumRegistracije",
                value: new DateTime(2020, 6, 6, 12, 2, 27, 61, DateTimeKind.Local).AddTicks(9003));
        }
    }
}
