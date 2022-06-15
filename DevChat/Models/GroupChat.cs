using System.ComponentModel.DataAnnotations;

namespace DevChat.Models
{
    public class GroupChat
    {
        [Required]
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Category { get; set; }
    }
}
