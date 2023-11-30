using System;
using System.Collections.Generic;
using System.Drawing;

namespace TransportNetworkSimulation
{
    class Program
    {
        public static void Main()
        {
            TransportNetwork network = new TransportNetwork();
            Car car = new Car(50, 2);
            Bus bus = new Bus(50, 40);
            Train train = new Train(50, 500);

            network.AddVehicle(car);
            network.AddVehicle(bus);
            network.AddVehicle(train);

            network.SimulateMovement();
        }
    }
}
