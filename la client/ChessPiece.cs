using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace la_engine
{
    public class ChessPiece
    {
        public string Color { get; set; }
        public string Type { get; set; }
        public int XPosition { get; set; }
        public int YPosition { get; set; }

        public ChessPiece(string color, string type, int xPosition, int yPosition)
        {
            this.Color = color;
            this.Type = type;
            this.XPosition = xPosition;
            this.YPosition = yPosition;
        }
        
        public List<(int, int)> GetLegalMoves()
        {
            List<(int, int)> legalMoves = new List<(int, int)>();

            // Logic for generating legal moves based on the piece type and position goes here

            return legalMoves;
        }
    }

}
