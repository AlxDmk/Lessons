﻿using System;

namespace Lessons
{
    class Lesson4
    {
        static void Main(string[] args)
        {
            //1.Написать метод GetFullName(string firstName, string lastName, string patronymic), принимающий на вход ФИО в разных аргументах и возвращающий объединённую строку с ФИО.Используя метод, написать программу, выводящую в консоль 3–4 разных ФИО.

            static void GetFullName(string firstName, string lastName, string patronymic)
            {
                Console.WriteLine($" Ваше ФИО: {firstName} {lastName} {patronymic}");
            }

            string[][] fios = new string[3][];
            fios[0] = new string[3] { "Иван", "Иванович", "Иванов" };
            fios[1] = new string[3] { "Степан", "Аркадьевич", "Андреев" };
            fios[2] = new string[3] { "Александр", "Валентинович", "Дымченко" };

            for (int i = 0; i < fios.Length; i++)
            {
                string firstName = fios[i][0];
                string lastName = fios[i][1];
                string patronymic = fios[i][2];

                GetFullName(firstName, lastName, patronymic);
            }


            ////2.Написать программу, принимающую на вход строку — набор чисел, разделенных пробелом, и возвращающую число — сумму всех чисел в строке.Ввести данные с клавиатуры и вывести результат на экран.

            Console.WriteLine("Введите данные");
            string lineEntered = Console.ReadLine();
            string[] lineArray = lineEntered.Split(' ');
            int sum = 0;
            for (int i = 0; i < lineArray.Length; i++)
            {
                sum += Convert.ToInt32(lineArray[i]);
            }

            Console.Write($"Сумма: {sum}");


            

            ////3.Написать метод по определению времени года.На вход подаётся число – порядковый номер месяца.На выходе — значение из перечисления(enum) — Winter, Spring, Summer, Autumn.Написать метод, принимающий на вход значение из этого перечисления и возвращающий название времени года(зима, весна, лето, осень). Используя эти методы, ввести с клавиатуры номер месяца и вывести название времени года.Если введено некорректное число, вывести в консоль текст «Ошибка: введите число от 1 до 12».
            ////4. (*) Написать программу, вычисляющую число Фибоначчи для заданного значения рекурсивным способом.
            ////5. (**) Есть предложение String str1 = " Предложение один Теперь предложение два Предложение три"; нужно превести строку к нормально виду " Предложение один. Теперь предложение два. Предложение три";
        }
    }
}
