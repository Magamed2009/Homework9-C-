using Domain.Models;

using Infrastructure.Services;

var st1 = new Students();
 st1.FirstName = "Maga";
 st1.LastName = "maga";
 st1.Id = 1;
 st1.BirthDate = new DateTime(2009,03,03);
 st1.Adress = "N.Sino";

 var st2 = new Students();
 st2.FirstName = "Magamed";
 st2.LastName = "magamed";
 st2.Id = 2;
 st2.BirthDate = new DateTime(2009,03,03);
 st2.Adress = "N.Sino";

 var StudentsServices = new StudentsServices();
 StudentsServices.AddStudents(st1);
 StudentsServices.AddStudents(st2);
 var st3 = new Students();
 st3.FirstName = "Magamedov";
 st3.LastName = "magamedov";
 st3.Id = 2;
 st3.BirthDate = new DateTime(2009,03,03);
 st3.Adress = "N.Sino";
 StudentsServices.UpdateStudents(st3);
 foreach (var st in StudentsServices.GetStudents())
 {
    System.Console.WriteLine(st.Id);
    System.Console.WriteLine(st.FirstName);
    System.Console.WriteLine(st.LastName);
    System.Console.WriteLine(st.Adress);
    System.Console.WriteLine(st.BirthDate);
    System.Console.WriteLine("-------------------------");
 }
 StudentsServices.DeleteStudents(2);
 
  foreach (var st in StudentsServices.GetStudents())
 {
    System.Console.WriteLine(st.Id);
    System.Console.WriteLine(st.FirstName);
    System.Console.WriteLine(st.LastName);
    System.Console.WriteLine(st.Adress);
    System.Console.WriteLine(st.BirthDate);
    System.Console.WriteLine("-------------------------");
 }
var t1 = new Teachers();
 t1.FirstName = "Maga";
 t1.LastName = "maga";
 t1.Id = 1;
 t1.Position = "June1";
 t1.ExperienceAmount = 12;

 var t2 = new Teachers();
 t2.FirstName = "Magamed";
 t2.LastName = "magamed";
 t2.Id = 2;
 t2.Position = "June1";
 t2.ExperienceAmount = 12;

 var teachersServices = new TeachersServices();
 teachersServices.AddTeachers(t1);
 teachersServices.AddTeachers(t2);
 var t3 = new Teachers();
 t3.FirstName = "Magamedov";
 t3.LastName = "magamedov";
 t3.Id = 2;
 t3.Position = "June1";
 t3.ExperienceAmount = 12;
 teachersServices.UpdateTeachers(t3);
 foreach (var st in teachersServices.GetTeachers())
 {
    System.Console.WriteLine(st.Id);
    System.Console.WriteLine(st.FirstName);
    System.Console.WriteLine(st.LastName);
    System.Console.WriteLine(st.Position);
    System.Console.WriteLine(st.ExperienceAmount);
    System.Console.WriteLine("-------------------------");
 }
 teachersServices.DeleteTeacher(2);
 
  foreach (var st in teachersServices.GetTeachers())
 {
    System.Console.WriteLine(st.Id);
    System.Console.WriteLine(st.FirstName);
    System.Console.WriteLine(st.LastName);
    System.Console.WriteLine(st.Position);
    System.Console.WriteLine(st.ExperienceAmount);
    System.Console.WriteLine("-------------------------");
 }
 var p1 = new Posts();
 p1.Title = "Maga";
 p1.Description = "maga";
 p1.Id = 1;
 p1.VoteAmount = 1;
 p1.CreatedAi = new DateTime(2009,03,03);

 var p2 = new Posts();
 p2.Title = "Magamed";
 p2.Description = "magamed";
 p2.Id = 2;
 p2.VoteAmount = 1;
 p2.CreatedAi = new DateTime(2009,03,03);

 var postsServices = new PostsServices();
 postsServices.AddPosts(p1);
 postsServices.AddPosts(p2);
 var p3 = new Posts();
 p3.Title = "Magamedov";
 p3.Description = "magamedov";
 p3.Id = 2;
 p3.VoteAmount = 1;
 p3.CreatedAi = new DateTime(2009,03,03);
 postsServices.UpdatePosts(p3);
 foreach (var st in postsServices.GetPosts())
 {
    System.Console.WriteLine(st.Id);
    System.Console.WriteLine(st.Title);
    System.Console.WriteLine(st.Description);
    System.Console.WriteLine(st.VoteAmount);
    System.Console.WriteLine(st.CreatedAi);
    System.Console.WriteLine("-------------------------");
 }
 postsServices.DeletePosts(2);
 
  foreach (var st in postsServices.GetPosts())
 {
    System.Console.WriteLine(st.Id);
    System.Console.WriteLine(st.Title);
    System.Console.WriteLine(st.Description);
    System.Console.WriteLine(st.VoteAmount);
    System.Console.WriteLine(st.CreatedAi);
    System.Console.WriteLine("-------------------------");
 }
var c1 = new Courses();
 c1.Title = "Maga";
 c1.Description = "maga";
 c1.Id = 1;
 c1.Fee = 1;
 c1.HasDiscount = true;

 var c2 = new Courses();
 c2.Title = "Magamed";
 c2.Description = "magamed";
 c2.Id = 2;
 c2.Fee = 1;
 c2.HasDiscount = true;

 var coursesServices = new CoursesServices();
 coursesServices.AddCourses(c1);
 coursesServices.AddCourses(c2);
 var c3 = new Courses();
 c3.Title = "Magamedov";
 c3.Description = "magamedov";
 c3.Id = 2;
 c3.Fee = 1;
 c3.HasDiscount = true;
 coursesServices.UpdateCourses(c3);
 foreach (var st in coursesServices.GetCourses())
 {
    System.Console.WriteLine(st.Id);
    System.Console.WriteLine(st.Title);
    System.Console.WriteLine(st.Description);
    System.Console.WriteLine(st.Fee);
    System.Console.WriteLine(st.HasDiscount);
    System.Console.WriteLine("-------------------------");
 }
 coursesServices.DeleteCourses(2);
 
  foreach (var st in coursesServices.GetCourses())
 {
    System.Console.WriteLine(st.Id);
    System.Console.WriteLine(st.Title);
    System.Console.WriteLine(st.Description);
    System.Console.WriteLine(st.Fee);
    System.Console.WriteLine(st.HasDiscount);
    System.Console.WriteLine("-------------------------");
 }