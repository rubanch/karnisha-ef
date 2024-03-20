using System.ComponentModel.DataAnnotations;

namespace ER_Diagram.Models
{
    public class AdminClass
    {
        [Key]
        public int Admin_Id {  get; set; }
        public string Admin_Name {  get; set; }
        public string Admin_Email {  get; set; }
        public string Admin_Password { get; set;}
    }
}
