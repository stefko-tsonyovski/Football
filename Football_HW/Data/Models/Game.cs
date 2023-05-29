using Football_HW.Data.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football_HW.Data.Models
{
    public class Game : IGame
    {
        private GameTeam team1;
        private GameTeam team2;
        private Referee referee;
        private Referee assistentReferee1;
        private Referee assistentReferee2;
        private IEnumerable<Goal> goals;

        public Game(GameTeam team1, GameTeam team2, Referee referee, Referee assistentReferee1, Referee assistentReferee2, List<Goal> goals)
        {
            this.Team1 = team1;
            this.Team2 = team2;
            this.Referee = referee;
            this.AssistentReferee1 = assistentReferee1;
            this.AssistentReferee2 = assistentReferee2;
            this.Goals = goals;
        }

        public  GameTeam Team1 
        { 
            get { return this.team1; } 
            private set 
            { 
                if(value == null)
                {
                    throw new ArgumentNullException("Team 1 cannot be null!");
                }

                this.team1 = value; 
            } 
        }

        public GameTeam Team2 
        { 
            get { return this.team2; }
            private set 
            { 
                if(value == null)
                {
                    throw new ArgumentNullException("Team 2 cannot be null!");
                }

                this.team2 = value; 
            } 
        }

        public Referee Referee 
        { 
            get { return this.referee; } 
            private set 
            { 
                if(value == null)
                {
                    throw new ArgumentNullException("Referee cannot be null!");
                }

                this.referee = value; 
            } 
        }

        public Referee AssistentReferee1 
        { 
            get { return this.assistentReferee1; } 
            private set 
            { 
                if(value == null)
                {
                    throw new ArgumentNullException("Assistent Referee 1 cannot be null!");
                }

                this.assistentReferee1 = value; 
            } 
        }

        public Referee AssistentReferee2 
        { 
            get { return this.assistentReferee2; } 
            private set 
            { 
                if(value == null)
                {
                    throw new ArgumentNullException("Assistent Referee 2 cannot be null");
                }

                this.assistentReferee2 = value; 
            } 
        }

        public IEnumerable<Goal> Goals 
        { 
            get { return this.goals; } 
            private set 
            {
                if(value == null )
                {
                    throw new ArgumentNullException("Goals cannot be null!");
                }

                this.goals = value; 
            } 
        }

        public string GameResult()
        {
            int team1Result = TeamGoals(this.Team1.Players.ToList());
            int team2Result = TeamGoals(this.Team2.Players.ToList());
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Results");
            sb.AppendLine($"Team 1        {team1Result} : {team2Result}        Team 2");
            sb.AppendLine($"Team 1: \n" + this.TeamPlayersScored(this.Team1.Players.ToList()));
            sb.AppendLine($"Team 2: \n" + this.TeamPlayersScored(this.Team2.Players.ToList()));

            return sb.ToString().TrimEnd();
        }


        public string Winner()
        {
            int team1Result = this.TeamGoals(this.Team1.Players.ToList());
            int team2Result = this.TeamGoals(this.Team2.Players.ToList());

            string winner = team1Result > team2Result ? "Team 1" : "Team 2";
            return "Winner: " + winner;
        }

        private int TeamGoals(List<FootballPlayer> players)
        {
            return this.Goals.Count((goal) => players.Any((player) => player.Name == goal.Player.Name));
        }

        private string TeamPlayersScored(IEnumerable<FootballPlayer> players)
        {
            StringBuilder sb = new StringBuilder();
            foreach (Goal goal in this.Goals)
            {
                if (players.Any((player) => player.Name == goal.Player.Name))
                {
                    sb.AppendLine(goal.ToString());
                }
            }

            if (string.IsNullOrEmpty(sb.ToString()))
            {
                return "No Goals";
            }
            return sb.ToString().TrimEnd();
        }
    }
}
