using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cpa_ifmg.Models
{
    [Table("Campus")]
    public class Campus
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string name { get; set; }
        [Required]
        public int PropostaId { get; set; }
        public Proposta Proposta { get; set; }
    }
}
