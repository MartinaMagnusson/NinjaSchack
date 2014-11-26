﻿using System;
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
        List<ChessPiece> allChessPieces = new List<ChessPiece>();
        public Chessboard() //sätter ut alla piece
        {
            
           
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
            Random random = new Random();
          //  Player randomPlayer = new Player();
            this.Draw();
            Console.ReadKey();
            bool running = true;
            while (running)
            {
                ChessPiece randomWhitePiece = players[0].chessPieces[new Random().Next(0, players[0].chessPieces.Count)];
                if (randomWhitePiece != null)
                {
                    if (players[1] != players[0])
                    {
                        players[1].Kill(randomWhitePiece.x, randomWhitePiece.y, allChessPieces);
                    }
                }
                else
                {
                    //Unable to make a move
                    //Is the game over?
                    running = true;
                }
                if (randomWhitePiece.GetChessPieceDescription() == "P")
                {
                    randomWhitePiece.Move(true);
                }
                else
                {
                    randomWhitePiece.Move();
                }
                this.Draw();
                Thread.Sleep(300);

                ChessPiece randomBlackPiece = players[1].chessPieces[new Random().Next(0, players[1].chessPieces.Count)];
                if (randomBlackPiece != null)
                {
                    if (players[0] != players[1])
                    {
                        players[0].Kill(randomBlackPiece.x, randomBlackPiece.y, allChessPieces);
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


                this.Draw();
                Thread.Sleep(300);






                //for (int i = 0; i < randomPlayer.chessPieces.Count; i++)
                //{
                //    int randomChess = random.Next(i);
                //    ChessPiece chessPiece = randomPlayer.Move();
                //    if (chessPiece != null)
                //    {
                //        foreach (Player opponentPlayer in players)
                //        {
                //            if (opponentPlayer != randomChess)
                //            {
                //                opponentPlayer.Kill(chessPiece.x, chessPiece.y);
                //            }
                //        }
                //    }
                //    else
                //    {
                //        //Unable to make a move
                //        //Is the game over?
                //        running = true;
                //    }
                //    this.Draw();
                //    Thread.Sleep(300);
                //}
                // foreach (Player player in this.players)
                //{ }
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
                //Console.Write("|");
                for (int x = 0; x < 8; x++)
                {
                    // foreach (Player player in this.players)
                    // {
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
                    //}
                    //Console.Write("|");
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
