using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConexionBD.Libreria.Modelos
{
    public class AlumnoNota
    {
        public int CodigoAlumno { get; set; }
        public string NombreMateria { get; set; }
        public double Calificacion { get; set; }
    }
}
