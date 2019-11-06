using System;

namespace Lab8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task: Write a program that will recognize invalid inputs when the user requests
            //information about students in a class.
            //What will the application do?
            //● Provide information about students in a class
            //● Prompt the user to ask about a particular student
            //● Give proper responses according to user-submitted information
            //● Ask if user would like to learn about another student
            //Build Specifications
            //1. Account for invalid user input with exceptions
            //2. Try to incorporate IndexOutOfRangeException and FormatException
            //Hints:
            //Make it easy for the user – tell them what information is available

            string[] name = {
                "Michele",  // [0]
                "Elena",    // [1]
                "Mary"      // [2]
            };
            string[] job = {
                "OT",                   // [0]
                "HR Generalist",        // [1]
                "Snack Shack Attendant" // [2]
            };
            string[] course = {
                "Physiology",               // [0]
                "Labor Relations",          // [1]
                "Zen and the Art of Nachos" // [2]
            };

            string response = "yes";  //NEED A YES -- OR OTHER VARIABLE NAME -- FOR THE LOOP TO CONTINUE DOWN TO THE WHILE

                while (response == "yes")  //NEED A YES FOR THE LOOP TO CONTINUE
                {
                    Console.WriteLine("Welcome to our C# class. Which student would you like to learn more about? (enter 0 - 2)");

                    try
                    {
                        string userInput = Console.ReadLine();
                        int input = int.Parse(userInput);  //is array number: 0, 1, 2  

                    // Console.WriteLine($"{ name[input]}"); // prints name: Michele, Elena or Shannon
                    Console.WriteLine($"Student {userInput} is {name[input]}. What would you like to know about {name[input]}? (enter “job” or “course”): ");
                    string otherinfo = Console.ReadLine();

                    if (otherinfo == "job")
                    {
                        Console.WriteLine($"{name[input]} is a {job[input]}.");
                    }
                    else if (otherinfo == "course")
                    {
                        Console.WriteLine($"{name[input]} is taking a course in {course[input]}");
                    }
                    else
                    {
                        throw new Exception("That input is incorrect. Please input 'job' or 'course'"); // USE AS A 'CATCH-ALL' FOR ANYTHING OTHER THAN 'JOB' OR 'COURSE'
                    }

                    Console.WriteLine($"Would you like to learn more about {name[input]} or another student? (Enter 'yes' or 'no') ");
                    response = Console.ReadLine();

                    if (response == "yes")
                    {
                        Console.WriteLine("Ok.");
                    }

                    else if (response == "no")
                    {
                        Console.WriteLine("Thank you for your inquiries. Goodbye.");
                    }
                    else
                    {
                        throw new Exception("That input is incorrect. Please input 'yes' or 'no' "); // USE AS A "CATCH-ALL" FOR ANYTHING OTHER THAN YES OR NO HERE (catch (Exception))
                    }
                }
                catch (IndexOutOfRangeException)  // IF NUBMER OTHER THAN 0 - 2
                {
                    Console.WriteLine("That student does not exist. Please try again. ");
                }
                catch (FormatException) // IF ANYTHING OTHER THAN AN INT
                {
                    Console.WriteLine("That data does not exist. You must use a student number from 0 - 2. Please try again.");
                }
                catch (Exception)  // FROM 'THROW NEW EXCEPTION' ABOVE AS A KIND OF CATCH ALL
                {
                    Console.WriteLine("Incorrect input. Answers are case sensitive and must be spelled exactly as specified. Please start over.");
                    response = "yes";  // THE 'YES' FORCES THE EXCEPTION TO LOOP BACK TO THE BEGINNING
                }
            }  // WHILE LOOP ENDS HERE
        }

    }
}
