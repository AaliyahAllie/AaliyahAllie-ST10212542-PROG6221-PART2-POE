using Microsoft.VisualStudio.TestTools.UnitTesting;
using AaliyahAllie_ST10212542_PROG6221_PART2_POE;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AaliyahAllie_ST10212542_PROG6221_PART2_POE.Tests
{
    [TestClass()]
    public class RecipeTests
    {
        [TestMethod()]
        public void ScaleRecipeTest()
        {
            // Arrange
            Recipe recipe = new Recipe("Test Recipe");
            recipe.AddIngredients("Ingredient 1", 100, "mg", 50);
            recipe.AddIngredients("Ingredient 2", 200, "ml", 100);

            double factor = 2;

            // Act
            recipe.ScaleRecipe(factor);

            // Assert
            Assert.AreEqual(200, recipe.Ingredients.First().Quantity);
            Assert.AreEqual(100 * factor, recipe.Ingredients.Last().Calories);
        }

        [TestMethod()]
        public void ResetRecipeTest()
        {
            // Arrange
            Recipe recipe = new Recipe("Test Recipe");
            recipe.AddIngredients("Ingredient 1", 100, "mg", 50);
            recipe.AddIngredients("Ingredient 2", 200, "ml", 100);

            // Act
            recipe.ResetRecipe();

            // Assert
            Assert.AreEqual(0, recipe.Ingredients.Count); // Assuming ResetRecipe clears all ingredients.
        }

        [TestMethod]
        public void TestCalculateTotalCalories_NoIngredients()
        {
            // Arrange
            Recipe recipe = new Recipe("Test Recipe");

            // Act
            double totalCalories = recipe.CalculateTotalCalories();

            // Assert
            Assert.AreEqual(0, totalCalories);
        }

        // Other test methods unchanged

        [TestMethod]
        public void TestCalculateTotalCalories_Overflow()
        {
            // Arrange
            Recipe recipe = new Recipe("Test Recipe");
            recipe.AddIngredients("Ingredient 1", int.MaxValue, "g", double.MaxValue);

            // Act
            double totalCalories = recipe.CalculateTotalCalories();

            // Assert
            Assert.AreEqual(double.PositiveInfinity, totalCalories);
        }

       
    }
}
