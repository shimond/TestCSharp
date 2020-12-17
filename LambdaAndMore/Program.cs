using System;
using System.Collections.Generic;
using System.IO;
namespace LambdaAndMore
{
    class Program
    {
        static void Main(string[] args)
        {
            // WhatIsTheOutput();
            using (StreamReader reader = new StreamReader("FILE_PATH"))
            {
                // read from file
                reader.Close();
            }
        }

        private static void WhatIsTheOutput()
        {
            List<Action> actions = new();
            for (int i = 0; i < 5; i++)
            {
                actions.Add(() => Console.WriteLine($"Action {i}"));
            }

            foreach (var action in actions)
            {
                action();
            }
        }
    }
}
