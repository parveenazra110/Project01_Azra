using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace POSSystem.Models
{
    public class User
    {
        [Display(Name = "Email ID")]
        [DataType(DataType.EmailAddress)]
        [Required]
        public string EmailId { get; set; }

        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        [Required]
        public string Password { get; set; }
    }

}