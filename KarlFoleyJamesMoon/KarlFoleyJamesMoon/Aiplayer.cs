using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KarlFoleyJamesMoon
{
	public class Aiplayer : Player
	{
		private Random rnd;
		public Aiplayer(string pSecondPlayer) 
		{
			name = pSecondPlayer;
			Score = 0;
		}

		public String AiTurn(Game CurrentGame)
		{
			return "";
		}

		public int CheckPlayerScore(int p1score, int goal)
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
			if (p1score > (goal - 6))
            {
				roll = 6;
            }
			else if (Score > (goal - 10))
            {
				roll = 1;
            }
			else if (p1score > Score)
			{
				roll = rnd.Next(3, 7);
			}
			else if (p1score < Score) {
				roll = rnd.Next(2, 4);
			}
			string message = RollResponce(roll);
			return (roll, message);
		}

		private string RollResponce(int roll)
        {
			string botReply;
			switch(roll)
            {
				case 1: botReply = "'Perhaps its best to play it safe and role 1'";
				case 2: botReply = "'I'm not liking my chances, lets just role 2'";
				case 3: botReply = "'Lets try rolling 3 dice'";
				case 4: botReply = "'Four should get me where I need to go'";
				case 5: botReply = "'Better try rolling five for a dash to the finish'";
				case 6: botReply = "'Its risky, but I need to roll 6 to catch up'";
			}
			return botReply;
        }
    }
}
