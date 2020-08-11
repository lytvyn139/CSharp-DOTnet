using System;
using System.Collections.Generic;

namespace InterfacesApp
{
    class Car : Vehicle, IRideable
    {
        public string Make;
        public string Model;

        //this must me public 
        public double DistanceTraveled
        {
            get { return Odometer; }
            set { Odometer = value; }
        }

        public void Ride(double distance)
        {

        }


        public Car(string color, string make, string model) : base(color)
        {
            Make = make;
            Model = model;
        }
        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"Make: {Make}");
            Console.WriteLine($"Model: {Model}");

        }

    }
}