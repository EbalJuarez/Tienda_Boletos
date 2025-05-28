using PaginaDeBoletos;
using PaginaDeBoletos.Clases;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
namespace Bolx.Clases
{
    public class Cancelar
    {
        public string? nombre { get; set; }
        public string? dpi { get; set; }

        public static Stack<Cancelar> Pila_Cancelacion = new Stack<Cancelar>();
        
    }
}   

