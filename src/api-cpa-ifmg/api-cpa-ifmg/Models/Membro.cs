using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cpa_ifmg.Models
{
    [Table("Membros")]
    public class Membro
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Portaria { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Representação { get; set; }
        [Required]

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{dd-MM-yyyy}")]
        public DateTime DataInicio { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{dd-MM-yyyy}")]
        public DateTime DataTermino { get; set; }

    }
    public enum Funcao
    {
        Membro,
        Presidente,
        VicePresidente

    }
}
