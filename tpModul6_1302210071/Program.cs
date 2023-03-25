// See https://aka.ms/new-console-template for more information

public class program
{
    static void Main(string[] args)
    {
        SayaTubeVideo sayaTubeVideo = new SayaTubeVideo("Tutorial Design By Contract - [Afny Latifa]");
        sayaTubeVideo.IncreasePlayCount(500);
        sayaTubeVideo.PrintVideoDetail();
        sayaTubeVideo.IncreasePlayCount(2147483647);
    }
}

