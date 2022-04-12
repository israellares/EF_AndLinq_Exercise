
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EFAndLinqPractice_SchoolAPI.Models
{
    public class Course
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        public ICollection<Student>  Students { get; set; }
    }
}