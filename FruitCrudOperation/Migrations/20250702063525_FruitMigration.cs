using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FruitCrudOperation.Migrations
{
    /// <inheritdoc />
    public partial class FruitMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Fruits",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FruitName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Quantity_In_Kg = table.Column<int>(type: "int", nullable: false),
                    Price_Per_Kg = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fruits", x => x.ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Fruits");
        }
    }
}
