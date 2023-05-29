using Football_HW.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football_HW.Data.Contracts
{
    public interface IGame
    {
        public GameTeam Team1 { get; }
        
        public GameTeam Team2 { get; }

        public Referee Referee { get; }

        public Referee AssistentReferee1 { get; }

        public Referee AssistentReferee2 { get; }

        public string GameResult();

        public string Winner();
    }
}
