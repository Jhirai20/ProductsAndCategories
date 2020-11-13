using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;


namespace ProductsAndCategories.Models
{
    public class Product
    {
[Key]
        public int ProductID { get; set; }

        [Required(ErrorMessage = "Input cannot be blank")]
        [MaxLength(45)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Input cannot be blank")]
        public float Price { get; set; }

        [Required(ErrorMessage = "Input cannot be blank")]
        public string Description {get; set;}

        public List<Association> Categories {get; set;}

        [Required]
        public DateTime CreatedAt {get; set;} = DateTime.Now;
        [Required]
        public DateTime UpdatedAt {get; set;} = DateTime.Now;
    }
}