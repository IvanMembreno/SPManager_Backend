using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SPManager_Backend.Models
{
    [Table("Estudiante")]
    public class Estudiante
    {
        [Key]
        [StringLength(20)]
        public string CodigoEstudiante { get; set; } = string.Empty;

        [Required]
        [StringLength(100)]
        public string Nombre { get; set; } = string.Empty;

        [Required]
        [StringLength(100)]
        public string Apellido { get; set; } = string.Empty;

        [Required]
        [StringLength(100)]
        public string Facultad { get; set; } = string.Empty;

        [Required]
        [StringLength(100)]
        public string Carrera { get; set; } = string.Empty;

        [Required]
        [StringLength(10)]
        public string Ciclo { get; set; } = string.Empty;

        [Required]
        [StringLength(100)]
        [EmailAddress]
        public string Correo { get; set; } = string.Empty;

        [StringLength(15)]
        public string Telefono { get; set; } = string.Empty;

        [ForeignKey("Detalles")]
        public int IdDescripcion { get; set; }

        [Required]
        [ForeignKey("Encargado")]
        public int IdEncargado { get; set; }

        public virtual Detalle? Detalles { get; set; }
        public virtual Encargado Encargado { get; set; }
    }
}
