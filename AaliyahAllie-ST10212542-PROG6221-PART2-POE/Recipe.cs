namespace AaliyahAllie_ST10212542_PROG6221_PART1
{
    
    public class Recipe
    {
        public string RecipeName { get; set; }

        public List<string> IngredientNames { get; set; }

        public List<int> IngredientQuantities { get; set; }

        public List<int> OriginalQuantities { get; set; }

        public List<string> UnitOfMeasurements { get; set; }

        public List<string> Steps { get; set; }

       
        public Recipe(string recipeName)
        {
           
            RecipeName = recipeName;
           
            IngredientNames = new List<string>();
           
            IngredientQuantities = new List<int>();
          
            OriginalQuantities = new List<int>();
            
            UnitOfMeasurements = new List<string>();
           
            Steps = new List<string>();
        }

        public void AddIngredients(string name, int quantity, string unitOfMeasurement)
        {
           
            if (unitOfMeasurement.ToLower() == "tablespoons" && quantity >= 8)
            {
              
                quantity = (int)Math.Ceiling((double)quantity / 16);
               
                unitOfMeasurement = "cups";
            }

            
            IngredientNames.Add(name);
            
            IngredientQuantities.Add(quantity);
            
            OriginalQuantities.Add(quantity);
           
            UnitOfMeasurements.Add(unitOfMeasurement);
        }

      
        public void AddStep(string step)
        {
            
            Steps.Add(step);
        }

       
        public void DisplayRecipe()
        {
            
            Console.WriteLine("***********************************");
           
            Console.WriteLine("RECIPE DETAILS");
           
            Console.WriteLine("***********************************");
           
            Console.WriteLine("Recipe Name: " + RecipeName);
           
            Console.WriteLine("Ingredients: ");
            for (int i = 0; i < IngredientNames.Count; i++)
            {
                Console.WriteLine($"{IngredientNames[i]} - {IngredientQuantities[i]} {UnitOfMeasurements[i]}");
            }
            
            Console.WriteLine("Steps: ");
           
            for (int i = 0; i < Steps.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{Steps[i]}");
            }
            
            Console.WriteLine("***********************************");
           
            Console.WriteLine();
        }

       
        public void ScaleRecipe(double factor)
        {
           
            for (int i = 0; i < IngredientQuantities.Count; i++)
            {
                
                IngredientQuantities[i] = (int)(OriginalQuantities[i] * factor);
            }
        }

        public void ResetRecipe()
        {
           
            for (int i = 0; i < IngredientQuantities.Count; i++)
            {
                IngredientQuantities[i] = OriginalQuantities[i];
            }
        }
    }
}
