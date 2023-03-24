using System.ComponentModel.DataAnnotations;

namespace Bugs4Bugs.Views.Account
{
    public class LoginVM
    {
        [Required(ErrorMessage = "Please enter your UserName")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Please enter your Password")]

        public string Password { get; set; }
    }
}
