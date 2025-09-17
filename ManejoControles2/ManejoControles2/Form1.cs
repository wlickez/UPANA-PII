using System.ComponentModel.DataAnnotations;

namespace ManejoControles2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ValidarButton_Click(object sender, EventArgs e)
        {
            if (ValidacionCheckBox.Checked == true)
            {
                MessageBox.Show("El checkbox está seleccionado");
            }
            else
            {
                MessageBox.Show("El checkbox NO está seleccionado");
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ValidacionCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ValidacionCheckBox.Checked == true)
            {
                this.Text = "Checkbox seleccionado";
            }
            else
            {
                this.Text = "Checkbox NO seleccionado";
            }
        }

        private void AgregarButton_Click(object sender, EventArgs e)
        {
            string alumno = AlumnoTextBox.Text;

            AlumnosComboBox.Items.Add(alumno);
        }

        private void AlumnosComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string alumnoSeleccionado = AlumnosComboBox.SelectedItem.ToString();
            MessageBox.Show(alumnoSeleccionado);
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            if(AlumnosComboBox.SelectedItem != null)
            {
                AlumnosComboBox.Items.Remove(AlumnosComboBox.SelectedItem);
            }
        }
    }
}
