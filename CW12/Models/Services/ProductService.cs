using CW12.Models.DAL;
using CW12.Models.Entity;

namespace CW12.Models.Services
{
    public class ProductService : IProductService
    {
        public int IdGenerator()
        {
            var lastId = ProductRepository.Products.Max(i => i.Id);
            return ++lastId;
        }

        public void Create(ProductViewModel productModel)
        {
            var product = new Product()
            {
                Id = IdGenerator(),
                Name = productModel.Name,
                Color = productModel.Color,
                Model = productModel.Model,
                Code = productModel.Code,
                Brand = productModel.Brand
            };

            ProductRepository.Products.Add(product);
        }
    }
}
