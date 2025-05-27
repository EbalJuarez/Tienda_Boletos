using System.ComponentModel.DataAnnotations;

namespace PaginaDeBoletos.Clases
{
    public class Boletos
    {
        public static int Total_Boletos = VIP.Total_Boletos+General.Total_Boletos+MesasPlatino.Total_Boletos+Tribuna.Total_Boletos;
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
