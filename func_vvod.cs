using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOne
{
    class MainClass
    {
       public static int VvodChisla()
        {
            Console.Out.WriteLine("Vvedite chislo ");
            int chislo;
            while (!Int32.TryParse(Console.ReadLine(),out chislo))
            {
                Console.Out.WriteLine("Neverniy vvod, poprobuite eshe raz ");
            }
            return chislo;
        }


        public static void Main(string[] args)
        {

            Console.Out.WriteLine("Vi vveli {0}", VvodChisla());
            Console.ReadLine();
        }
    }
}
