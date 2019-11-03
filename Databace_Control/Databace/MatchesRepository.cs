using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Databace
{
    public class MatchesRepository
    {
        public void GetInfo()
        {
            using (var dbMatch = new MatchesEntities())
            {
                var matches = dbMatch.Matches.ToList();

                foreach (var match in matches)
                {
                    Console.WriteLine($"{match.Teams.TeamName} - {match.Teams1.TeamName} {match.TeamAScore}:{match.TeamBScore}\n");
                    Console.WriteLine($"\n{match.Teams.TeamName} players in this match:\n");
                    foreach (var playerTeamA in match.Teams.Players.ToList())
                    {
                        Console.WriteLine($"\t{playerTeamA.Id}.{playerTeamA.Name}");
                    }

                    Console.WriteLine($"\n{match.Teams1.TeamName} players in this match:\n");
                    foreach (var playerTeamB in match.Teams1.Players.ToList())
                    {
                        Console.WriteLine($"\t{playerTeamB.Id}.{playerTeamB.Name}");
                    }

                    Console.WriteLine("\nFor show next match press any key....");
                    Console.ReadKey();
                    Console.Clear();
                }

            }
        }
    }
}
