using System.ComponentModel.DataAnnotations;

namespace DevChat.Models
{
    public class User
    {
        [Required]
        [Key]
        public int Id { get; set; }
        [Required]
        public string name { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string email { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime birthDate { get; set; }

    }
}
