using System;
using Xamarin.Forms;

namespace SwiftDeliveryApp
{
    public partial class RegistrationPage : ContentPage
    {
        public RegistrationPage()
        {
            InitializeComponent();
        }

        async void OnRegisterButtonClicked(object sender, EventArgs e)
        {
            // Placeholder for registration logic
            await DisplayAlert("Success", "Registration Complete!", "OK");
            await Navigation.PopAsync(); // Navigate back to the login page
        }
    }
}
