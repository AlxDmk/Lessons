using System;

namespace Lessons
{
    class Program3
    {
        static void Main(string[] args)
        {   
            
            ///
            /// 1.Написать программу, выводящую элементы двумерного массива по диагонали.
            /// 

            char[,] arr = new char[5, 9];
            int iArr = arr.GetLength(0);
            int jArr = arr.GetLength(1);
                      
        
            char number = '*';           // Заполняем массив значениями

            for (int i = 0; i <= arr.GetLength(0)-1; i++)     
            {
                for (int j = 0; j <= arr.GetLength(1) - 1; j++)
                { arr[i, j] = number; }
            }

            if (iArr == jArr)            // Если массив имеет одинаковое колличесво столбцов и строк
            {
                for (int i = 0; i <= iArr - 1; i++)
                {
                    for (int j = 0; j <= jArr - 1; j++)
                    {
                        if (i == j)
                        {
                            Console.Write(arr[i, j]);
                        }
                        else { Console.Write("  "); }
                    }
                    Console.WriteLine();
                }
            }

            else if (iArr%2 != 0 && jArr%2 !=0)     // Если массив имеет разное нечетное колличесво столбцов и строк
            {
                for (int i = 0; i <= iArr-1; i++)
                {
                    for (int j = 0; j <= jArr-1; j++)
                    {
                        if (i== j && i==0 || i==iArr-1&& j== jArr-1 || i == iArr/2 && j== jArr/2)
                        {
                            Console.Write(arr[i, j]);
                        }
                        else { Console.Write("  "); }                        
                    }
                    Console.WriteLine();
                }
            }

            else                                       // Если массив имеет разное колличесво столбцов и строк (сочетание четный/нечетный)
            {
                for (int i = 0; i <= iArr - 1; i++)
                {
                    for (int j = 0; j <= jArr - 1; j++)
                    {
                        if (i == 0 && j == 0 || i == iArr - 1 && j == jArr - 1 )
                        {
                            Console.Write(arr[i, j]);
                        }
                        else { Console.Write("  "); }

                    }
                    Console.WriteLine();
                }
            }

            

            // 3. Написать слово в обратном порядке
            char[] hellо = "hello".ToCharArray();

            for (int i = hellо.Length - 1; i >= 0; --i)
            {
                Console.Write(hellо[i]);
            }


        }
    }
}
