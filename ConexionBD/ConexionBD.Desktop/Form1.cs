using ConexionBD.Libreria;
using ConexionBD.Libreria.Modelos;
namespace ConexionBD.Desktop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            string q = $"INSERT INTO ALUMNO (Codigo, Nombre) VALUES ({CodigoTextBox.Text}, '{NombreTextBox.Text}')";

            Conexion conexion = new Conexion();
            conexion.InsertarEntidad(q);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conexion conexionConsulta = new Conexion();

            string consulta = "SELECT Codigo, Nombre FROM ALUMNO ";
            List<Alumno> alumnos = conexionConsulta.GetAlumnos(consulta);

            dataGridView1.DataSource = alumnos;
        }
    }
}
