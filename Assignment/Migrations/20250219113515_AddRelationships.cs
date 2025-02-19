using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment.Migrations
{
    /// <inheritdoc />
    public partial class AddRelationships : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DepartmentDeptId",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CourseId",
                table: "StudCourse",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StudentId",
                table: "StudCourse",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DepartmentDeptId",
                table: "Instructors",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TopicId",
                table: "Courses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CourseId",
                table: "CourseInstructor",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "InstructorId",
                table: "CourseInstructor",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Students_DepartmentDeptId",
                table: "Students",
                column: "DepartmentDeptId");

            migrationBuilder.CreateIndex(
                name: "IX_StudCourse_CourseId",
                table: "StudCourse",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_StudCourse_StudentId",
                table: "StudCourse",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Instructors_DepartmentDeptId",
                table: "Instructors",
                column: "DepartmentDeptId");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_TopicId",
                table: "Courses",
                column: "TopicId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseInstructor_CourseId",
                table: "CourseInstructor",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseInstructor_InstructorId",
                table: "CourseInstructor",
                column: "InstructorId");

            migrationBuilder.AddForeignKey(
                name: "FK_CourseInstructor_Courses_CourseId",
                table: "CourseInstructor",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CourseInstructor_Instructors_InstructorId",
                table: "CourseInstructor",
                column: "InstructorId",
                principalTable: "Instructors",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Topics_TopicId",
                table: "Courses",
                column: "TopicId",
                principalTable: "Topics",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Instructors_Departments_DepartmentDeptId",
                table: "Instructors",
                column: "DepartmentDeptId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudCourse_Courses_CourseId",
                table: "StudCourse",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_StudCourse_Students_StudentId",
                table: "StudCourse",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Departments_DepartmentDeptId",
                table: "Students",
                column: "DepartmentDeptId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseInstructor_Courses_CourseId",
                table: "CourseInstructor");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseInstructor_Instructors_InstructorId",
                table: "CourseInstructor");

            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Topics_TopicId",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Instructors_Departments_DepartmentDeptId",
                table: "Instructors");

            migrationBuilder.DropForeignKey(
                name: "FK_StudCourse_Courses_CourseId",
                table: "StudCourse");

            migrationBuilder.DropForeignKey(
                name: "FK_StudCourse_Students_StudentId",
                table: "StudCourse");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Departments_DepartmentDeptId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_DepartmentDeptId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_StudCourse_CourseId",
                table: "StudCourse");

            migrationBuilder.DropIndex(
                name: "IX_StudCourse_StudentId",
                table: "StudCourse");

            migrationBuilder.DropIndex(
                name: "IX_Instructors_DepartmentDeptId",
                table: "Instructors");

            migrationBuilder.DropIndex(
                name: "IX_Courses_TopicId",
                table: "Courses");

            migrationBuilder.DropIndex(
                name: "IX_CourseInstructor_CourseId",
                table: "CourseInstructor");

            migrationBuilder.DropIndex(
                name: "IX_CourseInstructor_InstructorId",
                table: "CourseInstructor");

            migrationBuilder.DropColumn(
                name: "DepartmentDeptId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "CourseId",
                table: "StudCourse");

            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "StudCourse");

            migrationBuilder.DropColumn(
                name: "DepartmentDeptId",
                table: "Instructors");

            migrationBuilder.DropColumn(
                name: "TopicId",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "CourseId",
                table: "CourseInstructor");

            migrationBuilder.DropColumn(
                name: "InstructorId",
                table: "CourseInstructor");
        }
    }
}
