using System;
using System.Collections.Generic;
using System.Text;

namespace Lessons.Lesson7
{
    public class AllCombo       

    {
        char[,] Mainfield;
        static public int Num, SizeX, SizeY;
        
        public AllCombo()
        {

        }
        public AllCombo(int num, int sizeX, int sizeY)
        {
            Num = num;
            SizeX = sizeX;
            SizeY = sizeY;
        }

      
        
        public char[][,] FindAllCombos(int num, int sizeX, int sizeY, char[,] mainArray)
        {
                   
            
            int stepY = sizeY - num; // сколько шагов по горизонтале (+1 = кол-во вписываемых квадратов)
            int stepX = sizeX - num; // сколько шагов по вертикале   (+1 = кол-во вписываемых квадратов)

            char[][,] allCombosArray = new char[(stepX+1)*(stepY+1)][,];

            int element = 0;

            for (int j = 0; j <= stepX; j++) // двигаем квадраты по вертикале
            {
                for (int i = 0; i <= stepY; i++) // Двигаем квадраты  по горизонтали
                {
                    int iNum = 0;
                    char[,] secondArray = new char[num, num];
                    for (int ie = i; ie < i + num; ie++)
                    {
                        int jNum = 0;
                        for (int je = j; je < j + num; je++)
                        {
                            secondArray[iNum, jNum] = mainArray[ie, je];
                            ++jNum;
                        }
                        iNum++;                       
                    }

                    allCombosArray[element] = secondArray; // Собираем в массив все возможные массивы

                    element++;                   
                }
            }

            return allCombosArray;

        }                
    }
}
