using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Entities
{
    internal class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public DateTime Duration { get; set; }
        public int TopicId { get; set; }

        public ICollection<StudentCourse> studentCourses { get; set; } = new HashSet<StudentCourse>();

        public ICollection<CourseInstructor> courseInstructors { get; set; } = new HashSet<CourseInstructor>();

    }
}
