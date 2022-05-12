using GasolinerasSegundoParcial.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace GasolinerasSegundoParcial.Views
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