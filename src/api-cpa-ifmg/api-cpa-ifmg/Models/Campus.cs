using System.ComponentModel.DataAnnotations;

namespace api_cpa_ifmg.Models
{
    public class Campus
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string name { get; set; }
    }
}
