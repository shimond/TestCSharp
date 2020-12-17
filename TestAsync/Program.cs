using System;
using System.Threading.Tasks;

namespace TestAsync
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main NO.1");
            _ = StartIt();
            Console.WriteLine("Main NO.2");
            Console.ReadLine();
        }

        private static async Task StartIt()
        {
            Console.WriteLine("StartIt 1");
            await MethodA();
            Console.WriteLine("StartIt 2");
        }

        static async Task MethodA()
        {
            for (int i = 1; i <= 3; i++)
            {
                await Task.Delay(2000);
                Console.WriteLine($"Method A {i}");
            }
        }

    }
}
