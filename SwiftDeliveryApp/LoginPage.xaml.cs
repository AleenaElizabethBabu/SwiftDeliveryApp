using System;
using Xamarin.Forms;

namespace SwiftDeliveryApp
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private async void OnLoginButtonClicked(object sender, EventArgs e)
        {
            // Placeholder login logic
            await DisplayAlert("Login", "Welcome to Swift Delivery!", "OK");

            // Navigate to the HomePage (create this page if not already done)
            await Navigation.PushAsync(new HomePage());
        }
    }
}
