using Microsoft.EntityFrameworkCore.Migrations;

namespace Application.Data.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "KorisnickoIme",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Lastname",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserEmail",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Day",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Days = table.Column<int>(type: "int", nullable: false),
                    User = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Day", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FollowingVeza",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Original = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Following = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FollowingVeza", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Program1",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Duration = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Reps = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Likes = table.Column<int>(type: "int", nullable: false),
                    Saved = table.Column<int>(type: "int", nullable: false),
                    User = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Program1", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Workout",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Reps = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Workout", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DayVeza",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DayId = table.Column<int>(type: "int", nullable: false),
                    Program1Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DayVeza", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DayVeza_Day_DayId",
                        column: x => x.DayId,
                        principalTable: "Day",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DayVeza_Program1_Program1Id",
                        column: x => x.Program1Id,
                        principalTable: "Program1",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SavedVeza",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    User = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Program1Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SavedVeza", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SavedVeza_Program1_Program1Id",
                        column: x => x.Program1Id,
                        principalTable: "Program1",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProgramVeza",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Program1Id = table.Column<int>(type: "int", nullable: false),
                    WorkoutId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProgramVeza", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProgramVeza_Program1_Program1Id",
                        column: x => x.Program1Id,
                        principalTable: "Program1",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProgramVeza_Workout_WorkoutId",
                        column: x => x.WorkoutId,
                        principalTable: "Workout",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DayVeza_DayId",
                table: "DayVeza",
                column: "DayId");

            migrationBuilder.CreateIndex(
                name: "IX_DayVeza_Program1Id",
                table: "DayVeza",
                column: "Program1Id");

            migrationBuilder.CreateIndex(
                name: "IX_ProgramVeza_Program1Id",
                table: "ProgramVeza",
                column: "Program1Id");

            migrationBuilder.CreateIndex(
                name: "IX_ProgramVeza_WorkoutId",
                table: "ProgramVeza",
                column: "WorkoutId");

            migrationBuilder.CreateIndex(
                name: "IX_SavedVeza_Program1Id",
                table: "SavedVeza",
                column: "Program1Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DayVeza");

            migrationBuilder.DropTable(
                name: "FollowingVeza");

            migrationBuilder.DropTable(
                name: "ProgramVeza");

            migrationBuilder.DropTable(
                name: "SavedVeza");

            migrationBuilder.DropTable(
                name: "Day");

            migrationBuilder.DropTable(
                name: "Workout");

            migrationBuilder.DropTable(
                name: "Program1");

            migrationBuilder.DropColumn(
                name: "KorisnickoIme",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Lastname",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "UserEmail",
                table: "AspNetUsers");
        }
    }
}
