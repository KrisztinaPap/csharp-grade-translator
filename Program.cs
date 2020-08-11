using System;

namespace c_grade_translator_assignment_assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            
            /*
                Title: C# Grade Translator
                Purpose: To practice comparison operators, data types, type conversion, and decisions in C#.
                
                Author: Krisztina Pap
                Date of Last Edit: Aug 11, 2020
            */

            // Explain user how to use program
            Console.WriteLine("This program takes in a numeric grade value (an integer between 0 and 100) and returns the corresponding letter grade (F to A+).");

            // Declare variables
            int userInput = 1;
            int grade = 0; 
           
            

            do
            {
                Console.WriteLine("What would you like to do?\n---------------\n1. Enter a grade\n2. Quit");
                userInput = int.Parse(Console.ReadLine());
                if ( userInput == 1 )
                {
                    // Prompt user for a value
                    Console.WriteLine("Enter a numeric grade value (an integer between 0 and 100): ");
                    try
                    {
                        grade = int.Parse(Console.ReadLine());
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        grade = 200;
                    }                    

                    // Compare grade entered to values in table & output results
                    if ( grade >= 0 && grade <= 100)
                    {
                        if ( grade >= 97  )
                        {
                            Console.WriteLine("A numeric grade {0} is the same as an A+", grade);
                        }
                        else if ( grade >= 90)
                        {
                            Console.WriteLine("A numeric grade {0} is the same as an A", grade);
                        }
                        else if ( grade >= 85)
                        {
                            Console.WriteLine("A numeric grade {0} is the same as an A-", grade);
                        }
                        else if ( grade >= 80)
                        {
                            Console.WriteLine("A numeric grade {0} is the same as an B+", grade);
                        }
                        else if ( grade >= 75)
                        {
                            Console.WriteLine("A numeric grade {0} is the same as an B", grade);
                        }
                        else if ( grade >= 70)
                        {
                            Console.WriteLine("A numeric grade {0} is the same as an B-", grade);
                        }
                        else if ( grade >= 65)
                        {
                            Console.WriteLine("A numeric grade {0} is the same as an C+", grade);
                        }
                        else if ( grade >= 60)
                        {
                            Console.WriteLine("A numeric grade {0} is the same as an C", grade);
                        }
                        else if ( grade >= 55)
                        {
                            Console.WriteLine("A numeric grade {0} is the same as an C-", grade);
                        }
                        else if ( grade >= 50)
                        {
                            Console.WriteLine("A numeric grade {0} is the same as an D", grade);
                        }
                        else
                        {
                            Console.WriteLine("A numeric grade {0} is the same as an F", grade);
                        }
                    }
                    
                    else
                    {
                        Console.WriteLine("Invalid input. Please try again!");
                    }
                }

            } while ( userInput != 2 );

        }
    }
}
