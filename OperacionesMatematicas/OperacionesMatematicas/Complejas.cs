using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operaciones.Complejas
{
    public class Complejas
    {
        public int Potencia(int baseNum, int exponente)
        {
            return (int)Math.Pow(baseNum, exponente);
        }
        public int RaizCuadrada(int numero)
        {
            if (numero < 0)
            {
                throw new ArgumentException("No se puede calcular la raíz cuadrada de un número negativo.");
            }
            return (int)Math.Sqrt(numero);
        }
    }
}
