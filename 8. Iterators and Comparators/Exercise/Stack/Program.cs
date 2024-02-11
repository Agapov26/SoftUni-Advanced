﻿namespace Stack
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Stack<string> stack = new Stack<string>();
            string[] delims = { ", ", " " };
            string input;

            while ((input = Console.ReadLine()) != "END")
            {
                string[] command = input.Split(delims, StringSplitOptions.RemoveEmptyEntries);

                if (command[0] == "Push")
                {
                    for (int i = 1; i < command.Length; i++)
                    {
                        stack.Push(command[i]);
                    }
                }

                else if (command[0] == "Pop")
                {
                    try
                    {
                        stack.Pop();
                    }
                    catch(InvalidOperationException e)
                    {
                        Console.WriteLine("No elements");
                    }
                }
            }

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
        }
    }
}
