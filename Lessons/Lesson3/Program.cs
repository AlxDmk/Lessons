using System;

namespace Lessons
{
    class Program3
    {
        static void Main(string[] args)
        {
           
            // 3. Написать слово в обратном порядке
            char[] hellо = "hello".ToCharArray();

            for (int i = hellо.Length - 1; i >= 0; --i)
            {
                Console.Write(hellо[i]);
            }


        }
    }
}
