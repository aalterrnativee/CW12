using System.ComponentModel.DataAnnotations;

namespace CW12.Models.Entity
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public string Model { get; set; }
        public int Code { get; set; }
        public Brand Brand { get; set; }
    }
}
