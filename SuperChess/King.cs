using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperChess
{
    class King : ChessPiece
    {
        public King(int x, int y, string color)
            : base(x, y, color)
        {
        }
        public override string GetChessPieceDescription() //Piece blir en bondeD:\GitHub\NinjaSchack\SuperChess\King.cs
        {
            return "K";
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
                        if (this.ValidateMove(this.x + 1, this.y))
                        {
                            this.x = this.x + 1;
                            movePossible = true;
                        }
                        break;
                    case 2:
                        if (this.ValidateMove(this.x, this.y + 1))
                        {
                            this.y = this.y + 1;
                            movePossible = true;
                        }
                        break;
                    case 3:
                        if (this.ValidateMove(this.x - 1, this.y))
                        {
                            this.x = this.x - 1;
                            movePossible = true;
                        }
                        break;
                    case 4:
                        if (this.ValidateMove(this.x, this.y - 1))
                        {
                            this.y = this.y - 1;
                            movePossible = true;
                        }
                        break;
                    case 5:
                        if (this.ValidateMove(this.x + 1, this.y + 1))
                        {
                            this.x = this.x + 1;
                            this.y = this.y + 1;
                            movePossible = true;
                        }
                        break;
                    case 6:
                        if (this.ValidateMove(this.x - 1, this.y - 1))
                        {
                            this.x = this.x - 1;
                            this.y = this.y - 1;
                            movePossible = true;
                        }
                        break;
                    case 7:
                        if (this.ValidateMove(this.x + 1, this.y - 1))
                        {
                            this.x = this.x + 1;
                            this.y = this.y - 1;
                            movePossible = true;
                        }
                        break;
                    case 8:
                        if (this.ValidateMove(this.x - 1, this.y + 1))
                        {
                            this.x = this.x - 1;
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
            if (y <= 7 && y >= 0 && x >= 0 && x <= 7)
            {
                return true;
            }
            return false; //Här måste vi kolla om draget är tillåtet, om det inte är tillåtet returnerar vi false.
            //TODO:Få rät på denna skiten
        }
    }
}
