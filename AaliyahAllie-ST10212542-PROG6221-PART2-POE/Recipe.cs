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
            Ingredients.Add(new Ingredient
            {
                Name = name,
                Quantity = quantity,
                OriginalQuantity = quantity,
                UnitOfMeasurement = unitOfMeasurement
            });
        }

        public void AddStep(string step)
        {
            Steps.Add(step);
        }

        public void DisplayRecipe()
        {
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine($"Recipe Name: {RecipeName}");
            Console.WriteLine("Ingredients: ");
            foreach(var ingredient in Ingredients)
            {
                Console.WriteLine($"{ingredient.Name}: {ingredient.Quantity} {ingredient.UnitOfMeasurement}");
            }Console.WriteLine("Steps: ");
            int stepNumber = 1;
            foreach (var ingredient in Steps)
            {
                Console.WriteLine($"Step {stepNumber}: {step}");
                stepNumber++;
            }
            Console.WriteLine("**********************************************************************************");
        }
    }
}
