using Microsoft.VisualStudio.TestTools.UnitTesting;
using AaliyahAllie_ST10212542_PROG6221_PART2_POE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AaliyahAllie_ST10212542_PROG6221_PART2_POE.Tests
{
    [TestClass()]
    public class RecipeTests
    {
        [TestMethod()]
        public void ScaleRecipeTest()
        {
            Recipe recipe = new Recipe("Test Recipe");
            recipe.AddIngredients("Ingredient 1", 100, "mg", 50);
            recipe.AddIngredients("Ingredient 2", 200, "ml", 100);

            double factor = 2;

            recipe.ScaleRecipe(factor);

            Assert.AreEqual(200, recipe.Ingredients.First().Quantity);
            Assert.AreEqual(100 * factor, recipe.Ingredients.Last().Calories);
        }
    }
}