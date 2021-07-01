using Microsoft.EntityFrameworkCore.Migrations;

namespace Gp_3.Migrations
{
    public partial class AddProductVM : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_AddProductVM_AddProductVMID",
                table: "Categories");

            migrationBuilder.DropForeignKey(
                name: "FK_Inventories_AddProductVM_AddProductVMID",
                table: "Inventories");

            migrationBuilder.DropTable(
                name: "AddProductVM");

            migrationBuilder.DropIndex(
                name: "IX_Inventories_AddProductVMID",
                table: "Inventories");

            migrationBuilder.DropIndex(
                name: "IX_Categories_AddProductVMID",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "AddProductVMID",
                table: "Inventories");

            migrationBuilder.DropColumn(
                name: "AddProductVMID",
                table: "Categories");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AddProductVMID",
                table: "Inventories",
                type: "int",
                nullable: true);

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
                    AmountInStock = table.Column<int>(type: "int", nullable: false),
                    CategoryID = table.Column<int>(type: "int", nullable: false),
                    Desc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Img = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InventoryID = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<float>(type: "real", nullable: false),
                    ProductID = table.Column<int>(type: "int", nullable: false),
                    Rate = table.Column<float>(type: "real", nullable: false),
                    SellerID = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddProductVM", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Inventories_AddProductVMID",
                table: "Inventories",
                column: "AddProductVMID");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Inventories_AddProductVM_AddProductVMID",
                table: "Inventories",
                column: "AddProductVMID",
                principalTable: "AddProductVM",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
