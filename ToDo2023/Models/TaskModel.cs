using System.ComponentModel.DataAnnotations;

namespace ToDo2023.Models
{
    public class TaskModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Description { get; set; }

        [Required]
        public bool Completed { get; set; }

        [DataType(DataType.Date)]
        [Required]
        public DateTime DueDate { get; set; }
    }
}
