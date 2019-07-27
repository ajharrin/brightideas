using System;
using System.ComponentModel.DataAnnotations;



namespace BrightIdeas.Models
{
    public class LoginUser
    {
        [Required(ErrorMessage = "Email address is required")]
        [EmailAddress(ErrorMessage = "Please enter properly formatted email address.")]
        public string LoginEmail { get; set; }
        [Required(ErrorMessage = "Password is required")]
        [MinLength(8, ErrorMessage = "Password must be atleast 8 characters long")]
        public string LoginPassword { get; set; }
    }
}
