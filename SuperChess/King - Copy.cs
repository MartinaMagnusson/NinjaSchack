//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace SuperChess
//{
//    class King : ChessPiece
//    {
//        public King(int x, int y)
//            : base(x, y)
//        {

//        }
//        public override string GetChessPieceDescription() //Piece blir en bonde
//        {
//            return "K";
//        }

//        public override bool Move(bool directionUp)
//        {
            
//            bool movePossible = false;
//            Random whichMove = new Random();
//            //whichMove.Next(1, 8);

            
//            if (directionUp || !directionUp)
//            {
//                    switch (whichMove.Next(1, 8))
//                    {
//                        case 1:
//                            this.x = this.x + 1;
//                            break;
//                        case 2:
//                            this.y = this.y + 1;
//                            break;
//                        case 3:
//                            this.x = this.x - 1;
//                            break;
//                        case 4:
//                            this.y = this.y - 1;
//                            break;
//                        case 5:
//                            this.x = this.x + 1;
//                            this.y = this.y + 1;
//                            break;
//                        case 6:
//                            this.x = this.x - 1;
//                            this.y = this.y - 1;
//                            break;
//                        case 7:
//                            this.x = this.x + 1;
//                            this.y = this.y - 1;
//                            break;
//                        case 8:
//                            this.x = this.x - 1;
//                            this.y = this.y + 1;
//                            break;
//                    }
//                }
            
//            return movePossible; //if we are unable to make a move return false
//        }

//        public override bool ValidateMove(int x, int y, bool directionUp)
//        {
//            bool move = false;

//            if (directionUp && (y < this.y && y >= 0) && y <= 7 && (x < this.x && x >= 0) && x <= 7)
//                move = true;

//            if (!directionUp && (y > this.y && y <=7) && y >= 0 && (x < this.x && x >= 0) && x <= 7)
//                move = true;

//            return move; //Här måste vi kolla om draget är tillåtet, om det inte är tillåtet returnerar vi false.
//        }
//    }
//}
