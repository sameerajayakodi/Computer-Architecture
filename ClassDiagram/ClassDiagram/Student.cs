using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ClassDiagram
{
    public class Student
    {
        public string StudentId {  get; set; }
        public string Name { get; set; }
        public string Major { get; set; }

       private List<Course> Courses { get; set; }

        public Student(string studentId,string name , string major) {
            StudentId = studentId;
            Name = name;
            Major = major;
            Courses = new List<Course>();
                
        }


        public void EnrollCourse(Course course) { 
           Courses .Add(course);
        }

        public List<Course> GetCourses() { 
            return Courses;
        }
        

        



    }
}
