using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cpa_ifmg.Models
{
    [Table("Cursos")]
    public class Curso
    {
        public int Id { get; set; }
        [Required]
        public string Area_Atuacao { get; set; }
        [Required]
        public string Eixo_Tecnologico { get; set; }
        public ICollection<CampusCurso> Campuses { get; set; }

    }
}
