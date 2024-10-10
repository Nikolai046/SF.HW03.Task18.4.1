using SF.HW03.Task18._4._1.BLL;
using SF.HW03.Task18._4._1.BLL.Commands;
using SF.HW03.Task18._4._1.PLL.Handlers;
using YoutubeExplode;

namespace SF.HW03.Task18._4._1.PLL;

/// <summary>
/// Класс UserInterface управляет взаимодействием с пользователем, предоставляя ему варианты получения информации о видео или скачивания.
/// </summary>
public class UserInterface
{
    private YoutubeClient youtubeClient;
    private CommandInvoker invoker;
    private string VideoUrl;
    private OutputPathInputHandler outputPathHandler;

    /// <summary>
    /// Конструктор инициализирует интерфейс с URL видео и необходимыми объектами.
    /// </summary>
    public UserInterface(string videoUrl)
    {
        youtubeClient = new YoutubeClient();
        invoker = new CommandInvoker();
        VideoUrl = videoUrl;
        outputPathHandler = new OutputPathInputHandler();
    }

    /// <summary>
    /// Метод Run предоставляет пользователю цикл для выбора действия: получить информацию о видео или скачать видео.
    /// </summary>
    public void Run()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("\nВыберите действие:");
            Console.WriteLine("1. Получить информацию о видео");
            Console.WriteLine("2. Скачать видео");
            Console.WriteLine("3. Выход");

            switch (Console.ReadKey().KeyChar)
            {
                case '1':
                    var infoCommand = new GetVideoInfoCommand(VideoUrl, youtubeClient);

                    invoker.SetCommand(infoCommand);
                    invoker.ExecuteCommand();

                    Console.WriteLine("\n Для продолжения нажмите любуую кнопку...");
                    Console.ReadKey();
                    break;

                case '2':
                    string outputPath = outputPathHandler.GetInput();
                    var downloadCommand = new DownloadVideoCommand(VideoUrl, outputPath, youtubeClient);

                    invoker.SetCommand(downloadCommand);
                    invoker.ExecuteCommand();

                    Console.WriteLine("\n Для продолжения нажмите любуую кнопку...");
                    Console.ReadKey();
                    break;

                case '3':
                    return;
            }
        }
    }
}