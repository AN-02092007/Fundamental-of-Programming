using System;
using System.Reflection;

namespace Fundamental_of_Programming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of Section: ");
            string sec = Console.ReadLine();

            Console.Write("Enter the number of exercise (Ex: 1, 2, 15): ");
            string ex = Console.ReadLine();

            ex = ex.PadLeft(2, '0');

            string className = $"Fundamental_of_Programming.Section_{sec}.Ex{ex}";

            Type type = Type.GetType(className);

            if (type != null)
            {
                MethodInfo method = type.GetMethod("Run");
                if (method != null)
                {
                    Console.Clear();
                    Console.WriteLine($"\n========== RUNNING: SECTION {sec} - EXERCISE {ex} ==========\n");
                    method.Invoke(null, null);
                }
                else
                {
                    Console.WriteLine("Saw the article but can't find the Run() function.");
                }
            }
            else
            {
                Console.WriteLine("You haven't completed this exercise or you entered the wrong name.");
            }

            Console.ReadLine();
        }
    }
}