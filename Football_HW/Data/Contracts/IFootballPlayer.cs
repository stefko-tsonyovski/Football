using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football_HW.Data.Contracts
{
    public  interface IFootballPlayer
    {
        public int Number { get; }

        public double Height { get; }
    }
}
