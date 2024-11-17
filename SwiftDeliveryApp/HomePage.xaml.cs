using System.Collections.Generic;
using Xamarin.Forms;

namespace SwiftDeliveryApp
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
            LoadRestaurants();
        }

        private void LoadRestaurants()
        {
            // Sample data for restaurants
            var restaurants = new List<Restaurant>
            {
                new Restaurant
                {
                    Name = "Pasta Palace",
                    Cuisine = "Italian",
                    Rating = "⭐️⭐️⭐️⭐️",
                    Image = "pasta_palace.png" // Place this image in the Resources/Drawable folder
                },
                new Restaurant
                {
                    Name = "Sushi Spot",
                    Cuisine = "Japanese",
                    Rating = "⭐️⭐️⭐️⭐️⭐️",
                    Image = "sushi_spot.png" // Place this image in the Resources/Drawable folder
                },
                new Restaurant
                {
                    Name = "Curry Corner",
                    Cuisine = "Indian",
                    Rating = "⭐️⭐️⭐️⭐️",
                    Image = "curry_corner.png" // Place this image in the Resources/Drawable folder
                }
            };

            // Bind the data to the CollectionView
            RestaurantCollectionView.ItemsSource = restaurants;
        }
    }
}
