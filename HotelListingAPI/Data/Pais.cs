namespace HotelListingAPI.Data
{
    public class Pais
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string NombreCorto { get; set; }

        public virtual IList<Hotel> Hoteles { get; set; }
    }
}