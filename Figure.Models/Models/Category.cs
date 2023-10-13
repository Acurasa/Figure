using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FigureModel.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string  Name { get; set; }
        [DisplayName("Display Order")]
        [Range(1,100,ErrorMessage="Display order must be in range between 1-100")]
        public int DisplayOrder { get; set; }
    }
}
