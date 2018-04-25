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
            public float NachalnayaCoordinataX;
            public float NachalnayaCoordinataY;
            public float Velocity;

            public float Radius;

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
        public static bool Collision(float X1, float Y1, float R1, float X2, float Y2, float R2)
        {
            var length = (float)Math.Sqrt(Math.Pow((Y2 - Y1), 2) + Math.Pow((X2 - X1), 2));
            bool result;
            if (length < R2 + R1)
                
            {          
                result = true;                
            }
            else result = false;

            return result;

        }
        public static void Main(string[] args)
        {

            var Ball1 = new Snaryad(VvodChisla(), VvodChisla(), VvodChisla(), VvodChisla());
            Ball1.CoordinatesVelocity();
            var Pushka = new Snaryad(VvodChisla(), VvodChisla(), VvodChisla(), VvodChisla());
            Pushka.CoordinatesVelocity();
            bool result=Collision(Ball1.NachalnayaCoordinataX,Ball1.NachalnayaCoordinataY,Ball1.Radius,Pushka.NachalnayaCoordinataX,Pushka.NachalnayaCoordinataY,Pushka.Radius);
            if (result)
                Console.Out.WriteLine("Collision Detected!");
            else Console.Out.WriteLine("Collision not detected!");            

            Console.ReadLine();
        }
    }

}
