using System;


namespace Matala3Q1
{
    class Program
    {

        static void Main(string[] args)
        {
            cookies c1 = new cookies();
            c1.Gluten = true;
            c1.NumOfEggs = 5;
            c1.NumOfFlour = 5.2f;
            c1.NumOfSugar = 1.5f;

            cookies c2 = new cookies();
            c2.Gluten = false;
            c2.NumOfEggs = 2;
            c2.NumOfFlour = 7.2f;
            c2.NumOfSugar = 4.5f;


            Console.WriteLine(printDetails(c1));
            Console.WriteLine(printDetails(c2));

            c1.NumOfSugar = 9.6f;
            Console.WriteLine(printDetails(c1));
            Console.WriteLine(printDetails(c2));
            c1 = c2;

            c2.NumOfEggs = 7;
            Console.WriteLine(printDetails(c1));
            Console.WriteLine(printDetails(c2));


            Console.ReadKey();
        }



            public static string printDetails(cookies c)
            {
                {
                    string res = "Details of cookie";
                    res += $"Gloten:{c.Gluten } \n";
                    res += $"NumOfSugar:{c.NumOfSugar}\n";
                    res += $"NumOfEggs:{c.NumOfEggs}\n";
                    res += $"NumOfFlour:{c.NumOfFlour}\n";

                    return res;
                }
            }

            
            
        }
    
}
