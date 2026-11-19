
using System.Collections.Generic;
using CatalogoMaui.Models;

namespace CatalogoMaui.Views;

public partial class ProductoDetallePage : ContentPage, IQueryAttributable
{
    public ProductoDetallePage()
    {
        InitializeComponent();
    }

    public void ApplyQueryAttributes(IDictionary<string, object> query)
    {
        if (query.TryGetValue("producto", out var valor)
            && valor is Producto producto)
        {
            // Los enlaces de esta página leen el producto recibido.
            BindingContext = producto;
        }
    }
}
