using System.ComponentModel.DataAnnotations;
using System.Numerics;

namespace ER_Diagram.Models
{
    public class EMIcardForm
    {
        [Key]
        public string EMIcard_ID {  get; set; }
        public string User_name {  get; set; }
        public string User_email { get; set;}
        public BigInteger User_phone { get; set;}
        public string PAN {  get; set;}
    }
}
