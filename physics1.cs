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
            while (!float.TryParse(Console.ReadLine(), out chislo))
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
            float Radius;
            public static int count = 0;

            public Snaryad()
            {
                count++;
            }

            public Snaryad(float X, float Y, float V, float R)
            {
                NachalnayaCoordinataX = X;
                NachalnayaCoordinataY = Y;
                Velocity = V;
                Radius = R;
                count++;
            }

            public void CoordinatesVelocity()
            {

                Console.Out.WriteLine("Koordinaty {0} shara X = {1}, Y = {2}, Velocity V = {3}, Radius R = {4}", count, NachalnayaCoordinataX, NachalnayaCoordinataY, Velocity, Radius);
            }
        }

        public static void Main(string[] args)
        {
            var Ball1 = new Snaryad(VvodChisla(), VvodChisla(), VvodChisla(),VvodChisla());
            Ball1.CoordinatesVelocity();
            var Pushka = new Snaryad(VvodChisla(), VvodChisla(), VvodChisla(),VvodChisla());
            Pushka.CoordinatesVelocity();

            Console.ReadLine();
        }
    }
}