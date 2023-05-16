using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CountryApp.Models
{
    public partial class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Capital Capital { get; set; }
        public int CapitalId { get; set; }
    }
}
