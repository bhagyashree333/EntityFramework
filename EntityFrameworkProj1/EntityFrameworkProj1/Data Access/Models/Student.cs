using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkProj1.Data_Access.Models
{
    [Table("Student" ,Schema="student")]
    public class Student
    {
        [Key]
        public int Rollno { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
       
        public int Course_id { get; set; }
        [ForeignKey("Course_id")]
        public Course Course { get; set; }
    }
}
