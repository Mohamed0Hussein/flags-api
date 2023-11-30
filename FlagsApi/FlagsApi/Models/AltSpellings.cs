namespace FlagsApi.Models
{
    public class AltSpellings
    {
        public int Id { get; set; }
        public string? AltSpelling { get; set; }

        public Country? Country { get; set; }

    }
}
