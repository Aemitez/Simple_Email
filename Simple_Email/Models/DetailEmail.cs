using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Simple_Email.Models
{
    public class DetailEmail
    {
        [Display(Name = "Email address serder")]
        [Required]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string EmailFrom { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string PasswordEmail { get; set; }
        [Display(Name = "Email address reciver")]
        [Required(ErrorMessage = "The email address is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string EmailTo { get; set; }
        [Required]
        public string Content { get; set; }
        [Required]
        public string Subject { get; set; }
        
    }
}