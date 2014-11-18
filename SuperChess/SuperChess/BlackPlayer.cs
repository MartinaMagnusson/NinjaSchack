using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SuperChess
{
    class BlackPlayer : Player
    {
        public BlackPlayer ()
        {
            for (int x = 0; x <= 7; x++)
            {
                this.AddChessPiece(new Pawn(x, 1));
            }
        }

        public override string GetDescription()
        {
            return "B";
        }

        public override ChessPiece Move()
        {

            //alternativ metod för att testa drag
            foreach (ChessPiece chessPiece in this.chessPieces)
            {
                if (chessPiece.Move(false))
                {
                    return chessPiece;
                }
            }

            return null;
        }
    }
}
