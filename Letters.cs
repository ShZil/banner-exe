using System;
using System.Collections.Generic;
using System.Text;

namespace Banner
{
    class Letters
    {
        private static readonly char[] ascii = { ' ', '!', '\"', '#', '$', '%', '&', '\'', '(', ')', '*', '+', ',', '-', '.', '/',
            '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', ':', ';', '<', '=', '>', '?',
            '@', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', '[', '\\', ']', '^', '_', '`', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', '{', '|', '}', '~' };
        // Size: ?x10 (Height must be 10).

        public static void printAll()
        {
            // Console.Write("{");
            for (char ch = ' '; ch < 127; ch++)
            {
                // Console.Write("\'" + ch + "\', ");
                Console.Write(ch);
            }
            // Console.Write("}");
        }

        public static string getAll()
        {
            string to = "";
            for (char ch = ' '; ch < 127; ch++)
            {
                to += ch;
            }
            return to;
        }

        public static string[] GetLetter(char letter)
        {
            if (letter >= ' ' && letter < 127)
            {
                var art = Letters.GetArt(letter - ' ');
                if (art == null)
                {
                    return new string[] { ascii[letter - ' '].ToString(),
                        ascii[letter - ' '].ToString(),
                        ascii[letter - ' '].ToString(),
                        ascii[letter - ' '].ToString(),
                        ascii[letter - ' '].ToString(),
                        ascii[letter - ' '].ToString(),
                        ascii[letter - ' '].ToString(),
                        ascii[letter - ' '].ToString(),
                        ascii[letter - ' '].ToString(),
                        ascii[letter - ' '].ToString()
                    };
                }
                else
                {
                    return art;
                }
            }
            return null;
        }

        private static string[] GetArt(int letter)
        {
            /*
             case n:
                    // char
                    toReturn = new string[]
                    {
                        "                   ",
                        "                   ",
                        "                   ",
                        "                   ",
                        "                   ",
                        "                   ",
                        "                   ",
                        "                   ",
                        "                   ",
                        "                   "
                    };
                    break;
             */
            string[] toReturn = null;
            switch (letter)
            {
                case 0:
                    // Space
                    string space = "               ";
                    toReturn = Mult(space, 10);
                    break;
                case 1:
                    // !
                    string rod = "  |  ";
                    string spc = "     ";
                    string dot = "  O  ";
                    toReturn = Add(Mult(rod, 8), spc, dot);
                    break;
                case 2:
                    // "
                    string tilt0 = "  / /  ";
                    string tilt1 = " / /   ";
                    string spaces = "       ";
                    toReturn = Add(tilt0, tilt1, Mult(spaces, 8));
                    break;
                case 3:
                    // #
                    toReturn = new string[]
                    {
                        "            /    /  ",
                        "           /    /   ",
                        "          /    /    ",
                        " --------+----+---- ",
                        "        /    /      ",
                        "       /    /       ",
                        " -----+----+------- ",
                        "     /    /         ",
                        "    /    /          ",
                        "   /    /           "
                    };
                    break;
                case 4:
                    // $
                    toReturn = new string[]
                    {
                        "           |       ",
                        "     =====|=====   ",
                        "  //      |        ",
                        " ||       |        ",
                        "  \\\\      |        ",
                        "     ====|====     ",
                        "         |     \\\\  ",
                        "         |      || ",
                        "        |      //  ",
                        "    ====|=====     "
                    };
                    break;
                case 5:
                    // %
                    toReturn = new string[]
                    {
                        "    ---    /  ",
                        "   <   >  /   ",
                        "    ---  /    ",
                        "        /     ",
                        "       /      ",
                        "      /       ",
                        "     /        ",
                        "    /  ---    ",
                        "   /  <   >   ",
                        "  /    ---    "
                    };
                    break;
                case 6:
                    // &
                    toReturn = new string[]
                    {
                        "        ======       ",
                        "     //        \\\\    ",
                        "     ||        ||    ",
                        "     \\\\        //    ",
                        "      \\\\     //      ",
                        "       \\\\  //        ",
                        "        \\\\/     /    ",
                        "        //\\\\ //      ",
                        "      ||  //\\        ",
                        "       \\ /  \\\\       "
                    };
                    break;
                case 7:
                    // '
                    string tilt2 = "  /  ";
                    string tilt3 = " /   ";
                    string spacess = "     ";
                    toReturn = Add(tilt2, tilt3, Mult(spacess, 8));
                    break;
                case 8:
                    // (
                    toReturn = new string[]
                    {
                        "        /     ",
                        "       /      ",
                        "      |       ",
                        "      |       ",
                        "      |       ",
                        "      |       ",
                        "      |       ",
                        "      |       ",
                        "       \\      ",
                        "        \\     "
                    };
                    break;
                case 9:
                    // )
                    toReturn = new string[]
                    {
                        "     \\       ",
                        "      \\      ",
                        "       |     ",
                        "       |     ",
                        "       |     ",
                        "       |     ",
                        "       |     ",
                        "       |     ",
                        "      /      ",
                        "     /       "
                    };
                    break;
                case 10:
                    // *
                    toReturn = Add(new string[] {
                        "   \\ | /   ",
                        "     x     ",
                        "   / | \\   " },
                   Mult("           ", 7));
                    break;
                case 11:
                    // +
                    string spac = "           ";
                    string vertical = "     |     ";
                    string horizontal = " ----+---- ";
                    toReturn = Add(Mult(spac, 2), Mult(vertical, 2), horizontal, Mult(vertical, 2), Mult(spac, 3));
                    break;
                case 12:
                    // ,
                    string spacc = "   ";
                    string top = " | ";
                    string bottom = " / ";
                    toReturn = Add(Mult(spacc, 8), top, bottom);
                    break;
                case 13:
                    // -
                    string spaac = "         ";
                    string horizont = " ------- ";
                    toReturn = Add(Mult(spaac, 4), horizont, Mult(spaac, 5));
                    break;
                case 14:
                    // .
                    string spaaac = "   ";
                    string dott = " O ";
                    toReturn = Add(Mult(spaaac, 9), dott);
                    break;
                case 15:
                    // /
                    toReturn = new string[]
                    {
                        "           /  ",
                        "          /   ",
                        "         /    ",
                        "        /     ",
                        "       /      ",
                        "      /       ",
                        "     /        ",
                        "    /         ",
                        "   /          ",
                        "  /           "
                    };
                    break;
                case 16:
                    // 0
                    toReturn = new string[]
                    {
                        "              ",
                        "      ---     ",
                        "   --     --  ",
                        "  |      /  | ",
                        "  |     /   | ",
                        "  |    /    | ",
                        "  |   /     | ",
                        "  |  /      | ",
                        "   --     --  ",
                        "      ___     "
                    };
                    break;
                case 17:
                    // 1
                    toReturn = new string[]
                    {
                        "              ",
                        "      /|      ",
                        "     / |      ",
                        "    /  |      ",
                        "       |      ",
                        "       |      ",
                        "       |      ",
                        "       |      ",
                        "       |      ",
                        "    ___|___   "
                    };
                    break;
                case 18:
                    // 2
                    toReturn = new string[]
                    {
                        "   ____      ",
                        "        \\    ",
                        "         |   ",
                        "          |  ",
                        "          |  ",
                        "         |   ",
                        "       /     ",
                        "     /       ",
                        "   |         ",
                        "   |_______  "
                    };
                    break;
                case 19:
                    // 3
                    toReturn = new string[]
                    {
                        "   ____       ",
                        "        \\     ",
                        "         \\    ",
                        "          |   ",
                        "         /    ",
                        "    -----     ",
                        "         \\    ",
                        "          |   ",
                        "         /    ",
                        "    ____/     ",
                    };
                    break;
                case 20:
                    // 4
                    toReturn = new string[]
                    {
                        "            ",
                        "  |      |  ",
                        "  |      |  ",
                        "  |      |  ",
                        "  |      |  ",
                        "   \\_____|  ",
                        "         |  ",
                        "         |  ",
                        "         |  ",
                        "         |  "
                    };
                    break;
                case 21:
                    // 5
                    toReturn = new string[]
                    {
                        "   _______  ",
                        "  |         ",
                        "  |         ",
                        "  |         ",
                        "   \\        ",
                        "    -----   ",
                        "         \\  ",
                        "          | ",
                        "         /  ",
                        "    ____/   "
                    };
                    break;
                case 22:
                    // 6
                    toReturn = new string[]
                    {
                        "      ____   ",
                        "     /       ",
                        "    /        ",
                        "   |         ",
                        "   |         ",
                        "   |-----    ",
                        "   |      \\  ",
                        "   |       | ",
                        "    \\     /  ",
                        "     \\___/   "
                    };
                    break;
                case 23:
                    // 7
                    toReturn = new string[]
                    {
                        "  _________  ",
                        "          /  ",
                        "         /   ",
                        "        /    ",
                        "       /     ",
                        "      /      ",
                        "     /       ",
                        "    /        ",
                        "   /         ",
                        "  /          "
                    };
                    break;
                case 24:
                    // 8
                    toReturn = new string[]
                    {
                        "      ___    ",
                        "    /     \\  ",
                        "   |       | ",
                        "   |       | ",
                        "    \\     /  ",
                        "     ----    ",
                        "    /     \\  ",
                        "   |       | ",
                        "   |       | ",
                        "    \\ ___ /  "
                    };
                    break;
                case 25:
                    // 9
                    toReturn = new string[]
                    {
                        "      ___    ",
                        "    /     \\  ",
                        "   |       | ",
                        "   |       | ",
                        "    \\     /  ",
                        "      ---/   ",
                        "        /    ",
                        "       /     ",
                        "      /      ",
                        "     /       "
                    };
                    break;
                case 26:
                    // :
                    string spaaaac = "   ";
                    string doott = " O ";
                    toReturn = Add(Mult(spaaaac, 3), doott, Mult(spaaaac, 2), doott, Mult(spaaaac, 3));
                    break;
                case 27:
                    // :
                    string spaaaacc = "   ";
                    string dooott = " O ";
                    string toop = " | ";
                    string botom = " / ";
                    toReturn = Add(Mult(spaaaacc, 3), dooott, Mult(spaaaacc, 2), toop, botom, Mult(spaaaacc, 2));
                    break;
                case 28:
                    // <
                    toReturn = new string[]
                    {
                        "      /  ",
                        "     /   ",
                        "    /    ",
                        "   /     ",
                        "  /      ",
                        "  \\      ",
                        "   \\     ",
                        "    \\    ",
                        "     \\   ",
                        "      \\  "
                    };
                    break;
                case 29:
                    // =
                    string across = "  _____  ";
                    string empaty = "         ";
                    toReturn = Add(Mult(empaty, 3), across, empaty, across, Mult(empaty, 4));
                    break;
                case 30:
                    // >
                    toReturn = new string[]
                    {
                        "  \\      ",
                        "   \\     ",
                        "    \\    ",
                        "     \\   ",
                        "      \\  ",
                        "      /  ",
                        "     /   ",
                        "    /    ",
                        "   /     ",
                        "  /      "
                    };
                    break;
                case 31:
                    // ?
                    toReturn = new string[]
                    {
                        "    ____    ",
                        "  /      \\  ",
                        " /        | ",
                        "          | ",
                        "         /  ",
                        "       /    ",
                        "      |     ",
                        "      |     ",
                        "            ",
                        "      O     "
                    };
                    break;
                case 32:
                    // @
                    toReturn = new string[]
                    {
                        "      ______      ",
                        "   __/      \\_    ",
                        "  /    ____   \\   ",
                        " |    /    \\   |  ",
                        " |   |      |  |  ",
                        " |    \\ ____\\  |  ",
                        " |           \\/   ",
                        "  \\__        ___  ",
                        "     \\______/     ",
                        "                  "
                    };
                    break;
                case 33:
                    // A
                    toReturn = new string[]
                    {
                        "         /\\         ",
                        "        /  \\        ",
                        "       /    \\       ",
                        "      /      \\      ",
                        "     /________\\     ",
                        "    /          \\    ",
                        "   /            \\   ",
                        "  /              \\  ",
                        " /                \\ ",
                        "/                  \\"
                    };
                    break;
                case 34:
                    // B
                    toReturn = new string[]
                    {
                        "  __________  ",
                        " |          \\ ",
                        " |           |",
                        " |           |",
                        " |          / ",
                        " | ---------  ",
                        " |          \\ ",
                        " |           |",
                        " |           |",
                        " |__________/ "
                    };
                    break;
                case 35:
                    // C
                    toReturn = new string[]
                    {
                        "     _________   ",
                        "    /         \\  ",
                        "   /             ",
                        "  /              ",
                        " |               ",
                        " |               ",
                        " |               ",
                        "  \\              ",
                        "   \\             ",
                        "    \\_________/  "
                    };
                    break;
                case 36:
                    // D
                    toReturn = new string[]
                    {
                        "  __________    ",
                        " |          \\   ",
                        " |           \\  ",
                        " |            | ",
                        " |            | ",
                        " |            | ",
                        " |            | ",
                        " |            | ",
                        " |           /  ",
                        " |__________/   "
                    };
                    break;
                case 37:
                    // E
                    string topper = "  ____________  ";
                    string side = " |              ";
                    string middle = " |---------     ";
                    string bottomer = " |____________  ";
                    toReturn = Add(topper, Mult(side, 4), middle, Mult(side, 3), bottomer);
                    break;
                case 38:
                    // F
                    topper = "  ____________ ";
                    side = " |             ";
                    middle = " |---------    ";
                    toReturn = Add(topper, Mult(side, 4), middle, Mult(side, 4));
                    break;
                case 39:
                    // G
                    toReturn = new string[]
                    {
                        "    _________  ",
                        "   /           ",
                        "  /            ",
                        " |             ",
                        " |             ",
                        " |      ------ ",
                        " |           | ",
                        " |           | ",
                        "  \\         /  ",
                        "   \\_______/   "
                    };
                    break;
                case 40:
                    // H
                    string normal = " |          | ";
                    string ladder = " |__________| ";
                    toReturn = Add(Mult(normal, 4), ladder, Mult(normal, 5));
                    break;
                case 41:
                    // I
                    string ttoop = " _____ ";
                    string bot = " __|__ ";
                    string mid = "   |   ";
                    toReturn = Add(ttoop, Mult(mid, 8), bot);
                    break;
                case 42:
                    // J
                    toReturn = new string[]
                    {
                        "      __________   ",
                        "                |  ",
                        "                |  ",
                        "                |  ",
                        "                |  ",
                        "                |  ",
                        "                |  ",
                        "               /   ",
                        "     \\_      _/    ",
                        "       \\____/      "
                    };
                    break;
                case 43:
                    // K
                    toReturn = new string[]
                    {
                        " |        /",
                        " |      /  ",
                        " |    /    ",
                        " |  /      ",
                        " |/        ",
                        " |\\        ",
                        " |  \\      ",
                        " |    \\    ",
                        " |      \\  ",
                        " |        \\"
                    };
                    break;
                case 44:
                    // L
                    string toppp =   " |           ";
                    string bottomm = " |__________ ";
                    toReturn = Add(Mult(toppp, 9), bottomm);
                    break;
                case 45:
                    // M
                    toReturn = new string[]
                    {
                        " |\\        /| ",
                        " | \\      / | ",
                        " |  \\    /  | ",
                        " |   \\  /   | ",
                        " |    \\/    | ",
                        " |          | ",
                        " |          | ",
                        " |          | ",
                        " |          | ",
                        " |          | "
                    };
                    break;
                case 46:
                    // N
                    toReturn = new string[]
                    {
                        " |\\         | ",
                        " | \\        | ",
                        " |  \\       | ",
                        " |   \\      | ",
                        " |    \\     | ",
                        " |     \\    | ",
                        " |      \\   | ",
                        " |       \\  | ",
                        " |        \\ | ",
                        " |         \\| "
                    };
                    break;
                case 47:
                    // O
                    toReturn = new string[]
                    {
                        "     _____     ",
                        "    /     \\    ",
                        "   /       \\   ",
                        "  /         \\  ",
                        " |           | ",
                        " |           | ",
                        " |           | ",
                        "  \\         /  ",
                        "   \\       /   ",
                        "    \\_____/    "
                    };
                    break;
                case 48:
                    // P
                    toReturn = new string[]
                    {
                        "  _________    ",
                        " |         \\   ",
                        " |          |  ",
                        " |          |  ",
                        " |_________/   ",
                        " |             ",
                        " |             ",
                        " |             ",
                        " |             ",
                        " |             "
                    };
                    break;
                case 49:
                    // Q
                    toReturn = new string[]
                    {
                        "     _____     ",
                        "    /     \\    ",
                        "   /       \\   ",
                        "  /         \\  ",
                        " |           | ",
                        " |           | ",
                        " |           | ",
                        "  \\      \\  /  ",
                        "   \\      \\/   ",
                        "    \\_____/\\_  "
                    };
                    break;
                case 50:
                    // R
                    toReturn = new string[]
                    {
                        "  _________    ",
                        " |         \\   ",
                        " |          |  ",
                        " |          |  ",
                        " |_________/   ",
                        " |\\            ",
                        " |  \\          ",
                        " |    \\        ",
                        " |      \\      ",
                        " |        \\    "
                    };
                    break;
                case 51:
                    // S
                    toReturn = new string[]
                    {
                        "   ________    ",
                        "  /            ",
                        " |             ",
                        " |             ",
                        "  \\_______     ",
                        "          \\    ",
                        "           |   ",
                        "           |   ",
                        "           |   ",
                        "  ________/    "
                    };
                    break;
                case 52:
                    // T
                    string midle =   "      |      ";
                    string tooop = " ___________ ";
                    toReturn = Add(tooop, Mult(midle, 9));
                    break;
                case 53:
                    // U
                    string norm =  " |            | ";
                    string bbot =  "  \\          /  ";
                    string bbot1 = "   \\        /   ";
                    string bbot2 = "    \\______/    ";
                    toReturn = Add(Mult(norm, 7), bbot, bbot1, bbot2);
                    break;
                case 54:
                    // V
                    toReturn = new string[]
                    {
                        " |       | ",
                        " |       | ",
                        "  |     |  ",
                        "  |     |  ",
                        "   |   |   ",
                        "   |   |   ",
                        "    | |    ",
                        "    | |    ",
                        "     |     ",
                        "     |     "
                    };
                    break;
                case 55:
                    // W
                    toReturn = new string[]
                    {
                        " |             | ",
                        " |             | ",
                        "  |     |     |  ",
                        "  |     |     |  ",
                        "   |   | |   |   ",
                        "   |   | |   |   ",
                        "    | |   | |    ",
                        "    | |   | |    ",
                        "     |     |     ",
                        "     |     |     "
                    };
                    break;
                case 56:
                    // X
                    toReturn = new string[]
                    {
                        " \\        / ",
                        "  \\      /  ",
                        "   \\    /   ",
                        "    \\  /    ",
                        "     \\/     ",
                        "     /\\     ",
                        "    /  \\    ",
                        "   /    \\   ",
                        "  /      \\  ",
                        " /        \\ "
                    };
                    break;
                case 57:
                    // Y
                    toReturn = new string[]
                    {
                        " \\         / ",
                        "  \\       /  ",
                        "   \\     /   ",
                        "    \\   /    ",
                        "     \\ /     ",
                        "      |      ",
                        "      |      ",
                        "      |      ",
                        "      |      ",
                        "      |      "
                    };
                    break;
                case 58:
                    // Z
                    toReturn = new string[]
                    {
                        " ________ ",
                        "        / ",
                        "       /  ",
                        "      /   ",
                        "     /    ",
                        "    /     ",
                        "   /      ",
                        "  /       ",
                        " /        ",
                        "/________ "
                    };
                    break;
                case 59:
                    // [
                    string woop = " +---   ";
                    string left = " |      ";
                    toReturn = Add(woop, Mult(left, 8), woop);
                    break;
                case 60:
                    // \
                    toReturn = new string[]
                    {
                        " \\           ",
                        "  \\          ",
                        "   \\         ",
                        "    \\        ",
                        "     \\       ",
                        "      \\      ",
                        "       \\     ",
                        "        \\    ",
                        "         \\   ",
                        "          \\  "
                    };
                    break;
                case 61:
                    // ]
                    string woopr = "   ---+ ";
                    string right = "      | ";
                    toReturn = Add(woopr, Mult(right, 8), woopr);
                    break;
                case 62:
                    // ^
                    toReturn = new string[]
                    {
                        "   /\\   ",
                        "  /  \\  ",
                        " /    \\ ",
                        "        ",
                        "        ",
                        "        ",
                        "        ",
                        "        ",
                        "        ",
                        "        "
                    };
                    break;
                case 63:
                    // ^
                    string empathy = "        ";
                    string under = "--------";
                    toReturn = Add(Mult(empathy, 9), under);
                    break;
                case 64:
                    // `
                    string tilt4 = "  \\  ";
                    string tilt5 = "   \\ ";
                    string spacesss = "     ";
                    toReturn = Add(tilt4, tilt5, Mult(spacesss, 8));
                    break;
            }
            if (toReturn != null)
            {
                if (toReturn.Length != 10)
                    throw new IndexOutOfRangeException("Art Array must be of length 10");
                for (int i = 1; i < 10; i++)
                {
                    if (toReturn[i].Length != toReturn[0].Length)
                        throw new IndexOutOfRangeException("Differing string lengths");
                }
            }
            return toReturn;
        }

        public static bool IsSpace(string[] letter)
        {
            foreach (var row in letter)
            {
                foreach (var ch in row.ToCharArray())
                {
                    if (ch != ' ') return false;
                }
            }
            return true;
        }

        private static string[] Mult(string str, int times)
        {
            string[] toReturn = new string[times];
            for (int i = 0; i < times; i++)
            {
                toReturn[i] = str;
            }
            return toReturn;
        }

        private static string[] Add(string[] a, string[] b)
        {
            string[] toReturn = new string[a.Length + b.Length];
            for (int i = 0; i < a.Length + b.Length; i++)
            {
                if (i < a.Length) toReturn[i] = a[i];
                else toReturn[i] = b[i - a.Length];
            }
            return toReturn;
        }
        private static string[] Add(string[] a, string b)
        {
            string[] toReturn = new string[a.Length + 1];
            for (int i = 0; i < a.Length + 1; i++)
            {
                if (i < a.Length) toReturn[i] = a[i];
                else toReturn[i] = b;
            }
            return toReturn;
        }
        private static string[] Add(string a, string[] b)
        {
            string[] toReturn = new string[1 + b.Length];
            for (int i = 0; i < 1 + b.Length; i++)
            {
                if (i < 1) toReturn[i] = a;
                else toReturn[i] = b[i - 1];
            }
            return toReturn;
        }

        private static string[] Add(string a, string b)
        {
            return new string[] { a, b };
        }
        private static string[] Add(string a, string b, string[] c)
        {
            return Add(Add(a, b), c);
        }
        private static string[] Add(string[] a, string b, string c)
        {
            return Add(Add(a, b), c);
        }
        private static string[] Add(string[] a, string b, string[] c)
        {
            return Add(Add(a, b), c);
        }
        private static string[] Add(string a, string[] b, string c)
        {
            return Add(Add(a, b), c);
        }
        private static string[] Add(string[] a, string[] b, string c, string[] d, string[] e)
        {
            return Add(Add(Add(Add(a, b), c), d), e);
        }
        private static string[] Add(string[] a, string b, string[] c, string d, string[] e)
        {
            return Add(Add(Add(Add(a, b), c), d), e);
        }
        private static string[] Add(string a, string[] b, string c, string[] d, string e)
        {
            return Add(Add(Add(Add(a, b), c), d), e);
        }
        private static string[] Add(string[] a, string b, string c, string d)
        {
            return Add(Add(Add(a, b), c), d);
        }
        private static string[] Add(string a, string[] b, string c, string[] d)
        {
            return Add(Add(Add(a, b), c), d);
        }
        private static string[] Add(string[] a, string b, string c, string d, string[] e)
        {
            return Add(Add(Add(Add(a, b), c), d), e);
        }
        private static string[] Add(string[] a, string b, string[] c, string d, string e, string[] f)
        {
            return Add(Add(Add(Add(Add(a, b), c), d), e), f);
        }
    }
}
