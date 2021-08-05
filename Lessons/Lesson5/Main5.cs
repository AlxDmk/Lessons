using Lessons.Lesson5;
using System;
using System.IO;

namespace Lessons
{
    class Main5
    {
        static void Main (string[] args)
        {
            //1.Ввести с клавиатуры произвольный набор данных и сохранить его в текстовый файл.
            /////////////////////////////////////////////////////////////////////////////////////

            MakeFirstTask();

            static void MakeFirstTask()
            {
                string filename = "startup.txt";
                File.WriteAllText(filename, String.Empty);

                Console.WriteLine("Введите произвольный набор символов:");
                string info = Console.ReadLine();
                File.AppendAllText(filename, info);                
            }           
          

            //2.Написать программу, которая при старте дописывает текущее время в файл «startup.txt».
            //////////////////////////////////////////////////////////////////////////////////////////
            
            WriteDate();

            static void WriteDate()
            {
                string date = DateTime.Now.ToString("T");
                File.AppendAllText("startup.txt",date);
                File.AppendAllText("startup.txt", Environment.NewLine);
            }



            //3.Ввести с клавиатуры произвольный набор чисел(0...255) и записать их в бинарный файл.
            ////////////////////////////////////////////////////////////////////////////////////////

            Console.WriteLine("Введите произвольное колличество чисел от 0 до 255 через запятую. (!) Неправильные числа будут удалены");

            string str = Console.ReadLine();
            string[] stringArray = str.Split(' ');

            int[] intArray = new int[stringArray.Length];

            for (int i = 0; i < stringArray.Length; i++)
            {
                intArray[i] = Convert.ToInt32(stringArray[i]); // формируем int массив                  
            }

            // CheckByteSuitable(ref intArray); // запускаем int массив на проверку соответствия от 0 до 255


            static void CheckByteSuitable(ref int[] array)
            {  // Метод отсеивания введенных  чисел < 0 и  > 255

                int count = 0;
                for (int i = 0; i < array.Length; i++)   //Определяем размер массива с введенными числами от 0 до 255
                {
                    if (array[i] > 255 || array[i] < 0)
                    {
                        count += 1;
                    }
                }

                byte[] correctByteArray = new byte[array.Length - count];
                int newSize = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] >= 0 && array[i] < 256)
                    {
                        correctByteArray[newSize] = (byte)array[i]; //Формируем  byte  массив для записи
                        newSize++;
                    }
                }
                // RecordByteFile(correctByteArray);
            }

            static void RecordByteFile(byte[] byteArray)
            {

                File.WriteAllBytes("bytes.bin", byteArray);
            }

            //4.Создать класс "Сотрудник" с полями: ФИО, должность, email, телефон, зарплата, возраст;
            //////////////////////////////////////////////////////////////////////////////////////////


            Person[] persArray = new Person[5]; 
            persArray[0] = new Person("Ivanov Ivan", "Engineer", "ivivan@mailbox.com", "892312312", 30000, 30); 
            persArray[1] = new Person("Stepanov Ivan", "Captain", "iviva@mailbox.com", "892332524", 40000, 35);
            persArray[2] = new Person("Petrov Stepan", "Second Pilot", "iviv@mailbox.com", "8927895", 45000, 40);
            persArray[3] = new Person("Stepanov Andrey", "Board Assistant", "ivi@mailbox.com", "892785689", 50000, 42);
            persArray[4] = new Person("Jhon Doe", "Board Marshal", "marshal@mailbox.com", "892722222", 50000, 47);

            ChoosePerson(40);

            void ChoosePerson(int x)
            {
                for (int i = 0; i < persArray.Length; i++)
                {
                    if (persArray[i].Age >= x)
                    {
                        persArray[i].Info();
                        Console.WriteLine();

                    }
                }
            }
        }
        
    }
}