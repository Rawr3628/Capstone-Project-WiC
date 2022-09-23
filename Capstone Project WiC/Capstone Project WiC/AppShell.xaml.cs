using Capstone_Project_WiC.ViewModels;
using Capstone_Project_WiC.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Capstone_Project_WiC
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
