using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IsBul.DAL.Migrations
{
    /// <inheritdoc />
    public partial class CompanyDetailsRevise3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "CompanyDescription",
                table: "CompanyDetails",
                type: "nvarchar(2000)",
                maxLength: 2000,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 2000);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "CompanyDescription",
                table: "CompanyDetails",
                type: "int",
                maxLength: 2000,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(2000)",
                oldMaxLength: 2000);
        }
    }
}
