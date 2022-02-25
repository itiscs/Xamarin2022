using SqliteApp.Models;
using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SqliteApp
{
    public partial class App : Application
    {
        public const string DATABASE_NAME = "friends.db";
        internal static FriendRepository database;
        internal static FriendRepository Database
        {
            get
            {
                if (database == null)
                {
                    database = new FriendRepository(
                        Path.Combine(
                            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), DATABASE_NAME));
                }
                return database;
            }
        }
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
