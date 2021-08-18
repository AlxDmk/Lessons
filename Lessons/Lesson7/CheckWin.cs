using System;
using System.Collections.Generic;
using System.Text;

namespace Lessons.Lesson7
{
    public class CheckWin 

    {
        public CheckWin()
        {

        }

        public bool CheckWinner(char sym, char [][,]array, int num)
        {
            bool result =  false;
         
            for (int i = 0; i < array.Length; i++)
            {
               
                for (int j = 0; j < num; j++)
                {

                    int count = 0;
                    for (int k = 0; k < num; k++)
                    {
                        if (array[i][j,k] == sym)
                        {
                            count++;                            
                        }                       
                                                
                    }
                    if (count == num)
                    {
                        result = true;
                        break;
                    }                                     
                }                              
             }

            if (result == false)
            {
                for (int i = 0; i < array.Length; i++)
                {

                    for (int j = 0; j < num; j++)
                    {

                        int count = 0;
                        for (int k = 0; k < num; k++)
                        {
                            if (array[i][k, j] == sym)
                            {
                                count++;
                            }

                        }
                        if (count == num)
                        {
                            result = true;
                            break;
                        }
                    }
                }
            }

            if (result == false)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    int count = 0;
                    for (int j = 0; j < num; j++)
                    {

                        
                        for (int k = 0; k < num; k++)
                        {
                            if (k == j)
                            {
                                if (array[i][k, j] == sym)
                                {
                                    count++;
                                }
                            }               
                         
                        }                        
                    }
                    if (count == num)
                    {
                        result = true;
                        break;
                    }
                }
            }
            if (result == false)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    int count = 0;
                    for (int j = 0; j < num; j++)
                    {
                        for (int k = num-1; k >=0; k--)
                        {
                            if (k == num-j-1)
                            {
                                if (array[i][num - j - 1,j ] == sym)
                                {
                                    count++;
                                }
                            }

                        }
                    }
                    if (count == num)
                    {
                        result = true;
                        break;
                    }
                }
            }

            return result;
        }

    }
}
