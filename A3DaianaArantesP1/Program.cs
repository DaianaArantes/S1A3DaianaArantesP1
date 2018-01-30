/*
 * Program ID: A3DaianaArantesP1
 * 
 * Purpose: Create a console based math program
 * This program will be shown as a menu with several options
 * 
 * Revision History
 * 
 * Written Dec 2017 by Daiana Arantes
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3DaianaArantesP1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declarate and initialize
            int menuOption = 0;
            int iterations = 0;
            
            // return to main menu if not 1 2 or 3
            do
            {
                //validate the user input
                do
                {
                    Console.WriteLine();
                    Console.WriteLine("Please select an option: ");
                    Console.WriteLine();
                    Console.WriteLine("Insert 1 to display list" +
                        " of even numbers");
                    Console.WriteLine();
                    Console.WriteLine("Insert 2 to display sequence" +
                        " of perfect squares");
                    Console.WriteLine();
                    Console.WriteLine("Insert 3 to exit the program");
                    Console.WriteLine();

                    //Try.Parse to validate if the input is valid
                    if (!int.TryParse(Console.ReadLine(), out menuOption))
                    {
                        Console.Clear();
                        Console.WriteLine("Invalid option, please " +
                            "insert 1, 2 or 3");
                        Console.WriteLine();
                    }
                    else if (menuOption < 1 || menuOption > 3)
                    {
                        Console.Clear();
                        Console.WriteLine("Invalid option, please insert " +
                            "1, 2 or 3");
                        Console.WriteLine();
                    }

                } while (menuOption < 1 || menuOption > 3);

                // validade input 1 2 or 3
                switch (menuOption)
                {
                    case 1:
                        Console.Clear();

                        do
                        {
                            Console.WriteLine("How many even numbers do" + 
                                " you want to display?");
                            Console.WriteLine();

                            //Try.Parse to validate if the input is valid
                            if (!int.TryParse(Console.ReadLine(), out iterations))
                            {
                                Console.Clear();
                                Console.WriteLine();
                                Console.WriteLine("Invalid input, please" +
                                    " insert how many even" +
                                    " numbers do you want to display");
                                Console.WriteLine();
                            }

                            else if (iterations < 1)
                            {
                                Console.Clear();
                                Console.WriteLine();
                                Console.WriteLine("Invalid input, please" +
                                    " insert how many even numbers" +
                                    " do you want to display");
                                Console.WriteLine();
                            }

                        } while (iterations < 1);

                        Console.WriteLine();
                        Program.DisplayEvenNumbers(iterations);
                        Console.WriteLine();
                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine();
                        Program.DisplaySequencePerfectSquares();
                        Console.WriteLine();

                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine();
                        Console.WriteLine("You choose to exit, thank you!");
                        Console.WriteLine();

                        break;
                }
            } while (menuOption != 3);
        }

        //Method to display a list of even numbers beginning at 0
        public static void DisplayEvenNumbers(int iterations)
        {
            Console.WriteLine();
            for (int evenNumber = 0, i = 0; i < iterations; i++, 
                evenNumber += 2)
            {
                Console.WriteLine(evenNumber);
            }
        }

        //display a sequence of perfect squares, begining 
        //printing the square of 1
        public static void DisplaySequencePerfectSquares()
        {
            int square = 1;
            int continues = 1;

            do
            {
                Console.Clear();
                Console.WriteLine("The square of " + square + " is "
                    + Math.Pow(square, 2));
                Console.WriteLine();
                Console.WriteLine("Do you want to continue or stop? ");
                Console.WriteLine();
                Console.WriteLine("Insert 1 to continue or any other" +
                    "key to stop");
                Console.WriteLine();

                if (!int.TryParse(Console.ReadLine(), out continues))
                {
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine("You choose to stop and to" +
                        " return to the original menu!");
                }

                else if (continues != 1)
                {
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine("You choose to stop and to" +
                        " return to the original menu!");
                }
                else
                {
                    square++;
                }

            } while (continues == 1);
        }
    }
}
