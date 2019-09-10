using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace PieShop
{
    public partial class LoginView : ContentPage
    {
        public LoginView()
        {
            InitializeComponent();
        }

        private async void LoginButton_OnClicked(object sender, EventArgs e)
        {
            Navigation.InsertPageBefore(new MainView(), this);
            await Navigation.PopAsync();
        }
    }
}
