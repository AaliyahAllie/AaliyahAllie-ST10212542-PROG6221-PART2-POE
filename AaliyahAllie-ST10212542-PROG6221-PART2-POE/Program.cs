﻿using System;
using System.Collections.Generic;
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
                        Console.WriteLine("Are you sure you want to enter a new recipe?(y/n)");
                        string recipeConfirmation = Console.ReadLine().ToLower();                       
                        if (recipeConfirmation == "y")
                        {
                            Console.WriteLine("Now Capturing Recipe");
                        }                       
                        else if (recipeConfirmation == "n")
                        {
                            Console.WriteLine("Returning to the main menu.");
                            continue;
                        }                        
                        Console.WriteLine("***********************************************");                      
                        Console.WriteLine("ENTER NEW RECIPE DETAILS");                       
                        Console.WriteLine("***********************************************");                       
                        Console.WriteLine("Enter recipe name: ");                        
                        string recipeName = Console.ReadLine();                      
                        Recipe newRecipe = new Recipe(recipeName);                     
                        Console.WriteLine("Enter number of ingredients: ");                      
                        int numIngredients;                        
                        if (!int.TryParse(Console.ReadLine(), out numIngredients))
                        {
                            Console.WriteLine("INVALID INPUT.PLEASE ENTER A VALID NUMBER.");                            
                            continue;
                        }                        
                        for (int i = 0; i < numIngredients; i++)
                        {                          
                            Console.WriteLine($"Ingredient {i + 1}");                           
                            Console.WriteLine("Name: ");                           
                            string ingredientName = Console.ReadLine();                           
                            Console.WriteLine("Quantity: ");                          
                            int ingredientQuantity;
                            if (!int.TryParse(Console.ReadLine(), out ingredientQuantity))
                            {
                                Console.WriteLine("Invalid input.Please enter a valid number.");                                
                                continue;
                            }                            
                            Console.WriteLine("Unit of Measurement (ml/mg/teaspoon/tablespoon/cup)");                            
                            string unitOfMeasurement = Console.ReadLine();                           
                            newRecipe.AddIngredients(ingredientName, ingredientQuantity, unitOfMeasurement);
                        }                        
                        Console.WriteLine("Enter the number of steps: ");                       
                        int numSteps;
                        if (!int.TryParse(Console.ReadLine(), out numSteps))
                        {
                            Console.WriteLine("Invalid input. Please enter a valid number.");                           
                            continue;
                        }                       
                        for (int i = 0; i < numSteps; i++)
                        {                            
                            Console.WriteLine($"Step {i + 1}: ");                           
                            string step = Console.ReadLine();                           
                            newRecipe.AddStep(step);
                        }                        
                        recipes.Add(newRecipe);                        
                        Console.WriteLine("RECIPE SUCCESSFULLY SAVED");                        
                        Console.WriteLine();                      
                        break;

                    case 2:                      
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
                        Console.WriteLine("***********************************************");                        
                        Console.WriteLine("DISPLAYING ALL RECIPE DETAILS:");                        
                        Console.WriteLine("***********************************************");                        
                        foreach (Recipe recipe in recipes)
                        {
                            Console.WriteLine($"RecipeName: {recipe.RecipeName}");
                            Console.WriteLine("Ingredients: ");
                            foreach(var ingredient in recipe.Ingredients)
                            {
                                Console.WriteLine($"{ingredient.Name}: {ingredient.Quantity}: {ingredient.UnitOfMeasurement}");
                            }
                            Console.WriteLine("Steps:");
                            int stepNumber = 1;
                            foreach (var step in recipe.Steps)
                            {
                                Console.WriteLine($"Step {stepNumber}: {step}");
                                stepNumber++;
                            }
                            Console.WriteLine("***********************************************");
                        }                        
                        break;

                    case 3:
                        Console.WriteLine("Are you sure ypu want to display a specific recipe?(y/n)");
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
                        Console.WriteLine("***********************************************");
                        Console.WriteLine("DISPLAYING SPECIFIC RECIPE:");
                        Console.WriteLine("***********************************************");
                        Console.WriteLine("LIST OF RECIPES:");
                        Console.WriteLine("***********************************************");
                        foreach (Recipe recipe in recipes)
                        {
                            Console.WriteLine($"RecipeName: {recipe.RecipeName}");
                            Console.WriteLine("***********************************************");
                        }
                        Console.WriteLine("Enter Name of Recipe To Display");
                        string recipeToDisplay = Console.ReadLine();
                        Recipe specificRecipe = recipes.FirstOrDefault(r => r.RecipeName.Equals(recipeToDisplay, StringComparison.OrdinalIgnoreCase));
                        if(specificRecipe != null)
                        {
                            specificRecipe.DisplayRecipe();
                        }
                        else
                        {
                            Console.WriteLine("RECIPE NOT FOUND");
                        }
                        break;


                    case 4:                        
                        Console.WriteLine("Are you sure ypu want to scale the recipe?(y/n)");
                        string scale = Console.ReadLine().ToLower();                        
                        if (scale == "y")
                        {
                            Console.WriteLine("Now Scaling Recipe");
                        }                       
                        else if (scale == "n")
                        {
                            Console.WriteLine("Returning to the main menu.");
                            continue;
                        }                        
                        Console.WriteLine("***********************************************");                       
                        Console.WriteLine("SCALE SPECIFIC RECIPE:");                        
                        Console.WriteLine("***********************************************"); 
                        if (recipes.Count == 0)
                        {
                            Console.WriteLine("THERE IS NO RECIPE TO SCALE");
                            Console.WriteLine("RETURNING TO MAIN MENU");
                            continue;
                        }
                        Console.WriteLine("Enter Name of Recipe To Scale:");
                        string recipeToScale = Console.ReadLine();
                        Recipe recipeToScaleObject = recipes.FirstOrDefault(r => r.RecipeName.Equals(recipeToScale, StringComparison.OrdinalIgnoreCase));
                        if(recipeToScaleObject != null)
                        {
                            Console.WriteLine("Enter the scaling factor(0.5,2,3): ");
                            if (!double.TryParse(Console.ReadLine(), out double scaleFactor) || (scaleFactor != 0.5 && scaleFactor != 2 && scaleFactor != 3))
                            {
                                Console.WriteLine("Invalid scale factor. Please enter 0.5, 2, or 3.");
                                continue;
                            }
                            recipeToScaleObject.ScaleRecipe(scaleFactor);

                            // Display the scaled recipe
                            Console.WriteLine("Scaled Recipe:");
                            Console.WriteLine("***********************************************");
                            Console.WriteLine($"Recipe Name: {recipeToScaleObject.RecipeName}");
                            Console.WriteLine("Ingredients:");
                            foreach (var ingredient in recipeToScaleObject.Ingredients)
                            {
                                Console.WriteLine($"{ingredient.Name}: {ingredient.Quantity * scaleFactor} {ingredient.UnitOfMeasurement}");
                            }
                            Console.WriteLine("Steps:");
                            int stepNumber = 1;
                            foreach (var step in recipeToScaleObject.Steps)
                            {
                                Console.WriteLine($"Step {stepNumber}: {step}");
                                stepNumber++;
                            }
                            Console.WriteLine("***********************************************");
                        }
                        else
                        {
                            Console.WriteLine("Recipe not found.");
                        }
                        break;

                    case 5:
                       
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
                        Console.WriteLine("***********************************************");                       
                        Console.WriteLine("RESET RECIPE TO ORIGINAL VALUES");
                        Console.WriteLine("***********************************************");
                        if (recipes.Count == 0)
                        {
                            Console.WriteLine("THERE ARE NO RECIPES TO RESET");
                            Console.WriteLine("RETURNING TO MAIN MENU.");
                            continue;
                        }
                        Console.WriteLine("Enter The Name of Recipe To Reset");
                        string recipeToReset = Console.ReadLine();
                        Recipe recipeToResetObject = recipes.FirstOrDefault(r => r.RecipeName.Equals(recipeToReset, StringComparison.OrdinalIgnoreCase));
                        if (recipeToResetObject != null)
                        {
                            recipeToResetObject.ResetRecipe();
                            Console.WriteLine("SUCCESSFULLY RESET");
                        }
                        else
                        {
                            Console.WriteLine("RECIPE NOT FOUND");
                        }
                        break;

                    case 6:
                       
                        Console.WriteLine("Are you sure ypu want to clear the recipe?(y/n)");
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
                       
                        Console.WriteLine("***********************************************");
                        Console.WriteLine("CLEAR RECIPE DATA:");
                        Console.WriteLine("***********************************************");

                        recipes.Clear();

                        
                        Console.WriteLine("RECIPE DATA SUCCESSFULLY CLEARED");
                        Console.WriteLine();
                       
                        break;

                    case 7:
                        break;

                    case 8:
                       
                        Console.WriteLine("Are you sure you want to exit? (y/n)");
                        string exitConfirmation = Console.ReadLine().ToLower();
                        
                        if (exitConfirmation == "y")
                        {
                            Console.WriteLine("THANK YOU FOR USING THIS APPLICATION");
                            Console.WriteLine("PROGRAM WILL NOW CLOSE");
                            Environment.Exit(0);
                        }
                      
                        else if (exitConfirmation == "n")
                        {
                            Console.WriteLine("Returning to the main menu.");
                            continue;
                        }
                        else
                        
                        {
                            Console.WriteLine("Invalid input. Returning to the main menu.");
                            continue;
                        }
                        
                        break;

                    default:
                        Console.WriteLine("INVALID CHOICE.PLEASE ENTER A VALID NUMBER");
                        break;
                }

            }

        }
    }

}