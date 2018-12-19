using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DTV_App.Models.ViewModels
{
    public class VideoVM
    {
        public int Id { get; set; }
        [Required] [StringLength(50, MinimumLength = 3)] public string Name { get; set; }
        [Required] [StringLength(150, MinimumLength = 3)] public string KeyWords { get; set; }
        public int AdminId { get; set; }
        [Required] public string ImageBase { get; set; }
        [Required] [StringLength(200, MinimumLength = 3)] public string Description { get; set; }
        [Required] [MinLength(3)]public string Link { get; set; }
    }
}
