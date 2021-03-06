﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3PaaStribe
{
    public class Player
    {
        public bool playerTurn { get; set; }
        private string playerName { get; set; }
        private string playerPiece { get; set; }
        private string botPiece { get; set; }

        private static string[] playerPieces = { "X", "O" };

        public Player(string playerName, string playerPiece, bool playerTurn = true)
        {
            this.playerName = playerName;
            this.playerTurn = playerTurn;
            this.playerPiece = playerPiece;
        }

        public string GetPlayerName()
        {
            return playerName;
        }

        public bool GetPlayerTurn()
        {
            return playerTurn;
        }

        public string GetPlayerPiece()
        {
            return playerPiece;
        }

        public void SetPlayerPiece(string t)
        {
            this.playerPiece = playerPieces[Convert.ToInt32(t)];
        }

        public string SetPiece()
        {
            if (GetPlayerPiece() == "X")
            {
                botPiece = "O";
            }
            else
            {
                botPiece = "X";
            }
            return botPiece;
        }

        public bool PlayerPieces(string t)
        {
            if(playerPieces.Contains(t))
            {
                return true;
            }
            return false;
        }

    }
}
