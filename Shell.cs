using System;

namespace ProjectExample
{
    public class Shell
    {
        public void Parse(string input)
        {
            var cmd = input.Split(' ');
            switch (cmd[0])
            {
                case "l":
                    break;
                case "cd":
                    break;
                case "a":
                    break;
                case "d":
                    break;
                case "e":
                    break;
                default:
                    Console.WriteLine("Unrecognized command");
                    break;
            }
        }
    }
}
