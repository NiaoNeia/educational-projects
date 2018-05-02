using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    abstract class Person
    {
        public string Name { get; set; }
        protected int Age { get; set; }

        public Person (string name, int age)
        {
            Name = name;
            Age = age;
        }
        abstract public void Print();
        
    }

  class Student: Person
    {
        int Course;
       public bool Stipendia;
        public static int counter = 1;

        public Student (int course, bool stipendia, string name, int age) : base (name, age)
        {
            Course = course;
            Stipendia = stipendia;
            counter++;
        }
        public override void Print ()
        {
            Console.WriteLine(Name +Age);
        }
    
    }
   
    class Program
    {   public static void VvodCursa (out int kurs)
        {
            Console.WriteLine("Vvedite kuts {0} studenta", Student.counter);
            while (!Int32.TryParse(Console.ReadLine(), out kurs))
                {
                Console.Out.WriteLine("Neverniy Vvod");
            }
        }
        public static void VvodStipendia(out bool st)
        {
            Console.WriteLine("Vvedite stipendia {0} studenta", Student.counter);
            while (!bool.TryParse(Console.ReadLine(), out st))
            {
                Console.Out.WriteLine("Neverniy Vvod");
            }
        }
        public static void VvodImeni(out string name)
        {
            Console.WriteLine("Vvedite imya {0} studenta", Student.counter);
            name = Console.ReadLine();
            
        }
        public static void VvodAge(out int age)
        {
            Console.WriteLine("Vvedite vozrast {0} studenta", Student.counter);
            while (!Int32.TryParse(Console.ReadLine(), out age))
            {
                Console.Out.WriteLine("Neverniy Vvod");
            }
        }
        public static bool Exit()
        {
            string e = Console.ReadLine();
            if (e == "e")
            { return true; }
            return false;
        }

        static void Main(string[] args)
            
        {
            var Potok = new List<Student>(3);
            Console.Out.WriteLine("Vvodite elementi classov, dlya zavershenia vvoda najmite e");


            while (!Exit())
            {
                int course;
                bool st;
                string name;
                int age;
                VvodCursa(out course);
                VvodStipendia(out st);
                VvodImeni(out name);
                VvodAge(out age);
                Potok.Add(new Student(course, st, name, age));

            }
            foreach (Student stud in Potok)
            {
                stud.Print();
            }

            Console.ReadKey();
        }
    }
}
