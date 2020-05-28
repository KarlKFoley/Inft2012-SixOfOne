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
		public Aiplayer(string pSecondPlayer) // Method, when called, creates an AI player to replace Player 2.
		{
			name = pSecondPlayer;
			Score = 0;
		}

		public String AiTurn(Game CurrentGame)
		{
			return "";
		}

		public int CheckPlayerScore(int p1score, int goal) // Calculates how many dice the AI rolls compared to player score.
		{
			int roll = 4; // Default roll
			if (p1score > (goal - 6)) // If player is 6 away from goal, AI rolls 6 dice
            {
				roll = 6;
            }
			else if (Score > (goal - 10)) // If AI is 10 away from goal, AI rolls 1 dice
            {
				roll = 1;
            }
			else if (p1score > Score) // If player is infront of AI, it rolls a number of dice between 3-6
			{
				roll = rnd.Next(3, 7);
			}
			else if (p1score < Score) // If AI is infront of player, it rolls a number of dice between 2-3
			{
				roll = rnd.Next(2, 4);
			}
			return roll;
		}

		private string RollResponce(int roll) // Based on AI roll, it posts a message about its roll
        {
			string botReply = "I hope this is a good roll!"; // Default message
			switch(roll)
            {
				case 1: botReply = "'Perhaps its best to play it safe and role 1'"; break; // If AI rolls a 1
				case 2: botReply = "'I'm not liking my chances, lets just role 2'"; break; // If AI rolls a 2
				case 3: botReply = "'Lets try rolling 3 dice'"; break; // If AI rolls a 3
				case 4: botReply = "'Four should get me where I need to go'"; break; // If AI rolls a 4
				case 5: botReply = "'Better try rolling five for a dash to the finish'"; break; // If AI rolls a 5
				case 6: botReply = "'Its risky, but I need to roll 6 to catch up'"; break; // If AI rolls a 6
			}
			return botReply; // Returns message
        }
    }
}
