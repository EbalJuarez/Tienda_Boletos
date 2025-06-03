using System.ComponentModel.DataAnnotations;

namespace PaginaDeBoletos.Clases
{
    public class Boletos
    {
        public static int Total_Boletos = VIP.Boletos_Vip+General.Boletos_General+MesasPlatino.Boletos_Mesas_Platino+Tribuna.Boletos_Tribuna;
        public int? Numero_correlativo { get; set; }
        public string? Zona { get; set; }
        [Required]
        [StringLength(36, ErrorMessage = "El correo no puede tener más de 36 caracteres.")]
        [RegularExpression(@"^[a-zA-Z0-9._%+-]+@gmail\.com$", ErrorMessage = "El correo debe ser una cuenta válida de Gmail.")]
        public string? Correo { get; set; }


        [Required]
        [StringLength(36,
        ErrorMessage = "Identifier too long (16 character limit).")]
        public string? Nombre { get; set; }

        [Required]
        [StringLength(13, ErrorMessage = "El DPI debe tener exactamente 13 caracteres.")]
        [MinLength(13, ErrorMessage = "El DPI debe tener exactamente 13 caracteres.")]
        public string? DPI { get; set; }


        public DateTime? Fecha_Compra { get; set; }
    }
}
