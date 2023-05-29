using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football_HW.Data.Models
{
    public class GoalKeeper : FootballPlayer
    {
        public GoalKeeper(string name, int age, int number, double height) 
            : base(name, age, number, height)
        {
        }
    }
}
