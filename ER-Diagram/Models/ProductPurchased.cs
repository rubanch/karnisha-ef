using System.ComponentModel.DataAnnotations;

namespace ER_Diagram.Models
{
    public class ProductPurchased
    {
        [Key]
        public int ProductPurchased_Id { get; set;}
        public string product_name {  get; set;}
        public string  Price_productPurchased { get; set;}

    }
}
