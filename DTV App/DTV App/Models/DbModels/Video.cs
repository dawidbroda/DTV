using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DTV_App.Models.DbModels
{
    public class Video
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]public int Id { get; set; }
        [Required][MaxLength(50)]public string Name { get; set; }
        [Required][MaxLength(150)] public string[] KeyWords { get; set; }
        public int AdminId { get; set; }
        [Required]public string ImageBase { get; set; }
        [Required][MaxLength(200)]public string Description { get; set; }
        [Required]public string Link { get; set; }
    }
}
