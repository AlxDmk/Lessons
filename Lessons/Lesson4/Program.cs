using System;

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
            fios[2] = new string[3] { "Александр", "Валентинович", "Димченко" };

            for (int i = 0; i < fios.Length; i++)
            {
                string firstName = fios[i][0];
                string lastName = fios[i][1];
                string patronymic = fios[i][2];

                GetFullName(firstName, lastName, patronymic);
            }


            //2.Написать программу, принимающую на вход строку — набор чисел, разделенных пробелом, и возвращающую число — сумму всех чисел в строке.Ввести данные с клавиатуры и вывести результат на экран.

            Console.WriteLine("Введите данные");
            string lineEntered = Console.ReadLine();
            string[] lineArray = lineEntered.Split(' ');
            int sum = 0;
            for (int i = 0; i < lineArray.Length; i++)
            {
                sum += Convert.ToInt32(lineArray[i]);
            }

            Console.Write($"Сумма: {sum}");




            ////3.Написать метод по определению времени года.На вход подаётся число – порядковый номер месяца.На выходе — значение из перечисления(enum) — Winter, Spring, Summer, Autumn. 
            ///Написать метод, принимающий на вход значение из этого перечисления и возвращающий название времени года(зима, весна, лето, осень). Используя эти методы, ввести с клавиатуры номер месяца и вывести название времени года.
            ///Если введено некорректное число, вывести в консольтекст «Ошибка: введите число от 1 до 12».

            
            AskMonthNumber();

            static void AskMonthNumber()
            {
                Console.WriteLine("Введите подрядковый номер месяца");
                int monthNumber = Convert.ToInt32(Console.ReadLine());

                CheckNumber(monthNumber);
            }

            static void CheckNumber(int number)
            {
                if (number > 12 || number < 1)
                {
                    Console.WriteLine("Ошибка: введите число от 1 до 12");
                    AskMonthNumber();
                }
                else
                {
                    FindSeason(number);
                }
            }

            static void FindSeason(int data)
            {
                int season;
                switch (data)
                {
                    case 1:
                    case 2:
                    case 12:
                        season = (int)Seasons.Winter;

                        break;
                    case 3:
                    case 4:
                    case 5:
                        season = (int)Seasons.Spring;

                        break;
                    case 6:
                    case 7:
                    case 8:
                        season = (int)Seasons.Summer;
                        break;
                    default:
                        season = (int)Seasons.Autmn;
                        break;
                }

                TranslateSeason(season);
             }

            static void TranslateSeason(int data) {
                string answer;
                switch (data)
                {
                    case 0:
                        answer = "Зима";
                        break;
                    case 1:
                        answer = "Весна";
                        break;
                    case 2:
                        answer = "Лето";
                        break;
                    default:
                        answer = "Осень";
                        break;
                }

                Console.WriteLine(answer);
            }


            ////4. (*) Написать программу, вычисляющую число Фибоначчи для заданного значения рекурсивным способом.

            Console.WriteLine("Введите число Фиббоначи");
            int number = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                Console.Write($"{FibbonateThis(i)}, ");
            }

            static int FibbonateThis(int data)
            {
                return (data ==1 || data == 0) ? 1 : FibbonateThis(data - 1) + FibbonateThis(data - 2);
            }

            //5. (**) Есть предложение String str1 = " Предложение один Теперь предложение два Предложение три"; нужно превести строку к нормально виду " Предложение один. Теперь предложение два. Предложение три";

            string  phrase = " Предложение один Теперь предложение два Предложение три";
            
            EditPhrase(phrase);
           
           static void EditPhrase(string data)
            {             
               
                for (int i = 2; i < data.Length; i++)
                {
                    if (char.IsUpper(data[i]))
                    {                     
                        data = data.Remove(i-1,1).Insert(i-1,char.ToString('.'));                     
                      
                    }                    
                }

                Console.WriteLine(data);               
            }
        

        }
            enum Seasons { Winter, Spring, Summer, Autmn }
    }
}
