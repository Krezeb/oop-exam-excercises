using System;
using System.Collections.Generic;

namespace Interfaces1
{
    class Program
    {
        static void Main(string[] args)
        {
            TodoCollection todoCollection = new TodoCollection();
            CollectTodos(todoCollection);
            PrintNonFinishedTodos(todoCollection);
        }

        private static void CollectTodos(ICreateTodo todoCollection)
        {
            while (true)
            {
                Console.WriteLine("Create a todo by enter a text description. Press enter without a message to complete todo list.");
                string input = Console.ReadLine();
                if (input == "")
                {
                    break;
                }
                todoCollection.CreateTodo(input);
            }
        }

        private static void PrintNonFinishedTodos(ICollectTodos todoCollection)
        {
            List<Todo> todosToPrint = todoCollection.ListTodos(false);
            foreach (Todo todo in todosToPrint)
            {
                Console.WriteLine($"{todo.Text}");
            }
        }
    }
}