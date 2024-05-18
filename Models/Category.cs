using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebApplicationForWebSystem.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        [DisplayName("Category Name")]
        public string Name { get; set; }
		[DisplayName("Display Order")]
        [Range(1,1000, ErrorMessage ="Display order must be 1-1000!")]
		public int DisplayOrder { get; set; }
    }
}
