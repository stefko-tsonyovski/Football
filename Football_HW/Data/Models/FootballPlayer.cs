using Football_HW.Data.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football_HW.Data.Models
{
    public abstract class FootballPlayer : Person, IFootballPlayer
    {
        private int number;
        private double height;

        public FootballPlayer(string name, int age, int number, double height) 
            : base(name, age)
        {
            this.Number = number;
            this.Height = height;
        }

        public int Number
        { 
            get { return this.number; }
            private set 
            {
                if(value < 0)
                {
                    throw new ArgumentException("Invalid player number!");
                }

                this.number = value;
            }
        }

        public double Height 
        { 
            get { return this.height; } 
            private set 
            {
                if(value <= 0)
                {
                    throw new ArgumentException("Invalid player height!");
                }

                this.height = value;
            }  
        }

    }
}
