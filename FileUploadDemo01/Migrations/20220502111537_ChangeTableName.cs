using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FileUploadDemo01.Migrations
{
    public partial class ChangeTableName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_MyProperty",
                table: "MyProperty");

            migrationBuilder.RenameTable(
                name: "MyProperty",
                newName: "uplodedFileModels");

            migrationBuilder.AddPrimaryKey(
                name: "PK_uplodedFileModels",
                table: "uplodedFileModels",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_uplodedFileModels",
                table: "uplodedFileModels");

            migrationBuilder.RenameTable(
                name: "uplodedFileModels",
                newName: "MyProperty");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MyProperty",
                table: "MyProperty",
                column: "Id");
        }
    }
}
