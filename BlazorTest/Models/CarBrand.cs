using System.ComponentModel.DataAnnotations;

namespace BlazorTest.Models
{
    public class CarBrand
    {
        [Key]
        public int carBrandID { get; set; }
        public string carBrandName { get; set; } = string.Empty;
        public string carBrandCountry { get; set; } = string.Empty;
        public string carBrand { get; set; } = string.Empty;
        public List<CarModel> carModels { get; set; } = new List<CarModel>();
    }
}
 
