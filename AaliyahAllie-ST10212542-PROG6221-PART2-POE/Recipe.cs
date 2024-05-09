namespace AaliyahAllie_ST10212542_PROG6221_PART1
{
    //public class for the recipe details where all the code will be
    public class Recipe
    {
        //declaration of variable names (strings and int) this is what the code will call and refer back to when storing and manpulating data

        //String declaration for RecipeName
        // stores the name of the recipe; property contains a getter and setter
        public string RecipeName { get; set; }

        //String declaration for Ingredient's Names; also gets stored into a List Array
        //stores ingredients names; property contains a getter and setter
        public List<string> IngredientNames { get; set; }

        //Int declartion for IngredientQuantities; also gets stored into a List Array
        //stores ingredients quantite; property contains a getter and setter
        public List<int> IngredientQuantities { get; set; }

        //Int declartion for OriginalQuantities; also gets stored into a List Array
        //stores original quantities; property contains a getter and setter
        public List<int> OriginalQuantities { get; set; }

        //Int declartion for Unit of Measurement; also gets stored into a List Array
        //stores units of measurements; property contains a getter and setter
        public List<string> UnitOfMeasurements { get; set; }

        //Int declartion for Steps; also gets stored into a List Array
        //stores steps; property contains a getter and setter
        public List<string> Steps { get; set; }

        //this is a method for storing the Recipe Name
        public Recipe(string recipeName)
        {
            //if a user gives an input the system gives the instruction to store the recipe name
            RecipeName = recipeName;
            //takes user input and stores into array list <string>
            IngredientNames = new List<string>();
            //takes user input and stores into array list <int>
            IngredientQuantities = new List<int>();
            //takes user input and stores into array list <int>
            OriginalQuantities = new List<int>();
            //takes user input and stores into array list <string>
            UnitOfMeasurements = new List<string>();
            //takes user input and stores into array list <string>
            Steps = new List<string>();
        }

        //this method is there to store the properties/details of the ingredients, such as its name,quantities,original quantities and units of measurement
        // Method to add ingredients to the recipe
        public void AddIngredients(string name, int quantity, string unitOfMeasurement)
        {
            // If the unit of measurement is tablespoons and the quantity is 8 or more, convert to cups
            if (unitOfMeasurement.ToLower() == "tablespoons" && quantity >= 8)
            {
                // Convert tablespoons to cups (1 cup = 16 tablespoons)
                quantity = (int)Math.Ceiling((double)quantity / 16);
                // Update the unit of measurement to cups
                unitOfMeasurement = "cups";
            }

            // Add the ingredient name to the list of ingredient names
            IngredientNames.Add(name);
            // Add the quantity of the ingredient to the list of ingredient quantities
            IngredientQuantities.Add(quantity);
            // Add the original quantity of the ingredient to the list of original quantities (for scaling)
            OriginalQuantities.Add(quantity);
            // Add the unit of measurement for the ingredient to the list of unit of measurements
            UnitOfMeasurements.Add(unitOfMeasurement);
        }

        // Method to add steps to the recipe
        public void AddStep(string step)
        {
            //adds the steps inputed by user and stores it in the list for steps
            Steps.Add(step);
        }

        //method to display the full recipe(ingredient details and steps)
        public void DisplayRecipe()
        {
            //basic user inface design
            //seperator line
            Console.WriteLine("***********************************");
            //prints a heading
            Console.WriteLine("RECIPE DETAILS");
            //seperator line
            Console.WriteLine("***********************************");
            //prints the name of the recipe
            Console.WriteLine("Recipe Name: " + RecipeName);
            //prints all the details of the recipe(ingredients)
            //Ingredients Header
            Console.WriteLine("Ingredients: ");
            // Loop through each ingredient and print its details
            for (int i = 0; i < IngredientNames.Count; i++)
            {
                Console.WriteLine($"{IngredientNames[i]} - {IngredientQuantities[i]} {UnitOfMeasurements[i]}");
            }
            //prints steps details
            //Step Header
            Console.WriteLine("Steps: ");
            // Loop through each step and print its number and description
            for (int i = 0; i < Steps.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{Steps[i]}");
            }
            //sepator line
            Console.WriteLine("***********************************");
            //prints an empty line to allow better formatting for user interface
            Console.WriteLine();
        }

        //method to scale the recipe by 0.5,2 & 3
        public void ScaleRecipe(double factor)
        {
            // Loop through each ingredient quantity
            for (int i = 0; i < IngredientQuantities.Count; i++)
            {
                // Scales the quantity of each ingredient by the given factor and cast to int
                IngredientQuantities[i] = (int)(OriginalQuantities[i] * factor);
            }
        }

        //method to reset the recipe make to its original scale
        public void ResetRecipe()
        {
            // Reset quantities to original values
            for (int i = 0; i < IngredientQuantities.Count; i++)
            {
                IngredientQuantities[i] = OriginalQuantities[i];
            }
        }
    }
}
