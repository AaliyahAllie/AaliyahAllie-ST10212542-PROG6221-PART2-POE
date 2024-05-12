//PROG PART 2
//AALIYAH ALLIE PROG PART 2
//INGREDIENTS.CS PAGE
//THIS PAGE OF CODE CONTAINS MY INGREDIENTS.CS FOR VARIABLES THAT ARE CALLED BY THE RECIPE.CS CLASS

//Defining the namespace of my INGREDIENTS.CS
namespace AaliyahAllie_ST10212542_PROG6221_PART2_POE
{
    // This namespace contains the class definitions for managing ingredients.
    public class Ingredient
    {// Represents an ingredient with properties for its name, quantity, original quantity, unit of measurement,
     // calories, original calories, food group, and food group number.

        
        //Getter and Setter for the Name variable
        public string Name { get; set; }
        //Getter and Setter for the Quantity variable
        public int Quantity { get; set; }
        //Getter and Setter for the OriginalQuantity variable
        //This is used to store the original quantity input for when the reset method is active
        public int OriginalQuantity { get; set; }
        //Getter and Setter for the UnitOfMeasuremnet variable
        public string UnitOfMeasurement { get; set; }
        public double Calories { get; set; }
        //Getter and Setter for the OriginalCalories variable
        //This is used to store the original calories input for when the reset method is active
        public double OriginalCalories { get; set; }
        //Getter and Setter for the FoodGroup variable
        public string FoodGroup { get; set; }
        //Getter and Setter for the OriginalQuantity variable
        //Captures what food group the user sets for an ingredient
        public int FoodGroupNumber { get; set; }
    }
}
