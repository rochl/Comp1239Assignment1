using Microsoft.EntityFrameworkCore.Migrations;

namespace Assignment1.Migrations.Technician
{
    public partial class Technician : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Technicians",
                table: "Technicians");

            migrationBuilder.DeleteData(
                table: "Technicians",
                keyColumn: "techName",
                keyValue: "Jake");

            migrationBuilder.DeleteData(
                table: "Technicians",
                keyColumn: "techName",
                keyValue: "Mike");

            migrationBuilder.DeleteData(
                table: "Technicians",
                keyColumn: "techName",
                keyValue: "Miranda");

            migrationBuilder.DeleteData(
                table: "Technicians",
                keyColumn: "techName",
                keyValue: "Roman");

            migrationBuilder.AlterColumn<string>(
                name: "techName",
                table: "Technicians",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "techId",
                table: "Technicians",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Technicians",
                table: "Technicians",
                column: "techId");

            migrationBuilder.InsertData(
                table: "Technicians",
                columns: new[] { "techId", "techEmail", "techName", "techPhone" },
                values: new object[,]
                {
                    { 1, "Computer@gmail.com", "Roman", "416-258-6757" },
                    { 2, "Computer@gmail.com", "Miranda", "416-258-6757" },
                    { 3, "Computer@gmail.com", "Mike", "416-258-6757" },
                    { 4, "Computer@gmail.com", "Jake", "416-258-6757" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Technicians",
                table: "Technicians");

            migrationBuilder.DropColumn(
                name: "techId",
                table: "Technicians");

            migrationBuilder.AlterColumn<string>(
                name: "techName",
                table: "Technicians",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Technicians",
                table: "Technicians",
                column: "techName");
        }
    }
}
