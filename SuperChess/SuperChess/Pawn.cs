using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperChess
{
    class Pawn : ChessPiece
    {
        public Pawn(int x, int y) :base(x,y)
        {
        }

        public override string GetChessPieceDescription() //Piece blir en bonde
        {
            return "P";
        }

        public override bool Move(bool directionUp)
        {
            bool movePossible = false;
            if (directionUp)
            {
                if (this.ValidateMove(this.x, this.y - 1, directionUp))
                {
                    this.y = this.y - 1;
                    movePossible = true;
                }
                                    
            }
            else
            {
                if (this.ValidateMove(this.x, this.y + 1, directionUp))
                {
                    this.y = this.y + 1;
                    movePossible = true;
                }
                    
            }

            return movePossible; //if we are unable to make a move return false
        }

        public override bool ValidateMove(int x, int y, bool directionUp)
        {

            bool move = false;

            if (directionUp && (y < this.y && y >= 0))
                move = true;

            if (!directionUp && (y > this.y && y < 8))
                move = true;

            ////logik för vita                                      //Skriv om skiten (x och y)
            //if (directionUp && (x >= this.x || x < this.x - 1))
            //    move = false;
            //if (directionUp && (y != this.y))
            //    move = false;

            ////Logik för svarta
            //if (!directionUp && (x <= this.x || x > this.x + 1))
            //    move = false;
            //if (!directionUp && (y != this.y))
            //    move = false;

            return move; //Här måste vi kolla om draget är tillåtet, om det inte är tillåtet returnerar vi false.
        }

    }
}
