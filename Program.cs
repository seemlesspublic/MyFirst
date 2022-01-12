using System;

namespace ROMB
{
    class Program
    {
        static void Main()
        {
            for (int i = 0; i < 10; i++)

            {
                for (int j = 10; j > i; j--)

                {
                    Console.Write(" ");
                }

                for (int j = 0; j < i; j++)

                {
                    Console.Write("*");

                }



                for (int j = 0; j <= i; j++)

                {
                    Console.Write("*");
                }

                Console.WriteLine(" ");

            }

            // половина

            for (int i = 10; i >= 0; i--)

            {
                for (int j = 10; j > i; j--)

                {
                    Console.Write(" ");
                }

                for (int j = 0; j <= i; j++)

                {
                    Console.Write("*");

                }

                for (int j = 0; j < i; j++)

                {
                    Console.Write("*");

                }
                Console.WriteLine(" ");

            }
        }
    }
}