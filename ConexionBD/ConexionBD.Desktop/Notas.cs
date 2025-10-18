using ConexionBD.Libreria;
namespace ConexionBD.Desktop
{
    public partial class Notas : Form
    {
        public Notas()
        {
            InitializeComponent();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            string queryAlumnoNota = $"INSERT INTO ALUMNO_NOTA (CodigoAlumno, NombreMateria, Calificacion) VALUES ({CodigoAlumnoTextBox.Text}, '{NombreMateriaTextBox.Text}', {CalificacionTextBox.Text})";

            Conexion conexion = new Conexion();
            conexion.InsertarEntidad(queryAlumnoNota);
        }
    }
}
