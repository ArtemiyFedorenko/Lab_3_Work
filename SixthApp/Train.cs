

using System.Drawing;

namespace TransportNetworkSimulation
{
    public class Train : Vehicle
    {
        public Train(int speed, int capacity)
        {
            this.Speed = speed;
            this.Capacity = capacity;
        }

        public override void Move()
        {
            Console.WriteLine("Train is moving.");
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
                Console.WriteLine($"{count} passengers boarded the Train");
                this.PassengerCount += count;
            }
            else
            {
                Console.WriteLine($"Not enough empty seats to board {count} passengers in Train");
            }
        }

        public override void UnboardPassengers(int count)
        {
            Console.WriteLine($"{count} passengers disembarked from the Train");
            this.PassengerCount -= count;
        }
    }
}
