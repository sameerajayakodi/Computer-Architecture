﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDiagram
{
    public class UndergraduateStudent:Student
    {
        public int Year { get; set; }

        public UndergraduateStudent(string studentId, string name, string major,int year)
            : base(studentId, name, major)
        { 
         

            Year = year;
        }

        public void DeclareMajor(string major)
        {
            Major = major;
        }

        public override string ToString()
        {
            return base.ToString() + $",Year : {Year}";
        }
    }
}
