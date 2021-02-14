using System;

namespace ProjectExample
{
    class Program
    {
        static void Main(string[] args)
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
            var help = @"Usage: l - list a project or task
cd [dir] - change directory to path
a [name] - append project or task
d [name] - delete project or task";
            Console.Write($"{help}\n");
        }
    }
}
