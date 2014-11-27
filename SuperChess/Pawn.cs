using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperChess
{
    class Pawn : ChessPiece
    {
        public Pawn(int x, int y, string color)
            : base(x, y, color)
        {
        }

        public override string GetChessPieceDescription() //Piece blir en bonde
        {
            return "P";
        }

        public override bool Move(bool directionUp)
        {
            if (directionUp)
            {
                if (this.ValidateMove(this.x, this.y - 1, directionUp))
                {
                    
                    this.y = this.y - 1;
                    return true;
                }
            }
            else
            {
                if (this.ValidateMove(this.x, this.y + 1, directionUp))
                {
                    
                    this.y = this.y + 1;
                    return true;
                }
            }
            return false; //if we are unable to make a move return false
        }

        public override bool ValidateMove(int x, int y, bool directionUp)
        {
            if (directionUp && (y < this.y && y >= 0))
            {
                return true;
            }
            if (!directionUp && (y > this.y && y < 8))
            {
                return true;
            }
            return false; //Här måste vi kolla om draget är tillåtet, om det inte är tillåtet returnerar vi false.
        }
    }
}