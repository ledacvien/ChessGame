using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChessGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            DrawBoard();
        }

        public void DrawBoard()
        {
            for (int row = 0; row < 8; ++ row)
            {
                for (int col = 0; col < 8; ++ col)
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Size = new Size(ChessBoard.edgeSquare, ChessBoard.edgeSquare);
                    pictureBox.Location = new Point((col * ChessBoard.edgeSquare) + ChessBoard.X, (row * ChessBoard.edgeSquare) + ChessBoard.Y);
                    pictureBox.AllowDrop = true;
                    pictureBox.SizeMode = PictureBoxSizeMode.CenterImage;


                    if (col % 2 == 0)
                        pictureBox.BackColor = row % 2 != 0 ? ChessBoard.Brown : ChessBoard.White;
                    else
                        pictureBox.BackColor = row % 2 != 0 ? ChessBoard.White : ChessBoard.Brown;

                    Controls.Add(pictureBox);
                    ChessBoard.squareList.Add(pictureBox);
                    pictureBox.Cursor = Cursors.Hand;
                    pictureBox.MouseDown += new MouseEventHandler(MouseDown);
                    pictureBox.MouseMove += new MouseEventHandler(MouseMove);
                }
            }

            PuttingPices();
        }

        public void PuttingPices()
        {
            string path = "C:\\Users\\levie\\OneDrive\\Documents\\aSpring2023\\CSE445\\ChessGameProject\\ChessGame\\ChessGame\\Image\\";
            ChessBoard.squareList[0].Image = Image.FromFile(path + "BRook.png");
            ChessBoard.squareList[1].Image = Image.FromFile(path + "BKnight.png");
            ChessBoard.squareList[2].Image = Image.FromFile(path + "BBishop.png");
            ChessBoard.squareList[3].Image = Image.FromFile(path + "BQueen.png");
            ChessBoard.squareList[4].Image = Image.FromFile(path + "BKing.png");
            ChessBoard.squareList[5].Image = Image.FromFile(path + "BBishop.png");
            ChessBoard.squareList[6].Image = Image.FromFile(path + "BKnight.png");
            ChessBoard.squareList[7].Image = Image.FromFile(path + "BRook.png");

            int row = 1;
            for (int col = 0; col < 8; ++col)
            {
                ChessBoard.squareList[8 * row + col].Image = Image.FromFile(path + "BPawn.png");
            }

            row = 6;
            for (int col = 0; col < 8; ++col)
            {
                ChessBoard.squareList[8 * row + col].Image = Image.FromFile(path + "WPawn.png");
            }

            row = 7;
            ChessBoard.squareList[8 * row].Image = Image.FromFile(path + "WRook.png");
            ChessBoard.squareList[8 * row + 1].Image = Image.FromFile(path + "WKnight.png");
            ChessBoard.squareList[8 * row + 2].Image = Image.FromFile(path + "WBishop.png");
            ChessBoard.squareList[8 * row + 3].Image = Image.FromFile(path + "WQueen.png");
            ChessBoard.squareList[8 * row + 4].Image = Image.FromFile(path + "WKing.png");
            ChessBoard.squareList[8 * row + 5].Image = Image.FromFile(path + "WBishop.png");
            ChessBoard.squareList[8 * row + 6].Image = Image.FromFile(path + "WKnight.png");
            ChessBoard.squareList[8 * row + 7].Image = Image.FromFile(path + "WRook.png");
        }

        bool Dragging;
        int xPos, yPos;

        new void MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Dragging = true;
                xPos = e.X;
                yPos = e.Y;
            }
        }
        new void MouseMove(object sender, MouseEventArgs e)
        {
            Control c = sender as Control;
            if (Dragging && c != null)
            {
                c.Top = e.Y + c.Top - yPos;
                c.Left = e.X + c.Left - xPos;
            }
        }
    }
}
