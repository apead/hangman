using System;
using System.Collections.Generic;
using System.Text;

namespace Hangman.Core
{
    public class HangmanGame
    {
        private Gallows _gallows;
        private string[] _wordsToGuess = new string[5] { "blushing", "hanging", "trouble", "vessel", "panicky" };
        private string _wordToGuess;
        private string _guessedWord;

        public HangmanGame()
        {
            _gallows = new Gallows();

            Initialize();
        }

        public void Initialize()
        {
            _gallows.Reset();

            Random random = new Random();
            _wordToGuess = _wordsToGuess[random.Next(0, 4)];

            MaskGuessedWord();

        }

        private void MaskGuessedWord()
        {
            StringBuilder builder = new StringBuilder();

            for (int index=0; index < _wordToGuess.Length;index++)
                builder.Append("_");

            _guessedWord = builder.ToString();
        }

        public string GetGuessedWord()
        {
            return _guessedWord;
        }

        public string GetWordToGuess()
        {
            return _wordToGuess;
        }


        public void GuessWord(string newGuessString)
        {
            if (newGuessString.Length > 0)
            {
                bool isGuessInWord = false;

                var newGuess = newGuessString[0];

                var temporaryWord = _guessedWord.ToCharArray();

                for (int index = 0; index < _wordToGuess.Length; index++)
                {
                    var currentChar = _wordToGuess[index];

                    if (currentChar == newGuess)
                    {
                        temporaryWord[index] = newGuess;
                        isGuessInWord = true;
                    }
                }
              
                _guessedWord = new string(temporaryWord);

                if (!isGuessInWord)
                    _gallows.ReduceChancesLeft();
            }
        }

        public bool IsPlayerHung()
        {
            return _gallows.IsHung();
        }

        public bool HasPlayerWon()
        {
            return _guessedWord == _wordToGuess;
        }

        public int GetChancesLeft()
        {
            return _gallows.GetChancesLeft();
        }

    }
}
