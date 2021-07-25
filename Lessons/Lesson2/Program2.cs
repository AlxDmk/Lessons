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
            Console.WriteLine($"Средня температура за сутки составляет: {(maxTemp+minTemp)/2}");

        }
    }
}
