using System;

namespace InterfacesApp
{
    class Vehicle
    {
        public int NumPassenger;
        public string Color;
        public double Odometer;

        public Vehicle(int numPas, string col)
        {
            NumPassenger = numPas;
            Color = col;
            Odometer = 0;
        }
        public Vehicle(string col)
        {
            NumPassenger = 5;
            Color = col;
            Odometer = 0;
        }
        public virtual void GetInfo()
        {
            Console.WriteLine($"Num Passenger: {NumPassenger}");
            Console.WriteLine($"Color: {Color}");
            Console.WriteLine($"Miles: {Odometer}");
        }


    }
}