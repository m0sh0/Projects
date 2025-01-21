using System;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            for (int i = 0; i <= rows; i++)
            {
                for (int j = rows; j >= i; j--)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
        }


    }
}
