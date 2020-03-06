using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.TeamworkProjects
{
    class Program
    {
        static void Main(string[] args)
        {
            int teamsCount = int.Parse(Console.ReadLine());
            List<Team> teams = new List<Team>();

            for (int i = 0; i < teamsCount; i++)
            {

                string[] input = Console.ReadLine().Split('-').ToArray();
                List<string> membersList = new List<string>();
                Team team = new Team();
                team.Creator = input[0];
                team.Name = input[1];
                team.Member = membersList;

                if (!teams.Select(x => x.Name).Contains(team.Name))
                {
                    if (!teams.Select(x => x.Creator).Contains(team.Creator))
                    {
                        teams.Add(team);
                        Console.WriteLine($"Team {team.Name} has been created by {team.Creator}!");
                    }
                    else
                    {
                        Console.WriteLine($"{team.Creator} cannot create another team!");
                        
                    }
                }
                else
                {
                    Console.WriteLine($"Team {team.Name} was already created!");
                }
            }
            string nextInput = Console.ReadLine();

            while (nextInput!="end of assignment")
            {
                string[] input = nextInput.Split(new char[]{ '-','>'}).ToArray();
                string user = input[0];
                string teamToJoin = input[2];

                if (!teams.Select(t => t.Name).Contains(teamToJoin))
                {
                    Console.WriteLine($"Team {teamToJoin} does not exist!");
                    
                }
                else if (teams.Select(x => x.Member).Any(x => x.Contains(user)) || teams.Select(x=> x.Creator).Contains(user))
                {
                    Console.WriteLine($"Member {user} cannot join team {teamToJoin}!");
                }
                else
                {
                    int index = teams.FindIndex(x => x.Name == teamToJoin);
                    teams[index].Member.Add(user);
                }
                nextInput = Console.ReadLine();
            }

            var disbandedTeams = teams.OrderBy(x => x.Name).Where(x => x.Member.Count == 0);
            var finalTeams = teams.OrderByDescending(x => x.Member.Count).ThenBy(x => x.Name).Where(x => x.Member.Count > 0);

            foreach (var team in finalTeams)
            {
                Console.WriteLine($"{team.Name}");
                Console.WriteLine($"- {team.Creator}");
                foreach (var member in team.Member.OrderBy(x=>x))
                {
                    Console.WriteLine($"-- {member}");
                }
            }
            Console.WriteLine("Teams to disband:");
            foreach (var team in disbandedTeams)
            {
                Console.WriteLine(team.Name);
            }
        }
    }
    class Team
    {
        public string Name { get; set; }
        public string Creator { get; set; }
        public List<string> Member { get; set; }

    }
}
