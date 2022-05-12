using EntityFrameworkProj1.Data_Access.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkProj1.Data_Access.Services
{
    public class MarksManagement
    {
        public void select()
        {
            using (var context = new StudentContextClass())
            { 
              var markobj=context.Marks.Include("Student").Include("Subject").ToList();

                Console.WriteLine("--------------------------------------------------------");
                foreach(var m in markobj)
                {
                    Console.WriteLine($"{m.Student.Rollno}|{m.Student.Name}|{m.Subject.Sub_Title}|{m.marks}");
                }
                Console.WriteLine("--------------------------------------------------------");
            }
        }

        public void AddMarks()
        {
            var context = new StudentContextClass();
            Console.WriteLine("Enter student roll no,Subject id,marks");
            int nrollno = int.Parse(Console.ReadLine());
   
            int sub_id = int.Parse(Console.ReadLine());
            int newmarks=int.Parse(Console.ReadLine());

            var marks = new Marks
            {

                Studentid=nrollno,
                Sub_id=sub_id,
                marks=newmarks,


            };
            context.Marks.Add(marks);
            context.SaveChanges();
            context.Dispose();

        }

        public void Updatemark()
        {
            Console.WriteLine("Enter mark id to be updated");

            int studidtobeupdated = int.Parse(Console.ReadLine());

            using var context = new StudentContextClass();

            var mark = context.Marks.FirstOrDefault(x => x.Studentid == studidtobeupdated);
            if (mark == null)
            {
                Console.WriteLine($"Person with id={studidtobeupdated} not found");
                return;
            }

            Console.WriteLine("Enter New Course code");
            string ncoursecode = Console.ReadLine();
            Console.WriteLine("Enter New course Title");
            string ncoursetitle = Console.ReadLine();
            Console.WriteLine("Enter New Course Description");
            string ncoursedescription = Console.ReadLine();

            course.Course_code = ncoursecode;
            course.course_Title = ncoursetitle;
            course.Course_description = ncoursedescription;

            context.Courses.Update(course);
            context.SaveChanges();

            select();

        }
    }
}
