using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace StackCalculator
{
    class Program
    {
        static Stack<decimal> stack = new Stack<decimal>();

        static void Push(string[] splits)
        {
            if (stack.Count < 10)
            {
                if (splits.Length > 1)
                {
                    var number = decimal.Parse(splits[1]);
                    stack.Push(number);
                }
            }
            else
            {
                Console.WriteLine("Error: Stack is full; could not Push " + splits[1] + " on to stack.");
            }
            
        }

        static void Pop()
        {
            if (stack.Count == 0)
            {
                Console.WriteLine("Error: Stack is empty; could not Pop.");
            }
            else
            {
                var popped = stack.Pop();
                Console.WriteLine("Successfully popped " + popped + " off the stack.");
            }
        }

        static void Print()
        {
            Console.WriteLine(stack.Peek().ToString());
        }

        static void Add()
        {
            if (stack.Count < 2)
            {
                Console.WriteLine("Error: Stack only has " + stack.Count + " items. Could not execute.");
            }
            else
            {
                var pop1 = stack.Pop();
                var pop2 = stack.Pop();
                var result = pop2 + pop1;
                stack.Push(result);
            }
        }

        static void Subtract()
        {
            if (stack.Count < 2)
            {
                Console.WriteLine("Error: Stack only has " + stack.Count + " items. Could not execute.");
            }
            else
            {
                var pop1 = stack.Pop();
                var pop2 = stack.Pop();
                var result = pop2 - pop1;
                stack.Push(result);
            }
        }

        static void Multiply()
        {
            if (stack.Count < 2)
            {
                Console.WriteLine("Error: Stack only has " + stack.Count + " items. Could not execute.");
            }
            else
            {
                var pop1 = stack.Pop();
                var pop2 = stack.Pop();
                var result = pop2 * pop1;
                stack.Push(result);
            }
        }

        static void Divide()
        {
            if (stack.Count < 2)
            {
                Console.WriteLine("Error: Stack only has " + stack.Count + " items. Could not execute.");
            }
            else
            {
                var pop1 = stack.Pop();
                var pop2 = stack.Pop();
                var result = pop2 / pop1;
                stack.Push(result);
            }
        }

        static void Exit()
        {

        }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("ENTER COMMAND: ");
                var command = Console.ReadLine();
                var splits = command.Split(' ');

                if (splits.Length > 0)
                {
                    switch (splits[0])
                    {
                        case "PUSH":
                            Push(splits);
                            break;
                        case "POP":
                            Pop();
                            break;
                        case "PRINT":
                            Print();
                            break;
                        case "ADD":
                            Add();
                            break;
                        case "SUBTRACT":
                            Subtract();
                            break;
                        case "MULTIPLY":
                            Multiply();
                            break;
                        case "DIVIDE":
                            Divide();
                            break;
                        case "EXIT":
                            return; // exit program
                        default:
                            Console.WriteLine("Unknown command");
                            break;
                    }
                }
            }
        }
    }
}
