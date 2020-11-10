using System;
using System.Collections.Generic;

// User will be able to Check items inside of a fridge
// and add items, remove items, and check expiration date for fridge item.

// clarification
// remove individual items from the fridge, OR multiple items!
//
namespace ClassExcersise_FridgeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    // what is an item?
    public class Food
    {
        public string Name { get; set; }
        public DateTime ExpirateDate { get; set; }
    }

    public interface IAddFood
    {
        void AddFood(Food food);

    }

    public interface IRemoveFood
    {
        List<Food> RemoveFood(string name);
        List<Food> RemoveFood(List<string> names);
    }

    public class Fridge : IRemoveFood, IAddFood
    {
        private List<Food> _foodInTheFridge = new List<Food>();


        public void AddFood(Food food)
        {
            _foodInTheFridge.Add(food);
        }

        public List<Food> RemoveFood(string name)
        {
            var removedFoods = new List<Food>();
            foreach (var food in _foodInTheFridge)
            {
                if (food.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    this._foodInTheFridge.Remove(food);
                    removedFoods.Add(food);
                }
            }

            return removedFoods;
        }


        // A user wants to remove MULTIPLE NAMED food items from their fridge, and if they have MULTIPLE 
        // food ITEM of that name, remove those as well.
        // ie, if a fridge has three tomatoes, and the user wants to remove "tomatoe" they will remove ALL 
        // three tomatoes from the fridge.
        public List<Food> RemoveFood(List<string> names)
        {

            var removedFoods = new List<Food>();

            // Tomato, Pickle, Milk 
            foreach (var name in names)
            {
                var listOfRemovedFoods = RemoveFood(name);
                removedFoods.AddRange(listOfRemovedFoods);
            }

            return removedFoods;
        }
    }
}
