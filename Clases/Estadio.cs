using PaginaDeBoletos.Clases;
using System.Collections.Generic;
namespace PaginaDeBoletos
{
    public class Estadio
    {
        public static List<VIP> Asientos_Vip { get; set; } = new List<VIP>(20);
        public static List<Tribuna> Asientos_Tribuna { get; set; } = new List<Tribuna>(50);
        public static List<General> Asientos_General { get; set; } = new List<General>(100);
        public static List<MesasPlatino> Asientos_MesasPlatino { get; set; } = new List<MesasPlatino>(10);

        public static LinkedList<List<Boletos>> Zonas_Estadio { get; set; } = new LinkedList<List<Boletos>>();

        static Estadio()
        {
            Zonas_Estadio.AddLast(Asientos_MesasPlatino.Cast<Boletos>().ToList());
            Zonas_Estadio.AddLast(Asientos_Vip.Cast<Boletos>().ToList());
            Zonas_Estadio.AddLast(Asientos_General.Cast<Boletos>().ToList());
            Zonas_Estadio.AddLast(Asientos_Tribuna.Cast<Boletos>().ToList());
        }
    }
}
