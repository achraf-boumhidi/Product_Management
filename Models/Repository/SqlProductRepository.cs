using System;
using System.Collections.Generic;
using System.Linq;

namespace Produt_Management.Models.Repository
{
    public class SqlProductRepository : ICompanyRepository<Product>
    {

        private readonly AppDbContext context;

        public SqlProductRepository(AppDbContext context)
        {
            this.context = context;
        }


        public void Add(Product entity)
        {
            this.context.Products.Add(entity);
            context.SaveChanges();
        }

        public Product Delete(int id)
        {
            var product = Get(id);
            if (product != null)
            {
                this.context.Products.Remove(product);
                context.SaveChanges();
            }
            return product;
        }

        public Product Get(int id)
        {
            Product product = this.context.Products.SingleOrDefault(pro => pro.Id == id);
            return product;
        }

        public IEnumerable<Product> GetAll()
        {
            return this.context.Products;
        }

        public Product Update(Product entity)
        {
            var product = this.context.Products.Attach(entity);
            context.SaveChanges();
            product.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            return entity;
        }
    }
}
