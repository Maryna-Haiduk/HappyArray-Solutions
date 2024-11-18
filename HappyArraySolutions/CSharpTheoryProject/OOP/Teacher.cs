using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTheoryProject.OOP
{
    internal class Teacher : Person
    {
        public string Subject { get; set; }
        public Teacher(string name, int age, string subject) : base(name, age)
        {
            Subject = subject;
        }

        public override void Greet()
        {
            Console.WriteLine($"Hello my name is {Name}, and I'm a teacher of {Subject}");
        }

        public void Explain()
        {
            string subject = Subject;
            Console.WriteLine($"Explanation begins {subject}");
        }

        public void ShowTeacherInfo()
        {
            Greet();
            ShowAge();
        }
    }
}
