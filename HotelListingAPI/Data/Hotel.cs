using System.ComponentModel.DataAnnotations.Schema;

namespace HotelListingAPI.Data
{
    public class Hotel
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public double Reseña { get; set; }
        [ForeignKey(nameof(PaisId))]
        public int PaisId { get; set; }
    }
}
