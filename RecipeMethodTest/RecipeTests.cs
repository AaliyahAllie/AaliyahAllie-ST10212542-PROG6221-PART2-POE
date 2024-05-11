using NUnit.Framework;
using System.Collections.Generic;

namespace RecipeMethod.Tests
{
    [TestFixture]
    public class RecipeTests
    {
        [Test]
        public void CalculateTotalCalories_EmptyIngredients_ReturnsZero()
        {
            // Arrange
            Recipe recipe = new Recipe("TestRecipe");

            // Act
            double totalCalories = recipe.CalculateTotalCalories();

            // Assert
            Assert.AreEqual(0, totalCalories);
        }

        [Test]
        public void CalculateTotalCalories_SingleIngredient_ReturnsCorrectValue()
        {
            // Arrange
            Recipe recipe = new Recipe("TestRecipe");
            recipe.AddIngredients("Ingredient1", 100, "grams", 200);

            // Act
            double totalCalories = recipe.CalculateTotalCalories();

            // Assert
            Assert.AreEqual(200, totalCalories);
        }

        [Test]
        public void CalculateTotalCalories_MultipleIngredients_ReturnsSumOfCalories()
        {
            // Arrange
            Recipe recipe = new Recipe("TestRecipe");
            recipe.AddIngredients("Ingredient1", 100, "grams", 200);
            recipe.AddIngredients("Ingredient2", 50, "grams", 150);

            // Act
            double totalCalories = recipe.CalculateTotalCalories();

            // Assert
            Assert.AreEqual(350, totalCalories);
        }
    }
}
