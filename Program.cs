public class Program
{
    public static void Main(string[] args)
    {
        var urlHandler = new VideoUrlInputHandler();
        string videoUrl = urlHandler.GetInput();

        var ui = new UserInterface(videoUrl);
        ui.Run();
    }
}