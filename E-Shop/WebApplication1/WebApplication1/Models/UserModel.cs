using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class UserModel
    {
        [DisplayName("ID")]
        [Required(ErrorMessage = "You need to enter valid id")]
        [Range(1, 999999, ErrorMessage = "You need to enter valid id")]
        public int id { get; set; }
        
        [DisplayName("UserName")]
        [Required(ErrorMessage = "You need to give us your Username")]
        [StringLength(20,ErrorMessage = "You need to enter valid Username")]
        public string user_name { get; set; }
        [DisplayName("Password")]
        [Required(ErrorMessage ="You need to give us your Password")]
        [StringLength(maximumLength: 20,ErrorMessage = "You need to enter valid Password", MinimumLength= 6)]
        public string password { get; set; }
        [DisplayName("Token")]
        [Required]
        [StringLength(maximumLength: 9999, MinimumLength= 1)]
        public string Token { get; set; }
    }
}