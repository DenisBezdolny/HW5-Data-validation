using System.ComponentModel.DataAnnotations;

namespace HW4.Models.Entities
{
    public class Friend
    {
       
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "Поле не может быть пустым")]
        public string FriendName { get; set; }

        [MaxLength(25)]
        public string Place { get; set; }

        [Range(0, 200)]
        public int FriendAge { get; set; }
    }
}

