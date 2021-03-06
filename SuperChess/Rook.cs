﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperChess
{
    class Rook : ChessPiece
    {
        public Rook(int x, int y, string color)
            : base(x, y, color)
        {
        }
        public override string GetChessPieceDescription() //Piece blir en bonde
        {
            return "R";
        }

        public override bool Move()
        {
            bool movePossible = false;
            Random whichMove = new Random();

            while (movePossible == false)
            {
                var step = whichMove.Next(1, 8);
                switch (whichMove.Next(1, 4))
                {
                    case 1:
                        if (this.ValidateMove(this.x + step, this.y))
                        {
                            this.x = this.x + step;
                            movePossible = true;
                        }
                        break;
                    case 2:
                        if (this.ValidateMove(this.x, this.y + step))
                        {
                            this.y = this.y + step;
                            movePossible = true;
                        }
                        break;
                    case 3:
                        if (this.ValidateMove(this.x - step, this.y))
                        {
                            this.x = this.x - step;
                            movePossible = true;
                        }
                        break;
                    case 4:
                        if (this.ValidateMove(this.x, this.y - step))
                        {
                            this.y = this.y - step;
                            movePossible = true;
                        }
                        break;
                }
            }
            return movePossible; //if we are unable to make a move return false
        }

        public override bool ValidateMove(int x, int y)
        {
            if (y < 8 && y >= 0 && x < 8 && x >= 0)
            {
                return true;
            }
            return false; //Här måste vi kolla om draget är tillåtet, om det inte är tillåtet returnerar vi false.
        }
    }
}