using System.ComponentModel.DataAnnotations;

namespace Portafolio.web.Models
{
    public class ContactViewModel
    {
        [Required]
        public string Nombre { get; set; }
		[Required]
		public string Email { get; set; }
        public string Mensaje { get; set; }
    }
}
