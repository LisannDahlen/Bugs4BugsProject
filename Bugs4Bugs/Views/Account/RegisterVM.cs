using System.ComponentModel.DataAnnotations;

namespace Bugs4Bugs.Views.Account
{
    public class RegisterVM
    {
        [Required(ErrorMessage ="Please enter your FirstName")]
        public string FirstName { get; set; }
        
        [Required(ErrorMessage = "Please enter your LastName")]

        public string LastName { get; set; }
        [Required(ErrorMessage = "Please enter your UserName")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Please enter your E-Mail")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter your Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }


        [Required(ErrorMessage = "Please confirm your password")]
        [DataType(DataType.Password)]
        [Display(Name = "Repeat password")]
        [Compare(nameof(Password))]
        public string PasswordRepeat { get; set; }
        
    }
}
