
using CatalogoMaui.Views;

namespace CatalogoMaui;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        Routing.RegisterRoute("producto-detalle", typeof(ProductoDetallePage));
    }
}
