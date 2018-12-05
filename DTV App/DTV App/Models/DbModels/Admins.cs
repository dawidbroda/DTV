using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DTV_App.Models.DbModels
{
    public class Admins
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]public int Id { get; set; }
        [MaxLength(50)]public string Email { get; set; }
        [MaxLength(50)] public string Name { get; set; }
        [MaxLength(50)] public string Password { get; set; }
        public int Acces { get; set; }
    }
}
