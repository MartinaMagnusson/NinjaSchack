using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SuperChess
{
    class Chessboard
    {
      List<Player> players;
        List<ChessPiece> allChessPieces = new List<ChessPiece>();
        public Chessboard() //sätter ut alla piece
        {
            players = new List<Player>();
            for (int x = 0; x <= 7; x++)
            {
                allChessPieces.Add(new Pawn(x, 6, "White"));
            }
            this.allChessPieces.Add(new King(4, 7, "White"));
            this.allChessPieces.Add(new Queen(3, 7, "White"));
            this.allChessPieces.Add(new Bishop(2, 7, "White"));
            this.allChessPieces.Add(new Bishop(5, 7, "White"));
            this.allChessPieces.Add(new Knight(1, 7, "White"));
            this.allChessPieces.Add(new Knight(6, 7, "White"));
            this.allChessPieces.Add(new Rook(0, 7, "White"));
            this.allChessPieces.Add(new Rook(7, 7, "White"));
            for (int x = 0; x <= 7; x++)
            {
                this.allChessPieces.Add(new Pawn(x, 1, "Black"));
            }
            this.allChessPieces.Add(new King(4, 0, "Black"));
            this.allChessPieces.Add(new Queen(3, 0, "Black"));
            this.allChessPieces.Add(new Bishop(2, 0, "Black"));
            this.allChessPieces.Add(new Bishop(5, 0, "Black"));
            this.allChessPieces.Add(new Knight(1, 0, "Black"));
            this.allChessPieces.Add(new Knight(6, 0, "Black"));
            this.allChessPieces.Add(new Rook(0, 0, "Black"));
            this.allChessPieces.Add(new Rook(7, 0, "Black"));
            this.players.Add(new WhitePlayer(allChessPieces));
            this.players.Add(new BlackPlayer(allChessPieces));
            this.StartGame();
        }

        public void StartGame()
        {
            this.Draw();
            Console.ReadKey();
            bool running = true;
            ChessPiece randomBlackPiece;
            ChessPiece randomWhitePiece;
            while (running)
            {
                // White player
                players[0].UpdateMyList(allChessPieces);
                randomWhitePiece = players[0].chessPieces[new Random().Next(0, players[0].chessPieces.Count)];
                if (randomWhitePiece != null)
                {
                    if (players[1] != players[0])
                    {
                       
                    }
                }
                //else                //{
                //    //Unable to make a move
                //    //Is the game over?
                //    running = true;
                //}
                if (randomWhitePiece.GetChessPieceDescription() == "P")
                {
                    randomWhitePiece.Move(true);
                }
                else
                {
                    randomWhitePiece.Move();
                }
                
                this.Draw();
                Thread.Sleep(30);

                if (players[0] == null)
                {
                    running = false;
                }
                //King king = new King();
                // Black player
                players[1].UpdateMyList(allChessPieces);
                randomBlackPiece = players[1].chessPieces[new Random().Next(0, players[1].chessPieces.Count)];
                if (randomBlackPiece != null)
                {
                    if (players[0] != players[1])
                    {
                        players[0].Kill(randomBlackPiece.x, randomBlackPiece.y, allChessPieces);
                        if (players[0].GetDescription() == "W" && randomWhitePiece.GetChessPieceDescription() == "K")
                        {
                            running = false;
                        } 
                    }
                }
                if (randomBlackPiece.GetChessPieceDescription() == "P")
                {
                    randomBlackPiece.Move(false);
                }
                else
                {
                    randomBlackPiece.Move();
                }
                if (players[1].chessPieces.Count == null)
                {
                    running = false;
                    break;
                }
                this.Draw();
                Thread.Sleep(30);
                if (players[1] == null)
                {
                    running = false;
                }
            }
            Console.WriteLine("Game over!");
        }

        //public List<string> message = new List<string>();
        //public void MoveWhitePiece(int x, int y, int xTarget, int yTarget)//vitas drag
        //{
        //    ChessPiece piece = this.board[x, y];
        //    ChessPiece targetPiece = this.board[xTarget, yTarget];

        //    if (piece == null)//fel som kan uppstå för vita
        //    {
        //        message.Add("Det finns ingen vit spelare på denna position");
        //        // Console.WriteLine("Det finns ingen vit spelare på denna position");
        //        return;
        //    }
        //    if (piece.IsChessPieceBlack())
        //    {
        //        message.Add("Det går inte att flytta en svart pjäs");
        //        return;
        //    }
        //    if (!piece.ValidateMove(x, y, xTarget, yTarget))
        //    {
        //        message.Add("Ogiltligt drag!");
        //        return;
        //    }
        //    if (targetPiece != null)
        //    {
        //        if (targetPiece.IsChessPieceWhite())
        //        {
        //            message.Add("Du kan inte ta din egna pjäs");
        //            return;
        //        }
        //    }

        //    this.board[x, y] = null; //När allt går rätt
        //    
        //    this.Draw();
        //    Console.WriteLine("{0},{1} till {2},{3}", x, y);
        //    foreach (var item in message)
        //    {
        //        //Console.WriteLine(item);
        //    }
        //    if (targetPiece != null)
        //    {
        //        Console.WriteLine("Vit spelare slog ut " + targetPiece.GetChessPieceType());
        //    }
        //    Thread.Sleep(1000);    
        //}

        public void Draw()//ritar upp spelbrädan 
        {
            Console.Clear();
            for (int y = 0; y < 8; y++)
            {
                for (int x = 0; x < 8; x++)
                {
                    ChessPiece chessPiece = GetChessPieceAt(x, y);
                    if (chessPiece != null && chessPiece.Color == "White")
                    {
                        Console.Write("[" + chessPiece.Color[0] + chessPiece.GetChessPieceDescription() + "]");
                    }
                    else if (chessPiece != null && chessPiece.Color == "Black")
                    {
                        Console.Write("[" + chessPiece.Color[0] + chessPiece.GetChessPieceDescription() + "]");
                    }
                    else
                    {
                        Console.Write("[  ]");
                    }
                }
                Console.WriteLine("");
            }
        }
        private ChessPiece GetChessPieceAt(int x, int y)
        {
            foreach (var piece in allChessPieces)
            {
                if (piece.x == x && piece.y == y)
                {
                    return piece;
                }
            }
            return null;
        }
    }
}
