using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoMaui.Models;
public class Producto
{
    public string Nombre { get; set; } = "";
    public string Descripcion { get; set; } = "";
    public decimal Precio { get; set; }
    // Nombre de una imagen incluida en Resources/Images.
    public string Foto { get; set; } = "";

    public string Detalle { get; set; } = "";
}
