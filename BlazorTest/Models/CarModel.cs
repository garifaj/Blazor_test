using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BlazorTest.Models
{
    public class CarModel
    {
        [Key]
        public required int carModelID { get; set; }
        public string modelName { get; set; } = string.Empty;
        public string modelType { get; set; } = string.Empty;
        [ForeignKey(nameof(CarBrand))]
        public int carBrandID { get; set; }
        public string carSize { get; set; } = string.Empty;
        public string ImageBase64 { get; set; } = string.Empty; // Added image column
    }
}
