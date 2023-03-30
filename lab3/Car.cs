using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal class Car : Vehicle
    {
        public Car(int cost, int speed, int year) : base(cost, speed, year) {}

        public override string GetInfo()
        {
            string info = "";

            info += "\n==== Car ==== \n";
            info += $"Cost: {Cost}\n";
            info += $"Speed: {Speed}\n";
            info += $"Year: {Year}";

            return info;
        }

    }
}
