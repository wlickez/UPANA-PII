using System.Text;

namespace ManejoArchivos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string texto = textBox1.Text;
                string directorio = Environment.CurrentDirectory + "\\20250823";
                string nombreArchivo = textBox2.Text;

                //validar si el nombre esta vacio
                if (string.IsNullOrEmpty(nombreArchivo))
                    throw new Exception("El nombre del archivo no debe ser vacio");

                nombreArchivo += ".txt";

                //el contenido no sea vacio o nulo
                if (string.IsNullOrEmpty(texto))
                    throw new Exception("El contenido no puede ser vacio o nulo");

                //validar el path exista directorio 
                if (!Directory.Exists(directorio))
                    Directory.CreateDirectory(directorio);

                //duplique
                if (File.Exists(Path.Combine(directorio, nombreArchivo)))
                    throw new Exception("El archivo ya existe");

                using (FileStream fs = new(Path.Combine(directorio, nombreArchivo), FileMode.CreateNew))
                {
                    byte[] contenEncode = Encoding.UTF8.GetBytes(texto);
                    await fs.WriteAsync(contenEncode, 0, contenEncode.Length);
                    MessageBox.Show("El archivo fue creado correctamente");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string directorio = Environment.CurrentDirectory + "\\20250823";
                string nombreArchivo = textBox2.Text;

                //validar si el nombre esta vacio
                if (string.IsNullOrEmpty(nombreArchivo))
                    throw new Exception("El nombre del archivo no debe ser vacio");

                nombreArchivo += ".txt";

                using (FileStream fs = new FileStream(nombreArchivo, FileMode.Open))
                {
                    using (StreamReader sr = new(fs))
                    {
                        textBox1.Text = sr.ReadToEnd();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
