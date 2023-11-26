using System.ComponentModel.DataAnnotations;

namespace DSW_ProyFinal.Models
{
    public class Product
    {
        [Key]
        public int prodId { get; set; }
        public string nombreProd { get; set; }
        public double precioProd { get; set; }
        public string descProd { get; set; }
        public string catProd { get; set; }
        public string urlProd { get; set; }
    }
}
