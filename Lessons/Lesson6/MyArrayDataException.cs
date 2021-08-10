using System;
using System.Collections.Generic;
using System.Text;

namespace Lessons.Lesson6
{
    [Serializable]

   


    public class MyArrayDataException : Exception
    {
        public MyArrayDataException(string message)
            : base(message)
           
        {
            

           
        }
    }
}
