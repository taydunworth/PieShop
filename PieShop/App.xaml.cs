using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PieShop
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new RegisterView();
            //MainPage = new LoginView();
            //MainPage = new ContactView();
            MainPage = new SettingsView();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
