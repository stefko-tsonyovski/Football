using Football_HW.Data.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football_HW.Data.Models
{
    public abstract class Person : IPerson
    {
		private string name;
		private int age;

        public Person(string name, int age)
        {
			this.Name = name;
			this.Age = age;
        }

        public string Name
		{
			get { return this.name; }
			private set 
			{
				if(string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
				{
					throw new ArgumentNullException("Name cannot be null!");
				}

				this.name = value;
            }
        }

		public int Age
		{
			get { return this.age; }
			private set 
			{ 
				if(value <= 0 )
				{
					throw new ArgumentException("Invalid age!");
				}

				this.age = value;
            }
        }
    }
}
