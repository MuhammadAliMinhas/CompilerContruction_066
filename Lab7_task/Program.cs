﻿using System;

namespace Lab7_task
{
    class Program
    {
        static string input;
        static int index = 0;

        static void Main(string[] args)
        {
            Console.WriteLine("Enter an arithmetic expression:");
            input = Console.ReadLine();

            try
            {
                bool isValid = E();
                if (isValid && index == input.Length)
                {
                    Console.WriteLine("Valid expression!");
                }
                else
                {
                    Console.WriteLine("Invalid expression!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        // Grammar Rules
        static bool E()
        {
            if (T())
            {
                while (index < input.Length && (input[index] == '+' || input[index] == '-'))
                {
                    index++;
                    if (!T())
                    {
                        throw new Exception("Invalid term in expression.");
                    }
                }
                return true;
            }
            return false;
        }

        static bool T()
        {
            if (F())
            {
                while (index < input.Length && (input[index] == '*' || input[index] == '/'))
                {
                    index++;
                    if (!F())
                    {
                        throw new Exception("Invalid factor in term.");
                    }
                }
                return true;
            }
            return false;
        }

        static bool F()
        {
            if (index < input.Length)
            {
                if (input[index] == '(')
                {
                    index++;
                    if (E())
                    {
                        if (index < input.Length && input[index] == ')')
                        {
                            index++;
                            return true;
                        }
                        throw new Exception("Missing closing parenthesis.");
                    }
                    throw new Exception("Invalid expression within parentheses.");
                }
                else if (N())
                {
                    return true;
                }
            }
            return false;
        }

        static bool N()
        {
            if (index < input.Length && char.IsDigit(input[index]))
            {
                index++;
                return true;
            }
            return false;
        }
    }
}
