using Microsoft.EntityFrameworkCore.Migrations;

namespace Controle.Data.Migrations
{
    public class _00000000000000_CadSchema : Migrations
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cad",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false) .Annotation("SqlServer.Identity", "1, 1"),
                    Login = table.Column<string>(Type:"nvarchar(max)", nullable: true),
                    Nome = table.Column<string>(Type: "nvarchar(max)", nullable: true),
                    Perfil = table.Column<string>(Type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cad", x => x.Id);
                });

            protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cad");


        }
}
