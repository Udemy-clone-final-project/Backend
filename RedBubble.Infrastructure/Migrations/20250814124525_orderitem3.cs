using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RedBubble.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class orderitem3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Price",
                table: "OrderItem",
                newName: "UnitPrice");

            migrationBuilder.AddColumn<decimal>(
                name: "TotalPrice",
                table: "OrderItem",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TotalPrice",
                table: "OrderItem");

            migrationBuilder.RenameColumn(
                name: "UnitPrice",
                table: "OrderItem",
                newName: "Price");
        }
    }
}
