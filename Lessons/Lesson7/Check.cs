using System;
using System.Collections.Generic;
using System.Text;

namespace Lessons.Lesson7
{
    public class Check : AllCombo
    {
        char Sym;
        char[,] MainField;
        char[][,] MatrixOfOpp;
        
        public Check(int num, int sizex, int sizey)
            :base (num, sizex,  sizey)
        {
            Num = num;
            SizeX = sizex;
            SizeY = sizey;            

        }
        
        public void  ResetField(char [,] mainField)
        {
            MainField = mainField;
            
            MatrixOfOpp = FindAllCombos(Num, SizeX, SizeY, MainField);            
        }

        public bool CheckWinner(char sym)
        {
            Sym = sym;
            CheckWin chckWn = new CheckWin();
            bool result = chckWn.CheckWinner(Sym, MatrixOfOpp, Num);
            return result;
        }

        public bool DisturbToWinPlayer(char sym, char symAI)
        {
           bool disturbed = TimeX.TryDisturb(sym,symAI, MainField, Num);
           return disturbed;
        }

    }
}
