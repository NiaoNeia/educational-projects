using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{   
   
    class Program

    {
        interface IPryam
        {
            List<float> Coordinates { get; set; }
        }

        interface IDot
        {
            float X1 { get; set; }
            float Y1 { get; set; }
        }

        class Pryamougolnik:IPryam
        {
            public List<float> Coordinates { get; set; }
            public Pryamougolnik ()
            {
                Coordinates = new List<float>();
            }
        }

        class Dot: IDot
        {
            public float X1 { get; set; }
            public float Y1 { get; set; }
        }

        public static float VvodKkordinat ()
        {
            Console.Out.WriteLine("Vvedite koordinati ");
            float n;
            while (!float.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("Neberniy vvod");
            }
            return n;
        }

        public static void RaycastLine (float X1, float Y1, float X2, float Y2, float XDot, float YDot, out int n)
        {
            float A = (Y1 - Y2) / (X1 - X2);
            float B = Y1 - A * X1;
            //Console.WriteLine("Pryamaya y={0}*x+{1}", A, B);
            float YPer = A * XDot + B;
            n = 0;
            if (XDot < Math.Max(X2, X1) && XDot > Math.Min(X2, X1) && YPer < Math.Max(Y2, Y1) && YPer > Math.Min(Y2, Y1)&&YPer>YDot)
            {
                //Console.WriteLine("Tochka peresekla gran {0}", n);
                n++;
            }
            //else Console.WriteLine("Tochka ne peresekla gran {0}", n);
        }
        static void Main(string[] args)
            
        {
            var Pr1 = new Pryamougolnik();
            Console.WriteLine("Vvod koordinat dlya pryamougolnika");
            for (int i = 0; i<8; i++)
            {
                Pr1.Coordinates.Add(VvodKkordinat());
                
            }
            Console.WriteLine("Vvod koordinat tochki");
            var Dot1 = new Dot { X1 = VvodKkordinat(), Y1 = VvodKkordinat() };
            int n,m,k,l;
            RaycastLine(Pr1.Coordinates[0], Pr1.Coordinates[1], Pr1.Coordinates[2], Pr1.Coordinates[3], Dot1.X1, Dot1.Y1, out n);
            RaycastLine(Pr1.Coordinates[2], Pr1.Coordinates[3], Pr1.Coordinates[4], Pr1.Coordinates[5], Dot1.X1, Dot1.Y1, out m);
            RaycastLine(Pr1.Coordinates[4], Pr1.Coordinates[5], Pr1.Coordinates[6], Pr1.Coordinates[7], Dot1.X1, Dot1.Y1, out k);
            RaycastLine(Pr1.Coordinates[6], Pr1.Coordinates[7], Pr1.Coordinates[0], Pr1.Coordinates[1], Dot1.X1, Dot1.Y1, out l);
            if ((n + m + k + l) % 2 == 0)
            {
                Console.WriteLine("Tochka vne chetirehugolnika");
            }
            else Console.Out.WriteLine("Tochka vnutri chetirehugolnika");

            Console.ReadKey();
        }
    }
}
