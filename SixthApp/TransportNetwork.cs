using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportNetworkSimulation
{
    public class TransportNetwork
    {
        private List<Vehicle> vehicles;
        public List<Vehicle> Vehicles
        {
            get { return vehicles; }
            set { vehicles = value; }
        }

        public TransportNetwork()
        {
            this.Vehicles = new List<Vehicle>();
        }

        public void AddVehicle(Vehicle vehicle)
        {
            this.Vehicles.Add(vehicle);
        }

        public void SimulateMovement()
        {
            foreach (Vehicle vehicle in this.Vehicles)
            {
                Route route = vehicle.GetNextRoute();

                if (route != null)
                {
                    SimulateTravel(route);
                }
            }
        }

        public void SimulateTravel(Route route)
        {
            if (route.Vehicle == null)
            {
                Console.WriteLine("Error: Route's Vehicle is null.");
                return;
            }

            route.Vehicle.Move();

            for (int i = 0; i < route.Stops.Count; ++i)
            {
                Point stop = route.Stops[i];
                if (route.IsBoardingStop(i))
                {
                    BoardPassengersAtStop(route, route.BoardingPassengerCount[i]);
                }
                else if (route.IsDisembarkingStop(i))
                {
                    UnboardPassengersAtStop(route, route.DisembarkingPassengerCount[i]);
                }
            }
        }

        public void BoardPassengersAtStop(Route route, int count)
        {
            if (route.Vehicle.Capacity >= count)
            {
                route.Vehicle.BoardPassengers(count);

                route.Vehicle.PassengerCount += count;
            }
            else
            {
                Console.WriteLine($"Not enough empty seats to board {count} passengers");
            }
        }

        public void UnboardPassengersAtStop(Route route, int count)
        {
            route.Vehicle.UnboardPassengers(count);

            route.Vehicle.PassengerCount -= count;
        }

        public Route CalculateOptimalRoute(Point start, Point end, Vehicle vehicle)
        {
            List<Route> routes = GetAllRoutes(start, end);

            Route optimalRoute = null;
            int minTravelTime = int.MaxValue;

            foreach (Route route in routes)
            {
                route.Vehicle = vehicle;

                int travelTime = route.CalculateTravelTime(vehicle);
                if (travelTime < minTravelTime)
                {
                    minTravelTime = travelTime;
                    optimalRoute = route;
                }
            }

            return optimalRoute;
        }

        public List<Route> GetAllRoutes(Point start, Point end)
        {
            Route route = new Route(start, end);
            route.Vehicle = this.Vehicles.FirstOrDefault(); // Set the vehicle property
            route.AddStop(new Point(GetRandomCoordinate(), GetRandomCoordinate()), 10, 0);
            route.AddStop(new Point(GetRandomCoordinate(), GetRandomCoordinate()), 0, 5);

            return new List<Route> { route };
        }

        private int GetRandomCoordinate()
        {
            Random random = new Random();
            return random.Next(1, 100);
        }
    }
}
