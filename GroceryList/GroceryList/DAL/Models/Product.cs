
using System;

namespace GroceryList.DAL.Models
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public int Quantity { get; set; }

        public Units units { get; set; }

        public DateTime DateOfCreate { get; set; }
    }
}
