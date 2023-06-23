using System.ComponentModel.DataAnnotations;

namespace session5.Models
{
    public class Login
    {
        [Required(ErrorMessage = " User Name is required ")]
        public string userName { get; set; }

        [Required(ErrorMessage = " password is required ")]
        public string Password { get; set; }
    }
}
