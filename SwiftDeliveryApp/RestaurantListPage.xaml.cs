using System.Collections.Generic;
using Xamarin.Forms;

namespace SwiftDeliveryApp
{
    public partial class RestaurantListPage : ContentPage
    {
        public RestaurantListPage(string category)
        {
            InitializeComponent();

            // Set the category title
            CategoryTitle.Text = $"{category} Restaurants";

            // Load restaurants for the selected category
            LoadRestaurants(category);
        }

        private void LoadRestaurants(string category)
        {
            var restaurants = new List<Restaurant>
            {
                new Restaurant { Name = "Pasta Palace", Cuisine = "Italian", Rating = "⭐️⭐️⭐️⭐️", Image = "pasta.png", Category = "PASTA" },
                new Restaurant { Name = "Noodle Nirvana", Cuisine = "Italian", Rating = "⭐️⭐️⭐️⭐️⭐️", Image = "pasta.png", Category = "PASTA" },
                new Restaurant { Name = "Burger Barn", Cuisine = "American", Rating = "⭐️⭐️⭐️⭐️", Image = "burger.png", Category = "BURGER" },
                new Restaurant { Name = "Cheesy Bites", Cuisine = "American", Rating = "⭐️⭐️⭐️⭐️⭐️", Image = "burger.png", Category = "BURGER" },
                new Restaurant { Name = "Taco Time", Cuisine = "Mexican", Rating = "⭐️⭐️⭐️⭐️", Image = "mexican.png", Category = "MEXICAN" },
                new Restaurant { Name = "Fiesta Feast", Cuisine = "Mexican", Rating = "⭐️⭐️⭐️⭐️⭐️", Image = "mexican.png", Category = "MEXICAN" },
                new Restaurant { Name = "Pizza Paradise", Cuisine = "Italian", Rating = "⭐️⭐️⭐️⭐️", Image = "pizza.png", Category = "PIZZA" },
                new Restaurant { Name = "Slice & Dice", Cuisine = "Italian", Rating = "⭐️⭐️⭐️⭐️⭐️", Image = "pizza.png", Category = "PIZZA" }
            };

            // Filter and bind restaurants
            var filteredRestaurants = restaurants.FindAll(r => r.Category == category);
            RestaurantCollectionView.ItemsSource = filteredRestaurants;
        }
    }

    public class Restaurant
    {
        public string Name { get; set; }
        public string Cuisine { get; set; }
        public string Rating { get; set; }
        public string Image { get; set; }
        public string Category { get; set; }
    }
}
