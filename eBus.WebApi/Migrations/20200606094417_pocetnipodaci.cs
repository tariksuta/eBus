using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eBus.WebApi.Migrations
{
    public partial class pocetnipodaci : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "KorisniciUloge",
                keyColumn: "ID",
                keyValue: 1,
                column: "DatumIzmjene",
                value: new DateTime(2020, 6, 6, 11, 44, 16, 477, DateTimeKind.Local).AddTicks(6265));

            migrationBuilder.UpdateData(
                table: "KorisniciUloge",
                keyColumn: "ID",
                keyValue: 2,
                column: "DatumIzmjene",
                value: new DateTime(2020, 6, 6, 11, 44, 16, 485, DateTimeKind.Local).AddTicks(645));

            migrationBuilder.InsertData(
                table: "Linija",
                columns: new[] { "ID", "KorisnikID", "Naziv", "OdredisteID", "PolazisteID" },
                values: new object[] { 1, 2, "Mostar-Sarajevo", 2, 1 });

            migrationBuilder.UpdateData(
                table: "Notifikacije",
                keyColumn: "ID",
                keyValue: 1,
                column: "DatumSlanja",
                value: new DateTime(2020, 6, 6, 11, 44, 16, 493, DateTimeKind.Local).AddTicks(1285));

            migrationBuilder.UpdateData(
                table: "Novosti",
                keyColumn: "ID",
                keyValue: 1,
                column: "DatumObjave",
                value: new DateTime(2020, 6, 6, 11, 44, 16, 492, DateTimeKind.Local).AddTicks(333));

            migrationBuilder.UpdateData(
                table: "Putnik",
                keyColumn: "ID",
                keyValue: 1,
                column: "DatumRegistracije",
                value: new DateTime(2020, 6, 6, 11, 44, 16, 487, DateTimeKind.Local).AddTicks(2350));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Linija",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "KorisniciUloge",
                keyColumn: "ID",
                keyValue: 1,
                column: "DatumIzmjene",
                value: new DateTime(2020, 6, 5, 23, 21, 58, 724, DateTimeKind.Local).AddTicks(1289));

            migrationBuilder.UpdateData(
                table: "KorisniciUloge",
                keyColumn: "ID",
                keyValue: 2,
                column: "DatumIzmjene",
                value: new DateTime(2020, 6, 5, 23, 21, 58, 730, DateTimeKind.Local).AddTicks(475));

            migrationBuilder.UpdateData(
                table: "Notifikacije",
                keyColumn: "ID",
                keyValue: 1,
                column: "DatumSlanja",
                value: new DateTime(2020, 6, 5, 23, 21, 58, 734, DateTimeKind.Local).AddTicks(8986));

            migrationBuilder.UpdateData(
                table: "Novosti",
                keyColumn: "ID",
                keyValue: 1,
                column: "DatumObjave",
                value: new DateTime(2020, 6, 5, 23, 21, 58, 734, DateTimeKind.Local).AddTicks(2317));

            migrationBuilder.UpdateData(
                table: "Putnik",
                keyColumn: "ID",
                keyValue: 1,
                column: "DatumRegistracije",
                value: new DateTime(2020, 6, 5, 23, 21, 58, 731, DateTimeKind.Local).AddTicks(7464));
        }
    }
}
