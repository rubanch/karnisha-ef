
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ER_Diagram.Models;

namespace ER_Diagram.Models
{
    public class Finance_management_system
    {
        [Key]
        public int finance_management_Id {  get; set; }
        
        
        
        [ForeignKey("AdminAddProduct_ID")]
        public required AdminAddProductClass adminadd {  get; set; }


        [ForeignKey("Admin_Id")]
        public required AdminClass AdminClass { get; set; }


        [ForeignKey("ProductPurchased_Id")]
        public required ProductPurchased productPurchased { get; set; }

        [ForeignKey("UserInfo_Id")]
        public required UserInfoClass UserInfoClass { get; set; }

        [ForeignKey("Admin_Id")]
        public required AdminClass adminclass { get; set; }


    }
}
