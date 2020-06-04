using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class InitDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Course",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Course", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Teatcher",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teatcher", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "University",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_University", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CoursesUniversity",
                columns: table => new
                {
                    UniversityId = table.Column<int>(nullable: false),
                    CourseId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoursesUniversity", x => new { x.CourseId, x.UniversityId });
                    table.ForeignKey(
                        name: "FK_CoursesUniversity_Course_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Course",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CoursesUniversity_University_UniversityId",
                        column: x => x.UniversityId,
                        principalTable: "University",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TeatcherCourse",
                columns: table => new
                {
                    TeatcherId = table.Column<int>(nullable: false),
                    CourseId = table.Column<int>(nullable: false),
                    UniversityId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeatcherCourse", x => new { x.TeatcherId, x.CourseId });
                    table.ForeignKey(
                        name: "FK_TeatcherCourse_Course_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Course",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TeatcherCourse_Teatcher_TeatcherId",
                        column: x => x.TeatcherId,
                        principalTable: "Teatcher",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TeatcherCourse_University_UniversityId",
                        column: x => x.UniversityId,
                        principalTable: "University",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TeatchersUniversity",
                columns: table => new
                {
                    UniversityId = table.Column<int>(nullable: false),
                    TeatcherId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeatchersUniversity", x => new { x.TeatcherId, x.UniversityId });
                    table.ForeignKey(
                        name: "FK_TeatchersUniversity_Teatcher_TeatcherId",
                        column: x => x.TeatcherId,
                        principalTable: "Teatcher",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TeatchersUniversity_University_UniversityId",
                        column: x => x.UniversityId,
                        principalTable: "University",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CoursesUniversity_UniversityId",
                table: "CoursesUniversity",
                column: "UniversityId");

            migrationBuilder.CreateIndex(
                name: "IX_TeatcherCourse_CourseId",
                table: "TeatcherCourse",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_TeatcherCourse_UniversityId",
                table: "TeatcherCourse",
                column: "UniversityId");

            migrationBuilder.CreateIndex(
                name: "IX_TeatchersUniversity_UniversityId",
                table: "TeatchersUniversity",
                column: "UniversityId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CoursesUniversity");

            migrationBuilder.DropTable(
                name: "TeatcherCourse");

            migrationBuilder.DropTable(
                name: "TeatchersUniversity");

            migrationBuilder.DropTable(
                name: "Course");

            migrationBuilder.DropTable(
                name: "Teatcher");

            migrationBuilder.DropTable(
                name: "University");
        }
    }
}
