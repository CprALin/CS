
class VideoPost : Post
{
    //member fields
    protected bool isPlaying {get; set;}
    protected int currDuration = 0;
    Timer? timer;
    //properties
    protected string? videoUrl {get; set;}
    protected int length {get; set;}
    public VideoPost() {}
    
    public VideoPost(string Title, string SendByUserName, string videoUrl, bool IsPublic, int length)
    {
        this.ID = GetNextId();
        this.Title = Title;
        this.SendByUserName = SendByUserName;
        this.IsPublic = IsPublic;

        this.videoUrl = videoUrl;
        this.length = length;
    }

    public override string ToString()
    {
        return String.Format($"{this.ID} - {this.Title}- {this.videoUrl} - by {this.SendByUserName} - length {this.length}");
    }

    public void Play()
    {
        if(!isPlaying)
        {
            isPlaying = true;
            Console.WriteLine("Playing");
            timer = new Timer(TimerCallback, null, 0 , 1000);
        }
    }

    private void TimerCallback(Object? o)
    {
        if(currDuration < length)
        {
            currDuration++;
            Console.WriteLine($"Video at {currDuration} s");
            GC.Collect(); 
        }else{
            Stop();
        }
    }

    public void Stop()
    {
       if(isPlaying)
       {
         isPlaying = false;
         Console.WriteLine($"Stopped at {currDuration} s");
         currDuration = 0;
         timer.Dispose();
       }
    }

}