using System;

namespace CG4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = new int[6] { 1, 1, 2, 3, 5, 8 };
            intArray[0] = 1;
            intArray[1] = 1;
            intArray[2] = 2;
            intArray[3] = 3;
            intArray[4] = 5;
            intArray[5] = 8;
            
            for (int i = 0; i < intArray.Length; i++)
            {
                Console.WriteLine(intArray[i]);
            }
            Console.ReadLine();
                
        }
    }
}
