using System;
using System.Threading.Tasks;

namespace workspace
{
    // Right-click `Run Method` or `Debug Method`
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello World!");
        }

        static int ReturnSomething()
        {
            return 777;
        }

        static async Task HelloWorldAsync()
        {
            foreach(char ch in "Hello, World!!!")
            {
                Console.Write(ch);
                await Task.Delay(100);
            }
            Console.WriteLine();
        }
    }
}
