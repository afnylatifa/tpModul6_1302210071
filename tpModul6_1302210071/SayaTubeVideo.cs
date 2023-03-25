using System;
using System.Diagnostics.Contracts;

public class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount;

    public SayaTubeVideo(string title)
    {
        Contract.Requires(title.Length < 100);
        Contract.Requires(title.Length != null);
        this.title = title;
        var random = new Random();
        this.id = random.Next(10000, 99999);
        this.playCount = 0;
    }

    public void IncreasePlayCount(int playCount)
    {
        Contract.Requires(playCount <= 10000000);
        try
        {
            this.playCount = checked(this.playCount + playCount);
        }
        catch (OverflowException e)
        {
            Console.WriteLine("Overflow exception : " + e.Message);
        }
    }

    public void PrintVideoDetail()
    {
        Console.WriteLine("Detail video : ");
        Console.WriteLine("ID : " + id);
        Console.WriteLine("Title : " + title);
        Console.WriteLine("Play count : " + playCount);
    }
}


