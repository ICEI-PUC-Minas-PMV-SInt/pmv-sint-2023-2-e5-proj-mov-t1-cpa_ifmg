using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cpa_ifmg.Models
{
    [Table("Dimensão")]
    public class Dimensao
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string DescricaodaDimensao { get; set; }
        public ICollection<Melhoria> Melhorias { get; set; }
        public int EixoId { get; set; }
        public Eixo Eixo { get; set; }
    }
}
