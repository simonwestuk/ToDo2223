using System.ComponentModel.DataAnnotations;

namespace ToDo2023.Models
{
   

    public class UserModel
    { 
        [Key]
        public Guid Id { get; set; }

        [Required, StringLength(100)]
        [Display(Name = "Firstname")]
        public string Fname { get; set; }
        
        [Required, StringLength(100)]
        [Display(Name = "Surname")]
        public string Sname { get; set; }

        [Required, EmailAddress]
        public string Email { get; set; }

        [Required, StringLength(100)]
        public string Password { get; set; }

    }
}
