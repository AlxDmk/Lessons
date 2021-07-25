using System;

namespace Lessons
{
    class Program2

    {
        static void Main(string[] args)
        {
            // Запрос минимальной и максимальной температуры и вывод срденей за сутки

            Console.WriteLine("Введите минимальную температуру за сутки");
            int minTemp = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите максимальную температуру за сутки");
            int maxTemp = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Средняя температура за сутки составляет: {(maxTemp + minTemp) / 2}");
           

            // Запросить номер текущего месяца и вывести его название. Определить, является число четным ил нечетным

            Console.Clear();
            Console.WriteLine("Введите номер текущего месяца");
            int num = Convert.ToInt32(Console.ReadLine());
            int currentMonth = DateTime.Now.Month;          
            if (num >=1 && num <= 12 )
            {
                string res = num % 2 == 0 ? "четный" : "нечетный";
                if (num != currentMonth)
                {
                    Console.WriteLine($"Вы уверены, что сейчас {(Month)num} ? Этот месяц : {res}");
                }
                else { Console.WriteLine($"Вы не потерялись! Сейчас {(Month)currentMonth} и он {res}"); }
            }
            else
            {
                Console.WriteLine("Вы ввели что-то, но точно не номер месяца");
            }





        }

        enum Month
        {
            Январь   = 1,
            Февраль  = 2,
            Март     = 3,
            Апрель   = 4,
            Май      = 5,
            Июнь     = 6,
            Июль     = 7,
            Август   = 8,
            Сентябрь = 9,
            Октябрь  = 10,
            Нояюрь   = 11,
            Декабрь  = 12

        }
    }

}
