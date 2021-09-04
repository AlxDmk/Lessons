using System;
using System.Collections.Generic;
using System.Text;

namespace Lessons.Lesson7
{
    class TimeX
    {
        public TimeX()
        {

        }

        public static bool TryDisturb(char sym, char symAI, char[,] mainField, int num)
        {
            bool avoidBool = false; 
            for (int i = 0; i < mainField.GetLength(0); i++)
            {
                for (int j = 0 ; j < mainField.GetLength(1); j++)
                {
                    char[] avoidArray   = new char[num];
                    int count = 0;
                    int step = 0;
                    for (int k = 0; k < avoidArray.Length; k++)
                    {   

                        avoidArray[k] = mainField[i, k+step];
                        
                        if (avoidArray [k] == sym)
                        {
                            count++;
                        }

                        if (k == avoidArray.Length - 1 && count == num-1)
                        {
                            for (int l = 0; l < avoidArray.Length; l++)
                            {
                                avoidArray[l] = mainField[i, l+step];
                                if (avoidArray[l]!= sym && avoidArray[l]!=symAI)
                                {                                
                                    Cross.SetSym (i, l, symAI);
                                    avoidBool = true;
                                }
                            }
                        }
                        
                    }
                    step++;
                }
            }

            if (!avoidBool)
            {
                
                for (int j = 0; j < mainField.GetLength(1); j++)
                {
                    for (int i = 0; i < mainField.GetLength(0); i++)
                    {
                        char[] avoidArray = new char[num];
                        int count = 0;
                        int step = 0;
                        for (int k = 0; k < avoidArray.Length; k++)
                        {

                            avoidArray[k] = mainField[k, i + step];

                            if (avoidArray[k] == sym)
                            {
                                count++;
                            }

                            if (k == avoidArray.Length - 1 && count == num - 1)
                            {
                                for (int l = 0; l < avoidArray.Length; l++)
                                {
                                    avoidArray[l] = mainField[l,i + step ];
                                    if (avoidArray[l] != sym && avoidArray[l] != symAI)
                                    {
                                        Cross.SetSym(l, i + step,  symAI);
                                        avoidBool = true;
                                    }
                                }
                            }

                        }
                        step++;
                    }
                }
            }

            return avoidBool;
            
        }
    }
}
