using System;
using System.ComponentModel.DataAnnotations;

namespace Produt_Management.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int Price { get; set; }
        [Required]
        public InStock? InStock { get; set; }
        public string Photo { get; set; }


    }
}
