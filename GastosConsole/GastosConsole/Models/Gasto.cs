using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GastosConsole.Models
{
    public class Gasto
    {
        public int Codigo { get; set; }
        public string Descripcion { get; set; }
        public DateTime Fecha { get; set; }
        public Cuenta Cuenta { get; set; }
        public decimal Monto { get; set; }
        public Usuario Usuario { get; set; }
    }
}
