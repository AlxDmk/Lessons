using System;

namespace Lessons
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите Ваше имя:");
            string userName = Console.ReadLine();
            Console.WriteLine($"Привет, {userName}! Сегодня: {DateTime.Today.ToString("D")}");
        }
    }
}
