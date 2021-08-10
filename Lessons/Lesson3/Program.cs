//using System;

//namespace Lessons
//{
//    //class Program3
//    //{
//    //    //static void Main(string[] args)
//    //    //{

//    //    //    //
//    //    //    // 1.Написать программу, выводящую элементы двумерного массива по диагонали.
//    //    //    //
//    //    //    // Очень много повторяющегося кода.Если подскажите, как сократить код, то буду благодарен

//    //    //    char[,] arr = new char[11, 11];  // 
//    //    //    int iArr = arr.GetLength(0);
//    //    //    int jArr = arr.GetLength(1);


//    //    //    char number = '*';           // Заполняем массив значениями

//    //    //    for (int i = 0; i <= arr.GetLength(0) - 1; i++)
//    //    //    {
//    //    //        for (int j = 0; j <= arr.GetLength(1) - 1; j++)
//    //    //        { arr[i, j] = number; }
//    //    //    }

//    //    //    if (iArr == jArr)            // Если массив имеет одинаковое колличесво столбцов и строк
//    //    //    {
//    //    //        for (int i = 0; i <= iArr - 1; i++)
//    //    //        {
//    //    //            for (int j = 0; j <= jArr - 1; j++)
//    //    //            {
//    //    //                if (i == j)
//    //    //                {
//    //    //                    Console.Write(arr[i, j]);
//    //    //                }
//    //    //                else { Console.Write("  "); }
//    //    //            }
//    //    //            Console.WriteLine();
//    //    //        }
//    //    //    }

//    //    //    else if (iArr % 2 != 0 && jArr % 2 != 0)     // Если массив имеет разное нечетное колличесво столбцов и строк
//    //    //    {
//    //    //        for (int i = 0; i <= iArr - 1; i++)
//    //    //        {
//    //    //            for (int j = 0; j <= jArr - 1; j++)
//    //    //            {
//    //    //                if (i == j && i == 0 || i == iArr - 1 && j == jArr - 1 || i == iArr / 2 && j == jArr / 2)
//    //    //                {
//    //    //                    Console.Write(arr[i, j]);
//    //    //                }

//    //    //                else { Console.Write("  "); }
//    //    //            }
//    //    //            Console.WriteLine();
//    //    //        }
//    //    //    }

//    //    //    else                                       // Если массив имеет разное колличесво столбцов и строк (сочетание четный/нечетный)
//    //    //    {
//    //    //        for (int i = 0; i <= iArr - 1; i++)
//    //    //        {
//    //    //            for (int j = 0; j <= jArr - 1; j++)
//    //    //            {
//    //    //                if (i == 0 && j == 0 || i == iArr - 1 && j == jArr - 1)
//    //    //                {
//    //    //                    Console.Write(arr[i, j]);
//    //    //                }
//    //    //                else { Console.Write("  "); }

//    //    //            }
//    //    //            Console.WriteLine();
//    //    //        }
//    //    //    }

//    //    //    //
//    //    //    // 2.Написать программу «Телефонный справочник»: создать двумерный массив 5х2, хранящий список телефонных контактов: первый элемент хранит имя контакта, второй — номер телефона/ email.

//    //    //    //

//    //    //    string[,] yPages = new string[5, 2];
//    //    //    yPages[0, 0] = "Контакт";
//    //    //    yPages[0, 1] = "номер телефона/email";

//    //    //    int i = 1;
//    //    //    while (i < yPages.GetLength(0))
//    //    //    {
//    //    //        Console.WriteLine($"Введите имя контакта № {i}");
//    //    //        yPages[i, 0] = Console.ReadLine();
                                
//    //    //        Console.WriteLine($"Введите телефон /email контакта № {i}");
//    //    //        yPages[i, 1] = Console.ReadLine();
//    //    //        i++;
//    //    //    }

//    //    //    Console.WriteLine("Спасибо! Книга создана");

//    //    //    for (int x = 0; x < yPages.GetLength(0); x++)
//    //    //    {
//    //    //        for (int y = 0; y < yPages.GetLength(1); y++)
//    //    //        {
//    //    //            Console.Write($"{yPages[x, y]}     ");
                    
//    //    //        }
//    //    //        Console.WriteLine();
//    //    //    }


//    //    //    //
//    //    //    // 3.Написать слово в обратном порядке
//    //    //    //
//    //    //    char[] hellо = "hello".ToCharArray();

//    //    //    for (int i = hellо.Length - 1; i >= 0; --i)
//    //    //    {
//    //    //        Console.Write(hellо[i]);
//    //    //    }


//    //    //    ///
//    //    //    /// 4. Морской бой (на примере трех кораблей)
//    //    //    ///

//    //    //    string[] map = new string[100];        // объявил одномерный массив поля 10х10

//    //    //    int[][] k = new int[3][];              // зубчатый массив  кораблей

//    //    //    k[0] = new int[1] { 00 };              // 
//    //    //    k[1] = new int[2] { 22, 23 };          //  задаю поячеечную позицию и размер кораблей
//    //    //    k[2] = new int[3] { 25, 35, 45 };      //

//    //    //    for (int x = 0; x < map.Length; x++)   // Заполняю весь массив map нулями
//    //    //    {
//    //    //        map[x] = "0";
//    //    //    }

//    //    //    for (int i = 0; i < k.Length; i++)
//    //    //    {                                       //список самих кораблей значение 
//    //    //        for (int t = 0; t < k[i].Length; t++)
//    //    //        {
//    //    //            int zn = k[i][t];
//    //    //            map[zn] = "X";
//    //    //        }
//    //    //    }

//    //    //    int m = 10;                             // предобразовываем в двумерный масси и выводим в консоль
//    //    //    string[,] matrix = new string[10, 10];

//    //    //    for (int i = 0, ctr = 0; i < m; i++)
//    //    //    {
//    //    //        for (int j = 0; j < m; j++, ctr++)
//    //    //        {
//    //    //            matrix[i, j] = map[ctr];
//    //    //            Console.Write($"{matrix[i, j]}  ");
//    //    //        }
//    //    //        Console.WriteLine();
//    //    //    }

//    //    //}
//    //}
//}
