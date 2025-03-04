﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Entities
{
    public class Instructor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }   
        public string Name { get; set; }
        public double? Bonus { get; set; }
        public double Salary { get; set; }
        public string Address { get; set; }
        public double? HourRate { get; set; }

        public int DepartmentDeptId { get; set; } //Fk
        public ICollection<CourseInstructor> courseInstructors { get; set; } = new HashSet<CourseInstructor>();

    }
}
