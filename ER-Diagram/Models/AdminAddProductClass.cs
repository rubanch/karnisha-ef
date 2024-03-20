using System.ComponentModel.DataAnnotations;

namespace ER_Diagram.Models
{
    public class AdminAddProductClass
    {
        [Key]
        public int AdminAddProduct_ID {  get; set; }
        public string Product_name{get;set;}
        public string Product_description { get;set;}
        public string Product_price { get;set;}
    }
}
