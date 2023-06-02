using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using pdc03_module07.Services;
using pdc03_module07.View;

namespace pdc03_module07
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new View.ShowEmployeePage());
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
