using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cpa_ifmg.Models
{
    [Table("Indicador")]
    public class Indicador
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Codigo { get; set; }
        [Required]
        public string Descricao { get; set; }
        [Required]
        public string Avaliacao { get; set; }

        public int QuestionarioId { get; set; }
        public Questionario Questionario { get; set; }
    }
}
