using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraAssignments
{
    internal class Program
    {
        static void Introduction()
        {
            // HEADER
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Week 2 Challenge Labs");
            Console.WriteLine("Name: Isaac Jang\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n---------------PART 1---------------\n");
            Console.ForegroundColor = ConsoleColor.White;
        }

        static void Transition()
        {
            // TRANSITION
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nPress any key to continue!\n");
            Console.ReadKey();
        }

        static void Part2()
        {
            // PART 2
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n---------------PART 2---------------\n");
            Console.ForegroundColor = ConsoleColor.White;
        }

        static void Part3()
        {
            // PART 2
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n---------------PART 3---------------\n");
            Console.ForegroundColor = ConsoleColor.White;
        }

        static void TryAgain()
        {
        StartPoint:
            while (true)
            {
                // ask user if they want to try again
                Console.WriteLine("\nWant to try again? (Y / N)");
                char answer = char.Parse(Console.ReadLine().ToUpper());

                // wants to continue
                if (answer == 'Y')
                {
                    goto StartPoint;
                }

                // does not want to continue
                else if (answer == 'N')
                {
                    break;
                }

                // invaid entry
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nEnter valid character");
                    Console.ForegroundColor = ConsoleColor.White;
                    continue;
                }
            }

        }

        static void ClosingMessage()
        {
            // CLOSING MESSAGE
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\n\nHave a great day!");
        }

        static void Main(string[] args)
        {
            //Introduction();

            ///*Write a function that takes an integer minutes and converts it to seconds. 

            //Examples:
            //convert(5) ➞ 300 
            //convert(3) ➞ 180 
            //convert(2) ➞ 120 */
            //Console.WriteLine("I can convert mins to number of seconds.");
            //Console.Write("Enter minutes: ");
            //float mins = float.Parse(Console.ReadLine());

            //Console.WriteLine($"{mins} minutes = {MinsToSecs(mins)} seconds");

            //Transition();

            //Part2();

            ///*
            // * 2. Declare an array of strings to store names of students. 
            // * Take the input from the user. Sort the students alphabetically and display the sorted list. 
            // * Can use built in function. 

            //*/

            //Transition();

            Part3();

            /*
            3. Create a function that returns true if a number is a palindrome. 
            Here the number can be in string format. Can use built in function of “reverse” on string. 
            Examples:
            IsPalindrome(838) ➞ true 
            IsPalindrome(4433) ➞ false 
            IsPalindrome(443344) ➞ true 

            Hint: reverse the string and compare the original with its reverse 
            */
            Console.WriteLine("Enter a number and I will tell you if it is a palindrome.");
            Console.Write("Number: ");
            int x = int.Parse(Console.ReadLine());
            string palidrome = Convert.ToString(x);

            Console.WriteLine(IsPalidrome(palidrome));


            /*
            4. Given a string, create a function to reverse the case. 
            All lower-cased letters should be upper-cased, and vice versa. 
            ReverseCase("Happy Birthday") ➞ "hAPPY bIRTHDAY" 
            ReverseCase("MANY THANKS") ➞ "many thanks" 
            ReverseCase("sPoNtAnEoUs") ➞ "SpOnTaNeOuS" 

            5. Write a C# Sharp program to check whether a given number is even or odd.  
            Test Data : 15 
            Expected Output : 
            15 is an odd integer */

            TryAgain();

            ClosingMessage();

            Console.ReadKey();
        }

        static float MinsToSecs(float mins)
        {
            float secs = mins * 60;
            return secs;
        }

        static bool IsPalidrome(string palidrome)
        {
            // creating charater array call "charArray", converting the palidrome
            char[] charArray = palidrome.ToCharArray();

            //reversing the array
            Array.Reverse(charArray);

            // Convert the reversed character array back to a string
            string reversedPalidrome = new string(charArray);

            if (palidrome == reversedPalidrome)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
