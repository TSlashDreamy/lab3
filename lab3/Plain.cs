using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    class Plain : Vehicle
    {
        private int height;
        public int Height { 
            get => height; 
            set => height = value < 0 ? throw new Exception("Height value can't be negative value") : value;
        }

        private int passengerNum;
        public int PassengerNum { 
            get => passengerNum; 
            set => passengerNum = value < 0 ? throw new Exception("Passenger number can't be negative value") : value; 
        }

        public Plain(int cost, int speed, int year, int height, int passengerNum) : base(cost, speed, year)
        {
            Height = height;
            PassengerNum = passengerNum;
        }

        public override int CalculateCost()
        {
            Cost = Year / 10 + Speed * 10 + Height * 5 + PassengerNum * 20;
            return Cost;
        }

        public override string GetInfo()
        {
            string info = "";

            info += "\n==== Plain ==== \n";
            info += $"Cost: {Cost}\n";
            info += $"Speed: {Speed}\n";
            info += $"Year: {Year}\n";
            info += $"Height: {Height}\n";
            info += $"Passenger number: {PassengerNum}";

            return info;
        }

    }
}
