using System;
using Microsoft.EntityFrameworkCore;
using Produt_Management.Models;

namespace Produt_Management.Extentions
{
    public static class ModelBuilderExtentions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product() { Id = 1, Name = "Product_1", Price = 1000, InStock = InStock.No, Photo = "/Images/p1.png" },
                new Product() { Id = 2, Name = "Product_2", Price = 2000, InStock = InStock.Yes, Photo = "/Images/p2.png" }
                );
        }
    }
}
