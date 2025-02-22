using System;
using System.Collections.Generic;

namespace MainProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("To-Do List.\n");
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1.Add task");
            Console.WriteLine("2.View tasks");
            Console.WriteLine("3.Exit");

            List<string> tasks = new();

            while (true)
            {
                Console.Write("Input: ");
                string input = Console.ReadLine();

                if (input == "1")
                {
                    AddTask(tasks);
                }
                else if (input == "2")
                {
                    if (tasks.Count == 0)
                    {
                        Console.WriteLine("No tasks added yet.");
                    }
                    else
                    {
                        PrintTasks(tasks);
                    }
                }
                else if (input == "3")
                {
                    Console.WriteLine("Goodbye!");
                }

  
            }
  
        }
        private static void AddTask(List<string> tasks)
        {
            Console.WriteLine("What task would you like to add?");
            Console.Write("Task name: ");
            string task = Console.ReadLine();

            if (tasks.Contains(task))
            {
                Console.WriteLine("You already have this task.");
                return;
            }

            tasks.Add(task);
        }

        private static void PrintTasks(List<string> tasks)
        {
            Console.WriteLine("Tasks:");

            for (int i = 0; i < tasks.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {tasks[i]}");
            }
        }


    }
}
