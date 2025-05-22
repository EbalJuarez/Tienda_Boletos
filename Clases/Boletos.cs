using System;
using System.ComponentModel.DataAnnotations;

namespace PaginaDeBoletos.Clases
{
    public class Boletos
    {
        
        public int? Numero_correlativo { get; set; }
        public string? Zona { get; set; }
        [Required]
        [StringLength(36,
        ErrorMessage = "Identifier too long (16 character limit).")]
        public string? Correo { get; set; }

        [Required]
        [StringLength(6,
        ErrorMessage = "Identifier too long (16 character limit).")]
        public string? Nombre { get; set; }

        [Required]
        [StringLength(6,
         ErrorMessage = "Identifier too long (16 character limit).")]
        public string? DPI { get; set; }


        public DateTime? Fecha_Compra { get; set; }
    }
}
