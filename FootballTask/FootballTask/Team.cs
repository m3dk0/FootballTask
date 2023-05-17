using System;
namespace FootballTask
{
    public class Team
    {
        public Coach Coach { get; set; }
        public FootballPlayer[] Players { get; set; }
        public double AverageAge
        {
            get
            {
                return PrintAverageAge();
            }
        }

        public Team(Coach coach, FootballPlayer[] players)
        {
            if (players.Length < 11 || players.Length > 22)
            {
                throw new ArgumentException("The number of players should be between 11 and 22.");
            }

            Coach = coach;
            Players = players;
        }
        public double PrintAverageAge()
        {
            int totalAge = 0;
            int playerCount = 0;

            foreach (FootballPlayer player in Players)
            {
                if (player != null)
                {
                    totalAge += player.Age;
                    playerCount++;
                }
            }

            if (playerCount > 0)
            {
                return (double)totalAge / playerCount;
            }
            else
            {
                return 0;
            }
        }
    }
}
	