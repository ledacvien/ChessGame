using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChessGame
{
    internal class ChessBoard
    {
        public static Color Brown = ColorTranslator.FromHtml("#b0722c");
        public static Color White = ColorTranslator.FromHtml("#ede4d8");
        public static int edgeSquare = 70; // 80 pixels
        public static int X = 30;
        public static int Y = 50;

        public static List<PictureBox> squareList = new List<PictureBox>();
        public ChessBoard() { }

    }
}
