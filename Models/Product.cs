namespace ProductInventoryAPI.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }
        public string Imagen { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
