namespace FlagsApi.Models
{
    public class Border
    {
        public int Id { get; set; }
        public string? border { get; set; }
        public Country Country { get; set; }
        public int CountryId { get; set; }
    }
}
