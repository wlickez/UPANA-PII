using ConexionBD.Libreria.Modelos;
using Microsoft.Data.SqlClient;

namespace ConexionBD.Libreria
{
    public class Conexion
    {
        private SqlConnection connection;
        private readonly string connectionString = "Data Source=tcp:epr-sql.database.windows.net;Initial Catalog=erp-bl;Persist Security Info=True;User ID=wlickez;Password=Pascal2020,.-;";

        public Conexion()
        {
            connection = new SqlConnection(connectionString);
            connection.Open();
        }
        public void InsertarEntidad(string query)
        {            
            using (connection)
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
            }
        }

        public List<Alumno> GetAlumnos(string query)
        {
            List<Alumno> alumnos = new List<Alumno>();
            SqlCommand command = new SqlCommand(query, connection);
            var reader = command.ExecuteReader();


            while (reader.Read())
            {
                Alumno alumno = new Alumno();
                alumno.Codigo = Convert.ToInt32(reader[0]);
                alumno.Nombre = Convert.ToString(reader[1]);

                alumnos.Add(alumno);
            }

            return alumnos;
        }
    }
}
