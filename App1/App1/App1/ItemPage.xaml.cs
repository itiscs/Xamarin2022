using App1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ItemPage : ContentPage
    {
        public ItemPage()
        {
            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);

        }

        public ItemPage(Product prod)
        {
            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);

            BindingContext = prod;

        }


        private async void Save_Clicked(object sender, EventArgs e)
        {
            var prod = (Product)BindingContext;
            if (!String.IsNullOrEmpty(prod.Name))
            {
                await App.Database.SaveItemAsync(prod);
            }
            await Navigation.PopAsync();

        }

        private async void Delete_Clicked(object sender, EventArgs e)
        {
            var prod = (Product)BindingContext;
            await App.Database.DeleteItemAsync(prod);
            await Navigation.PopAsync();
        }

        private async void Cancel_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}