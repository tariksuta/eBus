using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eBus.WebApi.Migrations
{
    public partial class ispravka1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "Kolona", "Red" },
                values: new object[] { 4, 1 });

            migrationBuilder.UpdateData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 5,
                column: "Kolona",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 6,
                column: "Kolona",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "Kolona", "Red" },
                values: new object[] { 3, 2 });

            migrationBuilder.UpdateData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "Kolona", "Red" },
                values: new object[] { 4, 2 });

            migrationBuilder.UpdateData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 9,
                column: "Kolona",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "Kolona", "Red" },
                values: new object[] { 2, 3 });

            migrationBuilder.UpdateData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "Kolona", "Red" },
                values: new object[] { 3, 3 });

            migrationBuilder.UpdateData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "Kolona", "Red" },
                values: new object[] { 4, 3 });

            migrationBuilder.UpdateData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 13,
                column: "Red",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 14,
                column: "Red",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 15,
                column: "Red",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "Kolona", "Red" },
                values: new object[] { 4, 4 });

            migrationBuilder.UpdateData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "Kolona", "Red" },
                values: new object[] { 1, 5 });

            migrationBuilder.UpdateData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "Kolona", "Red" },
                values: new object[] { 2, 5 });

            migrationBuilder.UpdateData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "Kolona", "Red" },
                values: new object[] { 3, 5 });

            migrationBuilder.UpdateData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "Kolona", "Red" },
                values: new object[] { 4, 5 });

            migrationBuilder.UpdateData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 21,
                columns: new[] { "Kolona", "Red" },
                values: new object[] { 1, 6 });

            migrationBuilder.UpdateData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 22,
                columns: new[] { "Kolona", "Red" },
                values: new object[] { 2, 6 });

            migrationBuilder.UpdateData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 23,
                columns: new[] { "Kolona", "Red" },
                values: new object[] { 3, 6 });

            migrationBuilder.UpdateData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 24,
                columns: new[] { "Kolona", "Red" },
                values: new object[] { 4, 6 });

            migrationBuilder.UpdateData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 25,
                column: "Red",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 26,
                column: "Red",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 27,
                column: "Red",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 28,
                columns: new[] { "Kolona", "Red" },
                values: new object[] { 4, 7 });

            migrationBuilder.UpdateData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 29,
                columns: new[] { "Kolona", "Red" },
                values: new object[] { 1, 8 });

            migrationBuilder.UpdateData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 30,
                columns: new[] { "Kolona", "Red" },
                values: new object[] { 2, 8 });

            migrationBuilder.UpdateData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 31,
                columns: new[] { "Kolona", "Red" },
                values: new object[] { 3, 8 });

            migrationBuilder.UpdateData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 32,
                columns: new[] { "Kolona", "Red" },
                values: new object[] { 4, 8 });

            migrationBuilder.UpdateData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 33,
                columns: new[] { "Kolona", "Red" },
                values: new object[] { 1, 9 });

            migrationBuilder.UpdateData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 34,
                columns: new[] { "Kolona", "Red" },
                values: new object[] { 2, 9 });

            migrationBuilder.UpdateData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 35,
                columns: new[] { "Kolona", "Red" },
                values: new object[] { 3, 9 });

            migrationBuilder.UpdateData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 36,
                columns: new[] { "Kolona", "Red" },
                values: new object[] { 4, 9 });

            migrationBuilder.UpdateData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 37,
                column: "Red",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 38,
                column: "Red",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 39,
                column: "Red",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 40,
                columns: new[] { "Kolona", "Red" },
                values: new object[] { 4, 10 });

            migrationBuilder.UpdateData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 41,
                columns: new[] { "Kolona", "Red" },
                values: new object[] { 1, 11 });

            migrationBuilder.UpdateData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 42,
                columns: new[] { "Kolona", "Red" },
                values: new object[] { 2, 11 });

            migrationBuilder.UpdateData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 43,
                columns: new[] { "Kolona", "Red" },
                values: new object[] { 3, 11 });

            migrationBuilder.UpdateData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 44,
                columns: new[] { "Kolona", "Red" },
                values: new object[] { 4, 11 });

            migrationBuilder.UpdateData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 49,
                columns: new[] { "Kolona", "Red" },
                values: new object[] { 1, 2 });

            migrationBuilder.UpdateData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 50,
                columns: new[] { "Kolona", "Red" },
                values: new object[] { 2, 2 });

            migrationBuilder.UpdateData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 51,
                columns: new[] { "Kolona", "Red" },
                values: new object[] { 3, 2 });

            migrationBuilder.UpdateData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 52,
                columns: new[] { "Kolona", "Red" },
                values: new object[] { 4, 2 });

            migrationBuilder.UpdateData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 53,
                columns: new[] { "Kolona", "Red" },
                values: new object[] { 1, 3 });

            migrationBuilder.UpdateData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 54,
                columns: new[] { "Kolona", "Red" },
                values: new object[] { 2, 3 });

            migrationBuilder.UpdateData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 55,
                columns: new[] { "Kolona", "Red" },
                values: new object[] { 3, 3 });

            migrationBuilder.UpdateData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 56,
                columns: new[] { "Kolona", "Red" },
                values: new object[] { 4, 3 });

            migrationBuilder.UpdateData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 57,
                columns: new[] { "Kolona", "Red" },
                values: new object[] { 1, 4 });

            migrationBuilder.UpdateData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 58,
                columns: new[] { "Kolona", "Red" },
                values: new object[] { 2, 4 });

            migrationBuilder.UpdateData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 59,
                columns: new[] { "Kolona", "Red" },
                values: new object[] { 3, 4 });

            migrationBuilder.UpdateData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 60,
                columns: new[] { "Kolona", "Red" },
                values: new object[] { 4, 4 });

            migrationBuilder.UpdateData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 61,
                columns: new[] { "Kolona", "Red" },
                values: new object[] { 1, 5 });

            migrationBuilder.UpdateData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 62,
                columns: new[] { "Kolona", "Red" },
                values: new object[] { 2, 5 });

            migrationBuilder.UpdateData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 63,
                columns: new[] { "Kolona", "Red" },
                values: new object[] { 3, 5 });

            migrationBuilder.UpdateData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 64,
                columns: new[] { "Kolona", "Red" },
                values: new object[] { 4, 5 });

            migrationBuilder.UpdateData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 65,
                columns: new[] { "Kolona", "Red" },
                values: new object[] { 1, 6 });

            migrationBuilder.UpdateData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 66,
                columns: new[] { "Kolona", "Red" },
                values: new object[] { 2, 6 });

            migrationBuilder.UpdateData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 67,
                columns: new[] { "Kolona", "Red" },
                values: new object[] { 3, 6 });

            migrationBuilder.UpdateData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 68,
                columns: new[] { "Kolona", "Red" },
                values: new object[] { 4, 6 });

            migrationBuilder.UpdateData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 69,
                columns: new[] { "Kolona", "Red" },
                values: new object[] { 1, 7 });

            migrationBuilder.UpdateData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 70,
                columns: new[] { "Kolona", "Red" },
                values: new object[] { 2, 7 });

            migrationBuilder.UpdateData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 71,
                columns: new[] { "Kolona", "Red" },
                values: new object[] { 3, 7 });

            migrationBuilder.UpdateData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 72,
                columns: new[] { "Kolona", "Red" },
                values: new object[] { 4, 7 });

            migrationBuilder.UpdateData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 73,
                columns: new[] { "Kolona", "Red" },
                values: new object[] { 1, 8 });

            migrationBuilder.UpdateData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 74,
                columns: new[] { "Kolona", "Red" },
                values: new object[] { 2, 8 });

            migrationBuilder.UpdateData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 75,
                columns: new[] { "Kolona", "Red" },
                values: new object[] { 3, 8 });

            migrationBuilder.UpdateData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 76,
                columns: new[] { "Kolona", "Red" },
                values: new object[] { 4, 8 });

            migrationBuilder.UpdateData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 77,
                columns: new[] { "Kolona", "Red" },
                values: new object[] { 1, 9 });

            migrationBuilder.UpdateData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 78,
                columns: new[] { "Kolona", "Red" },
                values: new object[] { 2, 9 });

            migrationBuilder.UpdateData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 79,
                columns: new[] { "Kolona", "Red" },
                values: new object[] { 3, 9 });

            migrationBuilder.UpdateData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 80,
                columns: new[] { "Kolona", "Red" },
                values: new object[] { 4, 9 });

            migrationBuilder.UpdateData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 81,
                columns: new[] { "Kolona", "Red" },
                values: new object[] { 1, 10 });

            migrationBuilder.UpdateData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 82,
                columns: new[] { "Kolona", "Red" },
                values: new object[] { 2, 10 });

            migrationBuilder.UpdateData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 83,
                columns: new[] { "Kolona", "Red" },
                values: new object[] { 3, 10 });

            migrationBuilder.UpdateData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 84,
                columns: new[] { "Kolona", "Red" },
                values: new object[] { 4, 10 });

            migrationBuilder.UpdateData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 85,
                columns: new[] { "Kolona", "Red" },
                values: new object[] { 1, 11 });

            migrationBuilder.UpdateData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 86,
                columns: new[] { "Kolona", "Red" },
                values: new object[] { 2, 11 });

            migrationBuilder.UpdateData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 87,
                columns: new[] { "Kolona", "Red" },
                values: new object[] { 3, 11 });

            migrationBuilder.UpdateData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 88,
                columns: new[] { "Kolona", "Red" },
                values: new object[] { 4, 11 });

            migrationBuilder.UpdateData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 89,
                columns: new[] { "Kolona", "Red" },
                values: new object[] { 1, 12 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Angazuje",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DatumAngazovanja", "DatumIsteka" },
                values: new object[] { new DateTime(2020, 6, 6, 11, 47, 33, 614, DateTimeKind.Local).AddTicks(9868), new DateTime(2020, 6, 13, 11, 47, 33, 615, DateTimeKind.Local).AddTicks(884) });

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

            migrationBuilder.UpdateData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "Kolona", "Red" },
                values: new object[] { 1, 2 });

            migrationBuilder.UpdateData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 5,
                column: "Kolona",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 6,
                column: "Kolona",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "Kolona", "Red" },
                values: new object[] { 1, 3 });

            migrationBuilder.UpdateData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "Kolona", "Red" },
                values: new object[] { 2, 3 });

            migrationBuilder.UpdateData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 9,
                column: "Kolona",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "Kolona", "Red" },
                values: new object[] { 1, 4 });

            migrationBuilder.UpdateData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "Kolona", "Red" },
                values: new object[] { 2, 4 });

            migrationBuilder.UpdateData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "Kolona", "Red" },
                values: new object[] { 3, 4 });

            migrationBuilder.UpdateData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 13,
                column: "Red",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 14,
                column: "Red",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 15,
                column: "Red",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "Kolona", "Red" },
                values: new object[] { 1, 6 });

            migrationBuilder.UpdateData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "Kolona", "Red" },
                values: new object[] { 2, 6 });

            migrationBuilder.UpdateData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "Kolona", "Red" },
                values: new object[] { 3, 6 });

            migrationBuilder.UpdateData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "Kolona", "Red" },
                values: new object[] { 1, 7 });

            migrationBuilder.UpdateData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "Kolona", "Red" },
                values: new object[] { 2, 7 });

            migrationBuilder.UpdateData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 21,
                columns: new[] { "Kolona", "Red" },
                values: new object[] { 3, 7 });

            migrationBuilder.UpdateData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 22,
                columns: new[] { "Kolona", "Red" },
                values: new object[] { 1, 8 });

            migrationBuilder.UpdateData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 23,
                columns: new[] { "Kolona", "Red" },
                values: new object[] { 2, 8 });

            migrationBuilder.UpdateData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 24,
                columns: new[] { "Kolona", "Red" },
                values: new object[] { 3, 8 });

            migrationBuilder.UpdateData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 25,
                column: "Red",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 26,
                column: "Red",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 27,
                column: "Red",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 28,
                columns: new[] { "Kolona", "Red" },
                values: new object[] { 1, 10 });

            migrationBuilder.UpdateData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 29,
                columns: new[] { "Kolona", "Red" },
                values: new object[] { 2, 10 });

            migrationBuilder.UpdateData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 30,
                columns: new[] { "Kolona", "Red" },
                values: new object[] { 3, 10 });

            migrationBuilder.UpdateData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 31,
                columns: new[] { "Kolona", "Red" },
                values: new object[] { 1, 11 });

            migrationBuilder.UpdateData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 32,
                columns: new[] { "Kolona", "Red" },
                values: new object[] { 2, 11 });

            migrationBuilder.UpdateData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 33,
                columns: new[] { "Kolona", "Red" },
                values: new object[] { 3, 11 });

            migrationBuilder.UpdateData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 34,
                columns: new[] { "Kolona", "Red" },
                values: new object[] { 1, 12 });

            migrationBuilder.UpdateData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 35,
                columns: new[] { "Kolona", "Red" },
                values: new object[] { 2, 12 });

            migrationBuilder.UpdateData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 36,
                columns: new[] { "Kolona", "Red" },
                values: new object[] { 3, 12 });

            migrationBuilder.UpdateData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 37,
                column: "Red",
                value: 13);

            migrationBuilder.UpdateData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 38,
                column: "Red",
                value: 13);

            migrationBuilder.UpdateData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 39,
                column: "Red",
                value: 13);

            migrationBuilder.UpdateData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 40,
                columns: new[] { "Kolona", "Red" },
                values: new object[] { 1, 14 });

            migrationBuilder.UpdateData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 41,
                columns: new[] { "Kolona", "Red" },
                values: new object[] { 2, 14 });

            migrationBuilder.UpdateData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 42,
                columns: new[] { "Kolona", "Red" },
                values: new object[] { 3, 14 });

            migrationBuilder.UpdateData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 43,
                columns: new[] { "Kolona", "Red" },
                values: new object[] { 1, 15 });

            migrationBuilder.UpdateData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 44,
                columns: new[] { "Kolona", "Red" },
                values: new object[] { 2, 15 });

            migrationBuilder.UpdateData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 49,
                columns: new[] { "Kolona", "Red" },
                values: new object[] { 5, 1 });

            migrationBuilder.UpdateData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 50,
                columns: new[] { "Kolona", "Red" },
                values: new object[] { 6, 1 });

            migrationBuilder.UpdateData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 51,
                columns: new[] { "Kolona", "Red" },
                values: new object[] { 7, 1 });

            migrationBuilder.UpdateData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 52,
                columns: new[] { "Kolona", "Red" },
                values: new object[] { 8, 1 });

            migrationBuilder.UpdateData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 53,
                columns: new[] { "Kolona", "Red" },
                values: new object[] { 9, 1 });

            migrationBuilder.UpdateData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 54,
                columns: new[] { "Kolona", "Red" },
                values: new object[] { 10, 1 });

            migrationBuilder.UpdateData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 55,
                columns: new[] { "Kolona", "Red" },
                values: new object[] { 11, 1 });

            migrationBuilder.UpdateData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 56,
                columns: new[] { "Kolona", "Red" },
                values: new object[] { 12, 1 });

            migrationBuilder.UpdateData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 57,
                columns: new[] { "Kolona", "Red" },
                values: new object[] { 13, 1 });

            migrationBuilder.UpdateData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 58,
                columns: new[] { "Kolona", "Red" },
                values: new object[] { 14, 1 });

            migrationBuilder.UpdateData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 59,
                columns: new[] { "Kolona", "Red" },
                values: new object[] { 15, 1 });

            migrationBuilder.UpdateData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 60,
                columns: new[] { "Kolona", "Red" },
                values: new object[] { 16, 1 });

            migrationBuilder.UpdateData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 61,
                columns: new[] { "Kolona", "Red" },
                values: new object[] { 17, 1 });

            migrationBuilder.UpdateData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 62,
                columns: new[] { "Kolona", "Red" },
                values: new object[] { 18, 1 });

            migrationBuilder.UpdateData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 63,
                columns: new[] { "Kolona", "Red" },
                values: new object[] { 19, 1 });

            migrationBuilder.UpdateData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 64,
                columns: new[] { "Kolona", "Red" },
                values: new object[] { 20, 1 });

            migrationBuilder.UpdateData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 65,
                columns: new[] { "Kolona", "Red" },
                values: new object[] { 21, 1 });

            migrationBuilder.UpdateData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 66,
                columns: new[] { "Kolona", "Red" },
                values: new object[] { 22, 1 });

            migrationBuilder.UpdateData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 67,
                columns: new[] { "Kolona", "Red" },
                values: new object[] { 23, 1 });

            migrationBuilder.UpdateData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 68,
                columns: new[] { "Kolona", "Red" },
                values: new object[] { 24, 1 });

            migrationBuilder.UpdateData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 69,
                columns: new[] { "Kolona", "Red" },
                values: new object[] { 25, 1 });

            migrationBuilder.UpdateData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 70,
                columns: new[] { "Kolona", "Red" },
                values: new object[] { 26, 1 });

            migrationBuilder.UpdateData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 71,
                columns: new[] { "Kolona", "Red" },
                values: new object[] { 27, 1 });

            migrationBuilder.UpdateData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 72,
                columns: new[] { "Kolona", "Red" },
                values: new object[] { 28, 1 });

            migrationBuilder.UpdateData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 73,
                columns: new[] { "Kolona", "Red" },
                values: new object[] { 29, 1 });

            migrationBuilder.UpdateData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 74,
                columns: new[] { "Kolona", "Red" },
                values: new object[] { 30, 1 });

            migrationBuilder.UpdateData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 75,
                columns: new[] { "Kolona", "Red" },
                values: new object[] { 31, 1 });

            migrationBuilder.UpdateData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 76,
                columns: new[] { "Kolona", "Red" },
                values: new object[] { 32, 1 });

            migrationBuilder.UpdateData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 77,
                columns: new[] { "Kolona", "Red" },
                values: new object[] { 33, 1 });

            migrationBuilder.UpdateData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 78,
                columns: new[] { "Kolona", "Red" },
                values: new object[] { 34, 1 });

            migrationBuilder.UpdateData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 79,
                columns: new[] { "Kolona", "Red" },
                values: new object[] { 35, 1 });

            migrationBuilder.UpdateData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 80,
                columns: new[] { "Kolona", "Red" },
                values: new object[] { 36, 1 });

            migrationBuilder.UpdateData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 81,
                columns: new[] { "Kolona", "Red" },
                values: new object[] { 37, 1 });

            migrationBuilder.UpdateData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 82,
                columns: new[] { "Kolona", "Red" },
                values: new object[] { 38, 1 });

            migrationBuilder.UpdateData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 83,
                columns: new[] { "Kolona", "Red" },
                values: new object[] { 39, 1 });

            migrationBuilder.UpdateData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 84,
                columns: new[] { "Kolona", "Red" },
                values: new object[] { 40, 1 });

            migrationBuilder.UpdateData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 85,
                columns: new[] { "Kolona", "Red" },
                values: new object[] { 41, 1 });

            migrationBuilder.UpdateData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 86,
                columns: new[] { "Kolona", "Red" },
                values: new object[] { 42, 1 });

            migrationBuilder.UpdateData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 87,
                columns: new[] { "Kolona", "Red" },
                values: new object[] { 43, 1 });

            migrationBuilder.UpdateData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 88,
                columns: new[] { "Kolona", "Red" },
                values: new object[] { 44, 1 });

            migrationBuilder.UpdateData(
                table: "Sjediste",
                keyColumn: "ID",
                keyValue: 89,
                columns: new[] { "Kolona", "Red" },
                values: new object[] { 45, 1 });
        }
    }
}
