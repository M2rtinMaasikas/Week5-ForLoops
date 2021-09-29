using System;

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajalt sisesada numbrit;
            //programm kuvab korrutustabelit 1 kuni 10 sisestatud numbri jaoks
            //usernumber = 5
            //1 * 5 = 5
            //2 * 5 = 10
            int j, n;


            Console.Write("sisesta number ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n");
            for (j = 1; j <= 10; j++)
            {
                Console.Write("{0} X {1} = {2} \n", n, j, n * j);
            }
        }


    }
}

