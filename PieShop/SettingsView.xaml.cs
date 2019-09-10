using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace PieShop
{
    public partial class SettingsView : ContentPage
    {
        public SettingsView()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            var languageList = new List<string> { "English", "Dutch", "French", "German", "Spanish" };
            LanguagePicker.ItemsSource = languageList;
        }

        private void LanguagePicker_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedIndex = ((Picker)sender).SelectedIndex;

            if (selectedIndex != 1)
            {
                SelectedLanguageLabel.Text = $"Selected Language: {LanguagePicker.ItemsSource[selectedIndex]}";
            }
        }

        private void PieBudgetSlider_OnValueChanged(object sender, ValueChangedEventArgs e)
        {
            PieBudgetLabel.Text = $"Selected Pie Budget: {e.NewValue:C}";
        }

        private void MaxPieStepper_OnValueChanged(object sender, ValueChangedEventArgs e)
        {
            MaxPieLabel.Text = $"Selected Maximum Pies Per Month: {e.NewValue}";
        }

        private async void SaveSettingsButton_OnClicked(object sender, EventArgs e)
        {
            SavingActivityIndicator.IsRunning = true;
            await Task.Delay(2000);
            SavingActivityIndicator.IsRunning = false;
            await DisplayAlert("Success", "Settings successfully saved", "Done");
        }
    }
}
