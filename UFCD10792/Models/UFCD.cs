using System.ComponentModel.DataAnnotations;

namespace UFCD10792.Models
{
    public class UFCD
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string? code { get; set; }
        public string? name { get; set; }
        public int hours { get; set; }
        public DateTime beginingDate { get; set; } = DateTime.Now;
    }


}
