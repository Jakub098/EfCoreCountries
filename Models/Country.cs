
namespace CountryApp.Models
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Capital Capital { get; set; }
        public List<City> Cities { get; set; }
    }
}
