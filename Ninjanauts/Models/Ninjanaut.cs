using System.Collections.Generic;
using Ninjanauts.Interfaces;

namespace Ninjanauts.Models
{
    public abstract class Ninjanaut
    {
        public string Name;
        protected int calorieIntake;
        public List<ILearnable> ConsumptionHistory;
        public Ninjanaut(string name)
        {
            Name = name;
            calorieIntake = 0;
            ConsumptionHistory = new List<ILearnable>();
        }
        public abstract bool IsFull { get; }
        public abstract void Consume(ILearnable item);
    }
}