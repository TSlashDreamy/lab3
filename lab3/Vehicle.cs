using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    abstract class Vehicle
    {
        private int cost;
        public int Cost { 
            get => cost; 
            set => cost = value < 0 ? throw new Exception("Cost can't be negative value") : value; 
        }
        
        private int speed;
        public int Speed { 
            get => speed; 
            set => speed = value < 0 ? throw new Exception("Speed can't be negative value") : value; 
        }
        
        private int year;
        public int Year { 
            get => year; 
            set => year = value < 950 ? throw new Exception("Year is too low") : value; 
        }

        protected Vehicle(int cost, int speed, int year)
        {
            Cost = cost;
            Speed = speed;
            Year = year;
        }

        public virtual int CalculateCost() { 
            Cost = Year / 10 + Speed * 10;
            return cost;
        }

        public virtual string GetInfo() {
            string info = "";

            info += "\n==== Vehicle ==== \n";
            info += $"Cost: {Cost}\n";
            info += $"Speed: {Speed}\n";
            info += $"Year: {Year}";

            return info;
        }

    }
}
