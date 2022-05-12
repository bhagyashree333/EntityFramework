using EntityFrameworkProj1.Data_Access.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkProj1.Data_Access.Services
{
    public class CourseManagement
    {
        public void select()
        {
            using (var context = new StudentContextClass())
            {
                var courses = context.Courses.ToList();

                Console.WriteLine("-------------------------------------------------------------");
                Console.WriteLine("|Course Code|  Course Title |  Course Description|");
                foreach (var c in courses)
                {


                    Console.WriteLine($"|{c.Course_code,8}, |   {c.course_Title,-11}  | {c.Course_description,-15} |");

                    Console.WriteLine("-------------------------------------------------------------");
                }
            }
        }

        public void AddCourse()
        {
            var context = new StudentContextClass();
            Console.WriteLine("Enter Course code,course Title,Course Description");
            string ncoursecode = Console.ReadLine();
            string ncoursetitle = Console.ReadLine();
            string ncoursedescription = Console.ReadLine();

            var course = new Course
            {
                Course_code = ncoursecode,
                course_Title = ncoursetitle,
                Course_description = ncoursedescription
            };
            context.Courses.Add(course);
            context.SaveChanges();
            context.Dispose();
           select();

        }

        public void UpdateCourse()
        {
            Console.WriteLine("enter course id to be updated");

            int courseidtobeupdated = int.Parse(Console.ReadLine());

            using var context = new StudentContextClass();

            var course = context.Courses.FirstOrDefault(x => x.Course_id == courseidtobeupdated);
            if (course == null)
            {
                Console.WriteLine($"Person with id={courseidtobeupdated} not found");
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
