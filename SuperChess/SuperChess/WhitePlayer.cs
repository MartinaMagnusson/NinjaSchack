using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperChess
{
    class WhitePlayer : Player
    {
        public WhitePlayer()
        {
            for (int x = 0; x <= 7; x++)
            {
                this.AddChessPiece(new Pawn(x, 6));
            }
        }

        public override string GetDescription()
        {
            return "W";
        }

        public override ChessPiece Move()
        {

            //alternativ metod för att testa drag
            foreach (ChessPiece chessPiece in this.chessPieces)
            {
                if (chessPiece.Move(true))
                {
                    return chessPiece;
                }                
            }

            return null;
        }
    }
}
