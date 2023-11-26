using System.Net.Mime;
namespace InheritanceDemo;

class Program
{
    static void Main(string[] args)
    {
        Post post1 = new Post("Thanks for the birthday wishes", true, "Denis");
        Post post2 = new Post("Thanks for the birthday wishes", true, "Cpr");
        Console.WriteLine(post1.ToString());
        Console.WriteLine(post2.ToString());

        ImagePost imagePost1 = new ImagePost("Check out my new shoes", "Denis", "https://images.com/shoes", true);
        Console.WriteLine(imagePost1.ToString()); 

        VideoPost videoPost1 = new VideoPost("This is a new vide", "Cpr", "https://video.com/video", true, 30);
        Console.WriteLine(videoPost1.ToString());

        videoPost1.Play();
        Console.WriteLine("Press any key to stop the video");
        Console.ReadLine();
        videoPost1.Stop();
    }
}
