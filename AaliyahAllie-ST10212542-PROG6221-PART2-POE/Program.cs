//Aaliyah Allie ST10212542 PART 1
//Prog6221 PART 1
namespace AaliyahAllie_ST10212542_PROG6221_PART1
{
    //MAIN CLASS
    public class Program
    {
        //main method
        static void Main(string[] args)
        {
            //Array list to store values
            List<Recipe> recipes = new List<Recipe>();
            int choice = 0;

            // Loop continues indefinitely until explicitly exited
            while (true)
            {
                //Basic user interface
                Console.WriteLine("***********************************************");
                //header
                Console.WriteLine("Welcome To Your Recipe Application");
                //seperation line
                Console.WriteLine("***********************************************");
                //user interface instruction
                Console.WriteLine("Please enter (1) to launch the menu");
                //empty line for better formating
                Console.WriteLine();


                //if statment
                //if user selects anything other than 1 an error message will display
                if (!int.TryParse(Console.ReadLine(), out choice) || choice != 1)
                {
                    Console.WriteLine("INVALID OPTION.ENTER (1) TO LAUNCH MENU");
                    //after error messsage displays it will go back to the previous display
                    continue;
                }
                //empty line for better display
                Console.WriteLine();

                //user interface message display
                //seperation line
                Console.WriteLine("***********************************************");
                //user instruction
                //tells user to select a numeric option i.e; 1, 2 , 3...
                Console.WriteLine("PLEASE SELECT ONE OF THE NUMERIC OPTIONS BELOW");
                //seperation line
                Console.WriteLine("***********************************************");
                //Option 1 will allow a user to enter the details for a new recipe (Recipe name, ingredients names,quantities,units of measurement and steps)
                Console.WriteLine("1.Enter new recipe");
                //Option 2 will display all the information the user gave in the previous option(Enter new recipe)
                Console.WriteLine("2.Display recipe");
                //Option 3 will allow the user to scale their recipe by 0.5,2 or 3
                //0.5 divide, 2 multiply by 2, 3 multiple by 3
                Console.WriteLine("3.Scale recipe (0.5, 2, or 3)");
                //Option 4 will erase all the previous option and display the original recipe of the users input in Option 1
                Console.WriteLine("4.Reset recipe to original values");
                //Option 5 will delete all the stored data in the array's so they will be blank
                Console.WriteLine("5.Clear recipe data");
                //Option 6 allows the user to close the program
                Console.WriteLine("6.Exit Program");
                //seperation line
                Console.WriteLine("***********************************************");
                //empty line for formatting
                Console.WriteLine();

                //the following code is how we will get the above numeric menu to work
                // User input validation for selected menu option
                int userChoice;
                //if user picks the wrong option say they pick 7 instead of 1-6 then the program will go back to the main menu after giving an error message
                if (!int.TryParse(Console.ReadLine(), out userChoice))
                {
                    //error message
                    Console.WriteLine("INVALID CHOICE.PLEASE ENTER A VALID NUMBER.");
                    //continues back to make menu
                    continue;
                }
                //empty line for formatting
                Console.WriteLine();

                // Handling different menu options
                switch (userChoice)
                {
                    //option 1's code
                    //allows for user to enter new recipe details
                    case 1:
                        //user exption handling
                        //code works by first asking the sure if they are sure they want to proceed with this selected option,
                        //if yes (y) it will continue to allow them to enter the details,
                        //if not (n) it will go back to the main menu 
                        Console.WriteLine("Are you sure you want to enter a new recipe?(y/n)");
                        string recipeConfirmation = Console.ReadLine().ToLower();
                        //if yes proceeds
                        if (recipeConfirmation == "y")
                        {
                            Console.WriteLine("Now Capturing Recipe");
                        }
                        //if no goes back
                        else if (recipeConfirmation == "n")
                        {
                            Console.WriteLine("Returning to the main menu.");
                            continue;
                        }
                        //user interface
                        //seperation line
                        Console.WriteLine("***********************************************");
                        //heading
                        Console.WriteLine("ENTER NEW RECIPE DETAILS");
                        //seperation line
                        Console.WriteLine("***********************************************");
                        //prompts user to enter the name of the recipe
                        Console.WriteLine("Enter recipe name: ");
                        //system reads input
                        string recipeName = Console.ReadLine();
                        //system stores input
                        Recipe newRecipe = new Recipe(recipeName);
                        //prompts user to let it know how many ingredients their are
                        Console.WriteLine("Enter number of ingredients: ");
                        //int declartion for number of ingreidents
                        int numIngredients;
                        //if user input is invalid error message
                        if (!int.TryParse(Console.ReadLine(), out numIngredients))
                        {
                            Console.WriteLine("INVALID INPUT.PLEASE ENTER A VALID NUMBER.");
                            //continues back
                            continue;
                        }
                        //loops through each ingreident entry
                        for (int i = 0; i < numIngredients; i++)
                        {
                            // Display the index of the ingredient being entered
                            Console.WriteLine($"Ingredient {i + 1}");
                            // Prompts user for the name of the ingredient
                            Console.WriteLine("Name: ");
                            //system reads input
                            string ingredientName = Console.ReadLine();
                            //prompts user for the quantity of the ingreident
                            Console.WriteLine("Quantity: ");
                            //if user inputs a string an error will occur
                            int ingredientQuantity;//int declartion for ingredient quantity
                            if (!int.TryParse(Console.ReadLine(), out ingredientQuantity))
                            {
                                Console.WriteLine("Invalid input.Please enter a valid number.");
                                //continues back
                                continue;
                            }
                            //prompts user for the unit of measurement the ingriedient will be using
                            Console.WriteLine("Unit of Measurement (ml/mg/teaspoon/tablespoon/cup)");
                            //system reads input
                            string unitOfMeasurement = Console.ReadLine();
                            //stores in rewRecipe and adds new ingredient details
                            newRecipe.AddIngredients(ingredientName, ingredientQuantity, unitOfMeasurement);
                        }
                        //prompts the user for the number of steps the recipe had
                        Console.WriteLine("Enter the number of steps: ");
                        //error message if there is an invalid input (string input)
                        int numSteps;//declation for steps
                        if (!int.TryParse(Console.ReadLine(), out numSteps))
                        {
                            Console.WriteLine("Invalid input. Please enter a valid number.");
                            //continues back
                            continue;
                        }
                        //loops through steps
                        for (int i = 0; i < numSteps; i++)
                        {
                            //prompts the user for the steps numbers 1 - whatever amount of steps there is
                            Console.WriteLine($"Step {i + 1}: ");
                            //system reads input
                            string step = Console.ReadLine();
                            //system adds steps and stores it
                            newRecipe.AddStep(step);
                        }
                        // Add the newly created recipe to the list of recipes
                        recipes.Add(newRecipe);
                        //successful message when all information is saved
                        Console.WriteLine("RECIPE SUCCESSFULLY SAVED");
                        //empty line for formatting
                        Console.WriteLine();
                        // Exit the loop as the recipe has been successfully saved
                        //goes back to launch
                        break;


                    case 2:
                        //user exption handling
                        //code works by first asking the sure if they are sure they want to proceed with this selected option,
                        //if yes (y) it will continue to allow them to enter the details,
                        //if not (n) it will go back to the main menu 
                        Console.WriteLine("Are you sure ypu want to display the recipe?(y/n)");
                        string displayConfirmation = Console.ReadLine().ToLower();
                        //if yes proceeds
                        if (displayConfirmation == "y")
                        {
                            Console.WriteLine("Now Displaying Recipe");
                        }
                        //if no goes back
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
                        //user interface
                        //displays the recipe
                        //seperation line
                        Console.WriteLine("***********************************************");
                        //header
                        Console.WriteLine("DISPLAYING RECIPE DETAILS:");
                        //seperation line
                        Console.WriteLine("***********************************************");
                        // Iterate through each recipe in the list of recipes
                        foreach (Recipe recipe in recipes)
                        {
                            // Display the details of the current recipe
                            recipe.DisplayRecipe();
                            //empty space for formatting
                            Console.WriteLine();
                        }
                        // Exit the loop as the display has been successful
                        //goes back to launch
                        break;

                    case 3:
                        //user exption handling
                        //code works by first asking the sure if they are sure they want to proceed with this selected option,
                        //if yes (y) it will continue to allow them to enter the details,
                        //if not (n) it will go back to the main menu 
                        Console.WriteLine("Are you sure ypu want to scale the recipe?(y/n)");
                        string scaleConfirmation = Console.ReadLine().ToLower();
                        //if yes proceeds
                        if (scaleConfirmation == "y")
                        {
                            Console.WriteLine("Now Scaling Recipe");
                        }
                        //if no goes back
                        else if (scaleConfirmation == "n")
                        {
                            Console.WriteLine("Returning to the main menu.");
                            continue;
                        }
                        //user interface
                        //scales the recipe by a factor
                        //seperation line
                        Console.WriteLine("***********************************************");
                        //header
                        Console.WriteLine("SCALE RECIPE:");
                        //seperation line
                        Console.WriteLine("***********************************************");
                        //prompts the user for the inputs : 0,5;2,or 3
                        Console.WriteLine("Enter the scaling factor(0.5,2,3): ");
                        //double declartion for scale factor (because there is a decimal option)
                        double scaleFactor;
                        //error if a user gives an option that isn't those 3
                        if (!double.TryParse(Console.ReadLine(), out scaleFactor))
                        {
                            Console.WriteLine("Invalid input.Enter a valid number");
                            //continues back
                            continue;
                        }
                        // Iterate through each recipe in the list of recipes
                        foreach (Recipe recipe in recipes)
                        {
                            //reads and calls the method on Recipe.cs
                            recipe.ScaleRecipe(scaleFactor);
                        }
                        Console.WriteLine("RECIPE SUCCESSFULLY SAVED");
                        Console.WriteLine();
                        // Exit the loop as the recipe has been successfully saved
                        //goes back to launch
                        break;

                    case 4:
                        //user exption handling
                        //code works by first asking the sure if they are sure they want to proceed with this selected option,
                        //if yes (y) it will continue to allow them to enter the details,
                        //if not (n) it will go back to the main menu 
                        Console.WriteLine("Are you sure ypu want to reset the recipe?(y/n)");
                        string resetConfirmation = Console.ReadLine().ToLower();
                        //if yes proceeds
                        if (resetConfirmation == "y")
                        {
                            Console.WriteLine("Now Reseting Recipe");
                        }
                        //if no goes back
                        else if (resetConfirmation == "n")
                        {
                            Console.WriteLine("Returning to the main menu.");
                            continue;
                        }
                        //user interface
                        //resets to original values
                        Console.WriteLine("***********************************************");
                        //header
                        Console.WriteLine("RESET RECIPE TO ORIGINAL VALUES");
                        Console.WriteLine("***********************************************");
                        // Iterate through each recipe in the list of recipes
                        foreach (Recipe recipe in recipes)
                        {
                            //reads and calls the method on Recipe.cs
                            recipe.ResetRecipe();
                        }
                        Console.WriteLine("RECIPE SUCCESSFULLY SAVED");
                        Console.WriteLine();
                        // Exit the loop as the recipe has been successfully reset
                        //goes back to launch
                        break;

                    case 5:
                        //user exption handling
                        //code works by first asking the sure if they are sure they want to proceed with this selected option,
                        //if yes (y) it will continue to allow them to enter the details,
                        //if not (n) it will go back to the main menu 
                        Console.WriteLine("Are you sure ypu want to clear the recipe?(y/n)");
                        string clearConfirmation = Console.ReadLine().ToLower();
                        //if yes proceeds
                        if (clearConfirmation == "y")
                        {
                            Console.WriteLine("Now Clearing Recipe");
                        }
                        else if (clearConfirmation == "n")
                        {
                            Console.WriteLine("Returning to the main menu.");
                            continue;
                        }
                        //user interface
                        Console.WriteLine("***********************************************");
                        Console.WriteLine("CLEAR RECIPE DATA:");
                        Console.WriteLine("***********************************************");

                        //reads and calls the method on Recipe.cs
                        recipes.Clear();

                        //data has been cleared message
                        Console.WriteLine("RECIPE DATA SUCCESSFULLY CLEARED");
                        Console.WriteLine();
                        // Exit the loop as the recipe has been deleted
                        //goes back to launch
                        break;

                    case 6:
                        //user exption handling
                        //code works by first asking the sure if they are sure they want to proceed with this selected option of exiting
                        //if yes (y) it will continue to allow them to exit,
                        //if not (n) it will go back to the main menu 
                        Console.WriteLine("Are you sure you want to exit? (y/n)");
                        string exitConfirmation = Console.ReadLine().ToLower();
                        //if yes proceeds
                        if (exitConfirmation == "y")
                        {
                            Console.WriteLine("THANK YOU FOR USING THIS APPLICATION");
                            Console.WriteLine("PROGRAM WILL NOW CLOSE");
                            Environment.Exit(0);
                        }
                        //if no goes back
                        else if (exitConfirmation == "n")
                        {
                            Console.WriteLine("Returning to the main menu.");
                            continue;
                        }
                        else
                        //error message if wrong option is chosen
                        {
                            Console.WriteLine("Invalid input. Returning to the main menu.");
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
    }

}