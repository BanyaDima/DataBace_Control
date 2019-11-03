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
            using (var db = new MatchesEntities())
            {
                var s = db.Matches.ToList();

                foreach (var item in s)
                {
                    Console.WriteLine($"{item.Teams.TeamName} - {item.Teams1.TeamName} {item.TeamAScore}:{item.TeamBScore}\n");
                    Console.WriteLine($"{item.Teams.TeamName} players in this match:\n");
                    foreach (var item1 in item.Teams.Players.ToList())
                    {
                        Console.WriteLine($"\t{item1.Id}.{item1.Name}");
                    }

                    Console.WriteLine($"{item.Teams1.TeamName} players in this match:\n");
                    foreach (var item2 in item.Teams1.Players.ToList())
                    {
                        Console.WriteLine($"\t{item2.Id}.{item2.Name}");
                    }

                    Console.WriteLine("For show next match press any key....");
                    Console.ReadKey();
                    Console.Clear();
                }

            }
        }
    }
}
