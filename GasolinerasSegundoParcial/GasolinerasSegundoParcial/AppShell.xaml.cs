using GasolinerasSegundoParcial.ViewModels;
using GasolinerasSegundoParcial.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace GasolinerasSegundoParcial
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }

        //Comentario de prueba para subir a git
    }
}
