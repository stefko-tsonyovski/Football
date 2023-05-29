using Football_HW.Data.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football_HW.Data.Models
{
    public class Team : ITeam
    {
        private Coach coach;
        private IEnumerable<FootballPlayer> players;

        public Team(Coach coach, List<FootballPlayer> players)
        {
            this.Coach = coach;
            this.Players = players;
        }

        public Coach Coach 
        { 
            get { return this.coach; } 
            private set {
                if(value == null)
                {
                    throw new ArgumentNullException("Coach cannot be null!");
                }

                this.coach = value; 
            } }

        public IEnumerable<FootballPlayer> Players { 
            get { return this.players;} 
            private set
            {
                if(value == null)
                {
                    throw new ArgumentNullException("Players cannot be null!");
                }

                if (value.Count() < 11 || value.Count() > 22)
                {
                    throw new ArgumentException("Players must be min 11, up to 22!");
                }

                this.players = value;
            } 
        }

        public int AverageAgeOfPlayers() => (int)Math.Round(this.players.Average((p) => p.Age));
    }
}
