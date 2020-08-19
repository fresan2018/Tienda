using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TiendaFireSport.Entidades;

namespace TiendaFireSport.Repositorios
{
    public class Repositorio : IRepositorio
    {
        public List<Producto> ObtenerProductos()
        {
            return new List<Producto>()
            {
                new Producto() { Id = 1, Nombre = "Dep 152", Categoria = "Diseños", Imagen = "img_1.jpg", Preciold = 70000, Precio = 49900, Color = "Naranja y negro" },
                new Producto() { Id = 2, Nombre = "Dep 153", Categoria = "Ofertas", Imagen = "img_2.jpg", Preciold = 70000, Precio = 49900, Color = "Negro" },
                new Producto() { Id = 3, Nombre = "Dep 154", Categoria = "nuevo", Imagen = "img_3.jpg", Preciold = 70000, Precio = 49900, Color = "Negro y verde" },
                new Producto() { Id = 4, Nombre = "Dep 155", Categoria = "Premium", Imagen = "img_4.jpg", Preciold = 70000, Precio = 49900, Color = "Azul y narnaja" },
                new Producto() { Id = 5, Nombre = "Dep 156", Categoria = "Premium", Imagen = "img_5.jpg", Preciold = 70000, Precio = 49900, Color = "Azul y Gris" },
                new Producto() { Id = 6, Nombre = "Dep 157", Categoria = "Ofertas", Imagen = "img_6.jpg", Preciold = 70000, Precio = 49900, Color = "Rosada y negro" }
            };
        }
    }
}
