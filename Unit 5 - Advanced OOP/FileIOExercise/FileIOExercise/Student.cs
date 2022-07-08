using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIOExercise
{
    internal class Student
    {
        public string Name { get; set; }
        public int Grade { get; set; }
        public int Age { get; set; }
        public Student(string _name, int _grade, int _age)
        {
            Name = _name;
            Grade = _grade;
            Age = _age;
        }
    }
}
