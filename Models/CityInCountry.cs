namespace CountryApp.Models
{
    public class CityInCountry
    {
        public Country Country { get; set; }
        public int CountryId { get; set; }
        public City City { get; set; }
        public int CityId { get; set; }
        public DateTime PublicationDate { get; set; }

    }
}
