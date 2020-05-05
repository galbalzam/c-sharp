using System;


namespace Matala
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
            

            // Question 2
            // 2.1
            Console.WriteLine("Create Car: ");            
            Car car = new Car();
            // 2.2
            Console.WriteLine("Print Start Details: ");
            car.printSpeed();
            // 2.3
            Console.WriteLine("Enter Speed You Want Drive: ");
            int spd = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < spd; i++)
            {
                car.upSpeed();
            }
            // 2.4
            Console.WriteLine("The Speed is: ");
            car.printSpeed();
            // 2.5
            Console.WriteLine("Down Speed 2KMH:");
            car.downSpeed(); car.downSpeed();
            // 2.6
            Console.WriteLine("The Speed is: ");
            car.printSpeed();
            Console.WriteLine("Stop Car:");
            car.stop();
            car.printSpeed();


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
