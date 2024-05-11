using System;
using System.Collections.Generic;
namespace AaliyahAllie_ST10212542_PROG6221_PART2_POE
{
    public class Recipe
    {
       
            public delegate void RecipeCalorieNotification(string message);
            public string RecipeName { get; set; }
            public ICollection<Ingredient> Ingredients { get; set; } 
            public ICollection<string> Steps { get; set; } 
            public RecipeCalorieNotification CalorieNotifer { get; set; }
            public Recipe(string recipeName)
            {
                RecipeName = recipeName;
                Ingredients = new List<Ingredient>(); 
                Steps = new List<string>(); 
            }

            public void AddIngredients(string name, int quantity, string unitOfMeasurement, double calories)
            {
                Console.WriteLine("Available Food Groups:");
                DisplayFoodGroupOptions();
                Console.WriteLine("Enter the number corresponding to the food group this ingredient belongs to:");
                int FoodGroupChoice;
                if (!int.TryParse(Console.ReadLine(), out FoodGroupChoice) || !AvailableFoodGroups.ContainsKey(FoodGroupChoice))
                {
                    Console.WriteLine("Invalid food group choice. Please select a valid number from the options.");
                    return;
                }
                string foodGroup = AvailableFoodGroups[FoodGroupChoice];
                Ingredients.Add(new Ingredient
                {
                    Name = name,
                    Quantity = quantity,
                    OriginalQuantity = quantity,
                    UnitOfMeasurement = unitOfMeasurement,
                    Calories = calories,
                    OriginalCalories = calories,
                    FoodGroup = foodGroup,
                    FoodGroupNumber = FoodGroupChoice
                });


            }

            public void AddStep(string step)
            {
                Steps.Add(step);
            }

        public void DisplayRecipe(bool showAllDetails)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine($"Recipe Name: {RecipeName}");

            if (showAllDetails)
            {
                Console.WriteLine("Ingredients:");
                foreach (var ingredient in Ingredients)
                {
                    Console.WriteLine($"{ingredient.Name}: {ingredient.Quantity} {ingredient.UnitOfMeasurement} (Food Group: {ingredient.FoodGroup}, Calories: {ingredient.Calories})");
                }

                Console.WriteLine("Steps:");
                int stepNumber = 1;
                foreach (var step in Steps)
                {
                    Console.WriteLine($"Step {stepNumber}: {step}");
                    stepNumber++;
                }
            }
            else
            {
                Console.WriteLine($"Ingredients: {Ingredients.Count} ingredient(s) recorded.");
                Console.WriteLine($"Steps: {Steps.Count} step(s) recorded.");
            }

            double totalCalories = CalculateTotalCalories();
            Console.Write($"Total Calories: {totalCalories} ");

            if (totalCalories >= 0 && totalCalories <= 300)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"(Total calories of {RecipeName} are between 0 and 300. This is still in a healthy calorie range.)");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"(ALERT!!! Calories above 300 may be unhealthy.)");
                CalorieNotifer?.Invoke($"ALERT!!! The recipe '{RecipeName}' exceeds 300 calories.");
            }

            Console.ResetColor();
            Console.WriteLine("***********************************************");
        }


        public double CalculateTotalCalories()
            {
                double totalCalories = 0;
                foreach (var ingredient in Ingredients)
                {
                    totalCalories += ingredient.Calories;
                }
                return totalCalories;
            }

            public static readonly Dictionary<int, string> AvailableFoodGroups = new Dictionary<int, string>
        {
            { 1, "Starchy foods" },
            { 2, "Vegetables and fruits" },
            { 3, "Dry beans, peas, lentils and soya" },
            { 4, "Chicken, fish, meat and eggs" },
            { 5, "Milk and dairy products" },
            { 6, "Fats and oil" },
            { 7, "Water" }
        };

            public static void DisplayFoodGroupOptions()
            {
                foreach (var foodGroup in AvailableFoodGroups)
                {
                    Console.WriteLine($"{foodGroup.Key}. {foodGroup.Value}");
                }
            }

            public void ScaleRecipe(double factor)
            {
                foreach (var ingredient in Ingredients)
                {
                    // Scale the original quantity of each ingredient by the given factor
                    ingredient.Quantity = (int)(ingredient.OriginalQuantity * factor);
                    //Scale the calories 
                    ingredient.Calories *= factor;
                }
            }

            public void ResetRecipe()
            {
                //Reset quantities of each ingredient to original values
                foreach (var ingredient in Ingredients)
                {
                    ingredient.Quantity = ingredient.OriginalQuantity;
                    //reset calories to original
                    ingredient.Calories = ingredient.OriginalCalories;
                }
            }


    }
    
}