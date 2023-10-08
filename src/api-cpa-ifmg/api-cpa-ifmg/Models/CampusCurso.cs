using System.ComponentModel.DataAnnotations.Schema;

namespace api_cpa_ifmg.Models
{
    [Table("CampusCurso")]
    public class CampusCurso
    {
        public int CampusId { get; set; }
        public Campus Campus { get; set; }
        public int CursoId { get; set; }
        public Curso Curso { get; set; }
    }
}
