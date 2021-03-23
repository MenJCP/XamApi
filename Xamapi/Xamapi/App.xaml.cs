using System;
using Xamapi.Services;
using Xamapi.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xamapi
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new StatePage());
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
