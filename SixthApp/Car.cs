

using System.Drawing;

namespace TransportNetworkSimulation
{
    public class Car : Vehicle
    {
        public Car(int speed, int capacity)
        {
            this.Speed = speed;
            this.Capacity = capacity;
        }

        public override void Move()
        {
            Console.WriteLine("Car is moving.");
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
                Console.WriteLine($"{count} passengers boarded the Car");
                this.PassengerCount += count;
            }
            else
            {
                Console.WriteLine($"Not enough empty seats to board {count} passengers in Car");
            }
        }

        public override void UnboardPassengers(int count)
        {
            Console.WriteLine($"{count} passengers disembarked from the Car");
            this.PassengerCount -= count;
        }
    }
}
