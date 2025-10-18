namespace ConexionBaseDatos.Models
{
    public class Usuario
    {
        public int COD_USUARIO { get; set; }
        public string USUARIO { get; set; }
        public string HASH_PASSWORD { get; set; }
    }
}
