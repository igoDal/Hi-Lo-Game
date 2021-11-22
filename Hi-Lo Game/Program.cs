﻿using System;

namespace Hi_Lo_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Hi-Lo.");
            Console.WriteLine($"Guess a number between 1 and {HiLoGame.MAXIMUM}");
            while (HiLoGame.GetPot() > 0)
            {
                Console.WriteLine("Press h for higher, l for lower, ? to buy a hint.");
                Console.WriteLine($" or any other key to quit with {HiLoGame.GetPot()}.");
                char key = Console.ReadKey(true).KeyChar;
                if (key == 'h')
                {
                    HiLoGame.Guess(true);
                }
                else if (key == 'l')
                {
                    HiLoGame.Guess(false);
                }
                else if (key == '?')
                {
                    HiLoGame.Hint();
                }
                else
                {
                    return;
                }
            }

            Console.WriteLine("The pot is empty, bye!");
        }
    }
}
