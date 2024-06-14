// Define the namespace for the RecipeApplication models
namespace RecipeApplication.Models
{
    // Class representing an ingredient used in recipes
    public class Ingredient
    {
        // Property to store the name of the ingredient
        public string Name { get; set; }

        // Property to store the quantity of the ingredient
        public double Quantity { get; set; }

        // Property to store the unit of measurement for the quantity
        public string Unit { get; set; }

        // Property to store the calorie count of the ingredient
        public double Calories { get; set; }

        // Property to store the food group the ingredient belongs to
        public string FoodGroup { get; set; }
    }
}

