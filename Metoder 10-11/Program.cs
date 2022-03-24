using System;

namespace Metoder_10_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int rndnr = random.Next(1, 11);

            Console.WriteLine("Gæt et nummer imellem 1-10");
            int guess = int.Parse(Console.ReadLine());

            int i = 0;

            string output = Guess(i, guess, rndnr);
            Console.WriteLine(output);

            Console.ReadKey();
            
        }

        public static string Guess(int i, int guess, int rndnr)
        {
            String output = "";
            while (true)
            {
                Console.Clear();

                if (rndnr < guess)
                {
                    Console.WriteLine("Tallet er for højt");
                    i++;
                }
                else if (rndnr > guess)
                {
                    Console.WriteLine("Tallet er for lavt");
                    i++;
                }
                else if (rndnr == guess)
                {
                    i++;
                    if (i <= 5)
                    {
                        output =$"Du har brugt {i} forsøg, godt klaret!";
                    }
                    else output =$"Du har brugt {i} forsøg, det er ret dårligt";
                    break;


                }

                Console.WriteLine("Guess a number between 1-10");
                guess = int.Parse(Console.ReadLine());
            }

            return output;
        }
    }
}
