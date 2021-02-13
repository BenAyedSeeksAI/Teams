namespace Teams
{
    partial class Program
    {
        class Game
        {
            public Team teamHome;
            public Team teamAway;
            public int goalsHome;
            public int goalsAway;
            public Game(Team teamHome, Team teamAway, int goalsHome, int goalsAway)
            {
                this.teamHome = teamHome;
                this.teamAway = teamAway;
                this.goalsHome = goalsHome;
                this.goalsAway = goalsAway;
            }
            public void validateGame()
            {
                if ( goalsHome > goalsAway)
                {
                    teamHome.win(goalsHome, goalsAway);
                    teamAway.lose(goalsAway, goalsHome);
                }
                else if (goalsHome < goalsAway)
                {
                    teamHome.lose(goalsHome, goalsAway);
                    teamAway.win(goalsAway, goalsHome);
                }else
                {
                    teamHome.draw(goalsHome, goalsAway);
                    teamAway.draw(goalsAway, goalsHome);
                }
            }
        }
    }
}
