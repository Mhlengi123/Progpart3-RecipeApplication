// Create a new Menu.cs file
using System.Collections.Generic;

namespace RecipeApplication.Models
{
    public class Menu
    {
        public List<Recipe> SelectedRecipes { get; private set; }

        public Menu()
        {
            SelectedRecipes = new List<Recipe>();
        }

        public void AddRecipe(Recipe recipe)
        {
            SelectedRecipes.Add(recipe);
        }

        public void RemoveRecipe(Recipe recipe)
        {
            SelectedRecipes.Remove(recipe);
        }

        public void ClearMenu()
        {
            SelectedRecipes.Clear();
        }
    }
}

