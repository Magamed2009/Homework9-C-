using Domain.Models;

namespace Infrastructure.Services;

public class CoursesServices
{
    List<Courses> course = new List<Courses>();
    public List<Courses> GetCourses(){
        return course;
    }
    public void AddCourses(Courses courses){
        course.Add(courses);
    }
    public string UpdateCourses(Courses courses){
        foreach (var item in course)
        {
            if(item.Id == courses.Id){
                item.Title = courses.Title;
                item.Description = courses.Description;
                item.Fee = courses.Fee;
                item.HasDiscount = courses.HasDiscount;
               return "Course deleted soccessfully";
            }
        }
        return "Course not found";
    }
    public string DeleteCourses(int id){
        for (int i = 0; i < course.Count; i++)
       {
        if(id==course[i].Id){
            course.Remove(course[i]);
            return "Student delete";
        }
       }
       return "Student not found";
    }
}