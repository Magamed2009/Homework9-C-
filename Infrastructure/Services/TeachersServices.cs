using Domain.Models;

namespace Infrastructure.Services;

public class TeachersServices
{
    List<Teachers> teacher = new List<Teachers>();
    public List<Teachers> GetTeachers()
    {
        return teacher;
    }
    public void AddTeachers(Teachers teachers)
    {
        teacher.Add(teachers);
    } 
    public string UpdateTeachers(Teachers teachers)
    {
        foreach (var item in teacher)
        {
            if(item.Id == teachers.Id)
            {
                item.FirstName = teachers.FirstName;
                item.LastName = teachers.LastName;
                item.Position = teachers.Position;
                item.ExperienceAmount = teachers.ExperienceAmount;
                return "Teacher update";
            }
        }
            return "Teacher not found";
    }
    public string DeleteTeacher(int id)
    {
        for (int i = 0; i < teacher.Count; i++)
       {
        if(id==teacher[i].Id){
            teacher.Remove(teacher[i]);
            return "Student delete";
        }
       }
       return "Student not found";
    }
}