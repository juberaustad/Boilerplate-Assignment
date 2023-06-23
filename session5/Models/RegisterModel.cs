using System.ComponentModel.DataAnnotations;

namespace session5.Models
{
    public class RegisterModel
    {

        [Required(ErrorMessage = " User Name is required ")]
        public string userName { get; set; }
        [Required(ErrorMessage = " Email is required ")]
        public string Email { get; set; }
        [Required(ErrorMessage = " password is required ")]
        public string Password { get; set; }
    }
}
