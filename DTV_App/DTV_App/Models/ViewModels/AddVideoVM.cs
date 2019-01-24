using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DTV_App.Models.ViewModels
{
    public class AddVideoVM
    {
        [Required] public string NameVideo { get; set; }
        public string Description { get; set; }
        [Required] public string URL { get; set; }
        [Required] public string Image { get; set; }
        [Required] public string KeyWords { get; set; }
    }
}
