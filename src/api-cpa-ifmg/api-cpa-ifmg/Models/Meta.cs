using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cpa_ifmg.Models
{
    [Table("Metas")]
    public class Meta
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Descricao { get; set; }
        [Required]        
        public string Prazo { get; set; }
        [Required]
        public string Atividade { get; set; }
        [Required]
        public Responsavel Responsavel { get; set; }
        [Required]
        public string Situacao { get; set; }

    }
    public enum Responsavel
    {
        CPA_Local,
        CPA_Central
    }
}
