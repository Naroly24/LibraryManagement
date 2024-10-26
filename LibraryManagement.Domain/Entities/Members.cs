using System.ComponentModel.DataAnnotations;

namespace LibraryManagement.Domain.Entities
{
    public class Members
    {
        public int Id { get; set; }

        [Required]
        public required string Name { get; set; }

        [Required]
        public required string Email { get; set; }
    }
}
