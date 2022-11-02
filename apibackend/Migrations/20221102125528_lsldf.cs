using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace apibackend.Migrations
{
    public partial class lsldf : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BaseEntity_BaseEntity_baseEntityId",
                table: "BaseEntity");

            migrationBuilder.RenameColumn(
                name: "baseEntityId",
                table: "BaseEntity",
                newName: "BaseEntityId");

            migrationBuilder.RenameIndex(
                name: "IX_BaseEntity_baseEntityId",
                table: "BaseEntity",
                newName: "IX_BaseEntity_BaseEntityId");

            migrationBuilder.AddColumn<int>(
                name: "BaseEntitiesId",
                table: "BaseEntity",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntity_BaseEntitiesId",
                table: "BaseEntity",
                column: "BaseEntitiesId");

            migrationBuilder.AddForeignKey(
                name: "FK_BaseEntity_BaseEntity_BaseEntitiesId",
                table: "BaseEntity",
                column: "BaseEntitiesId",
                principalTable: "BaseEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BaseEntity_BaseEntity_BaseEntityId",
                table: "BaseEntity",
                column: "BaseEntityId",
                principalTable: "BaseEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BaseEntity_BaseEntity_BaseEntitiesId",
                table: "BaseEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_BaseEntity_BaseEntity_BaseEntityId",
                table: "BaseEntity");

            migrationBuilder.DropIndex(
                name: "IX_BaseEntity_BaseEntitiesId",
                table: "BaseEntity");

            migrationBuilder.DropColumn(
                name: "BaseEntitiesId",
                table: "BaseEntity");

            migrationBuilder.RenameColumn(
                name: "BaseEntityId",
                table: "BaseEntity",
                newName: "baseEntityId");

            migrationBuilder.RenameIndex(
                name: "IX_BaseEntity_BaseEntityId",
                table: "BaseEntity",
                newName: "IX_BaseEntity_baseEntityId");

            migrationBuilder.AddForeignKey(
                name: "FK_BaseEntity_BaseEntity_baseEntityId",
                table: "BaseEntity",
                column: "baseEntityId",
                principalTable: "BaseEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
