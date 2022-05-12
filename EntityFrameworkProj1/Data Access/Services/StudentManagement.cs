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
                Console.WriteLine("-------------------------------------------------------------");
                Console.WriteLine("|Student Roo no|  Stud Email |  stud Address | sud Course_id");
                foreach (var stud in students)
                {
                    Console.WriteLine($"{stud.Rollno},{stud.Email},{stud.Address},{stud.Course.Course_id}");
                    ;
                }
                Console.WriteLine("-------------------------------------------------------------");
            }
        }

        public void AddStudent()
        {
            var context = new StudentContextClass();
            Console.WriteLine("Enter student Name,Email,Address,Course_id");
            string nsname = Console.ReadLine();
            string nsemail = Console.ReadLine();
            string nsaddress = Console.ReadLine();
            int ncourseid = int.Parse(Console.ReadLine());

            var student = new Student
            {

                Name = nsname,
                Email = nsemail,
                Address = nsaddress,
                Course_id = ncourseid

            };
            context.Student.Add(student);
            context.SaveChanges();
            context.Dispose();

        }

        public void UpdateStudent()
        {
            Console.WriteLine("Enter student Roll no ");



            int studidtobeupdated = int.Parse(Console.ReadLine());



            using var context = new StudentContextClass();



            var student = context.Student.FirstOrDefault(s => s.Rollno == studidtobeupdated);
            if (student == null)
            {
                Console.WriteLine($"Person with id={studidtobeupdated} not found");
                return;
            }



            Console.WriteLine("Enter New Student Name");
            string nstudname = Console.ReadLine();



            Console.WriteLine("Enter New Student Email");
            string nstudemail = Console.ReadLine();



            Console.WriteLine("Enter New Student Addresss");
            string nstudaddress = Console.ReadLine();



            Console.WriteLine("Enter Courseid");
            int ncourseid = int.Parse(Console.ReadLine());





            student.Name = nstudname;
            student.Email = nstudemail;
            student.Address = nstudaddress;
            student.Course_id = ncourseid;



            context.Student.Update(student);
            context.SaveChanges();



            select();




        }

    }
}
