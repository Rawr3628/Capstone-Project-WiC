using Capstone_Project_WiC.Services;
using Capstone_Project_WiC.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Capstone_Project_WiC
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
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
