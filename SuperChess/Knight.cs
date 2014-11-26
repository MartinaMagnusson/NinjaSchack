using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperChess
{
    class Knight : ChessPiece
    {
        public Knight(int x, int y, string color) : base(x, y, color)
        {
        }
        public override string GetChessPieceDescription() //Piece blir en bonde
        {
            return "H";
        }

        public override bool Move()
        {

            bool movePossible = false;
            Random whichMove = new Random();

            while (movePossible == false)
            {
                switch (whichMove.Next(1, 8))
                {
                    case 1:
                        if (this.ValidateMove(this.x + 1, this.y + 2))
                        {
                            this.x = this.x + 1;
                            this.y = this.y + 2;
                            movePossible = true;
                        }
                        break;
                    case 2:
                        if (this.ValidateMove(this.x + 1, this.y - 2))
                        {
                            this.x = this.x + 1;
                            this.y = this.y - 2;
                            movePossible = true;
                        }
                        break;
                    case 3:
                        if (this.ValidateMove(this.x - 1, this.y + 2))
                        {
                            this.x = this.x - 1;
                            this.y = this.y + 2;
                            movePossible = true;
                        }
                        break;
                    case 4:
                        if (this.ValidateMove(this.x - 1, this.y - 2))
                        {
                            this.x = this.x - 1;
                            this.y = this.y - 2;
                            movePossible = true;
                        }
                        break;
                    case 5:
                        if (this.ValidateMove(this.x + 2, this.y + 1))
                        {
                            this.x = this.x + 2;
                            this.y = this.y + 1;
                            movePossible = true;
                        }
                        break;
                    case 6:
                        if (this.ValidateMove(this.x - 2, this.y - 1))
                        {
                            this.x = this.x - 2;
                            this.y = this.y - 1;
                            movePossible = true;
                        }
                        break;
                    case 7:
                        if (this.ValidateMove(this.x + 2, this.y - 1))
                        {
                            this.x = this.x + 2;
                            this.y = this.y - 1;
                            movePossible = true;
                        }
                        break;
                    case 8:
                        if (this.ValidateMove(this.x - 2, this.y + 1))
                        {
                            this.x = this.x - 2;
                            this.y = this.y + 1;
                            movePossible = true;
                        }
                        break;
                }
            }

            return movePossible; //if we are unable to make a move return false
        }

        public override bool ValidateMove(int x, int y)
        {

            bool move = false;
            if (y < 8 && y >= 0 && x < 8 && x >= 0)
            { move = true; }

            return move; //Här måste vi kolla om draget är tillåtet, om det inte är tillåtet returnerar vi false.
            //TODO:Få rät på denna skiten
        }
    }
}
