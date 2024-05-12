//PROG PART 2
//AALIYAH ALLIE PROG PART 2
//UNIT TESTS
//THIS PAGE OF CODE CONTAINS MY UNIT TESTS FOR METHODS CREATED ON RECIPE.CS
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AaliyahAllie_ST10212542_PROG6221_PART2_POE;
using System;
using System.Collections.Generic;
using System.Linq;

//Defining the namespace of my test class
namespace AaliyahAllie_ST10212542_PROG6221_PART2_POE.Tests
{
    // Indicates that the following class contains test methods.
    [TestClass()]
    // Defines a test class for testing the Recipe class.
    public class RecipeTests
    {
        // Indicates that the following method is a test method.
        [TestMethod()]
        //This method is used to test the ScaleRecipe(menthod), functionality of the Recipe class.
        public void ScaleRecipeTest()
        {
            // Arrange
            // Creating an instance of Recipe class with name "Test Recipe".
            Recipe recipe = new Recipe("Test Recipe");
            // Adding an ingredient to the recipe.
            recipe.AddIngredients("Ingredient 1", 100, "mg", 50);
            //Adding another ingredient
            recipe.AddIngredients("Ingredient 2", 200, "ml", 100);

            //scale factor set to 2
            double factor = 2;

            // Act
            // Scaling the recipe by the set scale factor
            recipe.ScaleRecipe(factor);

            // Assert
            // Verifying the quantity of the first ingredient after scaling.
            Assert.AreEqual(200, recipe.Ingredients.First().Quantity);
            // Verifying the calories of the last ingredient after scaling.
            Assert.AreEqual(100 * factor, recipe.Ingredients.Last().Calories);
        }

        //Indicating the next test method
        [TestMethod()]

        //Testing the resetrecipe method's functionality from the recipe class
        public void ResetRecipeTest()
        {
            // Arrange
            // Creating an instance of Recipe class with name "Test Recipe".
            Recipe recipe = new Recipe("Test Recipe");
            // Adding an ingredient to the recipe.
            recipe.AddIngredients("Ingredient 1", 100, "mg", 50);
            // Adding another ingredient to the recipe.
            recipe.AddIngredients("Ingredient 2", 200, "ml", 100);

            // Act
            // Resetting the recipe.
            recipe.ResetRecipe();

            // Assert
            // Verifying that the ingredient count is zero after resetting the recipe.
            Assert.AreEqual(0, recipe.Ingredients.Count); 
        }

        //Indicating next test method
        [TestMethod]
        //testing calulate total calories method against 0 ingredients
        public void TestCalculateTotalCalories_NoIngredients()
        {
            // Arrange
            //Creating an instance of Recipe class with name "Test Recipe".
            Recipe recipe = new Recipe("Test Recipe");

            // Act
            // Calculating total calories.
            double totalCalories = recipe.CalculateTotalCalories();

            // Assert
            // Verifying that total calories are zero when there are no ingredients.
            Assert.AreEqual(0, totalCalories);
        }

        // Other test methods unchanged

        [TestMethod]
        public void TestCalculateTotalCalories_Overflow()
        {
            // Arrange
            Recipe recipe = new Recipe("Test Recipe");

            // Adding an ingredient with maximum values.
            recipe.AddIngredients("Ingredient 1", int.MaxValue, "g", double.MaxValue);

            // Act
            // Calculating total calories.
            double totalCalories = recipe.CalculateTotalCalories();

            // Assert
            // Verifying that total calories are positive infinity in case of overflow.
            Assert.AreEqual(double.PositiveInfinity, totalCalories);
        }

       
    }
}
