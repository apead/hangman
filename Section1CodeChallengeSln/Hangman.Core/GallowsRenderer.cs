using System;
using System.Collections.Generic;
using System.Text;

namespace Hangman.Core
{
    public class GallowsRenderer
    {
        private string[][] _gallowPics;

        public GallowsRenderer()
        {
            _gallowPics = new string[7][];

            Initialiize();
        }

        private void Initialiize()
        {
            int currentGallows = 6;
            _gallowPics[currentGallows] = new string[7];
            _gallowPics[currentGallows][0] = " +---+  ";
            _gallowPics[currentGallows][1] = " |   | ";
            _gallowPics[currentGallows][2] = "     | ";
            _gallowPics[currentGallows][3] = "     | ";
            _gallowPics[currentGallows][4] = "     | ";
            _gallowPics[currentGallows][5] = "     | ";
            _gallowPics[currentGallows][6] = "=========";

            currentGallows--;

            _gallowPics[currentGallows] = new string[7];
            _gallowPics[currentGallows][0] = " +---+ ";
            _gallowPics[currentGallows][1] = " |   | ";
            _gallowPics[currentGallows][2] = " o   | ";
            _gallowPics[currentGallows][3] = "     | ";
            _gallowPics[currentGallows][4] = "     | ";
            _gallowPics[currentGallows][5] = "     | ";
            _gallowPics[currentGallows][6] = "=========";

            currentGallows--;

            _gallowPics[currentGallows] = new string[7];
            _gallowPics[currentGallows][0] = " +---+ ";
            _gallowPics[currentGallows][1] = " |   | ";
            _gallowPics[currentGallows][2] = " o   | ";
            _gallowPics[currentGallows][3] = " |   | ";
            _gallowPics[currentGallows][4] = "     | ";
            _gallowPics[currentGallows][5] = "     | ";
            _gallowPics[currentGallows][6] = "=========";

            currentGallows--;

            _gallowPics[currentGallows] = new string[7];
            _gallowPics[currentGallows][0] = " +---+ ";
            _gallowPics[currentGallows][1] = " |   | ";
            _gallowPics[currentGallows][2] = " o   | ";
            _gallowPics[currentGallows][3] = "/|   | ";
            _gallowPics[currentGallows][4] = "     | ";
            _gallowPics[currentGallows][5] = "     | ";
            _gallowPics[currentGallows][6] = "=========";

            currentGallows--;

            _gallowPics[currentGallows] = new string[7];
            _gallowPics[currentGallows][0] = " +---+ ";
            _gallowPics[currentGallows][1] = " |   | ";
            _gallowPics[currentGallows][2] = " o   | ";
            _gallowPics[currentGallows][3] = "/|\\  | ";
            _gallowPics[currentGallows][4] = "     | ";
            _gallowPics[currentGallows][5] = "     | ";
            _gallowPics[currentGallows][6] = "=========";

            currentGallows--;

            _gallowPics[currentGallows] = new string[7];
            _gallowPics[currentGallows][0] = " +---+ ";
            _gallowPics[currentGallows][1] = " |   | ";
            _gallowPics[currentGallows][2] = " o   | ";
            _gallowPics[currentGallows][3] = "/|\\   | ";
            _gallowPics[currentGallows][4] = "/    | ";
            _gallowPics[currentGallows][5] = "     | ";
            _gallowPics[currentGallows][6] = "=========";


            currentGallows--;

            _gallowPics[currentGallows] = new string[7];
            _gallowPics[currentGallows][0] = " +---+ ";
            _gallowPics[currentGallows][1] = " |   | ";
            _gallowPics[currentGallows][2] = " o   | ";
            _gallowPics[currentGallows][3] = "/|\\   | ";
            _gallowPics[currentGallows][4] = " /\\   | ";
            _gallowPics[currentGallows][5] = "     | ";
            _gallowPics[currentGallows][6] = "=========";

        }

        public void Render(int x, int y, int gallows)
        {
            if (gallows > 0)
                Console.ForegroundColor = ConsoleColor.Green;
            else
                Console.ForegroundColor = ConsoleColor.Red;

            for (int index = 0; index < _gallowPics[gallows].Length;index++)
            {
                Console.SetCursorPosition(x, y + index);
                Console.Write(_gallowPics[gallows][index]);
            }
        }
    }
}
