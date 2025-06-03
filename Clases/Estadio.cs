using Bolx.Clases;
using PaginaDeBoletos.Clases;

namespace PaginaDeBoletos
{
    public class Estadio
    {

        public static LinkedList<List<ZonasEstadio>> Zonas_Estadio { get; set; } = new LinkedList<List<ZonasEstadio>>(
            new List<List<ZonasEstadio>>
            {
                new List<ZonasEstadio> { new ZonasEstadio("Norte", 100) },
                new List<ZonasEstadio> { new ZonasEstadio("Sur", 120) },
                new List<ZonasEstadio> { new ZonasEstadio("Este", 150) },
                new List<ZonasEstadio> { new ZonasEstadio("Oeste", 80) },
                new List<ZonasEstadio> { new ZonasEstadio("VIP", 50) }
            }
        );







    }

}
