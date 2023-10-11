using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace api_cpa_ifmg.Models
{
    public class UsuarioDto
    {
        
        public int? Id { get; set; }
        [Required]
        public Perfil Perfil { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string CPF { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Senha { get; set; }
        public int CampusId { get; set; }
        public Campus Campus { get; set; }
    }
}
