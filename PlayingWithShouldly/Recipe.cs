using System;
using System.Collections.Generic;

namespace PlayingWithShouldly
{
    public class Recipe
    {
        public string Name { get; set; }
        public Dictionary<string, int> Ingredients { get; private set; } 

        public Recipe(string name)
        {
            Name = name;
            Ingredients = new Dictionary<string, int>();
        }

        public void AddIngredient(string ingredientName, int weight)
        {
            Ingredients.Add(ingredientName, weight);
        }
    }
}
