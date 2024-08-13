using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDiagram
{
    public class Course
    {
       public string Title { get; set; }

       public string CourseId { get; set; }
       public string Credits { get; set; }

        private List<Student> Students { get; set; }
        private Professor Professor { get; set; }

        public Course(string title,string courseId , string credits) {
            Title = title;
            CourseId = courseId;
            Credits = credits;
            Students = new List<Student>();
           
        }


        public void SetProfessor(Professor professor) { 
           Professor = professor;
        }

        public Professor GetProfessor() { 
           return Professor;
        }

        public void EnrollStudent( Student student)
        {
            Students.Add(student);
        }

        public List<Student> GetStudets()
        {

        return Students; 
        
        }
    }
}
