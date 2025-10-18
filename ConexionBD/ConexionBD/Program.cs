using Microsoft.Data.SqlClient;

namespace ConexionBD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Data Source=tcp:epr-sql.database.windows.net;Initial Catalog=erp-bl;Persist Security Info=True;User ID=wlickez;Password=Pascal2020,.-;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    Console.WriteLine("Conexión exitosa!");
                    // Aquí puedes ejecutar comandos o consultas a la base de datos
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al conectar: " + ex.Message);
                }

                string salir = "s";

                while (salir == "s")
                {
                    Console.WriteLine("Selecciona una operación");
                    Console.WriteLine("1. Crear");
                    Console.WriteLine("2. Leer");
                    Console.WriteLine("3. Actualizar");
                    Console.WriteLine("4. Eliminar");

                    string opcion = Console.ReadLine();

                    switch (opcion)
                    {
                        case "1":
                            Crear(connection);
                            break;
                        case "2":
                            Leer(connection);
                            break;
                        default:
                            break;
                    }

                    Console.Write("Desea realizar otra operacion (s=si  n=no)");

                    salir = Console.ReadLine(); 
                }
            }
        }

        private static void Leer(SqlConnection connection)
        {
            string selectQuery = "SELECT * FROM [ALUMNO]";
            SqlCommand comandoSelecciona = new SqlCommand(selectQuery, connection);
            SqlDataReader reader = comandoSelecciona.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine($"Código: {reader[0]} Nombre: {reader[1].ToString()}");
            }

            reader.Close();

        }

        private static void Crear(SqlConnection connection)
        {
            int codigo;
            string nombre;

            try
            {
                Console.WriteLine("Ingrese el codigo del alumno:");
                codigo = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ingrese el nombre del alumno:");
                nombre = Console.ReadLine();

                string insertQuery = $"INSERT INTO [ALUMNO] (Codigo, Nombre) VALUES({codigo}, '{nombre}')";

                SqlCommand comandoInsertar = new SqlCommand(insertQuery, connection);
                comandoInsertar.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al insertar: " + ex.Message);
            }

        }
    }
}
