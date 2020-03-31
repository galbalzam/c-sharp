using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            string[][] matrix3 = new string[3][];
            matrix3[0] = new string[] { "main", "up", "sub" };
            matrix3[1] = new string[] { "down", "center", "up" };
            matrix3[2] = new string[] { "sub", "down", "main" };
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    Console.Write("[" + matrix3[i][j] + "]");
                }
                Console.WriteLine();
            }
        }
    }
}
