using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cpa_ifmg.Models
{
    [Table("Eixo")]
    public class Eixo
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Tipo { get; set; }
        [Required]
        public string DescricaoDoEixo { get; set; }
        public int CicloId { get; set; }
        public Ciclo Ciclo { get; set; }
        public ICollection<Dimensao> Dimensoes { get; set; }
        public int QuestionarioId { get; set; }
        public Questionario Questionario { get; set; }

    }
}
