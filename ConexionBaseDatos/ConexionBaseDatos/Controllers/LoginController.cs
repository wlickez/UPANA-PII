using ConexionBaseDatos.Intefaces;
using ConexionBaseDatos.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System.Data;
using Dapper;

namespace ConexionBaseDatos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private IConexion<Usuario> _conexion;

        
        public LoginController(IConexion<Usuario> conexion)
        {
            _conexion  = conexion;
            _conexion.Conectar();
        }

        [HttpGet]
        public IActionResult Get()
        {
            List<Usuario> usuarios = new List<Usuario>();

            string query = "SELECT COD_USUARIO, USUARIO, HASH_PASSWORD  FROM [RESIDENTE].[M_USUARIO]";

            var con = _conexion.ObtenerSqlConexion();
            SqlCommand comando = new SqlCommand(query, con);


            ////usando reader
            //SqlDataReader reader = comando.ExecuteReader();

            //while (reader.Read())
            //{
            //    var codigo = reader.GetInt32(0);
            //    var nombre = reader.GetString(1);
            //    var password = reader.GetString(2);
            //    Usuario usuario = new Usuario();
            //    usuario.COD_USUARIO = codigo;
            //    usuario.USUARIO = nombre;
            //    usuario.HASH_PASSWORD = password;

            //    usuarios.Add(usuario);
            //}

            //reader.Close();

            //sqladaptar y DataTable
            SqlDataAdapter adapter = new SqlDataAdapter(comando);
            DataTable dt = new DataTable();

            adapter.Fill(dt);

            foreach (DataRow fila in dt.Rows)
            {
                var codigo = (int)fila["COD_USUARIO"];
                var nombre = (string)fila[1];
                var password = (string)fila[2];
                Usuario usuario = new Usuario();
                usuario.COD_USUARIO = codigo;
                usuario.USUARIO = nombre;
                usuario.HASH_PASSWORD = password;

                usuarios.Add(usuario);
            }

            usuarios = _conexion.GetTabla(query);

            return Ok(usuarios);
        }
    }
}
