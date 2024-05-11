using System.Diagnostics;

namespace RecipeMethodTest
{
    public class RecipeTests
    {
        private StringWriter consoleOutput;
        private Recipe recipe;

        [SetUp]
        public void Setup()
        {
            consoleOutput = new StringWriter();
            Console.SetOut(consoleOutput);
            recipe.newRecipe();
            recipe.RecipeName = "Sample Recipe";
            recipe.Ingredients = new List<Ingredient>
            {
                new Ingredient{OriginalQuantity = 100, Quantity = 100, OriginalCalories = 50, Calories = 50 },


                new Ingredient {OriginalQuantity = 200, Quantity = 200, OriginalCalories = 80, Calories = 80}
                };
                
            }
        }

        [TearDown]
        public void CalculateTotalCalories_ReturnsCorrectTotal()
        {
        double expectedTotalCalories = 130;

        double actualTotalCalories = recipe.CalculateTotalCalories();

        Assert.AreEqual(expectedTotalCalories, actualTotalCalories);
        }

        [Test]
        public void CalculateTotalCalories_ReturnsZero_WhenNoIngredients()
        {
        recipe.Ingredients = new List<Ingredient>();

        double expectedTotalCalories = 0;

        double actualTotalCalories = recipe.CalculateTotalCalories();

        Assert.AreEqual(expectedTotalCalories,actualTotalCalories);
        }
        {
            
        }
    }
}