namespace Gastos.Models
{
    public class Gastos
    {

        public int Id { get; set; }
        public string Descripcion { get; set; }
        public double Monto { get; set; }
        public DateTime Fecha { get; set; }
        public Categoria Categoria { get; set; }


    }
}
