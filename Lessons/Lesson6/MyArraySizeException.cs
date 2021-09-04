using System;
using System.Collections.Generic;
using System.Text;


namespace Lessons.Lesson6
{
    [Serializable]
    public class MyArraySizeException : Exception
    {
        //public  Message { get; }
        //public int Length { get; }
        public MyArraySizeException()
        {
        }

        public MyArraySizeException(string message)
            :base (message)
        {
           
        }
       
        
    }
}
