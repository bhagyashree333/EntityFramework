using EntityFrameworkProj1.Data_Access.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkProj1.Data_Access
{
    public class StudentContextClass : DbContext
    {
        public DbSet<Student> Student { get; set; }
        public  DbSet<Subject> Subject { get; set; }

        public DbSet<Marks> Marks { get; set; }

        public DbSet<Course> Courses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=WAIDESK01\MSSQLSERVER01;Initial Catalog=Bk1;Integrated Security=True");
        }

    }
}
