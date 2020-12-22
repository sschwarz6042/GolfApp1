using GolfApp1.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GolfApp1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new NavigationPage(new SplashScreenPage());
            MainPage = new NavigationPage(new NewRoundPage(0));
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
