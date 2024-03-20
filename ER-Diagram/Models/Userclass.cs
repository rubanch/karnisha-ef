using System.ComponentModel.DataAnnotations;

namespace ER_Diagram.Models
{
    public class Userclass
    {
        [Key]
        public int User_Id {  get; set; }
        public string User_Name { get; set; }
        public string User_Email { get; set;}
        public string User_Password { get; set;}
    }
}
