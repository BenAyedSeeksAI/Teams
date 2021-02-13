using System;
using System.Collections.Generic;
using System.Linq;
namespace Teams
{
    partial class Program
    {
        class League
        {
            public List<Team> teams = new List<Team>();
            public List<Game> games = new List<Game>();

            public League()
            {
                teams.Add(new Team("Manchester United Fc"));
                teams.Add(new Team("Leicester City Fc   "));
                teams.Add(new Team("Manchester City Fc  "));
                teams.Add(new Team("Chelsea Fc          "));
            }
            public void fixture()
            {
                Random rnd = new Random();
                Console.WriteLine("First fixture : ");

                Game game1 = new Game(teams[0], teams[1], rnd.Next(0, 9), rnd.Next(0, 9));
                game1.validateGame();
                games.Add(game1);
                Console.WriteLine(game1.teamHome.name + game1.goalsHome + "-" + game1.goalsAway + "  " + game1.teamAway.name);

                Game game2 = new Game(teams[2], teams[3], rnd.Next(0, 9), rnd.Next(0, 9));
                game2.validateGame();
                games.Add(game2);
                Console.WriteLine(game2.teamHome.name + game2.goalsHome + "-" + game2.goalsAway + "  " + game2.teamAway.name);
            }
            public void fixture1()
            {
                Random rnd = new Random();
                Console.WriteLine("Second fixture : ");

                Game game1 = new Game(teams[2], teams[0], rnd.Next(0, 9), rnd.Next(0, 9));
                game1.validateGame();
                games.Add(game1);
                Console.WriteLine(game1.teamHome.name + game1.goalsHome +"-"+game1.goalsAway + "  "+game1.teamAway.name);

                Game game2 = new Game(teams[1], teams[3], rnd.Next(0, 9), rnd.Next(0, 9));
                game2.validateGame();
                games.Add(game2);
                Console.WriteLine(game2.teamHome.name + game2.goalsHome + "-" + game2.goalsAway +"  "+ game2.teamAway.name);
            }
            public void fixture2()
            {
                Random rnd = new Random();
                Console.WriteLine("Third fixture : ");

                Game game1 = new Game(teams[3], teams[0], rnd.Next(0, 9), rnd.Next(0, 9));
                game1.validateGame();
                games.Add(game1);
                Console.WriteLine(game1.teamHome.name + game1.goalsHome + "-" + game1.goalsAway + "  " + game1.teamAway.name);

                Game game2 = new Game(teams[1], teams[2], rnd.Next(0, 9), rnd.Next(0, 9));
                game2.validateGame();
                games.Add(game2);
                Console.WriteLine(game2.teamHome.name + game2.goalsHome + "-" + game2.goalsAway + "  " + game2.teamAway.name);
            }
            public List<Team> sort()
            {
                List<Team> SortedList = teams.OrderByDescending(o => o.p).ToList();
                return SortedList;
            }
            public void showTable()
            {
                List<Team> OurList = sort();
                Console.WriteLine("League's table :");
                foreach( var item in OurList)
                {
                    Console.WriteLine(item.result());
                }
            }
        }
    }
}
