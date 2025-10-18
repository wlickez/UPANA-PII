using Microsoft.Data.SqlClient;

namespace ConexionBaseDatos.Intefaces
{
    public interface IConexion<T>
    {
        void Conectar();
        SqlConnection ObtenerSqlConexion();

        List<T> GetTabla(string query);
    }
}
