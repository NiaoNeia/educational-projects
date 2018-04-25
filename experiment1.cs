using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        public static void Vvod (out float result)
        {
            Console.WriteLine("Vvedite chislo ");
            while (!float.TryParse(Console.ReadLine(), out result))
                {
                Console.WriteLine("Neverniy Vvod ");
            }

        }
         
        static void Main(string[] args)
            
        {
            
            Vvod(out float n);
            Console.WriteLine(n);
            Console.ReadKey();
        }
    }
}
