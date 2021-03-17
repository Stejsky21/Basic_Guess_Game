using System;

namespace Basic_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            int winNumber = r.Next(0, 100);
            bool win = false;
            int count = 0;

            do
            {
                Console.WriteLine("Write a number between 0 and 100");

                int number = int.Parse(Console.ReadLine());

                if (number > winNumber)
                {
                    Console.WriteLine("To high!");
                    count++;
                }
                else if (number < winNumber)
                {
                    Console.WriteLine("To low!");
                    count++;
                }
                else if (number == winNumber)
                {
                    count++;
                    Console.WriteLine("Bingo, YOU WIN!");
                    Console.WriteLine("You needed " + count + " attempts");
                    win = true;
                }

                Console.WriteLine();
            }
            while (win == false);
        }
    }
}
