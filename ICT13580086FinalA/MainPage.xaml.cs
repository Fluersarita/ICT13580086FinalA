using System;
using System.Collections.Generic;

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
    }
}
