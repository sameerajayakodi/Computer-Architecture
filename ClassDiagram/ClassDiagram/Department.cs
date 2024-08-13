using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDiagram
{
    public class Department
    {
        public string Name { get;set; }
        public string Code { get; set; }

        private List<Student> Students {  get; set; }
        private List<Professor> Professors { get; set; }
        private List<Course> Courses { get; set; }

        public Department(string name,string code) { 
          Name = name;
          Code = code;
          Students = new List<Student>();
          Professors = new List<Professor>();
          Courses = new List<Course>();
        }

        public void AddCourse(Course course) { 
           Courses.Add(course);
        }

        public List<Course> GetCourses()
        {
            return Courses;
        }

        public void AddProfessor(Professor professor) { 
            Professors.Add(professor);
        }

        public List<Professor> GetProfessors() { 
          return Professors;
        }

        public void AddStudent(Student student) { 
          Students.Add(student);    
        }

        public List<Student> GetStudents() { 
           return Students;
        }


    }
}
