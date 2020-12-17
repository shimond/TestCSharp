using System;
using System.Collections.Generic;

namespace LambdaAndMore
{
    class Program
    {
        static void Main(string[] args)
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
