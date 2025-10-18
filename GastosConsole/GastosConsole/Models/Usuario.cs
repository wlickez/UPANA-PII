using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GastosConsole.Models
{
    public class Usuario
    {
        public Usuario()
        {

        }
        public Usuario(string nombre)
        {
            Nombre = nombre;
        }

        public Usuario(int codigo, string nombre)
        {
            Codigo = codigo;
            Nombre = nombre;
        }



        public int Codigo { get; set; }
        public string Nombre { get; set; }
    }
}
