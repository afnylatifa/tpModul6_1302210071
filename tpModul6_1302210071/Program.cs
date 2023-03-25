// See https://aka.ms/new-console-template for more information

public class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount;

    public SayaTubeVideo(string title)
    {
        Random random = new Random();
        this.title = title;
        id = random.Next(10000, 99999);
        playCount = 0;
    }

    public void IncreasePlayCount(int playCount)
    {
        this.playCount = playCount;
    }

    public void PrintVideoDetail()
    {
        Console.WriteLine("Detail video : ");
        Console.WriteLine("ID : " + id);
        Console.WriteLine("Title : " + title);
        Console.WriteLine("Play count : " + playCount);
    }
}

public class program
{
    static void Main(string[] args)
    {
        SayaTubeVideo sayaTubeVideo = new SayaTubeVideo("Tutorial Design By Contract - [Afny Latifa]");
        sayaTubeVideo.PrintVideoDetail();
    }
}
