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
                //Console.WriteLine("Dlina"+ length + " " + Y2 + " " + Y1);       
                result = true;               
            }
            else result = false; /*Console.WriteLine("Dlina"+length+" " +Y2+" "+Y1);*/

            return result;
            
        }
        public static void ParametriCollisii(float SnaryadX1, float SnaryadY1, float SnaryadR, float SnaryadVelocity, float PushkaX1, float PushkaY1, float PushkaR, float PushkaVelocity)
        {
            float T=0f;
            double Angle = Math.PI/4;

            while (!Collision(SnaryadX1, SnaryadY1, SnaryadR, PushkaX1, PushkaY1, PushkaR) && ((SnaryadX1 + SnaryadR) < (PushkaX1 - PushkaR)))
            {
                for (Angle = 0; Angle < Math.PI / 2; Angle += 0.01)
                {
                    for (T = 1; T <= 100 / SnaryadVelocity; T += 1f)
                    {
                        SnaryadX1 = SnaryadVelocity * T+SnaryadX1;
                        PushkaX1 = PushkaX1 - (PushkaVelocity * T * (float)Math.Sin(Angle));                      
                        PushkaY1 = PushkaY1 - ((float)Math.Sqrt(Math.Pow(PushkaVelocity, 2) * Math.Pow(T, 2) - Math.Pow(PushkaVelocity, 2) * Math.Pow(T, 2) * Math.Pow(Math.Sin(Angle), 2)));
                        Console.WriteLine(Angle+" "+PushkaX1+" "+PushkaY1+" "+SnaryadX1+" "+SnaryadY1);
                    }
                }
            }
            if (Collision(SnaryadX1, SnaryadY1, SnaryadR, PushkaX1, PushkaY1, PushkaR))
            {
                Console.WriteLine("Stolknovenie proizoshlo cherez vremya {0}!\n Koordonati Snaryada {1} i {2}, skorost {3}\n Koordinati pushki {4}, {5}, skorost {6}, ugol povorota {7}", T, SnaryadX1, SnaryadY1, SnaryadVelocity, PushkaX1, PushkaY1, PushkaVelocity, Angle);
            }
            else Console.WriteLine("Stolknovenia ne budet");
        }
        public static void Main(string[] args)
        {

            var Ball1 = new Snaryad(VvodChisla(), VvodChisla(), VvodChisla(), VvodChisla());
            Ball1.CoordinatesVelocity();
            var Pushka = new Snaryad(VvodChisla(), VvodChisla(), VvodChisla(), VvodChisla());
            Pushka.CoordinatesVelocity();

            ParametriCollisii(Ball1.NachalnayaCoordinataX, Ball1.NachalnayaCoordinataY, Ball1.Radius, Ball1.Velocity, Pushka.NachalnayaCoordinataX, Pushka.NachalnayaCoordinataY, Pushka.Radius, Pushka.Velocity);
               

            Console.ReadLine();
        }
    }

}
