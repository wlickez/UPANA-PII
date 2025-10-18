using Microsoft.Data.Sqlite;

namespace Gastos
{
    public partial class Form1 : Form
    {
        string connectionString = "Data Source=estudiantes.db;";
        public Form1()
        {
            InitializeComponent();
            CrearBaseDeDatos();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void CrearBaseDeDatos()
        {
            using (var conn = new SqliteConnection(connectionString))
            {
                conn.Open();
                string query = "CREATE TABLE IF NOT EXISTS Estudiantes (Id INTEGER PRIMARY KEY AUTOINCREMENT, Nombre TEXT, Nota1 REAL, Nota2 REAL, Nota3 REAL, Promedio REAL, Estado TEXT)";
                SqliteCommand SqliteCommand = new SqliteCommand(query, conn);
                SqliteCommand.ExecuteNonQuery();
            }
        }
    }
}
