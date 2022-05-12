using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkProj1.Data_Access.Models
{
    [Table("Course", Schema = "course")]
    public class Course
    {
       public string Course_code { get; set; }
        public string course_Title { get; set; }
        public string Course_description { get; set; }  
        [Key]
        public int Course_id { get; set; }  
    }
}
