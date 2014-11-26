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
        public BlackPlayer (List<ChessPiece> chessPieces)
            : base(chessPieces)
        {
            //for (int x = 0; x <= 7; x++)
            //{
            //    this.AddChessPiece(new Pawn(x, 1, "Black"));
            //}
            //this.AddChessPiece(new King(4, 0, "Black"));
            //this.AddChessPiece(new Queen(3, 0, "Black"));
            //this.AddChessPiece(new Bishop(2, 0, "Black"));
            //this.AddChessPiece(new Bishop(5, 0, "Black"));
            //this.AddChessPiece(new Knight(1, 0, "Black"));
            //this.AddChessPiece(new Knight(6, 0, "Black"));
            //this.AddChessPiece(new Rook(0, 0, "Black"));
            //this.AddChessPiece(new Rook(7, 0, "Black"));

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
