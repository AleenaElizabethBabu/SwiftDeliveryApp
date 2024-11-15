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

        async void OnLoginButtonClicked(object sender, EventArgs e)
        {
            // For now, navigate to HomePage directly without authentication.
            await Navigation.PushAsync(new HomePage());
        }

        async void OnRegisterButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RegistrationPage());
        }
    }
}
