using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperChess
{
    class King : ChessPiece
    {
        public King(int x, int y)
            : base(x, y)
        {

        }
        public override string GetChessPieceDescription() //Piece blir en bonde
        {
            return "K";
        }

        public override bool Move(bool directionUp)
        {
            //Random random = new Random();
            //this.x = random.Next(0, 8);
            //this.y = random.Next(0, 8);
            bool movePossible = false;
            if (directionUp)
            {
                if (this.ValidateMove(this.x - 1, this.y, directionUp))
                {
                    this.x = this.x - 1;
                    movePossible = true;
                }
                else if (this.ValidateMove(this.x, this.y - 1, directionUp))
                {
                    this.y = this.y - 1;
                    movePossible = true;
                }
                else  if (this.ValidateMove(this.x -1 , this.y - 1, directionUp))
                {
                    this.y = this.y - 1;
                    this.x = this.x - 1;
                    movePossible = true;
                }
                else if (this.ValidateMove(this.x + 1, this.y, directionUp))
                {
                    this.x = this.x + 1;
                    movePossible = true;
                }
                else if (this.ValidateMove(this.x, this.y + 1, directionUp))
                {
                    this.y = this.y + 1;
                    movePossible = true;
                }
                else
                {
                    this.y = this.y + 1;
                    this.x = this.x + 1;
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
                else
                {
                    this.y = this.y - 1;
                    movePossible = true;
                }

            }

            return movePossible; //if we are unable to make a move return false
        }

        public override bool ValidateMove(int x, int y, bool directionUp)
        {

            bool move = false;

            if (directionUp && (y < this.y && y >= 0) && y <= 7 && (x < this.x && x >= 0) && x <= 7)
                move = true;

            if (!directionUp && (y > this.y && y <=7) && y >= 0 && (x < this.x && x >= 0) && x <= 7)
                move = true;

            return move; //Här måste vi kolla om draget är tillåtet, om det inte är tillåtet returnerar vi false.
        }
    }
}
