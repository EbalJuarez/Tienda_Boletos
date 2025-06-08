using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;
using PaginaDeBoletos;
using PaginaDeBoletos.Clases;
namespace Bolx.Clases
{
    public class Cancelar
    {
        [Required(ErrorMessage = "El nombre es obligatorio.")]
        public string? nombre { get; set; }

        [Required(ErrorMessage = "El número correlativo es obligatorio.")]
        [StringLength(8, MinimumLength = 8, ErrorMessage = "El número correlativo debe tener exactamente 8 dígitos.")]
        [RegularExpression(@"^\d{8}$", ErrorMessage = "El número correlativo debe ser numérico y tener 8 dígitos.")]
        public string? no_correlativo { get; set; }

        public static Stack<Cancelar> Pila_Cancelacion = new Stack<Cancelar>();
        
    }
}   

