using System;
using System.Collections.Generic;
using System.Text;

namespace Lessons.Lesson7
{
    class Cross
    {

        static int SIZE_X = 5;
        static int SIZE_Y = 5;

        static char PLAYER_DOT = 'X';
        static char AI_DOT = 'O';
        static char EMPTY_DOT = '.';

        static char[,] field = new char[SIZE_Y, SIZE_X];

        static Random random = new Random();

        

        private static void InitField()
        {
            for (int i = 0; i < SIZE_Y; i++)
            {
                for (int j = 0; j < SIZE_X; j++)
                {
                    field[i, j] = EMPTY_DOT;
                }
            }
        }

        private static void PrintField(int num)
        {
            Console.Clear();
            Console.WriteLine("Победная комбинация: {0}", num);
            Console.WriteLine("-------");
            for (int i = 0; i < SIZE_Y; i++)
            {
                Console.Write("|");
                for (int j = 0; j < SIZE_X; j++)
                {
                    Console.Write(field[i, j] + "|");
                }
                Console.WriteLine();
            }
            Console.WriteLine("-------");
        }

        public static  void SetSym(int y, int x, char sym)
        {
            field[y, x] = sym;

        }

        private static bool IsCellValid(int y, int x)
        {
            if (x < 0 || y < 0 || x > SIZE_X - 1 || y > SIZE_Y - 1)
            {
                return false;
            }

            return field[y, x] == EMPTY_DOT;
        }

        private static bool IsFieldFull()
        {
            for (int i = 0; i < SIZE_Y; i++)
            {
                for (int j = 0; j < SIZE_X; j++)
                {
                    if (field[i, j] == EMPTY_DOT)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private static void playerMove()
        {
            int x, y;
            do
            {
                Console.WriteLine("Координат по строке ");
                Console.WriteLine("Введите координаты вашего хода в диапозоне от 1 до " + SIZE_Y);
                x = Int32.Parse(Console.ReadLine()) - 1;
                Console.WriteLine("Координат по столбцу ");
                Console.WriteLine("Введите координаты вашего хода в диапозоне от 1 до " + SIZE_X);
                y = Int32.Parse(Console.ReadLine()) - 1;
            } while (!IsCellValid(y, x));
            SetSym(y, x, PLAYER_DOT);
        }

        private static void AiMove()
        {
            int x, y;
            do
            {
                x = random.Next(0, SIZE_X);
                y = random.Next(0, SIZE_Y);
            } while (!IsCellValid(y, x));
            SetSym(y, x, AI_DOT);
        }

        
        static void Main(string[] args)
        {
            int num = 0 ;
            WinNumber wincombo = new WinNumber();
            wincombo.SetWinNumber(ref num, SIZE_X, SIZE_Y);

            Check al = new Check(num, SIZE_X, SIZE_Y);

            InitField();
            PrintField(num);

           
            do
            {
                playerMove();
                Console.WriteLine("Ваш ход на поле");
                al.ResetField(field);
                PrintField(num);
              
                if (al.CheckWinner(PLAYER_DOT))
                {
                    Console.WriteLine("Вы выиграли");
                    break;
                }
                else if (IsFieldFull()) break;
               

                if (! al.DisturbToWinPlayer(AI_DOT, AI_DOT))
                {
                    al.DisturbToWinPlayer(PLAYER_DOT, AI_DOT);
                }
                if (!al.DisturbToWinPlayer(PLAYER_DOT, AI_DOT))
                {
                    AiMove();
                }

                Console.WriteLine("Ход Компа на поле");
                al.ResetField(field);
                PrintField(num);

                al.CheckWinner(AI_DOT);
               
             
                if (al.CheckWinner(AI_DOT))
                {
                    Console.WriteLine("Выиграли Комп");
                    break;
                }
                else if (IsFieldFull()) break;
            } while (true);
            Console.WriteLine("!Конец игры!");
        }




    
    }
}
