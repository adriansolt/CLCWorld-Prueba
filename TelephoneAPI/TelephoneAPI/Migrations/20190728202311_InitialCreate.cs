using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TelephoneAPI.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Telephones",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    number = table.Column<string>(type: "varchar(9)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Telephones", x => x.id);
                });

                migrationBuilder.InsertData(
                    table: "TelephoneDB",
                    columns: new[] { "id", "number" },
                    values: new object[,]
                    {
                        { 1, "612345678" },
                        { 2, "667345698" },
                        { 3, "668956112" },
                        { 4, "6002546127" },
                        { 5, "667984452" },
                        { 6, "604571529" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Telephones");
        }
    }
}
