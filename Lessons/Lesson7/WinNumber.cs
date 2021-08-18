using System;
using System.Collections.Generic;
using System.Text;

namespace Lessons.Lesson7
{
    class WinNumber
    {
       public  WinNumber()
        {

        }
        public  int SetWinNumber( ref int num, int sizeX, int sizeY)
        {          
            do
            {
                Console.WriteLine("Введите число выйгрышной последовательности");
                num = Int32.Parse(Console.ReadLine());
            }
            while ( num > sizeX || num > sizeY);

            return num;
        }
    }
}
