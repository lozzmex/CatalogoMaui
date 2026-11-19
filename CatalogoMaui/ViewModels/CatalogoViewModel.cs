using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatalogoMaui.Models;


namespace CatalogoMaui.ViewModels;
public class CatalogoViewModel
{
    // Cada objeto de esta lista se convertirá en una tarjeta.
    public List<Producto> Productos { get; } = new()
{
new Producto
{
   Nombre = "Minecraft",
            Descripcion = "Juego de construcción y supervivencia.",
            Precio = 499.00m,
            Foto = "minecraft.jpg",
            Detalle = "Minecraft es un videojuego de mundo abierto donde puedes explorar,construir casas etc."
        },

        new Producto
        {
            Nombre = "Grand Theft Auto V",
            Descripcion = "Acción y aventura en mundo abierto.",
            Precio = 599.00m,
            Foto = "gtav.jpg",
            Detalle = "Grand Theft Auto V es un videojuego de acción ambientado en Los Santos. Permite explorar la ciudad, conducir vehículos y completar misiones con tres protagonistas."
        },

        new Producto
        {
            Nombre = "EA Sports FC 25",
            Descripcion = "Simulador de fútbol con equipos reales.",
            Precio = 799.00m,
            Foto = "fc25.jpg",
            Detalle = "EA Sports FC 25 es un simulador de fútbol que permite competir con clubes y selecciones, disputar torneos y disfrutar diferentes modalidades de juego."
        },

        new Producto
        {
            Nombre = "Red Dead Redemption 2",
            Descripcion = "Aventura ambientada en el viejo oeste.",
            Precio = 699.00m,
            Foto = "rdr2.jpg",
            Detalle = "Red Dead Redemption 2 es un videojuego de acción y aventura protagonizado por Arthur Morgan. Explora un mundo abierto con misiones, caballos y una historia ambientada en el viejo oeste."
        }

        /*Para adaptar el catálogo, modifiqué la lista de productos en CatalogoViewModel.cs y agregué cuatro videojuegos con sus imágenes, nombres, descripciones y precios.
        No fue necesario duplicar el código XAML porque CollectionView utiliza DataTemplate para generar automáticamente una tarjeta por cada elemento de la lista.*/
};
}