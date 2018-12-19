using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DTV_App.Models.ViewModels
{
    public class LoginAdminVM
    {
        public int Id { get; set; }
        [Required] public string Login { get; set; }
        [Display(Name = "Hasło")]
        [Required] public string Password { get; set; }
    }
}
