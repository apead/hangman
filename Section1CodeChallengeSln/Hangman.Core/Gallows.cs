using System;

namespace Hangman.Core
{
    public class Gallows
    {
        const int MaxChances = 6;
        private int _chancesLeft;

        public Gallows()
        {
            Reset();
        }

        public void Reset()
        {
            _chancesLeft = MaxChances;
        }

        public void ReduceChancesLeft()
        {
            _chancesLeft--;

            if (_chancesLeft < 0)
                _chancesLeft = 0;
        }

        public bool IsHung()
        {
            return _chancesLeft == 0;
        }

        public int GetChancesLeft()
        {
            return _chancesLeft;
        }
    }
}
