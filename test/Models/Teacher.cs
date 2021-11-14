using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace test.Models
{
    public class Teacher
    {
        public int id { get; set; }

        public int Teacherid { get; set; }
        public MyUser teacheruser { get; set; }//needs sth
        public string FirstName { get; set; }
        public string lastName { get; set; }
        public int Salary { get; set; }
        public string PhoneNum { get; set; }
        public string Gender { get; set; }
        public string specialize { get; set; }
        public virtual ICollection<Student> Students { get; set; }
        public virtual ICollection<Course> Courses { get; set; }
    }
}
