using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cpa_ifmg.Models
{
    [Table("Campus")]
    public class Campus
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        
        public int PropostaId { get; set; }
        public Proposta Proposta { get; set; }

        public ICollection<CampusCurso> Cursos{ get; set; }
        public ICollection<Usuario> Usuarios { get; set; }
    }
}
