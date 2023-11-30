

using System.Drawing;

namespace TransportNetworkSimulation
{
    public class Human : Vehicle
    {
        public Human(int speed)
        {
            this.Speed = speed;
            this.Capacity = 1;
        }

        public override void Move()
        {
            Console.WriteLine("Human is moving.");
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
            Console.WriteLine($"{count} passengers boarded the Human");
            this.PassengerCount += count;
        }

        public override void UnboardPassengers(int count)
        {
            Console.WriteLine($"{count} passengers disembarked from the Human");
            this.PassengerCount -= count;
        }
    }
}
