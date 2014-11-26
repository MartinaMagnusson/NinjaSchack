﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperChess
{
    class Player
    {
        public List<ChessPiece> chessPieces;

        public Player(List<ChessPiece> chessPieces)
        {
            this.chessPieces = chessPieces;
        }

        //public void AddChessPiece(ChessPiece chessPiece)
        //{
        //    this.chessPieces.Add(chessPiece);
        //}

        public List<ChessPiece> GetMyPieces()
        {

        }
        public virtual string GetDescription()
        {
            return "U";
        }

        public ChessPiece GetChessPieceAt(int x, int y)
        {
            foreach (var chessPiece in this.chessPieces)
            {
                if (chessPiece.x == x && chessPiece.y == y)
                {
                    return chessPiece;
                }
            }
            return null;
        }

        public virtual ChessPiece Move()
        {
            return null;
        }

        public void Kill(int x, int y, List<ChessPiece> chessPieces)
        {
            ChessPiece chessPiece = this.GetChessPieceAt(x, y);
            if (chessPiece != null)
            {
                chessPieces.Remove(chessPiece);

            }
            
        }

        public int RandomChessPiece(List<ChessPiece> listOfPieces)
        {
            Random random = new Random();
            int randomPiece = random.Next(1, chessPieces.Count);
            return randomPiece;
        }
        
    }
 
}
