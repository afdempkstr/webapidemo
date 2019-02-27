using System.ComponentModel.DataAnnotations;

namespace WebApiDemo.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(50)]
        [Required]
        public string Title { get; set; }

        [MaxLength(50)]
        [Required]
        public string Author { get; set; }

        [Required]
        public int PublicationYear { get; set; }
    }
}