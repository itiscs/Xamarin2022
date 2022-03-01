using App1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            //lstProducts.ItemsSource = Product.GetProducts();

            NavigationPage.SetHasNavigationBar(this, false);
            
        }

        protected override async void OnAppearing()
        {
            // создание таблицы, если ее нет
            await App.Database.CreateTable();
            // привязка данных
            lstProducts.ItemsSource = await App.Database.GetItemsAsync();

            base.OnAppearing();
        }

        private void lstProducts_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var prod = (Product)e.SelectedItem;
            Navigation.PushAsync(new ItemPage(prod));           
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ItemPage(new Product()));
        }
    }
}
