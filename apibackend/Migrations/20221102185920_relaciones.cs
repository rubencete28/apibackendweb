using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace apibackend.Migrations
{
    public partial class relaciones : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BaseEntity_BaseEntity_BaseEntitiesId",
                table: "BaseEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_BaseEntity_BaseEntity_CursoId",
                table: "BaseEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_BaseEntity_BaseEntity_StudentId",
                table: "BaseEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoryCurso_BaseEntity_CategoriesId",
                table: "CategoryCurso");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoryCurso_BaseEntity_CursosId",
                table: "CategoryCurso");

            migrationBuilder.DropForeignKey(
                name: "FK_CursoStudent_BaseEntity_CursosId",
                table: "CursoStudent");

            migrationBuilder.DropForeignKey(
                name: "FK_CursoStudent_BaseEntity_studentsId",
                table: "CursoStudent");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BaseEntity",
                table: "BaseEntity");

            migrationBuilder.DropIndex(
                name: "IX_BaseEntity_BaseEntitiesId",
                table: "BaseEntity");

            migrationBuilder.DropIndex(
                name: "IX_BaseEntity_CursoId",
                table: "BaseEntity");

            migrationBuilder.DropIndex(
                name: "IX_BaseEntity_StudentId",
                table: "BaseEntity");

            migrationBuilder.DropColumn(
                name: "BaseEntitiesId",
                table: "BaseEntity");

            migrationBuilder.DropColumn(
                name: "CursoId",
                table: "BaseEntity");

            migrationBuilder.DropColumn(
                name: "Curso_Name",
                table: "BaseEntity");

            migrationBuilder.DropColumn(
                name: "DescripcionLarga",
                table: "BaseEntity");

            migrationBuilder.DropColumn(
                name: "DescriptionCorta",
                table: "BaseEntity");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "BaseEntity");

            migrationBuilder.DropColumn(
                name: "Dob",
                table: "BaseEntity");

            migrationBuilder.DropColumn(
                name: "Nivel",
                table: "BaseEntity");

            migrationBuilder.DropColumn(
                name: "Objetivos",
                table: "BaseEntity");

            migrationBuilder.DropColumn(
                name: "PublicoObjetivos",
                table: "BaseEntity");

            migrationBuilder.DropColumn(
                name: "Requisitos",
                table: "BaseEntity");

            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "BaseEntity");

            migrationBuilder.DropColumn(
                name: "Student_Name",
                table: "BaseEntity");

            migrationBuilder.DropColumn(
                name: "User_LastName",
                table: "BaseEntity");

            migrationBuilder.DropColumn(
                name: "User_Name",
                table: "BaseEntity");

            migrationBuilder.RenameTable(
                name: "BaseEntity",
                newName: "Users");

            migrationBuilder.RenameColumn(
                name: "CursosId",
                table: "CursoStudent",
                newName: "CursoId");

            migrationBuilder.RenameColumn(
                name: "CursosId",
                table: "CategoryCurso",
                newName: "cursosId");

            migrationBuilder.RenameColumn(
                name: "CategoriesId",
                table: "CategoryCurso",
                newName: "categoriesId");

            migrationBuilder.RenameIndex(
                name: "IX_CategoryCurso_CursosId",
                table: "CategoryCurso",
                newName: "IX_CategoryCurso_cursosId");

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
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
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
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DescriptionCorta = table.Column<string>(type: "nvarchar(280)", maxLength: 280, nullable: false),
                    DescripcionLarga = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PublicoObjetivos = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Objetivos = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Requisitos = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nivel = table.Column<int>(type: "int", nullable: false),
                    CreateBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
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
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Dob = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
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
                    UpdateBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                newName: "BaseEntity");

            migrationBuilder.RenameColumn(
                name: "CursoId",
                table: "CursoStudent",
                newName: "CursosId");

            migrationBuilder.RenameColumn(
                name: "cursosId",
                table: "CategoryCurso",
                newName: "CursosId");

            migrationBuilder.RenameColumn(
                name: "categoriesId",
                table: "CategoryCurso",
                newName: "CategoriesId");

            migrationBuilder.RenameIndex(
                name: "IX_CategoryCurso_cursosId",
                table: "CategoryCurso",
                newName: "IX_CategoryCurso_CursosId");

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "BaseEntity",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "BaseEntity",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "BaseEntity",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "EmailAddress",
                table: "BaseEntity",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "BaseEntitiesId",
                table: "BaseEntity",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CursoId",
                table: "BaseEntity",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Curso_Name",
                table: "BaseEntity",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DescripcionLarga",
                table: "BaseEntity",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DescriptionCorta",
                table: "BaseEntity",
                type: "nvarchar(280)",
                maxLength: 280,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "BaseEntity",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "Dob",
                table: "BaseEntity",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Nivel",
                table: "BaseEntity",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Objetivos",
                table: "BaseEntity",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PublicoObjetivos",
                table: "BaseEntity",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Requisitos",
                table: "BaseEntity",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StudentId",
                table: "BaseEntity",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Student_Name",
                table: "BaseEntity",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "User_LastName",
                table: "BaseEntity",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "User_Name",
                table: "BaseEntity",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_BaseEntity",
                table: "BaseEntity",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntity_BaseEntitiesId",
                table: "BaseEntity",
                column: "BaseEntitiesId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntity_CursoId",
                table: "BaseEntity",
                column: "CursoId",
                unique: true,
                filter: "[CursoId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntity_StudentId",
                table: "BaseEntity",
                column: "StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_BaseEntity_BaseEntity_BaseEntitiesId",
                table: "BaseEntity",
                column: "BaseEntitiesId",
                principalTable: "BaseEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BaseEntity_BaseEntity_CursoId",
                table: "BaseEntity",
                column: "CursoId",
                principalTable: "BaseEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BaseEntity_BaseEntity_StudentId",
                table: "BaseEntity",
                column: "StudentId",
                principalTable: "BaseEntity",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryCurso_BaseEntity_CategoriesId",
                table: "CategoryCurso",
                column: "CategoriesId",
                principalTable: "BaseEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryCurso_BaseEntity_CursosId",
                table: "CategoryCurso",
                column: "CursosId",
                principalTable: "BaseEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CursoStudent_BaseEntity_CursosId",
                table: "CursoStudent",
                column: "CursosId",
                principalTable: "BaseEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CursoStudent_BaseEntity_studentsId",
                table: "CursoStudent",
                column: "studentsId",
                principalTable: "BaseEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
