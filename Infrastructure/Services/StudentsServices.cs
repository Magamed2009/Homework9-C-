using Domain.Models;

namespace Infrastructure.Services;

public class StudentsServices
{
    List<Students> student = new List<Students>();
    public List<Students> GetStudents()
    {
        return student;
    }
    public void AddStudents(Students students)
    {
        student.Add(students);
    } 
    public string UpdateStudents(Students students)
    {
        foreach (var item in student)
        {
            if(item.Id == students.Id)
            {
                item.FirstName = students.FirstName;
                item.LastName = students.LastName;
                item.BirthDate = students.BirthDate;
                item.Adress = students.Adress;
                return "Student update";
            }
        }
            return "Student not found";
    }
    public string DeleteStudents(int id)
    {
       for (int i = 0; i < student.Count; i++)
       {
        if(id==student[i].Id){
            student.Remove(student[i]);
            return "Student delete";
        }
       }
       return "Student not found";
    }
}