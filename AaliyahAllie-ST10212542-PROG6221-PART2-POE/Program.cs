//PROG PART 2
//AALIYAH ALLIE PROG PART 2
//Program.CS PAGE
//THIS PAGE OF CODE CONTAINS MY RECIPE.CS FOR VARIABLES THAT ARE CALLED BY THE Program.CS CLASS
//Main method
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using static System.Formats.Asn1.AsnWriter;

//defining name space
namespace AaliyahAllie_ST10212542_PROG6221_PART2_POE
{
    //defining class
    public class Program
    {
        //main method
        static void Main(string[] args)
        {
            // Initialize an empty list to hold Recipe objects(generic collection)
            List<Recipe> recipes = new List<Recipe>();
            // Initialize an integer variable to store user choice, initially set to 0
            int choice = 0;

            // Main loop of the program
            while (true)
            { 
                //Interface welcome message
                Console.WriteLine("***********************************************"); 
                //welcome message header
                Console.WriteLine("Welcome To Your Recipe Application");               
                //interface design
                Console.WriteLine("***********************************************");   
                //user prompt 
                Console.WriteLine("Please enter (1) to launch the menu");           
                //seperation line to make code need
                Console.WriteLine();
               
                //any option other than 1 enters a error message and redirects back to the main welcome message interface
                if (!int.TryParse(Console.ReadLine(), out choice) || choice != 1)
                {
                    Console.WriteLine("INVALID OPTION.ENTER (1) TO LAUNCH MENU");                   
                    continue;
                }
                
                //seperation line for display
                Console.WriteLine();
                //interface design
                Console.WriteLine("***********************************************");    
                //prompts user to select a numeric option
                Console.WriteLine("PLEASE SELECT ONE OF THE NUMERIC OPTIONS BELOW");                
                Console.WriteLine("***********************************************");     
                //list of options
                Console.WriteLine("1.Enter new recipe");//will prompt user to enter new recipe
                Console.WriteLine("2.Display all recipes");//will prompt system to display all recipes
                Console.WriteLine("3.Display specific recipe");//will prompt user to select a specifi recipe and system will display it
                Console.WriteLine("4.Scale specific recipe (0.5, 2, or 3)");//will prompt user to select a specific recipe to scale by 0,5;2 or 3
                Console.WriteLine("5.Reset specific recipe to original values"); //will prompt user to select a specific recipe to reset to original values             
                Console.WriteLine("6.Clear all recipes data");//will prompt system to delete all stored data
                Console.WriteLine("7.Clear a specific recipes data");//deletes a specific recipe of users choice 
                Console.WriteLine("8.Exit Program"); //prompts system to exit              
                Console.WriteLine("***********************************************");
                //seperation line for display
                Console.WriteLine();

                //captures user input
                int userChoice;
               
                //if option isnt of the listed numeric option error message and redirects back to main menu
                if (!int.TryParse(Console.ReadLine(), out userChoice))
                {     
                    //error message
                    Console.WriteLine("INVALID CHOICE.PLEASE ENTER A VALID NUMBER.");                   
                    continue;
                }
                //seperation line
                Console.WriteLine();
               
                //switch case based on what user input is
                switch (userChoice)
                { 
                    //case 1 based on numeric option 1, Enters new recipes
                    case 1:
                     //user interface will display dark yellow message
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    //user interface (user exception handing)
                    Console.WriteLine("Are you sure you want to enter a new recipe? (y/n)");
                        //reads user input
                    string recipeConfirmation = Console.ReadLine().ToLower();
                        //no returns to main
                    if (recipeConfirmation == "n")
                    {
                        Console.WriteLine("Returning to the main menu.");
                        continue;
                    }
                    //yes continues with option
                    else if (recipeConfirmation != "y")
                    {
                        Console.WriteLine("Invalid input. Returning to the main menu.");
                        continue;
                    }
                    //resets colour
                    Console.ResetColor();
                    //interface display
                    Console.WriteLine("***********************************************");
                    Console.WriteLine("ENTER NEW RECIPE DETAILS");
                    Console.WriteLine("***********************************************");
                    //asks user how many recipes they want to enter
                    Console.WriteLine("Enter the number of recipes you want to enter: ");
                    //stores user input
                    int numRecipes;
                    //error messages displays if user give a letter input and not  an umber
                    if (!int.TryParse(Console.ReadLine(), out numRecipes) || numRecipes <= 0)
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number greater than 0.");
                        continue;
                    }
                    //loops if recipe is more than 1
                    for (int j = 0; j < numRecipes; j++)
                    {
                        //asks user for recipe name
                        Console.WriteLine($"Recipe {j + 1}:");
                        Console.WriteLine("Enter recipe name: ");
                        string recipeName = Console.ReadLine();
                         //stores recipe name
                        Recipe newRecipe = new Recipe(recipeName);
                        newRecipe.CalorieNotifer = DisplayCalorieNotification; // Assigning the delegate

                        //asks user for number of ingredients
                        Console.WriteLine("Enter number of ingredients: ");
                        //captures input
                        int numIngredients;
                         //error message
                        if (!int.TryParse(Console.ReadLine(), out numIngredients) || numIngredients <= 0)
                        {
                            Console.WriteLine("Invalid input. Please enter a valid number greater than 0.");
                            continue;
                        }
                        //loops if ingredients are more than 1
                        for (int i = 0; i < numIngredients; i++)
                        {
                            //prompts user for ingredient details and stores it
                            Console.WriteLine($"Ingredient {i + 1}");
                                //captures ingredient name
                            Console.WriteLine("Name: ");
                            string ingredientName = Console.ReadLine();
                                //captures ingredient quantity
                            Console.WriteLine("Quantity: ");
                            int ingredientQuantity;
                                //must have a number input for quantity
                            if (!int.TryParse(Console.ReadLine(), out ingredientQuantity) || ingredientQuantity <= 0)
                            {
                                Console.WriteLine("Invalid input. Please enter a valid number greater than 0.");
                                continue;
                            }
                            //captures ingredient unit of measurement
                            Console.WriteLine("Unit of Measurement (ml/mg/teaspoon/tablespoon/cup)");
                            string unitOfMeasurement = Console.ReadLine();
                                //captures calories
                            Console.WriteLine("Enter calorie amount: ");
                            double calories;
                                //must be a number input
                            if (!double.TryParse(Console.ReadLine(), out calories) || calories <= 0)
                            {
                                Console.WriteLine("Invalid input. Please enter a valid number greater than 0.");
                                continue;
                            }
                            //addes to new recipe add ingredients list
                            newRecipe.AddIngredients(ingredientName, ingredientQuantity, unitOfMeasurement, calories);
                        }
                        //captures steps
                        Console.WriteLine("Enter the number of steps: ");
                        int numSteps;
                        if (!int.TryParse(Console.ReadLine(), out numSteps) || numSteps <= 0)
                        {
                            Console.WriteLine("Invalid input. Please enter a valid number greater than 0.");
                            continue;
                        }
                        //loops steps if more than 1
                        for (int i = 0; i < numSteps; i++)
                        {
                            Console.WriteLine($"Step {i + 1}: ");
                            string step = Console.ReadLine();
                                //stores steps in list
                            newRecipe.AddStep(step);
                        }
                        //adds steps to new recipe
                        recipes.Add(newRecipe);
                        Console.WriteLine($"Recipe {recipeName} successfully saved.");
                        Console.WriteLine();
                    }
                    //breaks back to main menu when everything is captured
                    break;


                case 2://case 2 relates to numeric option2 (displays all recipes)
                        //user interface will display dark yellow message
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        //user interface (user expectation handing)
                        Console.WriteLine("Are you sure you want to display the recipe?(y/n)");
                        //reads user input
                        string displayConfirmation = Console.ReadLine().ToLower();
                        //yes continues with option
                        if (displayConfirmation == "y")                        {
                            Console.WriteLine("Now Displaying Recipe");
                        }
                        //no returns to main
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
                        //resets colour
                        Console.ResetColor();
                        //interface design
                        Console.WriteLine("***********************************************");          
                        //interface header for case 2 option
                        Console.WriteLine("DISPLAYING ALL RECIPE DETAILS:");                        
                        Console.WriteLine("***********************************************");
                        //displays recipes in colour DarkBlue
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        //Sorts Recipes alphabetically by recipe name
                        var sortedRecipes = recipes.OrderBy(r => r.RecipeName);
                        //sorts all recipes
                        foreach (Recipe recipe in sortedRecipes)
                        {
                            //calls display method from recipe.cs
                            recipe.DisplayRecipe(true);
                            //resets colour
                            Console.ResetColor();
                        }
                        
                        break;
                        
                    case 3://case 3 relates to numeric option 3(displays a specific recipe based on user input)
                           //user interface will display dark yellow message
                           //user interface (user expectation handing)
                           //reads user input
                           //no returns to main
                           //yes continues with option

                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("Are you sure you want to display a specific recipe?(y/n)");
                        string displaySpecificConfirmation = Console.ReadLine().ToLower();
                        if (displaySpecificConfirmation == "y")
                        {
                            Console.WriteLine("Now Displaying Specific Recipe");
                        }
                        else if (displaySpecificConfirmation == "n")
                        {
                            Console.WriteLine("Returning to the main menu.");
                            continue;
                        }                 
                        //resets colour
                        Console.ResetColor();
                        //interface design
                        Console.WriteLine("***********************************************");
                        //
                        Console.WriteLine("DISPLAYING SPECIFIC RECIPE:");
                        //dipslyas recipe names list in darkgreen
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("***********************************************");
                        Console.WriteLine("LIST OF RECIPES:");
                        Console.WriteLine("***********************************************");
                        //sorts recipe names alphabeticallys
                        var sortedRecipesByNameForDisplayingSpecificRecipe = recipes.OrderBy(r => r.RecipeName);
                        foreach (Recipe recipe in sortedRecipesByNameForDisplayingSpecificRecipe)
                        {
                            //display header and calls recipe names
                            Console.WriteLine($"RecipeName: {recipe.RecipeName}");
                            Console.WriteLine("***********************************************");
                        }
                        //resets colour
                        Console.ResetColor();
                        //asks user what recipe they want to display
                        Console.WriteLine("Enter Name of Recipe To Display:");
                        string recipeToDisplay = Console.ReadLine();
                        //displays that recipe based on user input
                        Recipe specificRecipe = recipes.FirstOrDefault(r => r.RecipeName.Equals(recipeToDisplay, StringComparison.OrdinalIgnoreCase));
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        if (specificRecipe != null)
                        {
                            //calls display recipe method for that specific recipe
                            specificRecipe.DisplayRecipe(true);
                        }
                        else
                        {
                            //no recipe by that name found
                            Console.WriteLine("Recipe not found.");
                        }
                        //resets colour to default
                        Console.ResetColor();
                        break;


                    case 4://case 4 relates to numeric option 4 (scale a recipe by user input)
                           //user interface will display dark yellow message
                           //user interface (user expectation handing)
                           //reads user input
                           //no returns to main
                           //yes continues with option

                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("Are you sure you want to scale the recipe?(y/n)");
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
                        //interface design
                        Console.WriteLine("***********************************************");   
                        //scale header
                        Console.WriteLine("SCALE SPECIFIC RECIPE:");                        
                        Console.WriteLine("***********************************************"); 
                        //if there are no recipes give message and goes back to main menu
                        if (recipes.Count == 0)
                        {
                            Console.WriteLine("THERE IS NO RECIPE TO SCALE");
                            Console.WriteLine("RETURNING TO MAIN MENU");
                            continue;
                        }
                        //dipslyas recipe names list in darkgreen
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("***********************************************");
                        Console.WriteLine("LIST OF RECIPES:");
                        Console.WriteLine("***********************************************");
                        //sorts recipe names alphabeticallys
                        var sortedRecipesByNameForScaling = recipes.OrderBy(r => r.RecipeName);
                        foreach (Recipe recipe in sortedRecipesByNameForScaling)
                        {
                            //display header and calls recipe name
                            Console.WriteLine($"RecipeName: {recipe.RecipeName}");
                            Console.WriteLine("***********************************************");
                        }
                        //resets colour
                        Console.ResetColor();
                        //asks user what recipe they want to scale 
                        Console.WriteLine("Enter the name of the recipe to scale:");
                        string recipeToScale = Console.ReadLine();
                        Recipe recipeToScaleObject = recipes.FirstOrDefault(r => r.RecipeName.Equals(recipeToScale, StringComparison.OrdinalIgnoreCase));
                        if (recipeToScaleObject != null)
                        {
                            //must scale it by the 3 options there are
                            Console.WriteLine("Enter the scale factor (0.5, 2, or 3):");
                            if (!double.TryParse(Console.ReadLine(), out double scaleFactor) || (scaleFactor != 0.5 && scaleFactor != 2 && scaleFactor != 3))
                            {
                                Console.WriteLine("Invalid scale factor. Please enter 0.5, 2, or 3.");
                                continue;
                            }
                            // Set console text color to Cyan for better visibility
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            // Scale the recipe using the specified scaleFactor
                            recipeToScaleObject.ScaleRecipe(scaleFactor);
                            // Print a message to indicate that the recipe has been scaled
                            Console.WriteLine("Scaled Recipe:");
                            // Display the scaled recipe, including all details
                            recipeToScaleObject.DisplayRecipe(true);
                        }
                        else
                        {
                            //recipe chosen wasnt found
                            Console.WriteLine("Recipe not found.");
                        }
                        //resets colour 
                        Console.ResetColor();
                        break;

                    case 5:
                        //user interface will display dark yellow message
                        //user interface (user expectation handing)
                        //reads user input
                        //no returns to main
                        //yes continues with option

                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("Are you sure you want to reset recipe?(y/n)");
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
                        //dipslyas recipe names list in darkgreen
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        //user interface design
                        Console.WriteLine("***********************************************");
                        Console.WriteLine("LIST OF RECIPES:");
                        Console.WriteLine("***********************************************");
                        //sorts alphabetically by recipe name
                        var sortedRecipesByNameForReseting = recipes.OrderBy(r => r.RecipeName);
                        foreach (Recipe recipe in sortedRecipesByNameForReseting)
                        {
                            //display header and calls recipe name
                            Console.WriteLine($"RecipeName: {recipe.RecipeName}");
                            Console.WriteLine("***********************************************");
                        }
                        Console.ResetColor();
                        //asks user what recipe they want to reset
                        Console.WriteLine("Enter the name of the recipe to reset:");
                        string recipeToReset = Console.ReadLine();
                        Recipe recipeToResetObject = recipes.FirstOrDefault(r => r.RecipeName.Equals(recipeToReset, StringComparison.OrdinalIgnoreCase));
                        if (recipeToResetObject != null)
                        {
                            //displays message as green
                            Console.ForegroundColor = ConsoleColor.Green;
                            recipeToResetObject.ResetRecipe();
                            Console.WriteLine("Recipe reset successfully!");
                        }
                        else
                        {
                            //recipe not found
                            Console.WriteLine("Recipe not found.");
                            Console.ResetColor();
                        }
                        break;

                    case 6://case 6 relates to option 6 clears all the recipes stored in the collection
                           //user interface will display dark yellow message
                           //user interface (user expectation handing)
                           //reads user input
                           //no returns to main
                           //yes continues with option

                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("Are you sure you want to clear all recipes?(y/n)");
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
                        Console.ResetColor();//reset colour
                        Console.WriteLine("***********************************************");
                        Console.WriteLine("CLEAR RECIPE DATA:");
                        Console.WriteLine("***********************************************");
                        if(recipes.Count == 0)//if recipes = 0 there are no recipes to clear error message
                        {
                            Console.WriteLine("THERE ARE NO RECIPES TO CLEAR");
                            Console.WriteLine("RETURNING TO MAIN MENU");
                            continue;
                        }
                        recipes.Clear();
                        //green messages displays if there was recipes to clear
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("ALL RECIPES DATA SUCCESSFULLY CLEARED");
                        Console.ResetColor();
                        Console.WriteLine();                       
                        break;

                    case 7://case 7 is numeric option 7 to delete a certain recipe
                           //user interface will display dark yellow message
                          
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        //user interface (user expectation handing)
                        
                        Console.WriteLine("Are you sure you want to clear a recipe's data(y/n)");
                        //reads user input
                        //no returns to main
                        //yes continues with option

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
                        //sorts alphabetically
                        var sortedRecipesByNameForClearing = recipes.OrderBy(r => r.RecipeName);
                        foreach (Recipe recipe in sortedRecipesByNameForClearing)
                        {
                            //displays header and recipe names
                            Console.WriteLine($"RecipeName: {recipe.RecipeName}");
                            Console.WriteLine("***********************************************");
                        }
                        Console.ResetColor();
                        //asks user what recipe they want to clear
                        Console.WriteLine("Enter Name of Recipe To Clear:");
                        //reads input
                        string recipeToClear = Console.ReadLine();
                        Recipe recipeToClearObject = recipes.FirstOrDefault(r => r.RecipeName.Equals(recipeToClear, StringComparison.OrdinalIgnoreCase));
                        if (recipeToClearObject != null)
                        {
                            //deletes recipe from collections
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
        //Method for delegates
        //Calls delegate function for message
        static void DisplayCalorieNotification(string message)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }

}