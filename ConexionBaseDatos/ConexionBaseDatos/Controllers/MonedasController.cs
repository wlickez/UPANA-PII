using ConexionBaseDatos.Intefaces;
using ConexionBaseDatos.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ConexionBaseDatos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MonedasController : ControllerBase
    {
        private readonly IConexion<Moneda> _conexion;
        public MonedasController(IConexion<Moneda> conexion)
        {
            _conexion = conexion;
        }

        [HttpGet]
        public IActionResult Get()
        {
            _conexion.Conectar();
            var con = _conexion.ObtenerSqlConexion();

            string query = "SELECT COD_MONEDA, DESCRIPCION FROM [RESIDENTE].[M_MONEDA]";

            List<Moneda> monedas = _conexion.GetTabla(query);

            return Ok(monedas);

        }
    }
}
