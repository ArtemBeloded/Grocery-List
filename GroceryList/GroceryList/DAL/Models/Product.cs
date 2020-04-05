
using System;
using System.ComponentModel.DataAnnotations;

namespace GroceryList.DAL.Models
{
    public class Product
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Please enter name of product")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Enter numerical amount")]
        [RegularExpression("^[0-9]+$", ErrorMessage = "Enter a valid quantity")]
        public int Quantity { get; set; }

        [Required(ErrorMessage = "Please specify your unit")]
        public Units unit { get; set; }

        [Required(ErrorMessage = "Please specify date of creation")]
        public DateTime DateOfCreate { get; set; }
    }
}
