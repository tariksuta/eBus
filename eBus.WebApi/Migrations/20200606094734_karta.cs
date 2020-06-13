using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eBus.WebApi.Migrations
{
    public partial class karta : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Angazuje",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DatumAngazovanja", "DatumIsteka" },
                values: new object[] { new DateTime(2020, 6, 6, 11, 47, 33, 614, DateTimeKind.Local).AddTicks(9868), new DateTime(2020, 6, 13, 11, 47, 33, 615, DateTimeKind.Local).AddTicks(884) });

            migrationBuilder.InsertData(
                table: "Karta",
                columns: new[] { "ID", "AngazujeID", "BrojKarte", "DatumIzdavanja", "SjedisteID", "VrijemeDolaska", "VrijemePolaska" },
                values: new object[,]
                {
                    { 1, 1, "affdsddvda", new DateTime(2020, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new TimeSpan(0, 10, 0, 0, 0), new TimeSpan(0, 8, 0, 0, 0) },
                    { 2, 1, "arfelpdvda", new DateTime(2020, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new TimeSpan(0, 10, 0, 0, 0), new TimeSpan(0, 8, 0, 0, 0) },
                    { 3, 1, "xrftlgdvdk", new DateTime(2020, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, new TimeSpan(0, 10, 0, 0, 0), new TimeSpan(0, 8, 0, 0, 0) },
                    { 4, 1, "xrftlgdvdk", new DateTime(2020, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, new TimeSpan(0, 10, 0, 0, 0), new TimeSpan(0, 8, 0, 0, 0) }
                });

            migrationBuilder.UpdateData(
                table: "KorisniciUloge",
                keyColumn: "ID",
                keyValue: 1,
                column: "DatumIzmjene",
                value: new DateTime(2020, 6, 6, 11, 47, 33, 600, DateTimeKind.Local).AddTicks(9257));

            migrationBuilder.UpdateData(
                table: "KorisniciUloge",
                keyColumn: "ID",
                keyValue: 2,
                column: "DatumIzmjene",
                value: new DateTime(2020, 6, 6, 11, 47, 33, 606, DateTimeKind.Local).AddTicks(9873));

            migrationBuilder.UpdateData(
                table: "Notifikacije",
                keyColumn: "ID",
                keyValue: 1,
                column: "DatumSlanja",
                value: new DateTime(2020, 6, 6, 11, 47, 33, 617, DateTimeKind.Local).AddTicks(5719));

            migrationBuilder.UpdateData(
                table: "Novosti",
                keyColumn: "ID",
                keyValue: 1,
                column: "DatumObjave",
                value: new DateTime(2020, 6, 6, 11, 47, 33, 616, DateTimeKind.Local).AddTicks(6981));

            migrationBuilder.UpdateData(
                table: "Putnik",
                keyColumn: "ID",
                keyValue: 1,
                column: "DatumRegistracije",
                value: new DateTime(2020, 6, 6, 11, 47, 33, 608, DateTimeKind.Local).AddTicks(8955));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "Angazuje",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DatumAngazovanja", "DatumIsteka" },
                values: new object[] { new DateTime(2020, 6, 6, 11, 45, 49, 983, DateTimeKind.Local).AddTicks(997), new DateTime(2020, 6, 13, 11, 45, 49, 983, DateTimeKind.Local).AddTicks(1716) });

            migrationBuilder.UpdateData(
                table: "KorisniciUloge",
                keyColumn: "ID",
                keyValue: 1,
                column: "DatumIzmjene",
                value: new DateTime(2020, 6, 6, 11, 45, 49, 971, DateTimeKind.Local).AddTicks(2599));

            migrationBuilder.UpdateData(
                table: "KorisniciUloge",
                keyColumn: "ID",
                keyValue: 2,
                column: "DatumIzmjene",
                value: new DateTime(2020, 6, 6, 11, 45, 49, 976, DateTimeKind.Local).AddTicks(7329));

            migrationBuilder.UpdateData(
                table: "Notifikacije",
                keyColumn: "ID",
                keyValue: 1,
                column: "DatumSlanja",
                value: new DateTime(2020, 6, 6, 11, 45, 49, 984, DateTimeKind.Local).AddTicks(3435));

            migrationBuilder.UpdateData(
                table: "Novosti",
                keyColumn: "ID",
                keyValue: 1,
                column: "DatumObjave",
                value: new DateTime(2020, 6, 6, 11, 45, 49, 983, DateTimeKind.Local).AddTicks(6569));

            migrationBuilder.UpdateData(
                table: "Putnik",
                keyColumn: "ID",
                keyValue: 1,
                column: "DatumRegistracije",
                value: new DateTime(2020, 6, 6, 11, 45, 49, 978, DateTimeKind.Local).AddTicks(749));
        }
    }
}
