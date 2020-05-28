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

		public int CheckPlayerScore(int p1score, int p2score, int goal)
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
			else if (p2score > (goal - 10))
            {
				roll = 1;
            }
			else if (p1score > p2score)
			{
				roll = rnd.Next(3, 7);
			}
			else if (p1score < p2score) {
				roll = rnd.Next(2, 4);
			}
			string message = RollResponce(roll);
			return roll;
		}

		private string RollResponce(int roll)
        {
			string botReply = "I hope this is a good roll!";
			switch(roll)
            {
				case 1: botReply = "'Perhaps its best to play it safe and role 1'"; break;
				case 2: botReply = "'I'm not liking my chances, lets just role 2'"; break;
				case 3: botReply = "'Lets try rolling 3 dice'"; break;
				case 4: botReply = "'Four should get me where I need to go'"; break;
				case 5: botReply = "'Better try rolling five for a dash to the finish'"; break;
				case 6: botReply = "'Its risky, but I need to roll 6 to catch up'"; break;
			}
			return botReply;
        }
    }
}
