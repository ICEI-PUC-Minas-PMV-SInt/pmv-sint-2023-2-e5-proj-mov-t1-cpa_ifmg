using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cpa_ifmg.Models
{
    [Table("Metas e Ações")]
    public class Meta
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Descricao { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{dd-MM-yyyy}")]
        public DateTime Data_Inicio { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{dd-MM-yyyy}")]
        public DateTime Data_Termino { get; set; }
        [Required]
        public string Atividade { get; set; }
        [Required]
        public Responsavel Responsavel { get; set; }
        [Required]
        public string Situacao { get; set; }
        public int PropostaId { get; set; }
        public Proposta Proposta { get; set; }

    }
    public enum Responsavel
    {
        [Display(Name = "CPA Local")]
        CPALocal,
        [Display(Name = "CPA Central")]
        CPACentral
    }
}
