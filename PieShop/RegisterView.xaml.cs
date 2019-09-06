using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace PieShop
{
    public partial class RegisterView : ContentPage
    {
        public RegisterView()
        {
            InitializeComponent();
            RegisterButton.IsEnabled = false;
        }


        private async void RegisterButton_OnClicked(object sender, EventArgs e)
        {
            await DisplayAlert("Success", "Your account has been created", "Done");
        }

        private void UsernameEntry_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            RegisterButton.IsEnabled = ValidateRegistration();
        }

        private void PasswordEntry_OnTextChanged(object sender, TextChangedEventArgs e)
        {

            RegisterButton.IsEnabled = ValidateRegistration();
        }

        private bool ValidateRegistration()
        {
            if (UsernameEntry.Text?.Length > 0 && PasswordEntry.Text?.Length > 0)
                return true;
                return false;
        }
    }
}
