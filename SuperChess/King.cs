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
        public override string GetChessPieceDescription() //Piece blir en bondeD:\GitHub\NinjaSchack\SuperChess\King.cs
        {
            return "K";
        }

        public override bool Move(bool directionUp)
        {

            bool movePossible = false;
<<<<<<< HEAD
            if (directionUp || !directionUp)
            {
                if (this.ValidateMove(this.x - 1, this.y, directionUp))
                {
                    this.x = this.x - 1;
                    movePossible = true;
                }
                if (this.ValidateMove(this.x, this.y - 1, directionUp))
                {
                    this.y = this.y - 1;
                    movePossible = true;
                }
                if (this.ValidateMove(this.x - 1, this.y - 1, directionUp))
                {
                    this.y = this.y - 1;
                    this.x = this.x - 1;
                    movePossible = true;
                }
                if (this.ValidateMove(this.x + 1, this.y, directionUp))
                {
                    this.x = this.x + 1;
                    movePossible = true;
                }
                if (this.ValidateMove(this.x, this.y + 1, directionUp))
                {
                    this.y = this.y + 1;
                    movePossible = true;
                }
                if (this.ValidateMove(this.x + 1, this.y + 1, directionUp))
                {
                    this.y += 1;
                    this.x += 1;
                    movePossible = true;
                }

=======
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
>>>>>>> 75cb5b979ecae31104d03a8a4ca61b349adbb711

            }
            return movePossible; //if we are unable to make a move return false
        }

        public override bool ValidateMove(int x, int y)
        {

            bool move = false;
<<<<<<< HEAD

            if (directionUp && y <= 7 && y >= 0 && x >= 0 && x <= 7)
                move = true;

            if (!directionUp && y <= 7 && y >= 0 && x >= 0 && x <= 7)
                move = true;
=======
            if (y < 8 && y >= 0 && x < 8 && x >= 0)
            { move = true; }
>>>>>>> 75cb5b979ecae31104d03a8a4ca61b349adbb711

            return move; //Här måste vi kolla om draget är tillåtet, om det inte är tillåtet returnerar vi false.
            //TODO:Få rät på denna skiten
        }
    }
}
