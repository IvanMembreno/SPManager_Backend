using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;

namespace SPManager_Backend.Models
{
    public class Encargado
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        [Required]
        [StringLength(100)]
        public int IdEncargado { get; set; }

        [Required]
        [StringLength(100)]
        public string Nombre { get; set; } = string.Empty;

        [Required]
        [StringLength(100)]
        public string Apellido { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        public string? Correo { get; set; } = string.Empty;

        [StringLength(15)]
        public string TelefonoPersonal { get; set; } = string.Empty;

        [StringLength(15)]
        public string TelefonoOficina { get; set; } = string.Empty;
    }
}
