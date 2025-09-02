namespace ManejoControles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AgregarButton.Click += AgregarButton_Click2;
            AgregarButton.Click += OtroMetodoChafa;
        }



        private void AgregarButton_Click2(object sender, EventArgs e)
        {

            MessageBox.Show("Este es el segundo proceso que se le asigno");
        }

        private void OtroMetodoChafa(object sender, EventArgs e)
        {
            MessageBox.Show("Chafa");
        }

        private void AgregarButton_Click(object sender, EventArgs e)
        {
            bool esVacio = string.IsNullOrEmpty(NombreAlumnoTextBox.Text);

            if (esVacio == true)
            {
                MessageBox.Show("El campo no puede estar vacio");
            }

            else
            {
                var elementos = ListadoAlumnosListBox.Items;
                string nuevoElemento = NombreAlumnoTextBox.Text;
                bool siExiste = false;

                for (int posicion = 0; posicion < elementos.Count; posicion++)
                {
                    string nombre = elementos[posicion].ToString();

                    if (nombre == nuevoElemento)
                    {
                        MessageBox.Show("El alumno ya existe");
                        siExiste = true;
                    }

                }

                if (siExiste == false)
                {
                    ListadoAlumnosListBox.Items.Add(nuevoElemento);
                    NombreAlumnoTextBox.Clear();
                    NombreAlumnoTextBox.Focus();
                }
            }

        }
    }
}
