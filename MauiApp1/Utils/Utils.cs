using MauiApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Utils
{
    internal class Utils
    {
        static public List<Producto> ListaProductos = new List<Producto>()
        {
            new Producto { IdProducto = 1, Nombre = "Producto1", Descripcion = "Descripción del Producto1", Cantidad = 10 },
            new Producto { IdProducto = 2, Nombre = "Producto2", Descripcion = "Descripción del Producto2", Cantidad = 20 }
        };

    }
}
