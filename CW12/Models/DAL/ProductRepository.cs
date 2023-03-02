using CW12.Models.Entity;

namespace CW12.Models.DAL
{
    public static class ProductRepository
    {
        public static List<Product> Products { get; set; } = new List<Product>
        {
            new Product()
            {
                Id = 1,
                Name = "Iphone 14",
                Color = "White",
                Model = "ModelTest",
                Code = 222,
                Brand = Brand.Iphone
            }
        };
    }
}
