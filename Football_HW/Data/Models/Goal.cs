using Football_HW.Data.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football_HW.Data.Models
{
    public class Goal : IGoal
    {
        private int minute;
        private FootballPlayer player;

        public Goal(int minute, FootballPlayer player)
        {
            this.Minute = minute;
            this.Player = player;
        }

        public int Minute 
        { 
            get { return this.minute; } 
            private set { 
                if(value < 0) 
                {
                    throw new ArgumentException("Invalid minute");
                }

                this.minute = value; 
            } 
        }

        public FootballPlayer Player 
        { 
            get { return this.player; } 
            private set {
                if(value == null)
                {
                    throw new ArgumentNullException("Player cannot be null!");
                }
                this.player = value; 
            } 
        }

        public override string ToString()
        {
            return $"{this.Player.Name} {this.Minute}'";
        }
    }
}
