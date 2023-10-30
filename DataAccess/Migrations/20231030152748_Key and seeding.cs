using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class Keyandseeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductInventories_Products_ProductId",
                table: "ProductInventories");

            migrationBuilder.DropIndex(
                name: "IX_ProductInventories_ProductId",
                table: "ProductInventories");

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("01a0723f-e30e-4baa-9259-de8127ec0180"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("0978b756-a3b3-4d43-b68a-81d199b0c019"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("0988613f-2217-42d3-b638-31967430b480"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("0cfd699c-a518-4f67-af1f-e0049bcdad9f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("0fcd3d62-8f39-4249-af3f-b6fa024f644c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("1013c2b6-a183-4d3d-86d9-93cdd1c3075a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("11f69707-5f94-422a-8404-b445cad4c1d4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("1352645f-5f8e-48bf-8199-f43b47f89b07"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("1577d4ed-d9fe-4ffd-a1d9-460a9261a2ed"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("162f8dea-2a5b-49a5-ac1f-d76a5ed9a1a2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("1752a687-cf8e-412f-b615-a24778fe6328"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("1797b4f2-e2c7-49d4-9af1-f37686e89579"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("17ac449b-ae6f-417a-a9cb-1939bd078054"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("181f55fd-54fb-489f-a7d8-2bd00d1d5a4e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("1bb69825-b5c8-4203-9699-92c5766b3a0a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("1bdac6ae-4804-4878-b4c2-0eb935737f7c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("1c56d425-23c5-46f2-826d-c01f71046e86"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("2070b5b4-d351-4b21-8037-1a03d6e2a60a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("24dbb0a6-1cca-49f1-89ca-80d8c63eb2b0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("2e27a761-7ddc-4f8b-82ef-ec9448115c40"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("33b6d403-ddf9-4016-b17e-a86077fa8af8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("34b3d64b-fe38-4421-a1ec-e41240bdb21a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("3961c569-1539-453c-af93-b6baf4e8f42f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("3cef6c38-7f3b-4684-925c-349a136fc952"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("401d2d9d-1a98-49b7-8cd4-25da142d4670"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("4119ce2c-409d-4c63-b50f-62d4b03c8557"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("42c99901-e155-4857-8603-daa6f53788ca"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("441fdb89-a856-43be-a638-a63051288ca4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("450ec360-7b5f-4693-8aa2-e2670b69e645"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("467af521-5c98-452f-a976-bb5932a31173"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("48135ae2-a47d-41fc-aed9-5c3e77485600"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("4d7cec0d-7809-480e-ba5b-4a1a039881ae"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("4e105b41-c979-4076-8be8-c88bcb82146b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("5408c206-5657-4f2a-a8ae-8bf2d908a2b5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("54e97419-75fc-4ba9-81a5-2b574efe5660"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("5545c939-a686-4547-ad28-8489f68248b3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("5563be8e-db8d-418a-ab3f-11eea9414cc8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("5806b350-226c-44a6-ba95-56d4fcdd692f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("5bf2a832-09c9-4aa3-889f-54223c07b8c9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("5dde305e-0b24-4025-b34d-ad493b7798f5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("65dd2849-4837-4e2b-90c6-b559569c8370"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("67073481-17ff-43a3-a58b-61f6157c3057"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("6afff7e1-d12d-4b9e-ab92-57926dd28e78"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("6b02fec4-c846-4961-90e1-ef2560a10008"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("6bb26f13-1db2-47a1-85a3-22241076a12b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("6fffa262-204a-403d-a909-7357674c73e9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("713b52a6-474f-45c3-89a3-3d09869bc8f1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("72312947-ef62-4968-bded-047fc930fce7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("75f22616-3803-4dd1-8b44-eea2554792af"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("7819d10a-2200-4625-bd4f-879725959b16"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("785c1515-073b-4062-83c6-6e1f8800abed"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("7a730650-3a35-41a6-b993-e63f1040b0b6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("81f08a41-5a37-4e4b-94e3-4c851f1c747d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("85491136-4efb-45af-a26f-b20bb5b55502"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("86d2aa72-0fe2-49db-a1fd-ca2df098a2c4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("882168c7-dddf-4a6e-92fa-d31fe669dd0e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("8ad892ad-7ea8-4250-896e-bd982f1217da"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("8c6a1cef-f1d0-45d8-83c5-14376a69c5b8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("9084b549-11a4-4a89-99c3-c1863f36d97f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("91b3907b-4bed-494a-82ff-c316dc1243e1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("91d212e7-df4f-4640-97af-16869542ad05"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("958e9992-7f72-44b7-aa40-789bea769420"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("98ac508e-ebe1-4a18-b7a2-5cfd9bf0bb24"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("994b9a80-d713-4734-a047-874e03c10a1e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("9b0e61a9-d8f9-4783-a2b9-6cd2bd4bb543"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("9ca7670e-d694-460b-aef9-22db4bbe5a9f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("9cd51294-65b2-40b2-9237-bae170703925"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("9da55ebf-07de-4791-9754-335de64aa23f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("a322a511-5715-4a93-b5f2-518dbbf429b2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("a41dc699-c5c7-4f96-9f9d-fb44b5f0a01c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("a4a884ca-ae7c-4a76-abc6-a701a10a1df2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("a4accaf0-570a-4763-998c-ce8ceac1d0ea"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("a6b08185-cd6e-4cbb-bb98-61f4769fd6e2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("a6cfbcf8-19f8-4fee-8e28-58384ba33f9a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("a8c7800f-aea0-4ccd-9efd-a0becf07526e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("aa3d3e64-3d76-45be-9981-3583a91626a3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("ab02f61b-a7a7-443c-8565-c1f6dfec412b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("ab457b6d-3203-45aa-8cd1-bb25fdad5817"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("ae841920-8947-482f-bc7a-421767a094dc"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("b19d897e-226b-48cc-8efa-5357321846fd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("b231e726-3a57-4d5d-87ce-2098383095ba"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("b31baf5b-dcd2-46a1-b4eb-cf0e95fd0d29"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("b355f774-54fd-4107-97d0-47578d4a955a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("b449bece-feaf-449a-b3ed-7b5d8fb022f5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("b54191d9-fbc8-46ac-a409-5454443bd9ad"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("b778da7d-ea6c-4b7e-b400-6c9e614d63e4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("bc7e5fbb-22f6-4323-bb08-a9ce92f15a8b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("bcbc5db3-2fd7-42e7-813e-bc3f88dbaebb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("c01a744c-c83a-4805-b8bb-65057555bf9c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("c05617c1-fb85-4ad3-ab17-09b57b3a0c92"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("c82d3f4a-c66b-46ed-967a-35b5670b86c7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("caddce43-7e4f-471d-913e-d1bd5a14eebc"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("cbbfca3f-588a-4905-a849-37a324ce6e36"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("d1101384-2c62-40fe-8812-fac7853a2d0c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("d41904e7-a0db-4615-807c-083bd2c0aa2d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("dde4552e-1e9c-405f-9390-fea684727763"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("dfc9a2e3-f346-420d-901d-48f2880affd1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("e0e4ef0b-ac6f-4b37-ad4f-3fe720d76a4c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("e69b27ad-554e-4ff4-8989-bc618bb79ddb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("ea1c9b70-680c-4de8-a4e0-e5d360ea1ce6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("ea26e674-10cf-463d-809f-24ab7aface6e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("ee77d729-cfae-4977-8bb8-6fb371cd93e8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("ef415501-1f2c-4698-8b16-0c5c1865657b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("f2c3c633-07f5-4740-8618-c95dabf1b036"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("f7884ff7-8f5e-4b2a-a674-ad2fd5579439"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("f85fb346-2c41-43d0-9192-e837882b072b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("fcab86f6-7722-43da-a7c5-4753ee25ae45"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("ff57f021-c0a4-420f-8146-ebc40d611846"));

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "ProductInventories");

            migrationBuilder.AlterColumn<Guid>(
                name: "ProductInventoryId",
                table: "ProductInventories",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.InsertData(
                table: "ProductInventories",
                columns: new[] { "ProductInventoryId", "LastInventory", "Quantity" },
                values: new object[,]
                {
                    { new Guid("00e9ac68-5a60-4efd-a087-480cbd1d4560"), new DateTime(2023, 10, 30, 16, 27, 47, 866, DateTimeKind.Local).AddTicks(9802), 56 },
                    { new Guid("020fefb6-905f-4cfc-affb-87438f76e3f2"), new DateTime(2023, 10, 30, 16, 27, 47, 866, DateTimeKind.Local).AddTicks(9834), 54 },
                    { new Guid("0322cc1b-ef8c-41c6-a471-c6dd9f8a5df3"), new DateTime(2023, 10, 30, 16, 27, 47, 866, DateTimeKind.Local).AddTicks(9979), 20 },
                    { new Guid("03ee2b9e-206b-4284-83ba-83a4a9e112c6"), new DateTime(2023, 10, 30, 16, 27, 47, 866, DateTimeKind.Local).AddTicks(9643), 58 },
                    { new Guid("04080c21-8f98-4bfb-8038-cd257c9554fb"), new DateTime(2023, 10, 30, 16, 27, 47, 866, DateTimeKind.Local).AddTicks(9864), 73 },
                    { new Guid("059684d0-b5d1-4ab0-8e20-2b64b73a22ac"), new DateTime(2023, 10, 30, 16, 27, 47, 866, DateTimeKind.Local).AddTicks(9783), 91 },
                    { new Guid("0681df8f-4764-441e-8d96-0381d104dc70"), new DateTime(2023, 10, 30, 16, 27, 47, 866, DateTimeKind.Local).AddTicks(9853), 31 },
                    { new Guid("06e9db33-a016-4fc0-91cf-0adb29728ecd"), new DateTime(2023, 10, 30, 16, 27, 47, 866, DateTimeKind.Local).AddTicks(9972), 73 },
                    { new Guid("0773be28-22d5-41e0-82f1-42d38b16c6e4"), new DateTime(2023, 10, 30, 16, 27, 47, 866, DateTimeKind.Local).AddTicks(9970), 35 },
                    { new Guid("09f0e79c-5c1f-47fe-ad0c-28dcb6f2d1a0"), new DateTime(2023, 10, 30, 16, 27, 47, 866, DateTimeKind.Local).AddTicks(9809), 55 },
                    { new Guid("0a767fea-342d-459a-8c9e-73e3a0cc0a55"), new DateTime(2023, 10, 30, 16, 27, 47, 866, DateTimeKind.Local).AddTicks(9858), 81 },
                    { new Guid("0ad36428-2066-4009-8b96-7335f90b7fcf"), new DateTime(2023, 10, 30, 16, 27, 47, 866, DateTimeKind.Local).AddTicks(9831), 84 },
                    { new Guid("0e1484db-7c30-4df9-812d-eeade77c5a10"), new DateTime(2023, 10, 30, 16, 27, 47, 866, DateTimeKind.Local).AddTicks(9797), 42 },
                    { new Guid("0e40d0fc-76f4-41e3-9743-6a3f05fdf7d5"), new DateTime(2023, 10, 30, 16, 27, 47, 866, DateTimeKind.Local).AddTicks(9816), 30 },
                    { new Guid("0eb38324-cba6-4275-9a1e-e9e5c21ad4ef"), new DateTime(2023, 10, 30, 16, 27, 47, 866, DateTimeKind.Local).AddTicks(9769), 65 },
                    { new Guid("0fae6de9-1517-4fed-a848-3615d297a4b7"), new DateTime(2023, 10, 30, 16, 27, 47, 866, DateTimeKind.Local).AddTicks(9501), 50 },
                    { new Guid("10898f93-24f4-43ae-ba47-1970f9406503"), new DateTime(2023, 10, 30, 16, 27, 47, 866, DateTimeKind.Local).AddTicks(9844), 94 },
                    { new Guid("10f1a4c5-6ca7-4aea-80ce-efbd4659c3cd"), new DateTime(2023, 10, 30, 16, 27, 47, 866, DateTimeKind.Local).AddTicks(9776), 48 },
                    { new Guid("124e27e9-41a3-45d9-9f5a-48689f16062d"), new DateTime(2023, 10, 30, 16, 27, 47, 866, DateTimeKind.Local).AddTicks(9889), 31 },
                    { new Guid("13f7453b-fdf7-4b48-b38a-fdd1ecf37fd5"), new DateTime(2023, 10, 30, 16, 27, 47, 866, DateTimeKind.Local).AddTicks(9873), 84 },
                    { new Guid("160c1943-8ada-4d9b-9ef5-7039edf2c8e5"), new DateTime(2023, 10, 30, 16, 27, 47, 866, DateTimeKind.Local).AddTicks(9576), 27 },
                    { new Guid("16885203-0de3-4d02-b072-774fa2c5d376"), new DateTime(2023, 10, 30, 16, 27, 47, 866, DateTimeKind.Local).AddTicks(9832), 41 },
                    { new Guid("18b08464-6668-47ba-b218-d213be4eb956"), new DateTime(2023, 10, 30, 16, 27, 47, 866, DateTimeKind.Local).AddTicks(9819), 52 },
                    { new Guid("1950e5af-9772-4ee9-b982-86a0f438fcc5"), new DateTime(2023, 10, 30, 16, 27, 47, 866, DateTimeKind.Local).AddTicks(9894), 90 },
                    { new Guid("1a1604c5-b259-4cce-af78-f6a6c8e21587"), new DateTime(2023, 10, 30, 16, 27, 47, 866, DateTimeKind.Local).AddTicks(9846), 36 },
                    { new Guid("1b87ccf3-91d1-4b82-a6cb-e176fe43f3c4"), new DateTime(2023, 10, 30, 16, 27, 47, 866, DateTimeKind.Local).AddTicks(9867), 61 },
                    { new Guid("1f873004-65d2-43c5-8084-31078d22a587"), new DateTime(2023, 10, 30, 16, 27, 47, 866, DateTimeKind.Local).AddTicks(9964), 72 },
                    { new Guid("206b38f1-5d84-4fb7-88dd-d4d8b6721b4d"), new DateTime(2023, 10, 30, 16, 27, 47, 866, DateTimeKind.Local).AddTicks(9770), 72 },
                    { new Guid("2234e347-baf9-47d5-905f-983ab5de6774"), new DateTime(2023, 10, 30, 16, 27, 47, 866, DateTimeKind.Local).AddTicks(9785), 63 },
                    { new Guid("2249915c-4c8c-4e0b-98e1-b74cd43ed066"), new DateTime(2023, 10, 30, 16, 27, 47, 866, DateTimeKind.Local).AddTicks(9807), 51 },
                    { new Guid("224aca8c-26f7-4ebb-804a-23eb106d6eb9"), new DateTime(2023, 10, 30, 16, 27, 47, 866, DateTimeKind.Local).AddTicks(9657), 20 },
                    { new Guid("2414b0a2-5ef8-4765-b8ac-29c59f3cd660"), new DateTime(2023, 10, 30, 16, 27, 47, 866, DateTimeKind.Local).AddTicks(9614), 37 },
                    { new Guid("26238f59-a638-4908-94a5-fd9a71f7fa0e"), new DateTime(2023, 10, 30, 16, 27, 47, 866, DateTimeKind.Local).AddTicks(9572), 80 },
                    { new Guid("264f4c8c-8211-4182-8c8f-9cfcf1fad70e"), new DateTime(2023, 10, 30, 16, 27, 47, 866, DateTimeKind.Local).AddTicks(9777), 48 },
                    { new Guid("2720c86e-b3ce-442c-8c1c-c132d56a8e29"), new DateTime(2023, 10, 30, 16, 27, 47, 866, DateTimeKind.Local).AddTicks(9615), 27 },
                    { new Guid("2cc77b69-2a76-42ac-997a-d5532b8e3e23"), new DateTime(2023, 10, 30, 16, 27, 47, 866, DateTimeKind.Local).AddTicks(9980), 57 },
                    { new Guid("2cf8bb56-9763-433b-b59a-a48acee916da"), new DateTime(2023, 10, 30, 16, 27, 47, 866, DateTimeKind.Local).AddTicks(9839), 62 },
                    { new Guid("2face619-52e5-4917-9346-a7574d8d1b0d"), new DateTime(2023, 10, 30, 16, 27, 47, 866, DateTimeKind.Local).AddTicks(9649), 40 },
                    { new Guid("31f2d39d-afad-4ab0-9ebd-edc42ca058ca"), new DateTime(2023, 10, 30, 16, 27, 47, 866, DateTimeKind.Local).AddTicks(9788), 65 },
                    { new Guid("34818646-ea55-40db-86ee-711967971c0e"), new DateTime(2023, 10, 30, 16, 27, 47, 866, DateTimeKind.Local).AddTicks(9975), 51 },
                    { new Guid("38cecf99-f0fb-4ede-b8e3-6d7c5bbf0ca3"), new DateTime(2023, 10, 30, 16, 27, 47, 866, DateTimeKind.Local).AddTicks(9865), 71 },
                    { new Guid("393371f0-c2b8-4661-aa81-8bf423baaf0e"), new DateTime(2023, 10, 30, 16, 27, 47, 866, DateTimeKind.Local).AddTicks(9645), 79 },
                    { new Guid("39751ddf-7f1b-4163-b1af-654719e23db3"), new DateTime(2023, 10, 30, 16, 27, 47, 866, DateTimeKind.Local).AddTicks(9828), 28 },
                    { new Guid("3a55a5fe-aefa-47d6-8a07-87ef24e18b97"), new DateTime(2023, 10, 30, 16, 27, 47, 866, DateTimeKind.Local).AddTicks(9793), 69 },
                    { new Guid("3d060369-a0d2-4dfb-aa0f-901cb9a170fb"), new DateTime(2023, 10, 30, 16, 27, 47, 866, DateTimeKind.Local).AddTicks(9870), 77 },
                    { new Guid("3fee98ab-b0be-4471-a293-0e427dccae3d"), new DateTime(2023, 10, 30, 16, 27, 47, 866, DateTimeKind.Local).AddTicks(9724), 98 },
                    { new Guid("40adf2f9-4f22-4ea0-b04a-6cdf06026478"), new DateTime(2023, 10, 30, 16, 27, 47, 866, DateTimeKind.Local).AddTicks(9656), 23 },
                    { new Guid("412f250b-3cfa-4616-9521-58f356f8ea28"), new DateTime(2023, 10, 30, 16, 27, 47, 866, DateTimeKind.Local).AddTicks(9646), 92 },
                    { new Guid("41343f00-ac70-4b4d-aa9e-48511a335c6c"), new DateTime(2023, 10, 30, 16, 27, 47, 866, DateTimeKind.Local).AddTicks(9659), 35 },
                    { new Guid("42070737-8b76-40dc-9dfe-c3ad6d274d99"), new DateTime(2023, 10, 30, 16, 27, 47, 866, DateTimeKind.Local).AddTicks(9813), 76 },
                    { new Guid("429a9ccf-f92b-4544-81b5-ab738e6fdf9b"), new DateTime(2023, 10, 30, 16, 27, 47, 866, DateTimeKind.Local).AddTicks(9885), 28 },
                    { new Guid("443b8c99-9e51-40f7-aa17-f1ae235f0f2b"), new DateTime(2023, 10, 30, 16, 27, 47, 866, DateTimeKind.Local).AddTicks(9773), 88 },
                    { new Guid("47d9f4d9-c944-4304-a40b-b2cf22ae927d"), new DateTime(2023, 10, 30, 16, 27, 47, 866, DateTimeKind.Local).AddTicks(9665), 40 },
                    { new Guid("4efc575c-a34e-49b5-a24e-bdaff07a5c9a"), new DateTime(2023, 10, 30, 16, 27, 47, 866, DateTimeKind.Local).AddTicks(9580), 86 },
                    { new Guid("50814569-bee2-4183-b8a3-edba1ca9c0e0"), new DateTime(2023, 10, 30, 16, 27, 47, 866, DateTimeKind.Local).AddTicks(9897), 71 },
                    { new Guid("55992dbb-5629-4740-bb17-da7ca0185bf3"), new DateTime(2023, 10, 30, 16, 27, 47, 866, DateTimeKind.Local).AddTicks(9859), 58 },
                    { new Guid("5d155307-332f-4c2e-b031-439d2b701a90"), new DateTime(2023, 10, 30, 16, 27, 47, 866, DateTimeKind.Local).AddTicks(9862), 82 },
                    { new Guid("5d611432-4d9d-4f58-a1c7-53b01963613b"), new DateTime(2023, 10, 30, 16, 27, 47, 866, DateTimeKind.Local).AddTicks(9726), 37 },
                    { new Guid("5e0d2c43-72eb-440d-8dc5-a88ced649452"), new DateTime(2023, 10, 30, 16, 27, 47, 866, DateTimeKind.Local).AddTicks(9774), 28 },
                    { new Guid("5f222c9b-633e-46d2-8c3f-dfcdccf6381a"), new DateTime(2023, 10, 30, 16, 27, 47, 866, DateTimeKind.Local).AddTicks(9891), 55 },
                    { new Guid("5f33128a-d3c8-48ba-9a91-8049660f59ab"), new DateTime(2023, 10, 30, 16, 27, 47, 866, DateTimeKind.Local).AddTicks(9886), 46 },
                    { new Guid("65ad008f-0b82-4e02-9b71-8e9a45b27bd3"), new DateTime(2023, 10, 30, 16, 27, 47, 866, DateTimeKind.Local).AddTicks(9973), 42 },
                    { new Guid("674fee3b-aa91-49e0-ba51-31cc5fa77f2f"), new DateTime(2023, 10, 30, 16, 27, 47, 866, DateTimeKind.Local).AddTicks(9874), 58 },
                    { new Guid("679f2643-4e09-4f6f-94a3-ae89d68bfcf6"), new DateTime(2023, 10, 30, 16, 27, 47, 866, DateTimeKind.Local).AddTicks(9590), 57 },
                    { new Guid("69206ef2-a902-4b01-84e3-e717def02374"), new DateTime(2023, 10, 30, 16, 27, 47, 866, DateTimeKind.Local).AddTicks(9652), 22 },
                    { new Guid("692d3744-9247-4057-98d6-3479ee2eda7c"), new DateTime(2023, 10, 30, 16, 27, 47, 866, DateTimeKind.Local).AddTicks(9969), 20 },
                    { new Guid("69a99614-e9c6-46cb-a946-f32dbc2b8e36"), new DateTime(2023, 10, 30, 16, 27, 47, 866, DateTimeKind.Local).AddTicks(9765), 37 },
                    { new Guid("6c28a28b-1936-4d08-905b-55becc778e41"), new DateTime(2023, 10, 30, 16, 27, 47, 866, DateTimeKind.Local).AddTicks(9759), 59 },
                    { new Guid("6cda3f11-82c4-4aaa-a1ca-f155a2a74716"), new DateTime(2023, 10, 30, 16, 27, 47, 866, DateTimeKind.Local).AddTicks(9967), 31 },
                    { new Guid("6d210dc8-99dc-4e05-8ac3-5b624144b6c7"), new DateTime(2023, 10, 30, 16, 27, 47, 866, DateTimeKind.Local).AddTicks(9815), 85 },
                    { new Guid("6f14bd0f-0d20-4181-b659-0ddf49968719"), new DateTime(2023, 10, 30, 16, 27, 47, 866, DateTimeKind.Local).AddTicks(9764), 47 },
                    { new Guid("712a0ec2-265e-4dec-9a66-77eb239a3474"), new DateTime(2023, 10, 30, 16, 27, 47, 866, DateTimeKind.Local).AddTicks(9648), 55 },
                    { new Guid("72a72de0-bcd4-4b62-9863-fa1aa0a4db22"), new DateTime(2023, 10, 30, 16, 27, 47, 866, DateTimeKind.Local).AddTicks(9847), 67 },
                    { new Guid("72b3d711-9539-457f-9a2c-b5051a93abdd"), new DateTime(2023, 10, 30, 16, 27, 47, 866, DateTimeKind.Local).AddTicks(9578), 56 },
                    { new Guid("72c32647-acd2-4989-8235-ad07144e6836"), new DateTime(2023, 10, 30, 16, 27, 47, 866, DateTimeKind.Local).AddTicks(9817), 70 },
                    { new Guid("73a8d1e7-63a5-4e7f-a0a7-406e4dc34a92"), new DateTime(2023, 10, 30, 16, 27, 47, 866, DateTimeKind.Local).AddTicks(9589), 79 },
                    { new Guid("75335219-3be8-4264-9c9e-9ba20b939b3b"), new DateTime(2023, 10, 30, 16, 27, 47, 866, DateTimeKind.Local).AddTicks(9825), 53 },
                    { new Guid("77278382-8206-43d9-9258-1006d65b4a9d"), new DateTime(2023, 10, 30, 16, 27, 47, 866, DateTimeKind.Local).AddTicks(9782), 59 },
                    { new Guid("7808a5b8-b97a-4c7c-95e3-db40c8d6ce7b"), new DateTime(2023, 10, 30, 16, 27, 47, 866, DateTimeKind.Local).AddTicks(9861), 25 },
                    { new Guid("79119774-1161-4092-b25e-5095412666ba"), new DateTime(2023, 10, 30, 16, 27, 47, 866, DateTimeKind.Local).AddTicks(9840), 93 },
                    { new Guid("797488b1-4494-427b-9aed-849fb14062fc"), new DateTime(2023, 10, 30, 16, 27, 47, 866, DateTimeKind.Local).AddTicks(9966), 42 },
                    { new Guid("7a6953cb-d418-4b8e-9fd4-218ca0ddc278"), new DateTime(2023, 10, 30, 16, 27, 47, 866, DateTimeKind.Local).AddTicks(9835), 53 },
                    { new Guid("7ccd4cd5-3f12-4425-8427-c654cdb81466"), new DateTime(2023, 10, 30, 16, 27, 47, 866, DateTimeKind.Local).AddTicks(9871), 70 },
                    { new Guid("810c5e01-93f9-4b75-a100-3dcfbeee4e85"), new DateTime(2023, 10, 30, 16, 27, 47, 866, DateTimeKind.Local).AddTicks(9598), 45 },
                    { new Guid("820b1d88-68b8-4cba-8616-2fb13dd8b16c"), new DateTime(2023, 10, 30, 16, 27, 47, 866, DateTimeKind.Local).AddTicks(9892), 55 },
                    { new Guid("865a58fe-3ae0-4d51-8953-7bf514ead7a6"), new DateTime(2023, 10, 30, 16, 27, 47, 866, DateTimeKind.Local).AddTicks(9826), 91 },
                    { new Guid("889e6c38-2ac9-4ac8-8db4-c8910d72c31a"), new DateTime(2023, 10, 30, 16, 27, 47, 866, DateTimeKind.Local).AddTicks(9882), 23 },
                    { new Guid("89e97744-b8fd-461e-a365-a87c35ecacb0"), new DateTime(2023, 10, 30, 16, 27, 47, 866, DateTimeKind.Local).AddTicks(9794), 93 },
                    { new Guid("8ad5e1c0-0227-4887-9d24-f318a7bb9667"), new DateTime(2023, 10, 30, 16, 27, 47, 866, DateTimeKind.Local).AddTicks(9822), 58 },
                    { new Guid("8d295478-046e-4822-a648-a50b398a5f6e"), new DateTime(2023, 10, 30, 16, 27, 47, 866, DateTimeKind.Local).AddTicks(9829), 64 },
                    { new Guid("911d3acd-394e-4028-bac4-69b8ca5a434b"), new DateTime(2023, 10, 30, 16, 27, 47, 866, DateTimeKind.Local).AddTicks(9982), 81 },
                    { new Guid("9385e09a-c30e-4623-bb01-8ff93becc7da"), new DateTime(2023, 10, 30, 16, 27, 47, 866, DateTimeKind.Local).AddTicks(9791), 27 },
                    { new Guid("939529a7-6d89-4137-b96e-0046ecefc5ec"), new DateTime(2023, 10, 30, 16, 27, 47, 866, DateTimeKind.Local).AddTicks(9780), 49 },
                    { new Guid("93a7c0ef-9f57-4134-9962-07065eb4dfe3"), new DateTime(2023, 10, 30, 16, 27, 47, 866, DateTimeKind.Local).AddTicks(9806), 38 },
                    { new Guid("9ab9916a-623f-48c5-95ea-c34f8a87e019"), new DateTime(2023, 10, 30, 16, 27, 47, 866, DateTimeKind.Local).AddTicks(9883), 82 },
                    { new Guid("9f2e7a48-2e72-416f-bb1b-157d7cf15a31"), new DateTime(2023, 10, 30, 16, 27, 47, 866, DateTimeKind.Local).AddTicks(9767), 62 },
                    { new Guid("a3da18ac-5653-4bb1-abbc-3f4512c87bef"), new DateTime(2023, 10, 30, 16, 27, 47, 866, DateTimeKind.Local).AddTicks(9812), 85 },
                    { new Guid("a4496355-9292-46c8-ae7d-34b08d7dc19b"), new DateTime(2023, 10, 30, 16, 27, 47, 866, DateTimeKind.Local).AddTicks(9574), 33 },
                    { new Guid("a4a5783c-17d3-4582-9765-da7be91e4029"), new DateTime(2023, 10, 30, 16, 27, 47, 866, DateTimeKind.Local).AddTicks(9779), 50 },
                    { new Guid("a4d62af5-7309-4d3d-98c9-bcf0b9540ac9"), new DateTime(2023, 10, 30, 16, 27, 47, 866, DateTimeKind.Local).AddTicks(9850), 97 },
                    { new Guid("a5392785-28f5-4a2e-b3df-cad28e7093ef"), new DateTime(2023, 10, 30, 16, 27, 47, 866, DateTimeKind.Local).AddTicks(9895), 95 },
                    { new Guid("a6444f34-4825-4ec2-afb3-381c6b7af492"), new DateTime(2023, 10, 30, 16, 27, 47, 866, DateTimeKind.Local).AddTicks(9796), 27 },
                    { new Guid("a741e204-5dcb-4e47-9e8d-3451500e1a52"), new DateTime(2023, 10, 30, 16, 27, 47, 866, DateTimeKind.Local).AddTicks(9761), 21 },
                    { new Guid("ad0d641d-0655-4f37-9a81-610851c3a850"), new DateTime(2023, 10, 30, 16, 27, 47, 866, DateTimeKind.Local).AddTicks(9852), 31 },
                    { new Guid("af0379a4-7470-47f2-9456-7526490becf1"), new DateTime(2023, 10, 30, 16, 27, 47, 866, DateTimeKind.Local).AddTicks(9877), 23 },
                    { new Guid("b008bb87-19c6-436d-a5ff-667d72fab328"), new DateTime(2023, 10, 30, 16, 27, 47, 866, DateTimeKind.Local).AddTicks(9786), 36 },
                    { new Guid("b0266221-616e-40d3-9e9a-250e804cc8ba"), new DateTime(2023, 10, 30, 16, 27, 47, 866, DateTimeKind.Local).AddTicks(9837), 51 },
                    { new Guid("b0ffc7ff-026c-45c3-8f01-852fb77a6d54"), new DateTime(2023, 10, 30, 16, 27, 47, 866, DateTimeKind.Local).AddTicks(9651), 89 },
                    { new Guid("b26cf13f-7281-48e1-89f0-b42f261f76b3"), new DateTime(2023, 10, 30, 16, 27, 47, 866, DateTimeKind.Local).AddTicks(9654), 87 },
                    { new Guid("b289b1a4-2ff3-463e-b114-45d5724c111b"), new DateTime(2023, 10, 30, 16, 27, 47, 866, DateTimeKind.Local).AddTicks(9641), 94 },
                    { new Guid("b328435c-0004-4c7b-b68b-74df183331fd"), new DateTime(2023, 10, 30, 16, 27, 47, 866, DateTimeKind.Local).AddTicks(9800), 51 },
                    { new Guid("b4bab4b0-ae01-4c59-9607-4c5376032249"), new DateTime(2023, 10, 30, 16, 27, 47, 866, DateTimeKind.Local).AddTicks(9888), 72 },
                    { new Guid("b4d65baa-6a81-4ec6-86f9-5c398344637f"), new DateTime(2023, 10, 30, 16, 27, 47, 866, DateTimeKind.Local).AddTicks(9799), 98 },
                    { new Guid("b7672e9d-597b-4f4a-9b27-066fb94d4833"), new DateTime(2023, 10, 30, 16, 27, 47, 866, DateTimeKind.Local).AddTicks(9666), 77 },
                    { new Guid("ba64bac8-f697-46ea-bd42-abd89c7a17a0"), new DateTime(2023, 10, 30, 16, 27, 47, 866, DateTimeKind.Local).AddTicks(9600), 57 },
                    { new Guid("c08a9d05-fd6f-4921-b563-978df2a5e3f9"), new DateTime(2023, 10, 30, 16, 27, 47, 866, DateTimeKind.Local).AddTicks(9880), 21 },
                    { new Guid("c306f595-7f32-47a6-9683-16233bd6746c"), new DateTime(2023, 10, 30, 16, 27, 47, 866, DateTimeKind.Local).AddTicks(9804), 77 },
                    { new Guid("c5a768eb-8de5-4618-8db8-c10e3854fa80"), new DateTime(2023, 10, 30, 16, 27, 47, 866, DateTimeKind.Local).AddTicks(9976), 79 },
                    { new Guid("c6e6988b-7bbb-42a7-bf65-4d8f6425e1b3"), new DateTime(2023, 10, 30, 16, 27, 47, 866, DateTimeKind.Local).AddTicks(9820), 38 },
                    { new Guid("cfb75b41-2f0b-4486-a252-b47711c9a1e5"), new DateTime(2023, 10, 30, 16, 27, 47, 866, DateTimeKind.Local).AddTicks(9810), 66 },
                    { new Guid("d43abd0f-f35b-45fc-848b-715d98265b0c"), new DateTime(2023, 10, 30, 16, 27, 47, 866, DateTimeKind.Local).AddTicks(9879), 20 },
                    { new Guid("d718c465-375e-4d49-9eac-a1d9f8f55736"), new DateTime(2023, 10, 30, 16, 27, 47, 866, DateTimeKind.Local).AddTicks(9610), 30 },
                    { new Guid("d740058d-bc9f-48be-9dd4-9d3e51fd636c"), new DateTime(2023, 10, 30, 16, 27, 47, 866, DateTimeKind.Local).AddTicks(9856), 92 },
                    { new Guid("da82cf02-4793-487f-b9b4-5f15e3da46b8"), new DateTime(2023, 10, 30, 16, 27, 47, 866, DateTimeKind.Local).AddTicks(9728), 80 },
                    { new Guid("dce64e28-baa7-42a3-8cb1-87b89185629f"), new DateTime(2023, 10, 30, 16, 27, 47, 866, DateTimeKind.Local).AddTicks(9771), 46 },
                    { new Guid("de9644c9-4492-49bb-b1d0-22f99bdb8c6c"), new DateTime(2023, 10, 30, 16, 27, 47, 866, DateTimeKind.Local).AddTicks(9790), 64 },
                    { new Guid("e00ccfd2-3513-4f71-94ae-60539c9f022f"), new DateTime(2023, 10, 30, 16, 27, 47, 866, DateTimeKind.Local).AddTicks(9762), 65 },
                    { new Guid("e1617779-54dd-41d3-bf40-43042f97ede1"), new DateTime(2023, 10, 30, 16, 27, 47, 866, DateTimeKind.Local).AddTicks(9687), 96 },
                    { new Guid("e3566da9-66b8-42c9-8043-1b229e130f84"), new DateTime(2023, 10, 30, 16, 27, 47, 866, DateTimeKind.Local).AddTicks(9868), 85 },
                    { new Guid("e46756e9-0d78-4e75-87b1-48da03f43ba6"), new DateTime(2023, 10, 30, 16, 27, 47, 866, DateTimeKind.Local).AddTicks(9823), 96 },
                    { new Guid("e4cde3fe-a4f2-427c-bf4c-57927ae0e629"), new DateTime(2023, 10, 30, 16, 27, 47, 866, DateTimeKind.Local).AddTicks(9983), 21 },
                    { new Guid("e7439069-4eff-4bd0-91ba-e0fb2d88fc77"), new DateTime(2023, 10, 30, 16, 27, 47, 866, DateTimeKind.Local).AddTicks(9843), 50 },
                    { new Guid("e831641c-b3e5-4dce-a4df-54d3abf5b414"), new DateTime(2023, 10, 30, 16, 27, 47, 866, DateTimeKind.Local).AddTicks(9961), 64 },
                    { new Guid("e8eb440e-640c-4b09-8d43-fb0553704242"), new DateTime(2023, 10, 30, 16, 27, 47, 866, DateTimeKind.Local).AddTicks(9842), 93 },
                    { new Guid("ebde4e15-1890-4cd7-8e43-dc7285d538e0"), new DateTime(2023, 10, 30, 16, 27, 47, 866, DateTimeKind.Local).AddTicks(9849), 74 },
                    { new Guid("ef6cfb3c-4ff2-4656-929e-d94a807c47d3"), new DateTime(2023, 10, 30, 16, 27, 47, 866, DateTimeKind.Local).AddTicks(9754), 54 },
                    { new Guid("f016b991-5566-44d8-94ec-bff357c41035"), new DateTime(2023, 10, 30, 16, 27, 47, 866, DateTimeKind.Local).AddTicks(9855), 34 },
                    { new Guid("f0a7ccb7-c4c9-4704-836d-cd4a179a1952"), new DateTime(2023, 10, 30, 16, 27, 47, 866, DateTimeKind.Local).AddTicks(9876), 87 },
                    { new Guid("f4191da6-4c7b-4982-a876-a63d198f5b2d"), new DateTime(2023, 10, 30, 16, 27, 47, 866, DateTimeKind.Local).AddTicks(9898), 33 },
                    { new Guid("f49a213d-e4eb-40c0-b665-d3ef47571f75"), new DateTime(2023, 10, 30, 16, 27, 47, 866, DateTimeKind.Local).AddTicks(9617), 51 },
                    { new Guid("f5cc27e8-fd3e-4791-8818-1fc163f49be8"), new DateTime(2023, 10, 30, 16, 27, 47, 866, DateTimeKind.Local).AddTicks(9977), 38 },
                    { new Guid("fa4a115c-3cfd-46c7-995b-a77a7209c0db"), new DateTime(2023, 10, 30, 16, 27, 47, 866, DateTimeKind.Local).AddTicks(9758), 92 },
                    { new Guid("fa5af86c-f51d-4439-b564-0d98ae18b1fa"), new DateTime(2023, 10, 30, 16, 27, 47, 866, DateTimeKind.Local).AddTicks(9756), 86 },
                    { new Guid("faf57570-37e7-45fd-a70c-4232931deb1e"), new DateTime(2023, 10, 30, 16, 27, 47, 866, DateTimeKind.Local).AddTicks(9612), 50 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "ColorId", "ProductDescription", "ProductName", "ProductPrice", "Quantity", "Rating", "SizeId", "SubCategoryId" },
                values: new object[,]
                {
                    { new Guid("020fefb6-905f-4cfc-affb-87438f76e3f2"), 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Cozy Shoes", 974.0, 5, 0, 2, 10 },
                    { new Guid("0322cc1b-ef8c-41c6-a471-c6dd9f8a5df3"), 6, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Warm Pants", 944.0, 41, 1, 3, 4 },
                    { new Guid("04080c21-8f98-4bfb-8038-cd257c9554fb"), 6, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Comfortable Shoes", 867.0, 23, 0, 4, 10 },
                    { new Guid("0681df8f-4764-441e-8d96-0381d104dc70"), 5, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Great Shoes", 524.0, 80, 1, 3, 10 },
                    { new Guid("06e9db33-a016-4fc0-91cf-0adb29728ecd"), 5, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Elegant Pants", 548.0, 92, 4, 4, 4 },
                    { new Guid("0773be28-22d5-41e0-82f1-42d38b16c6e4"), 5, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Trendy Pants", 205.0, 8, 3, 3, 4 },
                    { new Guid("0a767fea-342d-459a-8c9e-73e3a0cc0a55"), 5, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Chic Shoes", 828.0, 83, 3, 6, 10 },
                    { new Guid("0ad36428-2066-4009-8b96-7335f90b7fcf"), 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Modern Shoes", 352.0, 83, 2, 6, 10 },
                    { new Guid("0e40d0fc-76f4-41e3-9743-6a3f05fdf7d5"), 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Luxurious Shoes", 162.0, 56, 0, 2, 10 },
                    { new Guid("10898f93-24f4-43ae-ba47-1970f9406503"), 4, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Classy Shoes", 546.0, 83, 2, 3, 10 },
                    { new Guid("124e27e9-41a3-45d9-9f5a-48689f16062d"), 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Trendy Pants", 163.0, 72, 1, 3, 4 },
                    { new Guid("13f7453b-fdf7-4b48-b38a-fdd1ecf37fd5"), 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Stylish Pants", 648.0, 49, 3, 4, 4 },
                    { new Guid("16885203-0de3-4d02-b072-774fa2c5d376"), 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Modern Shoes", 657.0, 11, 0, 1, 10 },
                    { new Guid("18b08464-6668-47ba-b218-d213be4eb956"), 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Modern Shoes", 780.0, 32, 1, 4, 10 },
                    { new Guid("1950e5af-9772-4ee9-b982-86a0f438fcc5"), 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Modern Pants", 256.0, 97, 4, 6, 4 },
                    { new Guid("1a1604c5-b259-4cce-af78-f6a6c8e21587"), 4, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Comfortable Shoes", 451.0, 78, 1, 4, 10 },
                    { new Guid("1b87ccf3-91d1-4b82-a6cb-e176fe43f3c4"), 6, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Fashionable Shoes", 107.0, 75, 1, 6, 10 },
                    { new Guid("1f873004-65d2-43c5-8084-31078d22a587"), 4, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Great Pants", 925.0, 84, 0, 5, 4 },
                    { new Guid("2cc77b69-2a76-42ac-997a-d5532b8e3e23"), 6, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Sophisticated Pants", 70.0, 42, 0, 4, 4 },
                    { new Guid("2cf8bb56-9763-433b-b59a-a48acee916da"), 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Fancy Shoes", 716.0, 57, 1, 5, 10 },
                    { new Guid("34818646-ea55-40db-86ee-711967971c0e"), 5, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Classy Pants", 194.0, 52, 1, 6, 4 },
                    { new Guid("38cecf99-f0fb-4ede-b8e3-6d7c5bbf0ca3"), 6, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Great Shoes", 93.0, 90, 0, 5, 10 },
                    { new Guid("39751ddf-7f1b-4163-b1af-654719e23db3"), 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Elegant Shoes", 606.0, 44, 4, 4, 10 },
                    { new Guid("3d060369-a0d2-4dfb-aa0f-901cb9a170fb"), 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Trendy Pants", 80.0, 58, 2, 2, 4 },
                    { new Guid("429a9ccf-f92b-4544-81b5-ab738e6fdf9b"), 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Chic Pants", 294.0, 29, 0, 6, 4 },
                    { new Guid("50814569-bee2-4183-b8a3-edba1ca9c0e0"), 4, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Stylish Pants", 631.0, 33, 0, 2, 4 },
                    { new Guid("55992dbb-5629-4740-bb17-da7ca0185bf3"), 6, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Elegant Shoes", 636.0, 27, 4, 1, 10 },
                    { new Guid("5d155307-332f-4c2e-b031-439d2b701a90"), 6, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Elegant Shoes", 388.0, 7, 2, 3, 10 },
                    { new Guid("5f222c9b-633e-46d2-8c3f-dfcdccf6381a"), 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Fashionable Pants", 677.0, 75, 1, 4, 4 },
                    { new Guid("5f33128a-d3c8-48ba-9a91-8049660f59ab"), 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Cozy Pants", 533.0, 17, 1, 1, 4 },
                    { new Guid("65ad008f-0b82-4e02-9b71-8e9a45b27bd3"), 5, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Luxurious Pants", 402.0, 33, 3, 5, 4 },
                    { new Guid("674fee3b-aa91-49e0-ba51-31cc5fa77f2f"), 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Great Pants", 862.0, 59, 0, 5, 4 },
                    { new Guid("692d3744-9247-4057-98d6-3479ee2eda7c"), 5, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Modern Pants", 809.0, 7, 2, 2, 4 },
                    { new Guid("6cda3f11-82c4-4aaa-a1ca-f155a2a74716"), 5, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Great Pants", 799.0, 6, 1, 1, 4 },
                    { new Guid("6d210dc8-99dc-4e05-8ac3-5b624144b6c7"), 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Classy Shoes", 541.0, 26, 4, 1, 10 },
                    { new Guid("72a72de0-bcd4-4b62-9863-fa1aa0a4db22"), 4, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Stylish Shoes", 858.0, 72, 2, 5, 10 },
                    { new Guid("72c32647-acd2-4989-8235-ad07144e6836"), 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Trendy Shoes", 956.0, 5, 2, 3, 10 },
                    { new Guid("75335219-3be8-4264-9c9e-9ba20b939b3b"), 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Great Shoes", 205.0, 45, 4, 2, 10 },
                    { new Guid("7808a5b8-b97a-4c7c-95e3-db40c8d6ce7b"), 6, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Stylish Shoes", 63.0, 61, 3, 2, 10 },
                    { new Guid("79119774-1161-4092-b25e-5095412666ba"), 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite Shoes", 282.0, 4, 3, 6, 10 },
                    { new Guid("797488b1-4494-427b-9aed-849fb14062fc"), 4, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Chic Pants", 881.0, 56, 3, 6, 4 },
                    { new Guid("7a6953cb-d418-4b8e-9fd4-218ca0ddc278"), 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Great Shoes", 754.0, 99, 4, 3, 10 },
                    { new Guid("7ccd4cd5-3f12-4425-8427-c654cdb81466"), 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Elegant Pants", 914.0, 71, 2, 3, 4 },
                    { new Guid("820b1d88-68b8-4cba-8616-2fb13dd8b16c"), 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Elegant Pants", 939.0, 15, 4, 5, 4 },
                    { new Guid("865a58fe-3ae0-4d51-8953-7bf514ead7a6"), 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Comfortable Shoes", 85.0, 68, 0, 3, 10 },
                    { new Guid("889e6c38-2ac9-4ac8-8db4-c8910d72c31a"), 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Great Pants", 897.0, 46, 1, 4, 4 },
                    { new Guid("8ad5e1c0-0227-4887-9d24-f318a7bb9667"), 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Warm Shoes", 921.0, 66, 0, 6, 10 },
                    { new Guid("8d295478-046e-4822-a648-a50b398a5f6e"), 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite Shoes", 95.0, 65, 3, 5, 10 },
                    { new Guid("911d3acd-394e-4028-bac4-69b8ca5a434b"), 6, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Comfortable Pants", 150.0, 27, 2, 5, 4 },
                    { new Guid("9ab9916a-623f-48c5-95ea-c34f8a87e019"), 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Stylish Pants", 166.0, 56, 0, 5, 4 },
                    { new Guid("a4d62af5-7309-4d3d-98c9-bcf0b9540ac9"), 5, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Luxurious Shoes", 308.0, 38, 3, 1, 10 },
                    { new Guid("a5392785-28f5-4a2e-b3df-cad28e7093ef"), 4, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Fancy Pants", 595.0, 82, 1, 1, 4 },
                    { new Guid("ad0d641d-0655-4f37-9a81-610851c3a850"), 5, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Modern Shoes", 918.0, 15, 1, 2, 10 },
                    { new Guid("af0379a4-7470-47f2-9456-7526490becf1"), 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Fashionable Pants", 574.0, 10, 1, 1, 4 },
                    { new Guid("b0266221-616e-40d3-9e9a-250e804cc8ba"), 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Elegant Shoes", 836.0, 67, 0, 4, 10 },
                    { new Guid("b4bab4b0-ae01-4c59-9607-4c5376032249"), 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite Pants", 198.0, 96, 0, 2, 4 },
                    { new Guid("c08a9d05-fd6f-4921-b563-978df2a5e3f9"), 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Sophisticated Pants", 143.0, 86, 2, 3, 4 },
                    { new Guid("c5a768eb-8de5-4618-8db8-c10e3854fa80"), 6, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Classy Pants", 220.0, 35, 3, 1, 4 },
                    { new Guid("c6e6988b-7bbb-42a7-bf65-4d8f6425e1b3"), 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite Shoes", 81.0, 35, 3, 5, 10 },
                    { new Guid("d43abd0f-f35b-45fc-848b-715d98265b0c"), 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Classy Pants", 338.0, 65, 3, 2, 4 },
                    { new Guid("d740058d-bc9f-48be-9dd4-9d3e51fd636c"), 5, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Great Shoes", 794.0, 24, 0, 5, 10 },
                    { new Guid("e3566da9-66b8-42c9-8043-1b229e130f84"), 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Trendy Pants", 617.0, 19, 3, 1, 4 },
                    { new Guid("e46756e9-0d78-4e75-87b1-48da03f43ba6"), 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Fancy Shoes", 90.0, 43, 1, 1, 10 },
                    { new Guid("e4cde3fe-a4f2-427c-bf4c-57927ae0e629"), 6, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Fancy Pants", 235.0, 45, 4, 6, 4 },
                    { new Guid("e7439069-4eff-4bd0-91ba-e0fb2d88fc77"), 4, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Classy Shoes", 391.0, 80, 2, 2, 10 },
                    { new Guid("e831641c-b3e5-4dce-a4df-54d3abf5b414"), 4, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Stylish Pants", 527.0, 18, 1, 4, 4 },
                    { new Guid("e8eb440e-640c-4b09-8d43-fb0553704242"), 4, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Chic Shoes", 325.0, 50, 0, 1, 10 },
                    { new Guid("ebde4e15-1890-4cd7-8e43-dc7285d538e0"), 4, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Modern Shoes", 659.0, 58, 0, 6, 10 },
                    { new Guid("f016b991-5566-44d8-94ec-bff357c41035"), 5, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Elegant Shoes", 219.0, 27, 3, 4, 10 },
                    { new Guid("f0a7ccb7-c4c9-4704-836d-cd4a179a1952"), 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Cozy Pants", 862.0, 10, 1, 6, 4 },
                    { new Guid("f4191da6-4c7b-4982-a876-a63d198f5b2d"), 4, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Trendy Pants", 774.0, 29, 1, 3, 4 },
                    { new Guid("f5cc27e8-fd3e-4791-8818-1fc163f49be8"), 6, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Classy Pants", 342.0, 21, 3, 2, 4 }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ProductInventories_ProductId",
                table: "Products",
                column: "ProductId",
                principalTable: "ProductInventories",
                principalColumn: "ProductInventoryId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductInventories_ProductId",
                table: "Products");

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: new Guid("00e9ac68-5a60-4efd-a087-480cbd1d4560"));

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: new Guid("03ee2b9e-206b-4284-83ba-83a4a9e112c6"));

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: new Guid("059684d0-b5d1-4ab0-8e20-2b64b73a22ac"));

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: new Guid("09f0e79c-5c1f-47fe-ad0c-28dcb6f2d1a0"));

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: new Guid("0e1484db-7c30-4df9-812d-eeade77c5a10"));

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: new Guid("0eb38324-cba6-4275-9a1e-e9e5c21ad4ef"));

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: new Guid("0fae6de9-1517-4fed-a848-3615d297a4b7"));

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: new Guid("10f1a4c5-6ca7-4aea-80ce-efbd4659c3cd"));

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: new Guid("160c1943-8ada-4d9b-9ef5-7039edf2c8e5"));

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: new Guid("206b38f1-5d84-4fb7-88dd-d4d8b6721b4d"));

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: new Guid("2234e347-baf9-47d5-905f-983ab5de6774"));

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: new Guid("2249915c-4c8c-4e0b-98e1-b74cd43ed066"));

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: new Guid("224aca8c-26f7-4ebb-804a-23eb106d6eb9"));

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: new Guid("2414b0a2-5ef8-4765-b8ac-29c59f3cd660"));

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: new Guid("26238f59-a638-4908-94a5-fd9a71f7fa0e"));

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: new Guid("264f4c8c-8211-4182-8c8f-9cfcf1fad70e"));

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: new Guid("2720c86e-b3ce-442c-8c1c-c132d56a8e29"));

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: new Guid("2face619-52e5-4917-9346-a7574d8d1b0d"));

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: new Guid("31f2d39d-afad-4ab0-9ebd-edc42ca058ca"));

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: new Guid("393371f0-c2b8-4661-aa81-8bf423baaf0e"));

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: new Guid("3a55a5fe-aefa-47d6-8a07-87ef24e18b97"));

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: new Guid("3fee98ab-b0be-4471-a293-0e427dccae3d"));

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: new Guid("40adf2f9-4f22-4ea0-b04a-6cdf06026478"));

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: new Guid("412f250b-3cfa-4616-9521-58f356f8ea28"));

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: new Guid("41343f00-ac70-4b4d-aa9e-48511a335c6c"));

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: new Guid("42070737-8b76-40dc-9dfe-c3ad6d274d99"));

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: new Guid("443b8c99-9e51-40f7-aa17-f1ae235f0f2b"));

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: new Guid("47d9f4d9-c944-4304-a40b-b2cf22ae927d"));

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: new Guid("4efc575c-a34e-49b5-a24e-bdaff07a5c9a"));

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: new Guid("5d611432-4d9d-4f58-a1c7-53b01963613b"));

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: new Guid("5e0d2c43-72eb-440d-8dc5-a88ced649452"));

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: new Guid("679f2643-4e09-4f6f-94a3-ae89d68bfcf6"));

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: new Guid("69206ef2-a902-4b01-84e3-e717def02374"));

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: new Guid("69a99614-e9c6-46cb-a946-f32dbc2b8e36"));

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: new Guid("6c28a28b-1936-4d08-905b-55becc778e41"));

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: new Guid("6f14bd0f-0d20-4181-b659-0ddf49968719"));

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: new Guid("712a0ec2-265e-4dec-9a66-77eb239a3474"));

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: new Guid("72b3d711-9539-457f-9a2c-b5051a93abdd"));

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: new Guid("73a8d1e7-63a5-4e7f-a0a7-406e4dc34a92"));

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: new Guid("77278382-8206-43d9-9258-1006d65b4a9d"));

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: new Guid("810c5e01-93f9-4b75-a100-3dcfbeee4e85"));

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: new Guid("89e97744-b8fd-461e-a365-a87c35ecacb0"));

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: new Guid("9385e09a-c30e-4623-bb01-8ff93becc7da"));

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: new Guid("939529a7-6d89-4137-b96e-0046ecefc5ec"));

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: new Guid("93a7c0ef-9f57-4134-9962-07065eb4dfe3"));

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: new Guid("9f2e7a48-2e72-416f-bb1b-157d7cf15a31"));

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: new Guid("a3da18ac-5653-4bb1-abbc-3f4512c87bef"));

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: new Guid("a4496355-9292-46c8-ae7d-34b08d7dc19b"));

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: new Guid("a4a5783c-17d3-4582-9765-da7be91e4029"));

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: new Guid("a6444f34-4825-4ec2-afb3-381c6b7af492"));

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: new Guid("a741e204-5dcb-4e47-9e8d-3451500e1a52"));

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: new Guid("b008bb87-19c6-436d-a5ff-667d72fab328"));

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: new Guid("b0ffc7ff-026c-45c3-8f01-852fb77a6d54"));

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: new Guid("b26cf13f-7281-48e1-89f0-b42f261f76b3"));

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: new Guid("b289b1a4-2ff3-463e-b114-45d5724c111b"));

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: new Guid("b328435c-0004-4c7b-b68b-74df183331fd"));

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: new Guid("b4d65baa-6a81-4ec6-86f9-5c398344637f"));

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: new Guid("b7672e9d-597b-4f4a-9b27-066fb94d4833"));

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: new Guid("ba64bac8-f697-46ea-bd42-abd89c7a17a0"));

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: new Guid("c306f595-7f32-47a6-9683-16233bd6746c"));

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: new Guid("cfb75b41-2f0b-4486-a252-b47711c9a1e5"));

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: new Guid("d718c465-375e-4d49-9eac-a1d9f8f55736"));

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: new Guid("da82cf02-4793-487f-b9b4-5f15e3da46b8"));

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: new Guid("dce64e28-baa7-42a3-8cb1-87b89185629f"));

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: new Guid("de9644c9-4492-49bb-b1d0-22f99bdb8c6c"));

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: new Guid("e00ccfd2-3513-4f71-94ae-60539c9f022f"));

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: new Guid("e1617779-54dd-41d3-bf40-43042f97ede1"));

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: new Guid("ef6cfb3c-4ff2-4656-929e-d94a807c47d3"));

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: new Guid("f49a213d-e4eb-40c0-b665-d3ef47571f75"));

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: new Guid("fa4a115c-3cfd-46c7-995b-a77a7209c0db"));

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: new Guid("fa5af86c-f51d-4439-b564-0d98ae18b1fa"));

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: new Guid("faf57570-37e7-45fd-a70c-4232931deb1e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("020fefb6-905f-4cfc-affb-87438f76e3f2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("0322cc1b-ef8c-41c6-a471-c6dd9f8a5df3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("04080c21-8f98-4bfb-8038-cd257c9554fb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("0681df8f-4764-441e-8d96-0381d104dc70"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("06e9db33-a016-4fc0-91cf-0adb29728ecd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("0773be28-22d5-41e0-82f1-42d38b16c6e4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("0a767fea-342d-459a-8c9e-73e3a0cc0a55"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("0ad36428-2066-4009-8b96-7335f90b7fcf"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("0e40d0fc-76f4-41e3-9743-6a3f05fdf7d5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("10898f93-24f4-43ae-ba47-1970f9406503"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("124e27e9-41a3-45d9-9f5a-48689f16062d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("13f7453b-fdf7-4b48-b38a-fdd1ecf37fd5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("16885203-0de3-4d02-b072-774fa2c5d376"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("18b08464-6668-47ba-b218-d213be4eb956"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("1950e5af-9772-4ee9-b982-86a0f438fcc5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("1a1604c5-b259-4cce-af78-f6a6c8e21587"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("1b87ccf3-91d1-4b82-a6cb-e176fe43f3c4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("1f873004-65d2-43c5-8084-31078d22a587"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("2cc77b69-2a76-42ac-997a-d5532b8e3e23"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("2cf8bb56-9763-433b-b59a-a48acee916da"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("34818646-ea55-40db-86ee-711967971c0e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("38cecf99-f0fb-4ede-b8e3-6d7c5bbf0ca3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("39751ddf-7f1b-4163-b1af-654719e23db3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("3d060369-a0d2-4dfb-aa0f-901cb9a170fb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("429a9ccf-f92b-4544-81b5-ab738e6fdf9b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("50814569-bee2-4183-b8a3-edba1ca9c0e0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("55992dbb-5629-4740-bb17-da7ca0185bf3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("5d155307-332f-4c2e-b031-439d2b701a90"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("5f222c9b-633e-46d2-8c3f-dfcdccf6381a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("5f33128a-d3c8-48ba-9a91-8049660f59ab"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("65ad008f-0b82-4e02-9b71-8e9a45b27bd3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("674fee3b-aa91-49e0-ba51-31cc5fa77f2f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("692d3744-9247-4057-98d6-3479ee2eda7c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("6cda3f11-82c4-4aaa-a1ca-f155a2a74716"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("6d210dc8-99dc-4e05-8ac3-5b624144b6c7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("72a72de0-bcd4-4b62-9863-fa1aa0a4db22"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("72c32647-acd2-4989-8235-ad07144e6836"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("75335219-3be8-4264-9c9e-9ba20b939b3b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("7808a5b8-b97a-4c7c-95e3-db40c8d6ce7b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("79119774-1161-4092-b25e-5095412666ba"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("797488b1-4494-427b-9aed-849fb14062fc"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("7a6953cb-d418-4b8e-9fd4-218ca0ddc278"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("7ccd4cd5-3f12-4425-8427-c654cdb81466"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("820b1d88-68b8-4cba-8616-2fb13dd8b16c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("865a58fe-3ae0-4d51-8953-7bf514ead7a6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("889e6c38-2ac9-4ac8-8db4-c8910d72c31a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("8ad5e1c0-0227-4887-9d24-f318a7bb9667"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("8d295478-046e-4822-a648-a50b398a5f6e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("911d3acd-394e-4028-bac4-69b8ca5a434b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("9ab9916a-623f-48c5-95ea-c34f8a87e019"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("a4d62af5-7309-4d3d-98c9-bcf0b9540ac9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("a5392785-28f5-4a2e-b3df-cad28e7093ef"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("ad0d641d-0655-4f37-9a81-610851c3a850"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("af0379a4-7470-47f2-9456-7526490becf1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("b0266221-616e-40d3-9e9a-250e804cc8ba"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("b4bab4b0-ae01-4c59-9607-4c5376032249"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("c08a9d05-fd6f-4921-b563-978df2a5e3f9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("c5a768eb-8de5-4618-8db8-c10e3854fa80"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("c6e6988b-7bbb-42a7-bf65-4d8f6425e1b3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("d43abd0f-f35b-45fc-848b-715d98265b0c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("d740058d-bc9f-48be-9dd4-9d3e51fd636c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("e3566da9-66b8-42c9-8043-1b229e130f84"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("e46756e9-0d78-4e75-87b1-48da03f43ba6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("e4cde3fe-a4f2-427c-bf4c-57927ae0e629"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("e7439069-4eff-4bd0-91ba-e0fb2d88fc77"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("e831641c-b3e5-4dce-a4df-54d3abf5b414"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("e8eb440e-640c-4b09-8d43-fb0553704242"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("ebde4e15-1890-4cd7-8e43-dc7285d538e0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("f016b991-5566-44d8-94ec-bff357c41035"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("f0a7ccb7-c4c9-4704-836d-cd4a179a1952"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("f4191da6-4c7b-4982-a876-a63d198f5b2d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("f5cc27e8-fd3e-4791-8818-1fc163f49be8"));

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: new Guid("020fefb6-905f-4cfc-affb-87438f76e3f2"));

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: new Guid("0322cc1b-ef8c-41c6-a471-c6dd9f8a5df3"));

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: new Guid("04080c21-8f98-4bfb-8038-cd257c9554fb"));

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: new Guid("0681df8f-4764-441e-8d96-0381d104dc70"));

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: new Guid("06e9db33-a016-4fc0-91cf-0adb29728ecd"));

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: new Guid("0773be28-22d5-41e0-82f1-42d38b16c6e4"));

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: new Guid("0a767fea-342d-459a-8c9e-73e3a0cc0a55"));

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: new Guid("0ad36428-2066-4009-8b96-7335f90b7fcf"));

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: new Guid("0e40d0fc-76f4-41e3-9743-6a3f05fdf7d5"));

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: new Guid("10898f93-24f4-43ae-ba47-1970f9406503"));

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: new Guid("124e27e9-41a3-45d9-9f5a-48689f16062d"));

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: new Guid("13f7453b-fdf7-4b48-b38a-fdd1ecf37fd5"));

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: new Guid("16885203-0de3-4d02-b072-774fa2c5d376"));

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: new Guid("18b08464-6668-47ba-b218-d213be4eb956"));

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: new Guid("1950e5af-9772-4ee9-b982-86a0f438fcc5"));

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: new Guid("1a1604c5-b259-4cce-af78-f6a6c8e21587"));

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: new Guid("1b87ccf3-91d1-4b82-a6cb-e176fe43f3c4"));

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: new Guid("1f873004-65d2-43c5-8084-31078d22a587"));

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: new Guid("2cc77b69-2a76-42ac-997a-d5532b8e3e23"));

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: new Guid("2cf8bb56-9763-433b-b59a-a48acee916da"));

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: new Guid("34818646-ea55-40db-86ee-711967971c0e"));

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: new Guid("38cecf99-f0fb-4ede-b8e3-6d7c5bbf0ca3"));

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: new Guid("39751ddf-7f1b-4163-b1af-654719e23db3"));

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: new Guid("3d060369-a0d2-4dfb-aa0f-901cb9a170fb"));

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: new Guid("429a9ccf-f92b-4544-81b5-ab738e6fdf9b"));

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: new Guid("50814569-bee2-4183-b8a3-edba1ca9c0e0"));

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: new Guid("55992dbb-5629-4740-bb17-da7ca0185bf3"));

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: new Guid("5d155307-332f-4c2e-b031-439d2b701a90"));

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: new Guid("5f222c9b-633e-46d2-8c3f-dfcdccf6381a"));

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: new Guid("5f33128a-d3c8-48ba-9a91-8049660f59ab"));

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: new Guid("65ad008f-0b82-4e02-9b71-8e9a45b27bd3"));

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: new Guid("674fee3b-aa91-49e0-ba51-31cc5fa77f2f"));

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: new Guid("692d3744-9247-4057-98d6-3479ee2eda7c"));

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: new Guid("6cda3f11-82c4-4aaa-a1ca-f155a2a74716"));

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: new Guid("6d210dc8-99dc-4e05-8ac3-5b624144b6c7"));

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: new Guid("72a72de0-bcd4-4b62-9863-fa1aa0a4db22"));

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: new Guid("72c32647-acd2-4989-8235-ad07144e6836"));

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: new Guid("75335219-3be8-4264-9c9e-9ba20b939b3b"));

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: new Guid("7808a5b8-b97a-4c7c-95e3-db40c8d6ce7b"));

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: new Guid("79119774-1161-4092-b25e-5095412666ba"));

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: new Guid("797488b1-4494-427b-9aed-849fb14062fc"));

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: new Guid("7a6953cb-d418-4b8e-9fd4-218ca0ddc278"));

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: new Guid("7ccd4cd5-3f12-4425-8427-c654cdb81466"));

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: new Guid("820b1d88-68b8-4cba-8616-2fb13dd8b16c"));

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: new Guid("865a58fe-3ae0-4d51-8953-7bf514ead7a6"));

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: new Guid("889e6c38-2ac9-4ac8-8db4-c8910d72c31a"));

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: new Guid("8ad5e1c0-0227-4887-9d24-f318a7bb9667"));

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: new Guid("8d295478-046e-4822-a648-a50b398a5f6e"));

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: new Guid("911d3acd-394e-4028-bac4-69b8ca5a434b"));

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: new Guid("9ab9916a-623f-48c5-95ea-c34f8a87e019"));

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: new Guid("a4d62af5-7309-4d3d-98c9-bcf0b9540ac9"));

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: new Guid("a5392785-28f5-4a2e-b3df-cad28e7093ef"));

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: new Guid("ad0d641d-0655-4f37-9a81-610851c3a850"));

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: new Guid("af0379a4-7470-47f2-9456-7526490becf1"));

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: new Guid("b0266221-616e-40d3-9e9a-250e804cc8ba"));

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: new Guid("b4bab4b0-ae01-4c59-9607-4c5376032249"));

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: new Guid("c08a9d05-fd6f-4921-b563-978df2a5e3f9"));

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: new Guid("c5a768eb-8de5-4618-8db8-c10e3854fa80"));

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: new Guid("c6e6988b-7bbb-42a7-bf65-4d8f6425e1b3"));

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: new Guid("d43abd0f-f35b-45fc-848b-715d98265b0c"));

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: new Guid("d740058d-bc9f-48be-9dd4-9d3e51fd636c"));

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: new Guid("e3566da9-66b8-42c9-8043-1b229e130f84"));

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: new Guid("e46756e9-0d78-4e75-87b1-48da03f43ba6"));

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: new Guid("e4cde3fe-a4f2-427c-bf4c-57927ae0e629"));

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: new Guid("e7439069-4eff-4bd0-91ba-e0fb2d88fc77"));

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: new Guid("e831641c-b3e5-4dce-a4df-54d3abf5b414"));

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: new Guid("e8eb440e-640c-4b09-8d43-fb0553704242"));

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: new Guid("ebde4e15-1890-4cd7-8e43-dc7285d538e0"));

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: new Guid("f016b991-5566-44d8-94ec-bff357c41035"));

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: new Guid("f0a7ccb7-c4c9-4704-836d-cd4a179a1952"));

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: new Guid("f4191da6-4c7b-4982-a876-a63d198f5b2d"));

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "ProductInventoryId",
                keyValue: new Guid("f5cc27e8-fd3e-4791-8818-1fc163f49be8"));

            migrationBuilder.AlterColumn<int>(
                name: "ProductInventoryId",
                table: "ProductInventories",
                type: "int",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<Guid>(
                name: "ProductId",
                table: "ProductInventories",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.InsertData(
                table: "ProductInventories",
                columns: new[] { "ProductInventoryId", "LastInventory", "ProductId", "Quantity" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2068), new Guid("0ce7e75e-7c97-4dc6-99df-cf63bb9db979"), 80 },
                    { 2, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2125), new Guid("ea8a28e8-a737-4d10-8ec8-d049c4337d48"), 94 },
                    { 3, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2127), new Guid("c6ca0c21-5c01-4107-be18-a9bed7c19350"), 36 },
                    { 4, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2130), new Guid("fa6cbf1a-8ae3-4b49-b7cc-705079bbeb81"), 54 },
                    { 5, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2132), new Guid("d7fa75c9-6389-4027-928d-edbbb0f17b56"), 78 },
                    { 6, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2135), new Guid("0cac07f9-a5c9-4ba2-846f-0c1fcef4e824"), 56 },
                    { 7, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2137), new Guid("a7128799-2343-4c63-a866-5228fe6e971a"), 94 },
                    { 8, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2139), new Guid("d44908cd-086c-4778-bb9f-4b3402682e61"), 48 },
                    { 9, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2142), new Guid("b24a89f8-c6b8-4582-af00-db9af023c06f"), 57 },
                    { 10, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2145), new Guid("034bbcd7-2052-4071-af85-f29e1edf87c8"), 41 },
                    { 11, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2147), new Guid("1baea711-4ed0-43d1-a565-34c3c5efc98b"), 77 },
                    { 12, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2149), new Guid("cde08a71-d9c7-47ad-8f7b-cca7df05b9d3"), 24 },
                    { 13, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2152), new Guid("cf0e958d-5359-4148-ad97-aad3ba4b4208"), 70 },
                    { 14, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2154), new Guid("2a6e1f5e-2adf-4021-8d75-d2c05fcf12c6"), 55 },
                    { 15, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2156), new Guid("524b7b2a-0140-4d84-9f07-237ffe2ac1f9"), 98 },
                    { 16, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2158), new Guid("0d5bb576-e40b-4ab7-92bf-70af3c6c8b8e"), 20 },
                    { 17, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2160), new Guid("dadb4a4f-b2bd-490c-b9ca-e6fd8030d504"), 91 },
                    { 18, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2163), new Guid("08f072be-9e3e-4779-b5df-63be728c93cd"), 78 },
                    { 19, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2166), new Guid("66c9ce69-947f-47f5-8d3d-79ee985c76a1"), 45 },
                    { 20, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2168), new Guid("19680270-4982-4a44-be39-3caf18dbc775"), 90 },
                    { 21, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2170), new Guid("b62b54e3-18d1-4850-b289-5ec9633dd7c3"), 73 },
                    { 22, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2172), new Guid("85f465a6-95bc-430c-82dd-ba75b84f3424"), 84 },
                    { 23, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2174), new Guid("8036b3c1-f258-46aa-86ea-b9aae27bb488"), 82 },
                    { 24, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2177), new Guid("b0faaf42-4b5e-41b4-b143-cc398019c706"), 56 },
                    { 25, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2179), new Guid("8198ed81-b907-4711-a414-cebf71971d08"), 24 },
                    { 26, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2181), new Guid("4257e78a-77f8-4c28-a487-8a98f387f122"), 20 },
                    { 27, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2183), new Guid("dfeb7991-21ac-4d52-a9c0-cb5a796e4bee"), 71 },
                    { 28, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2185), new Guid("48fa4a99-077a-4c04-9010-43294c042a31"), 90 },
                    { 29, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2188), new Guid("e07a5c2c-41fa-47cf-9e28-07bc9a3e0e90"), 31 },
                    { 30, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2190), new Guid("7af58248-78d8-4928-9c1e-caf8f02bd138"), 73 },
                    { 31, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2192), new Guid("c3dc5a99-61dd-4c41-88a0-779ecb93f920"), 37 },
                    { 32, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2194), new Guid("c882043c-becf-419a-8110-6106ac8c9da1"), 30 },
                    { 33, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2196), new Guid("757937a5-d8a6-4676-8812-e75064dc756a"), 60 },
                    { 34, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2200), new Guid("166ac460-c5aa-4f26-b598-327febe5a008"), 30 },
                    { 35, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2202), new Guid("ee1fa5dc-b270-4c76-8243-789db413d74f"), 48 },
                    { 36, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2204), new Guid("949fc2e6-deb5-4071-bb36-fce359631a79"), 24 },
                    { 37, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2206), new Guid("e00150a7-e82b-40e0-a7a6-4d17aa623d80"), 24 },
                    { 38, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2208), new Guid("48cd40ca-58c4-49b6-8d62-5a678d2d5b0c"), 86 },
                    { 39, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2211), new Guid("06ed5e14-c926-4021-94df-4cf52552dd29"), 55 },
                    { 40, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2213), new Guid("abee0b2d-02ab-45fe-a733-299fe6b7ed82"), 59 },
                    { 41, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2215), new Guid("b8aa63c8-0c6e-4da3-a715-bbfb4baf8642"), 42 },
                    { 42, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2217), new Guid("5e8508ae-57e4-48a0-9125-dc0997517d5a"), 55 },
                    { 43, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2219), new Guid("3bb881d4-ee1d-4db9-bbf3-3790baaca1fb"), 42 },
                    { 44, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2222), new Guid("8cbfb40e-23b1-4c46-9727-116c84a94629"), 78 },
                    { 45, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2224), new Guid("9cdd4898-9e63-486b-ab42-f31ef81bd107"), 58 },
                    { 46, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2226), new Guid("8f4ec640-b089-4f53-872e-6e37f18b2101"), 37 },
                    { 47, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2228), new Guid("97992994-1e57-439f-ae59-f7461738ba20"), 93 },
                    { 48, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2230), new Guid("79c374ec-3a44-4dda-81b7-bf961420c3b2"), 23 },
                    { 49, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2232), new Guid("ee4f8b5d-6fd2-4ebc-ae40-6ee4809b5228"), 33 },
                    { 50, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2234), new Guid("940ebb9d-e469-491f-96f6-d06ac61ea1fc"), 58 },
                    { 51, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2237), new Guid("846ae453-2c4f-4a1e-8fa3-b56305166a33"), 53 },
                    { 52, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2239), new Guid("b6141f92-ee69-4eec-b01d-393c63efadd8"), 37 },
                    { 53, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2241), new Guid("33cd1f58-018e-4715-b5ed-33126a9a95ee"), 72 },
                    { 54, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2243), new Guid("03f810a2-9639-4c99-b505-1c5a9900a895"), 99 },
                    { 55, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2245), new Guid("f65a5fdc-9b9b-4920-8cd1-3d24288d0e95"), 84 },
                    { 56, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2248), new Guid("892b1593-edeb-4949-a120-da2311575504"), 73 },
                    { 57, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2250), new Guid("13eada7f-9468-4935-998b-beefd9af1f2f"), 60 },
                    { 58, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2252), new Guid("fcd46b3b-ce58-473a-ba81-477a22f24b32"), 76 },
                    { 59, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2254), new Guid("60fc6439-87ce-4e6e-b586-117b018cd5c7"), 29 },
                    { 60, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2257), new Guid("cc41a250-4925-47cd-8064-d445e31840b6"), 75 },
                    { 61, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2259), new Guid("162c37c3-be03-4b19-8eb7-504e0a7b38d2"), 56 },
                    { 62, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2261), new Guid("c8e2bb0c-1fce-43c0-a796-e657d6a302c0"), 44 },
                    { 63, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2263), new Guid("aad5f1ab-518a-4f7c-8827-d3896b2b6492"), 54 },
                    { 64, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2265), new Guid("2548934c-76d9-44e3-8426-505f70b8fb3a"), 25 },
                    { 65, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2267), new Guid("2f64d355-3dd1-467e-9982-22194b0f7e36"), 89 },
                    { 66, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2270), new Guid("322722c5-1d0f-4629-a97f-a843826d7273"), 39 },
                    { 67, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2273), new Guid("c74eeb12-c8c9-49d5-83bf-ec426b13b362"), 46 },
                    { 68, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2275), new Guid("00666402-3e1b-4eb2-9910-f92f2934ca77"), 60 },
                    { 69, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2277), new Guid("c1b12770-8729-4dac-a1bb-9691393ad173"), 63 },
                    { 70, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2279), new Guid("697f78c6-b4d3-47c9-8408-b48b5a8f2ed7"), 82 },
                    { 71, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2282), new Guid("ca0d490b-9fa0-4cc6-a65f-2c2a607c9c58"), 37 },
                    { 72, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2284), new Guid("60996c86-5530-4fed-a615-ebbc78a7a6bf"), 37 },
                    { 73, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2286), new Guid("7d6e1413-2e00-481c-abdb-ddb59c7d0113"), 35 },
                    { 74, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2288), new Guid("c10198a2-e182-46f7-85a3-a912bd57ffac"), 55 },
                    { 75, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2290), new Guid("4d367aa9-1484-4648-bb86-0b641a25ed55"), 29 },
                    { 76, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2292), new Guid("adf00df0-a252-4c79-b909-548300b6077d"), 85 },
                    { 77, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2294), new Guid("a19ebc5e-6360-427d-adc7-8f14e5244d3e"), 95 },
                    { 78, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2296), new Guid("15c387e5-e639-4c48-bd62-6fde6f37a1c7"), 58 },
                    { 79, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2299), new Guid("c467857b-c73a-4dc7-be34-b90281673509"), 84 },
                    { 80, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2301), new Guid("e4ae135c-6d8a-4050-9a95-9fb77bfa5ca9"), 76 },
                    { 81, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2303), new Guid("256920a2-ea83-491a-afe3-082b041abe95"), 47 },
                    { 82, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2305), new Guid("3a5de066-9b9d-4d60-9f16-f33660a31172"), 54 },
                    { 83, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2307), new Guid("b26d8e2a-ce27-4257-91b2-de9bb9bafe29"), 39 },
                    { 84, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2309), new Guid("cb470613-4b6c-480d-80e1-aaf452dea419"), 80 },
                    { 85, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2312), new Guid("9d9c3011-f945-44cc-bc07-b385b927a173"), 26 },
                    { 86, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2314), new Guid("b7ec227b-a22b-409e-a14f-61b726db9c77"), 65 },
                    { 87, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2316), new Guid("b6f4cf98-64d5-4ad7-a823-3cafd9d6b9df"), 36 },
                    { 88, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2318), new Guid("69f06927-47ca-413a-80dd-506476301a13"), 75 },
                    { 89, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2320), new Guid("ca2f8920-2644-4f26-9062-5cba0c664027"), 47 },
                    { 90, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2322), new Guid("ce8c4615-9c5c-4993-85a9-f0ca33cc48ac"), 34 },
                    { 91, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2325), new Guid("d487bc5f-28d2-4efc-8a7d-7ad5d357984c"), 57 },
                    { 92, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2327), new Guid("e312a808-9591-49cf-976b-e263489afcea"), 95 },
                    { 93, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2329), new Guid("62d0984b-6e2e-467e-b8dd-e6e913661e74"), 90 },
                    { 94, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2331), new Guid("238c4798-0ae0-4e96-ae05-97b0b0f5b129"), 20 },
                    { 95, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2334), new Guid("389c2006-a607-4364-a79b-ebf8d6370632"), 22 },
                    { 96, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2336), new Guid("1c889b6e-fed7-4d3e-8fe0-d0f4ed135ccb"), 66 },
                    { 97, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2338), new Guid("5c4c881b-4b2a-4e45-9cec-0d0ac5dfc529"), 32 },
                    { 98, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2340), new Guid("f1e34f4e-dee0-4e33-a8ba-ffdd9860432e"), 22 },
                    { 99, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2342), new Guid("e5b9d646-e169-45bf-ac25-fbead30cd469"), 93 },
                    { 100, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2344), new Guid("a18a9ba1-223f-4c10-8edc-4cba96a75720"), 77 },
                    { 101, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2347), new Guid("7fb8e3a3-105e-4a57-95ba-8957821bce71"), 99 },
                    { 102, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2349), new Guid("55943366-3443-4f1f-a286-21c9f79fe943"), 34 },
                    { 103, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2351), new Guid("07d0a511-a9ef-4edb-83c4-10f99a4b3fd9"), 88 },
                    { 104, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2353), new Guid("bca69c8d-a0da-4880-bee3-50ac025d2f76"), 76 },
                    { 105, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2355), new Guid("7e03c04e-fb68-4d07-b12a-6256dc246b95"), 85 },
                    { 106, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2357), new Guid("063beb70-115d-47f7-aee7-f7d71cdf0767"), 54 },
                    { 107, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2360), new Guid("46e8e096-c9f3-4f7b-ac16-fcecf9923256"), 46 },
                    { 108, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2384), new Guid("2ab58125-2397-44e2-aad1-d6edc85cc2aa"), 71 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "ColorId", "ProductDescription", "ProductName", "ProductPrice", "Quantity", "Rating", "SizeId", "SubCategoryId" },
                values: new object[,]
                {
                    { new Guid("01a0723f-e30e-4baa-9259-de8127ec0180"), 6, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Stylish Shoes", 321.0, 15, 1, 3, 8 },
                    { new Guid("0978b756-a3b3-4d43-b68a-81d199b0c019"), 4, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Stylish Shoes", 439.0, 57, 2, 1, 8 },
                    { new Guid("0988613f-2217-42d3-b638-31967430b480"), 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Modern Shoes", 827.0, 35, 4, 3, 8 },
                    { new Guid("0cfd699c-a518-4f67-af1f-e0049bcdad9f"), 5, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Comfortable Dress", 861.0, 23, 1, 4, 7 },
                    { new Guid("0fcd3d62-8f39-4249-af3f-b6fa024f644c"), 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Stylish Suit", 973.0, 1, 4, 3, 14 },
                    { new Guid("1013c2b6-a183-4d3d-86d9-93cdd1c3075a"), 5, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Stylish Suit", 170.0, 8, 0, 6, 14 },
                    { new Guid("11f69707-5f94-422a-8404-b445cad4c1d4"), 6, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Sophisticated Suit", 503.0, 24, 4, 2, 14 },
                    { new Guid("1352645f-5f8e-48bf-8199-f43b47f89b07"), 5, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Comfortable Suit", 978.0, 90, 0, 4, 14 },
                    { new Guid("1577d4ed-d9fe-4ffd-a1d9-460a9261a2ed"), 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Sophisticated Dress", 892.0, 9, 1, 4, 7 },
                    { new Guid("162f8dea-2a5b-49a5-ac1f-d76a5ed9a1a2"), 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Trendy Suit", 403.0, 68, 3, 3, 14 },
                    { new Guid("1752a687-cf8e-412f-b615-a24778fe6328"), 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Fashionable Shoes", 442.0, 97, 2, 2, 8 },
                    { new Guid("1797b4f2-e2c7-49d4-9af1-f37686e89579"), 5, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Chic Suit", 183.0, 96, 4, 1, 14 },
                    { new Guid("17ac449b-ae6f-417a-a9cb-1939bd078054"), 5, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Fashionable Suit", 492.0, 74, 3, 2, 14 },
                    { new Guid("181f55fd-54fb-489f-a7d8-2bd00d1d5a4e"), 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Classy Dress", 332.0, 14, 3, 2, 7 },
                    { new Guid("1bb69825-b5c8-4203-9699-92c5766b3a0a"), 5, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Classy Shoes", 408.0, 9, 3, 1, 8 },
                    { new Guid("1bdac6ae-4804-4878-b4c2-0eb935737f7c"), 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Elegant Dress", 917.0, 19, 4, 3, 7 },
                    { new Guid("1c56d425-23c5-46f2-826d-c01f71046e86"), 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Comfortable Suit", 111.0, 22, 0, 5, 14 },
                    { new Guid("2070b5b4-d351-4b21-8037-1a03d6e2a60a"), 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Luxurious Shoes", 619.0, 44, 0, 5, 8 },
                    { new Guid("24dbb0a6-1cca-49f1-89ca-80d8c63eb2b0"), 5, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Elegant Suit", 182.0, 75, 2, 5, 14 },
                    { new Guid("2e27a761-7ddc-4f8b-82ef-ec9448115c40"), 4, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Chic Shoes", 478.0, 3, 4, 5, 8 },
                    { new Guid("33b6d403-ddf9-4016-b17e-a86077fa8af8"), 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Fancy Dress", 227.0, 94, 2, 4, 7 },
                    { new Guid("34b3d64b-fe38-4421-a1ec-e41240bdb21a"), 5, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Trendy Dress", 446.0, 29, 0, 6, 7 },
                    { new Guid("3961c569-1539-453c-af93-b6baf4e8f42f"), 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Great Shoes", 766.0, 32, 3, 3, 8 },
                    { new Guid("3cef6c38-7f3b-4684-925c-349a136fc952"), 6, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Elegant Dress", 506.0, 78, 1, 3, 7 },
                    { new Guid("401d2d9d-1a98-49b7-8cd4-25da142d4670"), 4, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Fancy Suit", 920.0, 46, 3, 6, 14 },
                    { new Guid("4119ce2c-409d-4c63-b50f-62d4b03c8557"), 5, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Chic Dress", 73.0, 56, 4, 5, 7 },
                    { new Guid("42c99901-e155-4857-8603-daa6f53788ca"), 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Great Dress", 887.0, 28, 1, 5, 7 },
                    { new Guid("441fdb89-a856-43be-a638-a63051288ca4"), 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Stylish Suit", 879.0, 52, 1, 5, 14 },
                    { new Guid("450ec360-7b5f-4693-8aa2-e2670b69e645"), 4, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Chic Suit", 603.0, 95, 4, 2, 14 },
                    { new Guid("467af521-5c98-452f-a976-bb5932a31173"), 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Elegant Dress", 173.0, 70, 4, 1, 7 },
                    { new Guid("48135ae2-a47d-41fc-aed9-5c3e77485600"), 4, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Chic Shoes", 624.0, 20, 3, 4, 8 },
                    { new Guid("4d7cec0d-7809-480e-ba5b-4a1a039881ae"), 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Classy Shoes", 680.0, 23, 1, 5, 8 },
                    { new Guid("4e105b41-c979-4076-8be8-c88bcb82146b"), 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Luxurious Suit", 552.0, 41, 1, 2, 14 },
                    { new Guid("5408c206-5657-4f2a-a8ae-8bf2d908a2b5"), 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Comfortable Shoes", 464.0, 86, 0, 6, 8 },
                    { new Guid("54e97419-75fc-4ba9-81a5-2b574efe5660"), 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Cozy Suit", 758.0, 74, 1, 1, 14 },
                    { new Guid("5545c939-a686-4547-ad28-8489f68248b3"), 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Comfortable Shoes", 454.0, 21, 0, 3, 8 },
                    { new Guid("5563be8e-db8d-418a-ab3f-11eea9414cc8"), 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Cozy Shoes", 803.0, 32, 4, 1, 8 },
                    { new Guid("5806b350-226c-44a6-ba95-56d4fcdd692f"), 6, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Chic Shoes", 185.0, 95, 4, 6, 8 },
                    { new Guid("5bf2a832-09c9-4aa3-889f-54223c07b8c9"), 6, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Stylish Suit", 564.0, 85, 1, 1, 14 },
                    { new Guid("5dde305e-0b24-4025-b34d-ad493b7798f5"), 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Comfortable Dress", 848.0, 86, 2, 3, 7 },
                    { new Guid("65dd2849-4837-4e2b-90c6-b559569c8370"), 6, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Classy Dress", 980.0, 69, 1, 6, 7 },
                    { new Guid("67073481-17ff-43a3-a58b-61f6157c3057"), 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Fancy Shoes", 985.0, 19, 3, 2, 8 },
                    { new Guid("6afff7e1-d12d-4b9e-ab92-57926dd28e78"), 6, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Fashionable Shoes", 960.0, 8, 1, 4, 8 },
                    { new Guid("6b02fec4-c846-4961-90e1-ef2560a10008"), 4, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Comfortable Dress", 158.0, 70, 0, 4, 7 },
                    { new Guid("6bb26f13-1db2-47a1-85a3-22241076a12b"), 6, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Classy Dress", 767.0, 35, 1, 2, 7 },
                    { new Guid("6fffa262-204a-403d-a909-7357674c73e9"), 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite Dress", 520.0, 54, 4, 1, 7 },
                    { new Guid("713b52a6-474f-45c3-89a3-3d09869bc8f1"), 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Warm Dress", 405.0, 25, 1, 1, 7 },
                    { new Guid("72312947-ef62-4968-bded-047fc930fce7"), 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Chic Suit", 441.0, 86, 2, 2, 14 },
                    { new Guid("75f22616-3803-4dd1-8b44-eea2554792af"), 6, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Comfortable Suit", 257.0, 58, 3, 6, 14 },
                    { new Guid("7819d10a-2200-4625-bd4f-879725959b16"), 5, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Fancy Suit", 337.0, 81, 2, 3, 14 },
                    { new Guid("785c1515-073b-4062-83c6-6e1f8800abed"), 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Stylish Suit", 442.0, 75, 3, 4, 14 },
                    { new Guid("7a730650-3a35-41a6-b993-e63f1040b0b6"), 6, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Fashionable Shoes", 879.0, 31, 1, 1, 8 },
                    { new Guid("81f08a41-5a37-4e4b-94e3-4c851f1c747d"), 4, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Classy Shoes", 425.0, 83, 4, 3, 8 },
                    { new Guid("85491136-4efb-45af-a26f-b20bb5b55502"), 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Modern Suit", 922.0, 71, 0, 4, 14 },
                    { new Guid("86d2aa72-0fe2-49db-a1fd-ca2df098a2c4"), 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Classy Shoes", 345.0, 16, 1, 6, 8 },
                    { new Guid("882168c7-dddf-4a6e-92fa-d31fe669dd0e"), 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Cozy Suit", 78.0, 35, 0, 6, 14 },
                    { new Guid("8ad892ad-7ea8-4250-896e-bd982f1217da"), 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Stylish Dress", 744.0, 75, 3, 3, 7 },
                    { new Guid("8c6a1cef-f1d0-45d8-83c5-14376a69c5b8"), 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Warm Dress", 857.0, 28, 4, 2, 7 },
                    { new Guid("9084b549-11a4-4a89-99c3-c1863f36d97f"), 5, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Chic Dress", 140.0, 81, 1, 3, 7 },
                    { new Guid("91b3907b-4bed-494a-82ff-c316dc1243e1"), 4, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite Suit", 962.0, 75, 2, 5, 14 },
                    { new Guid("91d212e7-df4f-4640-97af-16869542ad05"), 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Chic Dress", 65.0, 6, 1, 6, 7 },
                    { new Guid("958e9992-7f72-44b7-aa40-789bea769420"), 5, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Elegant Dress", 946.0, 90, 0, 2, 7 },
                    { new Guid("98ac508e-ebe1-4a18-b7a2-5cfd9bf0bb24"), 6, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Modern Suit", 277.0, 59, 3, 4, 14 },
                    { new Guid("994b9a80-d713-4734-a047-874e03c10a1e"), 5, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Luxurious Shoes", 587.0, 63, 0, 6, 8 },
                    { new Guid("9b0e61a9-d8f9-4783-a2b9-6cd2bd4bb543"), 5, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Classy Shoes", 230.0, 39, 1, 4, 8 },
                    { new Guid("9ca7670e-d694-460b-aef9-22db4bbe5a9f"), 5, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Comfortable Shoes", 286.0, 79, 4, 5, 8 },
                    { new Guid("9cd51294-65b2-40b2-9237-bae170703925"), 6, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Elegant Shoes", 128.0, 4, 2, 2, 8 },
                    { new Guid("9da55ebf-07de-4791-9754-335de64aa23f"), 4, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Comfortable Suit", 499.0, 97, 3, 4, 14 },
                    { new Guid("a322a511-5715-4a93-b5f2-518dbbf429b2"), 4, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite Shoes", 968.0, 4, 1, 2, 8 },
                    { new Guid("a41dc699-c5c7-4f96-9f9d-fb44b5f0a01c"), 6, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Elegant Dress", 670.0, 47, 3, 1, 7 },
                    { new Guid("a4a884ca-ae7c-4a76-abc6-a701a10a1df2"), 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Fashionable Dress", 510.0, 82, 3, 5, 7 },
                    { new Guid("a4accaf0-570a-4763-998c-ce8ceac1d0ea"), 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Fancy Shoes", 992.0, 29, 3, 1, 8 },
                    { new Guid("a6b08185-cd6e-4cbb-bb98-61f4769fd6e2"), 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Classy Shoes", 545.0, 98, 1, 4, 8 },
                    { new Guid("a6cfbcf8-19f8-4fee-8e28-58384ba33f9a"), 4, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Classy Dress", 300.0, 42, 3, 1, 7 },
                    { new Guid("a8c7800f-aea0-4ccd-9efd-a0becf07526e"), 4, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Elegant Dress", 350.0, 94, 4, 2, 7 },
                    { new Guid("aa3d3e64-3d76-45be-9981-3583a91626a3"), 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Fashionable Dress", 593.0, 82, 3, 5, 7 },
                    { new Guid("ab02f61b-a7a7-443c-8565-c1f6dfec412b"), 4, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Warm Suit", 615.0, 29, 2, 3, 14 },
                    { new Guid("ab457b6d-3203-45aa-8cd1-bb25fdad5817"), 6, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Cozy Dress", 817.0, 54, 0, 4, 7 },
                    { new Guid("ae841920-8947-482f-bc7a-421767a094dc"), 6, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Comfortable Suit", 964.0, 45, 3, 3, 14 },
                    { new Guid("b19d897e-226b-48cc-8efa-5357321846fd"), 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Trendy Suit", 876.0, 14, 4, 1, 14 },
                    { new Guid("b231e726-3a57-4d5d-87ce-2098383095ba"), 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Chic Dress", 388.0, 51, 4, 6, 7 },
                    { new Guid("b31baf5b-dcd2-46a1-b4eb-cf0e95fd0d29"), 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Luxurious Shoes", 535.0, 42, 3, 5, 8 },
                    { new Guid("b355f774-54fd-4107-97d0-47578d4a955a"), 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Elegant Shoes", 807.0, 46, 2, 1, 8 },
                    { new Guid("b449bece-feaf-449a-b3ed-7b5d8fb022f5"), 6, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Elegant Shoes", 778.0, 8, 2, 5, 8 },
                    { new Guid("b54191d9-fbc8-46ac-a409-5454443bd9ad"), 5, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Stylish Shoes", 826.0, 49, 1, 2, 8 },
                    { new Guid("b778da7d-ea6c-4b7e-b400-6c9e614d63e4"), 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Sophisticated Suit", 326.0, 75, 2, 5, 14 },
                    { new Guid("bc7e5fbb-22f6-4323-bb08-a9ce92f15a8b"), 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Modern Suit", 351.0, 74, 4, 2, 14 },
                    { new Guid("bcbc5db3-2fd7-42e7-813e-bc3f88dbaebb"), 5, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Stylish Shoes", 250.0, 97, 0, 3, 8 },
                    { new Guid("c01a744c-c83a-4805-b8bb-65057555bf9c"), 5, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite Dress", 229.0, 5, 0, 1, 7 },
                    { new Guid("c05617c1-fb85-4ad3-ab17-09b57b3a0c92"), 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Fancy Suit", 520.0, 41, 4, 6, 14 },
                    { new Guid("c82d3f4a-c66b-46ed-967a-35b5670b86c7"), 6, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Cozy Suit", 789.0, 3, 1, 5, 14 },
                    { new Guid("caddce43-7e4f-471d-913e-d1bd5a14eebc"), 4, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Classy Dress", 619.0, 59, 4, 6, 7 },
                    { new Guid("cbbfca3f-588a-4905-a849-37a324ce6e36"), 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Fancy Dress", 99.0, 57, 2, 6, 7 },
                    { new Guid("d1101384-2c62-40fe-8812-fac7853a2d0c"), 4, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Fashionable Shoes", 242.0, 77, 2, 6, 8 },
                    { new Guid("d41904e7-a0db-4615-807c-083bd2c0aa2d"), 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Trendy Suit", 922.0, 33, 1, 1, 14 },
                    { new Guid("dde4552e-1e9c-405f-9390-fea684727763"), 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Cozy Shoes", 843.0, 46, 4, 2, 8 },
                    { new Guid("dfc9a2e3-f346-420d-901d-48f2880affd1"), 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Luxurious Dress", 208.0, 95, 4, 4, 7 },
                    { new Guid("e0e4ef0b-ac6f-4b37-ad4f-3fe720d76a4c"), 4, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Great Dress", 216.0, 50, 3, 5, 7 },
                    { new Guid("e69b27ad-554e-4ff4-8989-bc618bb79ddb"), 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Luxurious Suit", 710.0, 86, 2, 4, 14 },
                    { new Guid("ea1c9b70-680c-4de8-a4e0-e5d360ea1ce6"), 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite Suit", 243.0, 43, 2, 3, 14 },
                    { new Guid("ea26e674-10cf-463d-809f-24ab7aface6e"), 4, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Great Suit", 601.0, 11, 2, 1, 14 },
                    { new Guid("ee77d729-cfae-4977-8bb8-6fb371cd93e8"), 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Luxurious Shoes", 806.0, 4, 4, 4, 8 },
                    { new Guid("ef415501-1f2c-4698-8b16-0c5c1865657b"), 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Modern Shoes", 255.0, 86, 3, 6, 8 },
                    { new Guid("f2c3c633-07f5-4740-8618-c95dabf1b036"), 4, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Fashionable Dress", 180.0, 91, 1, 3, 7 },
                    { new Guid("f7884ff7-8f5e-4b2a-a674-ad2fd5579439"), 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Fashionable Dress", 933.0, 25, 1, 2, 7 },
                    { new Guid("f85fb346-2c41-43d0-9192-e837882b072b"), 6, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Exquisite Dress", 233.0, 62, 1, 5, 7 },
                    { new Guid("fcab86f6-7722-43da-a7c5-4753ee25ae45"), 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Modern Suit", 128.0, 22, 4, 6, 14 },
                    { new Guid("ff57f021-c0a4-420f-8146-ebc40d611846"), 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris bibendum, libero non rhoncus cursus, dolor libero accumsan ex, vel blandit elit neque quis ante. Morbi magna ex, fringilla id vehicula at, molestie id turpis. Duis bibendum ultrices sem, nec gravida enim tempor at. Praesent ac nulla tellus. Sed sed massa. ", "Modern Shoes", 768.0, 17, 2, 4, 8 }
                });

            migrationBuilder.InsertData(
                table: "ProductInventories",
                columns: new[] { "ProductInventoryId", "LastInventory", "ProductId", "Quantity" },
                values: new object[,]
                {
                    { 109, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2386), new Guid("d41904e7-a0db-4615-807c-083bd2c0aa2d"), 75 },
                    { 110, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2389), new Guid("72312947-ef62-4968-bded-047fc930fce7"), 90 },
                    { 111, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2391), new Guid("ea1c9b70-680c-4de8-a4e0-e5d360ea1ce6"), 97 },
                    { 112, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2393), new Guid("85491136-4efb-45af-a26f-b20bb5b55502"), 21 },
                    { 113, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2395), new Guid("1c56d425-23c5-46f2-826d-c01f71046e86"), 71 },
                    { 114, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2397), new Guid("c05617c1-fb85-4ad3-ab17-09b57b3a0c92"), 20 },
                    { 115, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2399), new Guid("b19d897e-226b-48cc-8efa-5357321846fd"), 38 },
                    { 116, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2401), new Guid("4e105b41-c979-4076-8be8-c88bcb82146b"), 91 },
                    { 117, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2404), new Guid("162f8dea-2a5b-49a5-ac1f-d76a5ed9a1a2"), 29 },
                    { 118, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2406), new Guid("e69b27ad-554e-4ff4-8989-bc618bb79ddb"), 89 },
                    { 119, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2408), new Guid("b778da7d-ea6c-4b7e-b400-6c9e614d63e4"), 41 },
                    { 120, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2410), new Guid("882168c7-dddf-4a6e-92fa-d31fe669dd0e"), 61 },
                    { 121, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2412), new Guid("54e97419-75fc-4ba9-81a5-2b574efe5660"), 43 },
                    { 122, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2414), new Guid("bc7e5fbb-22f6-4323-bb08-a9ce92f15a8b"), 75 },
                    { 123, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2417), new Guid("0fcd3d62-8f39-4249-af3f-b6fa024f644c"), 56 },
                    { 124, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2419), new Guid("785c1515-073b-4062-83c6-6e1f8800abed"), 34 },
                    { 125, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2421), new Guid("441fdb89-a856-43be-a638-a63051288ca4"), 63 },
                    { 126, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2423), new Guid("fcab86f6-7722-43da-a7c5-4753ee25ae45"), 80 },
                    { 127, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2425), new Guid("ea26e674-10cf-463d-809f-24ab7aface6e"), 26 },
                    { 128, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2427), new Guid("450ec360-7b5f-4693-8aa2-e2670b69e645"), 70 },
                    { 129, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2430), new Guid("ab02f61b-a7a7-443c-8565-c1f6dfec412b"), 71 },
                    { 130, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2433), new Guid("9da55ebf-07de-4791-9754-335de64aa23f"), 30 },
                    { 131, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2435), new Guid("91b3907b-4bed-494a-82ff-c316dc1243e1"), 53 },
                    { 132, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2438), new Guid("401d2d9d-1a98-49b7-8cd4-25da142d4670"), 89 },
                    { 133, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2440), new Guid("1797b4f2-e2c7-49d4-9af1-f37686e89579"), 47 },
                    { 134, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2442), new Guid("17ac449b-ae6f-417a-a9cb-1939bd078054"), 70 },
                    { 135, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2444), new Guid("7819d10a-2200-4625-bd4f-879725959b16"), 86 },
                    { 136, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2446), new Guid("1352645f-5f8e-48bf-8199-f43b47f89b07"), 39 },
                    { 137, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2448), new Guid("24dbb0a6-1cca-49f1-89ca-80d8c63eb2b0"), 29 },
                    { 138, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2450), new Guid("1013c2b6-a183-4d3d-86d9-93cdd1c3075a"), 68 },
                    { 139, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2453), new Guid("5bf2a832-09c9-4aa3-889f-54223c07b8c9"), 25 },
                    { 140, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2455), new Guid("11f69707-5f94-422a-8404-b445cad4c1d4"), 25 },
                    { 141, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2457), new Guid("ae841920-8947-482f-bc7a-421767a094dc"), 76 },
                    { 142, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2459), new Guid("98ac508e-ebe1-4a18-b7a2-5cfd9bf0bb24"), 57 },
                    { 143, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2461), new Guid("c82d3f4a-c66b-46ed-967a-35b5670b86c7"), 91 },
                    { 144, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2463), new Guid("75f22616-3803-4dd1-8b44-eea2554792af"), 20 },
                    { 145, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2465), new Guid("b355f774-54fd-4107-97d0-47578d4a955a"), 50 },
                    { 146, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2468), new Guid("1752a687-cf8e-412f-b615-a24778fe6328"), 55 },
                    { 147, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2470), new Guid("3961c569-1539-453c-af93-b6baf4e8f42f"), 74 },
                    { 148, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2472), new Guid("ee77d729-cfae-4977-8bb8-6fb371cd93e8"), 28 },
                    { 149, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2474), new Guid("b31baf5b-dcd2-46a1-b4eb-cf0e95fd0d29"), 56 },
                    { 150, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2476), new Guid("ef415501-1f2c-4698-8b16-0c5c1865657b"), 30 },
                    { 151, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2479), new Guid("5563be8e-db8d-418a-ab3f-11eea9414cc8"), 64 },
                    { 152, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2481), new Guid("67073481-17ff-43a3-a58b-61f6157c3057"), 73 },
                    { 153, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2483), new Guid("5545c939-a686-4547-ad28-8489f68248b3"), 84 },
                    { 154, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2485), new Guid("a6b08185-cd6e-4cbb-bb98-61f4769fd6e2"), 37 },
                    { 155, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2487), new Guid("4d7cec0d-7809-480e-ba5b-4a1a039881ae"), 96 },
                    { 156, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2489), new Guid("86d2aa72-0fe2-49db-a1fd-ca2df098a2c4"), 50 },
                    { 157, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2492), new Guid("a4accaf0-570a-4763-998c-ce8ceac1d0ea"), 76 },
                    { 158, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2494), new Guid("dde4552e-1e9c-405f-9390-fea684727763"), 41 },
                    { 159, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2496), new Guid("0988613f-2217-42d3-b638-31967430b480"), 33 },
                    { 160, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2498), new Guid("ff57f021-c0a4-420f-8146-ebc40d611846"), 55 },
                    { 161, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2500), new Guid("2070b5b4-d351-4b21-8037-1a03d6e2a60a"), 96 },
                    { 162, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2503), new Guid("5408c206-5657-4f2a-a8ae-8bf2d908a2b5"), 26 },
                    { 163, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2505), new Guid("0978b756-a3b3-4d43-b68a-81d199b0c019"), 66 },
                    { 164, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2507), new Guid("a322a511-5715-4a93-b5f2-518dbbf429b2"), 95 },
                    { 165, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2509), new Guid("81f08a41-5a37-4e4b-94e3-4c851f1c747d"), 23 },
                    { 166, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2512), new Guid("48135ae2-a47d-41fc-aed9-5c3e77485600"), 52 },
                    { 167, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2514), new Guid("2e27a761-7ddc-4f8b-82ef-ec9448115c40"), 32 },
                    { 168, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2516), new Guid("d1101384-2c62-40fe-8812-fac7853a2d0c"), 93 },
                    { 169, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2518), new Guid("1bb69825-b5c8-4203-9699-92c5766b3a0a"), 82 },
                    { 170, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2520), new Guid("b54191d9-fbc8-46ac-a409-5454443bd9ad"), 36 },
                    { 171, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2523), new Guid("bcbc5db3-2fd7-42e7-813e-bc3f88dbaebb"), 65 },
                    { 172, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2525), new Guid("9b0e61a9-d8f9-4783-a2b9-6cd2bd4bb543"), 65 },
                    { 173, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2527), new Guid("9ca7670e-d694-460b-aef9-22db4bbe5a9f"), 89 },
                    { 174, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2529), new Guid("994b9a80-d713-4734-a047-874e03c10a1e"), 92 },
                    { 175, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2532), new Guid("7a730650-3a35-41a6-b993-e63f1040b0b6"), 58 },
                    { 176, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2534), new Guid("9cd51294-65b2-40b2-9237-bae170703925"), 76 },
                    { 177, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2536), new Guid("01a0723f-e30e-4baa-9259-de8127ec0180"), 44 },
                    { 178, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2538), new Guid("6afff7e1-d12d-4b9e-ab92-57926dd28e78"), 54 },
                    { 179, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2540), new Guid("b449bece-feaf-449a-b3ed-7b5d8fb022f5"), 26 },
                    { 180, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2542), new Guid("5806b350-226c-44a6-ba95-56d4fcdd692f"), 56 },
                    { 181, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2545), new Guid("6fffa262-204a-403d-a909-7357674c73e9"), 78 },
                    { 182, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2547), new Guid("f7884ff7-8f5e-4b2a-a674-ad2fd5579439"), 76 },
                    { 183, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2549), new Guid("5dde305e-0b24-4025-b34d-ad493b7798f5"), 95 },
                    { 184, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2551), new Guid("33b6d403-ddf9-4016-b17e-a86077fa8af8"), 63 },
                    { 185, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2553), new Guid("a4a884ca-ae7c-4a76-abc6-a701a10a1df2"), 35 },
                    { 186, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2556), new Guid("b231e726-3a57-4d5d-87ce-2098383095ba"), 30 },
                    { 187, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2558), new Guid("713b52a6-474f-45c3-89a3-3d09869bc8f1"), 53 },
                    { 188, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2560), new Guid("8c6a1cef-f1d0-45d8-83c5-14376a69c5b8"), 73 },
                    { 189, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2562), new Guid("1bdac6ae-4804-4878-b4c2-0eb935737f7c"), 83 },
                    { 190, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2565), new Guid("dfc9a2e3-f346-420d-901d-48f2880affd1"), 70 },
                    { 191, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2567), new Guid("42c99901-e155-4857-8603-daa6f53788ca"), 62 },
                    { 192, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2569), new Guid("91d212e7-df4f-4640-97af-16869542ad05"), 79 },
                    { 193, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2571), new Guid("467af521-5c98-452f-a976-bb5932a31173"), 73 },
                    { 194, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2574), new Guid("181f55fd-54fb-489f-a7d8-2bd00d1d5a4e"), 43 },
                    { 195, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2576), new Guid("8ad892ad-7ea8-4250-896e-bd982f1217da"), 83 },
                    { 196, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2578), new Guid("1577d4ed-d9fe-4ffd-a1d9-460a9261a2ed"), 74 },
                    { 197, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2580), new Guid("aa3d3e64-3d76-45be-9981-3583a91626a3"), 90 },
                    { 198, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2582), new Guid("cbbfca3f-588a-4905-a849-37a324ce6e36"), 36 },
                    { 199, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2585), new Guid("a6cfbcf8-19f8-4fee-8e28-58384ba33f9a"), 29 },
                    { 200, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2587), new Guid("a8c7800f-aea0-4ccd-9efd-a0becf07526e"), 25 },
                    { 201, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2589), new Guid("f2c3c633-07f5-4740-8618-c95dabf1b036"), 93 },
                    { 202, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2591), new Guid("6b02fec4-c846-4961-90e1-ef2560a10008"), 94 },
                    { 203, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2593), new Guid("e0e4ef0b-ac6f-4b37-ad4f-3fe720d76a4c"), 47 },
                    { 204, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2595), new Guid("caddce43-7e4f-471d-913e-d1bd5a14eebc"), 70 },
                    { 205, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2598), new Guid("c01a744c-c83a-4805-b8bb-65057555bf9c"), 47 },
                    { 206, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2600), new Guid("958e9992-7f72-44b7-aa40-789bea769420"), 38 },
                    { 207, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2602), new Guid("9084b549-11a4-4a89-99c3-c1863f36d97f"), 30 },
                    { 208, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2604), new Guid("0cfd699c-a518-4f67-af1f-e0049bcdad9f"), 23 },
                    { 209, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2606), new Guid("4119ce2c-409d-4c63-b50f-62d4b03c8557"), 52 },
                    { 210, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2609), new Guid("34b3d64b-fe38-4421-a1ec-e41240bdb21a"), 98 },
                    { 211, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2611), new Guid("a41dc699-c5c7-4f96-9f9d-fb44b5f0a01c"), 79 },
                    { 212, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2613), new Guid("6bb26f13-1db2-47a1-85a3-22241076a12b"), 20 },
                    { 213, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2616), new Guid("3cef6c38-7f3b-4684-925c-349a136fc952"), 90 },
                    { 214, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2618), new Guid("ab457b6d-3203-45aa-8cd1-bb25fdad5817"), 76 },
                    { 215, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2620), new Guid("f85fb346-2c41-43d0-9192-e837882b072b"), 76 },
                    { 216, new DateTime(2023, 10, 30, 15, 39, 28, 22, DateTimeKind.Local).AddTicks(2622), new Guid("65dd2849-4837-4e2b-90c6-b559569c8370"), 38 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductInventories_ProductId",
                table: "ProductInventories",
                column: "ProductId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductInventories_Products_ProductId",
                table: "ProductInventories",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
