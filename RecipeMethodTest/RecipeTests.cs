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

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}