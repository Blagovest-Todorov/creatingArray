using System;

namespace _30.arrays
{
    class Program
    {
        static void Main(string[] args)
            
        {
            int[] myInt = new int[10];
            int count = 0;
            myInt[3] = 3;
            myInt[4] = 5;

            for (int i = 0; i < myInt.Length; i++)
            {
                count++;
                Console.WriteLine(myInt[i]);
                
            }
            Console.WriteLine($" the number of elements is : {count}");
         
            
        }
    }
}
