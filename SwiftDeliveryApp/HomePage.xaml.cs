using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace SwiftDeliveryApp
{
    public partial class HomePage : ContentPage
    {
        private List<Category> _allCategories; // Full list of categories for filtering

        public HomePage()
        {
            InitializeComponent();
            LoadCategories();
        }

        private void LoadCategories()
        {
            // Sample data for categories
            _allCategories = new List<Category>
            {
                new Category
                {
                    Name = "PASTA",
                    Cuisine = "Italian",
                    Rating = "⭐️⭐️⭐️⭐️",
                    Image = "pasta.png"
                },
                new Category
                {
                    Name = "BURGER",
                    Cuisine = "American",
                    Rating = "⭐️⭐️⭐️⭐️⭐️",
                    Image = "burger.png"
                },
                new Category
                {
                    Name = "MEXICAN",
                    Cuisine = "Mexican",
                    Rating = "⭐️⭐️⭐️⭐️",
                    Image = "mexican.png"
                },
                new Category
                {
                    Name = "PIZZA",
                    Cuisine = "Italian",
                    Rating = "⭐️⭐️⭐️⭐️⭐️",
                    Image = "pizza.png"
                },
                new Category
                {
                    Name = "POUTINE",
                    Cuisine = "Canadian",
                    Rating = "⭐️⭐️⭐️⭐️",
                    Image = "poutine.png"
                },
                new Category
                {
                    Name = "DESSERTS",
                    Cuisine = "Variety",
                    Rating = "⭐️⭐️⭐️⭐️⭐️",
                    Image = "desserts.png"
                }
            };

            // Initially bind all categories to the grid
            BindCategories(_allCategories);
        }

        private void BindCategories(List<Category> categories)
        {
            // Clear existing content
            CategoryGrid.Children.Clear();

            // Populate the grid dynamically
            for (int i = 0; i < categories.Count; i++)
            {
                var category = categories[i];

                // Create a stack layout for each category
                var stackLayout = new StackLayout
                {
                    VerticalOptions = LayoutOptions.Center,
                    HorizontalOptions = LayoutOptions.Center
                };

                stackLayout.Children.Add(new Image
                {
                    Source = category.Image,
                    WidthRequest = 80,
                    HeightRequest = 80
                });

                stackLayout.Children.Add(new Label
                {
                    Text = category.Name,
                    FontSize = 14,
                    HorizontalOptions = LayoutOptions.Center,
                    TextColor = Color.Black
                });

                stackLayout.Children.Add(new Label
                {
                    Text = $"Cuisine: {category.Cuisine}",
                    FontSize = 10,
                    HorizontalOptions = LayoutOptions.Center,
                    TextColor = Color.Gray
                });

                stackLayout.Children.Add(new Label
                {
                    Text = $"Rating: {category.Rating}",
                    FontSize = 12,
                    HorizontalOptions = LayoutOptions.Center,
                    TextColor = Color.Orange
                });

                // Add the stack layout to the grid
                CategoryGrid.Children.Add(stackLayout, i % 2, i / 2);
            }
        }

        private void OnSearchBarTextChanged(object sender, TextChangedEventArgs e)
        {
            // Filter the categories based on the search query
            var searchText = e.NewTextValue?.ToLower() ?? string.Empty;

            var filteredCategories = _allCategories
                .Where(c => c.Name.ToLower().Contains(searchText) ||
                            c.Cuisine.ToLower().Contains(searchText))
                .ToList();

            // Update the grid with the filtered categories
            BindCategories(filteredCategories);
        }
    }

    public class Category
    {
        public string Name { get; set; }
        public string Cuisine { get; set; }
        public string Rating { get; set; }
        public string Image { get; set; }
    }
}
