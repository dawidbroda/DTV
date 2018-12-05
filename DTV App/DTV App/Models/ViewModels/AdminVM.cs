using System.ComponentModel.DataAnnotations;

namespace DTV_App.Models.ViewModels
{
    public class AdminVM
    {
        public int Id { get; set; }
        [Required] [StringLength(50, MinimumLength = 3)]public string Email { get; set; }
        [Required] [StringLength(50, MinimumLength = 3)] public string Name { get; set; }
        [Required] [StringLength(50, MinimumLength = 8)] public string Password { get; set; }
        public int Acces { get; set; }
    }
}
