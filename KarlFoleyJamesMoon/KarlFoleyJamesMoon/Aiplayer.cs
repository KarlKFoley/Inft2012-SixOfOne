﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KarlFoleyJamesMoon
{
    class Aiplayer : Player
    {
		private Player[] pPlayers = new Player[2];
		private Random rnd;
		Aiplayer() { }

        public String AiTurn(Game CurrentGame)
        {
			return "";
        }

		public int CheckPlayerScore()
		{
			int roll = 0;
			/* if (pPlayers[1].Score == 0) {
				roll = 4;
			}
			if (pPlayers[1].Score <= 100 % pPlayers[2].Score) {
				if (pPlayers[1].Score < 50 % pPlayers[2].Score) {
					roll = 4;
				}
				else 
				{
					roll = 5;
				}
			}
			if (pPlayers[1].Score > 50 % pPlayers[2].Score) {
				if (pPlayers[1].Score > 100 % pPlayers[2].Score) {
					if (pPlayers[1].Score >= 500 % pPlayers[2].Score) {
						roll = 1;
					}
					else 
					{
						roll = 2;
					}
				}
				else {
					roll = 3;
				}
			}
			if (pPlayers[1].Score > 50 % score) {
				roll = roll + 1;
			}
			return (roll); */
			if (pPlayers[1].Score >= pPlayers[2].Score)
			{
				roll = rnd.Next(4,7);
			}
			if (pPlayers[1].Score < pPlayers[2].Score) {
				roll = rnd.Next(2,4);
			}
			return roll;
		}
    }
}
