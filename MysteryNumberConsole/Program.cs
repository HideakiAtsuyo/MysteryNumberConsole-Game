using System;

namespace MysteryNumberConsole
{
    class Program
    {
        public static int MagicNumber = new Random().Next(1, 1000);
        public static int Lives = new Random().Next(5, 10);
        static void Useless()
        {
            System.Threading.Thread.Sleep(1500);
            Console.Clear();
        }
        static void Useless2()
        {
            Console.ReadLine();
            Environment.Exit(0);
        }

        static void Check(int x, bool y)
        {
            if (x > MagicNumber)
            {
                if (y == true) Lives = Lives - 1;
                Console.WriteLine("The mystery number is smaller.");
                Useless();
            }
            else if (x < MagicNumber)
            {
                if (y == true) Lives = Lives - 1;
                Console.WriteLine("The mystery number is bigger.");
                Useless();
            }
            else
            {
                Console.WriteLine("Omg you are a genius! How can you gess it!");
                Useless2();
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("1 - No Life Mode\n2 - Life Mode");
            int Choice = Convert.ToInt32(Console.ReadLine());

            switch (Choice)
            {
                case 1:
                    Console.Clear();
                    while (true)
                    {
                        Console.WriteLine("Guess what is the Magic Number (between 1 and 1000)");
                        int Answer = Convert.ToInt32(Console.ReadLine());
                        Check(Answer, false);

                    }
                    break;
                case 2:
                    Console.Clear();
                    while (true)
                    {
                        if (Lives == 0)
                        {
                            Console.WriteLine("Looser..");
                            Useless2();
                        } else
                        {
                            Console.WriteLine($"Guess what is the Magic Number (between 1 and 1000) | Lives(Between 5 & 10): {Lives}");
                            int Answer = Convert.ToInt32(Console.ReadLine());
                            Check(Answer, true);
                        }
                    }
                    break;
                default:
                    Console.WriteLine("RIP");
                    Useless();
                    break;
            }
        }
    }
}
