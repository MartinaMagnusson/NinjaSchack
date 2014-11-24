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

            bool movePossible = false;
            Random whichMove = new Random();


            switch (whichMove.Next(1, 8))
            {
                case 1:
                    ValidateMove(this.x + 1, this.y, directionUp);
                    movePossible = true;
                    break;
                    case 2:
                    ValidateMove(this.x, this.y + 1, directionUp);
                    movePossible = true;
                    break;
                    case 3:
                    ValidateMove(this.x - 1, this.y, directionUp);
                    movePossible = true;
                    break;
                case 4:
                    ValidateMove(this.x, this.y - 1, directionUp);
                    movePossible = true;
                    break;
                case 5:
                    ValidateMove(this.x + 1, this.y + 1, directionUp);
                    movePossible = true;
                    break;
                case 6:
                    ValidateMove(this.x - 1, this.y - 1, directionUp);
                    movePossible = true;
                    break;
                case 7:
                    ValidateMove(this.x + 1, this.y - 1, directionUp);
                    movePossible = true;
                    break;
                case 8:
                    ValidateMove(this.x - 1, this.y + 1, directionUp);
                    movePossible = true;
                    break;

            }

            return movePossible; //if we are unable to make a move return false
        }

        public override bool ValidateMove(int x, int y, bool directionUp)
        {

            bool move = false;

            if (directionUp && (y < this.y && y >= 0) && y <= 7 && (x < this.x && x >= 0) && x <= 7)
                move = true;

            if (!directionUp && (y > this.y && y <= 7) && y >= 0 && (x < this.x && x >= 0) && x <= 7)
                move = true;

            return move; //Här måste vi kolla om draget är tillåtet, om det inte är tillåtet returnerar vi false.
        }
    }
}
