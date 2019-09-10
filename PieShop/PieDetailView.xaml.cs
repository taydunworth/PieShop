using System;
using System.Collections.Generic;
using PieShop.Model;
using Xamarin.Forms;

namespace PieShop
{
    public partial class PieDetailView : ContentPage
    {
        public PieDetailView(Pie p)
        {
            InitializeComponent();

            BindData(p);
        }

        private void BindData(Pie pie)
        {
            PieNameLabel.Text = pie.PieName;
            PieImage.Source = pie.ImageUrl;
            DescriptionLabel.Text = pie.Description;
            PriceLabel.Text = pie.Price.ToString("c");
            InStockLabel.Text = pie.InStock ? "In stock" : "Not in stock";
        }

        private void AddToBasketButton_OnClicked(object sender, EventArgs e)
        {
            DisplayAlert("Success", "Added to your basket!", "Done");
        }
    }
}
