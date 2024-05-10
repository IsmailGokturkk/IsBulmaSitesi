using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IsBul.DAL.Migrations
{
    /// <inheritdoc />
    public partial class addCompanyDetailsJobs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CompanyDetailId",
                table: "Jobs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CompanyDetailId",
                table: "CompanyDetails",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Jobs_CompanyDetailId",
                table: "Jobs",
                column: "CompanyDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyDetails_CompanyDetailId",
                table: "CompanyDetails",
                column: "CompanyDetailId");

            migrationBuilder.AddForeignKey(
                name: "FK_CompanyDetails_CompanyDetails_CompanyDetailId",
                table: "CompanyDetails",
                column: "CompanyDetailId",
                principalTable: "CompanyDetails",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Jobs_CompanyDetails_CompanyDetailId",
                table: "Jobs",
                column: "CompanyDetailId",
                principalTable: "CompanyDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CompanyDetails_CompanyDetails_CompanyDetailId",
                table: "CompanyDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_Jobs_CompanyDetails_CompanyDetailId",
                table: "Jobs");

            migrationBuilder.DropIndex(
                name: "IX_Jobs_CompanyDetailId",
                table: "Jobs");

            migrationBuilder.DropIndex(
                name: "IX_CompanyDetails_CompanyDetailId",
                table: "CompanyDetails");

            migrationBuilder.DropColumn(
                name: "CompanyDetailId",
                table: "Jobs");

            migrationBuilder.DropColumn(
                name: "CompanyDetailId",
                table: "CompanyDetails");
        }
    }
}
