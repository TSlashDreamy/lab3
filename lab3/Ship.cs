using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    class Ship : Vehicle
    {
        private int passengerNum;
        public int PassengerNum { 
            get => passengerNum; 
            set => passengerNum = value < 0 ? throw new Exception("Passenger number can't be negative value") : value; 
        }

        private string port = "Main port";
        public string Port { 
            get => port;
            set => port = value.Length <= 0 ? throw new Exception("Port name can't be empty") : value; 
        } 

        public Ship(int cost, int speed, int year, int passengerNum, string port) : base(cost, speed, year)
        {
            Port = port;
            PassengerNum = passengerNum;
        }

        public override int CalculateCost()
        {
            Cost = Year / 10 + Speed * 10 + passengerNum * 20;
            return Cost;
        }

        public override string GetInfo()
        {
            string info = "";

            info += "\n==== Ship ==== \n";
            info += $"Cost: {Cost}\n";
            info += $"Speed: {Speed}\n";
            info += $"Year: {Year}\n";
            info += $"Passenger number: {PassengerNum}\n";
            info += $"Port: {Port}";

            return info;
        }

    }
}
