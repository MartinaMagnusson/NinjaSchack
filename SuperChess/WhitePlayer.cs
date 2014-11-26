using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperChess
{
    class WhitePlayer : Player
    {
        public WhitePlayer(List<ChessPiece> chessPieces)
            : base(chessPieces)
        {
            //for (int x = 0; x <= 7; x++)
            //{
            //   this.AddChessPiece(new Pawn(x, 6, "White"));
            //}
            //this.AddChessPiece(new King(4, 7, "White"));
            //this.AddChessPiece(new Queen(3, 7, "White"));
            //this.AddChessPiece(new Bishop(2, 7, "White"));
            //this.AddChessPiece(new Bishop(5, 7, "White"));
            //this.AddChessPiece(new Knight(1, 7, "White"));
            //this.AddChessPiece(new Knight(6, 7, "White"));
            //this.AddChessPiece(new Rook(0, 7, "White"));
            //this.AddChessPiece(new Rook(7, 7, "White"));
        }

        public override string GetDescription()
        {
            return "W";
        }

        public override ChessPiece Move()
        {

            //alternativ metod för att testa drag
        //    ChessPiece randomWhitePiece = players[0].chessPieces[new Random().Next(0, players[0].chessPieces.Count)];
            //foreach (ChessPiece chessPiece in this.chessPieces)
            //{
            //    if (chessPiece.Move(true))
            //    {
            //        return chessPiece;
            //    }                
            //}

            return null;
        }
    }
}
