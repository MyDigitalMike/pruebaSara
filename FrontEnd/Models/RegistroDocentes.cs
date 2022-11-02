using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FrontEnd.Models
{
    public class RegistroDocentes
    {
        [Required]
        public int Id { get; set; }
        [DisplayName("Primer Nombre")]
        [Required(ErrorMessage = "Este Campo Es Obligatorio")]
        public string? PrimerNombre { get; set; }
        [DisplayName("Segundo Nombre")]
        public string? SegundoNombre { get; set; }
        [DisplayName("Primer Apellido")]
        [Required(ErrorMessage = "Este Campo Es Obligatorio")]
        public string? PrimerApellido { get; set; }
        [DisplayName("Segundo Apellido")]
        public string? SegundoApellido { get; set; }
        [DisplayName("Telefono")]
        public string? Telefono { get; set; }
        [DisplayName("Telefono")]
        public string? Correo { get; set; }
        [DisplayName("Fecha De Nacimiento")]
        public DateTime FechaNacimiento { get; set; }

    }
}
