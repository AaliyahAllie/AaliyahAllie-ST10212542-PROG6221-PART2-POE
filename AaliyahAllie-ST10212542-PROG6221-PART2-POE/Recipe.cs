using System;
using System.Collections.Generic;
namespace AaliyahAllie_ST10212542_PROG6221_PART2_POE
{
    public class Recipe
    {
        public string RecipeName { get; set; }
        public List<Ingredient> Ingredients { get; set; }
        public List<string> Steps { get; set; }
        public Recipe(string recipeName)
        {
            RecipeName = recipeName;
            Ingredients = new List<Ingredient>();
            Steps = new List<string>();
        }

        public void AddIngredients(string name, int quantity,string unitOfMeasurement)
        {

        }
    }
}
