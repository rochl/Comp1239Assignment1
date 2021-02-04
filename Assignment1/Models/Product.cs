using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Assignment1.Models
{
    public class Product
    {
        
        public int Code { get; set; }
        [Required(ErrorMessage = "Please enter a product name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter a product price.")]
        public decimal Price { get; set; }

        public Product()
        {

        }
    }
}
