using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace RecipeApplication.Models
{
    public class Recipe
    {
        public string Name { get; set; }
        public List<Ingredient> Ingredients { get; set; }
        public List<Step> Steps { get; set; }

        public Recipe()
        {
            Ingredients = new List<Ingredient>();
            Steps = new List<Step>();
        }

        public void EnterDetails()
        {
            MessageBox.Show("Enter details for the new recipe:");
            Name = Prompt.ShowDialog("Name of the recipe:", "Enter Recipe Name");

            EnterIngredients();
            EnterSteps();
        }

        public void EnterIngredients()
        {
            while (true)
            {
                string ingredientName = Prompt.ShowDialog("Enter ingredient name (or leave empty to finish):", "Enter Ingredient");
                if (string.IsNullOrWhiteSpace(ingredientName))
                {
                    break;
                }

                double quantity = double.Parse(Prompt.ShowDialog($"Enter quantity for {ingredientName}:", "Enter Quantity"));
                string unit = Prompt.ShowDialog($"Enter unit for {ingredientName} (e.g., cups, tablespoons):", "Enter Unit");

                Ingredients.Add(new Ingredient { Name = ingredientName, Quantity = quantity, Unit = unit });
            }
        }

        public void EnterSteps()
        {
            while (true)
            {
                string stepDescription = Prompt.ShowDialog("Enter step description (or leave empty to finish):", "Enter Step");
                if (string.IsNullOrWhiteSpace(stepDescription))
                {
                    break;
                }

                Steps.Add(new Step { Description = stepDescription });
            }
        }

        public string GetRecipeDetails()
        {
            var ingredientDetails = string.Join("\n", Ingredients.Select(i => $"{i.Quantity} {i.Unit} {i.Name}"));
            var stepDetails = string.Join("\n", Steps.Select((s, index) => $"{index + 1}. {s.Description}"));

            return $"{Name}\n\nIngredients:\n{ingredientDetails}\n\nSteps:\n{stepDetails}";
        }

        public void ScaleRecipe(double factor)
        {
            foreach (var ingredient in Ingredients)
            {
                ingredient.Quantity *= factor;
            }
        }

        public void ResetQuantities()
        {
            foreach (var ingredient in Ingredients)
            {
                ingredient.Quantity = 0;
            }
        }
    }
}
