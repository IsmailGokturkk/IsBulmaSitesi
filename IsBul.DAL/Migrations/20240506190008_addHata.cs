using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IsBul.DAL.Migrations
{
    /// <inheritdoc />
    public partial class addHata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CompanyDetails_JobDetails_JobDetailId",
                table: "CompanyDetails");

            migrationBuilder.DropIndex(
                name: "IX_CompanyDetails_JobDetailId",
                table: "CompanyDetails");

            migrationBuilder.DropColumn(
                name: "JobDetailId",
                table: "CompanyDetails");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "JobDetailId",
                table: "CompanyDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_CompanyDetails_JobDetailId",
                table: "CompanyDetails",
                column: "JobDetailId");

            migrationBuilder.AddForeignKey(
                name: "FK_CompanyDetails_JobDetails_JobDetailId",
                table: "CompanyDetails",
                column: "JobDetailId",
                principalTable: "JobDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
