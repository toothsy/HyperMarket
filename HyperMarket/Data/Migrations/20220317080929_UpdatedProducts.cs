using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HyperMarket.Data.Migrations
{
    public partial class UpdatedProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblImage");

            migrationBuilder.DropColumn(
                name: "ImageCheck",
                table: "tblProduct");

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "tblProduct",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "tblProduct");

            migrationBuilder.AddColumn<bool>(
                name: "ImageCheck",
                table: "tblProduct",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "tblImage",
                columns: table => new
                {
                    ImageId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ProductId = table.Column<int>(type: "INTEGER", nullable: false),
                    ImageLink = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblImage", x => x.ImageId);
                    table.ForeignKey(
                        name: "FK_tblImage_tblProduct_ProductId",
                        column: x => x.ProductId,
                        principalTable: "tblProduct",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tblImage_ProductId",
                table: "tblImage",
                column: "ProductId");
        }
    }
}
