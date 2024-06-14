using System.Linq;
using System.Windows;
using System.Windows.Controls;
using RecipeApplication.Models;

namespace RecipeApplication
{
    public partial class MainWindow : Window
    {
        // Instance of RecipeManager to handle recipe operations
        private RecipeManager _recipeManager;

        public MainWindow()
        {
            InitializeComponent();
            // Initialize RecipeManager and load initial recipes
            _recipeManager = new RecipeManager();
            LoadRecipes();
        }

        // Load initial recipes into the ListBox
        private void LoadRecipes()
        {
            _recipeManager.LoadInitialRecipes();
            RecipeListBox.ItemsSource = _recipeManager.recipes.Select(r => r.Name).ToList();
        }

        // Event handler for "Add Recipe" button click
        private void AddRecipeButton_Click(object sender, RoutedEventArgs args)
        {
            _recipeManager.AddRecipe();
            RecipeListBox.ItemsSource = _recipeManager.recipes.Select(r => r.Name).ToList();
        }

        // Event handler for "Display All Recipes" button click
        private void DisplayAllRecipesButton_Click(object sender, RoutedEventArgs args)
        {
            _recipeManager.DisplayAllRecipes();
            RecipeListBox.ItemsSource = _recipeManager.recipes.Select(r => r.Name).ToList();
        }

        // Event handler for "Scale Recipe" button click
        private void ScaleRecipeButton_Click(object sender, RoutedEventArgs args)
        {
            if (RecipeListBox.SelectedItem != null)
            {
                // Find the selected recipe
                Recipe selectedRecipe = _recipeManager.recipes.FirstOrDefault(r => r.Name == RecipeListBox.SelectedItem.ToString());
                if (selectedRecipe != null)
                {
                    double factor;
                    // Parse the scale factor and scale the recipe
                    if (double.TryParse(ScaleFactorTextBox.Text, out factor))
                    {
                        selectedRecipe.ScaleRecipe(factor);
                        RecipeDetailsTextBox.Text = selectedRecipe.GetRecipeDetails();
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid scaling factor.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a recipe to scale.");
            }
        }

        // Event handler for "Reset Quantities" button click
        private void ResetQuantitiesButton_Click(object sender, RoutedEventArgs args)
        {
            if (RecipeListBox.SelectedItem != null)
            {
                // Find the selected recipe and reset its quantities
                Recipe selectedRecipe = _recipeManager.recipes.FirstOrDefault(r => r.Name == RecipeListBox.SelectedItem.ToString());
                if (selectedRecipe != null)
                {
                    selectedRecipe.ResetQuantities();
                    RecipeDetailsTextBox.Text = selectedRecipe.GetRecipeDetails();
                }
            }
            else
            {
                MessageBox.Show("Please select a recipe to reset quantities.");
            }
        }

        // Event handler for "Exit" button click
        private void ExitButton_Click(object sender, RoutedEventArgs args)
        {
            // Shut down the application
            Application.Current.Shutdown();
        }

        // Event handler for "Enter Ingredients" button click
        private void EnterIngredientsButton_Click(object sender, RoutedEventArgs args)
        {
            if (RecipeListBox.SelectedItem != null)
            {
                // Find the selected recipe and enter its ingredients
                Recipe selectedRecipe = _recipeManager.recipes.FirstOrDefault(r => r.Name == RecipeListBox.SelectedItem.ToString());
                if (selectedRecipe != null)
                {
                    selectedRecipe.EnterIngredients();
                }
            }
            else
            {
                MessageBox.Show("Please select a recipe to enter ingredients.");
            }
        }

        // Event handler for "Enter Steps" button click
        private void EnterStepsButton_Click(object sender, RoutedEventArgs args)
        {
            if (RecipeListBox.SelectedItem != null)
            {
                // Find the selected recipe and enter its steps
                Recipe selectedRecipe = _recipeManager.recipes.FirstOrDefault(r => r.Name == RecipeListBox.SelectedItem.ToString());
                if (selectedRecipe != null)
                {
                    selectedRecipe.EnterSteps();
                }
            }
            else
            {
                MessageBox.Show("Please select a recipe to enter steps.");
            }
        }

        // Event handler for selection change in the recipe list
        private void RecipeListBox_SelectionChanged(object sender, SelectionChangedEventArgs args)
        {
            if (RecipeListBox.SelectedItem != null)
            {
                // Find the selected recipe and display its details
                Recipe selectedRecipe = _recipeManager.recipes.FirstOrDefault(r => r.Name == RecipeListBox.SelectedItem.ToString());
                if (selectedRecipe != null)
                {
                    RecipeDetailsTextBox.Text = selectedRecipe.GetRecipeDetails();
                }
            }
        }
    }
}
