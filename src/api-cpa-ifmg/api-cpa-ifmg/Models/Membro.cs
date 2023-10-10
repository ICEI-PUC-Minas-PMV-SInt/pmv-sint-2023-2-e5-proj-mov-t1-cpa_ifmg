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
        public Funcao Funcao { get; set; }
        [Required]

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{dd-MM-yyyy}")]
        public DateTime Data_Inicio { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{dd-MM-yyyy}")]
        public DateTime Data_Termino { get; set; }
        public int PropostaId { get; set; }
        public Proposta Proposta { get; set; }

    }
    public enum Funcao
    {
        [Display(Name = "Membro")]
        Membro,
        [Display(Name = "Presidente")]
        Presidente,
        [Display(Name = "Vice Presidente")]
        VicePresidente

    }
}
