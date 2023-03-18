using Microsoft.EntityFrameworkCore.Migrations;

namespace SystemWebDorms.Migrations
{
    public partial class NewDB2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MasterDormId",
                table: "MasterMenus",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "MasterMenuDropMenuLink",
                table: "MasterMenus",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MasterMenuId",
                table: "MasterDormitories",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_MasterMenus_MasterDormId",
                table: "MasterMenus",
                column: "MasterDormId");

            migrationBuilder.CreateIndex(
                name: "IX_MasterDormitories_MasterMenuId",
                table: "MasterDormitories",
                column: "MasterMenuId");

            migrationBuilder.AddForeignKey(
                name: "FK_MasterDormitories_MasterMenus_MasterMenuId",
                table: "MasterDormitories",
                column: "MasterMenuId",
                principalTable: "MasterMenus",
                principalColumn: "MasterMenuId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterMenus_MasterDormitories_MasterDormId",
                table: "MasterMenus",
                column: "MasterDormId",
                principalTable: "MasterDormitories",
                principalColumn: "MasterDormId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MasterDormitories_MasterMenus_MasterMenuId",
                table: "MasterDormitories");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterMenus_MasterDormitories_MasterDormId",
                table: "MasterMenus");

            migrationBuilder.DropIndex(
                name: "IX_MasterMenus_MasterDormId",
                table: "MasterMenus");

            migrationBuilder.DropIndex(
                name: "IX_MasterDormitories_MasterMenuId",
                table: "MasterDormitories");

            migrationBuilder.DropColumn(
                name: "MasterDormId",
                table: "MasterMenus");

            migrationBuilder.DropColumn(
                name: "MasterMenuDropMenuLink",
                table: "MasterMenus");

            migrationBuilder.DropColumn(
                name: "MasterMenuId",
                table: "MasterDormitories");
        }
    }
}
