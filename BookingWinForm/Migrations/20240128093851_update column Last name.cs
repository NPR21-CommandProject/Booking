using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookingWinForm.Migrations
{
    /// <inheritdoc />
    public partial class updatecolumnLastname : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LasttName",
                table: "tblUsers",
                newName: "LastName");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "tblUsers",
                newName: "LasttName");
        }
    }
}
