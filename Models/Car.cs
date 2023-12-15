using System.ComponentModel.DataAnnotations;

namespace CarShop.Models
{
    public class Car
    {
        [Key]
        public int Id { get; set; }
        public string CarBrand { get; set; }
        public string CarModel { get; set; }
        public string Price { get; set; }
        public string Available { get; set; }
    }
}
