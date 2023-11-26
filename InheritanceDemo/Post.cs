using System.Security.AccessControl;
class Post
{
    private static int currentPostId;

    //properties 
    protected int ID {get; set;}
    protected string Title { get; set; }
    protected string SendByUserName {get; set;}
    protected bool IsPublic {get; set;}


    public Post()
    {
        this.ID = 0;
        this.Title = "First Post";
        this.IsPublic = true;
        this.SendByUserName = "Denis";
    }

    //instance contructor that has three parameters
    public Post(string Title, bool IsPublic, string SendByUserName)
    {
       this.ID = GetNextId();
       this.Title = Title;
       this.SendByUserName = SendByUserName;
       this.IsPublic = IsPublic;
    }

    protected int GetNextId()
    {
        return ++currentPostId;
    }

    public void Update(string Title, bool IsPublic)
    {
        this.Title = Title;
        this.IsPublic = IsPublic;
    }

    public override string ToString()
    {
        return String.Format($"{this.ID} - {this.Title} - by {this.SendByUserName}");
    }
}