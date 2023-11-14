using Microsoft.Maui.Controls;
using MauiApp1.Models;
using System;
using System.Collections.ObjectModel;

namespace MauiApp1
{
    public partial class ProductoPage : ContentPage
    {
        public ProductoPage()
        {
            InitializeComponent();
            this.Appearing += OnPageAppearing;
        }

        private void OnPageAppearing(object sender, EventArgs e)
        {
            CargarListaProductos();
        }

        private void CargarListaProductos()
        {
            ObservableCollection<Producto> observableProductos = new ObservableCollection<Producto>(Utils.Utils.ListaProductos);
            listaProductos.ItemsSource = observableProductos;
        }

        private async void OnClickNuevoProductoAsync(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
            await Navigation.PushModalAsync(new NuevoProductoPage());
        }
    }
}
