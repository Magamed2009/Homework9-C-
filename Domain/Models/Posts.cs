namespace Domain.Models;

public class Posts
{
    public int  Id{ get; set; }
    public string Title{ get; set; }
    public string Description{ get; set; }
    public int VoteAmount{ get; set; }
    public DateTime CreatedAi{ get; set; }   
}