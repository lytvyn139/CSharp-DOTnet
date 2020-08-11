using System;
using System.Collections.Generic;

namespace InterfacesApp
{
    class Horse : Vehicle
    {
        public string Name;
        public double Endurance;
        public Horse(string name, double endurance)
        {
            Name = name;
            Endurance = endurance;
        }

    }
}