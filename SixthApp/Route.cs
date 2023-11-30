
using System.Drawing;

namespace TransportNetworkSimulation
{
    public class Route
    {
        private Point start;
        private Point end;
        private List<Point> stops;
        private List<int> boardingPassengerCount;
        private List<int> disembarkingPassengerCount;
        private Vehicle vehicle;

        public Point Start
        {
            get { return start; }
            set { start = value; }
        }
        public Point End
        {
            get { return end; }
            set { end = value; }
        }
        public List<Point> Stops
        {
            get { return stops; }
            set { stops = value; }
        }
        public List<int> BoardingPassengerCount
        {
            get { return boardingPassengerCount; }
            set { boardingPassengerCount = value; }
        }
        public List<int> DisembarkingPassengerCount
        {
            get { return disembarkingPassengerCount; }
            set { disembarkingPassengerCount = value; }
        }
        public Vehicle Vehicle
        {
            get { return vehicle; }
            set { vehicle = value; }
        }

        public Route(Point start, Point end)
        {
            this.Start = start;
            this.End = end;

            this.Stops = new List<Point>();
            this.BoardingPassengerCount = new List<int>();
            this.DisembarkingPassengerCount = new List<int>();
        }

        public void AddStop(Point stop, int boardingCount, int disembarkingCount)
        {
            this.Stops.Add(stop);
            this.BoardingPassengerCount.Add(boardingCount);
            this.DisembarkingPassengerCount.Add(disembarkingCount);
        }

        public int CalculateDistance()
        {
            return Math.Abs(Start.X - End.X) + Math.Abs(Start.Y - End.Y);
        }

        public int CalculateTravelTime(Vehicle vehicle)
        {
            return this.CalculateDistance() / vehicle.Speed;
        }

        public bool IsBoardingStop(int index)
        {
            return index % 2 == 0;
        }

        public bool IsDisembarkingStop(int index)
        {
            return index % 2 != 0;
        }
    }
}
