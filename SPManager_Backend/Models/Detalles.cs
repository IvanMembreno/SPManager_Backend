using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SPManager_Backend.Models
{
    public class Detalles
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdDescripcion { get; set; }

        [Required]
        [StringLength(100)]
        public string Lugar { get; set; }

        [Required]
        [StringLength(500)]
        public string Descripcion { get; set; }

        [Required]
        [Column(TypeName = "decimal(5,2)")]
        public decimal HorasRegistradas { get; set; }
        public DateTime FechaRegistro { get; set; }

    }
}
