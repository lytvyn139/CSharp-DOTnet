/* 
Create a Ninja class
add a constructor that sets calorieIntake to 0 and creates a new, empty list of Food objects to FoodHistory
add a public "getter" property called "IsFull" that returns a boolean based on if the Ninja's calorie intake is greater than 1200 calories
build out the Eat method that: if the Ninja is NOT full

adds calorie value to ninja's total calorieIntake
adds the randomly selected Food object to ninja's FoodHistory list
writes the Food's Name - and if it is spicy/sweet to the console
if the Ninja IS full
issues a warning to the console that the ninja is full and cannot eat anymore
*/
using System;
using System.Collections.Generic;

namespace HungryNinja.Models
{
    class Ninja
    {
        private int calorieIntake;
        public List<Food> FoodHistory;

        // add a constructor
        public Ninja()
        {
            calorieIntake = 0;
            FoodHistory = new List<Food>();
        }

        //add a public "getter" property called "IsFull" that returns a boolean based on if the Ninja's calorie intake is greater than 3200 calories
        public bool IsFull
        {
            get
            {
                return calorieIntake > 3200;
            }
        }

        /* 
            build out the Eat method that: if the Ninja is NOT full
            adds calorie value to ninja's total calorieIntake
            adds the randomly selected Food object to ninja's FoodHistory list
            writes the Food's Name - and if it is spicy/sweet to the console
         */
        public void Eat(Food item)
        {
            if (IsFull == true)
            {
                Console.WriteLine($"I'm so full, can't take it anymorem, total {calorieIntake}");
            }
            else
            {
                calorieIntake += item.Calories;
                FoodHistory.Add(item); //adding data to Food lsit 
                Console.WriteLine($"Nom nom {item.Name}, spicy? {item.IsSpicy}, maybe sweet? {item.IsSweet}, calories: {item.Calories}");
            }
        }
    }
}