using EntityFrameworkProj1.Data_Access.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkProj1.Data_Access.Services
{
    public class SubjectManagement
    {

        public void select()
        {
            using (var context = new StudentContextClass())
            { 
               var subject=context.Subject.ToList();
                {
                    Console.WriteLine("-----------------------------------");
                    foreach(var sub in subject)
                    {
                        Console.WriteLine($"{sub.SubCode},{sub.Sub_Title},{sub.Course_id}");
                    }
                }
            }
        
        }

        public void AddSubject()
        {

            var context = new StudentContextClass();
            Console.WriteLine("Enter Subject code,subject title ,Sub Description,Course_id");
            int nsubcode = int.Parse(Console.ReadLine());
            string nsubtitle = Console.ReadLine();
            string nsubdescription = Console.ReadLine();
            int ncourseid = int.Parse(Console.ReadLine());

            var subject = new Subject
            {
                Sub_id = nsubcode,
                Sub_Title = nsubtitle,  
                Sub_Description = nsubdescription,  
                Course_id=ncourseid

            };
            context.Subject.Add(subject);
            context.SaveChanges();
            context.Dispose();


        }


    }
}
