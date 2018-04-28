using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Person
    {
        public string Name { get; set; }
        int Age { get; set; }

        public Person (string name, int age)
        {
            Name = name;
            Age = age;
        }
    }

  class Student: Person
    {
        int Course;
       public bool Stipendia;

        public Student (int course, bool stipendia, string name, int age) : base (name, age)
        {
            Course = course;
            Stipendia = stipendia;
        }
    }

    class Program
    {
       
         
        static void Main(string[] args)
            
        {
            var Potok = new List<Student>(3);
            Potok.Add(new Student(5, true, "Masha", 19));
            Potok.Add(new Student(5, false, "Igor", 19));
            Potok.Add(new Student(5, true, "Ivan", 19));
            Potok.Add(new Student(5, false, "Irina", 19));
            int counter = 0;
            foreach (Student st in Potok)
            {
                if (!st.Stipendia)
            {
                    Console.Out.WriteLine("Student {0} bez stipendii!", st.Name);
                    counter++;
            }
                
            }
            Console.Out.WriteLine("Vsego bez stipendii {0} studentov", counter);
            Console.ReadKey();
        }
    }
}
