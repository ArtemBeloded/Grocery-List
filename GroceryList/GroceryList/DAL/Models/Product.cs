
namespace GroceryList.DAL.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int Quantity { get; set; }

        public Units units { get; set; }
    }
}
