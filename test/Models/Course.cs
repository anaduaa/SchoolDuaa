using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace test.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        public string Name { get; set; }
        public int Grade { get; set; }
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }
    }
}
