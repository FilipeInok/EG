using System.ComponentModel.DataAnnotations;

namespace Vinhos.Models
{
    public class Regioes
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string name { get; set; }
        public string? description { get; set; }

    }
}
