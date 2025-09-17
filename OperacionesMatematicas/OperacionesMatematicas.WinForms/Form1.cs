using Operaciones.Basicas;
using Mensajes;
namespace OperacionesMatematicas.WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Basicas basicas = new Basicas();

            string signo = SignoOperacionTextBox.Text;
            int a = Convert.ToInt32(NumeroATextBox.Text);
            int b = Convert.ToInt32(NumeroBTextBox.Text);


            switch (signo)
            {
                case "+":
                    int suma = basicas.Sumar(a, b);
                    ResultadoTextBox.Text = suma.ToString();
                    break;

                case "-":
                    int diferenicia = basicas.Restar(a, b);
                    ResultadoTextBox.Text = diferenicia.ToString();
                    break;

                case "*":
                    int producto = basicas.Multiplicar(a, b);
                    ResultadoTextBox.Text = producto.ToString();
                    break;

                case "/":
                    double cociente = basicas.Dividir(a, b);
                    ResultadoTextBox.Text = cociente.ToString();
                    break;
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Saludo saludo = new Saludo();
            saludo.Nombre = "";
            MessageBox.Show(saludo.ObtenerSaludo(ResultadoTextBox.Text));
        }
    }
}
