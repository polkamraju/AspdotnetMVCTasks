using System.ComponentModel.DataAnnotations;

namespace AspDotnetMVCTask4.Models
{
    public class UserNumber
    {
        [Required(ErrorMessage = "Please Input Number.")]
        [StringLength(9, MinimumLength = 9)]
        public string InputNumber { get; set; }
    }
}