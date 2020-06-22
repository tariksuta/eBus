using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eBus.WebApi.Migrations
{
    public partial class finishingdetailsthree : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Karta",
                columns: new[] { "ID", "AngazujeID", "BrojKarte", "DatumIzdavanja", "SjedisteID", "VrijemeDolaska", "VrijemePolaska" },
                values: new object[,]
                {
                    { 28, 1, "qqfjlvksgr", new DateTime(2020, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new TimeSpan(0, 10, 0, 0, 0), new TimeSpan(0, 8, 0, 0, 0) },
                    { 29, 1, "rtfjlmksgr", new DateTime(2020, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new TimeSpan(0, 10, 0, 0, 0), new TimeSpan(0, 8, 0, 0, 0) },
                    { 30, 1, "kqfjllksgb", new DateTime(2020, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, new TimeSpan(0, 10, 0, 0, 0), new TimeSpan(0, 8, 0, 0, 0) },
                    { 31, 1, "mqfjnlbsgv", new DateTime(2020, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, new TimeSpan(0, 10, 0, 0, 0), new TimeSpan(0, 8, 0, 0, 0) },
                    { 32, 1, "eqtjhlbsgv", new DateTime(2020, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, new TimeSpan(0, 10, 0, 0, 0), new TimeSpan(0, 8, 0, 0, 0) },
                    { 33, 1, "qwtjglbcgb", new DateTime(2020, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, new TimeSpan(0, 10, 0, 0, 0), new TimeSpan(0, 8, 0, 0, 0) },
                    { 34, 1, "pwtdglxcgy", new DateTime(2020, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, new TimeSpan(0, 10, 0, 0, 0), new TimeSpan(0, 8, 0, 0, 0) }
                });

            migrationBuilder.UpdateData(
                table: "KorisniciUloge",
                keyColumn: "ID",
                keyValue: 1,
                column: "DatumIzmjene",
                value: new DateTime(2020, 6, 23, 1, 10, 34, 839, DateTimeKind.Local).AddTicks(3294));

            migrationBuilder.UpdateData(
                table: "KorisniciUloge",
                keyColumn: "ID",
                keyValue: 2,
                column: "DatumIzmjene",
                value: new DateTime(2020, 6, 23, 1, 10, 34, 843, DateTimeKind.Local).AddTicks(6728));

            migrationBuilder.UpdateData(
                table: "Notifikacije",
                keyColumn: "ID",
                keyValue: 1,
                column: "DatumSlanja",
                value: new DateTime(2020, 6, 23, 1, 10, 34, 850, DateTimeKind.Local).AddTicks(3242));

            migrationBuilder.UpdateData(
                table: "Novosti",
                keyColumn: "ID",
                keyValue: 1,
                column: "DatumObjave",
                value: new DateTime(2020, 6, 23, 1, 10, 34, 849, DateTimeKind.Local).AddTicks(4619));

            migrationBuilder.UpdateData(
                table: "Putnik",
                keyColumn: "ID",
                keyValue: 1,
                column: "DatumRegistracije",
                value: new DateTime(2020, 6, 23, 1, 10, 34, 844, DateTimeKind.Local).AddTicks(9607));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "ID",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "ID",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "ID",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "ID",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "ID",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "ID",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "ID",
                keyValue: 34);

            migrationBuilder.UpdateData(
                table: "KorisniciUloge",
                keyColumn: "ID",
                keyValue: 1,
                column: "DatumIzmjene",
                value: new DateTime(2020, 6, 23, 0, 19, 9, 476, DateTimeKind.Local).AddTicks(4142));

            migrationBuilder.UpdateData(
                table: "KorisniciUloge",
                keyColumn: "ID",
                keyValue: 2,
                column: "DatumIzmjene",
                value: new DateTime(2020, 6, 23, 0, 19, 9, 480, DateTimeKind.Local).AddTicks(2801));

            migrationBuilder.UpdateData(
                table: "Notifikacije",
                keyColumn: "ID",
                keyValue: 1,
                column: "DatumSlanja",
                value: new DateTime(2020, 6, 23, 0, 19, 9, 543, DateTimeKind.Local).AddTicks(9690));

            migrationBuilder.UpdateData(
                table: "Novosti",
                keyColumn: "ID",
                keyValue: 1,
                column: "DatumObjave",
                value: new DateTime(2020, 6, 23, 0, 19, 9, 543, DateTimeKind.Local).AddTicks(4591));

            migrationBuilder.UpdateData(
                table: "Putnik",
                keyColumn: "ID",
                keyValue: 1,
                column: "DatumRegistracije",
                value: new DateTime(2020, 6, 23, 0, 19, 9, 537, DateTimeKind.Local).AddTicks(9505));
        }
    }
}
