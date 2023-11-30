namespace FlagsApi.Models
{
    public class Flag
    {
        public int Id { get; set; }
        public string? Svg { get; set; }
        public string? Png { get; set; }
        public Country? Country { get; set; }
        public int CountryId { get; set; }
    }
}
