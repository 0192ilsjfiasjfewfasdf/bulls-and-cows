using System;
using System.Globalization;

namespace BullsandCows
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("+-------------------------------------------------------------------+");
            Console.WriteLine("|                    Bulls & Cows \'Ultmate Baseball\'                |");
            Console.WriteLine("+-------------------------------------------------------------------+");
            Console.WriteLine("| Computer becomes a defense player and selects a 3-digit number.   |");
            Console.WriteLine("| The 3-digit number is between 0~9 & all 3 digits are different.   |");
            Console.WriteLine("| An offense player has to guess all numbers and its position.      |");
            Console.WriteLine("| The number of \'Strikes\': digits correct in the right position.    |");
            Console.WriteLine("| The number of \'Balls\': digits correct but in the wrong position.  |");
            Console.WriteLine("| The number of \'Outs\': digits are all wrong.                       |");
            Console.WriteLine("+-------------------------------------------------------------------+");
            Console.Write(" Computer: ");
            Console.WriteLine("\"I have chosen 3 different numbers... you have to guess it by the above rules!\"");
            Console.WriteLine();

            Random random = new Random();

            int[] numbers = new int[3];
            int index = 0;
            while (index < 3)
            {
                numbers[index] = random.Next(0, 10);

                bool hasDuplicate = false;
                for (int j = 0; j < index; j++)
                {
                    if (numbers[index] == numbers[j])
                    {
                        hasDuplicate = true;
                        break;
                    }
                }

                if (!hasDuplicate)
                {
                    index++;
                }
            }

            int[] guesses = new int[3];
            string[] inputMessages = {"> Put a 1st number.", "> Put a 2nd number.", ">Put a 3rd number."};

            while (true)
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine(inputMessages[i]);
                    guesses[i] = int.Parse(Console.ReadLine());
                }

            Console.WriteLine("> Number that offense chose");

                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine(guesses[i]);
                }

            if (guesses[0] == guesses[1] || guesses[0] == guesses[2] || guesses[1] == guesses[2])
            {
                Console.WriteLine("All 3 digit must be different.");
                continue;
            }

            int strikeCount = 0;
            int ballCount = 0;

                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (guesses[i] == numbers[j])
                        {
                            if (i == j)
                            {
                                strikeCount++;
                            }
                            else
                            {
                                ballCount++;
                            }
                        }
                    }
                }

                Console.Write("Strike: ");
                Console.WriteLine(strikeCount);
                Console.Write("Ball: ");
                Console.WriteLine(ballCount);
                Console.Write("Out: ");
                Console.WriteLine(3 - strikeCount - ballCount);

                if (strikeCount == 3)
                    {
                        Console.WriteLine("Congratulations! You guessed right!");
                        break;
                    }
            }
        }
    }
}
