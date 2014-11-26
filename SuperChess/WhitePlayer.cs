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
        {
            UpdateMyList(chessPieces);
        }

        public override void UpdateMyList(List<ChessPiece> chessPieces)
        {
            foreach (var piece in chessPieces)
            {
                if(piece.Color == "White")
                {
                    this.chessPieces.Add(piece);
                }
            }
        }
        public override string GetDescription()
        {
            return "W";
        }
    }
}
