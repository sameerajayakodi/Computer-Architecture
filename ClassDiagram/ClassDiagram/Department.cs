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

    }
}
