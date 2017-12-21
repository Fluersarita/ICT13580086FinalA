using System;
using System.Collections.Generic;
using ICT13580086FinalA.Models;
using Xamarin.Forms;

namespace ICT13580086FinalA
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            newButton.Clicked += NewButton_Clicked;


        }

        protected override void OnAppearing()
        {
            LoadData();
        }

        void LoadData()
        {
            productListview.ItemsSource = App.DbHelper.GetProducts();
        }

        void NewButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new ProductNewPage());
        }

        void Edite_Clicked(object sender, System.EventArgs e)
        {
            var button = sender as MenuItem;
            var product = button.CommandParameter as Product;
            Navigation.PushModalAsync(new ProductNewPage(product));
        }

        void Delete_Clicked(object sender, System.EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
