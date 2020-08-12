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
                Date of Last Edit: Aug 12, 2020
            */

            // Explain user how to use program
            Console.WriteLine("This program takes in a numeric grade value (an integer between 0 and 100) and returns the corresponding letter grade (F to A+).");

            // Declare variables
            int userInput = 1;
            double grade = 0; 
            string letterGrade = "";
           
            

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
                        grade = double.Parse(Console.ReadLine());
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
                            letterGrade = "A+";
                        }
                        else if ( grade >= 90)
                        {
                            letterGrade = "A";
                        }
                        else if ( grade >= 85)
                        {
                            letterGrade = "A-";
                        }
                        else if ( grade >= 80)
                        {
                            letterGrade = "B+";
                        }
                        else if ( grade >= 75)
                        {
                            letterGrade = "B";
                        }
                        else if ( grade >= 70)
                        {
                            letterGrade = "B-";
                        }
                        else if ( grade >= 65)
                        {
                            letterGrade = "C+";
                        }
                        else if ( grade >= 60)
                        {
                            letterGrade = "C";
                        }
                        else if ( grade >= 55)
                        {
                            letterGrade = "C-";
                        }
                        else if ( grade >= 50)
                        {
                            letterGrade = "D";
                        }
                        else
                        {
                            Console.WriteLine("A numeric grade {0} is the same as an F", grade);
                        }
                        Console.WriteLine("A numeric grade {0} is the same as a {1}.", grade, letterGrade);
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
