using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Gp_3.Migrations
{
    public partial class seee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AddProductVMID",
                table: "Categories",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "AddProductVM",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductID = table.Column<int>(type: "int", nullable: false),
                    CategoryID = table.Column<int>(type: "int", nullable: false),
                    SellerID = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Desc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<float>(type: "real", nullable: false),
                    Img = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AmountInStock = table.Column<int>(type: "int", nullable: false),
                    EntryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Rate = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddProductVM", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Categories_AddProductVMID",
                table: "Categories",
                column: "AddProductVMID");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_AddProductVM_AddProductVMID",
                table: "Categories",
                column: "AddProductVMID",
                principalTable: "AddProductVM",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_AddProductVM_AddProductVMID",
                table: "Categories");

            migrationBuilder.DropTable(
                name: "AddProductVM");

            migrationBuilder.DropIndex(
                name: "IX_Categories_AddProductVMID",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "AddProductVMID",
                table: "Categories");
        }
    }
}
