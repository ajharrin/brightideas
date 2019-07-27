using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BrightIdeas.Models
{
    public class Idea
    {
        [Key]
        public int IdeaId{get;set;}
        [Required (ErrorMessage = "Please enter an idea")]
        [MinLength(5, ErrorMessage = "An Idea must be atleast 5 characters long")]
        public string Post{get;set;}
        public int UserId{get;set;}
        public User Poster{get;set;}

        public List<Like> UsersLiking{get;set;}

        public void Display()
        {
            System.Console.WriteLine($"{Post}");
        }
    }
}