using System;

namespace lesson_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int lengthOfArray = Convert.ToInt32(Console.ReadLine());
            int NumToMul = Convert.ToInt32(Console.ReadLine());

            int[]arr= new int[lengthOfArray];

            Console.WriteLine($"Num of elemet: {lengthOfArray},num to mul:{NumToMul}");
            
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = i * NumToMul;
                Console.Write(arr[i]+ ", ");
            }

    
            Console.ReadKey();
        }

    }
}
