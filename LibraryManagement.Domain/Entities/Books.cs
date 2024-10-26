using System.ComponentModel.DataAnnotations;

namespace LibraryManagement.Domain.Entities
{
    public class Books
    {
        public int Id { get; set; }

        [Required]
        public required string Title { get; set; }

        [Required]
        public required string Author { get; set; }

        [Required]
        public required string Genre { get; set; }

        public int PublicationYear { get; set; }
    }
}
