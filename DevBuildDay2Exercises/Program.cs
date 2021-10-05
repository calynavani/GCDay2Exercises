using System;

namespace DevBuildDay2Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
          double numGrade;
            string grade;
            string repeat = "Y";

            Console.WriteLine("Welcome to the Letter Grade Converter!\n");

            do
            {   

                Console.Write("Enter a numerical grade: ");
                numGrade = double.Parse(Console.ReadLine());
                if (numGrade == 99 || numGrade == 100)
                {
                    grade = "A+";
                    
                }
                else if (numGrade < 99 && numGrade >= 88) 
                {
                    grade = "A";
                    
                }
                else if (numGrade == 87 || numGrade == 86)
                {
                    grade = "B+";
                    
                }
                else if (numGrade < 86 && numGrade >= 80)
                {
                    grade = "B";
                    
                }
                else if (numGrade == 79 || numGrade == 78)
                {
                    grade = "C+";
                    
                }
                else if (numGrade < 78 && numGrade >= 67)
                {
                    grade = "C";
                    
                }
                else if (numGrade == 66 || numGrade == 65)
                {
                    grade = "D+";
                    
                }
                else if (numGrade < 65 && numGrade >= 60)
                {
                    grade = "D";
                    
                }
                else if (numGrade == 60 || numGrade == 59)
                {
                    grade = "F+";
                    
                }
                else if (numGrade < 59 && numGrade >=0)
                {
                    grade = "F";
                    
                }
                Console.WriteLine($"Letter Grade: {grade}\n");


                Console.Write("Continue? (y/n): ");
                
                repeat = Console.ReadLine();


            } while (repeat == "Y" || repeat == "y"); */


            /*Prompt the user to enter a language. Based on the language the user input, display "Hello, World!" in that language. Use a switch statement to choose what to display.

               string language;
               string repeat;
               do
               {
                   Console.Write("Enter a language: ");
                   language = Console.ReadLine();
                   switch (language)
                   {
                       case "English":
                           Console.WriteLine("Hello, World! ");
                           break;
                       case "Spanish":
                           Console.WriteLine("Hola Mundo!");
                           break;
                       case "Dutch":
                           Console.WriteLine("Hallo Wereld!");
                           break;

                   }

                   Console.Write("Would you like to continue (y/n)? ");

                   repeat = Console.ReadLine();

                       if (repeat == "n" || repeat == "N")
                       {
                           Console.WriteLine("Goodbye!");
                       }


               } while (repeat == "y" || repeat == "Y"); */


            /*Determine whether the user is tall enough to ride a roller coaster. Prompt the user to
                enter her height in inches.If she is less than 54 inches tall, notify her that she cannot
            ride the Raptor.If she is at least 54 inches tall, notify her that she can ride the Raptor */


            double height;
       
            string repeat;

            do
            {

                Console.Write("Enter your height in inches: ");
                height = double.Parse(Console.ReadLine());

                double heightNeed = 54 - height;
                if (height < 54)
                {

                    Console.WriteLine($"Sorry, you cannot ride the Raptor. You need {Math.Round(heightNeed, 1)}  more inches. ");
                }
                else
                {
                    Console.WriteLine("Great, you can ride the Raptor!");
                }


                Console.Write("Would you like to continue (y/n)? ");

                repeat = Console.ReadLine();
                if (repeat == "n" || repeat == "N")
                {
                    Console.WriteLine("Goodbye!");
                }

            } while (repeat == "y");





        }
    }
}
