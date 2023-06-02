using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame
{
    internal class ChessPiece
    {
        private static int Pawn = 0;
        private static int Bishop = 1;
        private static int Knight = 2;
        private static int Rock = 3;
        private static int Queen = 4;
        private static int King = 5;

        private static string black = "B";
        private static string white = "W";
        private static string[] Pieces = { "Pawn", "Bishop", "Knight", "Rook", "Queen", "King" };

        private string color;    // W - white, B - black
        private int type;     // 0 - 5
        private int location; // 0 - 63

        public ChessPiece(string color, int type, int location)
        {
            this.color = color;
            this.type = type;
            this.location = location;
        }

        public string Color() { return color; }
        public int Type() { return type; }
        public int Location() { return location; }
        public void newLocation(int location) { this.location = location;}

        public string pieceName(ChessPiece piece)
        {
            return piece.Color() + ChessPiece.Pieces[piece.Type()];
        }

        public static bool isRook(ChessPiece piece)
        {
            if (piece == null) return false;
            if (piece.type == Rock) return true;
            return false;
        }
        public static bool isPawn(ChessPiece piece)
        {
            if (piece == null) return false;
            if (piece.type == Pawn) return true;
            return false;
        }
        public static bool isBishop(ChessPiece piece)
        {
            if (piece == null) return false;
            if (piece.type == Bishop) return true;
            return false;
        }
        public static bool isKnight(ChessPiece piece)
        {
            if (piece == null) return false;
            if (piece.type == Knight) return true;
            return false;
        }
        public static bool isQueen(ChessPiece piece)
        {
            if (piece == null) return false;
            if (piece.type == Queen) return true;
            return false;
        }
        public static bool isKing(ChessPiece piece)
        {
            if (piece == null) return false;   
            if (piece.type == King) return true;
            return false;
        }
    }
}
