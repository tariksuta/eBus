using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eBus.WebApi.Migrations
{
    public partial class dodatno : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Angazuje",
                columns: new[] { "ID", "DatumAngazovanja", "DatumIsteka", "LinijaID", "VoziloID" },
                values: new object[] { 1, new DateTime(2020, 6, 6, 11, 45, 49, 983, DateTimeKind.Local).AddTicks(997), new DateTime(2020, 6, 13, 11, 45, 49, 983, DateTimeKind.Local).AddTicks(1716), 1, 1 });

            migrationBuilder.InsertData(
                table: "Cijena",
                columns: new[] { "ID", "Iznos", "KompanijaID", "LinijaID", "Popust" },
                values: new object[] { 1, 22m, 1, 1, 0f });

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

            migrationBuilder.InsertData(
                table: "Sjediste",
                columns: new[] { "ID", "Kolona", "Red", "VoziloID" },
                values: new object[,]
                {
                    { 3, 3, 1, 1 },
                    { 67, 23, 1, 2 },
                    { 66, 22, 1, 2 },
                    { 65, 21, 1, 2 },
                    { 64, 20, 1, 2 },
                    { 63, 19, 1, 2 },
                    { 62, 18, 1, 2 },
                    { 61, 17, 1, 2 },
                    { 60, 16, 1, 2 },
                    { 58, 14, 1, 2 },
                    { 68, 24, 1, 2 },
                    { 57, 13, 1, 2 },
                    { 56, 12, 1, 2 },
                    { 55, 11, 1, 2 },
                    { 54, 10, 1, 2 },
                    { 53, 9, 1, 2 },
                    { 52, 8, 1, 2 },
                    { 51, 7, 1, 2 },
                    { 59, 15, 1, 2 },
                    { 69, 25, 1, 2 },
                    { 71, 27, 1, 2 },
                    { 50, 6, 1, 2 },
                    { 89, 45, 1, 2 },
                    { 88, 44, 1, 2 },
                    { 87, 43, 1, 2 },
                    { 86, 42, 1, 2 },
                    { 85, 41, 1, 2 },
                    { 84, 40, 1, 2 },
                    { 83, 39, 1, 2 },
                    { 82, 38, 1, 2 },
                    { 70, 26, 1, 2 },
                    { 81, 37, 1, 2 },
                    { 79, 35, 1, 2 },
                    { 78, 34, 1, 2 },
                    { 77, 33, 1, 2 },
                    { 76, 32, 1, 2 },
                    { 75, 31, 1, 2 },
                    { 74, 30, 1, 2 },
                    { 73, 29, 1, 2 },
                    { 72, 28, 1, 2 },
                    { 80, 36, 1, 2 },
                    { 49, 5, 1, 2 },
                    { 48, 4, 1, 2 },
                    { 47, 3, 1, 2 },
                    { 22, 1, 8, 1 },
                    { 21, 3, 7, 1 },
                    { 20, 2, 7, 1 },
                    { 19, 1, 7, 1 },
                    { 18, 3, 6, 1 },
                    { 17, 2, 6, 1 },
                    { 16, 1, 6, 1 },
                    { 15, 3, 5, 1 },
                    { 14, 2, 5, 1 },
                    { 13, 1, 5, 1 },
                    { 12, 3, 4, 1 },
                    { 11, 2, 4, 1 },
                    { 10, 1, 4, 1 },
                    { 9, 3, 3, 1 },
                    { 8, 2, 3, 1 },
                    { 7, 1, 3, 1 },
                    { 6, 3, 2, 1 },
                    { 5, 2, 2, 1 },
                    { 4, 1, 2, 1 },
                    { 23, 2, 8, 1 },
                    { 24, 3, 8, 1 },
                    { 25, 1, 9, 1 },
                    { 26, 2, 9, 1 },
                    { 1, 1, 1, 1 },
                    { 45, 1, 1, 2 },
                    { 44, 2, 15, 1 },
                    { 43, 1, 15, 1 },
                    { 42, 3, 14, 1 },
                    { 41, 2, 14, 1 },
                    { 40, 1, 14, 1 },
                    { 39, 3, 13, 1 },
                    { 38, 2, 13, 1 },
                    { 2, 2, 1, 1 },
                    { 37, 1, 13, 1 },
                    { 35, 2, 12, 1 },
                    { 34, 1, 12, 1 },
                    { 33, 3, 11, 1 },
                    { 32, 2, 11, 1 },
                    { 31, 1, 11, 1 },
                    { 30, 3, 10, 1 },
                    { 29, 2, 10, 1 },
                    { 28, 1, 10, 1 },
                    { 27, 3, 9, 1 },
                    { 36, 3, 12, 1 },
                    { 46, 2, 1, 2 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Angazuje",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cijena",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 89);

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
    }
}
