using Hangman.Core;
using System;

namespace Section1CodeChallengesApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var hangman = new HangmanGame();
            var renderer = new GallowsRenderer();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(0, 0);
            Console.Write("Welcome to Hangman!!");

            while (!hangman.HasPlayerWon() && !hangman.IsPlayerHung())
            {
                renderer.Render(5, 5, hangman.GetChancesLeft());

                Console.SetCursorPosition(0, 13);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("Your current guess: ");
                Console.WriteLine(hangman.GetGuessedWord());
                Console.SetCursorPosition(0, 15);

                Console.ForegroundColor = ConsoleColor.Green;

                Console.Write("What is your next guess: ");
                var nextGuess = Console.ReadLine();

                hangman.GuessWord(nextGuess);
            }

            renderer.Render(5, 5, hangman.GetChancesLeft());
            Console.SetCursorPosition(0, 13);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Your current guess: ");
            Console.WriteLine(hangman.GetGuessedWord());


            Console.SetCursorPosition(0, 20);


            if (hangman.HasPlayerWon())
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("Happiness!!  YOU HAVE WON!  :-)");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Sadness!!  YOU HAVE DIED  :-(");
            }

            Console.SetCursorPosition(0, 22);


            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("The word was: " + hangman.GetWordToGuess());

            Console.SetCursorPosition(0, 25);
            Console.WriteLine("Press Enter.");

            Console.ReadLine();
        }
    }
}
