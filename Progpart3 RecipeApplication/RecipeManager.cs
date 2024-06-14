using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace RecipeApplication.Models
{
    // Class to manage a collection of recipes
    public class RecipeManager
    {
        // List to store recipes
        public List<Recipe> recipes = new List<Recipe>();

        // Method to load initial recipes into the list
        public void LoadInitialRecipes()
        {
            // Adding a "Classic Grilled Cheese Sandwich" recipe
            recipes.Add(new Recipe
            {
                Name = "Classic Grilled Cheese Sandwich",
                Ingredients = new List<Ingredient>
                {
                    new Ingredient { Name = "Bread", Quantity = 2, Unit = "slices" },
                    new Ingredient { Name = "Cheese", Quantity = 1, Unit = "slice" },
                    new Ingredient { Name = "Butter", Quantity = 1, Unit = "tablespoon" },
                    new Ingredient { Name = "Salt", Quantity = 1, Unit = "to taste" },
                    new Ingredient { Name = "Pepper", Quantity = 1, Unit = "to taste" },
                },
                Steps = new List<Step>
                {
                    new Step { Description = "Butter one side of each slice of bread." },
                    new Step { Description = "Place one slice of bread, butter-side down, in a pan or skillet over medium heat." },
                    new Step { Description = "Place one or two slices of cheese on top of the bread." },
                    new Step { Description = "Place the second slice of bread, butter-side up, on top of the cheese." },
                    new Step { Description = "Cook for 2-3 minutes or until the bread is golden brown and the cheese is melted." },
                    new Step { Description = "Flip the sandwich over and cook for an additional 2-3 minutes or until the other side is also golden brown." }
                }
            });

            // Adding a "One-Pot Pasta with Tomato Sauce" recipe
            recipes.Add(new Recipe
            {
                Name = "One-Pot Pasta with Tomato Sauce",
                Ingredients = new List<Ingredient>
                {
                    new Ingredient { Name = "Pasta", Quantity = 1, Unit = "pound" },
                    new Ingredient { Name = "Cherry tomatoes", Quantity = 2, Unit = "cups" },
                    new Ingredient { Name = "Onion", Quantity = 1, Unit = "diced" },
                    new Ingredient { Name = "Garlic", Quantity = 2, Unit = "cloves" },
                    new Ingredient { Name = "Crushed tomatoes", Quantity = 1, Unit = "can" },
                    new Ingredient { Name = "Olive oil", Quantity = 1, Unit = "tablespoon" },
                    new Ingredient { Name = "Salt", Quantity = 1, Unit = "to taste" },
                    new Ingredient { Name = "Pepper", Quantity = 1, Unit = "to taste" },
                    new Ingredient { Name = "Parmesan cheese", Quantity = 1, Unit = "grated (optional)" },
                },
                Steps = new List<Step>
                {
                    new Step { Description = "Bring a large pot of salted water to a boil." },
                    new Step { Description = "Add the pasta and cook according to package instructions." },
                    new Step { Description = "In a large skillet, heat the olive oil over medium heat." },
                    new Step { Description = "Add the onion and garlic and cook until the onion is translucent." },
                    new Step { Description = "Add the cherry tomatoes and cook for an additional 2-3 minutes." },
                    new Step { Description = "Add the crushed tomatoes and stir to combine." },
                    new Step { Description = "Simmer the sauce for 10-15 minutes or until the flavors have melded together." },
                    new Step { Description = "Drain the pasta and add it to the skillet with the sauce." },
                    new Step { Description = "Toss to combine and season with salt and pepper to taste." },
                    new Step { Description = "Top with grated Parmesan cheese if desired." }
                }
            });

            // Adding a "Chicken Curry" recipe
            recipes.Add(new Recipe
            {
                Name = "Chicken Curry",
                Ingredients = new List<Ingredient>
                {
                    new Ingredient { Name = "Chicken breast", Quantity = 2, Unit = "pieces" },
                    new Ingredient { Name = "Onion", Quantity = 1, Unit = "large, chopped" },
                    new Ingredient { Name = "Garlic", Quantity = 3, Unit = "cloves, minced" },
                    new Ingredient { Name = "Ginger", Quantity = 1, Unit = "tablespoon, minced" },
                    new Ingredient { Name = "Tomato puree", Quantity = 1, Unit = "cup" },
                    new Ingredient { Name = "Coconut milk", Quantity = 1, Unit = "cup" },
                    new Ingredient { Name = "Curry powder", Quantity = 2, Unit = "tablespoons" },
                    new Ingredient { Name = "Cumin", Quantity = 1, Unit = "teaspoon" },
                    new Ingredient { Name = "Turmeric", Quantity = 1, Unit = "teaspoon" },
                    new Ingredient { Name = "Salt", Quantity = 1, Unit = "to taste" },
                    new Ingredient { Name = "Pepper", Quantity = 1, Unit = "to taste" },
                    new Ingredient { Name = "Cilantro", Quantity = 1, Unit = "handful, chopped" }
                },
                Steps = new List<Step>
                {
                    new Step { Description = "Heat oil in a large pan over medium heat." },
                    new Step { Description = "Add chopped onions, garlic, and ginger and cook until onions are translucent." },
                    new Step { Description = "Add curry powder, cumin, and turmeric and cook for another minute." },
                    new Step { Description = "Add chicken pieces and cook until they are browned on all sides." },
                    new Step { Description = "Add tomato puree and coconut milk, bring to a simmer." },
                    new Step { Description = "Cook for 20-25 minutes until chicken is fully cooked and tender." },
                    new Step { Description = "Season with salt and pepper to taste." },
                    new Step { Description = "Garnish with chopped cilantro and serve with rice or naan." }
                }
            });

            // Adding a "Grilled Chicken and Vegetables" recipe
            recipes.Add(new Recipe
            {
                Name = "Grilled Chicken and Vegetables",
                Ingredients = new List<Ingredient>
                {
                    new Ingredient { Name = "Boneless, skinless chicken breast", Quantity = 1, Unit = "lb" },
                    new Ingredient { Name = "Mixed vegetables (such as bell peppers, onions, and mushrooms)", Quantity = 1, Unit = "cup" },
                    new Ingredient { Name = "Olive oil", Quantity = 2, Unit = "tbsp" },
                    new Ingredient { Name = "Salt", Quantity = 1, Unit = "to taste" },
                    new Ingredient { Name = "Pepper", Quantity = 1, Unit = "to taste" },
                },
                Steps = new List<Step>
                {
                    new Step { Description = "Preheat grill to medium-high heat." },
                    new Step { Description = "Season chicken with salt and pepper." },
                    new Step { Description = "Grill chicken for 5-6 minutes per side, or until cooked through." },
                    new Step { Description = "Grill vegetables for 3-4 minutes per side, or until tender." },
                    new Step { Description = "Serve chicken and vegetables together." }
                }
            });

            // Adding a "One-Pot Pasta" recipe
            recipes.Add(new Recipe
            {
                Name = "One-Pot Pasta",
                Ingredients = new List<Ingredient>
                {
                    new Ingredient { Name = "Pasta", Quantity = 1, Unit = "lb" },
                    new Ingredient { Name = "Marinara sauce", Quantity = 1, Unit = "cup" },
                    new Ingredient { Name = "Grated mozzarella cheese", Quantity = 1, Unit = "cup" },
                    new Ingredient { Name = "Chopped fresh basil", Quantity = 1, Unit = "1/4 cup" },
                    new Ingredient { Name = "Salt", Quantity = 1, Unit = "to taste" },
                    new Ingredient { Name = "Pepper", Quantity = 1, Unit = "to taste" },
                },
                Steps = new List<Step>
                {
                    new Step { Description = "Cook pasta according to package instructions." },
                    new Step { Description = "In a large pot, combine cooked pasta, marinara sauce, and mozzarella cheese." },
                    new Step { Description = "Stir until cheese is melted and sauce is well combined." },
                    new Step { Description = "Season with salt and pepper to taste." },
                    new Step { Description = "Serve hot, topped with basil." }
                }
            });

            // Adding a "Tacos" recipe
            recipes.Add(new Recipe
            {
                Name = "Tacos",
                Ingredients = new List<Ingredient>
                {
                    new Ingredient { Name = "Ground beef", Quantity = 1, Unit = "lb" },
                    new Ingredient { Name = "Taco seasoning", Quantity = 1, Unit = "packet" },
                    new Ingredient { Name = "Taco shells", Quantity = 8, Unit = "to 10" },
                    new Ingredient { Name = "Shredded cheese", Quantity = 1, Unit = "to taste" },
                    new Ingredient { Name = "Lettuce", Quantity = 1, Unit = "to taste" },
                    new Ingredient { Name = "Other toppings of your choice", Quantity = 1, Unit = "to taste" },
                },
                Steps = new List<Step>
                {
                    new Step { Description = "Brown ground beef in a skillet over medium-high heat." },
                    new Step { Description = "Add taco seasoning and cook according to package instructions." },
                    new Step { Description = "Warm taco shells according to package instructions." },
                    new Step { Description = "Assemble tacos by filling shells with beef, cheese, lettuce, and other toppings." },
                    new Step { Description = "Serve hot." }
                }
            });

            // Adding a "Baked Salmon" recipe
            recipes.Add(new Recipe
            {
                Name = "Baked Salmon",
                Ingredients = new List<Ingredient>
                {
                    new Ingredient { Name = "Salmon fillets", Quantity = 4, Unit = "(6 oz each)" },
                    new Ingredient { Name = "Olive oil", Quantity = 2, Unit = "tbsp" },
                    new Ingredient { Name = "Lemon juice", Quantity = 2, Unit = "tbsp" },
                    new Ingredient { Name = "Salt", Quantity = 1, Unit = "to taste" },
                    new Ingredient { Name = "Pepper", Quantity = 1, Unit = "to taste" },
                },
                Steps = new List<Step>
                {
                    new Step { Description = "Preheat oven to 400°F (200°C)." },
                    new Step { Description = "Line a baking sheet with parchment paper." },
                    new Step { Description = "Place salmon fillets on the baking sheet." },
                    new Step { Description = "Drizzle with olive oil and lemon juice." },
                    new Step { Description = "Season with salt and pepper to taste." },
                    new Step { Description = "Bake for 12-15 minutes, or until cooked through." }
                }
            });

            // Adding a "Fried Rice" recipe
            recipes.Add(new Recipe
            {
                Name = "Fried Rice",
                Ingredients = new List<Ingredient>
                {
                    new Ingredient { Name = "Cooked rice", Quantity = 2, Unit = "cups" },
                    new Ingredient { Name = "Mixed vegetables (such as peas, carrots, and corn)", Quantity = 1, Unit = "cup" },
                    new Ingredient { Name = "Vegetable oil", Quantity = 2, Unit = "tbsp" },
                    new Ingredient { Name = "Eggs", Quantity = 2, Unit = "beaten" },
                    new Ingredient { Name = "Soy sauce", Quantity = 1, Unit = "to taste" },
                },
                Steps = new List<Step>
                {
                    new Step { Description = "Heat oil in a large skillet over medium-high heat." },
                    new Step { Description = "Add mixed vegetables and cook until tender." },
                    new Step { Description = "Push vegetables to one side of the skillet." },
                    new Step { Description = "Add beaten eggs to the other side of the skillet and scramble until cooked through." },
                    new Step { Description = "Mix eggs and vegetables together." },
                    new Step { Description = "Add cooked rice to the skillet and stir-fry until combined with eggs and vegetables." },
                    new Step { Description = "Season with soy sauce to taste." }
                }
            });

            // Adding a "Quesadillas" recipe
            recipes.Add(new Recipe
            {
                Name = "Quesadillas",
                Ingredients = new List<Ingredient>
                {
                    new Ingredient { Name = "Tortillas", Quantity = 4, Unit = "" },
                    new Ingredient { Name = "Shredded cheese (cheddar or Monterey Jack)", Quantity = 2, Unit = "cups" },
                    new Ingredient { Name = "Optional fillings: diced chicken, diced bell peppers, diced onions", Quantity = 1, Unit = "to taste" },
                },
                Steps = new List<Step>
                {
                    new Step { Description = "Heat a large skillet over medium-high heat." },
                    new Step { Description = "Place a tortilla in the skillet and sprinkle with cheese." },
                    new Step { Description = "Add optional fillings if desired." },
                    new Step { Description = "Fold tortilla in half and cook for 2-3 minutes on each side, or until cheese is melted and tortilla is crispy." },
                    new Step { Description = "Serve hot." }
                }
            });

            // Adding a "Banana Bread" recipe
            recipes.Add(new Recipe
            {
                Name = "Banana Bread",
                Ingredients = new List<Ingredient>
                {
                    new Ingredient { Name = "Ripe bananas", Quantity = 3, Unit = "" },
                    new Ingredient { Name = "All-purpose flour", Quantity = 1, Unit = "cup" },
                    new Ingredient { Name = "Granulated sugar", Quantity = 1, Unit = "cup" },
                    new Ingredient { Name = "Unsalted butter, melted", Quantity = 1, Unit = "cup" },
                    new Ingredient { Name = "Large eggs", Quantity = 2, Unit = "" },
                    new Ingredient { Name = "Baking powder", Quantity = 1, Unit = "tsp" },
                    new Ingredient { Name = "Salt", Quantity = 1, Unit = "to taste" },
                },
                Steps = new List<Step>
                {
                    new Step { Description = "Preheat oven to 350°F (180°C)." },
                    new Step { Description = "Grease a loaf pan with butter or cooking spray." },
                    new Step { Description = "In a large bowl, mash bananas with a fork until smooth." },
                    new Step { Description = "Add flour, sugar, melted butter, eggs, baking powder, and salt to the bowl." },
                    new Step { Description = "Mix until well combined." },
                    new Step { Description = "Pour batter into the loaf pan and bake for 50-60 minutes, or until a toothpick inserted into the center comes out clean." }
                }
            });
        }

        // Method to add a new recipe
        public void AddRecipe()
        {
            // Prompt user to enter the name of the recipe
            string name = Prompt.ShowDialog("Enter the name of the recipe:", "Add Recipe");
            Recipe newRecipe = new Recipe { Name = name };
            recipes.Add(newRecipe);
        }

        // Method to display all recipes
        public void DisplayAllRecipes()
        {
            // Join all recipe names into a single string separated by new lines
            string allRecipes = string.Join("\n", recipes.Select(r => r.Name));
            MessageBox.Show(allRecipes, "All Recipes");
        }

        // Method to scale the quantities of ingredients in a recipe
        public void ScaleRecipe(double factor)
        {
            // Check if there are any recipes available
            if (recipes.Count == 0)
            {
                MessageBox.Show("No recipes available.");
                return;
            }

            // Select the first recipe in the list
            Recipe selectedRecipe = recipes.FirstOrDefault();
            if (selectedRecipe != null)
            {
                // Scale the recipe by the given factor
                selectedRecipe.ScaleRecipe(factor);
            }
        }

        // Method to reset the quantities of ingredients in a recipe to their original values
        public void ResetQuantities()
        {
            // Check if there are any recipes available
            if (recipes.Count == 0)
            {
                MessageBox.Show("No recipes available.");
                return;
            }

            // Select the first recipe in the list
            Recipe selectedRecipe = recipes.FirstOrDefault();
            if (selectedRecipe != null)
            {
                // Reset the quantities of the ingredients in the recipe
                selectedRecipe.ResetQuantities();
            }
        }
    }
}
