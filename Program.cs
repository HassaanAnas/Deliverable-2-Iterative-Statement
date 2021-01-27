// HASSAAN ANAS
// 1/26/2021
// Iterative Statements
using System;

namespace Deliverable_2_Iterative_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask user to input data
            Console.WriteLine("Hello! Write an integer value between 1 and 100 to execute an Iterative Statement");

            //using try catch to avoid errors
            try
            {
                // this variable will gather input data
                string input = Console.ReadLine();

                // Data is parsed as an integer
                int value = int.Parse(input);

                // if else statement to set the range of 1 and 100
                if ((value >= 1) && (value <= 100))
                {


                    // using for loop
                    for (int n = 1; n <= value; n++)
                    {
                        Console.WriteLine("You have enetered  " + n.ToString() + ". This is the current integer value in the loop  " + n.ToString());
                    }

                    Console.WriteLine("Press any key to exit");
                    Console.ReadKey(true);

                }

                // using else statement to restrict the range
                else
                {
                    Console.WriteLine("Please insert an integer value between 1 and 100");
                }
            }

            
            // using catch statement to avoid errors
            catch
            {
                Console.WriteLine("Please inserth an integer between 1 and 100");
            }
        }

    }
}
