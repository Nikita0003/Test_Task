using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Test_Task.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Q1 = table.Column<bool>(nullable: false),
                    Q2 = table.Column<bool>(nullable: false),
                    Q3 = table.Column<bool>(nullable: false),
                    Q4 = table.Column<bool>(nullable: false),
                    Q5 = table.Column<bool>(nullable: false),
                    Q6 = table.Column<bool>(nullable: false),
                    Q7 = table.Column<bool>(nullable: false),
                    Q8 = table.Column<bool>(nullable: false),
                    Q9 = table.Column<bool>(nullable: false),
                    Q10 = table.Column<bool>(nullable: false),
                    Sum = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
