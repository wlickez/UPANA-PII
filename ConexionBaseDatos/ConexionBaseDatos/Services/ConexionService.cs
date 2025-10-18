using Microsoft.Data.SqlClient;
using ConexionBaseDatos.Intefaces;
using Dapper;
using ConexionBaseDatos.Models;

namespace ConexionBaseDatos.Services
{
    public class ConexionService<T> : IConexion<T>
    {
        private SqlConnection _conexion;
        public void Conectar()
        {
            string cadenaConexion = "Server=tcp:sql-server-residencial.database.windows.net,1433;Initial Catalog =sql-database-residencial; Persist Security Info= False; User ID=USRRESIDENTE; Password = residente*2025;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

            _conexion = new SqlConnection(cadenaConexion);
            _conexion.Open();
        }

        public List<Usuario> GetTabla(string query)
        {
            return _conexion.Query<Usuario>(query).ToList();  
        }

        public SqlConnection ObtenerSqlConexion()
        {
            return _conexion;
        }

        List<T> IConexion<T>.GetTabla(string query)
        {
            return _conexion.Query<T>(query).ToList();
        }
    }
}
