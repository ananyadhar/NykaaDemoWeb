using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System;
using System.Threading.Tasks;

namespace NykaaDemoWeb
{
    public class LoginModel
    {
        [Key]
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string User_Type { get; set; }

    }
}