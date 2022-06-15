using System.ComponentModel.DataAnnotations;

namespace DevChat.Models
{
    public class PrivateMessages
    {
        [Required]
        [Key]
        public int Id { get; set; }
        [Required]
        public int userId1 { get; set; }
        [Required]
        public int userId2 { get; set; }
        [Required]
        public string Message { get; set; }
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

    }
}
