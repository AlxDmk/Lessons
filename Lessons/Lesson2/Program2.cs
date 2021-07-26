using System;

namespace Lessons
{
    class Program2

    {
        static void Main(string[] args)
        {
            // 1 . Запрос минимальной и максимальной температуры и вывод срденей за сутки

            Console.WriteLine("Введите минимальную температуру за сутки");
            int minTemp = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите максимальную температуру за сутки");
            int maxTemp = Convert.ToInt32(Console.ReadLine());
            int av = (maxTemp + minTemp) / 2;
            Console.WriteLine($"Средняя температура за сутки составляет: {av}");
            Console.ReadKey();
           

            // 2.1  Запросить номер ТЕКУЩЕГО месяца и вывести его название. Определить, является число четным ил нечетным

            Console.Clear();
            Console.WriteLine("Введите номер текущего месяца");
            int num = Convert.ToInt32(Console.ReadLine());
            int currentMonth = DateTime.Now.Month;          
            if (num >=1 && num <= 12 )
            {
                string res = num % 2 == 0 ? "четный" : "нечетный";

                if (num != currentMonth) { 
                    Console.WriteLine($"Вы уверены, что сейчас {(Month)num} ? Этот месяц : {res}"); 
                }
                else { 
                    Console.WriteLine($"Вы не потерялись! Сейчас {(Month)currentMonth} и он {res}"); 
                }
            }
            else
            {
                Console.WriteLine("Вы ввели что-то, но точно не номер месяца");
            }

            Console.ReadKey();

            // 2.2 Запросить номер месяца и вывести его название. (любого месяца). Если зимние месяцы и средняя температура >0, то вывести сообщение "Дождливая зима"

            Console.Clear();
            Console.WriteLine("Введите номер ЛЮБОГО месяца");
            int num1 = Convert.ToInt32(Console.ReadLine());
                       
                switch (num1)
                {
                    case 1:
                        Console.WriteLine(Month.Январь);
                        break;
                    case 2:
                        Console.WriteLine(Month.Февраль);
                        break;
                    case 3:
                        Console.WriteLine(Month.Март);
                        break;
                    case 4:
                        Console.WriteLine(Month.Апрель);
                        break;
                    case 5:
                        Console.WriteLine(Month.Май);
                        break;
                    case 6:
                        Console.WriteLine(Month.Июнь);
                        break;
                    case 7:
                        Console.WriteLine(Month.Июль);
                        break;
                    case 8:
                        Console.WriteLine(Month.Август);
                        break;
                    case 9:
                        Console.WriteLine(Month.Сентябрь);
                        break;
                    case 10:
                        Console.WriteLine(Month.Октябрь);
                        break;
                    case 11:
                        Console.WriteLine(Month.Ноябрь);
                        break;
                    case 12:
                        Console.WriteLine(Month.Декабрь);
                        break;
                    default:
                        Console.WriteLine("Вы ввели некорректные данные!");
                        break;                        
                }

            if (num1 == 12 || num1 == 1 || num1 == 2 && av > 0) {Console.WriteLine("Дождливая зима");}

            


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
            Ноябрь   = 11,
            Декабрь  = 12

        }
    }

}
