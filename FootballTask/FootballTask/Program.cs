// See https://aka.ms/new-console-template for more information
using FootballTask;
//Team1(RealMadrid players)
GoalKeeper GoalKeeper1 = new GoalKeeper ("COURTOIS", 1,35,1.95);
Defender defender1 = new Defender ("Carvajal" , 2, 26, 1.85);
Defender defender2 = new Defender ("ALABA", 3, 27, 1.75);
Defender defender3 = new Defender ("NACHO", 4, 28, 1.90);
Defender defender4 = new Defender ("LUCAS V.", 5, 24, 1.82);
Midfielder midfielder1 = new Midfielder ("KROOS", 6, 25, 1.83);
Midfielder midfielder2 = new Midfielder ("MODRIC", 7, 26, 1.76);
Midfielder midfielder3 = new Midfielder ("CAMAVINGA", 8, 27, 1.88);
Midfielder midfielder4 = new Midfielder ("VALVERDE", 9, 23, 1.70);
Striker striker1 = new Striker ("BENZEMA", 10, 24, 1.75);
Striker striker2 = new Striker ("HAZARD", 11, 25, 1.80);

FootballPlayer[] playersTeam1 = new FootballPlayer[]
{
    GoalKeeper1,
    defender1,
    defender2,
    defender3,
    defender4,
    midfielder1,
    midfielder2,
    midfielder3,
    midfielder4,
    striker1,
    striker2
};
//Team2(Juventus players)
GoalKeeper goalkeeper2 = new GoalKeeper ("WOCHZIEH", 1, 26, 1.82);
Defender defender5 = new Defender ("DANILO", 2, 27, 1.85);
Defender defender6 = new Defender ("RICCIO", 3, 28, 1.75);
Defender defender7 = new Defender ("SANDRO", 4, 24, 1.90);
Defender defender8 = new Defender ("PERIN", 5, 25, 1.82);
Midfielder midfielder5 = new Midfielder ("POGBA", 6, 26, 1.83);
Midfielder midfielder6 = new Midfielder ("KOSTIC", 7, 27, 1.76);
Midfielder midfielder7 = new Midfielder ("RABIOT", 8, 23, 1.88);
Midfielder midfielder8 = new Midfielder ("PAREDES", 9, 24, 1.70);
Striker striker3 = new Striker ("MIRETTI", 10, 25, 1.75);
Striker striker4 = new Striker ("DI MARIA", 11, 30, 1.80);

FootballPlayer[] playersTeam2 = new FootballPlayer[]
{
    goalkeeper2,
    defender5,
    defender6,
    defender7,
    defender8,
    midfielder5,
    midfielder6,
    midfielder7,
    midfielder8,
    striker3,
    striker4
};

    
Coach coach = new Coach ("ALLEGRI",  40);
Coach coach1 = new Coach("ANCELOTTI", 50);  
Referee referee = new Referee ("Mark", 35);
    
AssistantReferee assistantReferee1 = new AssistantReferee  ("Adam", 30 );    
AssistantReferee assistantReferee2 = new AssistantReferee  ("Brian", 32 );
    
Team team1 = new Team(coach, playersTeam1);
Team team2 = new Team(coach, playersTeam2);    

Game game = new Game(team1, team2, referee, assistantReferee1, assistantReferee2);   
Console.WriteLine($"--Match is starting-");    
Console.WriteLine($"Our referee today is {referee.Name}");    
Console.WriteLine($"Assistant referees are {assistantReferee1.Name} and {assistantReferee2.Name}");
Console.WriteLine($"The Average age of a team1 players is {team1.PrintAverageAge()}");
Console.WriteLine($"The Average age of a team2 players is {team2.PrintAverageAge()}");

game.PrintGoal(10, striker1, team1);    
game.ScoreGoal(team1);    
game.PrintGoal(13, striker3, team2);    
game.ScoreGoal(team2);    
game.PrintGoal(65, striker3, team2);    
game.ScoreGoal(team2);
string winner = game.GetWinner();
Console.WriteLine($"--End of the Match--");
Console.WriteLine($"Winner: {winner}");

   
