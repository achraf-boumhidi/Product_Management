using System;
using System.Collections.Generic;
using System.Linq;

namespace Produt_Management.Models.Repository
{
    public class ProductRepository : ICompanyRepository<Product> 
    {

        List<Product> Products;


        public ProductRepository()
        {
            Products = new List<Product>();
            Products.Add(new Product() { Id = 0, Name = "Product_1", Price=1000, InStock = InStock.No, Photo = "/Images/p1.png" });
            Products.Add(new Product() { Id = 1, Name = "Product_2", Price = 2300, InStock = InStock.No, Photo = "/Images/p2.png" });
            Products.Add(new Product() { Id = 2, Name = "Product_3", Price = 5100, InStock = InStock.Yes, Photo = " /Images/p3.png" });
        }

        public void Add(Product product)
        {
            product.Id = Products.Max(x => x.Id) + 1;
            product.Photo = "/Images/default.png";

            Products.Add(product);

        }

        public Product Delete(int id)
        {
            Product product = Products.Find(p => p.Id == id);
            if (product != null)
            {
                Products.Remove(product);

            }

            return product;
        }


        public Product Get(int id)
        {
            return Products.SingleOrDefault(x => x.Id == id);
        }

        public IEnumerable<Product> GetAll()
        {
            return Products;
        }

        public Product Update(Product entity)
        {
            Product product = Products.Find(p => p.Id == entity.Id);
            if (product != null)
            {
                product.Name = entity.Name;
                product.Price = entity.Price;
                product.InStock = entity.InStock;
                product.Photo = entity.Photo;

            }
            return product;
        }
    }
}
