using BlazorCRUD.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorCRUD.Data.Dapper.Repositorios
{
    public class PeliculaRepository : IPeliculaRepository
    {
        private string ConnectionString;

        public PeliculaRepository(string connectionString)
        {
            ConnectionString = connectionString;
        }

        protected SqlConnection dbConnection()
        {
            return new SqlConnection(ConnectionString);
        }

        public Task<bool> ActualizarPelicula(Pelicula pelicula)
        {
            throw new NotImplementedException();
        }

        public Task<bool> EliminarPelicula(Pelicula pelicula)
        {
            throw new NotImplementedException();
        }

        public Task<Pelicula> getDetallesPeliculas(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Pelicula>> GetPeliculas()
        {
            throw new NotImplementedException();
        }

        public Task<bool> InsertarPelicula(Pelicula pelicula)
        {
            var db = dbConnection();
            var sql = @"INSERT INTO Peliculas (Titulo, Director, FechaLanzamiento)
            VALUES(@Titulo, @Director, @FechaLanzamiento)";
            throw new NotImplementedException();

        }
    }
}
