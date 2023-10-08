using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cpa_ifmg.Models
{
    [Table("Melhorias")]
    public class Melhoria
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string PropostaDeMelhoria { get; set; }
        [Required]
        public Status Status { get; set; }
        [Required]
        public string Observacao { get; set; }
        public int DimensaoId { get; set; }
        public Dimensao Dimensao { get; set; }
        public int PropostaId { get; set; }
        public Proposta Proposta { get; set; }
    }
    public enum Status
    {
        [Display(Name = "Não Iniciado")]
        NaoIniciado,
        [Display(Name = "Parcialmente Implementado")]
        ParcialmenteImplementado,
        [Display(Name = "Implementado")]
        Implementado,
        [Display(Name = "Não Implementado")]
        NaoImplementado
    }
}
