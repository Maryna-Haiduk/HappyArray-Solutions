using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTheoryProject.OOP
{
    internal class Student : Person
    {
        public string Classes { get; set; }
        public Student(string name, int age, string classes) : base(name, age) 
        {
            Classes = classes;
        }

        public override void Greet()
        {
            Console.WriteLine($"Hello my name is {Name}, and I'm a student");
        }
        
        public void GoToClasses()
        {
            Console.WriteLine($"I’m going to {Classes}");
        }

        public void ShowStudentInfo()
        {
            Greet();
            ShowAge();
            GoToClasses();
        }
    }
}
