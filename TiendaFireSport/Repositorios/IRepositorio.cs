using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TiendaFireSport.Entidades;

namespace TiendaFireSport.Repositorios
{
    public interface IRepositorio
    {
        List<Producto> ObtenerProductos();
    }
}
