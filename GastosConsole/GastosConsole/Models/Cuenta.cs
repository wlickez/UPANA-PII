﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GastosConsole.Models
{
    public class Cuenta
    {
        public int NumeroCuenta { get; set; }
        public string Nombre { get; set; }
        public decimal Saldo { get; set; }
        public CuentaClasificacion Clasificacion { get; set; }
    }
}
