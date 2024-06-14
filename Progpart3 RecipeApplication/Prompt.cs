using System.Windows;
using System.Windows.Controls;

namespace RecipeApplication.Models
{
    // Static class to display a prompt dialog with a text input field
    public static class Prompt
    {
        // Method to show the dialog and return the user's input
        public static string ShowDialog(string text, string caption)
        {
            // Create a new Window for the prompt
            Window prompt = new Window
            {
                Width = 300, // Set the width of the window
                Height = 150, // Set the height of the window
                Title = caption, // Set the title of the window
                WindowStartupLocation = WindowStartupLocation.CenterScreen // Center the window on the screen
            };

            // Create a StackPanel to arrange the elements vertically
            StackPanel stackPanel = new StackPanel();

            // Create a Label to display the prompt text
            Label textLabel = new Label() { Content = text };

            // Create a TextBox for user input
            TextBox textBox = new TextBox();

            // Create a Button for confirmation
            Button confirmation = new Button() { Content = "OK", Width = 75, Margin = new Thickness(5) };

            // Event handler for the Button's Click event
            confirmation.Click += (sender, e) =>
            {
                prompt.DialogResult = true; // Set the DialogResult to true
                prompt.Close(); // Close the prompt window
            };

            // Add the Label, TextBox, and Button to the StackPanel
            stackPanel.Children.Add(textLabel);
            stackPanel.Children.Add(textBox);
            stackPanel.Children.Add(confirmation);

            // Set the content of the prompt window to the StackPanel
            prompt.Content = stackPanel;

            // Show the prompt window as a dialog
            prompt.ShowDialog();

            // Return the text entered in the TextBox
            return textBox.Text;
        }
    }
}

