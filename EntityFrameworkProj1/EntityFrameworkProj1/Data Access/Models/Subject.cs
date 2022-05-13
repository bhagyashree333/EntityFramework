using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkProj1.Data_Access.Models
{
    [Table("Subjects", Schema = "course")]
    public class Subject
    {
        public string SubCode { get; set; }
        public string Sub_Title { get; set; }
        public string Sub_Description { get; set;}

        public int Course_id { get; set; }  
        [ForeignKey("Course_id")]
        public Course Course { get; set; }
        [Key]
        public int Sub_id { get; set; }
    }
}
