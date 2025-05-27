using PaginaDeBoletos.Clases;

namespace PaginaDeBoletos
{
    public static class Estadio
    {
        public static List<VIP> Asientos_Vip { get; set; } = new();
        public static List<Tribuna> Asientos_Tribuna { get; set; } = new();
        public static List<General> Asientos_General { get; set; } = new();
        public static List<MesasPlatino> Asientos_MesasPlatino { get; set; } = new();

        public static LinkedList<List<Boletos>> Zonas_Estadio { get; set; } = new();

        static Estadio()
        {
            InicializarZonas();
        }

        private static void InicializarZonas()
        {
            Zonas_Estadio.AddLast(Asientos_MesasPlatino.Cast<Boletos>().ToList());
            Zonas_Estadio.AddLast(Asientos_Vip.Cast<Boletos>().ToList());
            Zonas_Estadio.AddLast(Asientos_General.Cast<Boletos>().ToList());
            Zonas_Estadio.AddLast(Asientos_Tribuna.Cast<Boletos>().ToList());
        }
    }

}
