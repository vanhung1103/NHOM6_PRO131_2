using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _1_DAL.Migrations
{
    public partial class db2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bill_Voucher_Voucher_Id",
                table: "Bill");

            migrationBuilder.DropIndex(
                name: "IX_Bill_Voucher_Id",
                table: "Bill");

            migrationBuilder.DropColumn(
                name: "Total",
                table: "Bill");

            migrationBuilder.DropColumn(
                name: "Voucher_Id",
                table: "Bill");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Total",
                table: "Bill",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<Guid>(
                name: "Voucher_Id",
                table: "Bill",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Bill_Voucher_Id",
                table: "Bill",
                column: "Voucher_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Bill_Voucher_Voucher_Id",
                table: "Bill",
                column: "Voucher_Id",
                principalTable: "Voucher",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
