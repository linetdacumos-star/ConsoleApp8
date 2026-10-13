using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> myStack = new Stack<string>();
            bool running = true;

            while (running)
            {
                Console.WriteLine("\nWelcome to my STACK PROGRAM");
                Console.WriteLine("Choose what you want to do?");
                Console.WriteLine("1 - PUSH");
                Console.WriteLine("2 - POP");
                Console.WriteLine("3 - SEARCH");
                Console.WriteLine("4 - PEEK");
                Console.WriteLine("5 - DISPLAY");
                Console.WriteLine("6 - COUNT");
                Console.WriteLine("7 - EXIT");
                Console.Write("Enter Code: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter new data to push: ");
                        string pushData = Console.ReadLine();
                        Console.WriteLine("New data has been added!");
                        break;

                    case "2":
                        Console.Write("Enter how many data you want to pop: ");
                        if (int.TryParse(Console.ReadLine(), out int popCount))
                        {
                            if (popCount > myStack.Count)
                            {
                                Console.WriteLine("Operation not accepted.");
                            }
                            else
                            {
                                for (int i = 0; i < popCount; i++)
                                {
                                    string poppedItem = myStack.Pop();
                                    Console.WriteLine($"Popped: {poppedItem}");
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please enter a valid number.");
                        }
                        break;

                    case "3":
                        Console.Write("Enter data tosearch: ");
                        string searchData = Console.ReadLine();
                        if (myStack.Contains(searchData))
                        {
                            Console.WriteLine($"Data \"{searchData}\" found in the stack.");
                        }
                        else
                        {
                            Console.WriteLine($"Top element (Peek): {myStack.Peek()}");
                        }
                        break;

                    case "4":
                        if (myStack.Count > 0)
                        {
                            Console.WriteLine($"Top element (Peek): {myStack.Peek()}");
                        }
                        else
                        {
                            Console.WriteLine("The stack is empty.");
                        }
                        break;

                    case "5":
                        if (myStack.Count > 0)
                        {
                            Console.WriteLine("Current Stack elements:");
                            foreach (var item in myStack)
                            {
                                Console.WriteLine(item);
                            }
                        }
                        else
                        {
                            Console.WriteLine("The Stack is empty.");
                        }
                        break;

                    case "6":
                        Console.WriteLine($"Number of items in the stack: {myStack.Count}");
                        break;

                    case "7":
                        running = false;
                        break;

                    default:
                        Console.WriteLine("Invalid code. Please choose between 1 and 7.");
                        break;
                }

            }
        }
    }
}