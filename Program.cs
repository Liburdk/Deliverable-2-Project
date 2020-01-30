/*
  Writer: Kaley Liburd
  Due Date: 01/30/2020
  Comments: This project will demonstrate conditional statements. A conditional statement is 
  a statement that can be executed based on a condition set within a block of code.

  */
using System;

namespace Deliverable_2_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask user of an input
            Console.WriteLine("Please enter the numerical value of your current grade.");

            /*
             * For this project I will be using a try-catch block 
             * to determine the users inputted value.
             */

            try
            {
                // This line will collect the users inputted value
                string input = Console.ReadLine();

                /*
                 * From this the value is used to determine
                 * their current grade in the ISM 4300 course.
                 */

                int grade = int.Parse(input);

                /* From here I will assign a letter to the numerical
                 * value entered to the appropriate grade from the syllabus
                 */

                string letter = "F";

                // Here I will use the IF/ELSE statement used in class to set the conditions

                if (grade >= 98)
                {
                    letter = "A+";
                }
                else if ((grade >= 0) && (grade <= 59))
                {
                    letter = "F";
                }
                else if ((grade >= 60) && (grade <= 61))
                {
                    letter = "D-";
                }
                else if ((grade >= 62) && (grade <= 67))
                {
                    letter = "D";
                }
                else if ((grade >= 68) && (grade <= 69))
                {
                    letter = "D+";
                }
                else if ((grade >= 70) && (grade <= 71))
                {
                    letter = "C-";
                }
                else if ((grade >= 72) && (grade <= 77))
                {
                    letter = "C";
                }
                else if ((grade >= 78) && (grade <= 79))
                {
                    letter = "C+";
                }
                else if ((grade >= 80) && (grade <= 81))
                {
                    letter = "B-";
                }
                else if ((grade >= 82) && (grade <= 87))
                {
                    letter = "B";
                }
                else if ((grade >= 88) && (grade <= 89))
                {
                    letter = "B+";
                }
                else if ((grade >= 90) && (grade <= 91))
                {
                    letter = "A-";
                }
                else if ((grade >= 92) && (grade <= 97))
                {
                    letter = "A";
                }

                // Show prompt if a negative value is enetered
                else
                {
                    Console.WriteLine("Only input positive integers!");
                }

                /* Another IF/ELSE to display a message along with 
                 * the assigned letter grade
                 * */

                if ((grade >= 0) && (grade <= 59))
                {
                    Console.WriteLine("Grade: " + letter);
                    Console.WriteLine("Not impossible!" + "However, it will take a lot of studying and discipline to bring this grade up." + "Refer to the syllabus.");
                    Console.WriteLine("Hit any key to exit the program...");

                    // This will dismiss the program. Be sure to pause until the user hits a key
                    Console.ReadKey(true);
                }
                else if ((grade >= 60) && (grade <= 89))
                {
                    Console.WriteLine("Grade: " + letter);
                    switch (letter)
                    {

                        case "D-":
                        case "D":
                        case "D+":
                            Console.WriteLine("Strive for better. Refer to the syllabus.");
                            Console.WriteLine("Hit any key to exit the program...");

                            //Exits Program
                            Console.ReadKey(true);
                            break;
                        case "C-":
                        case "C":
                        case "C+":
                            Console.WriteLine("Think of your GPA!" + "Although technically passing, aim higher!");
                            Console.WriteLine("Hit any key to exit program...");

                            // Exits program
                            Console.ReadKey(true);
                            break;
                        case "B-":
                        case "B":
                        case "B+":
                            Console.WriteLine("B-eautiful job!" + "Keep up the great work!");
                            Console.WriteLine("Hit any key to exit the program...");

                            // Exits the program
                            Console.ReadKey(true);
                            break;
                    }
                }
                else if ((grade >= 90) && (grade <= 99))
                {
                    Console.WriteLine("Grade: " + letter);
                    Console.WriteLine("A-mazing Job!" + "Your parents should be proud!");
                    Console.WriteLine("Hit any key to exit the program...");

                    //Exits the program
                    Console.ReadKey(true);
                }
                else if (grade <= 100)
                {
                    Console.WriteLine("Grade:" + letter);
                    Console.WriteLine("Well Done!");
                    Console.WriteLine("Hit any key to exit the program...");

                    // Exits the program
                    Console.ReadKey(true);
                }
                else
                {
                    Console.WriteLine("An incorrect vaule was detected." + "Please enter a vaule 0 and 100.");
                    Console.WriteLine("Hit any key to exit the program...");

                    // Exits the program
                    Console.ReadKey(true);
                }

            } // End of try
            catch
            {
                Console.WriteLine("Please enter a numerical value to get a letter grade.");
                Console.WriteLine("Hit any key to exit the program...");

            } // end of catch
        }
        }
    }
