using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApp5
{
    class Program
    {class Predictable
        {
            public Dictionary<int, string> Phrases = new Dictionary<int, string>()
            {
                [1]= "Ждет тебя вскоре поездка на море.",
                [2]= "Пусть радости слеза прольется, скоро старый друг вернется!",
                [3]= "Долой и злость, и месть, получишь радостную весть.",
                [4]= "Жди заката, жди рассвета, жди от милого привета.",
                [5]= "Веселей смотри вперед, там богатство тебя ждет.",
                [6]= "Подожди немного, ждет тебя дорога.",
                [7]= "Появится вдруг у тебя новый друг.",
                [8]= "Солнце вновь и счастье вновь - встретишь новую любовь.",
                [9]= "К следующей субботе жди успех в работе.",
                [10]= "Будет у тебя всегда в доме вкусная еда.",
                [11]= "Ожидая плохого события, не крутите пуговицу: она обязательно оторвется.",
                [12]= "Переходя дорогу, посмотрите по сторонам - есть вероятность встретить свою судьбу.",
                [13]= "Заходите к начальнику с левой ноги - и вас ждет повышение по службе.",
                [14]= "Улыбайтесь всегда! И никто не назовет вас мрачным человеком. Молчите! И никто не назовет занудой.",
                [15]= "Купите книгу, которая вам совершенно не нравится, - и вы найдете ответы на все вопросы.",
                [16]= "Этой ночью звезды расположились на небе так, что вам светит все, что вы так давно мечтали получить.",
                [17]= "Сегодня для вас самый лучший день! Как и все остальные!",
                [18]= "Ночь сегодняшних звезд совершенно особенная и поможет получше осветить дорогу к давним планам",
                [19]="Держи нос по ветру, а хвост – пистолетом.",
                [20]= "Вам пора отдохнуть."
            };
            public void Choise ()
            {
                Random Rnd = new Random();
                Console.Out.WriteLine("Ваше предсказание....");
                Thread.Sleep(1000);
                Console.Out.WriteLine(".....");
                Thread.Sleep(1000);
                Console.Out.WriteLine(".......Оракул думает.......");
                Thread.Sleep(1000);
                Console.Out.WriteLine("Итак, ваше предсказание.....{0}", Phrases[Rnd.Next(1, 3)]);
                Console.ReadLine();
            }
            public static string Zapros ()
            {
                Console.Out.WriteLine("Хотите получить предсказание? y/n");
                while (true)
                {
                    var symb = Console.ReadLine(); 
                    if (symb.GetHashCode() == "y".GetHashCode())
                    {
                        return symb;
                    }
                    else if (symb.GetHashCode() == "n".GetHashCode()) Environment.Exit(0);
                    else { Console.Out.WriteLine("Неверный ввод"); }
                }
            }
        }
        static void Main(string[] args)
        {
            var pred1 = new Predictable();
            Predictable.Zapros();
            pred1.Choise();
        }
    }
}
