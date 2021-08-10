using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Diagnostics;


namespace Lessons.Lesson6
{
    class Main6
    {
        static void Main(string[] args)
        {

            //1.Написать консольное приложение Task Manager, которое выводит на экран запущенные процессы и позволяет завершить указанный процесс. Предусмотреть возможность завершения процессов с помощью указания его ID или имени процесса.
            //В качестве примера можно использовать консольные утилиты Windows tasklist и taskkill.

            Process[] allProcess = Process.GetProcesses();

            for (int i = 0; i < allProcess.Length; i++)
            {
                Console.WriteLine($"--> PID: { allProcess[i].Id}\tName: { allProcess[i].ProcessName } ");
            }

            Console.Write("Введите номер ID  процесса, который нужно закрыть");

            string stringIdToKill = Console.ReadLine();

            int idToKill = ConvertStringToInt(stringIdToKill);

            try
            {
                KillProcessById(idToKill);
            }

            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

            static int ConvertStringToInt(string data)
            {
                try
                {
                    int intData = Convert.ToInt32(data);
                    return intData;

                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                    return -1;
                }
            }
            static void KillProcessById(int id)
            {
                Process.GetProcessById(id).Kill();
            }

            //2.Напишите метод, на вход которого подаётся двумерный строковый массив размером 4х4,

            string[,] stringArray = new string[4, 4];
            
            try
            {
               FillMassive(stringArray);
               CheckSizeArray(stringArray);
              
               int sum =SumIntArray(stringArray);
               Console.WriteLine(sum);

            }
            catch(MyArraySizeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (MyArrayDataException ex)
            {
                Console.WriteLine(ex.Message);
            }

            static void CheckSizeArray(string[,] array)
            {
                if (array.GetLength(0) != 4 || array.GetLength(1)!=4)
                {
                    throw new MyArraySizeException("Неверный размер массива!");
                }           
                    
            }

            static int SumIntArray(string[,] array)

            {
                int sum = 0;
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        try { sum += Int32.Parse(array[i, j]); }
                        catch { throw new MyArrayDataException($"Невозможно сконвертировать ячейку[{i},{j}]") ; }
                    }

                }                 
                return sum;
            }

            static void FillMassive(string[,] array)
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        Console.Write($"X: {i},Y: {j} ->  ");
                        array[i, j] = Console.ReadLine();
                        
                    }                    
                }
            }

        }

    }
}
