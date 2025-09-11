using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AddmissionForm.Migrations
{
    /// <inheritdoc />
    public partial class AdmissionMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AdmissionForms",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Student_Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Fathers_Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Mothers_Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Course = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Percentage_In_HSC = table.Column<double>(type: "float", nullable: false),
                    Previous_College_Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Date_Of_Birth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Fees = table.Column<int>(type: "int", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdmissionForms", x => x.ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdmissionForms");
        }
    }
}
