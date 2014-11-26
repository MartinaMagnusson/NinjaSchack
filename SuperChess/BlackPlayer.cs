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
      //  public List<ChessPiece> chessPieces;
        public BlackPlayer (List<ChessPiece> chessPieces)
        {
            UpdateMyList(chessPieces);

        }
        public override void UpdateMyList(List<ChessPiece> chessPieces)
        {
            foreach (var piece in chessPieces)
            {
                if (piece.Color == "Black")
                {
                    this.chessPieces.Add(piece);
                }
            }
        }

        public override string GetDescription()
        {
            return "B";
        }

        //public override ChessPiece Move()
        //{

        //    //alternativ metod för att testa drag
        //    foreach (ChessPiece chessPiece in this.chessPieces)
        //    {
        //        if (chessPiece.Move(false))
        //        {
        //            return chessPiece;
        //        }
        //    }

        //    return null;
        //}
    }
}
