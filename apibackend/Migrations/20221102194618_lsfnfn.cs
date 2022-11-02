using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace apibackend.Migrations
{
    public partial class lsfnfn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CategoryCurso_Category_categoriesId",
                table: "CategoryCurso");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoryCurso_Cursos_cursosId",
                table: "CategoryCurso");

            migrationBuilder.DropForeignKey(
                name: "FK_CursoStudent_Cursos_CursoId",
                table: "CursoStudent");

            migrationBuilder.DropForeignKey(
                name: "FK_CursoStudent_Students_studentsId",
                table: "CursoStudent");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "Chapters");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Cursos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "baseEntities");

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "baseEntities",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "baseEntities",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "baseEntities",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "EmailAddress",
                table: "baseEntities",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "CursoId",
                table: "baseEntities",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Curso_Name",
                table: "baseEntities",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DescripcionLarga",
                table: "baseEntities",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DescriptionCorta",
                table: "baseEntities",
                type: "nvarchar(280)",
                maxLength: 280,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "baseEntities",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "Dob",
                table: "baseEntities",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Nivel",
                table: "baseEntities",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Objetivos",
                table: "baseEntities",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PublicoObjetivos",
                table: "baseEntities",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Requisitos",
                table: "baseEntities",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Student_Name",
                table: "baseEntities",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "User_LastName",
                table: "baseEntities",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "User_Name",
                table: "baseEntities",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_baseEntities",
                table: "baseEntities",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_baseEntities_CursoId",
                table: "baseEntities",
                column: "CursoId",
                unique: true,
                filter: "[CursoId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_baseEntities_baseEntities_CursoId",
                table: "baseEntities",
                column: "CursoId",
                principalTable: "baseEntities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryCurso_baseEntities_categoriesId",
                table: "CategoryCurso",
                column: "categoriesId",
                principalTable: "baseEntities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryCurso_baseEntities_cursosId",
                table: "CategoryCurso",
                column: "cursosId",
                principalTable: "baseEntities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CursoStudent_baseEntities_CursoId",
                table: "CursoStudent",
                column: "CursoId",
                principalTable: "baseEntities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CursoStudent_baseEntities_studentsId",
                table: "CursoStudent",
                column: "studentsId",
                principalTable: "baseEntities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_baseEntities_baseEntities_CursoId",
                table: "baseEntities");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoryCurso_baseEntities_categoriesId",
                table: "CategoryCurso");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoryCurso_baseEntities_cursosId",
                table: "CategoryCurso");

            migrationBuilder.DropForeignKey(
                name: "FK_CursoStudent_baseEntities_CursoId",
                table: "CursoStudent");

            migrationBuilder.DropForeignKey(
                name: "FK_CursoStudent_baseEntities_studentsId",
                table: "CursoStudent");

            migrationBuilder.DropPrimaryKey(
                name: "PK_baseEntities",
                table: "baseEntities");

            migrationBuilder.DropIndex(
                name: "IX_baseEntities_CursoId",
                table: "baseEntities");

            migrationBuilder.DropColumn(
                name: "CursoId",
                table: "baseEntities");

            migrationBuilder.DropColumn(
                name: "Curso_Name",
                table: "baseEntities");

            migrationBuilder.DropColumn(
                name: "DescripcionLarga",
                table: "baseEntities");

            migrationBuilder.DropColumn(
                name: "DescriptionCorta",
                table: "baseEntities");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "baseEntities");

            migrationBuilder.DropColumn(
                name: "Dob",
                table: "baseEntities");

            migrationBuilder.DropColumn(
                name: "Nivel",
                table: "baseEntities");

            migrationBuilder.DropColumn(
                name: "Objetivos",
                table: "baseEntities");

            migrationBuilder.DropColumn(
                name: "PublicoObjetivos",
                table: "baseEntities");

            migrationBuilder.DropColumn(
                name: "Requisitos",
                table: "baseEntities");

            migrationBuilder.DropColumn(
                name: "Student_Name",
                table: "baseEntities");

            migrationBuilder.DropColumn(
                name: "User_LastName",
                table: "baseEntities");

            migrationBuilder.DropColumn(
                name: "User_Name",
                table: "baseEntities");

            migrationBuilder.RenameTable(
                name: "baseEntities",
                newName: "Users");

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Users",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Users",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EmailAddress",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdateBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cursos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DescripcionLarga = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DescriptionCorta = table.Column<string>(type: "nvarchar(280)", maxLength: 280, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Nivel = table.Column<int>(type: "int", nullable: false),
                    Objetivos = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PublicoObjetivos = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Requisitos = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdateBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cursos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Dob = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdateBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Chapters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CursoId = table.Column<int>(type: "int", nullable: false),
                    CreateBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    UpdateBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chapters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Chapters_Cursos_CursoId",
                        column: x => x.CursoId,
                        principalTable: "Cursos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Chapters_CursoId",
                table: "Chapters",
                column: "CursoId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryCurso_Category_categoriesId",
                table: "CategoryCurso",
                column: "categoriesId",
                principalTable: "Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryCurso_Cursos_cursosId",
                table: "CategoryCurso",
                column: "cursosId",
                principalTable: "Cursos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CursoStudent_Cursos_CursoId",
                table: "CursoStudent",
                column: "CursoId",
                principalTable: "Cursos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CursoStudent_Students_studentsId",
                table: "CursoStudent",
                column: "studentsId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
