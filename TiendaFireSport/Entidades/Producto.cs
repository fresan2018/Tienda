using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TiendaFireSport.Entidades
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Categoria { get; set; }
        public string Imagen { get; set; }
        public string Color { get; set; }
        public int Preciold { get; set; }
        public int Precio { get; set; }
    }
}
