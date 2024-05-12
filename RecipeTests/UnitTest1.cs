using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AaliyahAllie_ST10212542_PROG6221_PART2_POE
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void TestCalculateTotalCalories_NoIngredients()
        {
            Recipe recipe = new Recipe("Test Recipe");

            double totalCalories = recipe.CalculateTotalCalories();

            Assert.AreEqual(0,totalCalories);
        }

        [TestMethod]
        public void TestCalculateTotalCalories_OneIngredient()
        {
            Recipe recipe = new Recipe("Test Recipe");
            recipe.AddIngredients("Ingredient 1", 100, "mg",50);
            double totalCalories = recipe.CalculateTotalCalories();
            Assert.AreEqual(50,totalCalories);
        }

        [TestMethod]

        [TestMethod]
        public void TestScaleRecipe()
        {
            // Arrange
            Recipe recipe = new Recipe("Test Recipe");
            recipe.AddIngredients("Ingredient 1", 100, "mg", 50);
            recipe.AddIngredients("Ingredient 2", 200, "ml", 100);

            double factor = 2;

            // Act
            recipe.ScaleRecipe(factor);

            // Assert
            foreach (var ingredient in recipe.Ingredients)
            {
                Assert.AreEqual(ingredient.OriginalQuantity * factor, ingredient.Quantity);
                Assert.AreEqual(ingredient.OriginalCalories * factor, ingredient.Calories);
            }
        }

        [TestMethod]
        public void TestResetRecipe()
        {
            // Arrange
            Recipe recipe = new Recipe("Test Recipe");
            recipe.AddIngredients("Ingredient 1", 100, "g", 50);
            recipe.AddIngredients("Ingredient 2", 200, "ml", 100);

            // Act
            recipe.ResetRecipe();

            // Assert
            foreach (var ingredient in recipe.Ingredients)
            {
                Assert.AreEqual(ingredient.OriginalQuantity, ingredient.Quantity);
                Assert.AreEqual(ingredient.OriginalCalories, ingredient.Calories);
            }
        }
    }
}
