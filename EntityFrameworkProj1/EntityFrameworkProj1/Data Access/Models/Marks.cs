using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkProj1.Data_Access.Models
{
    [Table("Marks", Schema = "mark")]
    public class Marks
    {
        
        public int Studentid { get; set; }
        [ForeignKey("Studentid")]

        public Student Student { get; set; }
        public int Sub_id { get; set; }
        [ForeignKey("Sub_id")]

        public Subject Subject { get; set; }
        
        public int marks { get; set; }
        
        [Key]
        public int mark_id{ get; set; }
    }
}
