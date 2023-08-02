using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeFirst_Migrations.Migrations
{
    /// <inheritdoc />
    public partial class try_conventions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StudentID",
                table: "Student",
                newName: "StudentId");

            migrationBuilder.RenameColumn(
                name: "StudentName",
                table: "Student",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "GradeId",
                table: "Grade",
                newName: "Id");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfBirth",
                table: "Student",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Student",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "GradeId",
                table: "Student",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "Height",
                table: "Student",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<byte[]>(
                name: "Photo",
                table: "Student",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.AddColumn<float>(
                name: "Weight",
                table: "Student",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<string>(
                name: "Section",
                table: "Grade",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Student_GradeId",
                table: "Student",
                column: "GradeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Student_Grade_GradeId",
                table: "Student",
                column: "GradeId",
                principalTable: "Grade",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Student_Grade_GradeId",
                table: "Student");

            migrationBuilder.DropIndex(
                name: "IX_Student_GradeId",
                table: "Student");

            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "Student");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Student");

            migrationBuilder.DropColumn(
                name: "GradeId",
                table: "Student");

            migrationBuilder.DropColumn(
                name: "Height",
                table: "Student");

            migrationBuilder.DropColumn(
                name: "Photo",
                table: "Student");

            migrationBuilder.DropColumn(
                name: "Weight",
                table: "Student");

            migrationBuilder.DropColumn(
                name: "Section",
                table: "Grade");

            migrationBuilder.RenameColumn(
                name: "StudentId",
                table: "Student",
                newName: "StudentID");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Student",
                newName: "StudentName");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Grade",
                newName: "GradeId");
        }
    }
}
