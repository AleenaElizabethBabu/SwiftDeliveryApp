using System;
using Xamarin.Forms;

namespace SwiftDeliveryApp
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private async void OnCategoryTapped(object sender, EventArgs e)
        {
            var tappedEventArgs = (TappedEventArgs)e;
            string selectedCategory = tappedEventArgs.Parameter.ToString();

            // Navigate to the RestaurantListPage
            await Navigation.PushAsync(new RestaurantListPage(selectedCategory));
        }
    }
}
