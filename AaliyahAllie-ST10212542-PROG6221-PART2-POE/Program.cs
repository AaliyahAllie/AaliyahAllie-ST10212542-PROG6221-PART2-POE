using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace AaliyahAllie_ST10212542_PROG6221_PART2_POE
{
 
    public class Program
    {
        
        static void Main(string[] args)
        {
            
            List<Recipe> recipes = new List<Recipe>();
            int choice = 0;

           
            while (true)
            {               
                Console.WriteLine("***********************************************");                
                Console.WriteLine("Welcome To Your Recipe Application");               
                Console.WriteLine("***********************************************");                
                Console.WriteLine("Please enter (1) to launch the menu");                
                Console.WriteLine();
               
                if (!int.TryParse(Console.ReadLine(), out choice) || choice != 1)
                {
                    Console.WriteLine("INVALID OPTION.ENTER (1) TO LAUNCH MENU");                   
                    continue;
                }
                
                Console.WriteLine();
                Console.WriteLine("***********************************************");                
                Console.WriteLine("PLEASE SELECT ONE OF THE NUMERIC OPTIONS BELOW");                
                Console.WriteLine("***********************************************");              
                Console.WriteLine("1.Enter new recipe");               
                Console.WriteLine("2.Display all recipes");
                Console.WriteLine("3.Display specific recipe");
                Console.WriteLine("4.Scale specific recipe (0.5, 2, or 3)");
                Console.WriteLine("5.Reset specific recipe to original values");                
                Console.WriteLine("6.Clear all recipes data");
                Console.WriteLine("7.Clear a specific recipes data");
                Console.WriteLine("8.Exit Program");               
                Console.WriteLine("***********************************************");                
                Console.WriteLine();

                int userChoice;
               
                if (!int.TryParse(Console.ReadLine(), out userChoice))
                {                   
                    Console.WriteLine("INVALID CHOICE.PLEASE ENTER A VALID NUMBER.");                   
                    continue;
                }
                
                Console.WriteLine();
               
                switch (userChoice)
                { 
                    case 1:
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("Are you sure you want to enter a new recipe? (y/n)");
                    string recipeConfirmation = Console.ReadLine().ToLower();
                    if (recipeConfirmation == "n")
                    {
                        Console.WriteLine("Returning to the main menu.");
                        continue;
                    }
                    else if (recipeConfirmation != "y")
                    {
                        Console.WriteLine("Invalid input. Returning to the main menu.");
                        continue;
                    }

                    Console.ResetColor();
                    Console.WriteLine("***********************************************");
                    Console.WriteLine("ENTER NEW RECIPE DETAILS");
                    Console.WriteLine("***********************************************");

                    Console.WriteLine("Enter the number of recipes you want to enter: ");
                    int numRecipes;
                    if (!int.TryParse(Console.ReadLine(), out numRecipes) || numRecipes <= 0)
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number greater than 0.");
                        continue;
                    }

                    for (int j = 0; j < numRecipes; j++)
                    {
                        Console.WriteLine($"Recipe {j + 1}:");
                        Console.WriteLine("Enter recipe name: ");
                        string recipeName = Console.ReadLine();
                        Recipe newRecipe = new Recipe(recipeName);
                        newRecipe.CalorieNotifer = DisplayCalorieNotification; // Assigning the delegate

                        Console.WriteLine("Enter number of ingredients: ");
                        int numIngredients;
                        if (!int.TryParse(Console.ReadLine(), out numIngredients) || numIngredients <= 0)
                        {
                            Console.WriteLine("Invalid input. Please enter a valid number greater than 0.");
                            continue;
                        }
                        for (int i = 0; i < numIngredients; i++)
                        {
                            Console.WriteLine($"Ingredient {i + 1}");
                            Console.WriteLine("Name: ");
                            string ingredientName = Console.ReadLine();
                            Console.WriteLine("Quantity: ");
                            int ingredientQuantity;
                            if (!int.TryParse(Console.ReadLine(), out ingredientQuantity) || ingredientQuantity <= 0)
                            {
                                Console.WriteLine("Invalid input. Please enter a valid number greater than 0.");
                                continue;
                            }
                            Console.WriteLine("Unit of Measurement (ml/mg/teaspoon/tablespoon/cup)");
                            string unitOfMeasurement = Console.ReadLine();
                            Console.WriteLine("Enter calorie amount: ");
                            double calories;
                            if (!double.TryParse(Console.ReadLine(), out calories) || calories <= 0)
                            {
                                Console.WriteLine("Invalid input. Please enter a valid number greater than 0.");
                                continue;
                            }
                            newRecipe.AddIngredients(ingredientName, ingredientQuantity, unitOfMeasurement, calories);
                        }

                        Console.WriteLine("Enter the number of steps: ");
                        int numSteps;
                        if (!int.TryParse(Console.ReadLine(), out numSteps) || numSteps <= 0)
                        {
                            Console.WriteLine("Invalid input. Please enter a valid number greater than 0.");
                            continue;
                        }
                        for (int i = 0; i < numSteps; i++)
                        {
                            Console.WriteLine($"Step {i + 1}: ");
                            string step = Console.ReadLine();
                            newRecipe.AddStep(step);
                        }

                        recipes.Add(newRecipe);
                        Console.WriteLine($"Recipe {recipeName} successfully saved.");
                        Console.WriteLine();
                    }
                    break;


                case 2:
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("Are you sure ypu want to display the recipe?(y/n)");
                        string displayConfirmation = Console.ReadLine().ToLower();                       
                        if (displayConfirmation == "y")                        {
                            Console.WriteLine("Now Displaying Recipe");
                        }                        
                        else if (displayConfirmation == "n")
                        {
                            Console.WriteLine("Returning to the main menu.");
                            continue;
                        }
                        if (recipes.Count == 0)
                        {
                            Console.WriteLine("THERE IS NO RECIPE");
                            Console.WriteLine("Returning to main menu");
                            continue;
                        }
                        Console.ResetColor();
                        Console.WriteLine("***********************************************");                        
                        Console.WriteLine("DISPLAYING ALL RECIPE DETAILS:");                        
                        Console.WriteLine("***********************************************");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        var sortedRecipes = recipes.OrderBy(r => r.RecipeName);
                        foreach (Recipe recipe in sortedRecipes)
                        {
                            recipe.DisplayRecipe(true);
                            Console.ResetColor();
                        }
                        
                        break;
                        
                    case 3:
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("Are you sure ypu want to display a specific recipe?(y/n)");
                        string displaySpecificConfirmation = Console.ReadLine().ToLower();
                        if (displaySpecificConfirmation == "y")
                        {
                            Console.WriteLine("Now Scaling Recipe");
                        }
                        else if (displaySpecificConfirmation == "n")
                        {
                            Console.WriteLine("Returning to the main menu.");
                            continue;
                        }                        
                        Console.ResetColor();
                        Console.WriteLine("***********************************************");
                        Console.WriteLine("DISPLAYING SPECIFIC RECIPE:");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("***********************************************");
                        Console.WriteLine("LIST OF RECIPES:");
                        Console.WriteLine("***********************************************");
                        foreach (Recipe recipe in recipes)
                        {
                            Console.WriteLine($"RecipeName: {recipe.RecipeName}");
                            Console.WriteLine("***********************************************");
                        }
                        Console.ResetColor();
                        Console.WriteLine("Enter Name of Recipe To Display:");
                        string recipeToDisplay = Console.ReadLine();
                        Recipe specificRecipe = recipes.FirstOrDefault(r => r.RecipeName.Equals(recipeToDisplay, StringComparison.OrdinalIgnoreCase));
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        if (specificRecipe != null)
                        {
                            specificRecipe.DisplayRecipe(true);
                        }
                        else
                        {
                            Console.WriteLine("Recipe not found.");
                        }
                        Console.ResetColor();
                        break;


                    case 4:
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("Are you sure ypu want to scale the recipe?(y/n)");
                        string scaleConfirmation = Console.ReadLine().ToLower();                        
                        if (scaleConfirmation == "y")
                        {
                            Console.WriteLine("Now Scaling Recipe");
                        }                       
                        else if (scaleConfirmation == "n")
                        {
                            Console.WriteLine("Returning to the main menu.");
                            continue;
                        }
                        Console.ResetColor();
                        Console.WriteLine("***********************************************");                       
                        Console.WriteLine("SCALE SPECIFIC RECIPE:");                        
                        Console.WriteLine("***********************************************"); 
                        if (recipes.Count == 0)
                        {
                            Console.WriteLine("THERE IS NO RECIPE TO SCALE");
                            Console.WriteLine("RETURNING TO MAIN MENU");
                            continue;
                        }
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("***********************************************");
                        Console.WriteLine("LIST OF RECIPES:");
                        Console.WriteLine("***********************************************");
                        foreach (Recipe recipe in recipes)
                        {
                            Console.WriteLine($"RecipeName: {recipe.RecipeName}");
                            Console.WriteLine("***********************************************");
                        }
                        Console.ResetColor();
                        Console.WriteLine("Enter the name of the recipe to scale:");
                        string recipeToScale = Console.ReadLine();
                        Recipe recipeToScaleObject = recipes.FirstOrDefault(r => r.RecipeName.Equals(recipeToScale, StringComparison.OrdinalIgnoreCase));
                        if (recipeToScaleObject != null)
                        {
                            Console.WriteLine("Enter the scale factor (0.5, 2, or 3):");
                            if (!double.TryParse(Console.ReadLine(), out double scaleFactor) || (scaleFactor != 0.5 && scaleFactor != 2 && scaleFactor != 3))
                            {
                                Console.WriteLine("Invalid scale factor. Please enter 0.5, 2, or 3.");
                                continue;
                            }
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            recipeToScaleObject.ScaleRecipe(scaleFactor);
                            Console.WriteLine("Scaled Recipe:");
                            recipeToScaleObject.DisplayRecipe(true);
                        }
                        else
                        {
                            Console.WriteLine("Recipe not found.");
                        }
                        Console.ResetColor();
                        break;

                    case 5:
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("Are you sure ypu want to reset recipe?(y/n)");
                        string resetConfirmation = Console.ReadLine().ToLower();                        
                        if (resetConfirmation == "y")
                        {
                            Console.WriteLine("Now Reseting Recipe");
                        }                        
                        else if (resetConfirmation == "n")
                        {
                            Console.WriteLine("Returning to the main menu.");
                            continue;
                        }
                        Console.ResetColor();
                        Console.WriteLine("***********************************************");                       
                        Console.WriteLine("RESET RECIPE TO ORIGINAL VALUES");
                        Console.WriteLine("***********************************************");
                        if (recipes.Count == 0)
                        {
                            Console.WriteLine("THERE ARE NO RECIPES TO RESET");
                            Console.WriteLine("RETURNING TO MAIN MENU.");
                            continue;
                        }
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("***********************************************");
                        Console.WriteLine("LIST OF RECIPES:");
                        Console.WriteLine("***********************************************");
                        foreach (Recipe recipe in recipes)
                        {
                            Console.WriteLine($"RecipeName: {recipe.RecipeName}");
                            Console.WriteLine("***********************************************");
                        }
                        Console.ResetColor();
                        Console.WriteLine("Enter the name of the recipe to reset:");
                        string recipeToReset = Console.ReadLine();
                        Recipe recipeToResetObject = recipes.FirstOrDefault(r => r.RecipeName.Equals(recipeToReset, StringComparison.OrdinalIgnoreCase));
                        if (recipeToResetObject != null)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            recipeToResetObject.ResetRecipe();
                            Console.WriteLine("Recipe reset successfully!");
                        }
                        else
                        {
                            Console.WriteLine("Recipe not found.");
                        }
                        break;

                    case 6:
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("Are you sure ypu want to clear all recipes?(y/n)");
                        string clearConfirmation = Console.ReadLine().ToLower();                        
                        if (clearConfirmation == "y")
                        {
                            Console.WriteLine("Now Clearing Recipe");
                        }
                        else if (clearConfirmation == "n")
                        {
                            Console.WriteLine("Returning to the main menu.");
                            continue;
                        }
                        Console.ResetColor();
                        Console.WriteLine("***********************************************");
                        Console.WriteLine("CLEAR RECIPE DATA:");
                        Console.WriteLine("***********************************************");
                        if(recipes.Count == 0)
                        {
                            Console.WriteLine("THERE ARE NO RECIPES TO CLEAR");
                            Console.WriteLine("RETURNING TO MAIN MENU");
                            continue;
                        }
                        recipes.Clear();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("ALL RECIPES DATA SUCCESSFULLY CLEARED");
                        Console.ResetColor();
                        Console.WriteLine();                       
                        break;

                    case 7:
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("Are you sure ypu want to clear a recipe's data(y/n)");
                        string clear2Confirmation = Console.ReadLine().ToLower();
                        if (clear2Confirmation == "y")
                        {
                            Console.WriteLine("Now Clearing Recipe");
                        }
                        else if (clear2Confirmation == "n")
                        {
                            Console.WriteLine("Returning to the main menu.");
                            continue;
                        }
                        Console.ResetColor();
                        Console.WriteLine("***********************************************");
                        Console.WriteLine("CLEAR SPECIFIC RECIPE DATA:");
                        Console.WriteLine("***********************************************");
                        if (recipes.Count == 0)
                        {
                            Console.WriteLine("THERE ARE NO RECIPES TO CLEAR");
                            Console.WriteLine("RETURNING TO MAIN MENU");
                            continue;
                        }
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("***********************************************");
                        Console.WriteLine("LIST OF RECIPES:");
                        Console.WriteLine("***********************************************");
                        foreach (Recipe recipe in recipes)
                        {
                            Console.WriteLine($"RecipeName: {recipe.RecipeName}");
                            Console.WriteLine("***********************************************");
                        }
                        Console.ResetColor();
                        Console.WriteLine("Enter Name of Recipe To Clear:");
                        
                        string recipeToClear = Console.ReadLine();
                        Recipe recipeToClearObject = recipes.FirstOrDefault(r => r.RecipeName.Equals(recipeToClear, StringComparison.OrdinalIgnoreCase));
                        if (recipeToClearObject != null)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            recipes.Remove(recipeToClearObject);
                            Console.WriteLine("Recipe cleared successfully!");
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.WriteLine("Recipe not found.");
                        }
                        break;

                    case 8:
                        //user exption handling
                        //code works by first asking the sure if they are sure they want to proceed with this selected option of exiting
                        //if yes (y) it will continue to allow
                        //them to exit,
                        //if not (n) it will go back to the main menu 
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("Are you sure you want to exit? (y/n)");
                        string exitConfirmation = Console.ReadLine().ToLower();
                        Console.ResetColor();
                        //if yes proceeds
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        if (exitConfirmation == "y")
                        {
                            Console.WriteLine("THANK YOU FOR USING THIS APPLICATION");
                            Console.WriteLine("PROGRAM WILL NOW CLOSE");
                            Environment.Exit(0);
                            Console.ResetColor();

                        }

                        //if no goes back
                        else if (exitConfirmation == "n")
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine("Returning to the main menu.");
                            Console.ResetColor();

                            continue;
                        }
                        else
                        //error message if wrong option is chosen
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Invalid input. Returning to the main menu.");
                            Console.ResetColor();

                            continue;
                        }
                        // Exit the loop 
                        //exits the program
                        break;

                    default:
                        Console.WriteLine("INVALID CHOICE.PLEASE ENTER A VALID NUMBER");
                        break;
                }

            }

        }
        static void DisplayCalorieNotification(string message)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }

}