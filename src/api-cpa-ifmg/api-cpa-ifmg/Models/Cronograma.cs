using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cpa_ifmg.Models
{
    [Table("Cronograma")]
    public class Cronograma
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string DescricaoDasAtividades { get; set; }
        [Required]
        public Situacao Situacao { get; set; }
        public ResponsavelCronograma ResponsavelCronograma { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{dd-MM-yyyy}")]
        public DateTime Data_Inicio { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{dd-MM-yyyy}")]
        public DateTime Data_Termino { get; set; }
        public string Procedimentos { get; set; }
        public int PropostaId { get; set; }
        public Proposta Proposta { get; set; }

    }
    public enum Situacao
    {
        AFazer,
        EmAndamento,
        Concluido

    }
    public enum ResponsavelCronograma
    {
        CPALocal,
        CPACentral
    }
}
