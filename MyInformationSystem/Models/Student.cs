using System.ComponentModel.DataAnnotations;

namespace MyInformationSystem.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        public string ? Course { get; set; }

    }
}
