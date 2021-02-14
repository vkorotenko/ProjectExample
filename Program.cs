using System;

namespace ProjectExample
{
    class Program
    {
        private static void Main()
        {
            PrintHelp();
            var isDone = true;
            var shell = new Shell();
            do
            {
                var input = Console.ReadLine();
                if (input != null && input.ToLower() == "q") isDone = false;
                else shell.Parse(input);
            } while (isDone);
        }

        private static void PrintHelp()
        {
            const string help = @"Usage: l - list a project or task
cd [dir] - change directory to path
a [name] - append project or task
d [name] - delete project or task
e [name] - edit task or project";

            Console.Write($"{help}\n");
        }
    }
}
