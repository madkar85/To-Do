using System;
using System.Collections.Generic;

namespace To_Do
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> tasks = new List<string>();
            List<string> completedTasks = new List<string>();


            Welcome();
            Menu(tasks, completedTasks);
            //AddTasks(tasks);
            //ShowTasks(tasks);
            Console.WriteLine(string.Join(' ', tasks));
        }

        static private void Welcome()
        {
            Console.WriteLine("Välkommen till Att-Göra-Listan");
            Console.WriteLine("Börja med att skapa några uppgifter");
            Console.WriteLine("Lägg till en uppgift i taget (skriv q för att avsluta.)");

        }

        static private void Menu(List<string> tasks, List<string> completedTasks)
        {
            string input;

            do
            {
                Console.WriteLine("Välj något av följande alternativ");
                Console.WriteLine("1. Lägg till.");
                Console.WriteLine("2. Visa uppgifter");
                Console.WriteLine("3. Klarmarkera");
                Console.WriteLine("4. Visa avklarade");
                Console.WriteLine("5. Ta bort");
                Console.WriteLine("q. Avsluta");
                input = Console.ReadLine();

                Console.Clear();

                switch (input)
                {
                    case "1":
                        AddTasks(tasks);
                        break;
                    case "2":
                        ShowTasks(tasks);
                        break;
                    case "3":
                        MoveTasksToCompletedTasks(tasks, completedTasks);
                        break;
                    case "4":
                        ShowCompletedTasks(completedTasks);
                        break;
                    case "5":
                        RemoveFromTasks(tasks);
                        break;
                    default:
                        break;
                }
            } while (input != "q");

        }

        static private void AddTasks(List<string> tasks)
        {
            string input;
            do
            {
                Console.Write("Uppgift: ");
                input = Console.ReadLine();
                tasks.Add(input);
            }
            while (input != "q");
        }


        static private void ShowTasks(List<string> tasks)
        {
            Console.WriteLine("Visa uppgifter:");

            for (int i = 0; i < tasks.Count - 1; i++)
            {
                Console.WriteLine(i + ". " + tasks[i]);
            }
        }



        static private void MoveTasksToCompletedTasks(List<string> tasks, List<string> completedTasks)
        {
            Console.WriteLine("Välj uppgift som är utförd. (skriv q för att avsluta)");
            ShowTasks(tasks);
            string choice = Console.ReadLine();
            
            if (choice != "q")
            {
                int idx = Convert.ToInt32(choice);
                completedTasks.Add(tasks[idx]);
                tasks.RemoveAt(idx);
            }

        }

        static private void ShowCompletedTasks(List<string> completedTasks)
        {
            foreach (var item in completedTasks)
            {
                Console.WriteLine(item);
            }
        }

        static private void RemoveFromTasks(List<string> tasks)
        {
            Console.WriteLine("Ta bort uppgifter. (skriv q för att avsluta)");
            ShowTasks(tasks);

           string choice = Console.ReadLine();
            
            if (choice != "q")
            {
                int index = Convert.ToInt32(choice);
                tasks.RemoveAt(index);
            } 

        }



    }
}
