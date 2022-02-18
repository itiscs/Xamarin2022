using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App4
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SecondPage : ContentPage
    {
        public SecondPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);

            var lst = Product.GetProducts();
            lstProducts.ItemsSource = lst;
        }

        private void lstProducts_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Navigation.PushAsync(new ItemPage((Product)e.SelectedItem));

        }
    }
}