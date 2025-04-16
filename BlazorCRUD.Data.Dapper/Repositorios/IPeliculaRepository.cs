using BlazorCRUD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorCRUD.Data.Dapper.Repositorios
{
    public interface IPeliculaRepository
    {
        Task<IEnumerable<Pelicula>> GetPeliculas();
        Task<Pelicula> getDetallesPeliculas(int id);
        Task<bool> InsertarPelicula(Pelicula pelicula);
        Task<bool> ActualizarPelicula(Pelicula pelicula);
        Task<bool> EliminarPelicula(Pelicula pelicula);


    }
}
