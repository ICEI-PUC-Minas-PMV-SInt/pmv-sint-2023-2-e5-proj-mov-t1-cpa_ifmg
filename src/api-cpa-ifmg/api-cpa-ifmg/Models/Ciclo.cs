using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cpa_ifmg.Models
{
    [Table("Ciclo")]
    public class Ciclo
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{yyyy}")]
        public DateTime Ano { get; set; }
        public ICollection<Eixo> Eixos { get; set; }
        public int QuestionarioId { get; set; }
        public Questionario Questionario { get; set; }
    }
}
