using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cpa_ifmg.Models
{
    [Table("Proposta")]
    public class Proposta
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public TipoProposta Tipo { get; set; }
        [Required]
        public SituacaoProposta Situacao { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{dd-MM-yyyy}")]
        public DateTime Data { get; set; }

        public ICollection<Campus> Unidade { get; set; }
        
     

    }
    public enum TipoProposta
    {
        Cadastro_Membros,
        Relatorio
    }
    public enum SituacaoProposta
    {
        Elaboracao,
        Efetivada,
        Enviada
    }
}
