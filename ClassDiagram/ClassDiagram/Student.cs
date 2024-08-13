using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDiagram
{
    public class Student
    {
        public string StudentId {  get; set; }
        public string Name { get; set; }
        public string Major { get; set; }

        private List<Professor> Professors { get; set; }

        public Student(string studentId,string name , string major) {
            StudentId = studentId;
            Name = name;
            Major = major;
            Professors = new List<Professor>();
        }

        public void AddProfessor(Professor professor) { 
                Professors.Add(professor);
        }

        public List<Professor> GetProfessors() { 
          return Professors;
        }

    }
}
