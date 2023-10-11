using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace api_cpa_ifmg.Models
{
    [Table("Usuários")]
    public class Usuario
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public Perfil Perfil { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string CPF { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        [JsonIgnore]
        public string Senha { get; set; }
        public int CampusId { get; set; }
        public Campus Campus { get; set; }
    }
    public enum Perfil
    {
        [Display(Name = "CPA Local")]
        CPALocal,
        [Display(Name = "CPA Central")]
        CPACentral,
        [Display(Name = "Discente")]
        Discente,
        [Display(Name = "Docente")]
        Docente,
        [Display(Name = "Técnico Administrativo")]
        Tecnicoadministrativo,
        [Display(Name = "Comunidade Externa")]
        Comunidadeexterna

    }
}
