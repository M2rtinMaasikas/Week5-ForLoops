using System;

namespace HelloWorldString
{
    class Program
    {
        static void Main(string[] args)
        {
            string HelloWorld = "Hello World!";

            for(int i =0; i < HelloWorld.Length; i++)
            {
                Console.WriteLine($"kohal {i} on {HelloWorld[i]}");
            }
        }
    }
}
