using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public delegate int DelegateTest(int x, int y);

    public class Matematic
    {
          int x { get; set; }
          int y { get; set; }

        public int Sum(int x, int y)
        {
            return x + y;
        }

        public int Mult (int x, int y)
        {
            return x * y;
        }

        
    }
    class Program
    {
        static void Main(string[] args)
        {
            var M1 = new Matematic();
            Console.Out.WriteLine("Vvedite X");
            int x = Int32.Parse(Console.ReadLine());
            Console.Out.WriteLine("Vvedite Y");
            int y = Int32.Parse(Console.ReadLine());
            DelegateTest Del1;
            if (Console.ReadLine() == "+")
            { Del1 = M1.Sum; Console.Out.WriteLine(Del1.Invoke(x, y)); } 
            else if (Console.ReadLine()=="*")
            {
                Del1 = M1.Mult; Console.Out.WriteLine(Del1.Invoke(x, y));
            }
            
            Console.ReadLine();
            
        }
    }
}
