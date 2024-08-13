using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDiagram
{
    public class GraduateStudent:Student
    {
        public string ReasearchTopic { get; set; }
        public GraduateStudent(string studentId, string name, string major, string researchTopic)
            :base(studentId,name,major) {

            ReasearchTopic = researchTopic;
        }

        public void ApplyForTA()
        {
            Console.WriteLine("Apply for TA");
        }

        public override string ToString()
        {
            return base.ToString() + $",ReasearchTopic {ReasearchTopic}";
        }
    }
}
