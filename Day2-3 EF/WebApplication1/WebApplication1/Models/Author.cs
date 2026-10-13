using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    [Table("Writers")]
    public class Author
    {
        public int Id { get; set; }

        [StringLength(100)]
        [Required]
        [MaxLength(150)]
        public string Name { get; set; } = string.Empty;

        public string? Country { get; set; }
    }
}
