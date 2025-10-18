using GastosConsole.Models;

namespace GastosConsole
{
    internal class Program
    {
        //inicializacion de las listas para emular una base de datos
        static List<Cuenta> cuentas = new List<Cuenta>();
        static List<CuentaClasificacion> clasificaciones = new List<CuentaClasificacion>();
        static List<Gasto> gastos = new List<Gasto>();
        static List<GastoClasificacion> gastoClasificaciones = new List<GastoClasificacion>();
        static List<Usuario> usuariosLista = new List<Usuario>();
        static void Main(string[] args)
        {

            string opcion = string.Empty;

            do
            {
                Console.WriteLine("Seleccione una opción:");
                Console.WriteLine("1. Agregar Cuenta");
                Console.WriteLine("2. Agregar Clasificación de Cuenta");
                Console.WriteLine("3. Agregar Gasto");
                Console.WriteLine("4. Agregar Clasificación de Gasto");
                Console.WriteLine("5. Agregar Usuario");

                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        AgregarCuenta();
                        ListarCuentas();
                        break;
                    case "2":
                        // Lógica para agregar una clasificación de cuenta
                        AgregarCuentaClasificacion();
                        break;
                    case "3":
                        // Lógica para agregar un gasto
                        Console.WriteLine("Agregar Gasto");

                        break;
                    case "4":
                        // Lógica para agregar una clasificación de gasto
                        Console.WriteLine("Agregar Clasificación de Gasto");

                        break;
                    case "5":
                        AgregarUsuario();
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Intente de nuevo.");
                        break;
                }
            }
            while (opcion != "n");
        }

        private static void ListarCuentas()
        {
            foreach (var cuenta in cuentas)
            {
                Console.WriteLine($"Cuenta {cuenta.NumeroCuenta} Nombre {cuenta.Nombre} Clasificacion: {cuenta.Clasificacion.Codigo} Saldo {cuenta.Saldo}");
            }
        }

        private static void AgregarCuenta()
        {
            Cuenta cuentaNueva = new Cuenta();

            Console.WriteLine("Ingrese el numero de cuenta");
            cuentaNueva.NumeroCuenta = Convert.ToInt32(Console.ReadLine()); 

            Console.WriteLine("Ingrese el nombre de la cuenta");  
            cuentaNueva.Nombre = Console.ReadLine();

            Console.WriteLine("Ingrese el saldo inicial");
            cuentaNueva.Saldo = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Ingrese la clasificacion de la cuenta");
            cuentaNueva.Clasificacion = new CuentaClasificacion()
            {
                Codigo = Convert.ToInt32(Console.ReadLine())
            };

            cuentas.Add(cuentaNueva);

            Console.WriteLine("Cuenta agregada exitosamente.");

        }

        private static void AgregarCuentaClasificacion()
        {
            Console.WriteLine("Ingrese el codigo de la clasificación");
            int codigo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el nombre de la clasificación");
            string nombre = Console.ReadLine(); 

            CuentaClasificacion cuentaClasificacion = new CuentaClasificacion();
            cuentaClasificacion.Codigo = codigo;
            cuentaClasificacion.Nombre = nombre;

            clasificaciones.Add(cuentaClasificacion);

            Console.WriteLine("Clasificación de cuenta agregada exitosamente.");

        }

        private static void AgregarUsuario()
        {
            Console.WriteLine("Ingrese el código");
            int codigo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el nombre");
            string nombre = Console.ReadLine();

            //constructor defaul
            Usuario usuarioNuevo = new Usuario();
            usuarioNuevo.Codigo = codigo;
            usuarioNuevo.Nombre = nombre;                       
            
            usuariosLista.Add(usuarioNuevo);

            Console.WriteLine("Usuario agregado exitosamente.");
        }
    }
}
