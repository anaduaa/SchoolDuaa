using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace test.Models
{
    public class Student
    {


        public int Studentid { get; set; }
        public MyUser studentuser { get; set; }//needs sth
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Course Courses { get; set; }
        public Teacher Teacher { get; set; }

        public int id { get; set; }
    }
}
