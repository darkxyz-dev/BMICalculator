using System;

namespace BMICalculaor
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your age: ");
            int age = Int32.Parse(Console.ReadLine());

            if (age <= 20)
            {
                Console.WriteLine("You are too young to use the calculator");
            }
            else if (age >= 60)
            {
                Console.WriteLine("You are too old to use the calculator");
            }
            else
            {
                double height;
                Console.WriteLine("enter your height: ");
                height = double.Parse(Console.ReadLine());
                Console.WriteLine($"your height is {height} meters");
                double eight;
                Console.WriteLine("Enter your weight:");
                double Weight = Int32.Parse(Console.ReadLine());
                double Result = Weight / (height * height);     
                Console.WriteLine($"Your weight is {Weight} .");



                if (Result <= 19)
                                    {
                                        Console.WriteLine("You are underweight.");
                                   }
                                else if (Result <= 25)
                                     {
                                        Console.WriteLine("Your weight is healthy");
                                    }
                               else if (Result >= 25 && Result <= 30)
                                   {
                                        Console.WriteLine("You are overweight.");
                                    }
                               else if (Result >= 30)
                                    {
                                         Console.WriteLine("You are obese.");
                            
                }
            }

        }




    }
    
}
