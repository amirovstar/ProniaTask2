using System;
using System.ComponentModel.DataAnnotations;

namespace ProniaNew.Models
{
    public class ProductImage : BaseEntity
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public int ProductId { get; set; }
        public Product? Product { get; set; }
    }
}

