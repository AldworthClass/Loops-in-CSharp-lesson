﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_6___Loops
{
    class Program
    {
        //Each solution was coded in its own static method
        static void Main(string[] args)
        {
            int choice;
            //Displays the menu with error checking
            do {
                Console.WriteLine("Loop Practice Solutions");
                Console.WriteLine("");
                Console.WriteLine("Select an option:");
                Console.WriteLine("1 - For Loop Question 1");
                Console.WriteLine("2 - For Loop Question 2");
                Console.WriteLine("3 - For Loop Question 3");
                Console.WriteLine("4 - For Loop Question 4");
                Console.WriteLine("5 - For Loop Question 5");
                Console.WriteLine("6 - For Loop Question 6");
                Console.WriteLine("7 - While Loop Question 1");
                Console.WriteLine("8 - While Loop Question 2");
                Console.WriteLine("10 - QUIT");
                while (!Int32.TryParse(Console.ReadLine(), out choice))
                    Console.WriteLine("Invalid selection, try again.");

                Console.WriteLine("");
                Console.WriteLine("");
                switch (choice)
                {
                    case 1:
                        ForQuestion1();
                        break;
                    case 2:
                        ForQuestion2Sol1();
                        break;
                    case 3:
                        ForQuestion3();
                        break;
                    case 4:
                        ForQuestion4();
                        break;
                    case 5:
                        ForQuestion5();
                        break;
                    case 6:
                        ForQuestion6();
                        break;
                    case 7:
                        WhileQuestion1();
                        break;
                    case 8:
                        WhileQuestion2();
                        break;
                    case 10:
                        Console.WriteLine("Thanks for participating");
                        break;
                    default:    //This is like the else part of an if/else..if block
                        Console.WriteLine("Invalid Selection");
                        break;
                }
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
            } while (choice != 10);
        }

        // Display numbers 1-10 formatted (1, 2, ... 10)
        public static void ForQuestion1()
        {
            Console.WriteLine("Question 1");
            Console.WriteLine("");
            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine("");
        }

        // Display numbers from 5 to 50 solution 1
        public static void ForQuestion2Sol1()
        {
            Console.WriteLine("Question 2 Solution 1");
            Console.WriteLine("");
            for (int i = 5; i <= 55; i += 5)
            {
                Console.WriteLine(i);
            }
        }

        // // Display numbers from 5 to 50 solution 2
        public static void ForQuestion2Sol2()
        {
            Console.WriteLine("Question 2 Solution 2");
            Console.WriteLine("");
            for (int i = 1; i <= 11; i++)  //Ends at 11 because 5 x 11 = 55
            {
                Console.WriteLine(i*5);
            }
        }

        // Display numbers from 99-50
        public static void ForQuestion3()
        {
            Console.WriteLine("Question 3");
            Console.WriteLine("");
            for (int i = 99; i >= 55; i--)
            {
                Console.WriteLine(i);
            }
        }

        // Calculate sum of odd/even numbers from 20-40
        public static void ForQuestion4()
        {
            int evenSum = 0;
            int oddSum = 0;
            Console.WriteLine("Question 4");
            Console.WriteLine("");
            for (int i = 20; i <= 40; i++)
            {
                if (i % 2 == 0) //If i is divisible by 2 it is even
                {
                    evenSum += i;
                }
                else  //If i is not divisible by 2 it is odd
                {
                    oddSum += i;
                }
            }
            Console.WriteLine($"Sum of odd numbers: {oddSum}");
            Console.WriteLine($"Sum of even numbers: {evenSum}");
        }

        // Use loop to calculate 5!
        public static void ForQuestion5()
        {
            // 5! = 5 x 4 x 3 x 2 x 1
            int factorial = 1;
            for (int i = 5; i >= 1; i--)
            {
                factorial *= i;
            }
            Console.WriteLine($"5! = {factorial}");
        }

        // Count how many of 10 entered numbers are even
        public static void ForQuestion6()
        {
            int numEven = 0;
            int input;
            Console.WriteLine("Enter 5 integers, I will tell you how many are even!");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Please enter an integer:");
                while (!Int32.TryParse(Console.ReadLine(), out input)) //Ensures valid input
                    Console.WriteLine("Invalid integer, try again:");
                if (input % 2 == 0) //If there is only 1 line of code in the body of a loop or if statement, the { } are optional!
                    numEven += 1;
            }
            Console.WriteLine($"You entered {numEven}");
        }

        // Select favourite ninja turtle
        public static void WhileQuestion1()
        {
            int selection;
            Console.WriteLine("Select your favourite ninja turtle:");
            do
            {
                Console.WriteLine("1 - Donatello");
                Console.WriteLine("2 - Mecalleango");
                Console.WriteLine("3 - Leonardo");
                Console.WriteLine("4 - Raphael");
                while (!Int32.TryParse(Console.ReadLine(), out selection))//Verifies numeric input
                    Console.WriteLine("Invalid input, enter an integer:");
                if (selection != 1)
                {
                    Console.WriteLine("Try again");
                    Console.WriteLine("");
                }

            } while (selection != 1);//Only ends when user chooses
            Console.WriteLine("Wise choice my friend.");
        }

        // Valid age verification
        public static void WhileQuestion2()
        {
            int age;
            Console.WriteLine("Please enter your age:");
            while (!Int32.TryParse(Console.ReadLine(), out age) || age <= 0)
                Console.WriteLine("Invalid age, try again:");
            Console.WriteLine("Thanks");
        }
    }
}
