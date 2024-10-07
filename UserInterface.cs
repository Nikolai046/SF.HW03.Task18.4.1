using YoutubeExplode;

public class UserInterface
{
    private readonly YoutubeClient _youtubeClient;
    private readonly CommandInvoker _invoker;
    private readonly string _videoUrl;
    private readonly OutputPathInputHandler _outputPathHandler;

    public UserInterface(string videoUrl)
    {
        _youtubeClient = new YoutubeClient();
        _invoker = new CommandInvoker();
        _videoUrl = videoUrl;
        _outputPathHandler = new OutputPathInputHandler();
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
                var infoCommand = new GetVideoInfoCommand(_videoUrl, _youtubeClient);
                _invoker.SetCommand(infoCommand);
                _invoker.ExecuteCommand();
                return true;

            case "2":
                string outputPath = _outputPathHandler.GetInput();
                var downloadCommand = new DownloadVideoCommand(_videoUrl, outputPath, _youtubeClient);
                _invoker.SetCommand(downloadCommand);
                _invoker.ExecuteCommand();
                return true;

            case "3":
                return false;

            default:
                Console.WriteLine("Неверный выбор. Попробуйте снова.");
                return true;
        }
    }
}