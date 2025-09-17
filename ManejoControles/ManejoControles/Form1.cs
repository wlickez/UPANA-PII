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

        private async void AgregarButton_Click_1(object sender, EventArgs e)
        {
            int final = 100;

            timer1.Start();
            timer1.Interval = 5000;
            timer1.Tick += Timer1_Tick;

            AgregarButton.Enabled = false;

            for (int i = 0; i <= final; i++)
            {
                progressBar1.Value = i;
                progressBar1.Refresh();
                await Task.Delay(500);
            }

            AgregarButton.Enabled = true;            

            timer1.Stop();
        }

        private void Timer1_Tick(object? sender, EventArgs e)
        {
            ListadoAlumnosListBox.Items.Add("Agregado por el control Timer: " + DateTime.Now.ToString());            
        }
    }
}
