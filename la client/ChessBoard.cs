using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace la_engine
{
    public class ChessBoard
    {
        public ChessPiece[,] Board { get; private set; }

        public ChessBoard()
        {
            Board = new ChessPiece[8, 8];
            Init();
        }

        public void Init()
        {
            // Set up the starting positions of the pieces on the chessboard
            Board[0, 0] = new ChessPiece("White", "Rook", 0, 0);
            Board[0, 1] = new ChessPiece("White", "Knight", 0, 1);
            Board[0, 2] = new ChessPiece("White", "Bishop", 0, 2);
            Board[0, 3] = new ChessPiece("White", "Queen", 0, 3);
            Board[0, 4] = new ChessPiece("White", "King", 0, 4);
            Board[0, 5] = new ChessPiece("White", "Bishop", 0, 5);
            Board[0, 6] = new ChessPiece("White", "Knight", 0, 6);
            Board[0, 7] = new ChessPiece("White", "Rook", 0, 7);

            for (int i = 0; i < 8; i++)
            {
                Board[1, i] = new ChessPiece("White", "Pawn", 1, i);
                Board[6, i] = new ChessPiece("Black", "Pawn", 6, i);
            }

            Board[7, 0] = new ChessPiece("Black", "Rook", 7, 0);
            Board[7, 1] = new ChessPiece("Black", "Knight", 7, 1);
            Board[7, 2] = new ChessPiece("Black", "Bishop", 7, 2);
            Board[7, 3] = new ChessPiece("Black", "Queen", 7, 3);
            Board[7, 4] = new ChessPiece("Black", "King", 7, 4);
            Board[7, 5] = new ChessPiece("Black", "Bishop", 7, 5);
            Board[7, 6] = new ChessPiece("Black", "Knight", 7, 6);
            Board[7, 7] = new ChessPiece("Black", "Rook", 7, 7);
        }
    }

}
