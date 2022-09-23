using Capstone_Project_WiC.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Capstone_Project_WiC.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}