

namespace FlagsApi.Models
{
    public class Latlng
    {
        public int Id { get; set; }

        public double? Lat { get; set; }
        public double? Lng { get; set; }
        public Country Country { get; set; }
        public int CountryId { get; set; }

    }
}
