using System;
namespace FootballTask
{
	public class Game
	{
		public Team Team1 { get; set; }
		public Team Team2 { get; set; }
		public Referee Referee { get; set; }
        public AssistantReferee AssistantReferee1 { get; set; }
        public AssistantReferee AssistantReferee2 { get; set; }
        public int Team1Score { get; set; }
		public int Team2Score { get; set; }

		public Game(Team team1, Team team2, Referee referee, AssistantReferee assistantReferee1, AssistantReferee assistantReferee2)
		{
			this.Team1 = team1;
			this.Team2 = team2;
			this.Referee = referee;
            this.AssistantReferee1 = assistantReferee1;
            this.AssistantReferee2 = assistantReferee2;
            Team1Score = 0;
            Team2Score = 0;
        }

        public void PrintGoal(int minute, FootballPlayer player, Team scoringTeam)
        {
            string gameResult = $"{scoringTeam.Coach.Name}'s {scoringTeam.Players.Length}-player team scored a goal!";
            Console.WriteLine($"Minute: {minute}, Player: {player.Name}, Game Result: {gameResult}");
        }
        public void ScoreGoal(Team scoringTeam)
        {
            if (scoringTeam == Team1)
            {
                Team1Score++;
            }
            else if (scoringTeam == Team2)
            {
                Team2Score++;
            }
        }
        public string GetWinner()
        {
            if (Team1Score > Team2Score)
            {
                return $"{Team1.Coach.Name}'s {Team1.Players.Length}-player team wins!"+"Team1 wins";
            }
            else if (Team2Score > Team1Score)
            {
                return $"{Team2.Coach.Name}'s {Team2.Players.Length}-player team wins!"+ "Team 2 wins";
            }
            else
            {
                return "It's a draw!";
            }
        }
    }
}

