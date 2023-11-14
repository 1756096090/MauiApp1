
using CommunityToolkit.Maui.Core;
using MauiApp1.Models;

namespace MauiApp1;

public partial class NuevoProductoPage : ContentPage
{
	public NuevoProductoPage()
	{
        InitializeComponent();
	}

	private async void OnClickGuardarProducto(object sender, EventArgs e)
	{
		int id = Utils.Utils.ListaProductos.Count + 1;
		Utils.Utils.ListaProductos.Add(new Models.Producto
		{
			IdProducto = id,
			Nombre = Nombre.Text,
			Descripcion = Descripcion.Text,
			Cantidad = Int32.Parse(Cantidad.Text),


		}) ;
        await Navigation.PopAsync();
        await Navigation.PushModalAsync(new ProductoPage());

    }
}