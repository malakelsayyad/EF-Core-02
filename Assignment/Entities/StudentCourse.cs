using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Entities
{
    public class StudentCourse
    {
        public int StudId { get; set; }
        public int CrsId { get; set; }
        public string Grade { get; set; }
    }
}
