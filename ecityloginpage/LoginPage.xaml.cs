using Microsoft.Maui.Controls;

namespace ecityloginpage
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            {
                InitializeComponent(); // Do not change this line
            }

        }

        async void OnLoginButtonClicked(object sender, EventArgs e)
        {
            // Display an alert asynchronously when the login button is clicked
            await DisplayAlert("Login", "Welcome back to eCity!", "OK");
        }
    }
}
