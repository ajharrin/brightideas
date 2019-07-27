using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace BrightIdeas.Models
{
    public class User
    {
        [Key]
        public int UserId{get;set;}
        [Required(ErrorMessage = "Name is required")]
        [RegularExpression(@"^[a-zA-Z'' ']+$", ErrorMessage = "Alias Should be only letters and spaces.")]
        public string Name{get;set;}
        [Required(ErrorMessage = "Alias is required")]
        [RegularExpression(@"^[a-zA-Z0-9]+$", ErrorMessage = "Alias Should be letters and numbers only.")]
        public string Alias{get;set;}
        [Required(ErrorMessage = "Email address is required")]
        [EmailAddress(ErrorMessage = "Please enter properly formatted email address.")]
        public string Email{get;set;}
        [Required(ErrorMessage = "Password is required")]
        [MinLength(8, ErrorMessage = "Password must be atleast 8 characters long")]
        public string Password{get;set;}
        [NotMapped]
        [Compare("Password", ErrorMessage = "Passwords Do Not Match")]
        [DataType(DataType.Password)]
        public string Confirm{get;set;}
        public DateTime CreatedAt{get;set;}
        public DateTime UpdatedAt{get;set;}
        public List<Idea> UserIdeas{get;set;}
        public List<Like> IdeasLiked{ get; set; }
    }
}