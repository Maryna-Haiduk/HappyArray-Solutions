using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTheoryProject.OOP
{
    internal class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public virtual void Greet()
        {
            Console.WriteLine($"Hello my name is {Name}");
        }
        public void ShowAge() 
        {
            Console.WriteLine($"I am {Age} years old");
        }
    }
}
