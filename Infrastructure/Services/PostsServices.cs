using System.Runtime.Intrinsics.X86;
using Domain.Models;
namespace Infrastructure.Services;

public class PostsServices
{
    List<Posts> posts = new List<Posts>();
    public List<Posts> GetPosts(){
        return posts;
    }
    public void AddPosts(Posts posts){
        this.posts.Add(posts);
    }
    public string UpdatePosts(Posts posts){
        foreach (var item in this.posts)
        {
            if(item.Id == posts.Id){
                item.Title = posts.Title;
                item.Description = posts.Description;
                item.VoteAmount = posts.VoteAmount;
                item.CreatedAi = posts.CreatedAi;
               return "Student deleted soccessfully";
            }
        }
        return "Student not found";
    }
    public string DeletePosts(int id){
        for (int i = 0; i < posts.Count; i++)
       {
        if(id==posts[i].Id){
            posts.Remove(posts[i]);
            return "Student delete";
        }
       }
       return "Student not found";;
    }
}