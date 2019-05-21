using System;
using System.Collections.Generic;
using System.Text;

namespace P09SimpleTextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = new StringBuilder();
            var length = int.Parse(Console.ReadLine());
            var versions = new Stack<StringBuilder>();
            versions.Push(text);

            for (int i = 0; i < length; i++)
            {
                var command = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                switch (command[0])
                {
                    case "1":
                        text.Append(command[1]);
                        versions.Push(text);
                        break;
                    case "2":
                        var count = int.Parse(command[1]);
                        text.Remove(text.Length - 1 - count, count);
                        versions.Push(text);
                        break;
                    case "3":
                        var index = int.Parse(command[1]);
                        Console.WriteLine(text[index]);
                        break;
                    case "4":
                        if (versions.Count > 0)
                        {
                            text = versions.Pop();
                        }
                        break;
                }
            }
        }
    }
}
