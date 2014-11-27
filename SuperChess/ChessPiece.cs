using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperChess
{
    class ChessPiece
    {
        public int x;
        public int y;
        public string Color { get; set; }
        public ChessPiece(int x, int y, string color)
        {
            this.x = x;
            this.y = y;
            this.Color = color;
        }

        public virtual string GetChessPieceDescription()
        {
            return "U";
        }

        public virtual bool Move(bool directionUp)
        {
            return true;
        }
        public virtual bool Move()
        {
            return true;
        }
        public virtual bool FalseMove(bool falseMove)
        {
            return false;
        }

        public virtual bool ValidateMove(int x, int y, bool directionUp)
        {
            return true;
        }
        public virtual bool ValidateMove(int x, int y)
        {
            return true;
        }
    }
}