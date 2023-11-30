using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportNetworkSimulation
{
    public class Bus : Vehicle
    {
        public Bus(int speed, int capacity)
        {
            this.Speed = speed;
            this.Capacity = capacity;
        }

        public override void Move()
        {
            Console.WriteLine("Bus is moving.");
        }

        public override Route GetNextRoute()
        {
            Point start = new Point(GetRandomCoordinate(), GetRandomCoordinate());
            Point end = new Point(GetRandomCoordinate(), GetRandomCoordinate());
            TransportNetwork transportNetwork = new TransportNetwork();

            return transportNetwork.CalculateOptimalRoute(start, end, this);
        }

        public override void BoardPassengers(int count)
        {
            if (this.Capacity >= count)
            {
                Console.WriteLine($"{count} passengers boarded the Bus");
                this.PassengerCount += count;
            }
            else
            {
                Console.WriteLine($"Not enough empty seats to board {count} passengers in Bus");
            }
        }

        public override void UnboardPassengers(int count)
        {
            Console.WriteLine($"{count} passengers disembarked from the Bus");
            this.PassengerCount -= count;
        }
    }
}
