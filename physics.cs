using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOne
{
    class MainClass
    {
       public static float VvodChisla()
        {
            Console.Out.WriteLine("Vvedite chislo ");
            float chislo;
            while (!float.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture, out chislo))
            {
                Console.Out.WriteLine("Neverniy vvod, poprobuite eshe raz ");
            }
            return chislo;
        }
         class Snaryad
        {
            float NachalnayaCoordinataX;
            float NachalnayaCoordinataY;
            float Velocity;

            public Snaryad ()
            {
                NachalnayaCoordinataX = X;
                NachalnayaCoordinataY = Y;
                Velocity = V;
            }

            public Snaryad(float X, float Y, float V)
            {
                NachalnayaCoordinataX = X;
                NachalnayaCoordinataY = Y;
                Velocity = V;
            }

        }

        public static void Main(string[] args)
        {
            Snaryad Ball1 = new Snaryad(VvodChisla(), VvodChisla(), VvodChisla());
            Console.Out.WriteLine("Koordinaty 1go shara X = {0}, Y={1}, skorost V = {2}");
            Console.ReadLine();
        }
    }
}
