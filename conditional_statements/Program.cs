using System;

namespace Conditional_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user for input
            Console.WriteLine("How many years of experience do you have in professional programming?");
            /*
               Use the try catch block to validate user input.
               If the user provides bad input, the catch block
               will handle the error and a message will be displayed.
            */
            try
            {
                // This variable will gather the user input
                string input = Console.ReadLine();
                /* 
                   This variable will be used to store sales
                   after the input variable is parsed to decimal
                 */
                int exp = int.Parse(input);
                // This variable will be used to calculate the bonus
                 /* 
                    This IF/ELSE IF/ELSE statement is used to conditionally
                    test the users input. Various options are available
                    depending on the amount entered by the user. Then, insde of each IF/ELSE IF/ELSE
                    there is a switch conditional statement that displays a message depending
                    on the number of years experience in sales entered by the user. 
                 */
                if (exp == 0)
                {
                    Console.WriteLine("Need lots of practice");
                    // Now get the number of years the user has been in sales
                    
                }
                else if ((exp > 0) && (exp < 2))
                {
                    Console.WriteLine("Looks like you have little experience");
                }
                else if (exp == 2)
                {
                    Console.WriteLine("Wow! YOv've been doing this for a little while");
                }
                else if (exp > 2)
                {
                    Console.WriteLine("You are an expert");
                }
                else
                {
                    Console.WriteLine("please enter a valid input");
                }
            } // end of try
            catch
            {
                Console.WriteLine("Please enter valid years of experience");
                Console.ReadKey(true);
            } // end of catch     
        } // end of Main
    } // end of class
} // end of namespace
