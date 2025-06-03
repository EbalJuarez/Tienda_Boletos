namespace Bolx.Clases
{
    public class ZonasEstadio
    {
        public string Zona { get; set; }
        public int BoletosDisponibles { get; set; }

        public ZonasEstadio(string zona, int boletosDisponibles)
        {
            Zona = zona;
            BoletosDisponibles = boletosDisponibles;
        }
    }
}
