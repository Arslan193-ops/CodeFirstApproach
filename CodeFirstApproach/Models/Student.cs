using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstApproach.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Column("Student Name",TypeName = "varchar(100)")]
        public string Name { get; set; }
        public int Age { get; set; }

        [Column("Student Gender", TypeName = "varchar(100)")]
        public string Gender { get; set; }
    }
}
