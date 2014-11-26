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

        public ChessPiece(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public virtual string GetChessPieceDescription()
        {
            return "U";
        }

        public virtual bool Move(bool directionUp)
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
