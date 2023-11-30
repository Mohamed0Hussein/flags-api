namespace FlagsApi.Models
{
    public class RegionalBloc
    {
        public int Id { get; set; }
        public string? Acronym { get; set; }
        public string? Name { get; set; }
        public Country? Country { get; set; }    
    }
}
