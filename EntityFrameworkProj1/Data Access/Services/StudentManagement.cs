using EntityFrameworkProj1.Data_Access.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkProj1.Data_Access.Services
{
    public class StudentManagement
    {
        public void select()
        {

            using (var context = new StudentContextClass())
            {
                var students = context.Student.Include("Course").ToList();
                Console.WriteLine("------------------------------------");
                foreach (var stud in students)
                {
                    Console.WriteLine($"{stud.Rollno},{stud.Email},{stud.Address},{stud.Course.Course_id}");
                    ;
                }

            }
        }

        public void AddStudent()
        {
            var context = new StudentContextClass();
            Console.WriteLine("Enter student Name,Email,Address,Course_id");
            string nsname = Console.ReadLine();
            string nsemail = Console.ReadLine();
            string nsaddress = Console.ReadLine();
            int ncourseid=int.Parse(Console.ReadLine());

            var student = new Student
            {
                
                Name = nsname,
                Email = nsemail,
                Address=nsaddress,
                Course_id=ncourseid
                 
            };
            context.Student.Add(student);
            context.SaveChanges();
            context.Dispose();

        }

    }
}
