using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace apibackend.Migrations
{
    public partial class kbkbjb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BaseEntity_BaseEntity_BaseEntityId",
                table: "BaseEntity");

            migrationBuilder.RenameColumn(
                name: "BaseEntityId",
                table: "BaseEntity",
                newName: "StudentId");

            migrationBuilder.RenameIndex(
                name: "IX_BaseEntity_BaseEntityId",
                table: "BaseEntity",
                newName: "IX_BaseEntity_StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_BaseEntity_BaseEntity_StudentId",
                table: "BaseEntity",
                column: "StudentId",
                principalTable: "BaseEntity",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BaseEntity_BaseEntity_StudentId",
                table: "BaseEntity");

            migrationBuilder.RenameColumn(
                name: "StudentId",
                table: "BaseEntity",
                newName: "BaseEntityId");

            migrationBuilder.RenameIndex(
                name: "IX_BaseEntity_StudentId",
                table: "BaseEntity",
                newName: "IX_BaseEntity_BaseEntityId");

            migrationBuilder.AddForeignKey(
                name: "FK_BaseEntity_BaseEntity_BaseEntityId",
                table: "BaseEntity",
                column: "BaseEntityId",
                principalTable: "BaseEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
