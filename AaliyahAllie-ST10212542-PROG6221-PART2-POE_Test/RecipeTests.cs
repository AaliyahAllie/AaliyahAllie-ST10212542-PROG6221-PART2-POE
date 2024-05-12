using NUnit.Framework;
using System;

namespace AaliyahAllie_ST10212542_PROG6221_PART2_POE
{
    [TestFixture]
    public class RecipeTests
    {

        [Test]
        public void TestCalculateTotalCalories_NoIngredients()
        {
            Recipe recipe = new Recipe("Test Recipe");

            double totalCalories = recipe.CalculateTotalCalories();

            Assert.AreEqual(0, totalCalories);
        }

        [Test]
        public void TestCalculateTotalCalories_OneIngredient()
        {
            Recipe recipe = new Recipe("Test Recipe");
            recipe.AddIngredients("Ingredient 1", 100, "mg", 50);
            double totalCalories = recipe.CalculateTotalCalories();
            Assert.AreEqual(50, totalCalories);
        }

        [Test]
        public void TestCalculateTotalCalories_MultipleIngredients()
        {
            Recipe recipe = new Recipe("Test Recipe");
            recipe.AddIngredients("Ingredient 1", 100, "mg", 50);
            recipe.AddIngredients("Ingredient 2", 200, "ml", 100);
            double totalCalories = recipe.CalculateTotalCalories();
            Assert.AreEqual(150, totalCalories);
        }

        [Test]
        public void TestCalculateTotalCalories_NegQuantity()
        {
            Recipe recipe = new Recipe("TestRecipe");
            recipe.AddIngredients("Ingredient 1", -100, "mg", 50);
            double totalCalories = recipe.CalculateTotalCalories();
            Assert.AreEqual(0, totalCalories);
        }

        [Test]
        public void TestCalculateTotalCalories_NegCal()
        {
            Recipe recipe = new Recipe("TestRecipe");
            recipe.AddIngredients("Ingredient 1", 100, "mg", -50);
            double totalCalories = recipe.CalculateTotalCalories();
            Assert.AreEqual(0, totalCalories);
        }

        [Test]
        public void TestCalculateTotalCalories_OverFlow()
        {
            Recipe recipe = new Recipe("TestRecipe");
            recipe.AddIngredients("Ingredient 1", int.MaxValue, "mg", double.MaxValue);
            double totalCalories = recipe.CalculateTotalCalories();
            Assert.AreEqual(double.MaxValue, totalCalories);
        }

        [Test]
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

        [Test]
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
