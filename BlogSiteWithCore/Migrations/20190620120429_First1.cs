using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogSiteWithCore.Migrations
{
    public partial class First1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "LastOperationerName",
                table: "Blogs",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "LastOperationerName",
                table: "Blogs",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldNullable: true);
        }
    }
}
