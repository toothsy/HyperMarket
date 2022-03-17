using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HyperMarket.Data.Migrations
{
    public partial class UpdateOrder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tblOrder_tblBusinessDetail_BusinessDetailBusinessId",
                table: "tblOrder");

            migrationBuilder.DropColumn(
                name: "BusinessName",
                table: "tblOrder");

            migrationBuilder.RenameColumn(
                name: "BusinessDetailBusinessId",
                table: "tblOrder",
                newName: "BusinessDetailId");

            migrationBuilder.RenameIndex(
                name: "IX_tblOrder_BusinessDetailBusinessId",
                table: "tblOrder",
                newName: "IX_tblOrder_BusinessDetailId");

            migrationBuilder.AddForeignKey(
                name: "FK_tblOrder_tblBusinessDetail_BusinessDetailId",
                table: "tblOrder",
                column: "BusinessDetailId",
                principalTable: "tblBusinessDetail",
                principalColumn: "BusinessId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tblOrder_tblBusinessDetail_BusinessDetailId",
                table: "tblOrder");

            migrationBuilder.RenameColumn(
                name: "BusinessDetailId",
                table: "tblOrder",
                newName: "BusinessDetailBusinessId");

            migrationBuilder.RenameIndex(
                name: "IX_tblOrder_BusinessDetailId",
                table: "tblOrder",
                newName: "IX_tblOrder_BusinessDetailBusinessId");

            migrationBuilder.AddColumn<string>(
                name: "BusinessName",
                table: "tblOrder",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_tblOrder_tblBusinessDetail_BusinessDetailBusinessId",
                table: "tblOrder",
                column: "BusinessDetailBusinessId",
                principalTable: "tblBusinessDetail",
                principalColumn: "BusinessId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
