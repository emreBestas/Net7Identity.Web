using System.ComponentModel.DataAnnotations;

namespace Net7Identity.Web.ViewModels
{
    public class SignUpViewModel
    {
        [Required(ErrorMessage = "This field cannot be left blank")]
        [Display(Name = "User Name:")]
        public string Username { get; set; }
        [Required(ErrorMessage = "This field cannot be left blank")]
        [Display(Name = "Email:")]
        public string Email { get; set; }
        [Required(ErrorMessage = "This field cannot be left blank")]
        [Display(Name = "Phone Number:")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "This field cannot be left blank")]
        [Display(Name = "Password:")]
        public string Password { get; set; }
        [Compare(nameof(Password),ErrorMessage = "Passwords are incompatible")] 
        [Display(Name = "Confirm Password:")]
        public string ConfirmPassword { get; set; }
    }
}
