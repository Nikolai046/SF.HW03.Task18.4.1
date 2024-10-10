using System.Text;

public class Program
{
    public static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        var urlHandler = new VideoUrlInputHandler();
        string videoUrl = urlHandler.GetInput();

        var ui = new UserInterface(videoUrl);
        ui.Run();
    }
}