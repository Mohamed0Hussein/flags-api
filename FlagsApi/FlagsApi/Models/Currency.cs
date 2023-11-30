namespace FlagsApi.Models
{
    public class Currency
    {
        public int Id { get; set; }
        public string? Code { get; set; }
        public string? Name { get; set; }
        public string? Symbol { get; set; }
        public List<Country>? Countries { get; set; }
    }
}
