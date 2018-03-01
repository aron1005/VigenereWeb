using System.ComponentModel.DataAnnotations;

namespace VigenereWeb.Models
{
    public class VigenereViewModel
    {
        [Required]
        public string Mensaje { get; set; }

        [Required]
        [MinLength(1)]
        public string Clave { get; set; }
    }

}