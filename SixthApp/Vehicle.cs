
namespace TransportNetworkSimulation
{
    public abstract class Vehicle
    {
        private int speed;
        private int capacity;
        private int passengerCount;

        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }
        public int Capacity
        {
            get { return capacity; }
            set { capacity = value; }
        }

        public int PassengerCount
        {
            get { return passengerCount; }
            set { passengerCount = value; }
        }

        public abstract void Move();
        public abstract Route GetNextRoute();
        public abstract void BoardPassengers(int count);
        public abstract void UnboardPassengers(int count);
        public int GetRandomCoordinate()
        {
            Random random = new Random();
            return random.Next(1, 100);
        }
    }
}
