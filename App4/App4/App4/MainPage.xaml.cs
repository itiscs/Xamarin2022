using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App4
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);
           
            TapGestureRecognizer tp = new TapGestureRecognizer();
            tp.Tapped += Tp_Tapped;
            lblTitle.GestureRecognizers.Add(tp);

        }

        private void Tp_Tapped(object sender, EventArgs e)
        {
            lblHello.Text = $"Hello {txtName.Text}";
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            //lblHello.Text = $"Hello {txtName.Text}"; 
            Random r = new Random();
            BoxView box = new BoxView()
            {
                HeightRequest = 100,
                WidthRequest = 300,
                Color = Color.FromRgb(r.Next(255), r.Next(255), r.Next(255))
            };
            stk1.Children.Add(box);

        }

        private void btnSecond_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SecondPage());
            
        }
    }
}
