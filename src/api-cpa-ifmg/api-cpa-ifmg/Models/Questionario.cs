using System.ComponentModel.DataAnnotations.Schema;

namespace api_cpa_ifmg.Models
{
    [Table("Questionario")]
    public class Questionario
    {
        public ICollection<Indicador> Indicadores { get; set;}
        public ICollection<Eixo> Eixos { get; set; }
        public ICollection<Ciclo> Ciclos { get; set; }
    }
}
