using Microsoft.EntityFrameworkCore.Migrations;

namespace Assignment1.Migrations.Technician
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Technicians",
                columns: table => new
                {
                    techName = table.Column<string>(nullable: false),
                    techEmail = table.Column<string>(nullable: false),
                    techPhone = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Technicians", x => x.techName);
                });

            migrationBuilder.InsertData(
                table: "Technicians",
                columns: new[] { "techName", "techEmail", "techPhone" },
                values: new object[,]
                {
                    { "Roman", "Computer@gmail.com", "416-258-6757" },
                    { "Miranda", "Computer@gmail.com", "416-258-6757" },
                    { "Mike", "Computer@gmail.com", "416-258-6757" },
                    { "Jake", "Computer@gmail.com", "416-258-6757" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Technicians");
        }
    }
}
