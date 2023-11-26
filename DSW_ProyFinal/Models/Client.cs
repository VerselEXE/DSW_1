using System.ComponentModel.DataAnnotations;

namespace DSW_ProyFinal.Models
{
    public class Client
    {
        [Key]
        public int clientId { get; set; }
        public string? nombreClient { get; set; }
        public string? emailClient { get; set; }
        public string? phoneClient { get; set; }

    }
}
