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

        public ICollection<Campus> Campi { get; set; }
        public ICollection<Membro> Membros { get; set; }
        public ICollection<Melhoria> Melhorias { get; set; }
        public ICollection<Meta> Metas { get; set; }
        public ICollection<Cronograma> Cronogramas { get; set; }



    }
    public enum TipoProposta
    {
        [Display(Name = "Cadastro Membros")] 
        CadastroMembros,
        [Display(Name = "Relatório")]
        Relatorio
    }
    public enum SituacaoProposta
    {
        [Display(Name = "Em elaboração")] 
        Elaboracao,
        [Display(Name = "Efetivada")]
        Efetivada,
        [Display(Name = "Enviada")]
        Enviada
    }
}
