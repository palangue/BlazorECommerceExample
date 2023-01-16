using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorECommersData.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class SecondDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "Categories",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Age",
                table: "Categories");
        }
    }
}
