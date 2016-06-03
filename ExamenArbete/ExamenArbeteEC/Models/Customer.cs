using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ExamenArbeteEC.Models
{
    public class Customer
    {

        public int Id { get; set; }

    }

    public class LogOnModel
    {
        [Required]
       
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
      
        public string Password { get; set; }

       
        public bool RememberMe { get; set; }
    }

    public class RegisterModel
    {
        [Required]
     
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
      
        public string Email { get; set; }

        [Required]
      
        [DataType(DataType.Password)]
      
        public string Password { get; set; }

        [DataType(DataType.Password)]
       
        public string ConfirmPassword { get; set; }
    }

    public class ChangePasswordModel
    {
        [Required]
        [DataType(DataType.Password)]
     
        public string OldPassword { get; set; }

        [Required]
      
        [DataType(DataType.Password)]
       
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
       
        public string ConfirmPassword { get; set; }
    }

}