namespace FlagsApi.Models
{
    public class Translations
    {
        public int Id { get; set; }
        public string? Br { get; set; }
        public string? Pt { get; set; }
        public string? Nl { get; set; }
        public string? Hr { get; set; }
        public string? Fa { get; set; }
        public string? De { get; set; }
        public string? Es { get; set; }
        public string? Fr { get; set; }
        public string? Ja { get; set; }
        public string? It { get; set; }
        public string? Hu { get; set; }
        public Country? Country { get; set; }    
        public int CountryId { get; set; }
    }
}
