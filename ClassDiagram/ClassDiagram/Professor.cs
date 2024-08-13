using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDiagram
{
    public class Professor
    {

       public string ProfessorId {  get; set; }
       public string Name { get; set; }
       public string Specialization {  get; set; }
        private List<Course> Courses;

        public Professor(string professorId , string name , string specialization) {
            
            ProfessorId = professorId;

            Name = name;
            Specialization = specialization;
            Courses = new List<Course>();

        }

        public void AddCourse(Course course) 
        {
            Courses.Add(course);
        }

        public List<Course> GetCourses()
        {
            return Courses; 
        }


    }
}
