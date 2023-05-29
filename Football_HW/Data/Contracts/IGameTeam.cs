using Football_HW.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football_HW.Data.Contracts
{
    public interface IGameTeam 
    {
        public Team Team { get; }

        public IEnumerable<FootballPlayer> Players { get; }
    }
}
