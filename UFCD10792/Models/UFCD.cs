using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace UFCD10792.Models
{
    public class UFCD
    {
        [Key]
        public int id { get; set; }
        [Required]
        [DisplayName("Código")]
        public string? code { get; set; }
        [DisplayName("Nome da Unidade")]
        public string? name { get; set; }
        [DisplayName("Carga Horária")]
        [Range(25,50,ErrorMessage ="Valores válidos entre 25 e 50")]

        public int hours { get; set; }       
        [DisplayName("Data de Inicio")]
        public DateTime beginingDate { get; set; } = DateTime.UtcNow;
       

    }


}
