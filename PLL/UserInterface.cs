using YoutubeExplode;

public class UserInterface
{
    private readonly YoutubeClient youtubeClient;
    private readonly CommandInvoker invoker;
    private string VideoUrl;
    private readonly OutputPathInputHandler outputPathHandler;

    public UserInterface(string videoUrl)
    {
        //  youtubeClient = new YoutubeClient();
        invoker = new CommandInvoker();
        VideoUrl = videoUrl;
        outputPathHandler = new OutputPathInputHandler();
    }

    public void Run()
    {
        while (true)
        {
            DisplayMenu();
            string choice = Console.ReadLine();

            if (!HandleUserChoice(choice))
            {
                break;
            }
        }
    }

    private void DisplayMenu()
    {
        Console.WriteLine("\nВыберите действие:");
        Console.WriteLine("1. Получить информацию о видео");
        Console.WriteLine("2. Скачать видео");
        Console.WriteLine("3. Выход");
    }

    private bool HandleUserChoice(string choice)
    {
        switch (choice)
        {
            case "1":
                var infoCommand = new GetVideoInfoCommand(VideoUrl, youtubeClient);
                invoker.SetCommand(infoCommand);
                invoker.ExecuteCommand();
                return true;

            case "2":
                string outputPath = outputPathHandler.GetInput();
                var downloadCommand = new DownloadVideoCommand(VideoUrl, outputPath, youtubeClient);
                invoker.SetCommand(downloadCommand);
                invoker.ExecuteCommand();
                return true;

            case "3":
                return false;

            default:
                Console.WriteLine("Неверный выбор. Попробуйте снова.");
                return true;
        }
    }
}