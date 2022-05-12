// See https://aka.ms/new-console-template for more information
using EntityFrameworkProj1.Data_Access.Services;

Console.WriteLine("Hello, World!");

CourseManagement course = new CourseManagement();
course.select();
//course.AddCourse();
course.UpdateCourse();

//MarksManagement m11 = new MarksManagement();
//m11.select();

//StudentManagement stud1=new StudentManagement();
//stud1.select();

//SubjectManagement submanagement=new SubjectManagement();
//submanagement.select();
