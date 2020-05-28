using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KarlFoleyJamesMoon
{
	class Aiplayer : Player
	{
		private Random rnd;
		Aiplayer() { }

		public String AiTurn(Game CurrentGame)
		{
			return "";
		}

		public int CheckPlayerScore(int p1score, int p2score)
		{
			int roll = 4;
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
			if (p1score > p2score)
			{
				roll = rnd.Next(3, 7);
			}
			if (p1score < p1score) {
				roll = rnd.Next(2, 4);
			}
			string message = OnCall(roll);
			return (roll, message);
		}

		private string OnCall(int roll)
        {
			string botReply;
			switch(roll)
            {
				case 2: botReply = "";
				case 3: botReply = "";
				case 4: botReply = "";
				case 5: botReply = "";
				case 6: botReply = "";
			}
			return botReply;
        }
    }
}
