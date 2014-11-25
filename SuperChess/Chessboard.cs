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
        List<Player> players = new List<Player>(); 

        public Chessboard() //sätter ut alla piece
        {
            this.players.Add(new WhitePlayer());
            this.players.Add(new BlackPlayer());
            this.StartGame();
        }

        public void StartGame()
        {
            Random random = new Random();
            this.Draw();
            Console.ReadKey();
            bool running = true;
            while (running)
            {
                
               foreach (Player player in this.players)
               {
                
                    ChessPiece chessPiece = player.Move();
                    if (chessPiece != null)
                    {
                        foreach (Player opponentPlayer in players)
                        {
                            if (opponentPlayer != player)
                            {
                                opponentPlayer.Kill(chessPiece.x, chessPiece.y);
                                
                            }
                          }
                    }
                    else
                    {
                        //Unable to make a move
                        //Is the game over?
                        running = true;
                    }
                    this.Draw();
                    Thread.Sleep(300);
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
        //public void MoveBlackPiece(int x, int y, int xTarget, int yTarget)//vitas drag
        //{
        //    ChessPiece piece = this.board[x, y];
        //    ChessPiece targetPiece = this.board[xTarget, yTarget];

        //    if (piece == null)//fel som kan uppstå för vita
        //    {
        //      //  Console.WriteLine("Det finns ingen svart spelare på denna position");
        //        return;
        //    }
        //    if (piece.IsChessPieceWhite())
        //    {
        //     //   Console.WriteLine("Det går inte att flytta en vit pjäs");
        //        return;
        //    }
        //    if (!piece.ValidateMove(x, y, xTarget, yTarget))
        //    {
        //       // Console.WriteLine("Ogiltligt drag!");
        //        return;
        //    }
        //    if (targetPiece != null)
        //    {
        //        if (targetPiece.IsChessPieceBlack())
        //        {
        //           // Console.WriteLine("Du kan inte ta din egna pjäs");
        //            return;
        //        }
        //    }
            
        //    this.board[x, y] = null; //När allt går rätt
        //    this.board[xTarget, yTarget] = piece;
        //    this.Draw();
        //    Console.WriteLine("{0},{1} till {2},{3}", x, y, xTarget, yTarget);
        //    if (targetPiece != null)
        //    {
        //       Console.WriteLine("Svart spelare slog ut vit " + targetPiece.GetChessPieceType());
        //    }
        //    Thread.Sleep(1000);
        //}
    

        public void Draw()//ritar upp spelbrädan 
        {
            Console.Clear();
            for (int y = 0; y < 8; y++)
            {
                Console.Write("|");
                for (int x = 0; x < 8; x++)
                {
                    foreach (Player player in this.players)
                    {
                        ChessPiece chessPiece = player.GetChessPieceAt(x, y);
                        if (chessPiece != null)
                        {
                            Console.Write(player.GetDescription() + chessPiece.GetChessPieceDescription());
                        }
                        else
                        {
                            Console.Write("  ");
                        }
                    }
                    Console.Write("|");
                }
                Console.WriteLine("");
            }
        }
      
    }
}
