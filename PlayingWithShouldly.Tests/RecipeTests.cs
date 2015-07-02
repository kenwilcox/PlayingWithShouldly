using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shouldly;

namespace PlayingWithShouldly.Tests
{
    public class RecipeTests
    {
        public void ShouldAddIngredients()
        {
            var applePie = new Recipe("Apple Pie");
            applePie.AddIngredient("Apples", 200);
            applePie.AddIngredient("Sugar", 50);
            applePie.AddIngredient("Pastry", 300);

            applePie.Ingredients.ShouldContainKey("Apples");
            applePie.Ingredients.ShouldNotContainKey("Cherries");

            applePie.Ingredients.ShouldContainKeyAndValue("Sugar", 50);
            applePie.Ingredients.ShouldNotContainValueForKey("Sugar", 150);
        }
    }
}


