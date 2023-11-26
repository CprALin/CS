class ImagePost : Post
{
    //ImagePost deriver from Post and adds a property (ImageUrl) and two Constructors
    public string? imgUrl { get; set; }

    public ImagePost(){}

    public ImagePost(string Title, string SendByUserName, string imgUrl , bool IsPublic)
    { 
        //the following properties and the GetNextId method are inherited from Post
        this.ID = GetNextId();
        this.Title = Title;
        this.SendByUserName = SendByUserName;
        this.IsPublic = IsPublic;
        
        //property of ImagePost
        this.imgUrl = imgUrl;
    }

    public override string ToString()
    {
        return String.Format($"{this.ID} - {this.Title}- {this.imgUrl} - by {this.SendByUserName}");
    }
}