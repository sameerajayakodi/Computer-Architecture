using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDiagram
{
    public class University
    {
        public string Name {  get; set; }
        public string Location { get; set; }

        private List<Department> Departments { get; set; }

        public University(string name , string location) {
            Name = name;
            Location = location;
            Departments = new List<Department>();
        }

        public void AddDepartment(Department dep) { 
           Departments.Add(dep);
        }

        public List<Department> GetDepartments()
        {
            return Departments;
        }
    }
}
