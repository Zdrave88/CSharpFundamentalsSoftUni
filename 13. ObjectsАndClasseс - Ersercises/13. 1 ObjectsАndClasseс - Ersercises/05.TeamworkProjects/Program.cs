using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int teamCount = int.Parse(Console.ReadLine());
        List<Team> teams = new List<Team>();

        // Team creation phase
        for (int i = 0; i < teamCount; i++)
        {
            string[] teamInput = Console.ReadLine().Split("-");
            string creator = teamInput[0];
            string teamName = teamInput[1];

            bool teamExists = false;
            bool creatorExists = false;

            // Check if team name or creator already exists
            foreach (var team in teams)
            {
                if (team.TeamName == teamName)
                    teamExists = true;
                if (team.Creator == creator)
                    creatorExists = true;
            }

            if (teamExists)
                Console.WriteLine($"Team {teamName} was already created!");
            else if (creatorExists)
                Console.WriteLine($"{creator} cannot create another team!");
            else
            {
                teams.Add(new Team(teamName, creator));
                Console.WriteLine($"Team {teamName} has been created by {creator}!");
            }
        }

        // Joining phase
        while (true)
        {
            string input = Console.ReadLine();
            if (input == "end of assignment")
                break;

            string[] joinInput = input.Split("->");
            string user = joinInput[0];
            string teamName = joinInput[1];

            Team teamToJoin = null;
            bool userInOtherTeam = false;

            foreach (var team in teams)
            {
                if (team.TeamName == teamName)
                    teamToJoin = team;
                if (team.Creator == user || team.Members.Contains(user))
                    userInOtherTeam = true;
            }

            if (teamToJoin == null)
                Console.WriteLine($"Team {teamName} does not exist!");
            else if (userInOtherTeam)
                Console.WriteLine($"Member {user} cannot join team {teamName}!");
            else
                teamToJoin.Members.Add(user);
        }

        // Output the valid teams sorted by member count (descending) and then by team name
        List<Team> teamsToDisband = new List<Team>();

        teams.Sort((a, b) => b.Members.Count.CompareTo(a.Members.Count) == 0
            ? a.TeamName.CompareTo(b.TeamName)
            : b.Members.Count.CompareTo(a.Members.Count));

        foreach (var team in teams)
        {
            if (team.Members.Count == 0)
            {
                teamsToDisband.Add(team);
                continue;
            }

            Console.WriteLine($"{team.TeamName}");
            Console.WriteLine($"- {team.Creator}");
            team.Members.Sort();
            foreach (var member in team.Members)
            {
                Console.WriteLine($"-- {member}");
            }
        }

        // Output the teams that need to disband
        Console.WriteLine("Teams to disband:");
        teamsToDisband.Sort((a, b) => a.TeamName.CompareTo(b.TeamName));
        foreach (var team in teamsToDisband)
        {
            Console.WriteLine(team.TeamName);
        }
    }
}

class Team
{
    public string TeamName { get; set; }
    public string Creator { get; set; }
    public List<string> Members { get; set; }

    public Team(string teamName, string creator)
    {
        TeamName = teamName;
        Creator = creator;
        Members = new List<string>();
    }
}