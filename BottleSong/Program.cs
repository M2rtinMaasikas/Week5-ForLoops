using System;

namespace BottleSong
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 100; i++)
                Console.WriteLine($"{ i + 1} bottles of beers on the wall, {i} bottles of beer. \n take one down and pass it around, {i-1} bottle of beer on the wall.");

        }
        
    }  
}
