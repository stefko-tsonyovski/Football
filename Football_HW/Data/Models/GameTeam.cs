using Football_HW.Data.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football_HW.Data.Models
{
    public class GameTeam : IGameTeam
    {
        private Team team;
        private IEnumerable<FootballPlayer> players;


        public GameTeam(Team team, List<FootballPlayer> players)
        {
            this.Team = team;
            this.Players = players;
        }

        public Team Team 
        { 
            get { return this.team; } 
            private set 
            {
                if(value == null)
                {
                    throw new ArgumentNullException("Team cannot be null!");
                }

                this.team = value;
            } 
        }

        public IEnumerable<FootballPlayer> Players 
        { 
            get { return this.players; }
            private set 
            {
                if(value == null)
                {
                    throw new ArgumentNullException("Players cannot be null");
                }

                if (value.Count() != 11)
                {
                    throw new ArgumentException("Players in game should be 11 only!");
                }

                this.players = value;
            } 
        }    


    }
}
